Imports Microsoft.Reporting.WinForms
Imports System.Text
Public Class frmHacer_Venta


    ' Estas variables son las que se encargaran de gestionar la informacion de la base de datos!
    Public producto As Producto
    Public empleado As Empleado
    Private Conexion As New Conexion()

    'Esta funcion se encarga de colocar la informacion del producto en pantalla 
    Public Sub ImprimirProducto()
        TextBox7.Text = producto.Nombre
        TextBox8.Text = producto.Administracion
        TextBox9.Text = producto.Precio
        TextBox10.Text = producto.Cantidad
        NumericUpDown1.Value = 1
        NumericUpDown1.Maximum = producto.Cantidad
        NumericUpDown1.Minimum = 1
    End Sub

    ' Esta funcion se encargara de actualizar el precio de la factura
    Private Sub ActualizarPrecio()
        Dim precio As Decimal = 0.0
        For Each fila As DataGridViewRow In DataGridView1.Rows
            precio = precio + Convert.ToDecimal(fila.Cells(4).Value)
        Next
        TextBox6.Text = precio
    End Sub

    Private Sub frmHacer_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lb_codigoEmpleado.Text = empleado.Cedula
        lb_nombreEmpleado.Text = empleado.Nombre
        ImprimirProducto()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    ' En este evento, cuando el valor del NumericUpDown1 sea cambiado, se multipicara el precio base del producto por el numero seleccionado
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        TextBox9.Text = producto.Precio * NumericUpDown1.Value
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_BuscarCodigoID.Click
        If Me.Validate And txt_BuscarCodigoID.Text = String.Empty Then
            MsgBox("Ingrese datos en el campo")
        Else
            producto = New Producto(txt_BuscarCodigoID.Text)
            If producto.vacio() Then
                MsgBox("Este producto no existe!")
            Else
                ImprimirProducto()
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_BuscarCliente.Click
        ' AQUI es el boton de buscar, verifica que el campo de la cedula no este vacio 
        If txt_DniCliente.Text = String.Empty Then
            MsgBox("Ingrese datos en este campo")
        Else
            verificarCliente()
        End If
    End Sub

    Private Sub verificarCliente()
        If Conexion.Verificacion("Clientes", "CEDULA = " & txt_DniCliente.Text) Then
            Try
                Conexion.Conexion.Open()
                Conexion.Comando = New OleDb.OleDbCommand("SELECT * FROM Clientes WHERE CEDULA =" & txt_DniCliente.Text, Conexion.Conexion)
                Conexion.Lector = Conexion.Comando.ExecuteReader()
                While Conexion.Lector.Read()
                    txt_NombreCliente.Text = Conexion.Lector.Item(0)
                    txt_DniCliente.Text = Conexion.Lector.Item(1)
                    txt_TelefonoCLiente.Text = Conexion.Lector.Item(3)
                    txt_DireccionCliente.Text = Conexion.Lector.Item(4)
                End While
                'Msgbox("usuario Registrado con exito")
                activarDatosClientes(False)
                gb_DatosVenta.Enabled = True
            Catch ex As Exception
                MsgBox("ERROR al consultar cliente: " & ex.Message)
            Finally
                Conexion.Conexion.Close()
            End Try
        Else
            Dim x As Integer = MsgBox("ERROR USUARIO NO REGISTRADO" & vbNewLine & "¿Desea Registrar a este cliente?", vbYesNo, "Usuario no registrado")
            If x = vbYes Then
                activarDatosClientes(True)
            End If
        End If
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        If txt_DniCliente.Text <> "" And txt_DireccionCliente.Text <> "" And txt_NombreCliente.Text <> "" And txt_TelefonoCLiente.Text <> "" Then
            If txt_DireccionCliente.TextLength > 4 And txt_DniCliente.TextLength > 4 And txt_NombreCliente.TextLength > 4 And txt_TelefonoCLiente.TextLength > 4 Then
                Conexion.Cliente(txt_NombreCliente.Text, txt_DniCliente.Text, "Venezolana", txt_TelefonoCLiente.Text, txt_DireccionCliente.Text)
                verificarCliente() : gb_DatosVenta.Enabled = True
                activarDatosClientes(False)  'habilitar el restante del frm para continuar la venta
                txt_BuscarCodigoID.Focus()
                MsgBox("usuario creado con exito " & vbNewLine & "precione aceptar para continuar con la venta", vbInformation)
            Else
                MsgBox("Porfavor Rellene todos los Campos")
            End If
        Else
            ' en caso de de si esten vacios
            MsgBox("Porfavor Rellene todos los Campos")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_AgregarProducto.Click
        ' Si de casualidad se apreta el boton de Agregar, se verifica primero que la variable producto no este vacia
        ' Si la variable llega a estar vacia ocurriran muchos problemas, por eso se verifica si la propiedad producto.nombre no este vacia
        If String.IsNullOrEmpty(producto.Nombre) Then
            MsgBox("ERROR Agregar: No has seleccionado producto para agregar a la compra")
            ' Si la variable producto no tiene informacion, el flujo de ejecucion de esta funcion se rompera
            Return
        End If
        ' Esto verifica si el producto ya estaba en el DataGridView
        For Each fila As DataGridViewRow In DataGridView1.Rows
            ' Aqui recorremos fila por fila del DataGridView
            ' Verificamos si el codigo del producto es igual a la celda Codigo de la fila actual
            If Str(producto.Codigo).Trim().Equals(fila.Cells("Codigo").Value.ToString.Trim()) Then
                'Dado el caso de que exista el producto en el DataGridView, solo tendra que modificarse la cantidad comprada y el total
                fila.Cells("Cantidad").Value = NumericUpDown1.Value
                fila.Cells("Total2").Value = producto.Precio * NumericUpDown1.Value
                ' Finalmente limpiamos
                Limpiar()
                ' Una vez realizado los cambios, rompemos este evento para evitar que se ejecute el codigo de mas abajo
                Return
            End If
        Next
        ' Cada vez que se aprete el boton agregar, se enlistara un producto al DataGridView y se actualiza el precio del carrito
        DataGridView1.Rows.Add(New String() {producto.Codigo, producto.Nombre, producto.Precio, NumericUpDown1.Value, producto.Precio * NumericUpDown1.Value})
        ActualizarPrecio() : txt_BuscarCodigoID.Text = ""
        ' De ultimo limpiamos
        Limpiar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Por cada producto del DataGridView sea dobleclickeado se borrara y se actualizara el precio del carrio nuevamente
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        ActualizarPrecio()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_Pagar.Click
        ' Primero verificamos que existan registro dentro del DataGridView
        If DataGridView1.Rows.Count <= 0 Or Not producto.vacio() Then
            ' Si no existen registros, se rompera esta funcion y no se ejecutara
            MsgBox("No hay registros para pagar O debes agregar el producto al carrito")
            Return
        End If

        'TODOS LOS TEXTBOX DEBEN ESTAR RELLENOS PARA QUE NO OCURRAN ERRORES, PENDIENTE DE ESO.

        ' Para hacer la factura usaremos el dataset especificamente creado para eso
        Dim dataset As New FacturaDataSet()
        Dim datatable As New DataTable("Factura")
        Dim productos As New StringBuilder()


        ' Creamos un DataTable donde se almacenara toda la informacion de los productos 
        datatable.Columns.Add("Codigo")
        datatable.Columns.Add("Nombre")
        datatable.Columns.Add("Precio")
        datatable.Columns.Add("Cantidad")
        datatable.Columns.Add("Total")

        ' Rellenamos la DataTable con los productos indicado en el DataGridView1
        For Each fila As DataGridViewRow In DataGridView1.Rows
            Dim datos As DataRow = datatable.NewRow()
            datos("Codigo") = fila.Cells(0).Value
            datos("Nombre") = fila.Cells(1).Value
            datos("Precio") = fila.Cells(2).Value
            datos("Cantidad") = fila.Cells(3).Value
            datos("Total") = fila.Cells(4).Value
            ' Esta funcion se encarga de actualizar la cantidad disponible del producto dentro de la base de datos
            producto.ActualizarPrecio(fila.Cells(0).Value, fila.Cells(3).Value)
            productos.Append("PRODUCTO: " & fila.Cells(0).Value & " CANTIDAD: " & fila.Cells(3).Value & " PAGADO: " & fila.Cells(4).Value & " - ")
            datatable.Rows.Add(datos)
        Next

        ' Esto es para remover el ultimo " - " que queda al final del StringBuilder

        ' Eliminamos el contenido del DataSet creado especificamente para el ReportViewer
        dataset.Tables.RemoveAt(0)
        ' Le asignamos nueva tabla, que debe ser igual a la borrada anteriormente, pero con lo particular de que esta nueva tabla esta llena de datos
        dataset.Tables.Add(datatable)

        ' Registramos la venta!
        ' Esto hara que se registre en la base de datos y de una vez devuelva el numero de factura registrado!
        Dim NumeroFactura As Integer = Conexion.RegistrarCompra(txt_DniCliente.Text, "Venezolana", productos.ToString().Remove(productos.ToString().LastIndexOf(" - ")), TextBox6.Text)

        ' Aqui le damos valor a los parametros que usara el reportviewer
        Dim parametros As ReportParameter() = New ReportParameter(7) {}
        parametros(0) = New ReportParameter("NombreCliente", txt_NombreCliente.Text)
        parametros(1) = New ReportParameter("TelefonoCliente", txt_TelefonoCLiente.Text)
        parametros(2) = New ReportParameter("DireccionCliente", txt_DireccionCliente.Text)
        parametros(3) = New ReportParameter("CedulaCliente", txt_DniCliente.Text)
        parametros(4) = New ReportParameter("TotalPagar", TextBox6.Text)
        parametros(5) = New ReportParameter("CajeroNombre", empleado.Nombre & " " & empleado.Apellido)
        parametros(6) = New ReportParameter("CajeroCargo", empleado.Cargo)
        ' AQui debes agregar el numero de factura, si deseas claro. 
        ' Crea la funcion, y si no lo deseas borras este parametro 7 y le pones a la longitud del array 6 en la declaracion!
        parametros(7) = New ReportParameter("Factura", NumeroFactura)
        'parametros(8) = New ReportParameter("NacionalidadCliente", cb_NacionalidadCliente.SelectedItem)


        ' Esto sirve para registrar cliente y la factura en la base de datos



        Dim Factura As New frmVisualizarReportes()
        Factura.Parametros(parametros, dataset)
        Factura.Show()

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    '/-----------------------------------------------------------------------------------------------------------------/'
    '/- Validaciones del formulario -/'
    '/-----------------------------------------------------------------------------------------------------------------/'
    Sub validandoCampo(ByRef Objeto As Object, ByVal largo As Integer)
        If DirectCast(Objeto, TextBox).Text.Length > 0 And DirectCast(Objeto, TextBox).Text.Length < largo Then
            ' Me.ErrorProvider1.SetError(Objeto, "")
        Else
            Me.ErrorProvider1.SetError(Objeto, "ingrese un dato en esete campo") 'mensage de error
        End If
    End Sub

    Private Sub txt_DniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_DniCliente.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub txt_TelefonoCLiente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TelefonoCLiente.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub btn_BuscarCodigoID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btn_BuscarCodigoID.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub txt_BuscarCodigoID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_BuscarCodigoID.Validating
        validandoCampo(sender, 5)
    End Sub

    '/-----------------------------------------------------------------------------------------------------------------/

    Private Sub activarDatosClientes(ByVal x As Boolean)
        If x = True Then
            txt_NombreCliente.Enabled = True : txt_NombreCliente.Text = ""
            txt_NombreCliente.Focus() : btn_Registrar.Visible = True
            txt_TelefonoCLiente.Enabled = True : txt_TelefonoCLiente.Text = ""
            txt_DireccionCliente.Enabled = True : txt_DireccionCliente.Text = ""
        Else
            txt_NombreCliente.Enabled = False
            txt_TelefonoCLiente.Enabled = False
            txt_DireccionCliente.Enabled = False

        End If
    End Sub

    ' Cuando se aprete el boton inventario, se mostrara el frmInventario
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_MostrarInventario.Click
        frmInventario.Show()
    End Sub

    Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        ' SI el producto esta vacio, evitamos que se pueda ejecutar este evento
        If producto.vacio() Then
            ' Si esta vacio, rompemos el flujo de ejecucion de esta funcion, evitando que se ejecute el codigo de abajo
            Return
        End If
        TextBox9.Text = producto.Precio * NumericUpDown1.Value
    End Sub


    Public Sub Limpiar()
        producto.Nombre = ""
        producto.Codigo = 0
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        NumericUpDown1.Value = 1
    End Sub


    'Cuando se produzca este evento, se limpiara la informacion del producto seleccionado
    Private Sub btn_EliminarProducto_Click(sender As Object, e As EventArgs) Handles btn_EliminarProducto.Click
        Limpiar()
    End Sub
End Class
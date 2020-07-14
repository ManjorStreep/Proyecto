Imports Microsoft.Reporting.WinForms
Imports System.Text
Public Class frmHacer_Venta

    ' Estas variables son las que se encargaran de gestionar la informacion de la base de datos!
    Dim producto As Productos
    Dim empleado As Empleado

    ' Estos TableAdapter seran lo que se encarguen de registrar clientes y el historial de compras
    Dim TablaHistorial As New DatabaseDataSetTableAdapters.HistorialTableAdapter
    Dim TablaCliente As New DatabaseDataSetTableAdapters.ClientesTableAdapter

    ' Esta funcion sera para seleccionar el producto desde la base de datos y posteriormente, si se realiza la compra se actualiza la cantidad
    Public Sub SeleccionarProducto(ByVal codigo As String)
        producto = New Productos(codigo)
        ImprimirProducto()
    End Sub

    ' Esta Funcion es para obtener informacion del empleado
    Public Sub DatosEmpleado(ByVal cedula As String)
        empleado = New Empleado(cedula)
    End Sub

    'Esta funcion se encarga de colocar la informacion del producto en pantalla 
    Private Sub ImprimirProducto()
        TextBox7.Text = producto.Nombre
        TextBox8.Text = producto.Clasificacion
        TextBox9.Text = producto.Valor
        TextBox10.Text = producto.Cantidad_Disponible
        NumericUpDown1.Value = 1
    End Sub

    ' Esta funcion se encargara de actualizar el precio de la factura
    Private Sub ActualizarPrecio()
        Dim precio As Decimal = 0.0
        For Each fila As DataGridViewRow In DataGridView1.Rows
            precio = precio + Convert.ToDecimal(fila.Cells(4).Value)
        Next

    End Sub

    Private Sub frmHacer_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        ' Estos metodos se encargan de llenar el DataGridView con la informacion de todos los productos
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)

        ' Antes de mostrar este formulario se debe enviar la informacion del trabajador con la funcion DatosEmpleado()
        lb_codigoEmpleado.Text = empleado.Cedula
        lb_nombreEmpleado.Text = empleado.Nombre
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    ' En este evento, cuando el valor del NumericUpDown1 sea cambiado, se multipicara el precio base del producto por el numero seleccionado
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        TextBox9.Text = producto.Valor * NumericUpDown1.Value
    End Sub

    ' * AQUI DEBES HACER VERIFICACION DE QUE EL TEXTBOX1 NO ESTE VACIO * 
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Conexiones.Verificacion("Productos", "CODIGO = " & TextBox1.Text) Then
            SeleccionarProducto(TextBox1.Text)
        Else
            MsgBox("El CODIGO del producto es incorrecto o no existe")
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
        ' Cada vez que se aprete el boton agregar, se enlistara un producto al DataGridView y se actualiza el precio del carrito
        DataGridView1.Rows.Add(New String() {producto.Id, producto.Nombre, producto.Valor, NumericUpDown1.Value, TextBox9.Text})
        ActualizarPrecio()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Por cada producto del DataGridView sea dobleclickeado se borrara y se actualizara el precio del carrio nuevamente
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        ActualizarPrecio()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_Pagar.Click
        'TODOS LOS TEXTBOX DEBEN ESTAR RELLENOS PARA QUE NO OCURRAN ERRORES, PENDIENTE DE ESO.

        ' Para hacer la factura usaremos el dataset especificamente creado para eso
        Dim dataset As New FacturaDataSet()
        Dim datatable As New DataTable()
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
            productos.Append("PRODUCTO: " & fila.Cells(2).Value & " CANTIDAD: " & fila.Cells(3).Value & " PAGADO: " & fila.Cells(4).Value & " - ")
            datatable.Rows.Add(datos)
        Next

        ' Esto es para remover el ultimo " - " que queda al final del StringBuilder

        ' Eliminamos el contenido del DataSet creado especificamente para el ReportViewer
        dataset.Tables.RemoveAt(0)
        ' Le asignamos nueva tabla, que debe ser igual a la borrada anteriormente, pero con lo particular de que esta nueva tabla esta llena de datos
        dataset.Tables.Add(datatable)

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
        parametros(7) = New ReportParameter("Factura", "123")

        ' Esto sirve para registrar cliente y la factura en la base de datos
        ' Debes colocar el numero de factora al final!
        TablaCliente.RegistrarCliente(txt_NombreCliente.Text, txt_DniCliente.Text, txt_TelefonoCLiente.Text, txt_DireccionCliente.Text)
        TablaHistorial.RegistrarCompra(txt_NombreCliente.Text, productos.ToString().Remove(productos.ToString().LastIndexOf(" - ")), TextBox6.Text, DateTime.Now, empleado.Cedula, "Factura:0000")

        Dim Factura As New frmVisualizarReportes()
        Factura.Parametros(parametros, dataset)
        Factura.Show()

    End Sub
    ' AQUI es el boton de buscar, verifica que el campo de la cedula no este vacio 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Validate And txt_DniCliente.Text = String.Empty Then
            MsgBox("Ingrese datos en este campo")
        Else
            If txt_DniCliente.Text <> "" And txt_DireccionCliente.Text <> "" And txt_NombreCliente.Text <> "" And txt_TelefonoCLiente.Text <> "" Then
                If txt_DireccionCliente.TextLength > 4 And txt_DniCliente.TextLength > 4 And txt_NombreCliente.TextLength > 4 And txt_TelefonoCLiente.TextLength > 4 Then
                    'aca se registran los datos en la DB
                    If Conexiones.Verificacion("Clientes", "CEDULA = '" & txt_DniCliente.Text & "'") Then
                        Dim datos As DataTableReader = TablaCliente.ObtenerCliente(txt_DniCliente.Text).CreateDataReader()
                        While datos.Read()
                            txt_NombreCliente.Text = datos.Item(1)
                            txt_DniCliente.Text = datos.Item(2)
                            txt_TelefonoCLiente.Text = datos.Item(3)
                            txt_DireccionCliente.Text = datos.Item(4)
                        End While
                        'Msgbox("usuario Registrado con exito")
                        activarDatosClientes(False)
                    Else
                        MsgBox("ERROR USUARIO NO REGISTRADO", vbNewLine + "Rellene los siguientes campos para registrarlo")
                        'falta activar los campos
                        activarDatosClientes(True)
                    End If
                    MsgBox("Porfavor Rellene todos los Campos")
                End If
                MsgBox("Porfavor Rellene todos los Campos")
            End If
            
        End If
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
    '/-----------------------------------------------------------------------------------------------------------------/'
    Private Sub txt_DniCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_DniCliente.Validating
        validandoCampo(sender, 8)
    End Sub
    Private Sub txt_TelefonoCLiente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TelefonoCLiente.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub activarDatosClientes(ByVal x As Boolean)
        If x = True Then
            txt_NombreCliente.Enabled = True : txt_NombreCliente.Text = ""
            txt_NombreCliente.Focus()
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
End Class
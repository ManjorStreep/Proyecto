Imports Microsoft.Reporting.WinForms
Imports System.Text
Public Class frmHacer_Venta

    Dim producto As Productos
    Dim empleado As Empleado

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
        TextBox6.Text = precio
    End Sub

    Private Sub frmHacer_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    ' En este evento, cuando el valor del NumericUpDown1 sea cambiado, se multipicara el precio base del producto por el numero seleccionado
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.Rows.Add(New String() {producto.Id, producto.Nombre, producto.Valor, NumericUpDown1.Value, TextBox9.Text})
        ActualizarPrecio()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        ActualizarPrecio()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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
        parametros(0) = New ReportParameter("NombreCliente", TextBox2.Text)
        parametros(1) = New ReportParameter("TelefonoCliente", TextBox5.Text)
        parametros(2) = New ReportParameter("DireccionCliente", TextBox4.Text)
        parametros(3) = New ReportParameter("CedulaCliente", TextBox3.Text)
        parametros(4) = New ReportParameter("TotalPagar", TextBox6.Text)
        parametros(5) = New ReportParameter("CajeroNombre", empleado.Nombre & " " & empleado.Apellido)
        parametros(6) = New ReportParameter("CajeroCargo", empleado.Cargo)
        ' AQui debes agregar el numero de factura, si deseas claro. 
        ' Crea la funcion, y si no lo deseas borras este parametro 7 y le pones a la longitud del array 6 en la declaracion!
        parametros(7) = New ReportParameter("Factura", "123")

        ' Esto sirve para registrar cliente y la factura en la base de datos
        TablaCliente.RegistrarCliente(TextBox2.Text, TextBox3.Text, TextBox5.Text, TextBox4.Text)
        TablaHistorial.RegistrarCompra(TextBox2.Text, productos.ToString().Remove(productos.ToString().LastIndexOf(" - ")), TextBox6.Text, DateTime.Now, empleado.Cedula)

        Dim Factura As New frmVisualizarReportes()
        Factura.Parametros(parametros, dataset)
        Factura.Show()

    End Sub
    ' AQUI es el boton de buscar, verifica que el campo de la cedula no este vacio 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Conexiones.Verificacion("Clientes", "CEDULA = '" & TextBox3.Text & "'") Then
            Dim datos As DataTableReader = TablaCliente.ObtenerCliente(TextBox3.Text).CreateDataReader()
            While datos.Read()
                TextBox2.Text = datos.Item(1)
                TextBox3.Text = datos.Item(2)
                TextBox5.Text = datos.Item(3)
                TextBox4.Text = datos.Item(4)
            End While
        Else
            MsgBox("ERROR USUARIO NO REGISTRADO")
        End If
    End Sub
End Class
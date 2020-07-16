Public Class frmCaja


    ' Esta variable sera la encargada de almacenar los datos del usuario logeado
    Public empleado As Empleado
    Public producto As Producto


    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Aqui es indispensable que antes de llamar al metodo Show() de este form, primero debes otorgase datos a la variable persona
        lb_datocajero0.Text = empleado.Nombre
        lb_datocajero1.Text = empleado.Apellido
        lb_datocajero2.Text = empleado.Cedula
        lb_datocajero3.Text = empleado.Cargo

        'iniciando timer
        '
        tim_1.Start()
        producto = New Producto()
        producto.Llenar(DataGridView1)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        MsgBox("Vuelva pronto :)", MsgBoxStyle.OkOnly)
        End
    End Sub

    Private Sub tim_1_Tick(sender As Object, e As EventArgs) Handles tim_1.Tick
        ToolStripStatusLabel_ObtenerFecha.Text = DatosSistema.obtenerFecha()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Cuando se de doble click a una celda del DataGridView se haran estas acciones.

        ' Se envia al frmHacer_Venta el producto que ha sido clickeado 
        'frmHacer_Venta.SeleccionarProducto(DataGridView1.CurrentRow.Cells(0).Value)
        ' Se envia al frmHacer_Venta el empleado que ha estado logeado en el sistema
        'frmHacer_Venta.DatosEmpleado(persona.Cedula)
        ' De ultimo se muestra el frmHacer_Venta
        frmHacer_Venta.producto = New Producto(DataGridView1.CurrentRow.Cells(0).Value)
        frmHacer_Venta.empleado = empleado
        frmHacer_Venta.Show()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        For Each filas As DataGridViewRow In DataGridView1.Rows
            ' Compara lo introducido en TextBox1 con todos los codigos de los productos, y el que sea igual, debe ser seleccionado!
            ' Use integer, porque no se como comparar 2 Strings, si tu sabes, arreglalo!
            If Integer.Parse(filas.Cells(0).Value) = Integer.Parse(TextBox1.Text) Then
                DataGridView1.Rows(filas.Index).Selected = True
            End If
        Next
    End Sub

End Class

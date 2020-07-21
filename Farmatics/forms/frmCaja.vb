Public Class frmCaja


    ' Esta variable sera la encargada de almacenar los datos del usuario logeado
    Public Empleado As New Empleado
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
        ' instanciamos una variable tipo producto vacia, solamente para usar su metodo Llenar, para colocar todos los productos en el DataGridView
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
        frmHacer_Venta.producto = New Producto(DataGridView1.CurrentRow.Cells(0).Value)
        ' Se envia al frmHacer_Venta el empleado que ha estado logeado en el sistema
        frmHacer_Venta.empleado = empleado
        ' De ultimo se muestra el frmHacer_Venta
        frmHacer_Venta.Show()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim seleccion As Boolean = False
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If TextBox1.Text.Equals(fila.Cells("Codigo").Value) Then
                seleccion = True
                DataGridView1.Rows(fila.Index).Selected = seleccion
            End If
        Next
        If seleccion = False Then
            For Each fila As DataGridViewRow In DataGridView1.Rows
                If TextBox1.Text.Equals(fila.Cells("Nombre").Value) Then
                    DataGridView1.Rows(fila.Index).Selected = seleccion
                End If
            Next
        End If
    End Sub

    Private Sub btn_facturar_Click(sender As Object, e As EventArgs) Handles btn_facturar.Click
        frmHacer_Venta.empleado = Me.empleado
        frmHacer_Venta.ShowDialog()
    End Sub
End Class

Public Class frmCaja

    ' Esta variable sera la encargada de almacenar los datos del usuario logeado
    Dim persona As Empleado

    ' Este es un metodo setter, para otorgarle datos a la variable persona
    Public Sub Trabajador(ByVal Cedula As Integer)
        persona = New Empleado(Cedula)
    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        ' Estos metodos son los encargado de rellenar el DataGridView con los datos de todos los productos
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)


        ' Aqui es indispensable que antes de llamar al metodo Show() de este form, primero debes otorgase datos a la variable persona
        lb_datocajero0.Text = persona.Nombre
        lb_datocajero1.Text = persona.Apellido
        lb_datocajero2.Text = persona.Cedula
        lb_datocajero3.Text = persona.Cargo

        'iniciando timer
        '
        tim_1.Start()

        DataGridView1.Rows(0).Selected = False
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
        frmHacer_Venta.SeleccionarProducto(DataGridView1.CurrentRow.Cells(0).Value)
        ' Se envia al frmHacer_Venta el empleado que ha estado logeado en el sistema
        frmHacer_Venta.DatosEmpleado(persona.Cedula)
        ' De ultimo se muestra el frmHacer_Venta
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

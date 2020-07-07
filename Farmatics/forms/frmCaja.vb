Public Class frmCaja

    Dim persona As Empleado

    Public Sub Trabajador(ByVal Cedula As Integer)
        persona = New Empleado(Cedula)
    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)

        lb_datocajero0.Text = persona.Nombre
        lb_datocajero1.Text = persona.Apellido
        lb_datocajero2.Text = persona.Cedula
        lb_datocajero3.Text = persona.Cargo

        'iniciando timer
        '
        tim_1.Start()

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        MsgBox("Vuelva pronto :)", MsgBoxStyle.OkOnly)
        End
    End Sub


    Private Sub tim_1_Tick(sender As Object, e As EventArgs) Handles tim_1.Tick
        ToolStripStatusLabel_ObtenerFecha.Text = DatosSistema.obtenerFecha()
    End Sub

    Private Sub btn_facturar_Click(sender As Object, e As EventArgs) Handles btn_facturar.Click
        frmHacer_Venta.Show()
    End Sub
End Class

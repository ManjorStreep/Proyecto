Public Class frmCaja

    Dim Usuario As Empleado

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'Volcado de Informacion del Cajero
        '
        Usuario = frmLogin.Usuario()
<<<<<<< HEAD
=======
        Conexiones.ObtenerTabla("Productos", DataGridView1)
>>>>>>> e1d727629efac0976a90f69005a020eff1d26938
        lb_datocajero0.Text = Usuario.Nombre
        lb_datocajero1.Text = Usuario.Apellido
        lb_datocajero2.Text = Usuario.Cedula
        lb_datocajero3.Text = Usuario.Cargo
<<<<<<< HEAD
        '
        'Rellenando la Tabla 
        '
        Conexiones.ObtenerTabla("Productos", DataGridView1)

        '
        'iniciando timer
        '
        tim_1.Start()


=======
>>>>>>> e1d727629efac0976a90f69005a020eff1d26938
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

    Private Sub gbPerfil_Enter(sender As Object, e As EventArgs) Handles gbPerfil.Enter

    End Sub
End Class

Public Class frmCaja

    Dim Usuario As Empleado

    Private Sub btn_client_Click(sender As Object, e As EventArgs) Handles btn_client.Click

    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario = frmLogin.Usuario()
        Conexiones.ObtenerTabla("Productos", DataGridView1)
        lb_datocajero0.Text = Usuario.Nombre
        lb_datocajero1.Text = Usuario.Apellido
        lb_datocajero2.Text = Usuario.Cedula
        lb_datocajero3.Text = Usuario.Cargo
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lb_datocajero0_Click(sender As Object, e As EventArgs) Handles lb_datocajero0.Click

    End Sub
End Class

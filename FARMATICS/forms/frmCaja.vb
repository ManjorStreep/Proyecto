Public Class frmCaja

    Private Sub btn_client_Click(sender As Object, e As EventArgs) Handles btn_client.Click

    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Conexiones.Productos("Select * from Clientes")
        DataGridView1.DataMember = "Clientes"

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

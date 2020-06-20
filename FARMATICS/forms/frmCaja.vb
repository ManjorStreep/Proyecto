Public Class frmCaja

    Private Sub btn_client_Click(sender As Object, e As EventArgs) Handles btn_client.Click

    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD

        Conexiones.ObtenerTabla("Clientes", DataGridView1)
=======
        '
        'carga de objeto datagridview
        '
        DataGridView1.DataSource = Conexiones.obtenerDataSet("Select * from Clientes", "Clientes")
        DataGridView1.DataMember = "Clientes"
        '
        'carga del area de Identificacion del Cajero
        '
>>>>>>> 9ac577c7aa89f085b74216bae718dbcbb8b8272f

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

End Class

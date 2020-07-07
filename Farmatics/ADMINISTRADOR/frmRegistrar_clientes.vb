Public Class frmRegistrar_clientes


    Private Sub frmGestion_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox3.Items.Add("V")
        ComboBox3.Items.Add("E")
        ComboBox3.Items.Add("P")
        ComboBox3.Items.Add("J")
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub btSalir_Click_1(sender As Object, e As EventArgs) Handles btSalir.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btConsuta_Click(sender As Object, e As EventArgs) Handles btConsuta.Click
       
    End Sub

End Class

Public Class frmMenu

    Private Sub VerFichasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerFichasToolStripMenuItem.Click
        frmFichas.Show()
    End Sub

    Private Sub CerrarSeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSeToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub GestionarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarProductoToolStripMenuItem.Click
        frmRegistroproductos.Show()
    End Sub

    Private Sub RealizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarVentaToolStripMenuItem.Click
        frmHacer_Venta.Show()
    End Sub

    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        frmRegistrar_clientes.Show()
    End Sub

End Class
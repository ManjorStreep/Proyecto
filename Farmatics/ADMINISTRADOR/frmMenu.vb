
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

    Private Sub RealizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmHacer_Venta.Show()
    End Sub

    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        frmRegistrar_clientes.Show()
    End Sub

    Private Sub FichaTecnicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaTecnicaToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Historial' Puede moverla o quitarla según sea necesario.
        Me.HistorialTableAdapter.Fill(Me.DatabaseDataSet.Historial)
        tmr_reloj.Start()
    End Sub

    Private Sub tmr_reloj_Tick(sender As Object, e As EventArgs) Handles tmr_reloj.Tick
        SsTxt_Fecha.Text = DatosSistema.obtenerFecha("Fecha")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
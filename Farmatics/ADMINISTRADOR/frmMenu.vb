
Public Class frmMenu

    ' Esta variable sera la encargada de almacenar los datos del usuario logeado
    Public empleado As Empleado
    Private tabla As New Conexion()


    Private Sub VerFichasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerFichasToolStripMenuItem.Click
        frmFichas.empleado = empleado
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

    End Sub

    Private Sub FichaTecnicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaTecnicaToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub


    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Aqui es indispensable que antes de llamar al metodo Show() de este form, primero debes otorgase datos a la variable persona
        lb_datocajero0.Text = empleado.Nombre
        lb_datocajero1.Text = empleado.Apellido
        lb_datocajero2.Text = empleado.Cedula
        lb_datocajero3.Text = empleado.Cargo

        tmr_reloj.Start()
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Historial' Puede moverla o quitarla según sea necesario.
        ' Me.HistorialTableAdapter.Fill(Me.DatabaseDataSet.Historial)
        ' Aqui es indispensable que antes de llamar al metodo Show() de este form, primero debes otorgase datos a la variable persona

        tabla.Llenar(DataGridView1, "Historial")



    End Sub

    Private Sub tmr_reloj_Tick(sender As Object, e As EventArgs) Handles tmr_reloj.Tick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        frmHacer_Venta.Show()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub ListaDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeProductoToolStripMenuItem.Click
        frmInventario.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmReportesClientes.Show()
    End Sub

End Class
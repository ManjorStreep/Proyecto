'Importamos la librería Runtime.InteropServices.
Imports System.Runtime.InteropServices
'---------------------------------------------------------------------------------------------'
Public Class frmPanelMenu
    ' Esta variable sera la encargada de almacenar los datos del usuario logeado
    Public empleado As Empleado
    Private tabla As New Conexion()
    '---------------------------------------------------------------------------------------------'
    'Añadiendo funcion de arrastrar o mover el formulario / Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    '---------------------------------------------------------------------------------------------'
    '---------------------------------------------------------------------------------------------'
    'Procedimientos
    '---------------------------------------------------------------------------------------------'
    Private Sub ocultarSubmenu()
        panelSubMenuAdministrador.Visible = False
        panelSubmenuHerramientas.Visible = False
        panelSubmenuReportes.Visible = False
    End Sub

    Private formulariosRecurrentes As Form = Nothing
    Private Sub abrirFormulariosHijos(formularioHijo As Form)
        If formulariosRecurrentes IsNot Nothing Then formulariosRecurrentes.Close()
        formulariosRecurrentes = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = BorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        panelFormulariosHijos.Controls.Add(formularioHijo)
        panelFormulariosHijos.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()
    End Sub

    Private Sub mostrarSubmenu(subMenu As Panel)
        If subMenu.Visible = False Then
            ocultarSubmenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub
    '---------------------------------------------------------------------------------------------'
    'Componentes del Formulario 
    '---------------------------------------------------------------------------------------------'
    Private Sub frmPanelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarSubmenu()
        lbUser.Text += empleado.Nombre & " " & empleado.Apellido
        lbCargo.Text += empleado.Cargo

        Timer1.Start()


    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized ' minimiza la ventana
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized ' maximiza la ventana
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit() ' cierra el programa de raiz
    End Sub

    Private Sub btnAdministración_Click(sender As Object, e As EventArgs) Handles btnAdministración.Click
        mostrarSubmenu(panelSubMenuAdministrador)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        mostrarSubmenu(panelSubmenuReportes)
    End Sub

    Private Sub btnHerramientas_Click(sender As Object, e As EventArgs) Handles btnHerramientas.Click
        mostrarSubmenu(panelSubmenuHerramientas)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '
        'call a formulario a mostrar
        '
        ocultarSubmenu()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '
        'call a formulario a mostrar
        '
        ocultarSubmenu()
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        '
        'call a formulario a mostrar
        '
        ocultarSubmenu()
    End Sub

    Private Sub btnReporteInventario_Click(sender As Object, e As EventArgs) Handles btnReporteInventario.Click
        '
        'call a formulario a mostrar
        '
        ocultarSubmenu()
    End Sub

    Private Sub btnReportesClientes_Click(sender As Object, e As EventArgs) Handles btnReportesClientes.Click
        '
        'call a formulario a mostrar
        '
        ocultarSubmenu()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '
        'call a formulario a mostrar
        '
        ocultarSubmenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '
        'call a formulario a mostrar
        '
        ocultarSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmFichas.empleado = empleado
        abrirFormulariosHijos(New frmFichas())
        ocultarSubmenu()
    End Sub
    '---------------------------------------------------------------------------------------------'

    Private Sub panelHeaderTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeaderTop.MouseDown
        'Creamos el evento MouseDown del panel barra de título e invocamos los métodos anteriores, de la siguiente manera.
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Me.Cursor = Cursors.Cross
    End Sub

    Private Sub panelHeaderTopLateral_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeaderTopLateral.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbFechaHora.Text = DatosSistema.obtenerFecha("Fecha")
    End Sub
End Class
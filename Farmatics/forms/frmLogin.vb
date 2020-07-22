'Importamos la librerías
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Threading
'---------------------------------------------------------------------------------------------'
Public Class frmLogin
    Private empleado As Empleado
    '---------------------------------------------------------------------------------------------'
    'Añadiendo funcion de arrastrar o mover el formulario / Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    '---------------------------------------------------------------------------------------------'
    'Procedimientos
    '---------------------------------------------------------------------------------------------'
    Private Sub CustomizarComponentes() ' este metodo edita la altura de los textBBox ya que desde el editor no se puede realizar
        'txtUsername
        txtUser.AutoSize = False
        txtUser.Size = New Size(240, 30)
        'txtPassword
        txtPass.AutoSize = False
        txtPass.Size = New Size(240, 30)
        txtPass.UseSystemPasswordChar = True ' activar caracteres de contraseña
    End Sub

    '---------------------------------------------------------------------------------------------'
    'Componentes del Formulario 
    '---------------------------------------------------------------------------------------------'
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load

        CustomizarComponentes() ' inicializa el componente
        txtUser.Focus()
        txtUser.Text = "" : txtPass.Text = ""
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        End ' cierra el programa de raiz
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized ' minimiza la ventana
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        'metodo para darle estilo y forma a el control "btnLogin" mediante metodos de dibujado
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

    Private Sub PanelCabezera_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelCabezera.MouseDown
        'Creamos el evento MouseDown del panel barra de título e invocamos los métodos anteriores, de la siguiente manera.
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'También podemos mover el formulario de cualquier parte o en caso que no uses una barra de título, de la misma forma, creas el evento MouseDown del formulario e invocas los métodos.
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '
        'el codigo a ejecutar
        '
        btnLogin.Enabled = False
        Try
            If Me.ValidateChildren And txtUser.Text <> String.Empty And txtPass.Text <> String.Empty Then
                'MessageBox.Show("datos ingresados correctamente", "registro de ususarios", MessageBoxButtons.OK)
                ' Verificamos si el usuario existe en la base de datos
                ' Si el usuario existe se mostrara el siguiente form correspondiente a su cargo!
                Dim conexion As New Conexion
                If conexion.Verificacion("Empleados", "CEDULA =" & txtUser.Text & " AND CLAVE ='" & txtPass.Text & "'") Then
                    empleado = New Empleado(txtUser.Text)
                    If empleado.Cargo.Equals("DUEÑO") Or empleado.Cargo.Equals("GERENTE") Then
                        frmPanelMenu.empleado_X = empleado
                        frmPanelMenu.Show()
                        Me.Hide()
                    Else
                        frmCaja.empleado = empleado
                        frmCaja.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                        frmCaja.Show()

                        Me.Hide()
                    End If
                Else
                    MsgBox("Usuario o Contraseña - INVALIDOS")
                End If
            Else
                MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnLogin.Enabled = True
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'
    '/- validando campos -/'
    '/-----------------------------------------------------------------------------------------------------------------/'

    Private Sub txtUser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUser.Validating
        validandoCampo(sender, 9)
    End Sub

    Private Sub txtPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPass.Validating
        validandoCampo(sender, 10)
    End Sub

    Sub validandoCampo(ByRef Objeto As Object, ByVal largo As Integer)
        If DirectCast(Objeto, TextBox).Text.Length > 0 And DirectCast(Objeto, TextBox).Text.Length < largo Then
            'Me.ErrorProvider1.SetError(Objeto, "")
        Else
            Me.ErrorProvider1.SetError(Objeto, "ingrese un dato en esete campo") 'mensage de error
        End If
    End Sub

    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'
End Class

Imports System.Data.SqlClient
Imports System.Threading
Public Class frmLogin

    Private empleado As Empleado

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_user.Focus()
        txt_user.Text = "" : txt_pass.Text = ""
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        ' ERROR: Esta pregunta no tiene fundamento, preguntar no tiene sentido si de igual manera se saldra
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        btnIngresar.Enabled = False
        Try
            If Me.ValidateChildren And txt_user.Text <> String.Empty And txt_pass.Text <> String.Empty Then
                'MessageBox.Show("datos ingresados correctamente", "registro de ususarios", MessageBoxButtons.OK)
                ' Verificamos si el usuario existe en la base de datos
                ' Si el usuario existe se mostrara el siguiente form correspondiente a su cargo!
                Dim conexion As New Conexion
                If conexion.Verificacion("Empleados", "CEDULA =" & txt_user.Text & " AND CLAVE ='" & txt_pass.Text & "'") Then
                    empleado = New Empleado(txt_user.Text)
                    If empleado.Cargo = "DUEÑO" Or empleado.Cargo = "GERENTE" Then
                        frmMenu.empleado = empleado
                        frmMenu.Show()
                    Else
                        frmCaja.Show()
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
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'
    '/- validando campos -/'
    '/-----------------------------------------------------------------------------------------------------------------/'

    Private Sub txt_user_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_user.Validating
        validandoCampo(sender, 9)
    End Sub

    Private Sub txt_pass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_pass.Validating
        validandoCampo(sender, 10)
    End Sub

    Sub validandoCampo(ByRef Objeto As Object, ByVal largo As Integer)
        If DirectCast(Objeto, TextBox).Text.Length > 0 And DirectCast(Objeto, TextBox).Text.Length < largo Then
            Me.ErrorIcon.SetError(Objeto, "")
        Else
            Me.ErrorIcon.SetError(Objeto, "ingrese un dato en esete campo") 'mensage de error
        End If
    End Sub

    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'

   

End Class

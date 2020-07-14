Imports System.Data.SqlClient
Imports System.Threading
Public Class frmLogin

    Dim datos As List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_user.Focus()
        ' Indicamos (por ejemplo en el evento Load) que queremos que el backgroundworker informe le Progreso

        ' Indicamos (por ejemplo en el evento Load) que queremos que el backgroundworker tenga cancelación
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        btnIngresar.Enabled = False
        Try
            If Me.ValidateChildren And txt_user.Text <> String.Empty And txt_pass.Text <> String.Empty Then
                'MessageBox.Show("datos ingresados correctamente", "registro de ususarios", MessageBoxButtons.OK)

                btnIngresar.Enabled = True : btSalir.Enabled = True
                If Me.BackgroundWorker1.IsBusy <> True Then
                    BackgroundWorker1.RunWorkerAsync()
                End If

            Else
            MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'
    '/- Operacion asincrona -/'
    '/-----------------------------------------------------------------------------------------------------------------/'
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        If Verificacion("Empleados", "CEDULA ='" & txt_user.Text & "' AND CLAVE ='" & txt_pass.Text & "'") Then

            Me.BackgroundWorker1.WorkerReportsProgress = True
            If Verificacion("Empleados", "CEDULA ='" & txt_user.Text & "' AND CARGO = 'Dueño' OR " & "CEDULA ='" & txt_user.Text & "' AND CARGO = 'Gerente'") Then
                frmMenu.Trabajador(txt_user.Text)
                abrirPantallas(False)
            Else
                MsgBox("Usuario no existe")

            End If
        End If
    End Sub
    ' Evento que actualiza la progressbar para que el usuario vea la evolución de la operación
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ProgressBar1.Value += e.ProgressPercentage
    End Sub

    ' Evento que muestra una alerta para informar al usuario de que la operación asíncrona ha finalizado (ya sea porque el usuario la ha cancelado, se ha producido un erorr, o ha finalizado correctamente)
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If e.Cancelled Then
            MessageBox.Show("Laación ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Se producido un error durante la ejecución: " & e.Error.Message)
        Else
            'MessageBox.Show("Laación en segundo plano ha finalizado con éxito.")
            If abrirPantallas() <> False Then
                frmMenu.Show()
            Else
                frmCaja.Show()
            End If
            Me.Hide()
        End If


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

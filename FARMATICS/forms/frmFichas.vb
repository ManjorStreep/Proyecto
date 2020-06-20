Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmFichas
    Private Sub frmFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MainDataDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        'Me.UsuariosTableAdapter.Fill(Me.MainDataDataSet.usuarios)'


        Me.BackgroundWorker1.WorkerReportsProgress = True
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub btbusqueda_Click(sender As Object, e As EventArgs) Handles btbusqueda.Click
        'conexion_1.abrir()
        Me.ProgressBar1.Value = 0
            ''''''''''''''''''''''''''''''''''''''''''''''''''
            If BackgroundWorker1.IsBusy <> True Then
                ' Start the asynchronous operation.
            BackgroundWorker1.RunWorkerAsync() : asd()

            'conexion_1.conexiones.Close()
            'Conexion.conexiones.Close()
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''
       

    End Sub
    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Dim myImagenConsulta As Image

        ' myImagenConsulta = BytesToImagen(Conexion.consultaByte(TextBox1.Text))
        'PictureBox2.Image = myImagenConsulta

        BackgroundWorker1.ReportProgress(100)
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged



        Me.ProgressBar1.Value += e.ProgressPercentage



    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'conexion_1.conexiones.Close()
        'Conexion.conexiones.Close()

    End Sub


    Sub asd()


        'Dim x As String
        'x = TextBox1.Text
        'Try
        '    If TextBox1.Text <> "" Then
        '        'Aqui se iniciara la conexion a la base de datos 

        '        Dim ejecutar As New SqlCommand("select * from usuarios where dni = '" & x & "'", conexion_1.conexiones)
        '        Dim l As SqlDataReader = ejecutar.ExecuteReader
        '        If l.HasRows = True Then
        '            While l.Read
        '                Label28.Text = l(10) + " - " + l(0)
        '                ' a = Trim(l(0))
        '                'aa = Trim(l(10))
        '                Label27.Text = Trim(l(1))
        '                Label26.Text = Trim(l(2))
        '                Label25.Text = Trim(l(3))
        '                Label24.Text = Trim(l(4))
        '                Label23.Text = Trim(l(5))
        '                Label22.Text = Trim(l(6))
        '                Label21.Text = Trim(l(7))
        '                Label20.Text = Trim(l(8))
        '                ' Label28.Text = aa + " - " + a
        '            End While
        '        Else
        '            'en caso de que no exista en la base de datos ; Habilite el formulario
        '            Conexion.conexiones.Close()
        '            MsgBox("No existe este usuario , o no esta registrado en el sistema,Rellene el formulario de registro aparte", MsgBoxStyle.Information)
        '        End If
        '    Else
        '        MsgBox("Ingrese una Cedula valida")
        '        Conexion.conexiones.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    
    Private Sub txt_clave_TextChanged(sender As Object, e As EventArgs) Handles txt_clave.TextChanged

    End Sub
End Class
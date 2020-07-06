Public Class frmRegistroproductos

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmRegistroproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
        TextBox15.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datos As DataTable = Me.ProductosTableAdapter.GetDataBy(Integer.Parse(TextBox4.Text))
        Dim Producto As New Productos(datos.Rows(0))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(TextBox15.Text) Or String.IsNullOrEmpty(TextBox16.Text) Or String.IsNullOrEmpty(TextBox17.Text) Then
            MsgBox("No pueden estar los campos vacios")
            Return
        End If
        If Me.ProductosTableAdapter.GetDataByNombre(TextBox15.Text).Rows.Count > 0 Then
            MsgBox("Este producto existe")
        Else
            MsgBox("Este producto no existe")
        End If

    End Sub
End Class
Imports Sotware_Farmatics.Conexiones
Public Class frmRegistroproductos

    Dim recipe As Boolean

    ' Esta funcion es la que se encargara de modificar y seleccionar productos y mostrarlo en pantalla.
    Private Sub Datos(ByVal tabla As DataTable)
        Dim producto As New Productos(tabla.Rows(0))
        TextBox1.Text = producto.Id
        TextBox15.Text = producto.Nombre
        TextBox16.Text = producto.Cantidad_Disponible
        TextBox17.Text = producto.Valor
        If producto.Recipe Then
            RadioButton1.Select()
        Else
            RadioButton2.Select()
        End If
        'Aqui adentro falta el algoritmo que te marque el item del combobox correspondiente al que tiene guardado el producto.Clasificacion

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub frmRegistroproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
        TextBox15.Enabled = True
        ComboBox4.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Datos(Me.ProductosTableAdapter.GetDataBy(Integer.Parse(TextBox4.Text)))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Aqui debes validar, osea si los Textbox estan vacios, no dejes que se registren en la base de datos, porque saldran errores.
        If String.IsNullOrEmpty(TextBox15.Text) Or String.IsNullOrEmpty(TextBox16.Text) Or String.IsNullOrEmpty(TextBox17.Text) Or String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("No pueden estar los campos vacios")
            Return
        End If
        If Me.ProductosTableAdapter.GetDataByNombre(TextBox15.Text).Rows.Count > 0 Then
            MsgBox("Este producto existe")
            Return
        End If
        Try
            'Asi se registra un producto a la base de datos.
            Me.ProductosTableAdapter.InsertQuery(TextBox15.Text, Convert.ToDecimal(TextBox17.Text), Integer.Parse(TextBox16.Text), ComboBox4.SelectedItem, recipe, Integer.Parse(TextBox1.Text))
            Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
        Catch ex As Exception
            MsgBox("Fallo al registrar el producto - " & ex.Message)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        recipe = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        recipe = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Datos(Me.ProductosTableAdapter.GetDataBy(DataGridView1.CurrentRow.Cells(0).Value))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Aqui debes validar que los Textbox no esten vacios para poder modificar un producto!
        If String.IsNullOrEmpty(TextBox15.Text) Or String.IsNullOrEmpty(TextBox16.Text) Or String.IsNullOrEmpty(TextBox17.Text) Or String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("No pueden estar los campos vacios")
            Return
        End If
        Try
            Me.ProductosTableAdapter.UpdateQuery(TextBox15.Text, Convert.ToDecimal(TextBox17.Text), Integer.Parse(TextBox16.Text), ComboBox4.SelectedItem, recipe, Integer.Parse(TextBox1.Text), TextBox17.Text)
            Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
        Catch ex As Exception
            MsgBox("Fallo al actualizar el producto - " & ex.Message)
        End Try

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)

    End Sub
End Class
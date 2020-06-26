Public Class frmRegistrar_clientes


    Private Sub frmGestion_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox3.Items.Add("V")
        ComboBox3.Items.Add("E")
        ComboBox3.Items.Add("P")
        ComboBox3.Items.Add("J")
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub btSalir_Click_1(sender As Object, e As EventArgs) Handles btSalir.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btConsuta_Click(sender As Object, e As EventArgs) Handles btConsuta.Click
        Dim datos As Empleado
        Dim consulta As List(Of String) = Conexiones.ObtenerDatos("Empleados", "WHERE CEDULA ='" & txtDNI.Text & "'")
        If consulta.Count > 0 Then
            datos = New Empleado(consulta)
            txtApellido.Text = datos.Apellido
            txtNombre.Text = datos.Nombre
            txtDIreccion.Text = datos.Direccion
            txtTelefono.Text = datos.Telefono
            If datos.Sexo = RadioButton3.Text Then
                RadioButton3.Select()
            Else
                RadioButton4.Select()
            End If

        Else
            MsgBox("No funciona")
        End If
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
End Class
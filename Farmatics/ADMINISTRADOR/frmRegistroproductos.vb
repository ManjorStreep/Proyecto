Imports Sotware_Farmatics.Conexiones
Public Class frmRegistroproductos

    Dim recipe As Boolean
    Dim producto As Productos

    ' Esta funcion es la que se encargara de modificar y seleccionar productos y mostrarlo en pantalla.
    Private Sub Datos(ByVal tabla As DataTable)
        producto = New Productos(tabla.Rows(0))
        txtCodigoProducto.Text = producto.Id
        txtNombreProducto.Text = producto.Nombre
        txtCantidadProductos.Text = producto.Cantidad_Disponible
        txtPrecioProducto.Text = producto.Valor
        If producto.Recipe Then
            RadioButton1.Select()
        Else
            RadioButton2.Select()
        End If
        cbViaDeAdministracion.SelectedText = producto.Clasificacion

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub frmRegistroproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
        txtNombreProducto.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If txtBusqueda.CausesValidation And txtBusqueda.Text <> String.Empty Then
                If Conexiones.Verificacion("Productos", "CODIGO = " & txtBusqueda.Text) Then
                    Datos(Me.ProductosTableAdapter.GetDataBy1(Integer.Parse(txtBusqueda.Text)))
                Else
                    Dim x As Integer = MsgBox("este ususario no existe... ¿desea registrarlo en la base de datos?", vbQuestion + vbYesNo + vbDefaultButton1, "Prodcuto no encontrado")
                    If x = vbYes Then
                        activarCampos(True)
                    End If
                End If
            Else
                MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ' Aqui debes validar, osea si los Textbox estan vacios, no dejes que se registren en la base de datos, porque saldran errores.
        Try
            If Me.ValidateChildren And cbViaDeAdministracion.SelectedIndex >= 0 And txtCantidadProductos.Text <> String.Empty And txtCodigoProducto.Text <> String.Empty And txtNombreProducto.Text <> String.Empty And txtPrecioProducto.Text <> String.Empty Then
                If Me.ProductosTableAdapter.GetDataByNombre(txtNombreProducto.Text).Rows.Count > 0 Then
                    MsgBox("Este producto existe")
                End If
                Try
                    'Asi se registra un producto a la base de datos.
                    Me.ProductosTableAdapter.InsertQuery(txtNombreProducto.Text, Convert.ToDecimal(txtPrecioProducto.Text), Integer.Parse(txtCantidadProductos.Text), cbViaDeAdministracion.SelectedItem, recipe, Integer.Parse(txtCodigoProducto.Text))
                    Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
                    DataGridView1.Refresh()
                Catch ex As Exception
                    MsgBox("Fallo al registrar el producto - " & ex.Message)
                End Try
            Else
                MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            producto = Nothing
            'Aqui necesito que se limpie los campos!
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        recipe = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        recipe = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        activarCampos(True)
        Datos(Me.ProductosTableAdapter.GetDataBy1(DataGridView1.CurrentRow.Cells(0).Value))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Aqui debes validar que los Textbox no esten vacios para poder modificar un producto!
        Try
            If Me.ValidateChildren And cbViaDeAdministracion.SelectedIndex >= 0 And txtCantidadProductos.Text <> String.Empty And txtCodigoProducto.Text <> String.Empty And txtNombreProducto.Text <> String.Empty And txtPrecioProducto.Text <> String.Empty Then
                Try
                    Me.ProductosTableAdapter.UpdateQuery(txtNombreProducto.Text, Convert.ToDecimal(txtPrecioProducto.Text), Integer.Parse(txtCantidadProductos.Text), cbViaDeAdministracion.SelectedItem, recipe, Integer.Parse(txtCodigoProducto.Text), Integer.Parse(producto.Id))
                    Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
                Catch ex As Exception
                    MsgBox("Fallo al actualizar el producto - " & ex.Message)
                End Try
            Else
                MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            producto = Nothing
            'Aqui necesito que se limpie los campos!
        End Try
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Try
            If Me.ValidateChildren And cbViaDeAdministracion.SelectedIndex >= 0 And txtCantidadProductos.Text <> String.Empty And txtCodigoProducto.Text <> String.Empty And txtNombreProducto.Text <> String.Empty And txtPrecioProducto.Text <> String.Empty Then
                Me.ProductosTableAdapter.DeleteQuery(txtCodigoProducto.Text)
                ' Aqui cuando borres el producto, necesito que se limpie los campos!
                Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)
            Else
                MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'
    '/- Validaciones del formulario -/'
    '/-----------------------------------------------------------------------------------------------------------------/'
    Sub validandoCampo(ByRef Objeto As Object, ByVal largo As Integer)
        If DirectCast(Objeto, TextBox).Text.Length > 0 And DirectCast(Objeto, TextBox).Text.Length < largo Then
            Me.ErrorProvider1.SetError(Objeto, "")
        Else
            Me.ErrorProvider1.SetError(Objeto, "ingrese un dato en esete campo") 'mensage de error
        End If
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'

    Private Sub txtPrecioProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioProducto.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub txtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub txtCantidadProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadProductos.KeyPress
        validandoCampo(sender, 4)
    End Sub

    Private Sub txtCantidadProductos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCantidadProductos.Validating
        validandoCampo(sender, 4)
    End Sub

    Private Sub txtCodigoProducto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodigoProducto.Validating
        validandoCampo(sender, 5)
    End Sub

    Private Sub txtNombreProducto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreProducto.Validating
        validandoCampo(sender, 50)
    End Sub

    Private Sub txtPrecioProducto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecioProducto.Validating
        validandoCampo(sender, 10)
    End Sub

    Private Sub cbViaDeAdministracion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbViaDeAdministracion.Validating
        If DirectCast(sender, ComboBox).SelectedIndex >= 0 Then
        Else
            Me.ErrorProvider1.SetError(sender, "Seleccione un dato de este campo") 'mensage de error
        End If
    End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'
    Private Sub activarCampos(ByVal x As Boolean)
        If x = True Then
            ' Te faltaba poner esto, mejoralo.
            txtCodigoProducto.Text = ""
            txtNombreProducto.Text = ""
            txtCantidadProductos.Text = ""
            txtPrecioProducto.Text = ""
            ' ----------------------------
            btnIngresar.Enabled = True
            btn_Eliminar.Enabled = True
            btnModificar.Enabled = True
            gbCampos.Enabled = True
        Else
            btnIngresar.Enabled = False
            btn_Eliminar.Enabled = False
            btnModificar.Enabled = False
            gbCampos.Enabled = False
        End If
    End Sub
End Class
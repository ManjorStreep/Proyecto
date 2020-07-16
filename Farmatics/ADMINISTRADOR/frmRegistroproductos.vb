Public Class frmRegistroproductos


    Dim recipe As Boolean
    Public producto As Producto

    ' Esta funcion es la que se encargara de modificar y seleccionar productos y mostrarlo en pantalla.
    Private Sub ImprimirDatos()

        ' Cada vez que se llame esta funcion, la variable producto tendra un nuevo valor
        txtCodigoProducto.Text = producto.Codigo
        txtNombreProducto.Text = producto.Nombre
        txtCantidadProductos.Text = producto.Cantidad
        txtPrecioProducto.Text = producto.Precio

        If producto.Prescripcion Then
            RadioButton1.Select()
        Else
            RadioButton2.Select()
        End If

        cbViaDeAdministracion.SelectedText = producto.Administracion

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub frmRegistroproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim d As New Conexion

        d.Llenar(DataGridView1, "Productos")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If txtBusqueda.CausesValidation And txtBusqueda.Text <> String.Empty Then
                producto = New Producto(txtBusqueda.Text)
                If producto.vacio() Then
                    ' Sea el caso de que no existe el producto, se habilitara la opcion para poder registrarlo en la base de datos
                    Dim x As Integer = MsgBox("este producto no existe... ¿desea registrarlo en la base de datos?", vbQuestion + vbYesNo + vbDefaultButton1, "Prodcuto no encontrado")
                    If x = vbYes Then
                        activarCampos(True)

                    End If
                Else
                    ImprimirDatos()
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
        If Me.ValidateChildren And cbViaDeAdministracion.SelectedIndex >= 0 And txtCantidadProductos.Text <> String.Empty And txtCodigoProducto.Text <> String.Empty And txtNombreProducto.Text <> String.Empty And txtPrecioProducto.Text <> String.Empty Then
            ' Aqui se intenta registrar el producto en la base de datos
            producto.Registrar(Integer.Parse(txtCodigoProducto.Text), txtNombreProducto.Text, Integer.Parse(txtCantidadProductos.Text), Convert.ToDecimal(txtPrecioProducto.Text), recipe, cbViaDeAdministracion.SelectedItem)
            producto.Llenar(DataGridView1)

        Else
            MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        recipe = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        recipe = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Cuando se hace click sobre algun producto del DataGridView se rellenara los campos necesarios para editarlos
        activarCampos(True)
        producto = New Producto(DataGridView1.CurrentRow.Cells(0).Value)
        ImprimirDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Me.ValidateChildren And cbViaDeAdministracion.SelectedIndex >= 0 And txtCantidadProductos.Text <> String.Empty And txtCodigoProducto.Text <> String.Empty And txtNombreProducto.Text <> String.Empty And txtPrecioProducto.Text <> String.Empty Then
            producto.Modificar(txtCodigoProducto.Text, txtNombreProducto.Text, txtCantidadProductos.Text, txtPrecioProducto.Text, recipe, cbViaDeAdministracion.SelectedItem)
            producto.Llenar(DataGridView1)
        Else
            MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If Me.ValidateChildren And cbViaDeAdministracion.SelectedIndex >= 0 And txtCantidadProductos.Text <> String.Empty And txtCodigoProducto.Text <> String.Empty And txtNombreProducto.Text <> String.Empty And txtPrecioProducto.Text <> String.Empty Then
            ' Esta funcion es la encargada de eliminar registros de la taba Productos en la base de datos!
            ' Una vez actualizado los registros, con esta funcion se debe actualizar la informacion de DataGridView
            ' ERROR: Aqui cuando borres el producto, necesito que se limpie los campos!
            producto.Eliminar()
            producto.Llenar(DataGridView1)
        Else
            MessageBox.Show("ingrese datos en los campos", "registro de usuarios", MessageBoxButtons.OK)
        End If
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
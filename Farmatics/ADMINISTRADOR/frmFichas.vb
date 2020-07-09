Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmFichas

    Dim empleado As Empleado

    Private Sub frmFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DatabaseDataSet.Empleados)
    End Sub

    Private Sub btbusqueda_Click(sender As Object, e As EventArgs) Handles btbusqueda.Click
        If Conexiones.Verificacion("Empleados", "CEDULA ='" & TextBox1.Text & "'") Then
            ImprimirDatos(New Empleado(TextBox1.Text))
        Else
            ' QUiero que aqui pongas una ventana que te pregunte si o no :v
            ' Si apreta que SI, le habilitas el GroupBox3.Enable = True
            ' Limpia primero todos los TextBox y esas cosas para que pueda escribir sin problemas.
            MsgBox("Usuario no registrardo, desea registrar?")
            GroupBox1.Enabled = True
            txt_DNI.Text = TextBox1.Text
            txt_DNI.Focus()
        End If
    End Sub


    Private Sub ImprimirDatos(ByVal datos As Empleado)
        empleado = datos
        txt_nombre.Text = datos.Nombre
        txt_apellido.Text = datos.Apellido
        txt_direccion.Text = datos.Direccion
        txt_correo.Text = datos.Correo
        txt_telefono.Text = datos.Telefono
        txt_DNI.Text = datos.Cedula
        txt_clave.Text = datos.Clave

        If datos.Sexo = "Masculino" Then
            rb_hombre.Select()
        Else
            rb_mujer.Select()
        End If

    End Sub

    Private Sub Usuarios1DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Usuarios1DataGridView.CellClick
        ImprimirDatos(New Empleado(Integer.Parse(Usuarios1DataGridView.CurrentRow.Cells(2).Value)))
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Conexiones.Verificacion("Empleados", "CEDULA ='" & TextBox1.Text & "'") Then
            Me.EmpleadosTableAdapter.EliminarEmpleado(TextBox1.Text)
        ElseIf Conexiones.Verificacion("Empleados", "CEDULA ='" & txt_DNI.Text & "'") Then
            Me.EmpleadosTableAdapter.EliminarEmpleado(txt_DNI.Text)
        End If
        Me.EmpleadosTableAdapter.Fill(Me.DatabaseDataSet.Empleados)

    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
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

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        DatosSistema.SoloLetras(e)
    End Sub

    Private Sub txt_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido.KeyPress
        DatosSistema.SoloLetras(e)
    End Sub

    Private Sub txt_DNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_DNI.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        DatosSistema.SoloNumeros(e)
    End Sub

    Private Sub txt_telefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_telefono.Validating
        validandoCampo(sender, 11)
    End Sub

    Private Sub txt_nombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nombre.Validating
        validandoCampo(sender, 20)
    End Sub

    Private Sub txt_DNI_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_DNI.Validating
        validandoCampo(sender, 8)
    End Sub

    Private Sub txt_direccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_direccion.Validating
        validandoCampo(sender, 50)
    End Sub

    Private Sub txt_correo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_correo.Validating
        validandoCampo(sender, 50)
    End Sub

    Private Sub txt_clave_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_clave.Validating
        validandoCampo(sender, 20)
    End Sub

    Private Sub txt_apellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_apellido.Validating
        validandoCampo(sender, 20)
    End Sub

    Private Sub cb_cargo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_cargo.Validating
        If DirectCast(sender, ComboBox).SelectedItem <> 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "ingrese un dato en esete campo") 'mensage de error
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    ' ---------------------------------------------------------------------------------------

    'Este boton es para habilitar los el GroupBox1
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        GroupBox1.Enabled = True
    End Sub

    ' Aqui vas a validar que ningun campoo este vacio y impedir que se registren!
    ' Este boton sera el que actualize la base de datos.
    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If String.IsNullOrEmpty(txt_DNI.Text) Then
            MsgBox("No has ingresado datos para registrar")
            Return
        End If

        Dim sexo As String
        If rb_hombre.Checked Then
            sexo = rb_hombre.Text
        Else
            sexo = rb_mujer.Text
        End If
        MsgBox(System.DateTime.Now)
        If Conexiones.Verificacion("Empleados", "CEDULA ='" & txt_DNI.Text & "'") Then
            If empleado.vacio() Then
                Try
                    ' Aqui da error porque falta poner un valor por defecto al combobox
                    Me.EmpleadosTableAdapter.ActualizarEmpleado(txt_nombre.Text, txt_apellido.Text, txt_DNI.Text, txt_telefono.Text, txt_correo.Text, txt_direccion.Text, sexo, cb_cargo.SelectedItem, empleado.FechaIngreso, txt_clave.Text, empleado.Cedula)
                    ' Aqui da otro error porque no puede recibir un campo vacio desde la base de datos, y el campo vacio se genera porque el combobox no tiene un valor por defecto.
                    ImprimirDatos(New Empleado(txt_DNI.Text))
                    Me.EmpleadosTableAdapter.Fill(Me.DatabaseDataSet.Empleados)
                Catch ex As Exception
                    MsgBox("Error al tratar de registrar empleado en la base de datos")
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            Try
                Me.EmpleadosTableAdapter.AgregarEmpleado(txt_nombre.Text, txt_apellido.Text, txt_DNI.Text, txt_telefono.Text, txt_correo.Text, txt_direccion.Text, sexo, cb_cargo.SelectedItem, System.DateTime.Now, txt_clave.Text)
                Me.EmpleadosTableAdapter.Fill(Me.DatabaseDataSet.Empleados)
                MsgBox("Usuario registrado con exito")
            Catch ex As Exception
                MsgBox("Error al registrar usuario")
            End Try
        End If
        ' Esto es muy importante
        empleado = Nothing
    End Sub
End Class
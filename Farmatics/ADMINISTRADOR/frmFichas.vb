Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Sotware_Farmatics
Public Class frmFichas

    Public empleado As Empleado

    Private Sub frmFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empleado.Llenar(Usuarios1DataGridView)
    End Sub

    Private Sub btbusqueda_Click(sender As Object, e As EventArgs) Handles btbusqueda.Click
        If txt_Busqueda.Text <> String.Empty Then
            empleado = New Empleado(txt_Busqueda.Text)
            If Not empleado.vacio() Then
                ImprimirDatos()
            Else
                ' ERROR: QUiero que aqui pongas una ventana que te pregunte si o no :v
                ' Seal el caso donde el usuario no exista, se debe activar los campos correspondites para su registros
                Dim x As Integer = MsgBox("este ususario no existe... ¿desea registrarlo en la base de datos?", vbQuestion + vbYesNo + vbDefaultButton1, "Prodcuto no encontrado")
                ' ERROR: Limpia primero todos los TextBox y esas cosas para que pueda escribir sin problemas.
                If x = vbYes Then
                    ' ERROR: Si apreta que SI, le habilitas el GroupBox3.Enable = True
                    Limpiar()
                    GroupBox1.Enabled = True
                    btn_registrar.Enabled = True
                    txt_DNI.Text = txt_Busqueda.Text
                    txt_DNI.Focus()
                End If
            End If
            
        Else
            MsgBox("Ingrese un dato en el campo")
        End If

    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        ' Este boton sera el que actualize la base de datos.
        If Me.ValidateChildren And cb_cargo.SelectedIndex >= 0 And txt_apellido.Text <> String.Empty And txt_clave.Text <> String.Empty And txt_correo.Text <> String.Empty And txt_direccion.Text <> String.Empty And txt_DNI.Text <> String.Empty And txt_nombre.Text <> String.Empty And txt_telefono.Text <> String.Empty Then
            Dim sexo As String
            If rb_hombre.Checked Then
                sexo = rb_hombre.Text
            Else
                sexo = rb_mujer.Text
            End If
            empleado = New Empleado()
            If empleado.vacio() Then
                empleado.Registrar(txt_nombre.Text, txt_apellido.Text, "Venezolana", txt_DNI.Text, DateTime.Now, cb_cargo.SelectedItem, txt_clave.Text, txt_direccion.Text, txt_telefono.Text, sexo, txt_correo.Text)
                empleado.Llenar(Usuarios1DataGridView)
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If empleado.vacio() Then
            Return
        End If
        empleado.Eliminar()
        empleado.Llenar(Usuarios1DataGridView)
        Limpiar()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If GroupBox1.Enabled = False Then
            GroupBox1.Enabled = True
            Return
        End If
        Dim sexo As String
        If rb_hombre.Checked Then
            sexo = rb_hombre.Text
        Else
            sexo = rb_mujer.Text
        End If
        empleado.Modificar(txt_nombre.Text, txt_apellido.Text, "Venezolana", txt_DNI.Text, DateTime.Now, cb_cargo.SelectedItem, txt_clave.Text, txt_direccion.Text, txt_telefono.Text, sexo, txt_correo.Text)
        empleado.Llenar(Usuarios1DataGridView)
        Limpiar()

    End Sub

    Private Sub Usuarios1DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Usuarios1DataGridView.CellClick
        ' Cuando se seleccione un Empleado en el DatGridView se habilitaran los botones de registro, eliminar y editar
        btn_eliminar.Enabled = True
        btn_editar.Enabled = True
        ' Se debe seleccionar el empleados con los datos de la fila seleccionada y rellenar los campos necesarios
        empleado = New Empleado(Usuarios1DataGridView.CurrentRow.Cells("Cedula").Value)
        ImprimirDatos()
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    ' ---------------------------------------------------------------------------------------
    '/- Funciones propias del formulario -/'
    ' ---------------------------------------------------------------------------------------
    ' Esta funcion se encaraga de poner la informacion del empleado en sus respectivos campos
    Private Sub ImprimirDatos()
        ' Cada vez que se llame esta funcion, la variable empleado tendra un nuevo valor
        txt_nombre.Text = empleado.Nombre
        txt_apellido.Text = empleado.Apellido
        txt_direccion.Text = empleado.Direccion
        txt_correo.Text = empleado.Correo
        txt_telefono.Text = empleado.Telefono
        txt_DNI.Text = empleado.Cedula
        txt_clave.Text = empleado.Clave
        cb_cargo.Text = empleado.Cargo
        If empleado.Sexo = "Masculino" Then
            rb_hombre.Select()
        Else
            rb_mujer.Select()
        End If

    End Sub

    ' Funcion que se encarga de limpiar los campos y la variable empleado
    Private Sub Limpiar()
        If GroupBox1.Enabled Or Not String.IsNullOrEmpty(txt_DNI.Text) Then
            empleado = Nothing
            GroupBox1.Enabled = False
            txt_apellido.Text = ""
            txt_clave.Text = ""
            txt_correo.Text = ""
            txt_direccion.Text = ""
            txt_DNI.Text = ""
            txt_nombre.Text = ""
            txt_telefono.Text = ""
            btn_registrar.Enabled = False
            btn_eliminar.Enabled = False
            btn_editar.Enabled = False
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
        If DirectCast(sender, ComboBox).SelectedIndex = 0 Then
            Me.ErrorProvider1.SetError(sender, "ingrese un dato en esete campo") 'mensage de error
        End If
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmFichas
    Dim datos As Empleado

    Private Sub frmFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btbusqueda_Click(sender As Object, e As EventArgs) Handles btbusqueda.Click
        
    End Sub

    
    Private Sub ImprimirDatos(ByVal consulta As List(Of String))
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

    Private Sub Usuarios1DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Usuarios1DataGridView.CellDoubleClick
        Dim datos As New List(Of String)
        For numero As Integer = 0 To Usuarios1DataGridView.ColumnCount - 1
            datos.Add(Convert.ToString(Usuarios1DataGridView.CurrentRow.Cells(numero).Value))
        Next

        ImprimirDatos(datos)

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        'esperando codigo
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
End Class
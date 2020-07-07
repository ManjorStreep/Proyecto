Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmFichas
    Dim datos As Empleado

    Private Sub frmFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btbusqueda_Click(sender As Object, e As EventArgs) Handles btbusqueda.Click
        
    End Sub

    
    Private Sub ImprimirDatos(ByVal consulta As List(Of String))
        datos = New Empleado(consulta)
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

    End Sub




    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub
End Class
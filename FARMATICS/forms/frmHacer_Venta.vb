Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmHacer_Venta
    Dim ruta As String = "Data Source=DESKTOP-IJ5FIDU\SQLEXPRESS;Initial Catalog=MainData;Integrated Security=True"
    Private Sub frmHacer_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
    Public Sub asd()
        'Dim x As String
        'x = TextBox13.Text
        'Try
        '    If TextBox13.Text <> "" Then
        '        'Aqui se iniciara la conexion a la base de datos 
        '        Dim ejecutar As New SqlCommand("select * from clientes where dni = '" & x & "'", conexion_clientes.conexiones)
        '        Dim l As SqlDataReader = ejecutar.ExecuteReader
        '        If l.HasRows = True Then
        '            Dim a, b As String
        '            While l.Read
        '                a = l(1)
        '                b = l(2)
        '                TextBox12.Text = a + b
        '                TextBox11.Text = l(4)
        '                TextBox10.Text = l(5)
        '            End While
        '        Else
        '            'en caso de que no exista en la base de datos ; Habilite el formulario
        '            Conexion.conexiones.Close()
        '            MsgBox("No existe este cliente , o no esta registrado en el sistema,Rellene el formulario de registro aparte", MsgBoxStyle.Information)
        '            frmGestion_Cliente.Show()
        '        End If
        '    Else
        '        MsgBox("Ingrese una Cedula valida")
        '        Conexion.conexiones.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Inventario_completo.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Refresh()
    End Sub



End Class
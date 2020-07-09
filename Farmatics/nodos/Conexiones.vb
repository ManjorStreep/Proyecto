Imports System.Data.OleDb
Imports System.Text
Module Conexiones
    Dim SESSION As Boolean
    ' Declaracion de variables a usar en el modulo.
    Public Conexion As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb")
    Public Comando As OleDbCommand
    Public Lector As OleDbDataReader

    Public Function Verificacion(ByVal tabla As String, ByVal consulta As String)
        Dim regresar As Boolean = False
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM " & tabla & " WHERE " & consulta, Conexion)
            Lector = Comando.ExecuteReader()
            regresar = Lector.HasRows()
            Lector.Close()
        Catch ex As Exception
            MsgBox("Error al verificar en la base de datos - " & ex.Message)
        Finally
            Conexion.Close()
        End Try

        Return regresar
    End Function

    Public Function login(ByVal user As String, ByVal pass As String)

        If Verificacion("Empleados", "CEDULA ='" & user & "' AND CLAVE ='" & pass & "'") Then
            If Verificacion("Empleados", "CEDULA ='" & user & "' AND CARGO = 'Dueño' OR " & "CEDULA ='" & user & "' AND CARGO = 'Gerente'") Then
                frmMenu.Trabajador(user)
                frmMenu.Show()
            Else
                frmCaja.Trabajador(user)
                frmCaja.Show()
            End If
            SESSION = True
        Else
            MsgBox("Usuario no existe")
            SESSION = False
        End If
        Return SESSION
    End Function

End Module

Module DatosSistema

    Public Function obtenerFecha(Optional ByVal Opcion As String = "")
        Dim fechaActual As Date = Date.Now
        Dim horaActual As TimeSpan = Date.Now.TimeOfDay
        Select Case Opcion
            Case "Fecha"
                Return fechaActual.ToString
            Case "Hora"
                Return horaActual.ToString
        End Select
        Return fechaActual + horaActual
    End Function

End Module

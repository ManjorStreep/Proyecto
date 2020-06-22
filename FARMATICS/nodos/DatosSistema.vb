Module DatosSistema

    Public Function obtenerFecha(Optional ByVal fecha_hora As Boolean = 0)
        Dim fechaActual As Date = Date.Now
        Dim horaActual As TimeSpan = Date.Now.TimeOfDay
        Select Case fecha_hora
            Case 0
                Return fechaActual.ToString
            Case 1
                Return horaActual.ToString
        End Select
        Return fechaActual + horaActual
    End Function

End Module

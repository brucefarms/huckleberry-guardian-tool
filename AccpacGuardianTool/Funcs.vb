Public Class Funcs

    Shared Function SerialDate() As String
        Dim ToReturn As String
        ToReturn = Date.Today.Year & PadZeros(Date.Today.Month, 2) & PadZeros(Date.Today.Day, 2)
        ToReturn &= PadZeros(Date.Now.Hour, 2) & PadZeros(Date.Now.Minute, 2) & PadZeros(Date.Now.Second, 2)
        Return ToReturn
    End Function

    Shared Function PadZeros(ByVal obj As Integer, ByVal pCount As Integer) As String
        Return Right("000000000" & obj, pCount)
    End Function

End Class

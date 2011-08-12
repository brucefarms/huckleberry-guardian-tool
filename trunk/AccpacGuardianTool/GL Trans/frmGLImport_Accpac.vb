Partial Class frmGLImport

    Public Session As AccpacCOMAPI.AccpacSession
    Public DBLink As AccpacCOMAPI.AccpacDBLink

    Function UpdateCNTBTCH() As Boolean
        Try
            Dim v As AccpacCOMAPI.AccpacView = Nothing
            DBLink.OpenView("GL0008", v)

            v.Browse("BATCHID=" & Funcs.PadZeros(txtCNTBTCH.Text, 6), True)
            Do While v.Fetch
                Me.txtBTCHDESC.Text = v.Fields.FieldByName("BTCHDESC").Value
                Me.rbExistingBatch.Checked = True
                Return True
            Loop

            Return False
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

End Class

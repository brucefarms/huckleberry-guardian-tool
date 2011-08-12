Public Class GLBatch

    Private session As AccpacCOMAPI.AccpacSession
    Private DBLink As AccpacCOMAPI.AccpacDBLink
    Private GLAcct As GLAccounts

    Dim GLBATCH1batch As AccpacCOMAPI.AccpacView
    Dim GLBATCH1batchFields As AccpacCOMAPI.AccpacViewFields
    Dim GLBATCH1header As AccpacCOMAPI.AccpacView
    Dim GLBATCH1headerFields As AccpacCOMAPI.AccpacViewFields
    Dim GLBATCH1detail1 As AccpacCOMAPI.AccpacView
    Dim GLBATCH1detail1Fields As AccpacCOMAPI.AccpacViewFields
    Dim GLBATCH1detail2 As AccpacCOMAPI.AccpacView
    Dim GLBATCH1detail2Fields As AccpacCOMAPI.AccpacViewFields

    Public Sub New(ByVal s As AccpacCOMAPI.AccpacSession)
        session = s
        GLAcct = New GLAccounts(session)

        DBLink = session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)

        DBLink.OpenView("GL0008", GLBATCH1batch)
        GLBATCH1batchFields = GLBATCH1batch.Fields
        DBLink.OpenView("GL0006", GLBATCH1header)
        GLBATCH1headerFields = GLBATCH1header.Fields
        DBLink.OpenView("GL0010", GLBATCH1detail1)
        GLBATCH1detail1Fields = GLBATCH1detail1.Fields
        DBLink.OpenView("GL0402", GLBATCH1detail2)
        GLBATCH1detail2Fields = GLBATCH1detail2.Fields

        GLBATCH1batch.Compose(New Object() {GLBATCH1header})
        GLBATCH1header.Compose(New Object() {GLBATCH1batch, GLBATCH1detail1})
        GLBATCH1detail1.Compose(New Object() {GLBATCH1header, GLBATCH1detail2})
        GLBATCH1detail2.Compose(New Object() {GLBATCH1detail1})
    End Sub

    Public Function CreateBatch(ByVal btchdesc As String) As Boolean
        Try
            GLBATCH1header.RecordCreate(2)
            GLBATCH1batchFields.FieldByName("BTCHDESC").PutWithoutVerification(btchdesc)
            'GLBATCH1batch.Update()
            Return True
        Catch ex As Exception
            Dim strErr As String = Nothing
            If session.Errors.Count > 0 Then
                For i As Integer = 0 To session.Errors.Count - 1
                    strErr &= session.Errors.Item(i) & vbNewLine & "--" & vbNewLine
                Next
            End If
            MsgBox(strErr & ex.ToString)

            Return False
        End Try
    End Function

    Public Function CreateBatch(ByVal btchid As Integer) As Boolean
        GLBATCH1batch.Browse("BATCHID=" & Funcs.PadZeros(btchid, 6), True)
        If Not GLBATCH1batch.Fetch Then
            Select Case MsgBox(Format("GL Batch {0} not found", btchid), MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    CreateBatch("")
                    Return True
                Case MsgBoxResult.No
                    Return False
            End Select
        End If
    End Function

    Sub CreateJE()
        GLBATCH1header.RecordCreate(2)
        GLBATCH1headerFields.FieldByName("SRCETYPE").Value = "CO"
    End Sub

    Sub SaveJE()
        Try
            GLBATCH1header.Update()
            GLBATCH1header.Insert()

        Catch ex As Exception
            Dim strErr As String = Nothing
            If session.Errors.Count > 0 Then
                For i As Integer = 0 To session.Errors.Count - 1
                    strErr &= session.Errors.Item(i) & vbNewLine & "--" & vbNewLine
                Next
            End If
            MsgBox(session.Errors.Count & vbNewLine & strErr & "----------------" & vbNewLine & ex.ToString)
            session.Errors.Clear()
        End Try
    End Sub

    Sub AddLine(ByVal ACCTID As String, ByVal SCURNAMT As String)
        Try
            GLAcct.CreateGLAccount(ACCTID)

            GLBATCH1detail1.RecordCreate(0)
            GLBATCH1detail1Fields.FieldByName("ACCTID").Value = "10010000000" 'ACCTID
            GLBATCH1detail1.Process()
            GLBATCH1detail1Fields.FieldByName("SCURNAMT").Value = SCURNAMT
            GLBATCH1detail1.Insert()

        Catch ex As Exception
            Dim strErr As String = Nothing
            If session.Errors.Count > 0 Then
                For i As Integer = 0 To session.Errors.Count - 1
                    strErr &= session.Errors.Item(i) & vbNewLine & "--" & vbNewLine
                Next
            End If
            MsgBox(strErr & ex.ToString)
            session.Errors.Clear()
        End Try
    End Sub

End Class

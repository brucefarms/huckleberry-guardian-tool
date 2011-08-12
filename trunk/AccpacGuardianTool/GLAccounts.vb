Public Class GLAccounts

    Private session As AccpacCOMAPI.AccpacSession
    Private DBLink As AccpacCOMAPI.AccpacDBLink

    Public Sub New(ByVal s As AccpacCOMAPI.AccpacSession)
        session = s
        DBLink = session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)
    End Sub

    Public Function CreateGLAccount(ByVal acct As String, Optional ByVal AutoCreateSeg As Boolean = True)
        Try
            Dim vGL0001 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0001", vGL0001)

            Dim GLACCOUNT1detail1 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0004", GLACCOUNT1detail1)
            Dim GLACCOUNT1detail2 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0012", GLACCOUNT1detail2)
            Dim GLACCOUNT1detail3 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0107", GLACCOUNT1detail3)
            Dim GLACCOUNT1detail4 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0400", GLACCOUNT1detail4)
            Dim GLACCOUNT1detail5 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0401", GLACCOUNT1detail5)
            Dim GLACCOUNT1detail6 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0057", GLACCOUNT1detail6)
            Dim GLACCOUNT1detail7 As AccpacCOMAPI.AccpacView
            DBLink.OpenView("GL0063", GLACCOUNT1detail7)

            vGL0001.Compose(New Object() {Nothing, GLACCOUNT1detail1, GLACCOUNT1detail2, Nothing, GLACCOUNT1detail3, GLACCOUNT1detail4, GLACCOUNT1detail5, GLACCOUNT1detail6, GLACCOUNT1detail7})
            GLACCOUNT1detail1.Compose(New Object() {vGL0001})
            GLACCOUNT1detail2.Compose(New Object() {vGL0001, Nothing})
            GLACCOUNT1detail3.Compose(New Object() {vGL0001})
            GLACCOUNT1detail4.Compose(New Object() {vGL0001})
            GLACCOUNT1detail5.Compose(New Object() {vGL0001})
            GLACCOUNT1detail6.Compose(New Object() {vGL0001})
            GLACCOUNT1detail7.Compose(New Object() {vGL0001})

            Dim segs As String() = acct.Split("-")
            For i As Integer = 1 To segs.Length - 1
                Me.CreateSeg(i + 1, segs(i))
            Next
            
            Dim strAcct As String

            vGL0001.Fields.FieldByName("ACCTID").PutWithoutVerification(acct.Replace("-", ""))
            vGL0001.Read()
            strAcct = Trim(vGL0001.Fields.FieldByName("ACCTFMTTD").Value)
            If Len(strAcct) > 0 Then Return True

            vGL0001.Fields.FieldByName("ACCTID").PutWithoutVerification(Replace(acct, "-", ""))
            vGL0001.Fields.FieldByName("PROCESSCMD").PutWithoutVerification("1")
            vGL0001.Fields.FieldByName("ACCTFMTTD").PutWithoutVerification(acct)
            vGL0001.Process()

            vGL0001.Fields.FieldByName("PROCESSCMD").PutWithoutVerification("7")
            vGL0001.Fields.FieldByName("ACCTDESC").PutWithoutVerification(acct)

            vGL0001.Process()
            vGL0001.Insert()

            Return True
        Catch ex As Exception
            Dim strErr As String = Nothing
            If session.Errors.Count > 0 Then
                For i As Integer = 0 To session.Errors.Count - 1
                    strErr &= session.Errors.Item(i) & vbNewLine & "--" & vbNewLine
                Next
            End If
            MsgBox(strErr & ex.ToString)
            session.Errors.Clear()
            Return False
        End Try
    End Function

    Public Function CreateSeg(ByVal IDSEG As String, ByVal SEGVAL As String) As Boolean
        Try
            Dim vGLSEG As AccpacCOMAPI.AccpacView = Nothing
            Dim vGLSEGFields As AccpacCOMAPI.AccpacViewFields
            DBLink.OpenView("GL0021", vGLSEG)
            vGLSEGFields = vGLSEG.Fields

            Dim StrBrowse As String = String.Format("SEGVAL = ""{0}"" AND IDSEG = ""{1}""", SEGVAL, Funcs.PadZeros(IDSEG, 6))

            vGLSEG.Browse(StrBrowse, True)

            If vGLSEG.Fetch Then Return True

            vGLSEG.RecordCreate(0)

            vGLSEGFields.FieldByName("SEGVAL").Value = SEGVAL
            vGLSEGFields.FieldByName("IDSEG").Value = Funcs.PadZeros(IDSEG, 6)

            vGLSEG.Insert()
            vGLSEG.Post()

            Return True
        Catch ex As Exception
            Dim strErr As String = Nothing
            If session.Errors.Count > 0 Then
                For i As Integer = 0 To session.Errors.Count - 1
                    MsgBox(session.Errors.Item(i))
                    strErr &= session.Errors.Item(i) & vbNewLine & "--" & vbNewLine
                Next
            End If
            MsgBox(strErr & ex.ToString)
            session.Errors.Clear()
            Return False
        End Try
    End Function

End Class

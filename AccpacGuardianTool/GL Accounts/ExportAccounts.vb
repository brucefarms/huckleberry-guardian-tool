Imports System.IO

Public Class ExportAccounts

    Private Session As AccpacCOMAPI.AccpacSession
    Private DBlink As AccpacCOMAPI.AccpacDBLink

    Private fiPath As FileInfo
    Private fiTempFile As FileInfo

    Private res As String

    Sub New(ByVal s As AccpacCOMAPI.AccpacSession)
        Session = s

        DBlink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)
    End Sub

    Public Sub ExportAccount(ByVal filepath As String, Optional ByVal FilterString As String = "")
        FilterString = String.Format("<Criteria>{0}</Criteria>", System.Web.HttpUtility.HtmlEncode(FilterString))

        fiPath = New FileInfo(filepath)
        fiTempFile = New FileInfo(Path.Combine(Environ("TEMP"), "GLAccounts.xml"))

        Dim IE As New AccpacImportExport.ImportExport

        IE.Open(DBlink)
        IE.SetView("GL0001", "", AccpacImportExport.tagViewType.VIEW_FLAT, Nothing)

        IE.ExecuteExportScript("", True)

        Dim ScriptPath, TempScriptPath
        TempScriptPath = Path.Combine(Environ("TEMP"), "GLAccountsExp.xml")

        Dim strXML As String = "<?xml version=""1.0"" encoding=""utf-8""?><AccpacImpExp Action=""8"" ProgramName=""GL1100"" Type=""EXPORT"" Version=""532"" ExportDateLocale=""3084""><VIEW ID=""GL0001"" Type=""0"" Action=""0"" AllFieldSelected=""1"">{0}<TABLE>Accounts</TABLE></VIEW><DBNAME>{1}</DBNAME><DBTYPE>XML</DBTYPE></AccpacImpExp>"

        Dim StreamWriter As StreamWriter
        StreamWriter = File.CreateText(TempScriptPath)

        StreamWriter.Write(String.Format(strXML, FilterString, fiTempFile.FullName))
        StreamWriter.Close()

        IE.ExecuteExportScript(TempScriptPath, True)

        'IE.GetExecuteResult(res)

        'For i As Integer = 0 To Session.Errors.Count - 1
        '    MsgBox(Session.Errors.Item(i).ToString)
        'Next
        'Session.Errors.Clear()

        Try
            Dim ds As New DataSet
            Dim fs As New FileStream(fiTempFile.FullName, FileMode.Open)
            ds.ReadXml(fs)
            fs.Close()

            Dim dt As New dsGuardian._Account_txtDataTable
            Dim dr As dsGuardian._Account_txtRow

            For Each drA As DataRow In ds.Tables("GL0001").Rows
                dr = dt.New_Account_txtRow
                dr._Account_ = drA("ACCTFMTTD")
                dr.Description = drA("ACCTDESC")
                dr.Status = CInt(drA("ACTIVESW"))
                dt.Rows.Add(dr)
            Next

            If fiPath.Exists Then fiPath.Delete()

            Dim sw As New StreamWriter(fiPath.FullName, False)
            Dim icolcount As Integer = dt.Columns.Count

            For i As Integer = 0 To dt.Columns.Count - 1
                sw.Write(String.Format("""{0}""", dt.Columns(i).ColumnName))
                If i < icolcount - 1 Then
                    sw.Write(",")
                End If
            Next
            sw.Write(sw.NewLine)

            For Each drow As DataRow In dt.Rows
                For i As Integer = 0 To icolcount - 1
                    If Not Convert.IsDBNull(drow(i)) Then
                        sw.Write(String.Format("""{0}""", drow(i).ToString()))
                    End If
                    If i < icolcount - 1 Then
                        sw.Write(",")
                    End If
                Next
                sw.Write(sw.NewLine)
            Next
            sw.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class

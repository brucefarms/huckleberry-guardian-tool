Imports System.IO

Public Class ExportVendors

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
        fiTempFile = New FileInfo(Path.Combine(Environ("TEMP"), "APVendors.xml"))

        Dim IE As New AccpacImportExport.ImportExport

        IE.Open(DBlink)
        IE.SetView("AP0015", "", AccpacImportExport.tagViewType.VIEW_FLAT, Nothing)

        ' IE.ExecuteExportScript("", True)

        Dim ScriptPath, TempScriptPath
        TempScriptPath = Path.Combine(Environ("TEMP"), "APVendorsExp.xml")

        Dim strXML As String = String.Format("<?xml version=""1.0"" encoding=""utf-8""?><AccpacImpExp Action=""8"" ProgramName=""AP1200"" Type=""EXPORT"" Version=""532"" ExportDateLocale=""3084""><VIEW ID=""AP0015"" Type=""2"" Action=""0"" AllFieldSelected=""1"">{0}<TABLE>Vendors</TABLE></VIEW><VIEW ID=""AP0407"" Type=""8"" Action=""4096"" Parent=""AP0015"" AllFieldSelected=""0""><TABLE>Vendor_Optional_Field_Values</TABLE></VIEW><DBNAME>%%FULLFILEPATH%%</DBNAME><DBTYPE>XML</DBTYPE></AccpacImpExp>", FilterString)

        Dim StreamWriter As StreamWriter
        StreamWriter = File.CreateText(TempScriptPath)

        StreamWriter.Write(strXML.Replace("%%FULLFILEPATH%%", fiTempFile.FullName))
        StreamWriter.Close()

        IE.ExecuteExportScript(TempScriptPath, True)

        For i As Integer = 0 To Session.Errors.Count - 1
            MsgBox(Session.Errors.Item(i).ToString)
        Next
        Session.Errors.Clear()

        Try
            Dim ds As New dsGuardian
            Dim fs As New FileStream(fiTempFile.FullName, FileMode.Open)
            ds.ReadXml(fs)
            fs.Close()

            Dim dt As New dsGuardian._Supplier_txtDataTable
            Dim dr As dsGuardian._Supplier_txtRow

            For Each drA As dsGuardian.AP0015Row In ds.AP0015.Rows
                dr = dt.New_Supplier_txtRow
                dr.Num = drA.VENDORID
                dr.Name = drA.VENDNAME
                dr.BillAddr1 = drA.TEXTSTRE1
                dr.BillAddr2 = drA.TEXTSTRE2
                dr.BillCity = drA.NAMECITY
                dr.BillStatProv = drA.CODESTTE
                dr.BillPC = drA.CODEPSTL
                dr.Phone = drA.TEXTPHON1
                dr.Fax = drA.TEXTPHON2
                dr.Contact = drA.NAMECTAC
                dr.Email = drA.EMAIL1
                dr.Status = drA.SWACTV
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
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class

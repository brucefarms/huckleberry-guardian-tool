Imports System.IO

Partial Class frmAPImport

    Dim comLink As AccpacCOMAPI.AccpacDBLink
    Dim res As String

    Sub ImportToAccpac(ByVal fiTemp As FileInfo)
        comLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)

        If rbNewBatch.Checked Then
            Try
                txtCNTBTCH.Text = CreateAPInvoiceBatch(txtBTCHDESC.Text)
            Catch ex As Exception
                Dim f As New frmImportResults(Session, "")
                f.Show()
                Exit Sub
            End Try
        End If

        Dim IE As New AccpacImportExport.ImportExport

        IE.Open(comLink)

        IE.SetView("AP0020", "", AccpacImportExport.tagViewType.VIEW_BATCH, Nothing)
        IE.SetView("AP0021", "AP0020", AccpacImportExport.tagViewType.VIEW_SEQUENCED_HEADER, Nothing)
        IE.SetView("AP0022", "AP0021", AccpacImportExport.tagViewType.VIEW_DETAIL_SEQUENCED, Nothing)
        IE.SetBatchNumber(txtCNTBTCH.Text)
        IE.VerifyOnPut = True

        Dim ScriptPath, TempScriptPath
        TempScriptPath = Path.Combine(Environ("TEMP"), "APIMPORT.xml")

        Dim strXML As String = "<?xml version=""1.0"" encoding=""utf-8""?><AccpacImpExp Action=""16"" ProgramName=""AP2100"" Type=""IMPORT"" Version=""532"" HasTitleRecord=""1""><VIEW ID=""AP0020"" Type=""4"" Action=""0""><TABLE>Invoice_Batches</TABLE></VIEW><VIEW ID=""AP0021"" Type=""3"" Action=""0"" Parent=""AP0020"" SelectedIDs=""1 2 3 4 6 9 10 11 15 ""><TABLE>Invoices</TABLE></VIEW><VIEW ID=""AP0022"" Type=""9"" Action=""0"" Parent=""AP0021"" SelectedIDs=""1 2 3 34 ""><TABLE>Invoice_Details</TABLE></VIEW><VIEW ID=""AP0023"" Type=""9"" Action=""0"" Parent=""AP0021"" SelectedIDs=""1 2 3 ""><TABLE>Invoice_Payment_Schedules</TABLE></VIEW><VIEW ID=""AP0402"" Type=""8"" Action=""4096"" Parent=""AP0021""><TABLE>Invoice_Optional_Fields</TABLE></VIEW><VIEW ID=""AP0401"" Type=""8"" Action=""4096"" Parent=""AP0022""><TABLE>Invoice_Detail_Optional_Fields</TABLE></VIEW><DBNAME>%%FULLFILEPATH%%</DBNAME><DBTYPE>Single CSV File</DBTYPE><BatchID></BatchID></AccpacImpExp>"
        Dim StreamWriter As StreamWriter
        StreamWriter = File.CreateText(TempScriptPath)

        StreamWriter.Write(strXML.Replace("%%FULLFILEPATH%%", fiTemp.FullName))
        StreamWriter.Close()

        IE.ExecuteImportScript(TempScriptPath, True)

        IE.GetExecuteResult(res)

        If Len(res) > 50 Then
            'MoveImportFile(txtImporFilePath.Text, FilePath(txtImporFilePath.Text) & "\" & FileNameNoExt(txtImporFilePath.Text) & "_" & SerialDate & ".csv")
        End If

        IE.Close()
        IE = Nothing

        comLink.Close()
        comLink = Nothing

        ShowResults()
    End Sub

End Class

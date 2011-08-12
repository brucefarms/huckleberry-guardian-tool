Imports vb = Microsoft.VisualBasic
Imports System.IO

Public Class frmGLImport

    Dim res As String
    Dim IE As New AccpacImportExport.ImportExport
    Public FC As AccpacCOMAPI.AccpacFiscalCalendar

    Sub DeleteGLBatch(ByVal CNTBTCH As Integer)
        Try
            DBLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)

            Dim GLBATCH5batch As AccpacCOMAPI.AccpacView
            Dim GLBATCH5batchFields As AccpacCOMAPI.AccpacViewFields
            DBLink.OpenView("GL0008", GLBATCH5batch)
            GLBATCH5batchFields = GLBATCH5batch.Fields

            Dim GLBATCH5header As AccpacCOMAPI.AccpacView
            Dim GLBATCH5headerFields As AccpacCOMAPI.AccpacViewFields
            DBLink.OpenView("GL0006", GLBATCH5header)
            GLBATCH5headerFields = GLBATCH5header.Fields

            Dim GLBATCH5detail1 As AccpacCOMAPI.AccpacView
            Dim GLBATCH5detail1Fields As AccpacCOMAPI.AccpacViewFields
            DBLink.OpenView("GL0010", GLBATCH5detail1)
            GLBATCH5detail1Fields = GLBATCH5detail1.Fields

            Dim GLBATCH5detail2 As AccpacCOMAPI.AccpacView
            Dim GLBATCH5detail2Fields As AccpacCOMAPI.AccpacViewFields
            DBLink.OpenView("GL0402", GLBATCH5detail2)
            GLBATCH5detail2Fields = GLBATCH5detail2.Fields

            GLBATCH5batch.Compose(New Object() {GLBATCH5header})
            GLBATCH5header.Compose(New Object() {GLBATCH5batch, GLBATCH5detail1})
            GLBATCH5detail1.Compose(New Object() {GLBATCH5header, GLBATCH5detail2})
            GLBATCH5detail2.Compose(New Object() {GLBATCH5detail1})

            Dim btch As String = vb.Right("00000" & txtCNTBTCH.Text, 6)

            GLBATCH5batchFields.FieldByName("BATCHID").Value = btch
            GLBATCH5batch.Read()

            GLBATCH5batchFields.FieldByName("PROCESSCMD").PutWithoutVerification("2")        ' Lock Batch Switch
            GLBATCH5batch.Process()

            GLBATCH5batchFields.FieldByName("BATCHSTAT").Value = "3"                          ' Status
            GLBATCH5batch.Update()

            GLBATCH5batchFields.FieldByName("PROCESSCMD").PutWithoutVerification("0")        ' Lock Batch Switch
            GLBATCH5batch.Process()
        Catch ex As Exception
            For i As Integer = 0 To Session.Errors.Count - 1
                MsgBox(Session.Errors.Item(i))
            Next
            Session.Errors.Clear()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmGLImport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Len(Trim(res)) = 0 Then Exit Sub

        If Me.DsAccpac.SessionError.Rows.Count > 0 Then
            Select Case MsgBox("Import contained errors.   Delete batch?", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    DeleteGLBatch(txtCNTBTCH.Text)
                Case MsgBoxResult.No

                Case MsgBoxResult.Cancel
                    e.Cancel = True
                    Exit Sub
            End Select
        End If

        If Me.DsAccpac.SessionError.Rows.Count > 0 Then Exit Sub

        Select Case MsgBox("Close form and archive import files?", MsgBoxStyle.YesNoCancel, "Closing Form")
            Case MsgBoxResult.Yes
                fi1_orig.MoveTo(Path.Combine(fi1_orig.DirectoryName, Path.GetFileNameWithoutExtension(fi1_orig.Name) & "." & Funcs.SerialDate & "." & txtCNTBTCH.Text & fi1_orig.Extension))
            Case MsgBoxResult.No

            Case MsgBoxResult.Cancel
                e.Cancel = True
        End Select
    End Sub

    Private Sub frmGLImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbAction.SelectedIndex = 0
        Session = CType(Me.MdiParent, frmMDIMain).Session
        DBLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)
        FC = DBLink.GetFiscalCalendar
    End Sub

    Private fi1, fi2, fi1_orig, fi2_orig As FileInfo
    Private di_temp As System.IO.DirectoryInfo

    Private Sub btnBrowseFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFile1.Click
        OpenFileDialog1.Filter = "GL Transaction (*.txt)|GLTransExport*.txt"
        Select Case OpenFileDialog1.ShowDialog
            Case Windows.Forms.DialogResult.OK
                txtFile1.Text = OpenFileDialog1.FileName
                fi1 = New FileInfo(txtFile1.Text)
                If fi1.Exists Then LoadFile()
        End Select

    End Sub

    Sub LoadFile()
        fi1_orig = New FileInfo(fi1.FullName)
        CreateTempFiles()
        CreateSchema()

        Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fi1.DirectoryName & ";Extended Properties=""Text;"""
        Dim conn As New OleDb.OleDbConnection(ConStr)
        Dim da As New OleDb.OleDbDataAdapter("Select * from " & fi1.Name, conn)

        DsGuardian.GlTransExport.Clear()
        Try
            da.Fill(DsGuardian.GlTransExport)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        LoadFile()
    End Sub

    Function CreateTempFiles()
        Try
            di_temp = New DirectoryInfo(Path.Combine(System.IO.Path.GetTempPath, "AccGuardTemp"))
            If Not di_temp.Exists Then di_temp.Create()

            di_temp = System.IO.Directory.CreateDirectory(Path.Combine(di_temp.FullName, Funcs.SerialDate))

            fi1 = fi1.CopyTo(Path.Combine(di_temp.FullName, fi1.Name))

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub CreateSchema()
        Dim sw As New StreamWriter(Path.Combine(di_temp.FullName, "Schema.ini"))
        Try
            sw.WriteLine(String.Format("[{0}]", New String() {fi1.Name}))
            sw.WriteLine("Format=CSVDelimited")
            sw.WriteLine("MaxScanRows=0")
            sw.WriteLine()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sw.Close()
            sw = Nothing
        End Try
    End Sub

    Private Sub btnFdrCNTBTCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdrCNTBTCH.Click
        Try
            Dim f As New AccpacFinder.ViewFinder
            f.Session = Session
            f.ViewID = "GL0008"

            Select Case f.Finder
                Case True
                    txtCNTBTCH.Text = f.ReturnFieldValues
            End Select

        Catch ex As Exception
            Dim strErr As String = Nothing
            If Session.Errors.Count > 0 Then
                For i As Integer = 0 To Session.Errors.Count - 1
                    strErr &= Session.Errors.Item(i) & vbNewLine & "--" & vbNewLine
                Next
            End If
            MsgBox(strErr & ex.ToString)
            Session.Errors.Clear()
        End Try
    End Sub

    Private Sub rbNewBatch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNewBatch.CheckedChanged
        Me.txtBTCHDESC.ReadOnly = rbExistingBatch.Checked
    End Sub

    Private Sub txtCNTBTCH_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNTBTCH.Leave
        UpdateCNTBTCH()
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        btnImport.Enabled = False

        Dim dv As New DataView(Me.DsGuardian.GlTransExport)
        Dim dtJour As DataTable = dv.ToTable("dtJour", True, "Journal_Number")

        Dim drJH As dsGuardian.Journal_HeadersRow
        Dim drJD As dsGuardian.Journal_DetailsRow
        Dim drG As dsGuardian.GlTransExportRow
        Dim LoopCount As Integer = 0
        Dim TransDate As Date
        Dim p As Integer
        Dim y As String
        For Each drJour As DataRow In dtJour.Rows
            LoopCount = 0

            dv.RowFilter = String.Format("Journal_Number = {0}", New String() {drJour(0)})
            drG = dv.Item(0).Row

            ' Create Journal Here
            drJH = DsGuardian.Journal_Headers.NewJournal_HeadersRow
            With drJH
                .BATCHID = drG.Batch_Number
                .BTCHENTRY = drG.Journal_Number
                .SRCELEDGER = "GL"
                .SRCETYPE = "GD"
                TransDate = CDate(drG.TransactionDate).ToShortDateString
                .DATEENTRY = TransDate.Year & vb.Right("0" & TransDate.Month, 2) & vb.Right("0" & TransDate.Day, 2)

                FC.GetPeriod(dtpPostingDate.Value, p, y)

                .FSCSPERD = p
                .FSCSYR = y
            End With
            Me.DsGuardian.Journal_Headers.Rows.Add(drJH)

            For i As Integer = 0 To dv.Count - 1
                drG = dv(i).Row

                LoopCount -= 1

                drJD = Me.DsGuardian.Journal_Details.NewJournal_DetailsRow
                With drJD
                    .BATCHNBR = drG.Batch_Number
                    .JOURNALID = drG.Journal_Number
                    .TRANSNBR = LoopCount
                    .ACCTID = vb.Left(drG.Account_Number.Replace("-", "") & "00000000000", 11)
                    .TRANSAMT = drG.Amount
                    .TRANSDATE = TransDate.Year & vb.Right("0" & TransDate.Month, 2) & vb.Right("0" & TransDate.Day, 2)
                    .TRANSDESC = drG.Journal_Description

                End With
                Me.DsGuardian.Journal_Details.Rows.Add(drJD)
            Next
        Next

        Dim diTemp As New DirectoryInfo(Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "GuardianTemp"))
        If Not diTemp.Exists Then diTemp.Create()

        Dim fiTemp As New FileInfo((Path.Combine(diTemp.FullName, Path.GetFileNameWithoutExtension(fi1.FullName) & ".csv")))

        Dim b As New BuildGLExport
        b.BuildCSV(New DataTable() {DsGuardian.Journal_Headers, DsGuardian.Journal_Details}, fiTemp, "Column1, Column4, Column2")

        ImportToAccpac(fiTemp)
    End Sub

    Sub ImportToAccpac(ByVal fiTemp As FileInfo)
        Dim comLink As AccpacCOMAPI.AccpacDBLink
        comLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)

        If rbNewBatch.Checked Then
            Dim v As AccpacCOMAPI.AccpacView
            comLink.OpenView("GL0008", v)
            v.RecordCreate(AccpacCOMAPI.tagViewRecordCreateEnum.VIEW_RECORD_CREATE_INSERT)
            txtCNTBTCH.Text = v.Fields.FieldByName("BATCHID").Value
            v.Fields.FieldByName("BTCHDESC").PutWithoutVerification(txtBTCHDESC.Text)
            v.Update()
        End If

        IE.Open(comLink)

        IE.SetView("GL0008", "", AccpacImportExport.tagViewType.VIEW_BATCH, Nothing)
        IE.SetView("GL0006", "GL0008", AccpacImportExport.tagViewType.VIEW_SEQUENCED_HEADER, Nothing)
        IE.SetView("GL0010", "GL0006", AccpacImportExport.tagViewType.VIEW_DETAIL_SEQUENCED, Nothing)
        IE.SetBatchNumber(txtCNTBTCH.Text)
        IE.VerifyOnPut = True

        Dim ScriptPath, TempScriptPath
        TempScriptPath = Path.Combine(Environ("TEMP"), "GLIMPORT.xml")

        Dim strXML As String = "<?xml version=""1.0"" encoding=""utf-8""?><AccpacImpExp Action=""16"" ProgramName=""GL2100"" Type=""IMPORT"" Version=""532"" HasTitleRecord=""1""><VIEW ID=""GL0008"" Type=""4"" Action=""0""><TABLE>Batches</TABLE></VIEW><VIEW ID=""GL0006"" Type=""3"" Action=""0"" Parent=""GL0008"" SelectedIDs=""1 2 3 4 ""><TABLE>Journal_Headers</TABLE></VIEW><VIEW ID=""GL0010"" Type=""9"" Action=""0"" Parent=""GL0006"" SelectedIDs=""1 2 3 4 6 ""><TABLE>Journal_Details</TABLE></VIEW><VIEW ID=""GL0402"" Type=""8"" Action=""4096"" Parent=""GL0010""><TABLE>Journal_Detail_Optional_Fields</TABLE></VIEW><DBNAME>%%FULLFILEPATH%%</DBNAME><DBTYPE>Single CSV File</DBTYPE><BatchID></BatchID></AccpacImpExp>"
        Dim StreamWriter As StreamWriter
        StreamWriter = File.CreateText(TempScriptPath)

        StreamWriter.Write(strXML.Replace("%%FULLFILEPATH%%", fiTemp.FullName))
        StreamWriter.Close()

        IE.StoreRetartInfoInAccpacProperty = False
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

    Private Sub ShowResults()

        DBLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)
        Dim v As AccpacCOMAPI.AccpacView

        Try
            Dim dsRES As New DataSet
            dsRES.ReadXml(New System.IO.StringReader(Res))
            Dim dtVIEW As DataTable = dsRES.Tables("VIEW")
            Dim drR As dsAccpac.VIEWRow

            If IsNothing(dtVIEW) Then Exit Try

            For Each dr As DataRow In dtVIEW.Rows
                drR = Me.DsAccpac.VIEW.NewVIEWRow
                For i As Integer = 0 To dtVIEW.Columns.Count - 1
                    Try
                        drR(dtVIEW.Columns(i).ColumnName) = dr(i)
                    Catch ex As Exception

                    End Try

                Next
                DBLink.OpenView(drR.ID, v)
                drR.Description = v.Description
                Me.DsAccpac.VIEW.Rows.Add(drR)
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim dt As DataTable
        'dt.Columns.Add("ToString")
        dt = Me.DsAccpac.SessionError

        Try
            Me.DsAccpac.SessionError.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim drE As dsAccpac.SessionErrorRow

        Dim index, pHelpID As Integer
        Dim pPriority As AccpacCOMAPI.tagErrorPriority
        Dim pMsg, pSource, pErrCode, pHelpFile As String

        For i As Integer = 0 To Session.Errors.Count - 1
            drE = dt.NewRow
            Session.Errors.Get(index, pMsg, pPriority, pSource, pErrCode, pHelpFile, pHelpID)
            drE.index = index
            drE.pMsg = pMsg
            drE.pPriority = pPriority.ToString
            drE.pSource = pSource
            drE.pErrCode = pErrCode
            drE.pHelpFile = pHelpFile
            drE.pHelpID = pHelpID
            dt.Rows.Add(drE)
        Next
        Session.Errors.Clear()

        Me.dgvAccpacErrors.DataSource = dt

        TabControl1.SelectedIndex = 1
    End Sub

    Sub ReplaceText(ByVal FilePath, ByVal DestPath, ByVal Findtxt, ByVal ReplaceTxt)
        Dim StreamReader As StreamReader
        StreamReader = File.OpenText(FilePath)

        Dim contents As String = StreamReader.ReadToEnd()
        StreamReader.Close()

        Dim StreamWriter As StreamWriter
        StreamWriter = File.CreateText(DestPath)

        StreamWriter.Write(contents.Replace(Findtxt, ReplaceTxt))
        StreamWriter.Close()
    End Sub


    Private Sub btnImport_Click2()
        Dim dv As New DataView(Me.DsGuardian.GlTransExport)
        Dim dtJour As DataTable = dv.ToTable("dtJour", True, "Journal_Number")

        Dim temp As Boolean = False
        Dim b As New GLBatch(Session)
        Select Case rbExistingBatch.Checked
            Case True
                temp = b.CreateBatch(txtCNTBTCH.Text)
            Case False
                temp = b.CreateBatch(txtBTCHDESC.Text)
        End Select

        If temp = False Then Exit Sub
        Dim acct As String

        For Each drJour As DataRow In dtJour.Rows
            dv.RowFilter = String.Format("Journal_Number = {0}", New String() {drJour(0)})
            b.CreateJE()
            For Each dr As DataRow In dv.Table.Rows
                acct = dr("Account_Number")
                If Len(acct) = 8 Then acct &= "-0000"
                b.AddLine(acct, dr("Amount"))
            Next
            b.SaveJE()
        Next
    End Sub
End Class
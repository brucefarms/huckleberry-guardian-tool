Imports vb = Microsoft.VisualBasic
Imports System.IO

Public Class frmAPImport

    Private fi1, fi2, fi1_orig, fi2_orig As FileInfo
    Private di_temp As System.IO.DirectoryInfo
    Private myfrmMDIMain As frmMDIMain
    Public FC As AccpacCOMAPI.AccpacFiscalCalendar

    Sub DeleteBatch(ByVal cntbtch As Integer)

        DBLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)

        Dim APINVOICE1batch As AccpacCOMAPI.AccpacView
        Dim APINVOICE1batchFields As AccpacCOMAPI.AccpacViewFields
        DBLink.OpenView("AP0020", APINVOICE1batch)
        APINVOICE1batchFields = APINVOICE1batch.Fields

        Dim APINVOICE1header As AccpacCOMAPI.AccpacView
        Dim APINVOICE1headerFields As AccpacCOMAPI.AccpacViewFields
        DBLink.OpenView("AP0021", APINVOICE1header)
        APINVOICE1headerFields = APINVOICE1header.Fields

        Dim APINVOICE1detail1 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail1Fields As AccpacCOMAPI.AccpacViewFields
        DBLink.OpenView("AP0022", APINVOICE1detail1)
        APINVOICE1detail1Fields = APINVOICE1detail1.Fields

        Dim APINVOICE1detail2 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail2Fields As AccpacCOMAPI.AccpacViewFields
        DBLink.OpenView("AP0023", APINVOICE1detail2)
        APINVOICE1detail2Fields = APINVOICE1detail2.Fields

        Dim APINVOICE1detail3 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail3Fields As AccpacCOMAPI.AccpacViewFields
        DBLink.OpenView("AP0402", APINVOICE1detail3)
        APINVOICE1detail3Fields = APINVOICE1detail3.Fields

        Dim APINVOICE1detail4 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail4Fields As AccpacCOMAPI.AccpacViewFields
        DBLink.OpenView("AP0401", APINVOICE1detail4)
        APINVOICE1detail4Fields = APINVOICE1detail4.Fields

        APINVOICE1batch.Compose(New Object() {APINVOICE1header})
        APINVOICE1header.Compose(New Object() {APINVOICE1batch, APINVOICE1detail1, APINVOICE1detail2, APINVOICE1detail3})
        APINVOICE1detail1.Compose(New Object() {APINVOICE1header, APINVOICE1batch, APINVOICE1detail4})
        APINVOICE1detail2.Compose(New Object() {APINVOICE1header})
        APINVOICE1detail3.Compose(New Object() {APINVOICE1header})
        APINVOICE1detail4.Compose(New Object() {APINVOICE1detail1})

        On Error Resume Next

        ' Try

        APINVOICE1batchFields.FieldByName("CNTBTCH").Value = cntbtch
        APINVOICE1batch.Read()

        APINVOICE1batchFields.FieldByName("PROCESSCMD").PutWithoutVerification("2")      ' Process Command Code
        APINVOICE1batch.Process()

        APINVOICE1batchFields.FieldByName("BTCHSTTS").Value = "4"                         ' Batch Status
        APINVOICE1batch.Update()

        APINVOICE1batchFields.FieldByName("PROCESSCMD").PutWithoutVerification("0")      ' Process Command Code
        APINVOICE1batch.Process()
        'Catch ex As Exception
        ' MsgBox(ex.ToString)
        ' For i As Integer = 0 To Session.Errors.Count - 1
        ' MsgBox(Session.Errors.Item(i))
        ' Next
        ' Session.Errors.Clear()
        ' End Try
    End Sub

    Private Sub btnBrowseFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFile1.Click
        OpenFileDialog1.Filter = "AP Transaction (*.txt)|APTransExport1*.txt"
        Select Case OpenFileDialog1.ShowDialog
            Case Windows.Forms.DialogResult.OK
                txtFile1.Text = OpenFileDialog1.FileName
                fi1 = New FileInfo(txtFile1.Text)
                txtFile2.Text = (System.IO.Path.Combine(fi1.DirectoryName, Replace(fi1.Name, "1", "2", 1, 1)))
                If fi1.Exists And fi2.Exists Then LoadFiles()
        End Select
    End Sub

    Private Sub btnBrowseFile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFile2.Click
        OpenFileDialog1.Filter = "AP Transaction (*.txt)|APTransExport2*.txt"
        Select Case OpenFileDialog1.ShowDialog
            Case Windows.Forms.DialogResult.OK
                txtFile2.Text = OpenFileDialog1.FileName
        End Select
    End Sub

    Private Sub txtFile1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFile1.TextChanged
        Try
            fi1 = New FileInfo(txtFile1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFile2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFile2.TextChanged
        Try
            fi2 = New FileInfo(txtFile2.Text)
        Catch ex As Exception

        End Try

    End Sub

    Function CreateTempFiles()
        Try
            di_temp = New DirectoryInfo(Path.Combine(System.IO.Path.GetTempPath, "AccGuardTemp"))
            If Not di_temp.Exists Then di_temp.Create()

            di_temp = System.IO.Directory.CreateDirectory(Path.Combine(di_temp.FullName, Funcs.SerialDate))

            fi1 = fi1.CopyTo(Path.Combine(di_temp.FullName, fi1.Name))
            fi2 = fi2.CopyTo(Path.Combine(di_temp.FullName, fi2.Name))
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
            sw.WriteLine(String.Format("[{0}]", New String() {fi2.Name}))
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

    Private Sub rbNewBatch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNewBatch.CheckedChanged
        Me.txtBTCHDESC.ReadOnly = rbExistingBatch.Checked
    End Sub

    Private Sub txtCNTBTCH_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNTBTCH.Leave
        UpdateCNTBTCH()
    End Sub

    Private Sub frmAPImport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Len(Trim(txtTaxLine1.Text)) > 0 Then My.Settings.TaxDesc1 = txtTaxLine1.Text
        If Len(Trim(txtFile1.Text)) > 0 Then My.Settings.APFile1 = txtFile1.Text
        If Len(Trim(txtFile2.Text)) > 0 Then My.Settings.APFile2 = txtFile2.Text
        My.Settings.Save()

        If Len(Trim(res)) = 0 Then Exit Sub

        If Me.DsAccpac.SessionError.Rows.Count > 0 Then
            Select Case MsgBox("Import contained errors.   Delete batch?", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    DeleteBatch(txtCNTBTCH.Text)
                    Exit Sub
                Case MsgBoxResult.No

                Case MsgBoxResult.Cancel
                    e.Cancel = True
                    Exit Sub
            End Select
        End If

        Select Case MsgBox("Close form and archive import files?", MsgBoxStyle.YesNoCancel, "Closing Form")
            Case MsgBoxResult.Yes
                fi1_orig.MoveTo(Path.Combine(fi1_orig.DirectoryName, Path.GetFileNameWithoutExtension(fi1_orig.Name) & "." & Funcs.SerialDate & "." & txtCNTBTCH.Text & fi1_orig.Extension))
                fi2_orig.MoveTo(Path.Combine(fi2_orig.DirectoryName, Path.GetFileNameWithoutExtension(fi2_orig.Name) & "." & Funcs.SerialDate & "." & txtCNTBTCH.Text & fi2_orig.Extension))
            Case MsgBoxResult.No

            Case MsgBoxResult.Cancel
                e.Cancel = True
        End Select
    End Sub

    Private Sub frmAPImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.myfrmMDIMain = Me.MdiParent
        Session = CType(Me.MdiParent, frmMDIMain).Session
        DBLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)
        FC = DBLink.GetFiscalCalendar

        cbAction.SelectedIndex = 0

        Try
            txtTaxLine1.Text = My.Settings.TaxDesc1
            txtFile1.Text = My.Settings.APFile1
            txtFile2.Text = My.Settings.APFile2

            LoadFiles()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        LoadFiles()
    End Sub

    Sub LoadFiles()
        fi1_orig = New FileInfo(fi1.FullName)
        fi2_orig = New FileInfo(fi2.FullName)

        If fi1_orig.Exists = False Or fi2.Exists = False Then Exit Sub

        CreateTempFiles()
        CreateSchema()

        Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fi1.DirectoryName & ";Extended Properties=""Text;"""
        Dim conn As New OleDb.OleDbConnection(ConStr)
        Dim da As New OleDb.OleDbDataAdapter("Select * from " & fi1.Name, conn)

        da.Fill(DsGuardian, "APTransExport1")

        If fi2.Exists Then
            ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fi2.DirectoryName & ";Extended Properties=""Text;HDR=Yes;FMT=Delimited\"""
            conn = New OleDb.OleDbConnection(ConStr)
            da = New OleDb.OleDbDataAdapter("Select * from " & fi2.Name, conn)

            da.Fill(DsGuardian, "APTransExport2")
        Else
            Select Case MsgBox("File Not Found" & vbNewLine & fi2.FullName, MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes

            End Select
        End If
    End Sub

    Private Sub btnFdrCNTBTCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdrCNTBTCH.Click
        Try
            Dim f As New AccpacFinder.ViewFinder
            f.Session = Session
            f.ViewID = "AP0020"

            Select Case f.Finder
                Case True
                    txtCNTBTCH.Text = f.ReturnFieldValues
            End Select

        Catch ex As Exception
            Dim f As New frmImportResults(Session, "")
            f.ShowDialog()
        End Try
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        btnImport.Enabled = False

        Dim dv1 As New DataView(Me.DsGuardian.APTransExport1)
        Dim dv2 As New DataView(Me.DsGuardian.APTransExport2)
        Dim dtJour As DataTable = dv1.ToTable("dtJour", True, "InvoiceNumber")

        Dim drIH As dsGuardian.Invoice_HeaderRow
        Dim drID As dsGuardian.Invoice_DetailsRow
        Dim drAP1 As dsGuardian.APTransExport1Row
        Dim drAP2 As dsGuardian.APTransExport2Row

        Dim LoopCount As Integer
        Dim DocDate As Date

        Dim TermCode As String
        Dim dvCalc As DataView
        Dim Tax1, Tax2 As Decimal
        Dim p As Integer
        Dim y As String

        myfrmMDIMain.frmTerms.CheckTerms(Me.DsGuardian.APTransExport1)

        For Each drJour As DataRow In dtJour.Rows
            LoopCount = 0

            dv1.RowFilter = String.Format("InvoiceNumber = '{0}'", New String() {drJour(0)})
            dv2.RowFilter = String.Format("InvoiceNumber = '{0}'", New String() {drJour(0)})

            drAP1 = dv1(0).Row

            DocDate = drAP1.DocDate

            drIH = Me.DsGuardian.Invoice_Header.NewInvoice_HeaderRow
            With drIH
                .CNTBTCH = drAP1.BatchNumber
                .DATEINVC = DocDate.Year & vb.Right("0" & DocDate.Month, 2) & vb.Right("0" & DocDate.Day, 2)
                .IDINVC = drAP1.InvoiceNumber
                .IDVEND = drAP1.VendorID
                .AMTGROSTOT = CDec(drAP1.PurchaseAmount) + CDec(drAP1.TaxAmount) + CDec(drAP1.MiscAmount) + CDec(drAP1.FreightAmount)
                .AMTTAX1 = 0
                .AMTTAX2 = 0

                ' .DATEBUS = vb.Right("00" & dtpPostingDate.Value.Month, 2) & "/" & vb.Right("00" & dtpPostingDate.Value.Day, 2) & "/" & dtpPostingDate.Value.Year
                ' FC.GetPeriod(dtpPostingDate.Value, p, y)
                ' .FISCPER = p
                ' .FISCYR = y

                TermCode = myfrmMDIMain.frmTerms.GetMatchingTerm((drAP1.Terms))
                If Len(Trim(TermCode)) = 0 Then
                    .TERMCODE = myfrmMDIMain.frmTerms.DsGuardian.TermsMatching(0).TERMSCODE
                Else
                    .TERMCODE = TermCode
                End If

            End With
            Me.DsGuardian.Invoice_Header.Rows.Add(drIH)

            For i As Integer = 0 To dv2.Count - 1
                drAP2 = dv2.Item(i).Row
                If Len(Trim(drIH.PONBR)) = 0 Then drIH.PONBR = drAP2.PONumber
                drID = Me.DsGuardian.Invoice_Details.NewInvoice_DetailsRow
                drID.AMTDIST = drAP2.Debit - drAP2.Credit

                If drAP2.DistributionType = "MISC" Then
                    drID.IDGLACCT = "55062390000"
                Else
                    drID.IDGLACCT = drAP2.AccountNum
                End If

                drID.CNTBTCH = drIH.CNTBTCH
                drID.CNTITEM = drIH.CNTITEM
                drID.TEXTDESC = drAP2.LineDescription
                drID.AMTTAX1 = 0
                drID.AMTTAX2 = 0
                
                If drAP2.DistributionType <> "PAY" Then Me.DsGuardian.Invoice_Details.Rows.Add(drID)
            Next

            dvCalc = Me.DsGuardian.Invoice_Details.DefaultView
            dvCalc.RowFilter = "CNTITEM=" & drIH.CNTITEM

            Tax1 = 0
            Tax2 = 0
            Tax1 = Me.DsGuardian.Invoice_Details.Compute("Sum(AMTTAX1)", dvCalc.RowFilter)
            Tax2 = Me.DsGuardian.Invoice_Details.Compute("Sum(AMTTAX2)", dvCalc.RowFilter)

            drID = Me.DsGuardian.Invoice_Details.NewInvoice_DetailsRow
            drID.AMTDIST = drAP1.TaxAmount
            drID.IDGLACCT = "11150000000"
            drID.CNTBTCH = drIH.CNTBTCH
            drID.CNTITEM = drIH.CNTITEM
            drID.TEXTDESC = txtTaxLine1.Text
            drID.AMTTAX1 = 0
            drID.AMTTAX2 = 0
            Me.DsGuardian.Invoice_Details.Rows.Add(drID)
        Next

        Dim diTemp As New DirectoryInfo(Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "GuardianTemp"))
        If Not diTemp.Exists Then diTemp.Create()

        Dim fiTemp As New FileInfo((Path.Combine(diTemp.FullName, Path.GetFileNameWithoutExtension(fi1.FullName) & ".csv")))

        Dim b As New BuildGLExport
        b.BuildCSV(New DataTable() {DsGuardian.Invoice_Header, DsGuardian.Invoice_Details, New dsGuardian.Invoice_Payment_Schedules_DataTable, New DataTable, New DataTable}, fiTemp, "Column1, Column4, Column2")

        ImportToAccpac(fiTemp)
    End Sub

End Class
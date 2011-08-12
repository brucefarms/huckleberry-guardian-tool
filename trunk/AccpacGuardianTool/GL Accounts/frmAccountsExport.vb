Public Class frmAccountsExport

    Private myMDIMain As frmMDIMain
    Dim strFilter As String

    Private Sub frmAccountsExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myMDIMain = Me.MdiParent
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim strFilterDate As String = Nothing
        Dim strFilterRange As String = Nothing

        Dim strFilterSeg1 As String = String.Format("((ACSEGVAL01 >= ""{0}"") AND (ACSEGVAL01 <= ""{1}""))", txtSeg1_1.Text, txtSeg1_2.Text)
        Dim strFilterSeg2 As String = String.Format("((ACSEGVAL02 >= ""{0}"") AND (ACSEGVAL02 <= ""{1}""))", txtSeg2_1.Text, txtSeg2_2.Text)
        Dim strFilterSeg3 As String = String.Format("((ACSEGVAL03 >= ""{0}"") AND (ACSEGVAL03 <= ""{1}""))", txtSeg3_1.Text, txtSeg3_2.Text)

        strFilterDate = String.Format("((CREATEDATE >= ""{0}"") AND (CREATEDATE <= ""{1}""))", myMDIMain.AccpacDate(dtpStartDate.Value), myMDIMain.AccpacDate(dtpStopDate.Value))

        strFilter = String.Format("{0} AND {1} AND {2} AND {3}", strFilterDate, strFilterSeg1, strFilterSeg2, strFilterSeg3)

        Dim dt As New DataTable
        Dim dr As DataRow

        Dim DBLink As AccpacCOMAPI.AccpacDBLink = myMDIMain.Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)
        Dim v As AccpacCOMAPI.AccpacView
        Dim vf As AccpacCOMAPI.AccpacViewFields
        DBLink.OpenView("GL0001", v)
        vf = v.Fields

        '"ACCTID", 

        Dim flds() As String = New String() {"ACCTFMTTD", "CREATEDATE", "ACCTDESC"}

        For Each s As String In flds
            dt.Columns.Add(s)
        Next

        Try
            v.Browse(strFilter, True)

            Do While v.Fetch
                dr = dt.NewRow
                For Each s As String In flds
                    dr(s) = vf.FieldByName(s).Value
                Next
                dt.Rows.Add(dr)
            Loop
        Catch ex As Exception
            For i As Integer = 0 To myMDIMain.Session.Errors.Count - 1
                MsgBox(myMDIMain.Session.Errors.Item(i) & vbNewLine & strFilter)
            Next
            myMDIMain.Session.Errors.Clear()
        End Try

        Me.DataGridView1.DataSource = dt
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim export As New ExportAccounts(Me.myMDIMain.Session)
        Dim fsa As New SaveFileDialog
        fsa.DefaultExt = "txt"
        fsa.InitialDirectory = My.Settings.ExportGLLastFile
        fsa.FileName = "account.txt"
        fsa.Filter = "Text File (*.txt)|*.txt"

        Select Case fsa.ShowDialog
            Case Windows.Forms.DialogResult.OK
                export.ExportAccount(fsa.FileName, strFilter)
                My.Settings.ExportGLLastFile = fsa.FileName
        End Select
    End Sub

    Private Sub btnResetFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetFilters.Click
        txtSeg1_1.Text = ""
        txtSeg1_2.Text = "9999"
        txtSeg2_1.Text = ""
        txtSeg2_2.Text = "999"
        txtSeg3_1.Text = ""
        txtSeg3_2.Text = "9999"
    End Sub
End Class
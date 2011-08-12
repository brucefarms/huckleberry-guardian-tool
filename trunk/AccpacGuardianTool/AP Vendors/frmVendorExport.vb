Public Class frmVendorExport

    Private Session As AccpacCOMAPI.AccpacSession

    Private Sub frmVendorExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Session = CType(Me.MdiParent, frmMDIMain).Session
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        btnExport.Enabled = False
        Dim strFilter As String = String.Format("((IDGRP >= ""{0}"") AND (IDGRP <= ""{1}""))", txtIDGRPFrom.Text, txtIDGRPTo.Text)

        Dim export As New ExportVendors(Session)
        Dim fsa As New SaveFileDialog
        fsa.DefaultExt = "txt"
        fsa.InitialDirectory = My.Settings.ExportAPLastFile
        fsa.FileName = "supplier.txt"
        fsa.Filter = "Text File (*.txt)|*.txt"

        Select Case fsa.ShowDialog
            Case Windows.Forms.DialogResult.OK
                export.ExportAccount(fsa.FileName, strFilter)
                My.Settings.ExportAPLastFile = fsa.FileName
        End Select
        MsgBox("Export Finished")
    End Sub
End Class
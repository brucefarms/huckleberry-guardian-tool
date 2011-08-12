Imports System.Windows.Forms

Public Class frmMDIMain

#Region " Auto Stuff "

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

#End Region

    Private Sub frmMDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not AccpacSignOn() Then
            End
        End If
        Me.ToolStripStatusLabel.Text = Session.CompanyID & " - " & Session.CompanyName

        Dim g As New GLAccounts(Session)

        'Dim FICleanup As System.IO.FileInfo
        'FICleanup = New System.IO.FileInfo(System.IO.Path.Combine("%TEMP%", "AccGuardTemp"))
        'If FICleanup.Exists Then FICleanup.Delete()
    End Sub


    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fi As System.IO.FileInfo

        Select Case OpenFileDialog1.ShowDialog
            Case Windows.Forms.DialogResult.OK

                fi = New System.IO.FileInfo(OpenFileDialog1.FileName)
        End Select
    End Sub

    Private Sub APTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APTransactionToolStripMenuItem.Click

    End Sub

    Private Sub TransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsToolStripMenuItem.Click
        Dim f As New frmGLImport
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub TransactionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsToolStripMenuItem1.Click
        Dim f As New frmAPImport
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub VendorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorsToolStripMenuItem.Click
        Dim frm As New frmVendorExport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsToolStripMenuItem.Click
        Dim f As New frmAccountsExport
        f.MdiParent = Me
        f.Show()

        Exit Sub

    End Sub
End Class

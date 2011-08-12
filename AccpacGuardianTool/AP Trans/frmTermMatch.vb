Imports System.IO

Public Class frmTermMatch

    Dim Session As AccpacCOMAPI.AccpacSession
    Dim DBLink As AccpacCOMAPI.AccpacDBLink
    Dim vAPATA As AccpacCOMAPI.AccpacView

    Dim myFrmMDIMain As frmMDIMain
    Dim fi As FileInfo
    Dim fiTermMatch As FileInfo

    Public Sub New(ByVal s As AccpacCOMAPI.AccpacSession, ByVal frm As Form)
        InitializeComponent()

        myFrmMDIMain = frm
        Session = s

        DBLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)
        LoadAccpacTerms()

        fi = New FileInfo(Path.Combine(myFrmMDIMain.AccpacSharedData, "GuardianImport"))
        If Not fi.Exists Then
            Directory.CreateDirectory(fi.FullName)
        End If
        fiTermMatch = New FileInfo(Path.Combine(fi.FullName, "termmatch.xml"))
    End Sub

    Sub LoadAccpacTerms()
        DBLink.OpenView("AP0012", vAPATA)

        Dim dr As dsAccpac.APRTARow

        vAPATA.Browse("", True)
        Do While vAPATA.Fetch
            dr = Me.DsAccpac.APRTA.NewAPRTARow
            dr.CODEDESC = vAPATA.Fields.FieldByName("CODEDESC").Value
            dr.TERMSCODE = vAPATA.Fields.FieldByName("TERMSCODE").Value
            Me.DsAccpac.APRTA.Rows.Add(dr)
        Loop
    End Sub

    Public Function GetMatchingTerm(ByVal str As String) As String
        Dim dr As dsGuardian.TermsMatchingRow
        Dim strRegEx = System.Text.RegularExpressions.Regex.Escape(str)
        Try
            dr = Me.DsGuardian.TermsMatching.FindByTerms(strRegEx)
            If IsNothing(dr) Then
                dr = Me.DsGuardian.TermsMatching.FindByTerms(str)
                If IsNothing(dr) Then
                    dr = Me.DsGuardian.TermsMatching.NewTermsMatchingRow
                    dr.Terms = str
                    Me.DsGuardian.TermsMatching.Rows.Add(dr)
                End If
            End If
            Return dr.TERMSCODE

        Catch ex As Exception
            Return ""
        End Try

        Dim dv As New DataView(Me.DsGuardian.TermsMatching)
        dv.RowFilter = "Terms = '" & System.Text.RegularExpressions.Regex.Escape(str) & "'"

        If dv.Count > 0 Then
            dr = dv.Item(0).Row
        Else
            dr = Me.DsGuardian.TermsMatching.NewTermsMatchingRow
            dr.Terms = str
            Me.DsGuardian.TermsMatching.Rows.Add(dr)
            Me.ShowDialog()
            GetMatchingTerm(str)
        End If

        Return dr.TERMSCODE
    End Function

    Private Sub frmTermMatch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each dr As dsGuardian.TermsMatchingRow In Me.DsGuardian.TermsMatching
            If IsNothing(dr.TERMSCODE) Then
                Select Case MsgBox("There are blank term codes.  Continue?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.No
                        e.Cancel = True
                        Exit Sub
                End Select
            End If
        Next

        Try
            Dim fs As New FileStream(fiTermMatch.FullName, FileMode.Create)
            Me.DsGuardian.TermsMatching.WriteXml(fs)
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub frmTermMatch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If fiTermMatch.Exists Then
                Me.DsGuardian.TermsMatching.Clear()
                Dim fs As New FileStream(fiTermMatch.FullName, FileMode.Open)
                Me.DsGuardian.TermsMatching.ReadXml(fs)
                fs.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub CheckTerms(ByVal dt As DataTable)
        Dim drTerm As dsGuardian.TermsMatchingRow

        For Each drDT As dsGuardian.APTransExport1Row In dt.Rows
            Try
                drTerm = Me.DsGuardian.TermsMatching.NewTermsMatchingRow
                drTerm.Terms = drDT.Terms
                Me.DsGuardian.TermsMatching.Rows.Add(drTerm)
            Catch ex As Exception

            End Try
        Next
        Me.ShowDialog()
    End Sub

End Class
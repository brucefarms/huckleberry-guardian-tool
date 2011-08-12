Public Class frmDispData

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Datasource As Object, ByVal Datamember As String, Optional ByVal isDataGrid As Boolean = True)
        InitializeComponent()

        If isDataGrid Then
            Dim dg As New DataGrid
            dg.DataSource = Datasource
            dg.DataMember = Datamember
            dg.Dock = DockStyle.Fill
            Me.Controls.Add(dg)
            Me.Controls.Remove(Me.DataGridView1)
            Me.Show()
        Else
            With Me.DataGridView1
                .DataSource = Datasource
                .DataMember = Datamember
                .Dock = DockStyle.Fill
                Me.Show()
            End With
        End If
    End Sub

    Private Sub frmDispData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' This is a test
    End Sub

End Class
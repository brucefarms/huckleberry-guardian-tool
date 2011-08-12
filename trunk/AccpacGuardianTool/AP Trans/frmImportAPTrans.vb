Imports System.IO

Public Class frmImportAPTrans

    Private fi1, fi2, fi1_Orig, fi2_Orig As System.IO.FileInfo
    Private di_temp As System.IO.DirectoryInfo


    Public Sub New(ByVal filepath As String)
        InitializeComponent()

        fi1 = New System.IO.FileInfo(filepath)
        fi1_Orig = New FileInfo(fi1.FullName)
        fi2 = New System.IO.FileInfo(System.IO.Path.Combine(fi1.DirectoryName, Replace(fi1.Name, "1", "2", 1, 1)))
        fi2_Orig = New FileInfo(fi2.FullName)

        Me.Text = fi1.FullName
    End Sub

    Private Sub frmImportAPTrans_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            Select Case MsgBox("Close this window?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.No
                    e.Cancel = True
                    Exit Sub
            End Select
            For Each f As FileInfo In di_temp.GetFiles
                f.Delete()
            Next

            di_temp.Delete()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub frmImportAPTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not fi1.Exists Then Me.Close()

        CreateTempFiles()
        CreateSchema()

        Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fi1.DirectoryName & ";Extended Properties=""Text;"""
        Dim conn As New OleDb.OleDbConnection(ConStr)
        Dim da As New OleDb.OleDbDataAdapter("Select * from " & fi1.Name, conn)

        da.Fill(dsGuardian, "APTransExport1")

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

End Class
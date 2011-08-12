Imports System.IO

Public Class BuildGLExport

    Dim dsGuardian
    Dim dt As DataTable

    Sub BuildCSV(ByVal tables As DataTable(), ByVal fiPath As System.IO.FileInfo, ByVal Sort As String)
        dt = New DataTable

        Dim t As DataTable
        Dim drD, drS As DataRow
        Dim loopcout As Integer = 0

        For i As Integer = 0 To tables.Length - 1
            t = tables(i)

            dt.Columns.Add(New DataColumn())
            dt.Columns.Add(New DataColumn())

            Do Until dt.Columns.Count >= t.Columns.Count + 2
                dt.Columns.Add(New DataColumn())
            Loop
        Next

        For i As Integer = 0 To tables.Length - 1
            loopcout += 1
            t = tables(i)
            If t.Rows.Count = 0 Then
                drS = t.NewRow
            Else
                drS = t.Rows(0)
            End If


            drD = dt.NewRow
            drD(0) = "A" & loopcout
            drD(1) = "RECTYPE"
            For ii As Integer = 0 To drS.Table.Columns.Count - 1
                drD(ii + 2) = drS.Table.Columns(ii).ColumnName
            Next
            dt.Rows.Add(drD)
        Next

        For i As Integer = 0 To tables.Length - 1
            t = tables(i)

            For Each drS In t.Rows
                drD = dt.NewRow
                drD(0) = "B"
                drD(1) = i + 1
                For ii As Integer = 0 To drS.Table.Columns.Count - 1
                    drD(ii + 2) = drS(ii)
                Next
                dt.Rows.Add(drD)
            Next
        Next

        ' CleanDT(dt)

        'Dim f As New frmDispData
        'f.DataGridView1.DataSource = dt
        'f.DataGridView1.Dock = DockStyle.Fill
        'f.ShowDialog()
        '
        BuildFile(fiPath, Sort)
    End Sub

    Sub CleanDT(ByVal DT As DataTable)
        Dim HasData As Boolean = False
        Dim RevLoop As Integer = DT.Columns.Count
        Dim dr As DataRow
        Dim isNOth As Boolean

        RevLoop = DT.Columns.Count - 1

        HasData = False
        For Each dr In DT.Rows


            Try
                If Len(Trim(dr(RevLoop))) > 0 Then
                    HasData = True
                End If
            Catch ex As InvalidCastException
                Debug.WriteLine(RevLoop)
            End Try
        Next

        Dim f As New frmDispData
        f.DataGridView1.DataSource = DT
        f.DataGridView1.Dock = DockStyle.Fill
        'f.ShowDialog()

        If HasData Then
            Exit Sub
        Else
            DT.Columns.Remove(DT.Columns(RevLoop))
            CleanDT(DT)
        End If

    End Sub

    Private Sub BuildFile(ByVal fiPath As System.IO.FileInfo, ByVal sort As String)
        Dim dv As New DataView(dt)
        dv.Sort = sort '"Column1, Column4, Column2"
        Dim dtTmp As DataTable = dv.ToTable

        'Dim f As New frmDispData
        'f.DataGridView1.DataSource = dtTmp
        'f.ShowDialog()

        dtTmp.Columns.Remove("Column1")

        If fiPath.Exists Then fiPath.Delete()
        Dim sw As New StreamWriter(fiPath.FullName, False)
        Dim icolcount As Integer = dtTmp.Columns.Count
        Dim x As Decimal
        Dim REC As String

        For Each drow As DataRow In dtTmp.Rows
            REC = drow(0).ToString()
            For i As Integer = 0 To icolcount - 1
                If Not Convert.IsDBNull(drow(i)) Then
                    Try
                        sw.Write(CDec(drow(i).ToString()))
                    Catch ex As Exception
                        If REC = "RECTYPE" Then
                            sw.Write(drow(i).ToString())
                        Else
                            sw.Write("""" & drow(i).ToString().Replace("""", """""") & """")
                        End If
                    End Try
                End If
                If i < icolcount - 1 Then
                    sw.Write(",")
                End If
            Next
            sw.Write(sw.NewLine)
        Next
        sw.Close()

    End Sub

End Class

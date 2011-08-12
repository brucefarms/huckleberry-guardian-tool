Partial Class frmAPImport

    Dim v As AccpacCOMAPI.AccpacView

    Sub ShowResults()
        DBLink = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)

        Try
            Dim dsRES As New DataSet
            dsRES.ReadXml(New System.IO.StringReader(res))
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

End Class

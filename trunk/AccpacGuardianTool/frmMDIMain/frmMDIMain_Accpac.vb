Imports vb = Microsoft.VisualBasic

Partial Class frmMDIMain

    Public frmTerms As frmTermMatch

    Public Session As AccpacCOMAPI.AccpacSession
    Public pSignon As New AccpacSignonManager.AccpacSignonMgr
    Public SessMgr As New AccpacSessionManager.AccpacSessionMgr
    Public SessionID As Integer
    Public sObjHandle As String

    Public Function AccpacSignOn() As Boolean
        Try
            Session = New AccpacCOMAPI.AccpacSession
            'Dim HostName As String = "accpacsvr01.peharbour.ca"

            With SessMgr
                .AppID = "AS"
                .AppVersion = "55A"
                .ProgramName = "AR2100"
                '.ServerName = ""
                .ForceNewSignon = False
            End With

            'SessMgr.ServerName = HostName

            SessMgr.CreateSession(sObjHandle, SessionID, Session)

            If IsNothing(Session) Then
                Return False
            Else
                frmTerms = New frmTermMatch(Session, Me)
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public ReadOnly Property AccpacSharedData() As String
        Get
            Try
                Return Session.SharedDataPathOnServer
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    Function AccpacDate(ByVal d As Date)
        Return d.Year & Pad(d.Month, 2) & Pad(d.Day, 2)
    End Function

    Function Pad(ByVal str As String, ByVal padding As Integer) As String
        Return vb.Right("00000000000000000000" & str, padding)
    End Function

End Class


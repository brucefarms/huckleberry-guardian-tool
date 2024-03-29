﻿Imports System.Deployment.Application
Imports System.Windows.Forms

Partial Class frmMDIMain

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        InstallUpdateSyncWithInfo()

        Exit Sub
        'httpDownload.download("http://secure.plus.ca/webdeploy/interwestimporttool/setup.zip", AccpacSharedData & "\ImportTool\INSTALL\setup.zip")


        Dim ShellAppType As Type = Type.GetTypeFromProgID("Shell.Application")
        Dim Sa As Object = Activator.CreateInstance(ShellAppType)

        Dim filesInZip = Sa.NameSpace(AccpacSharedData & "\ImportTool\INSTALL\setup.zip").Items
        Sa.NameSpace(AccpacSharedData & "\ImportTool\INSTALL\").CopyHere(filesInZip, 16)


    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
            
            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("The new version of the application cannot be downloaded at this time. " + ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " & ioe.Message)
                Return
            End Try



            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If

                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show("This application has detected a mandatory update from your current " & _
                        "version to version " & info.MinimumRequiredVersion.ToString() & _
                        ". The application will now install the update and restart.", _
                        "Update Available", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        MessageBox.Show("The application has been upgraded, and will now restart.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show("Cannot install the latest version of the application. " & ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later.")
                        Return
                    End Try
                End If
            Else
                MessageBox.Show("There are no updates available.", "No Updates Available", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("There are no updates available.", "No Updates Available", MessageBoxButtons.OK)
        End If
    End Sub


End Class

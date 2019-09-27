Imports AutoUpdaterDotNET

Public Class Form1

    Dim butler As String = "butler.exe" ' This will be used to check for butler.
    Dim FilenameUpdate As String = System.IO.Path.GetFileName(butler) ' This will be used to find butler in the file system.
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        UpdateCheck()
    End Sub

    Public Sub UpdateCheck()
        AutoUpdater.ShowSkipButton = False
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = True
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours
        AutoUpdater.RemindLaterAt = 1
        AutoUpdater.DownloadPath = Environment.CurrentDirectory

        AutoUpdater.Start("http://thecrafters001.ga/EasyButler.xml")
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If System.IO.File.Exists(butler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "login"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("Failed to login. Butler is missing!", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If System.IO.File.Exists(butler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "update"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("Failed to update. Butler is missing!", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        AboutBox1.Show()
    End Sub
End Class

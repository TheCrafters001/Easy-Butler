Imports AutoUpdaterDotNET

Public Class Form1
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
End Class

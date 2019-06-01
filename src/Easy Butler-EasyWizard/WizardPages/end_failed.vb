Public Class end_failed
    Private Sub End_failed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.UserName = ""
        My.Settings.GameURL = ""
        My.Settings.Folder = ""
        My.Settings.OSVer = ""
        My.Settings.NewGameVer = ""
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SourcePathButler As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameButler As String = System.IO.Path.GetFileName(SourcePathButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathButler) Then

        Else
            MessageBox.Show("You seem to be missing butler.exe. You can still work in the app, you cannot update your games however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SourcePathUpdateButler As String = "Update Butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then

        Else
            MessageBox.Show("You seem to be missing Update Butler.exe. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SourcePath7zip As String = "7z.dll" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim Filename7zip As String = System.IO.Path.GetFileName(SourcePath7zip) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePath7zip) Then

        Else
            MessageBox.Show("You seem to be missing 7z.dll. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SourcePathc7 As String = "c7zip.dll" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim Filename As String = System.IO.Path.GetFileName(SourcePathc7) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathc7) Then

        Else
            MessageBox.Show("You seem to be missing c7zip.dll. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
        Folder.Text = FolderBrowserDialog1.SelectedPath()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Username.Text = ""
        Version.Text = ""
        GameURL.Text = ""
        Folder.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "butler.exe"
        pHelp.Arguments = "push " + Folder.Text + " " + Username.Text + "/" + GameURL.Text + ":win --userversion " + Version.Text
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "butler.exe"
        pHelp.Arguments = "login"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SourcePathUpdateButler As String = "Update Butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "Update Butler.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("You seem to be missing Update Butler.exe. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "butler.exe"
        pHelp.Arguments = "logout"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SelectFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFolderToolStripMenuItem.Click
        FolderBrowserDialog1.ShowDialog()
        Folder.Text = FolderBrowserDialog1.SelectedPath()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LicenseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem1.Click
        MessageBox.Show("Easy Butler is under the GNU GPL License. This means that it is 100% free! And Open-Source!", "License", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class

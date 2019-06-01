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
        If My.Settings.DarkTheme = False Then

        ElseIf My.Settings.DarkTheme = True Then
            Me.BackColor = Color.DimGray
            Me.ForeColor = Color.White
            Button1.BackColor = Color.DimGray
            Button2.BackColor = Color.DimGray
            Button3.BackColor = Color.DimGray
            Button7.BackColor = Color.DimGray
            Button6.BackColor = Color.DimGray
            Button5.BackColor = Color.DimGray
            Button8.BackColor = Color.DimGray
            Button9.BackColor = Color.DimGray
            Button10.BackColor = Color.DimGray
            Button11.BackColor = Color.DimGray
            Button12.BackColor = Color.DimGray
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
        Dim SourcePathLogin As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogin) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "push """ + Folder.Text + """ " + Username.Text + "/" + GameURL.Text + ":" + OS_Select.Text + " --userversion " + Version.Text
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("You seem to be missing butler.exe. You cannot update your game without this file. Please try downloading the latest version of Easy Butler, or download butler manualy from here: https://fasterthanlime.itch.io/butler.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SourcePathLogin As String = "login.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogin) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "login.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("You seem to be missing login.exe. You cannot login to butler.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SourcePathUpdateButler As String = "Update Butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "Update Butler.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Hidden
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("You seem to be missing Update Butler.exe. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SourcePathLogout As String = "logout.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogout) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogout) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "logout.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Hidden
            Dim proc As Process = Process.Start(pHelp)
            MsgBox("You have been logged out!")
        Else
            MessageBox.Show("You seem to be missing logout.exe. You cannot logout of butler.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SelectFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFolderToolStripMenuItem.Click
        FolderBrowserDialog1.ShowDialog()
        Folder.Text = FolderBrowserDialog1.SelectedPath()
    End Sub

    Private Sub LicenseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem1.Click
        MessageBox.Show("Easy Butler is under the GNU GPL License. This means that it is 100% free! And Open-Source!", "License", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MessageBox.Show("Type in what version of your game is. It cannot be a lower version, or the same version number.", "What's This?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Select the area where your compiled code is. Press the ""..."" button to open the folder selector.", "What's This?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("This is where you put your game URL. For example, if you have your game set up to yourusername.itch.io/really-cool-game, you would need to have it set to really-cool-game.", "What's This?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("This is where you put your user name. This allows Easy Butler to push games out to the right URL", "What's This?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MessageBox.Show("Select the OS your game is directed to. This means if you have a Mac game, you would select Mac, or if you have a Linux game, you would select Linux. There is NO Support of iOS.", "What's This?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim SourcePathLogin As String = "login.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogin) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "login.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("You seem to be missing login.exe. You cannot login to butler.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim SourcePathUpdateButler As String = "Update Butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "Update Butler.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Hidden
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("You seem to be missing Update Butler.exe. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UpdateGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateGameToolStripMenuItem.Click
        MsgBox("Please use the main form, not the menu strip, to update your game.")
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim SourcePathLogout As String = "logout.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogout) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogout) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "logout.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Hidden
            Dim proc As Process = Process.Start(pHelp)
            MsgBox("You have been logged out!")
        Else
            MessageBox.Show("You seem to be missing logout.exe. You cannot logout of butler.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub
End Class

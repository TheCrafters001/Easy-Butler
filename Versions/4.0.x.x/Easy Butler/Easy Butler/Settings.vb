Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.RememUser = True
        Else
            My.Settings.RememUser = False
        End If
        If CheckBox2.Checked = True Then
            My.Settings.RememURL = True
        Else
            My.Settings.RememURL = False
        End If
        If CheckBox3.Checked = True Then
            My.Settings.RememFold = True
        Else
            My.Settings.RememFold = False
        End If
        If CheckBox4.Checked = True Then
            My.Settings.RememOS = True
        Else
            My.Settings.RememOS = False
        End If
        If CheckBox5.Checked = True Then
            My.Settings.RememVer = True
        Else
            My.Settings.RememVer = False
        End If




        If CheckBox6.Checked = True Then
            My.Settings.DarkTheme = "on"
        Else
            My.Settings.DarkTheme = "off"

        End If
        My.Settings.Save()

        Dim dlgResult As DialogResult = MessageBox.Show("A restart may be required for some settings. Would you like to restart?", "Restart?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgResult = DialogResult.Yes Then

            Application.Restart()
        Else
        End If
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DarkTheme = "off" Then

        ElseIf My.Settings.DarkTheme = "on" Then
            Me.BackColor = Color.DimGray
            Me.ForeColor = Color.White
            Button1.BackColor = Color.DimGray
            Button2.BackColor = Color.DimGray
        Else
            'Do Nothing
        End If
        If My.Settings.RememUser = True Then
            CheckBox1.Checked = True
        End If
        If My.Settings.RememURL = True Then
            CheckBox2.Checked = True
        End If
        If My.Settings.RememFold = True Then
            CheckBox3.Checked = True
        End If
        If My.Settings.RememOS = True Then
            CheckBox4.Checked = True
        End If
        If My.Settings.RememVer = True Then
            CheckBox5.Checked = True
        End If
        If My.Settings.DarkTheme = "on" Then
            CheckBox6.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dlgResult As DialogResult = MessageBox.Show("Are you sure? Any changes you may have made will not be saved.", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgResult = DialogResult.Yes Then

            Me.Close()
        Else
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://forms.gle/97QpsyUUTFNPNJ7z8")
    End Sub
End Class
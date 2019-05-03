Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If RadioButton1.Checked = True + RadioButton2.Checked = False Then
        'My.Settings.DarkTheme = False
        'My.Settings.Save()
        'Else
        'My.Settings.DarkTheme = True
        'My.Settings.Save()
        'End If
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
        My.Settings.Save()
        'Dim dlgResult As DialogResult = MessageBox.Show("A restart may be required for some settings. Would you like to restart?", "Restart?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If dlgResult = DialogResult.Yes Then
        '
        'Application.Restart()
        'Else
        'End If
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'If My.Settings.DarkTheme = False Then

        'ElseIf My.Settings.DarkTheme = True Then
        'RadioButton2.Checked = True
        'RadioButton1.Checked = False
        'Me.BackColor = Color.DimGray
        'Me.ForeColor = Color.White
        'Button1.BackColor = Color.DimGray
        'Button2.BackColor = Color.DimGray
        'End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
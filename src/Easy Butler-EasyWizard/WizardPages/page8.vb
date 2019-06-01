Public Class page8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please put your (compiled) game folder in the text box.", "No User Input...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            My.Settings.Folder = TextBox1.Text
            My.Settings.Save()
            page9.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the wizard now? Your changes will not be saved.", "Exit now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            end_failed.Show()
            Me.Close()
        End If
    End Sub
End Class
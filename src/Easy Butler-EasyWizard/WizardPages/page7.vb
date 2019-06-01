Public Class page7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please put your new game version in the text box.", "No User Input...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            My.Settings.NewGameVer = TextBox1.Text
            My.Settings.Save()
            page8.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        page6.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the wizard now? Your changes will not be saved.", "Exit now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            end_failed.Show()
            Me.Close()
        End If
    End Sub
End Class
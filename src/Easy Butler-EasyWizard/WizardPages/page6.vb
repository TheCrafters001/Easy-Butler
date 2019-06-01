﻿Public Class page6
    Private Sub Page6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        page5.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OS_Select.Text = "" Then
            MessageBox.Show("Please put your Itch.IO URL (http://" + My.Settings.UserName + ".itch.io/(gameURL)) in the text box.", "No User Input...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            My.Settings.GameURL = OS_Select.Text
            My.Settings.Save()
            page7.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the wizard now? Your changes will not be saved.", "Exit now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            end_failed.Show()
            Me.Close()
        End If
    End Sub
End Class
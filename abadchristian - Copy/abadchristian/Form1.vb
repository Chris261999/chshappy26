Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LoadCount < 0 Then
            Form2.ShowDialog()
        End If
        Me.Text = My.Settings.appstat & ": count = > " & My.Settings.LoadCount
        My.Settings.LoadCount -= 1
        My.Settings.Save()
    End Sub
End Class

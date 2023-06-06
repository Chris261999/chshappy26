Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cha24XX
        If My.Settings.Serialkey = TextBox1.Text Then
            My.Settings.appstat = "full version"
            My.Settings.Save()
            Close()
        Else
            MsgBox("invalid serialkey")
        End If
    End Sub
End Class
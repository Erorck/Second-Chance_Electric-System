Public Class FormLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Me.Hide()
        FormAdminGen.ShowDialog()
        Me.Show()
    End Sub

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Me.Close()
    End Sub
End Class

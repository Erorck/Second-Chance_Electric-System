Public Class FormCambiarContra
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormEmplGen.Close()
        FormLogin.Show()

        My.Settings.Numero_Usuario = -1
        My.Settings.Tipo = 1
        My.Settings.Check = False
        My.Settings.Password = ""
    End Sub
End Class
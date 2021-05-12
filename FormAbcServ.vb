Public Class FormAbcServ
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        FormAbcCliente.ShowDialog()
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class
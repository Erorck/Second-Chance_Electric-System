Public Class Form6
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        Form5.ShowDialog()
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class
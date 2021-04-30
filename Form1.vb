Public Class FormAdminGen
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        Me.Hide()
        Form5.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Me.Hide()
        Form6.ShowDialog()
        Me.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Me.Hide()
        FormAbcEmpl.ShowDialog()
        Me.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub
End Class
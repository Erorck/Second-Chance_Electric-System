Public Class FormGeneral
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        Me.Hide()
        FormAbcCliente.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Me.Hide()
        FormAbcServ.ShowDialog()
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

    Private Sub ConsultaDeReciboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeReciboToolStripMenuItem.Click
        Me.Hide()
        FormAbcRcb.ShowDialog()
        Me.Show()
    End Sub

    Private Sub TarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifasToolStripMenuItem.Click

    End Sub

    Private Sub GestiónTarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónTarifasToolStripMenuItem.Click
        Me.Hide()
        FormAbcTar.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GestiónConsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónConsumosToolStripMenuItem.Click
        Me.Hide()
        FormAbcCons.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        Me.Hide()
        FormRepGeneral.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ConsumoHistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumoHistóricoToolStripMenuItem.Click
        Me.Hide()
        FormRepConsH.ShowDialog()
        Me.Show()
    End Sub
End Class
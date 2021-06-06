Public Class FormAbcEmpl
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormAbcEmpl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScdChncDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.ScdChncDataSet.Empleado)

    End Sub

    Private Sub DGVEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        Dim i As Integer

        'With DGVEmpleados
        '    If e.RowIndex >= 0 Then
        '        i = .CurrentRow.Index

        '        txtNombre.Text = .Rows(i).Cells("Nombre").Value.ToString
        '    End If
        'End With

        txtNombre.Text = "Hola"

    End Sub
End Class
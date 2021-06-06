Public Class Form1
    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScdChncDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScdChncDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.ScdChncDataSet.Empleado)

    End Sub

    Private Sub EmpleadoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles EmpleadoBindingSource.CurrentChanged

    End Sub
End Class
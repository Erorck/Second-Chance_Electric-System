Public Class FormAbcCliente
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

    Private Sub FormAbcCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Vista_Cliente.All_Clients' table. You can move, or remove it, as needed.
        Me.All_ClientsTableAdapter.Fill(Me.DS_Vista_Cliente.All_Clients)
        'TODO: This line of code loads data into the 'DS_Tabla_Cliente.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DS_Tabla_Cliente.Cliente)

    End Sub


End Class
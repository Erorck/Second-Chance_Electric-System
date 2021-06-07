Public Class FormAbcCons
    Private Sub FormAbcCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Vista_Consumo.All_Consumptions' table. You can move, or remove it, as needed.
        Me.All_ConsumptionsTableAdapter.Fill(Me.DS_Vista_Consumo.All_Consumptions)
        'TODO: This line of code loads data into the 'DS_Tabla_Consumo.Consumo' table. You can move, or remove it, as needed.
        Me.ConsumoTableAdapter.Fill(Me.DS_Tabla_Consumo.Consumo)

    End Sub
End Class
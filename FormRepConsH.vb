Imports System.Data.SqlClient

Public Class FormRepConsH
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

#Region "Filtrar"
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim ds As New DataSet
        Dim dt As DataTable = New DataTable
        Dim adapter As SqlDataAdapter
        Dim command As New SqlCommand()
        Dim Temp As Integer

        Try
            Temp = CInt(txtAño.Text)
            params(0) = New SqlParameter("@Año", SqlDbType.Int)
            params(0).Value = Temp

            Temp = CInt(txtServicio.Text)
            params(1) = New SqlParameter("@Servicio", SqlDbType.Int)
            params(1).Value = Temp

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ReporteCH"
            command.Parameters.AddRange(params)
            adapter = New SqlDataAdapter(command)

            connection.Open()
            With RepChDataViewGrid
                adapter.Fill(dt)
                'reset the datasource from the binding source
                .DataSource = dt
                'should redraw with the new data
                .Refresh()
            End With

            ' RepChDataViewGrid.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
#End Region

#Region "Generar PDF"
    Private Sub btnGenerarPDF_Click(sender As Object, e As EventArgs) Handles btnGenerarPDF.Click

    End Sub
#End Region

End Class
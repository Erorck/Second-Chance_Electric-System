Imports System.Data.SqlClient

Public Class FormRepGeneral

#Region "Cerrar form"
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

#End Region

#Region "Filtrar"
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(2) As SqlParameter
        Dim ds As New DataSet
        Dim dt As DataTable = New DataTable
        Dim adapter As SqlDataAdapter
        Dim command As New SqlCommand()
        Dim Temp As Integer


        Try
            Temp = CInt(txtAño.Text)
            params(0) = New SqlParameter("@Año", SqlDbType.Int)
            params(0).Value = Temp

            Temp = CInt(cbMes.SelectedValue)
            params(1) = New SqlParameter("@Mes", SqlDbType.Int)
            params(1).Value = Temp

            params(2) = New SqlParameter("@TipoS", SqlDbType.VarChar)
            params(2).Value = cbTipo.SelectedValue

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Reporte_General"
            command.Parameters.AddRange(params)
            adapter = New SqlDataAdapter(command)

            connection.Open()
            With RepGenDataViewGrid
                adapter.Fill(dt)
                'reset the datasource from the binding source
                .DataSource = dt
                'should redraw with the new data
                .Refresh()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

#End Region

#Region "Cargar Form"
    Private Sub FormRepGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "CARGAR COMBOBOX MES"
        Dim typeString As System.Type = System.Type.GetType("System.String")
        Dim typeInt As System.Type = System.Type.GetType("System.Int32")

        Dim dtG As DataTable = New DataTable()
        dtG.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeInt), New DataColumn("Name", typeString)})
        dtG.Rows.Add(0, "TODOS")
        dtG.Rows.Add(1, "ENE")
        dtG.Rows.Add(2, "FEB")
        dtG.Rows.Add(3, "MAR")
        dtG.Rows.Add(4, "ABR")
        dtG.Rows.Add(5, "MAY")
        dtG.Rows.Add(6, "JUN")
        dtG.Rows.Add(7, "JUL")
        dtG.Rows.Add(8, "AGO")
        dtG.Rows.Add(9, "SEP")
        dtG.Rows.Add(10, "OCT")
        dtG.Rows.Add(11, "NOV")
        dtG.Rows.Add(12, "DIC")


        'Assign DataTable as DataSource.
        cbMes.DataSource = dtG
        cbMes.DisplayMember = "Name"
        cbMes.ValueMember = "Id"
        cbMes.SelectedValue = 0
#End Region

#Region "CARGA COMBO TIPO SERVICIO"
        Dim dtT As DataTable = New DataTable
        dtT.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeString), New DataColumn("Name", typeString)})
        dtT.Rows.Add("A", "AMBOS")
        dtT.Rows.Add("R", "RESIDENCIAL")
        dtT.Rows.Add("I", "INDUSTRIAL")

        'Assign DataTable as DataSource.
        cbTipo.DataSource = dtT
        cbTipo.DisplayMember = "Name"
        cbTipo.ValueMember = "Id"
        cbTipo.SelectedValue = "A"
#End Region

    End Sub
#End Region


End Class
Imports System.Data.SqlClient

Public Class FormAbcRcb

#Region "Cargar Form"
    Private Sub FormAbcRcb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Tabla_Rcb.All_Receipts' table. You can move, or remove it, as needed.
        Me.All_ReceiptsTableAdapter.Fill(Me.DS_Tabla_Rcb.All_Receipts)

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

#Region "Cerrar Form"
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

#End Region

#Region "Generar Rcb"
    Private Sub btnGenerarRcb_Click(sender As Object, e As EventArgs) Handles btnGenerarRcb.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(7) As SqlParameter

        Dim command As New SqlCommand()
        Dim Temp As Integer


        Try
            If cbMes.SelectedValue = 0 And cbTipo.SelectedValue = "A" Then
                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "INSTA"
            End If

            If cbMes.SelectedValue > 0 And cbTipo.SelectedValue = "A" Then
                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "INSUA"
            End If

            If cbMes.SelectedValue = 0 And cbTipo.SelectedValue <> "A" Then
                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "INSTU"
            End If

            If cbMes.SelectedValue > 0 And cbTipo.SelectedValue <> "A" Then
                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "INSUU"
            End If

            params(1) = New SqlParameter("@No_Recibo", SqlDbType.Int)
            params(1).Value = Nothing

            Temp = CInt(txtAño.Text)
            params(2) = New SqlParameter("@Año", SqlDbType.Int)
            params(2).Value = Temp

            Temp = CInt(cbMes.SelectedValue)
            params(3) = New SqlParameter("@Mes", SqlDbType.Int)
            params(3).Value = Temp

            params(4) = New SqlParameter("@TipoS", SqlDbType.VarChar)
            params(4).Value = cbTipo.SelectedValue

            params(5) = New SqlParameter("@Servicio", SqlDbType.Int)
            params(5).Value = Nothing

            params(6) = New SqlParameter("@Fo_Pago", SqlDbType.VarChar)
            params(6).Value = Nothing

            params(7) = New SqlParameter("@Usuario_Mod", SqlDbType.Int)
            params(7).Value = FormLogin.Usuario

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Recibo"
            command.Parameters.AddRange(params)


            connection.Open()

            command.ExecuteNonQuery()

            With GenRcbDataViewGrid
                .DataSource = Nothing
                'refill the table adapter from the dataset table 
                All_ReceiptsTableAdapter.Fill(Me.DS_Tabla_Rcb.All_Receipts)
                'reset the datasource from the binding source
                .DataSource = Me.AllReceiptsBindingSource
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

End Class
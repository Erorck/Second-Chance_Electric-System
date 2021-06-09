Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

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

        If txtAño.Text = "" Then
            lbMsg.Text = "Ingrese un año"
            Return
        End If

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

        lbMsg.Text = ""
    End Sub
#End Region

#Region "Metodos para exportar datos"
    Public Function Getcolumnaszise(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next

        Return values

    End Function

    Public Sub exportardatospdf(ByVal document As Document, ByVal Header As String, ByVal Frase As String)

        Dim datatable As New PdfPTable(RepGenDataViewGrid.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = Getcolumnaszise(RepGenDataViewGrid)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New iTextSharp.text.Paragraph(Header, New Font(Font.Name = "Tahoma", 20, Font.Bold))

        Dim texto As New Phrase(Frase, New Font(Font.Name = "Tahoma", 14, Font.Bold))


        For i As Integer = 0 To RepGenDataViewGrid.ColumnCount - 1
            datatable.AddCell(RepGenDataViewGrid.Columns(i).HeaderText)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To RepGenDataViewGrid.RowCount - 1
            For j As Integer = 0 To RepGenDataViewGrid.ColumnCount - 1
                datatable.AddCell(RepGenDataViewGrid(j, i).Value.ToString())
            Next

            datatable.CompleteRow()
        Next

        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)

    End Sub
#End Region

#Region "Generar PDF"
    Private Sub btnGenerarPDF_Click(sender As Object, e As EventArgs) Handles btnGenerarPDF.Click
        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte General.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            exportardatospdf(doc, "Reporte", "Reporte General")
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("No se puede crear el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
#End Region

End Class
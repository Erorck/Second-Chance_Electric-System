Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

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

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
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

        Dim datatable As New PdfPTable(RepChDataViewGrid.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = Getcolumnaszise(RepChDataViewGrid)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New iTextSharp.text.Paragraph(Header, New Font(Font.Name = "Tahoma", 20, Font.Bold))

        Dim texto As New Phrase(Frase, New Font(Font.Name = "Tahoma", 14, Font.Bold))


        For i As Integer = 0 To RepChDataViewGrid.ColumnCount - 1
            datatable.AddCell(RepChDataViewGrid.Columns(i).HeaderText)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To RepChDataViewGrid.RowCount - 1
            For j As Integer = 0 To RepChDataViewGrid.ColumnCount - 1
                datatable.AddCell(RepChDataViewGrid(j, i).Value.ToString())
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
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reportes.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            exportardatospdf(doc, "Reporte", "Reporte de Consumo Historico")
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("No se puede crear el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
#End Region

End Class
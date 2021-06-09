Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FormConsulRcb
#Region "Cerrar Form"
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

#End Region

#Region "Cargar form"
    Private Sub FormConsulRcb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter

#Region "CARGAR COMBOBOX MES"
        Dim typeString As System.Type = System.Type.GetType("System.String")
        Dim typeInt As System.Type = System.Type.GetType("System.Int32")

        Dim dtG As DataTable = New DataTable()
        dtG.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeInt), New DataColumn("Name", typeString)})
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
        cbMes.SelectedValue = 1
#End Region

#Region "CARGA COMBOBOX Servicio"
        Dim command As New SqlCommand()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable

        Try

            If FormLogin.TipoU = 2 Then
                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "SLAC"

                params(1) = New SqlParameter("@Cliente", SqlDbType.Int)
                params(1).Value = FormLogin.Usuario
            Else
                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "SLCT"

                params(1) = New SqlParameter("@Cliente", SqlDbType.Int)
                params(1).Value = Nothing
            End If



            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Servicio"
            command.Parameters.AddRange(params)

            connection.Open()

            With da
                .SelectCommand = command
                .Fill(dt)
            End With

            cbServicio.DataSource = dt
            cbServicio.DisplayMember = dt.Columns(4).ColumnName
            cbServicio.ValueMember = dt.Columns(0).ColumnName
            cbServicio.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            da.Dispose()
        End Try
#End Region

#Region "CARGAR COMBOBOX FORMA DE PAGO"

        Dim dtF As DataTable = New DataTable()
        dtF.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeString), New DataColumn("Name", typeString)})
        dtF.Rows.Add("FP", "Forma de pago")
        dtF.Rows.Add("EFC", "Efectivo")
        dtF.Rows.Add("TB", "Transferencia bancaria")
        dtF.Rows.Add("TD", "Tarjeta Debito")
        dtF.Rows.Add("TC", "Tarjeta Credito")

        'Assign DataTable as DataSource.
        cbFo_Pago.DataSource = dtF
        cbFo_Pago.DisplayMember = "Name"
        cbFo_Pago.ValueMember = "Id"
        cbFo_Pago.SelectedIndex = 0
#End Region

        btnPagar.Enabled = False
        cbFo_Pago.Visible = False

    End Sub
#End Region

#Region "Metodos para exportar datos"

    Public Sub exportardatospdf(ByVal document As Document, ByVal Header As String, ByVal Frase As String)

        'Encabezado
        Dim encabezado1 As New Paragraph("RECIBO", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim encabezado2 As New Paragraph("CFE Contigo", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim encabezado3 As New Paragraph("           ", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        With ConsulRcbDataViewGrid

            Dim Temp As String
            Dim Temp2 As String
            Dim Temp3 As String
            'Cliente		

            Temp = .Rows(0).Cells("Numero_Contrato").Value
            Dim texto1 As New Paragraph("Número de servicio: " + Temp, New Font(Font.Name = "Tahoma", 15, Font.Bold))

            Temp = .Rows(0).Cells("Cliente").Value
            Dim texto2 As New Paragraph("Nombre: " + Temp, New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Temp = .Rows(0).Cells("Ubicacion").Value
            Dim texto3 As New Paragraph("Dirección: " + Temp, New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Dim texto4 As New Paragraph("                       ", New Font(Font.Name = "Tahoma", 16, Font.Bold))

            Temp = .Rows(0).Cells("Año").Value
            Temp2 = " - " + .Rows(0).Cells("Mes").Value
            Dim texto5 As New Paragraph("Periodo: " + Temp + Temp2, New Font(Font.Name = "Tahoma", 16, Font.Bold))

            Dim texto6 As New Paragraph("                    ", New Font(Font.Name = "Tahoma", 16, Font.Bold))

            'Datos
            Temp = "Consumo Básico:      " + .Rows(0).Cells("Consumo_Basico").Value
            Temp2 = "  Tarifa Básica:      " + .Rows(0).Cells("Tarifa_Basica").Value
            Temp3 = "  Subtotal Básico:    " + .Rows(0).Cells("Subtotal_Basico").Value

            Dim Consumo1 As New Paragraph(Temp + Temp2 + Temp3, New Font(Font.Name = "Tahoma", 14, Font.Bold))


            Temp = "Consumo Intermedio:  " + .Rows(0).Cells("Consumo_Intermedio").Value
            Temp2 = "  Tarifa Intermedia:  " + .Rows(0).Cells("Tarifa_Intermedia").Value
            Temp3 = "  Subtotal Intermedio:" + .Rows(0).Cells("Subtotal_Intermedio").Value

            Dim Consumo2 As New Paragraph(Temp + Temp2 + Temp3, New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Temp = "Consumo Excedente:   " + .Rows(0).Cells("Consumo_Excedente").Value
            Temp2 = "  Tarifa Excedente:   " + .Rows(0).Cells("Tarifa_Excedente").Value
            Temp3 = "  Subtotal Excedente: " + .Rows(0).Cells("Subtotal_Excedente").Value

            Dim Consumo3 As New Paragraph(Temp + Temp2 + Temp3, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            Dim Consumo12 As New Paragraph("                       ", New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Temp = "                                                  Consumo Total:       " + .Rows(0).Cells("Consumo_Total").Value
            Temp2 = "                                                  Subtotal:          " + .Rows(0).Cells("Subtotal_Final").Value

            Dim Consumo4 As New Paragraph(Temp, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            Dim Consumo5 As New Paragraph(Temp2, New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Temp = "                                                  IVA:               " + .Rows(0).Cells("IVA").Value
            Temp2 = "                                                  Total:             " + .Rows(0).Cells("Total").Value

            Dim Consumo6 As New Paragraph(Temp, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            Dim Consumo7 As New Paragraph(Temp2, New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Temp = "Total con nombre:     " + .Rows(0).Cells("Total_Nombre").Value
            Temp2 = "    Fecha límite pago:   " + .Rows(0).Cells("Fecha_Limite_Pago").Value

            Dim Consumo8 As New Paragraph("                       ", New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Dim Consumo9 As New Paragraph(Temp + Temp2, New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Dim Consumo10 As New Paragraph("                       ", New Font(Font.Name = "Tahoma", 14, Font.Bold))

            Temp = .Rows(0).Cells("Estado").Value
            If Temp = "PG" Then
                Temp = "Pagado"
            Else
                Temp = "Pendiente de pago"
            End If
            Dim Consumo11 As New Paragraph("                  Estatus:     " + Temp,
                                          New Font(Font.Name = "Tahoma", 14, Font.Bold))


            'Generar recibo.
            document.Add(encabezado1)
            document.Add(encabezado2)
            document.Add(encabezado3)
            document.Add(texto1)
            document.Add(texto2)
            document.Add(texto3)
            document.Add(texto4)
            document.Add(texto5)
            document.Add(texto6)
            document.Add(Consumo1)
            document.Add(Consumo2)
            document.Add(Consumo3)
            document.Add(Consumo12)
            document.Add(Consumo4)
            document.Add(Consumo5)
            document.Add(Consumo6)
            document.Add(Consumo7)
            document.Add(Consumo8)
            document.Add(Consumo9)
            document.Add(Consumo10)
            document.Add(Consumo11)
        End With



    End Sub

#End Region

#Region "Generar PDF"
    Private Sub btnGenerarPDF_Click(sender As Object, e As EventArgs) Handles btnGenerarRcbPDF.Click
        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Recibo.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            exportardatospdf(doc, "Recibo", "Desglose")
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("No se puede crear el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
#End Region

#Region "Boton buscar"
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(5) As SqlParameter
        Dim dt As DataTable = New DataTable
        Dim adapter As SqlDataAdapter
        Dim Temp As Integer
        Dim TempS As String
        Dim Msg As String

        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "SLC1S"

        params(1) = New SqlParameter("@No_Recibo", SqlDbType.Int)
        params(1).Value = Nothing

        Temp = CInt(txtAño.Text)
        params(2) = New SqlParameter("@Año", SqlDbType.Int)
        params(2).Value = Temp

        Temp = CInt(cbMes.SelectedValue)
        params(3) = New SqlParameter("@Mes", SqlDbType.Int)
        params(3).Value = Temp

        params(4) = New SqlParameter("@TipoS", SqlDbType.VarChar)
        params(4).Value = Nothing

        params(5) = New SqlParameter("@Servicio", SqlDbType.Int)
        params(5).Value = cbServicio.SelectedValue

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Recibo"
        command.Parameters.AddRange(params)

        adapter = New SqlDataAdapter(command)

        Try
            connection.Open()

            With ConsulRcbDataViewGrid
                adapter.Fill(dt)
                'reset the datasource from the binding source
                .DataSource = dt
                'should redraw with the new data
                .Refresh()
                'clear out the datasource for the Grid view
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        connection.Close()

        lbId.Text = ConsulRcbDataViewGrid.Rows(0).Cells("Numero_Recibo").Value.ToString
        TempS = ConsulRcbDataViewGrid.Rows(0).Cells("Estado").Value.ToString

        If TempS = "PP" Then
            btnPagar.Enabled = True
            cbFo_Pago.Visible = True
        Else
            btnPagar.Enabled = False
            cbFo_Pago.Visible = False
        End If

        btnGenerarRcbPDF.Enabled = True

    End Sub

#End Region

#Region "Pagar"
    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(2) As SqlParameter

        Dim i As Integer
        Dim Msg As String

        i = CInt(lbId.Text)

        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "PAG1"

        params(1) = New SqlParameter("@No_Recibo", SqlDbType.Int)
        params(1).Value = i

        params(2) = New SqlParameter("@Fo_Pago", SqlDbType.VarChar)
        params(2).Value = cbFo_Pago.SelectedValue


        Msg = "Se ha pagado el recibo: " + CStr(i)

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Recibo"
        command.Parameters.AddRange(params)

        Try
            connection.Open()

            command.ExecuteNonQuery()

            With ConsulRcbDataViewGrid
                .Refresh()
                'clear out the datasource for the Grid view
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        btnPagar.Enabled = False
        cbFo_Pago.Visible = False

        connection.Close()

        MessageBox.Show(Msg)

    End Sub
#End Region

End Class
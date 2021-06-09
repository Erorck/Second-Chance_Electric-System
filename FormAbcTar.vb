Imports System.Data.SqlClient

Public Class FormAbcTar

#Region "Cargar Form"
    Private Sub FormAbcTar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Tabla_Tarifa.Tarifa' table. You can move, or remove it, as needed.
        Me.TarifaTableAdapter.Fill(Me.DS_Tabla_Tarifa.Tarifa)

        LimpiarRegistro()

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(0) As SqlParameter

        lbId.Text = ""

#Region "CARGA COMBOBOX Mes"
        Dim command As New SqlCommand()
        Dim da As SqlDataAdapter = New SqlDataAdapter

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

#Region "CARGA COMBOBOX Tipo"

        Dim daT As SqlDataAdapter = New SqlDataAdapter
        Dim dtT As DataTable = New DataTable

        dtT.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeString), New DataColumn("Name", typeString)})

        dtT.Rows.Add("R", "RESIDENCIAL")
        dtT.Rows.Add("I", "INDUSTRIAL")

        'Assign DataTable as DataSource.
        cbTipo.DataSource = dtT
        cbTipo.DisplayMember = "Name"
        cbTipo.ValueMember = "Id"
        cbTipo.SelectedValue = "R"

#End Region

        lbUsuarioMod.Text = ""
        lbFechaMod.Text = ""

    End Sub

#End Region

#Region "Cerrar Form"
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

#End Region

#Region "Boton Limpiar"
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarRegistro()
    End Sub
#End Region

#Region "Metodo Limpiar espacios"
    Private Sub LimpiarRegistro()
        Dim i As Integer

        i = TarifaDataViewGrid.CurrentRow.Index

        lbId.Text = ""
        txtAño.Clear()

        txtCant_B.Clear()

        txtCant_I.Clear()

        txtCant_E.Clear()

        cbMes.SelectedIndex = 0
        cbTipo.SelectedValue = "R"

        lbUsuarioMod.Text = ""
        lbFechaMod.Text = ""

        cbMes.Enabled = True
        cbTipo.Enabled = True
        txtAño.Enabled = True

    End Sub


#End Region

#Region "Data Grid Funcionalidad"
    Private Sub TarifaDataViewGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TarifaDataViewGrid.CellClick
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter

        Dim i As Integer

        ' MessageBox.Show(e.RowIndex)
        With TarifaDataViewGrid
            i = .Rows(i).Cells("No_Tarifa").Value

            If e.RowIndex >= 0 Then

                Dim Temp As String
                i = .CurrentRow.Index

#Region "Llenado textbox"
                Temp = .Rows(i).Cells("No_Tarifa").Value.ToString
                lbId.Text = Temp

                Temp = .Rows(i).Cells("Año").Value.ToString
                txtAño.Text = Temp

                Temp = .Rows(i).Cells("Tar_B").Value.ToString
                txtCant_B.Text = Temp

                Temp = .Rows(i).Cells("Tar_I").Value.ToString
                txtCant_I.Text = Temp

                Temp = .Rows(i).Cells("Tar_E").Value.ToString
                txtCant_E.Text = Temp

                Temp = .Rows(i).Cells("F_Mod").Value.ToString
                lbFechaMod.Text = Temp

#End Region

                Temp = .Rows(i).Cells("Mes").Value.ToString
                cbMes.SelectedValue = CInt(Temp)

                Temp = .Rows(i).Cells("Tipo").Value.ToString
                cbTipo.SelectedValue = Temp

                'Usuario mod
                Dim adapter As SqlDataAdapter
                Dim ds As New DataSet
                Dim CONT As Integer

                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "SLT1"

                params(1) = New SqlParameter("@No_Tarifa", SqlDbType.Int)
                params(1).Value = CInt(lbId.Text)

                Dim command As New SqlCommand()

                Try
                    connection.Open()
                    command.Connection = connection
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_Tarifa"
                    command.Parameters.AddRange(params)
                    adapter = New SqlDataAdapter(command)
                    adapter.Fill(ds)

                    For CONT = 0 To ds.Tables(0).Rows.Count - 1
                        lbUsuarioMod.Text = ds.Tables(0).Rows(0).Item(7)
                    Next

                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    connection.Close()
                End Try

                cbMes.Enabled = False
                cbTipo.Enabled = False
                txtAño.Enabled = False

            End If

        End With
    End Sub

#End Region

#Region "Registrar/Editar"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(9) As SqlParameter
        Dim Temp As String
        Dim i As String
        Dim Msg As String

        i = lbId.Text

        If i = "" Then
            'USUARIO NUEVO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "INS"

            params(1) = New SqlParameter("@No_Tarifa", SqlDbType.Int)
            params(1).Value = 0

            Msg = "Se ha dado de alta la Tarifa: "

        Else

            'EDITAR USUARIO YA CREADO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "ED"

            params(1) = New SqlParameter("@No_Tarifa", SqlDbType.Int)
            params(1).Value = CInt(i)

            Msg = "Se ha modificado la Tarifa Consumo con Id: " + i + " del periodo: "

        End If

        Temp = cbMes.SelectedValue
        params(2) = New SqlParameter("@Mes", SqlDbType.Int)
        params(2).Value = CInt(Temp)

        Msg += cbMes.GetItemText(cbMes.SelectedItem) + " - "
        Temp = txtAño.Text
        params(3) = New SqlParameter("@Año", SqlDbType.Int)
        params(3).Value = CInt(Temp)

        Msg += Temp


        Temp = txtCant_B.Text
        params(4) = New SqlParameter("@Tar_B", SqlDbType.Decimal)
        params(4).Value = CDec(Temp)

        Temp = txtCant_I.Text
        params(5) = New SqlParameter("@Tar_I", SqlDbType.Decimal)
        params(5).Value = CDec(Temp)

        Temp = txtCant_E.Text
        params(6) = New SqlParameter("@Tar_E", SqlDbType.Decimal)
        params(6).Value = CDec(Temp)


        Temp = cbTipo.SelectedValue
        params(7) = New SqlParameter("@Tipo", SqlDbType.VarChar)
        params(7).Value = Temp

        Msg += " de tipo: " + cbTipo.GetItemText(cbTipo.SelectedItem)

        Temp = lbUsuarioMod.Text
        params(8) = New SqlParameter("@Usuario_Mod", SqlDbType.Int)
        params(8).Value = FormLogin.Usuario

        params(9) = New SqlParameter("@Archivo", SqlDbType.VarChar)
        params(9).Value = Nothing

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Tarifa"

        command.Parameters.AddRange(params)

        Try
            connection.Open()

            command.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        Finally
            connection.Close()
        End Try


        With TarifaDataViewGrid
            'clear out the datasource for the Grid view
            .DataSource = Nothing
            'refill the table adapter from the dataset table 
            Me.TarifaTableAdapter.Fill(Me.DS_Tabla_Tarifa.Tarifa)
            'reset the datasource from the binding source
            .DataSource = Me.TarifaBindingSource
            'should redraw with the new data
            .Refresh()
        End With

        MessageBox.Show(Msg)
        LimpiarRegistro()
    End Sub

#End Region

#Region "Carga masiva"
    Private Sub btnSubirArchivo_Click(sender As Object, e As EventArgs) Handles btnSubirArchivo.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(9) As SqlParameter
        Dim i As String
        Dim Msg As String
        Dim Temp As String

        Dim fichero As String
        Dim dlAbrir As New System.Windows.Forms.OpenFileDialog

        dlAbrir.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|" &
        "Todos los archivos (*.*)|*.*"
        dlAbrir.Multiselect = False
        dlAbrir.CheckFileExists = False
        dlAbrir.Title = "Selección de fichero"
        dlAbrir.ShowDialog()
        If dlAbrir.FileName <> "" Then
            fichero = dlAbrir.FileName
            Temp = fichero
        Else
            MessageBox.Show("Ruta no encontrada")
            Return
        End If

        i = lbId.Text


        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "INSM"

        params(1) = New SqlParameter("@No_Tarifa", SqlDbType.Int)
        params(1).Value = Nothing

        params(2) = New SqlParameter("@Mes", SqlDbType.Int)
        params(2).Value = Nothing

        params(3) = New SqlParameter("@Año", SqlDbType.Int)
        params(3).Value = Nothing

        params(4) = New SqlParameter("@Tar_B", SqlDbType.Decimal)
        params(4).Value = Nothing

        params(5) = New SqlParameter("@Tar_I", SqlDbType.Decimal)
        params(5).Value = Nothing

        params(6) = New SqlParameter("@Tar_E", SqlDbType.Decimal)
        params(6).Value = Nothing

        params(7) = New SqlParameter("@Tipo", SqlDbType.VarChar)
        params(7).Value = Nothing

        params(8) = New SqlParameter("@Usuario_Mod", SqlDbType.Int)
        params(8).Value = FormLogin.Usuario

        params(9) = New SqlParameter("@Archivo", SqlDbType.VarChar)
        params(9).Value = Temp


        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Tarifa"

        command.Parameters.AddRange(params)

        Try
            connection.Open()

            command.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try


        With TarifaDataViewGrid
            'clear out the datasource for the Grid view
            .DataSource = Nothing
            'refill the table adapter from the dataset table 
            Me.TarifaTableAdapter.Fill(Me.DS_Tabla_Tarifa.Tarifa)
            'reset the datasource from the binding source
            .DataSource = Me.TarifaBindingSource
            'should redraw with the new data
            .Refresh()
        End With

        LimpiarRegistro()
    End Sub
#End Region

End Class
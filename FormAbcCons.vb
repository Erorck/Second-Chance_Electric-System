Imports System.Data.SqlClient

Public Class FormAbcCons

#Region "Carga Formulario"
    Private Sub FormAbcCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(0) As SqlParameter

        'TODO: This line of code loads data into the 'DS_Vista_Consumo.All_Consumptions' table. You can move, or remove it, as needed.
        Me.All_ConsumptionsTableAdapter.Fill(Me.DS_Vista_Consumo.All_Consumptions)
        'TODO: This line of code loads data into the 'DS_Tabla_Consumo.Consumo' table. You can move, or remove it, as needed.
        Me.ConsumoTableAdapter.Fill(Me.DS_Tabla_Consumo.Consumo)

        lbId.Text = ""

#Region "CARGA COMBOBOX Servicio"
        Dim command As New SqlCommand()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable

        Try


            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "SLCT"

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
            cbServicio.DisplayMember = (dt.Columns(0).ColumnName + " Med:" + dt.Columns(1).ColumnName + " " + dt.Columns(3).ColumnName).ToString
            cbServicio.ValueMember = dt.Columns(0).ColumnName
            cbServicio.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            da.Dispose()
        End Try
#End Region

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
        cbMes.SelectedIndex = -1
#End Region


        lbUsuarioMod.Text = ""
        lbFechaMod.Text = ""
    End Sub
#End Region

#Region "Data Grid Funcionalidad"
    Private Sub ConsumoDataViewGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConsumoDataViewGrid.CellContentClick, ConsumoDataViewGrid.CellClick
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter

        Dim i As Integer

        ' MessageBox.Show(e.RowIndex)
        With ConsumoDataViewGrid
            i = .Rows(i).Cells("No_Consumo").Value

            If e.RowIndex >= 0 Then

                Dim Temp As String
                Dim TempD As Decimal
                i = .CurrentRow.Index

                lbCant_B.Text = .Rows(i).Cells("Cant_B").Value
                lbCant_I.Text = .Rows(i).Cells("Cant_I").Value
                lbCant_E.Text = .Rows(i).Cells("Cant_E").Value


#Region "Llenado textbox"
                Temp = .Rows(i).Cells("No_Consumo").Value.ToString
                lbId.Text = Temp

                Temp = .Rows(i).Cells("Año").Value.ToString
                txtAño.Text = Temp

                TempD = CDec(lbCant_B.Text) + CDec(lbCant_I.Text) + CDec(lbCant_E.Text)
                txtCant_T.Text = TempD

#End Region

                Temp = .Rows(i).Cells("F_Mod").Value.ToString
                lbFechaMod.Text = Temp

                lbCant_B.Text += " $  p/Kw"
                lbCant_I.Text += " $  p/Kw"
                lbCant_E.Text += " $  p/Kw"

                Temp = .Rows(i).Cells("Mes").Value.ToString
                cbMes.SelectedValue = CInt(Temp)

                Temp = .Rows(i).Cells("Servicio").Value.ToString
                cbServicio.SelectedValue = CInt(Temp)

                'Usuario mod
                Dim adapter As SqlDataAdapter
                Dim ds As New DataSet
                Dim CONT As Integer

                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "SLT1"

                params(1) = New SqlParameter("@No_Consumo", SqlDbType.Int)
                params(1).Value = CInt(Temp)

                Dim command As New SqlCommand()

                command.Connection = connection
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_Consumo"
                command.Parameters.AddRange(params)
                adapter = New SqlDataAdapter(command)

                connection.Open()
                adapter.Fill(ds)

                For CONT = 0 To ds.Tables(0).Rows.Count - 1
                    lbUsuarioMod.Text = ds.Tables(0).Rows(0).Item(8)
                    cbServicio.SelectedValue = CInt(ds.Tables(0).Rows(0).Item(0))
                Next

                connection.Close()

                If ConsumoDataViewGrid.Rows(i).Cells("Estatus").Value.ToString = "PR" Then
                    btnGuardar.Enabled = False
                    cbMes.Enabled = False
                    cbServicio.Enabled = False
                    txtAño.Enabled = False
                    txtCant_T.ReadOnly = True
                Else
                    btnGuardar.Enabled = True
                    cbMes.Enabled = True
                    cbServicio.Enabled = True
                    txtAño.Enabled = True
                    txtCant_T.ReadOnly = False
                End If

            End If

        End With
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

        i = ConsumoDataViewGrid.CurrentRow.Index

        lbId.Text = ""
        txtAño.Clear()

        txtCant_T.Clear()

        cbMes.SelectedIndex = -1
        cbServicio.SelectedIndex = -1

        lbUsuarioMod.Text = ""
        lbFechaMod.Text = ""

        btnGuardar.Enabled = True
        cbMes.Enabled = True
        cbServicio.Enabled = True
        txtAño.Enabled = True
        txtCant_T.ReadOnly = False

    End Sub

#End Region

#Region "Registrar/Modificar"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(7) As SqlParameter
        Dim Temp As String
        Dim i As String
        Dim Msg As String

        i = lbId.Text

        If i = "" Then
            'USUARIO NUEVO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "INS"

            params(1) = New SqlParameter("@No_Consumo", SqlDbType.Int)
            params(1).Value = 0

            Msg = "Se ha dado de alta el Consumo: "

        Else

            'EDITAR USUARIO YA CREADO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "ED"

            params(1) = New SqlParameter("@No_Consumo", SqlDbType.Int)
            params(1).Value = CInt(i)

            Msg = "Se ha modificado el Consumo con Id: " + i + " del periodo: "

        End If


        Temp = cbMes.SelectedValue
        params(2) = New SqlParameter("@Mes", SqlDbType.Int)
        params(2).Value = CInt(Temp)

        Msg += cbMes.GetItemText(cbMes.SelectedItem) + " - "

        Temp = txtAño.Text
        params(3) = New SqlParameter("@Año", SqlDbType.Int)
        params(3).Value = CInt(Temp)

        Msg += Temp

        Temp = txtCant_T.Text

        params(4) = New SqlParameter("@Cant_T", SqlDbType.Decimal)
        params(4).Value = CDec(Temp)


        Temp = cbServicio.SelectedValue
        params(5) = New SqlParameter("@Servicio", SqlDbType.Int)
        params(5).Value = CInt(Temp)


        params(6) = New SqlParameter("@Usuario_Mod", SqlDbType.Int)
        params(6).Value = FormLogin.Usuario

        params(7) = New SqlParameter("@Archivo", SqlDbType.VarChar)
        params(7).Value = Nothing

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Consumo"

        command.Parameters.AddRange(params)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

        'clear out the datasource for the Grid view
        Me.ConsumoDataViewGrid.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.ConsumoTableAdapter.Fill(Me.DS_Tabla_Consumo.Consumo)
        'reset the datasource from the binding source
        Me.ConsumoDataViewGrid.DataSource = Me.ConsumoBindingSource1
        'should redraw with the new data
        Me.ConsumoDataViewGrid.Refresh()

        MessageBox.Show(Msg)
        LimpiarRegistro()
    End Sub

#End Region

#Region "Carga_Masiva"
    Private Sub btnSubirArchivo_Click(sender As Object, e As EventArgs) Handles btnSubirArchivo.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(7) As SqlParameter
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

        params(1) = New SqlParameter("@No_Consumo", SqlDbType.Int)
        params(1).Value = Nothing

        params(2) = New SqlParameter("@Mes", SqlDbType.Int)
        params(2).Value = Nothing

        params(3) = New SqlParameter("@Año", SqlDbType.Int)
        params(3).Value = Nothing

        params(4) = New SqlParameter("@Cant_T", SqlDbType.Decimal)
        params(4).Value = Nothing

        params(5) = New SqlParameter("@Servicio", SqlDbType.Int)
        params(5).Value = Nothing

        params(6) = New SqlParameter("@Usuario_Mod", SqlDbType.Int)
        params(6).Value = FormLogin.Usuario

        params(7) = New SqlParameter("@Archivo", SqlDbType.VarChar)
        params(7).Value = Temp


        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Consumo"

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


        'clear out the datasource for the Grid view
        Me.ConsumoDataViewGrid.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.ConsumoTableAdapter.Fill(Me.DS_Tabla_Consumo.Consumo)
        'reset the datasource from the binding source
        Me.ConsumoDataViewGrid.DataSource = Me.ConsumoBindingSource1
        'should redraw with the new data
        Me.ConsumoDataViewGrid.Refresh()

        LimpiarRegistro()
    End Sub

#End Region

#Region "Cerrar Form"
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub
#End Region

End Class
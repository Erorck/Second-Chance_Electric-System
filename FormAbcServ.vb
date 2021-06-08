Imports System.Data.SqlClient

Public Class FormAbcServ

#Region "Cargar Form"
    Private Sub FormAbcServ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(0) As SqlParameter
        'TODO: This line of code loads data into the 'DS_Tabla_Servicios.Servicio' table. You can move, or remove it, as needed.
        Me.ServicioTableAdapter.Fill(Me.DS_Tabla_Servicios.Servicio)

        Dim typeString As System.Type = System.Type.GetType("System.String")

#Region "CARGA COMBO TIPO SERVICIO"
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

#Region "CARGA COMBOBOX ESTATUS"
        Dim dtE As DataTable = New DataTable()
        dtE.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeString), New DataColumn("Name", typeString)})
        dtE.Rows.Add("A", "ACTIVO")
        dtE.Rows.Add("S", "SUSPENDIDO")
        dtE.Rows.Add("E", "ELIMINADO")


        'Assign DataTable as DataSource.
        cbEstado.DataSource = dtE
        cbEstado.DisplayMember = "Name"
        cbEstado.ValueMember = "Id"

        cbEstado.SelectedValue = "A"

#End Region

#Region "CARGA COMBOBOX Cliente"
        Dim command As New SqlCommand()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dtC As DataTable = New DataTable

        Try


            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "SLCT"

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Cliente"
            command.Parameters.AddRange(params)

            connection.Open()

            With da
                .SelectCommand = command
                .Fill(dtC)
            End With

            cbClientes.DataSource = dtC

            Dim Temp As String

            Temp = dtC.Columns(1).ColumnName

            cbClientes.DisplayMember = Temp
            cbClientes.ValueMember = dtC.Columns(0).ColumnName
            cbClientes.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            da.Dispose()
        End Try
#End Region

        btnCerrarFormulario.Enabled = False
        btnEliminar.Enabled = False
        btnHabilitar.Enabled = False
        cbEstado.Enabled = False

    End Sub
#End Region

#Region "Metodo Limpiar espacios"
    Private Sub LimpiarRegistro()
        Dim i As Integer

        i = ServiciosDataViewGrid.CurrentRow.Index

        txtMedidor.Clear()
        cbClientes.SelectedIndex = 0
        cbTipo.SelectedValue = "R"
        txtUbicacion.Clear()

        lbId.Text = ""
        lbUsuarioMod.Text = ""
        lbFechaMod.Text = ""

        cbClientes.Enabled = True
        cbTipo.Enabled = True

        btnEliminar.Enabled = False
        btnHabilitar.Enabled = False

    End Sub


#End Region

#Region "Cerrar Form"
    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub
#End Region

#Region "DataViewGrid Funcionalidad"
    Private Sub TarifaDataViewGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiciosDataViewGrid.CellClick

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter

        Dim i As Integer

        ' MessageBox.Show(e.RowIndex)
        With ServiciosDataViewGrid
            i = .Rows(i).Cells("No_Servicio").Value

            If e.RowIndex >= 0 Then

                Dim Temp As String
                i = .CurrentRow.Index

                Temp = .Rows(i).Cells("No_Servicio").Value.ToString
                lbId.Text = Temp

#Region "Llenado textbox"

                Temp = .Rows(i).Cells("No_Medidor").Value.ToString
                txtMedidor.Text = Temp

                Temp = .Rows(i).Cells("Ubicacion").Value.ToString
                txtUbicacion.Text = Temp

#End Region
                Temp = .Rows(i).Cells("Cliente").Value.ToString
                cbClientes.SelectedValue = Temp

                Temp = .Rows(i).Cells("Tipo").Value.ToString
                cbTipo.SelectedValue = Temp

                Temp = .Rows(i).Cells("F_Mod").Value.ToString
                lbFechaMod.Text = Temp

                Temp = .Rows(i).Cells("Estatus").Value.ToString
                cbEstado.SelectedValue = Temp

                If cbEstado.SelectedValue = "A" Then
                    btnHabilitar.Enabled = False
                    btnEliminar.Enabled = True
                Else
                    btnHabilitar.Enabled = True
                    btnEliminar.Enabled = False
                End If

                'Usuario mod
                Dim adapter As SqlDataAdapter
                Dim ds As New DataSet
                Dim CONT As Integer

                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "SLT1"

                params(1) = New SqlParameter("@No_Servicio", SqlDbType.Int)
                params(1).Value = CInt(lbId.Text)

                Dim command As New SqlCommand()

                Try
                    connection.Open()
                    command.Connection = connection
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_Servicio"
                    command.Parameters.AddRange(params)
                    adapter = New SqlDataAdapter(command)
                    adapter.Fill(ds)

                    For CONT = 0 To ds.Tables(0).Rows.Count - 1
                        lbUsuarioMod.Text = ds.Tables(0).Rows(0).Item(4)
                    Next

                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    connection.Close()
                End Try

                cbClientes.Enabled = False
                cbTipo.Enabled = False


            End If

        End With

    End Sub


#End Region

#Region "Boton Limpiar"
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarRegistro()
    End Sub

#End Region

#Region "Eliminar"
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'ELIMINAR

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim i As Integer
        Dim Msg As String

        i = CInt(lbId.Text)

        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "DEL"

        params(1) = New SqlParameter("@No_Servicio", SqlDbType.Int)
        params(1).Value = i

        Msg = "Se ha dado de baja al Servicio: " + CStr(i)

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Servicio"

        command.Parameters.AddRange(params)

        Try
            connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try



        With ServiciosDataViewGrid
            .DataSource = Nothing
            'refill the table adapter from the dataset table 
            ServicioTableAdapter.Fill(Me.DS_Tabla_Servicios.Servicio)
            'reset the datasource from the binding source
            .DataSource = Me.ServicioBindingSource
            'should redraw with the new data
            .Refresh()
            'clear out the datasource for the Grid view
        End With


        MessageBox.Show(Msg)
        LimpiarRegistro()
    End Sub

#End Region

#Region "Habilitar"
    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        'REHABILITAR

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim i As Integer
        Dim Msg As String

        i = CInt(lbId.Text)

        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "RHB"

        params(1) = New SqlParameter("@No_Servicio", SqlDbType.Int)
        params(1).Value = i

        Msg = "Se ha habilitado el Servicio: " + CStr(i)

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Servicio"

        command.Parameters.AddRange(params)

        Try
            connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

        With ServiciosDataViewGrid
            .DataSource = Nothing
            'refill the table adapter from the dataset table 
            ServicioTableAdapter.Fill(Me.DS_Tabla_Servicios.Servicio)
            'reset the datasource from the binding source
            .DataSource = Me.ServicioBindingSource
            'should redraw with the new data
            .Refresh()
            'clear out the datasource for the Grid view
        End With


        MessageBox.Show(Msg)
        LimpiarRegistro()
    End Sub

#End Region

#Region "Guardar/Registrar"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(6) As SqlParameter
        Dim params2(1) As SqlParameter
        Dim Temp As String
        Dim i As String
        Dim Msg As String

        i = lbId.Text

        If i = "" Then
            'USUARIO NUEVO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "INS"

            params(1) = New SqlParameter("@No_Servicio", SqlDbType.Int)
            params(1).Value = 0

            Msg = "Se ha dado de alta el Servicio "

        Else

            'EDITAR USUARIO YA CREADO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "ED"

            params(1) = New SqlParameter("@No_Servicio", SqlDbType.Int)
            params(1).Value = CInt(i)

            Msg = "Se ha modificado el Servicio con Id: " + i

        End If


        Temp = txtMedidor.Text
        params(2) = New SqlParameter("@No_Medidor", SqlDbType.Int)
        params(2).Value = CInt(Temp)

        Msg += ". Medidor:" + Temp + ". Tipo: "

        Temp = cbTipo.SelectedValue
        params(3) = New SqlParameter("@Tipo", SqlDbType.VarChar)
        params(3).Value = Temp

        Msg += Temp + ". Cliente: "

        Temp = cbClientes.SelectedValue
        params(4) = New SqlParameter("@Cliente", SqlDbType.Int)
        params(4).Value = CInt(Temp)

        params2(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
        params2(1).Value = CInt(Temp)

        Temp = txtUbicacion.Text
        params(5) = New SqlParameter("@Ubicacion", SqlDbType.VarChar)
        params(5).Value = Temp

        Temp = lbUsuarioMod.Text
        params(6) = New SqlParameter("@Usuario_Mod", SqlDbType.Int)
        params(6).Value = 0


        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Servicio"

        command.Parameters.AddRange(params)

        Try
            connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try


#Region "Cliente MSG"

        Dim ds As New DataSet
        Dim command2 As New SqlCommand()
        Dim adapter As SqlDataAdapter


        Try
            params2(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params2(0).Value = "SLT1"

            command2.Connection = connection
            command2.CommandType = CommandType.StoredProcedure
            command2.CommandText = "sp_Cliente"
            command2.Parameters.AddRange(params2)
            adapter = New SqlDataAdapter(command2)

            connection.Open()
            adapter.Fill(ds)

            For CONT = 0 To ds.Tables(0).Rows.Count - 1
                Msg += ds.Tables(0).Rows(0).Item(1)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            adapter.Dispose()
        End Try
#End Region

        With ServiciosDataViewGrid
            .DataSource = Nothing
            'refill the table adapter from the dataset table 
            ServicioTableAdapter.Fill(Me.DS_Tabla_Servicios.Servicio)
            'reset the datasource from the binding source
            .DataSource = Me.ServicioBindingSource
            'should redraw with the new data
            .Refresh()
            'clear out the datasource for the Grid view
        End With

        MessageBox.Show(Msg)
        LimpiarRegistro()
    End Sub
#End Region
End Class
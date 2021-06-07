Imports System.Data.SqlClient


Public Class FormAbcEmpl

    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

#Region "Cargar form"
    Private Sub FormAbcEmpl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ScdChncDataSet1.All_Employees' table. You can move, or remove it, as needed.
        Me.All_EmployeesTableAdapter.Fill(Me.ScdChncDataSet1.All_Employees)
        'TODO: This line of code loads data into the 'ScdChncDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.ScdChncDataSet.Empleado)

        lbId.Text = ""

#Region "CARGA COMBOBOX GENERO"
        Dim typeString As System.Type = System.Type.GetType("System.String")

        Dim dtG As DataTable = New DataTable()
        dtG.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeString), New DataColumn("Name", typeString)})
        dtG.Rows.Add("MA", "MA - MASCULINO")
        dtG.Rows.Add("FE", "FE - FEMENINO")


        'Assign DataTable as DataSource.
        cbGenero.DataSource = dtG
        cbGenero.DisplayMember = "Name"
        cbGenero.ValueMember = "Id"

        Dim Temp As String

        Temp = EmpleadoDataGridView.Rows(0).Cells("Genero").Value

        cbGenero.SelectedValue = Temp
        'If Temp = "MA" Then
        '    cbGenero.SelectedIndex = 0
        'Else
        '    cbGenero.SelectedIndex = 1
        'End If
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

        Temp = EmpleadoDataGridView.Rows(0).Cells("Estatus").Value

        cbEstado.SelectedValue = Temp
        'If Temp = "A" Then
        '    cbEstado.SelectedIndex = 0
        'ElseIf Temp = "S" Then
        '    cbEstado.SelectedIndex = 1
        'Else
        '    cbEstado.SelectedIndex = 2
        'End If
#End Region

        lbUsuarioMod.Text = ""
        lbFechaMod.Text = ""

        btnHabilitar.Enabled = False
        btnEliminar.Enabled = False

        FechaNac.Value = New Date(1986, 4, 26)

    End Sub
#End Region

#Region "DataGrid funcionalidad"
    Private Sub EmpleadoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadoDataGridView.CellClick

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter

        Dim i As Integer

        ' MessageBox.Show(e.RowIndex)
        With EmpleadoDataGridView
            i = .Rows(i).Cells("No_Usuario").Value

            If e.RowIndex >= 0 Then

                Dim Temp As String
                i = .CurrentRow.Index

#Region "Llenado textbox"
                Temp = .Rows(i).Cells("No_Usuario").Value.ToString
                lbId.Text = Temp

                Temp = .Rows(i).Cells("Nombre").Value.ToString
                txtNombre.Text = Temp

                Temp = .Rows(i).Cells("Apellido_P").Value.ToString
                txtApellidoP.Text = Temp

                Temp = .Rows(i).Cells("Apellido_M").Value.ToString
                txtApellidoM.Text = Temp

                Temp = .Rows(i).Cells("Contraseña").Value.ToString
                txtPass.Text = Temp

                Temp = .Rows(i).Cells("F_nac").Value.ToString
                FechaNac.Text = Temp

                Temp = .Rows(i).Cells("DHS").Value.ToString
                DHSTextBox.Text = Temp

                Temp = .Rows(i).Cells("DV").Value.ToString
                DVTextBox.Text = Temp

                Temp = .Rows(i).Cells("CURP").Value.ToString
                txtCURP.Text = Temp

                Temp = .Rows(i).Cells("HomoC").Value.ToString
                HomoCTextBox.Text = Temp

                Temp = .Rows(i).Cells("RFC").Value.ToString
                txtRFC.Text = Temp

                Temp = .Rows(i).Cells("Email").Value.ToString
                txtEmail.Text = Temp

                Temp = .Rows(i).Cells("F_Mod").Value.ToString
                lbFechaMod.Text = Temp

                Temp = .Rows(i).Cells("No_Usuario").Value.ToString
#End Region
                'Usuario mod
                Dim adapter As SqlDataAdapter
                Dim ds As New DataSet
                Dim CONT As Integer

                params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params(0).Value = "SLT1"

                params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
                params(1).Value = CInt(Temp)

                Dim command As New SqlCommand()
                connection.Open()
                command.Connection = connection
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_Empleado"
                command.Parameters.AddRange(params)
                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)

                For CONT = 0 To ds.Tables(0).Rows.Count - 1
                    lbUsuarioMod.Text = ds.Tables(0).Rows(0).Item(7)
                Next

                connection.Close()

                'GENERO
                Temp = .Rows(i).Cells("Genero").Value.ToString
                cbGenero.SelectedValue = Temp

                'ESTATUS
                Temp = EmpleadoDataGridView.Rows(i).Cells("Estatus").Value.ToString
                cbEstado.SelectedValue = Temp

                btnHabilitar.Enabled = True
                btnEliminar.Enabled = True


            End If

        End With

    End Sub
#End Region

#Region "Eliminar"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'ELIMINAR

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim i As Integer
        Dim Msg As String

        i = CInt(lbId.Text)

        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "DEL"

        params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
        params(1).Value = i

        Msg = "Se ha dado de baja al Empleado: " + CStr(i)

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Empleado"

        command.Parameters.AddRange(params)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

        'clear out the datasource for the Grid view
        Me.EmpleadoDataGridView.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.EmpleadoTableAdapter.Fill(Me.ScdChncDataSet.Empleado)
        'reset the datasource from the binding source
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        'should redraw with the new data
        Me.EmpleadoDataGridView.Refresh()


        MessageBox.Show(Msg)
        LimpiarRegistro()

    End Sub
#End Region

#Region "Boton Limpiar"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarRegistro()
    End Sub

#End Region

#Region "Registrar/Editar"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(12) As SqlParameter
        Dim Temp As String
        Dim i As String
        Dim Msg As String

        i = lbId.Text

        If i = "" Then
            'USUARIO NUEVO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "INS"

            params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
            params(1).Value = 0

            Msg = "Se ha dado de alta al Empleado: "

        Else

            'EDITAR USUARIO YA CREADO
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "ED"

            params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
            params(1).Value = CInt(i)

            Msg = "Se ha modificado al Empleado con Id: " + i + " "

        End If

        Temp = txtNombre.Text
        params(2) = New SqlParameter("@Nombre", SqlDbType.VarChar)
        params(2).Value = Temp

        Msg += Temp + " "

        Temp = txtApellidoP.Text
        params(3) = New SqlParameter("@Apellido_P", SqlDbType.VarChar)
        params(3).Value = Temp

        Msg += Temp + " "

        Temp = txtApellidoM.Text
        params(4) = New SqlParameter("@Apellido_M", SqlDbType.VarChar)
        params(4).Value = Temp

        Msg += Temp

        Temp = cbGenero.SelectedValue
        params(5) = New SqlParameter("@Genero", SqlDbType.VarChar)
        params(5).Value = Temp

        Temp = txtPass.Text
        params(6) = New SqlParameter("@Contraseña", SqlDbType.VarChar)
        params(6).Value = Temp

        Temp = txtEmail.Text
        params(7) = New SqlParameter("@Email", SqlDbType.VarChar)
        params(7).Value = Temp

        params(8) = New SqlParameter("@F_Nac", SqlDbType.Date)
        params(8).Value = FechaNac.Value

        Temp = lbUsuarioMod.Text
        params(9) = New SqlParameter("@Usuario_Mod", SqlDbType.Int)
        params(9).Value = 0

        Temp = DHSTextBox.Text
        params(10) = New SqlParameter("@DHS", SqlDbType.Int)
        params(10).Value = CInt(Temp)

        Temp = DVTextBox.Text
        params(11) = New SqlParameter("@DV", SqlDbType.Int)
        params(11).Value = CInt(Temp)

        Temp = HomoCTextBox.Text
        params(12) = New SqlParameter("@Homo", SqlDbType.Char)
        params(12).Value = Temp

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Empleado"

        command.Parameters.AddRange(params)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

        'clear out the datasource for the Grid view
        Me.EmpleadoDataGridView.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.EmpleadoTableAdapter.Fill(Me.ScdChncDataSet.Empleado)
        'reset the datasource from the binding source
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        'should redraw with the new data
        Me.EmpleadoDataGridView.Refresh()

        MessageBox.Show(Msg)
        LimpiarRegistro()

    End Sub
#End Region

#Region "Metodo Limpiar espacios"
    Private Sub LimpiarRegistro()
        lbId.Text = ""
        txtNombre.Clear()
        txtApellidoP.Clear()
        txtApellidoM.Clear()
        txtPass.Clear()
        DHSTextBox.Clear()
        DVTextBox.Clear()
        txtCURP.Clear()
        HomoCTextBox.Clear()
        txtRFC.Clear()
        txtEmail.Clear()
        cbEstado.SelectedIndex = 0
        lbUsuarioMod.Text = ""
        FechaNac.Value = New Date(1986, 4, 26)

        btnHabilitar.Enabled = False
        btnEliminar.Enabled = False

    End Sub

#End Region

#Region "Habilitar"
    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim i As Integer
        Dim Msg As String

        i = CInt(lbId.Text)

        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "RHB"

        params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
        params(1).Value = i

        Msg = "Se ha habilitado al Empleado: " + CStr(i)

        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_Empleado"

        command.Parameters.AddRange(params)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

        'clear out the datasource for the Grid view
        Me.EmpleadoDataGridView.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.EmpleadoTableAdapter.Fill(Me.ScdChncDataSet.Empleado)
        'reset the datasource from the binding source
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        'should redraw with the new data
        Me.EmpleadoDataGridView.Refresh()


        MessageBox.Show(Msg)
        LimpiarRegistro()
    End Sub
#End Region

End Class
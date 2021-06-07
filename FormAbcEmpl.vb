Imports System.Data.SqlClient


Public Class FormAbcEmpl
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles btnCerrarFormulario.Click
        Me.Close()
    End Sub

#Region "Cargar form"
    Private Sub FormAbcEmpl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScdChncDataSet1.All_Employees' table. You can move, or remove it, as needed.
        Me.All_EmployeesTableAdapter.Fill(Me.ScdChncDataSet1.All_Employees)
        'TODO: This line of code loads data into the 'ScdChncDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.ScdChncDataSet.Empleado)


        Dim Temp As String

        Temp = EmpleadoDataGridView.Rows(0).Cells("Genero").Value

        If Temp = "MA" Then
            cbGenero.SelectedIndex = 0
        Else
            cbGenero.SelectedIndex = 1
        End If

        Temp = EmpleadoDataGridView.Rows(0).Cells("Estatus").Value

        If Temp = "A" Then
            cbEstado.SelectedIndex = 0
        ElseIf Temp = "S" Then
            cbEstado.SelectedIndex = 1
        Else
            cbEstado.SelectedIndex = 2
        End If

    End Sub
#End Region

#Region "DataGrid funcionalidad"
    Private Sub EmpleadoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadoDataGridView.CellClick

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Dim i As Integer

        MessageBox.Show(e.RowIndex)
        With EmpleadoDataGridView
            i = .Rows(i).Cells("No_Usuario").Value

            If e.RowIndex >= 0 Then

                Dim Temp As String
                i = .CurrentRow.Index

                Temp = .Rows(i).Cells("No_Usuario").Value.ToString
                Label17.Text = Temp

                Temp = .Rows(i).Cells("Nombre").Value.ToString
                txtNombre.Text = Temp

                Temp = .Rows(i).Cells("Apellido_P").Value.ToString
                txtApellidoP.Text = Temp

                Temp = .Rows(i).Cells("Apellido_M").Value.ToString
                TextBox9.Text = Temp

                Temp = .Rows(i).Cells("Contraseña").Value.ToString
                TextBox1.Text = Temp

                Temp = .Rows(i).Cells("F_nac").Value.ToString
                FechaNac.Text = Temp

                Temp = .Rows(i).Cells("DHS").Value.ToString
                DHSTextBox.Text = Temp

                Temp = .Rows(i).Cells("DV").Value.ToString
                DVTextBox.Text = Temp

                Temp = .Rows(i).Cells("CURP").Value.ToString
                TextBox8.Text = Temp

                Temp = .Rows(i).Cells("HomoC").Value.ToString
                HomoCTextBox.Text = Temp

                Temp = .Rows(i).Cells("RFC").Value.ToString
                TextBox7.Text = Temp

                Temp = .Rows(i).Cells("Email").Value.ToString
                TextBox3.Text = Temp

                Temp = .Rows(i).Cells("F_Mod").Value.ToString
                Label19.Text = Temp

                Temp = .Rows(i).Cells("No_Usuario").Value.ToString

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
                    lbUsuarioMod.Text = ds.Tables(0).Rows(i).Item(7)
                Next

                'lbUsuarioMod.Text = dt.Columns(7).ColumnName

                'command.ExecuteNonQuery()

                connection.Close()

                'GENERO
                Temp = .Rows(i).Cells("Genero").Value.ToString

                If Temp = "MA" Then
                    cbGenero.SelectedIndex = 0
                Else
                    cbGenero.SelectedIndex = 1
                End If

                Temp = EmpleadoDataGridView.Rows(i).Cells("Estatus").Value.ToString

                'ESTATUS
                If Temp = "A" Then
                    cbEstado.SelectedIndex = 0
                ElseIf Temp = "S" Then
                    cbEstado.SelectedIndex = 1
                Else
                    cbEstado.SelectedIndex = 2
                End If

            End If

        End With

    End Sub
#End Region

#Region "Eliminar"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ELIMINAR

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim i As Integer

        i = CInt(Label17.Text)

        params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
        params(0).Value = "DEL"

        params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
        params(1).Value = i

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


        MessageBox.Show("Se ha dado de baja un registro")

    End Sub
#End Region

    Private Sub EmpleadoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadoDataGridView.CellContentClick

    End Sub

#Region "Nuevo registro"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label17.Text = ""
        txtNombre.Clear()
        txtApellidoP.Clear()
        TextBox9.Clear()
        TextBox1.Clear()
        DHSTextBox.Clear()
        DVTextBox.Clear()
        TextBox8.Clear()
        HomoCTextBox.Clear()
        TextBox7.Clear()
        TextBox3.Clear()
        cbEstado.SelectedIndex = 0
        lbUsuarioMod.Text = ""

    End Sub
#End Region


End Class
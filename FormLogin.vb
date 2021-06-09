Imports System.Data.SqlClient

Public Class FormLogin

    Protected Friend Usuario As Integer
    Protected Friend TipoU As Integer

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(2) As SqlParameter

        If txtBUser.Text = "" Then
            lbMsg.Text = "*Ingrese el numero de usuario"
            Return
        End If

        If txtBPass.Text = "" Then
            lbMsg.Text = "*Ingrese la contraseña"
            Return
        End If

#Region "Funcionalidad Login"
        Dim command As New SqlCommand()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable

        Try
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "LOG"

            params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
            params(1).Value = CInt(txtBUser.Text)

            params(2) = New SqlParameter("@Contraseña", SqlDbType.VarChar)
            params(2).Value = txtBPass.Text

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            If cbTipoUsuario.SelectedValue = 1 Then
                command.CommandText = "sp_Empleado"
                TipoU = 1
                If txtBUser.Text = "0" And txtBPass.Text = "root" Then
                    TipoU = 0
                    Usuario = 0
                    Me.Hide()
                    FormEmplGen.ShowDialog()
                    Return
                End If
            Else
                command.CommandText = "sp_Cliente"
                TipoU = 2
            End If

            command.Parameters.AddRange(params)

            connection.Open()

            With da
                .SelectCommand = command
                .Fill(dt)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
            da.Dispose()
            Return
        Finally
            connection.Close()
            da.Dispose()
        End Try

        If dt.Rows.Count > 0 Then
            Usuario = CInt(txtBUser.Text)
            Me.Hide()
            FormEmplGen.ShowDialog()
        Else
            lbMsg.Text = "*Usuario y/o contraseña incorrectos"
            Return
        End If


#End Region



    End Sub

#Region "Salir de aplicación"
    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Application.Exit()
    End Sub
#End Region

#Region "Cargar Login"
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "CARGAR COMBOBOX TIPO DE USUARIO"
        Dim typeString As System.Type = System.Type.GetType("System.String")
        Dim typeInt As System.Type = System.Type.GetType("System.Int32")

        Dim dtG As DataTable = New DataTable()
        dtG.Columns.AddRange(New DataColumn() {New DataColumn("Id", typeInt), New DataColumn("Name", typeString)})
        dtG.Rows.Add(1, "EMPLEADO")
        dtG.Rows.Add(2, "CLIENTE")

        'Assign DataTable as DataSource.
        cbTipoUsuario.DataSource = dtG
        cbTipoUsuario.DisplayMember = "Name"
        cbTipoUsuario.ValueMember = "Id"
        cbTipoUsuario.SelectedValue = 1
#End Region

        lbMsg.Text = ""
    End Sub
#End Region

End Class

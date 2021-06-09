Imports System.Data.SqlClient

Public Class FormLogin

    Protected Friend Usuario As Integer
    Protected Friend TipoU As Integer
    Private Intento As Integer

#Region "Funcionalidad Login"
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        Dim connection As New SqlConnection("Server= DESKTOP-51SJOGN; Database = ScdChnc; Integrated Security = true")
        Dim params(1) As SqlParameter
        Dim params2(1) As SqlParameter
        Dim command As New SqlCommand()
        Dim command2 As New SqlCommand()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable
        Dim ds As DataSet = New DataSet
        Dim Temp As String

        Temp = "Numero_"

#Region "Verificacion de identidad"
        If txtBUser.Text = "" Then
            lbMsg.Text = "*Ingrese el numero de usuario"
            Return
        End If

        If txtBPass.Text = "" Then
            lbMsg.Text = "*Ingrese la contraseña"
            Return
        End If


        Try
            params(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
            params(0).Value = "SLT1"

            params(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
            params(1).Value = CInt(txtBUser.Text)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            If cbTipoUsuario.SelectedValue = 1 Then
                command.CommandText = "sp_Empleado"
                TipoU = 1
                Temp += "Empleado"
                If txtBUser.Text = "0" And txtBPass.Text = "root" Then
                    If checkBRemeber.Checked = True Then
                        My.Settings.Check = True
                        My.Settings.Numero_Usuario = 0
                        My.Settings.Tipo = 0
                        My.Settings.Password = "root"
                    End If
                    TipoU = 0
                    Usuario = 0
                    Me.Hide()
                    FormEmplGen.ShowDialog()
                    Return
                End If
            Else
                command.CommandText = "sp_Cliente"
                Temp += "Cliente"
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
#End Region


        If dt.Rows.Count > 0 AndAlso dt.Rows(0).Item("Clave") = txtBPass.Text Then

            If dt.Rows(0).Item("Estado") = "S" Then
                lbMsg.Text = "*Usuario suspendido por demasiados intentos fallidos. Contacte a soporte"
                Return
            End If

            Usuario = CInt(txtBUser.Text)
            If checkBRemeber.Checked = True Then
                My.Settings.Check = True
                My.Settings.Numero_Usuario = Usuario
                My.Settings.Tipo = TipoU
                My.Settings.Password = txtBPass.Text
            End If

            Me.Hide()
            FormEmplGen.ShowDialog()
        Else

            If txtBUser.Text = "0" And cbTipoUsuario.SelectedValue = 1 Then
                lbMsg.Text = "*No es posible suspender al administrador, ten más cuidado"
                Return
            End If

#Region "Advertencias"

            If dt.Rows(0).Item("Estado") = "S" Then
                lbMsg.Text = "*Usuario suspendido por demasiados intentos fallidos. Contacte a soporte"
                Return
            End If

            If My.Settings.Strike = 0 Then
                lbMsg.Text = "*Usuario y/o contraseña incorrectos"
                My.Settings.Strike += 1
            End If

            If Intento = CInt(txtBUser.Text) And My.Settings.Strike < 4 Then
                lbMsg.Text = "*Usuario y/o contraseña incorrectos"
                My.Settings.Strike += 1
            End If

            If My.Settings.Strike = 2 Then
                lbMsg.Text = "*Usuario y/o contraseña incorrectos. Equivocarse una vez más resultará en la suspensión del usuario"
            End If

#Region "Suspensión"
            If My.Settings.Strike = 3 Then
                params2(0) = New SqlParameter("@Oper", SqlDbType.VarChar)
                params2(0).Value = "SUS"

                params2(1) = New SqlParameter("@No_Usuario", SqlDbType.Int)
                params2(1).Value = CInt(txtBUser.Text)

                command2.Connection = connection
                command2.CommandType = CommandType.StoredProcedure

                If cbTipoUsuario.SelectedValue = 1 Then
                    command2.CommandText = "sp_Empleado"
                Else
                    command2.CommandText = "sp_Cliente"
                End If

                Try
                    command2.Parameters.AddRange(params2)

                    connection.Open()

                    command2.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)
                    connection.Close()
                    Return

                End Try

                lbMsg.Text = "*Usuario suspendido por demasiados intentos fallidos. Contacte a soporte"
            End If

            connection.Close()
#End Region

            Intento = CInt(txtBUser.Text)

            Return
#End Region

        End If

    End Sub
#End Region

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
        My.Settings.Strike = 0

        If My.Settings.Check = True Then
            Usuario = My.Settings.Numero_Usuario
            txtBUser.Text = Usuario

            TipoU = My.Settings.Tipo
            If TipoU = 0 Then
                cbTipoUsuario.SelectedValue = 1
            Else
                cbTipoUsuario.SelectedValue = TipoU
            End If

            txtBPass.Text = My.Settings.Password

            checkBRemeber.Checked = True

        End If

    End Sub
#End Region

End Class

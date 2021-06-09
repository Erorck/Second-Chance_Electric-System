Imports System.Runtime.InteropServices

Public Class FormEmplGen

#Region "Funcionalidad formulario MAIN"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                    >= (Me.ClientSize.Width - cGrip)) _
                    AndAlso (pos.Y _
                    >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    'ARRASTRAR EL FORMULARIO'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Width
        sh = Me.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub
#End Region

    'Metodo abrir formulario
    Private Sub AbrirFormEnPanel(Of MiForm As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of MiForm)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New MiForm()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()

        End If

    End Sub

#Region "Abrir Formularios"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        AbrirFormEnPanel(Of FormCambiarContra)()
        btnCuenta.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        AbrirFormEnPanel(Of FormRepConsH)()
        btnReportes.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormEnPanel(Of FormAbcCliente)()
        btnClientes.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnConsumos_Click(sender As Object, e As EventArgs) Handles btnConsumos.Click
        AbrirFormEnPanel(Of FormAbcCons)()
        btnConsumos.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTarifas.Click
        AbrirFormEnPanel(Of FormAbcTar)()
        btnTarifas.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        AbrirFormEnPanel(Of FormAbcServ)()
        btnServicios.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnRepTar_Click(sender As Object, e As EventArgs) Handles btnRepTar.Click
        AbrirFormEnPanel(Of FormRepTar)()
        btnRepTar.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnRepCons_Click(sender As Object, e As EventArgs) Handles btnRepCons.Click
        AbrirFormEnPanel(Of FormRepCons)()
        btnRepCons.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnRepGeneral_Click(sender As Object, e As EventArgs) Handles btnRepGeneral.Click
        AbrirFormEnPanel(Of FormRepGeneral)()
        btnRepGeneral.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnGenRcb_Click(sender As Object, e As EventArgs) Handles btnGenRcb.Click
        AbrirFormEnPanel(Of FormAbcRcb)()
        btnGenRcb.BackColor = Color.FromArgb(26, 50, 54)
    End Sub

    Private Sub btnConsulRbc_Click(sender As Object, e As EventArgs) Handles btnConsulRbc.Click
        AbrirFormEnPanel(Of FormConsulRcb)()
        btnConsulRbc.BackColor = Color.FromArgb(26, 50, 54)
    End Sub


    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        AbrirFormEnPanel(Of FormAbcEmpl)()
        btnEmpleados.BackColor = Color.FromArgb(26, 50, 54)
    End Sub
#End Region

#Region "Metodo Preparacion"
    Private Sub SetRestrictions(Tipo As Integer)

        If Tipo = 0 Then
            btnEmpleados.Visible = True
            btnClientes.Visible = True
            btnServicios.Visible = True
            btnConsumos.Visible = True
            btnTarifas.Visible = True
            btnGenRcb.Visible = True
            btnCuenta.Visible = True
            btnReportes.Visible = True
            btnRepCons.Visible = True
            btnRepTar.Visible = True
            btnRepGeneral.Visible = True
            btnConsulRbc.Visible = True
        End If

        If Tipo = 1 Then
            btnEmpleados.Visible = False
            btnClientes.Visible = True
            btnServicios.Visible = True
            btnConsumos.Visible = True
            btnTarifas.Visible = True
            btnGenRcb.Visible = True
            btnCuenta.Visible = True
            btnReportes.Visible = True
            btnRepCons.Visible = True
            btnRepTar.Visible = True
            btnRepGeneral.Visible = True
            btnConsulRbc.Visible = True
        End If

        If Tipo = 2 Then
            btnClientes.Visible = False
            btnServicios.Visible = False
            btnConsumos.Visible = False
            btnTarifas.Visible = False
            btnGenRcb.Visible = False
            btnCuenta.Visible = True
            btnReportes.Visible = True
            btnRepCons.Visible = False
            btnRepTar.Visible = False
            btnRepGeneral.Visible = False
            btnConsulRbc.Visible = True
        End If

    End Sub
#End Region

#Region "Cargar form"
    Private Sub FormEmplGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRestrictions(FormLogin.TipoU)
        FormCambiarContra.Close()
        FormConsulRcb.Close()
    End Sub
#End Region

#Region "Cerrar Formularios"
    'Metodo al cerrar un formulario
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("FormCambiarContra") Is Nothing) Then
            btnCuenta.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormRepConsH") Is Nothing) Then
            btnReportes.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormAbcCliente") Is Nothing) Then
            btnClientes.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormAbcEmpl") Is Nothing) Then
            btnEmpleados.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormAbcCons") Is Nothing) Then
            btnConsumos.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormAbcTar") Is Nothing) Then
            btnTarifas.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormAbcServ") Is Nothing) Then
            btnServicios.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormRepTar") Is Nothing) Then
            btnRepTar.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormRepCons") Is Nothing) Then
            btnRepCons.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormRepGeneral") Is Nothing) Then
            btnRepGeneral.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormAbcRcb") Is Nothing) Then
            btnGenRcb.BackColor = Color.DarkCyan
        End If
        If (Application.OpenForms("FormConsulRcb") Is Nothing) Then
            btnConsulRbc.BackColor = Color.DarkCyan
        End If
    End Sub
#End Region



End Class
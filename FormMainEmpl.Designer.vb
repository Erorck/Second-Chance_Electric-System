<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmplGen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnConsulRbc = New System.Windows.Forms.Button()
        Me.btnGenRcb = New System.Windows.Forms.Button()
        Me.btnRepGeneral = New System.Windows.Forms.Button()
        Me.btnRepCons = New System.Windows.Forms.Button()
        Me.btnRepTar = New System.Windows.Forms.Button()
        Me.btnServicios = New System.Windows.Forms.Button()
        Me.btnTarifas = New System.Windows.Forms.Button()
        Me.btnConsumos = New System.Windows.Forms.Button()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1100, 700)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelFormularios.Controls.Add(Me.Logo)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(850, 660)
        Me.PanelFormularios.TabIndex = 2
        '
        'Logo
        '
        Me.Logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Logo.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Logo
        Me.Logo.Location = New System.Drawing.Point(0, 0)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(850, 660)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelMenu.Controls.Add(Me.btnConsulRbc)
        Me.PanelMenu.Controls.Add(Me.btnGenRcb)
        Me.PanelMenu.Controls.Add(Me.btnRepGeneral)
        Me.PanelMenu.Controls.Add(Me.btnRepCons)
        Me.PanelMenu.Controls.Add(Me.btnRepTar)
        Me.PanelMenu.Controls.Add(Me.btnServicios)
        Me.PanelMenu.Controls.Add(Me.btnTarifas)
        Me.PanelMenu.Controls.Add(Me.btnConsumos)
        Me.PanelMenu.Controls.Add(Me.btnCuenta)
        Me.PanelMenu.Controls.Add(Me.btnReportes)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.btnEmpleados)
        Me.PanelMenu.Controls.Add(Me.PanelHeader)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 660)
        Me.PanelMenu.TabIndex = 1
        '
        'btnConsulRbc
        '
        Me.btnConsulRbc.BackColor = System.Drawing.Color.DarkCyan
        Me.btnConsulRbc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsulRbc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsulRbc.FlatAppearance.BorderSize = 0
        Me.btnConsulRbc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnConsulRbc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnConsulRbc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsulRbc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulRbc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConsulRbc.Location = New System.Drawing.Point(0, 580)
        Me.btnConsulRbc.Name = "btnConsulRbc"
        Me.btnConsulRbc.Size = New System.Drawing.Size(250, 40)
        Me.btnConsulRbc.TabIndex = 11
        Me.btnConsulRbc.Text = "Consultar Recibo"
        Me.btnConsulRbc.UseVisualStyleBackColor = False
        '
        'btnGenRcb
        '
        Me.btnGenRcb.BackColor = System.Drawing.Color.DarkCyan
        Me.btnGenRcb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenRcb.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGenRcb.FlatAppearance.BorderSize = 0
        Me.btnGenRcb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnGenRcb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnGenRcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenRcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenRcb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGenRcb.Location = New System.Drawing.Point(0, 540)
        Me.btnGenRcb.Name = "btnGenRcb"
        Me.btnGenRcb.Size = New System.Drawing.Size(250, 40)
        Me.btnGenRcb.TabIndex = 10
        Me.btnGenRcb.Text = "Generar Recibos"
        Me.btnGenRcb.UseVisualStyleBackColor = False
        '
        'btnRepGeneral
        '
        Me.btnRepGeneral.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRepGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepGeneral.FlatAppearance.BorderSize = 0
        Me.btnRepGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRepGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRepGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepGeneral.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRepGeneral.Location = New System.Drawing.Point(0, 500)
        Me.btnRepGeneral.Name = "btnRepGeneral"
        Me.btnRepGeneral.Size = New System.Drawing.Size(250, 40)
        Me.btnRepGeneral.TabIndex = 9
        Me.btnRepGeneral.Text = "Reporte General"
        Me.btnRepGeneral.UseVisualStyleBackColor = False
        '
        'btnRepCons
        '
        Me.btnRepCons.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRepCons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepCons.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepCons.FlatAppearance.BorderSize = 0
        Me.btnRepCons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRepCons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRepCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepCons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepCons.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRepCons.Location = New System.Drawing.Point(0, 460)
        Me.btnRepCons.Name = "btnRepCons"
        Me.btnRepCons.Size = New System.Drawing.Size(250, 40)
        Me.btnRepCons.TabIndex = 8
        Me.btnRepCons.Text = "Reporte Consumos"
        Me.btnRepCons.UseVisualStyleBackColor = False
        '
        'btnRepTar
        '
        Me.btnRepTar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRepTar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepTar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepTar.FlatAppearance.BorderSize = 0
        Me.btnRepTar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRepTar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRepTar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepTar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepTar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRepTar.Location = New System.Drawing.Point(0, 420)
        Me.btnRepTar.Name = "btnRepTar"
        Me.btnRepTar.Size = New System.Drawing.Size(250, 40)
        Me.btnRepTar.TabIndex = 7
        Me.btnRepTar.Text = "Reporte Tarifas"
        Me.btnRepTar.UseVisualStyleBackColor = False
        '
        'btnServicios
        '
        Me.btnServicios.BackColor = System.Drawing.Color.DarkCyan
        Me.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnServicios.FlatAppearance.BorderSize = 0
        Me.btnServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServicios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnServicios.Location = New System.Drawing.Point(0, 380)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Size = New System.Drawing.Size(250, 40)
        Me.btnServicios.TabIndex = 6
        Me.btnServicios.Text = "Servicios"
        Me.btnServicios.UseVisualStyleBackColor = False
        '
        'btnTarifas
        '
        Me.btnTarifas.BackColor = System.Drawing.Color.DarkCyan
        Me.btnTarifas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTarifas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTarifas.FlatAppearance.BorderSize = 0
        Me.btnTarifas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnTarifas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarifas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarifas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTarifas.Location = New System.Drawing.Point(0, 340)
        Me.btnTarifas.Name = "btnTarifas"
        Me.btnTarifas.Size = New System.Drawing.Size(250, 40)
        Me.btnTarifas.TabIndex = 5
        Me.btnTarifas.Text = "Tarifas"
        Me.btnTarifas.UseVisualStyleBackColor = False
        '
        'btnConsumos
        '
        Me.btnConsumos.BackColor = System.Drawing.Color.DarkCyan
        Me.btnConsumos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsumos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsumos.FlatAppearance.BorderSize = 0
        Me.btnConsumos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnConsumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnConsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsumos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsumos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConsumos.Location = New System.Drawing.Point(0, 300)
        Me.btnConsumos.Name = "btnConsumos"
        Me.btnConsumos.Size = New System.Drawing.Size(250, 40)
        Me.btnConsumos.TabIndex = 4
        Me.btnConsumos.Text = "Consumos"
        Me.btnConsumos.UseVisualStyleBackColor = False
        '
        'btnCuenta
        '
        Me.btnCuenta.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCuenta.FlatAppearance.BorderSize = 0
        Me.btnCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCuenta.Location = New System.Drawing.Point(0, 260)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(250, 40)
        Me.btnCuenta.TabIndex = 3
        Me.btnCuenta.Text = "Cuenta"
        Me.btnCuenta.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.DarkCyan
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReportes.Location = New System.Drawing.Point(0, 220)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(250, 40)
        Me.btnReportes.TabIndex = 2
        Me.btnReportes.Text = "Consumo Histórico"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.DarkCyan
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClientes.Location = New System.Drawing.Point(0, 180)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(250, 40)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 140)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(250, 40)
        Me.btnEmpleados.TabIndex = 0
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = False
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PictureBox1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(250, 140)
        Me.PanelHeader.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Header
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1100, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Normal
        Me.btnRestaurar.Location = New System.Drawing.Point(1038, 12)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Minimize
        Me.btnMinimizar.Location = New System.Drawing.Point(1000, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.maximize3
        Me.btnMaximizar.Location = New System.Drawing.Point(1038, 12)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Close
        Me.btnCerrar.Location = New System.Drawing.Point(1072, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'FormEmplGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(370, 420)
        Me.Name = "FormEmplGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¡Bienvenido!"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnCuenta As Button
    Friend WithEvents Logo As PictureBox
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnConsumos As Button
    Friend WithEvents btnTarifas As Button
    Friend WithEvents btnServicios As Button
    Friend WithEvents btnRepCons As Button
    Friend WithEvents btnRepTar As Button
    Friend WithEvents btnRepGeneral As Button
    Friend WithEvents btnGenRcb As Button
    Friend WithEvents btnConsulRbc As Button
End Class

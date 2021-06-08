<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbcTar
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lbId = New System.Windows.Forms.Label()
        Me.lbFechaMod = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbUsuarioMod = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSubirArchivo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TarifaDataViewGrid = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCant_E = New System.Windows.Forms.TextBox()
        Me.txtCant_I = New System.Windows.Forms.TextBox()
        Me.txtCant_B = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.DS_Tabla_Tarifa = New PIA_MAD___ScdChnc.DS_Tabla_Tarifa()
        Me.TarifaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarifaTableAdapter = New PIA_MAD___ScdChnc.DS_Tabla_TarifaTableAdapters.TarifaTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.btnCerrarFormulario = New System.Windows.Forms.PictureBox()
        Me.No_Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tar_B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tar_I = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tar_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario_Mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_Mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TarifaDataViewGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tabla_Tarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Burbuja1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 560)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(550, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 560)
        Me.Panel1.TabIndex = 22
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(86, 498)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(77, 33)
        Me.btnLimpiar.TabIndex = 136
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lbId
        '
        Me.lbId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbId.AutoSize = True
        Me.lbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbId.Location = New System.Drawing.Point(270, 346)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(71, 20)
        Me.lbId.TabIndex = 134
        Me.lbId.Text = "Numero"
        Me.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbFechaMod
        '
        Me.lbFechaMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFechaMod.AutoSize = True
        Me.lbFechaMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaMod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbFechaMod.Location = New System.Drawing.Point(305, 472)
        Me.lbFechaMod.Name = "lbFechaMod"
        Me.lbFechaMod.Size = New System.Drawing.Size(46, 15)
        Me.lbFechaMod.TabIndex = 133
        Me.lbFechaMod.Text = "FECHA"
        Me.lbFechaMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(305, 457)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 15)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "Fecha modificación:"
        '
        'lbUsuarioMod
        '
        Me.lbUsuarioMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbUsuarioMod.AutoSize = True
        Me.lbUsuarioMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarioMod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbUsuarioMod.Location = New System.Drawing.Point(108, 472)
        Me.lbUsuarioMod.Name = "lbUsuarioMod"
        Me.lbUsuarioMod.Size = New System.Drawing.Size(97, 15)
        Me.lbUsuarioMod.TabIndex = 131
        Me.lbUsuarioMod.Text = "USUARIO_MOD"
        Me.lbUsuarioMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(106, 457)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 15)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Ultimo usuario en modificar: "
        '
        'txtAño
        '
        Me.txtAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(239, 384)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(53, 26)
        Me.txtAño.TabIndex = 129
        Me.txtAño.Text = "YYYY"
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(334, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Excedente"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(226, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "Intermedio"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(139, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Basico"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(194, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Tarifa #"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(20, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 28)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "Gestión Tarifas"
        '
        'btnSubirArchivo
        '
        Me.btnSubirArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubirArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnSubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubirArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubirArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubirArchivo.Location = New System.Drawing.Point(169, 499)
        Me.btnSubirArchivo.Name = "btnSubirArchivo"
        Me.btnSubirArchivo.Size = New System.Drawing.Size(110, 32)
        Me.btnSubirArchivo.TabIndex = 122
        Me.btnSubirArchivo.Text = "Subir Archivo"
        Me.btnSubirArchivo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(285, 498)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(175, 33)
        Me.btnGuardar.TabIndex = 121
        Me.btnGuardar.Text = "Guardar/Registrar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TarifaDataViewGrid
        '
        Me.TarifaDataViewGrid.AllowUserToAddRows = False
        Me.TarifaDataViewGrid.AllowUserToDeleteRows = False
        Me.TarifaDataViewGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TarifaDataViewGrid.AutoGenerateColumns = False
        Me.TarifaDataViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TarifaDataViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.NullValue = "NULL"
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TarifaDataViewGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.TarifaDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TarifaDataViewGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No_Tarifa, Me.Mes, Me.Año, Me.Tar_B, Me.Tar_I, Me.Tar_E, Me.Tipo, Me.Usuario_Mod, Me.F_Mod})
        Me.TarifaDataViewGrid.DataSource = Me.TarifaBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.NullValue = "NULL"
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TarifaDataViewGrid.DefaultCellStyle = DataGridViewCellStyle12
        Me.TarifaDataViewGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TarifaDataViewGrid.Location = New System.Drawing.Point(25, 76)
        Me.TarifaDataViewGrid.Name = "TarifaDataViewGrid"
        Me.TarifaDataViewGrid.ReadOnly = True
        Me.TarifaDataViewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TarifaDataViewGrid.Size = New System.Drawing.Size(502, 252)
        Me.TarifaDataViewGrid.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(294, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "$ p/Kw"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(409, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "$ p/Kw"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(178, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "$ p/Kw"
        '
        'txtCant_E
        '
        Me.txtCant_E.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCant_E.Location = New System.Drawing.Point(339, 430)
        Me.txtCant_E.Name = "txtCant_E"
        Me.txtCant_E.Size = New System.Drawing.Size(64, 20)
        Me.txtCant_E.TabIndex = 116
        Me.txtCant_E.Text = "Excendente"
        Me.txtCant_E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCant_I
        '
        Me.txtCant_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCant_I.Location = New System.Drawing.Point(223, 430)
        Me.txtCant_I.Name = "txtCant_I"
        Me.txtCant_I.Size = New System.Drawing.Size(64, 20)
        Me.txtCant_I.TabIndex = 115
        Me.txtCant_I.Text = "Intermedio"
        Me.txtCant_I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCant_B
        '
        Me.txtCant_B.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCant_B.Location = New System.Drawing.Point(111, 430)
        Me.txtCant_B.Name = "txtCant_B"
        Me.txtCant_B.Size = New System.Drawing.Size(64, 20)
        Me.txtCant_B.TabIndex = 114
        Me.txtCant_B.Text = "Básico"
        Me.txtCant_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(99, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Periodo:"
        '
        'cbMes
        '
        Me.cbMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbMes.Location = New System.Drawing.Point(168, 384)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(65, 26)
        Me.cbMes.TabIndex = 112
        Me.cbMes.Text = "MM"
        '
        'DS_Tabla_Tarifa
        '
        Me.DS_Tabla_Tarifa.DataSetName = "DS_Tabla_Tarifa"
        Me.DS_Tabla_Tarifa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TarifaBindingSource
        '
        Me.TarifaBindingSource.DataMember = "Tarifa"
        Me.TarifaBindingSource.DataSource = Me.DS_Tabla_Tarifa
        '
        'TarifaTableAdapter
        '
        Me.TarifaTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(298, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbTipo.Location = New System.Drawing.Point(341, 381)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(119, 26)
        Me.cbTipo.TabIndex = 138
        Me.cbTipo.Text = "TIPO"
        '
        'btnCerrarFormulario
        '
        Me.btnCerrarFormulario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarFormulario.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Close
        Me.btnCerrarFormulario.Location = New System.Drawing.Point(528, 12)
        Me.btnCerrarFormulario.Name = "btnCerrarFormulario"
        Me.btnCerrarFormulario.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarFormulario.TabIndex = 139
        Me.btnCerrarFormulario.TabStop = False
        '
        'No_Tarifa
        '
        Me.No_Tarifa.DataPropertyName = "No_Tarifa"
        Me.No_Tarifa.HeaderText = "Numero Tarifa"
        Me.No_Tarifa.Name = "No_Tarifa"
        Me.No_Tarifa.ReadOnly = True
        Me.No_Tarifa.Width = 99
        '
        'Mes
        '
        Me.Mes.DataPropertyName = "Mes"
        Me.Mes.HeaderText = "Mes"
        Me.Mes.Name = "Mes"
        Me.Mes.ReadOnly = True
        Me.Mes.Width = 52
        '
        'Año
        '
        Me.Año.DataPropertyName = "Año"
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        Me.Año.ReadOnly = True
        Me.Año.Width = 51
        '
        'Tar_B
        '
        Me.Tar_B.DataPropertyName = "Tar_B"
        Me.Tar_B.HeaderText = "Tarifa Basica"
        Me.Tar_B.Name = "Tar_B"
        Me.Tar_B.ReadOnly = True
        Me.Tar_B.Width = 94
        '
        'Tar_I
        '
        Me.Tar_I.DataPropertyName = "Tar_I"
        Me.Tar_I.HeaderText = "Tarifa Intermedia"
        Me.Tar_I.Name = "Tar_I"
        Me.Tar_I.ReadOnly = True
        Me.Tar_I.Width = 102
        '
        'Tar_E
        '
        Me.Tar_E.DataPropertyName = "Tar_E"
        Me.Tar_E.HeaderText = "Tarifa Excedente"
        Me.Tar_E.Name = "Tar_E"
        Me.Tar_E.ReadOnly = True
        Me.Tar_E.Width = 104
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 53
        '
        'Usuario_Mod
        '
        Me.Usuario_Mod.DataPropertyName = "Usuario_Mod"
        Me.Usuario_Mod.HeaderText = "Usuario_Mod"
        Me.Usuario_Mod.Name = "Usuario_Mod"
        Me.Usuario_Mod.ReadOnly = True
        Me.Usuario_Mod.Visible = False
        Me.Usuario_Mod.Width = 95
        '
        'F_Mod
        '
        Me.F_Mod.DataPropertyName = "F_Mod"
        Me.F_Mod.HeaderText = "F_Mod"
        Me.F_Mod.Name = "F_Mod"
        Me.F_Mod.ReadOnly = True
        Me.F_Mod.Visible = False
        Me.F_Mod.Width = 65
        '
        'FormAbcTar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.Controls.Add(Me.btnCerrarFormulario)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lbId)
        Me.Controls.Add(Me.lbFechaMod)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbUsuarioMod)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnSubirArchivo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TarifaDataViewGrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCant_E)
        Me.Controls.Add(Me.txtCant_I)
        Me.Controls.Add(Me.txtCant_B)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbMes)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAbcTar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TarifaDataViewGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tabla_Tarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lbId As Label
    Friend WithEvents lbFechaMod As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbUsuarioMod As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnSubirArchivo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TarifaDataViewGrid As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCant_E As TextBox
    Friend WithEvents txtCant_I As TextBox
    Friend WithEvents txtCant_B As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMes As ComboBox
    Friend WithEvents DS_Tabla_Tarifa As DS_Tabla_Tarifa
    Friend WithEvents TarifaBindingSource As BindingSource
    Friend WithEvents TarifaTableAdapter As DS_Tabla_TarifaTableAdapters.TarifaTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents btnCerrarFormulario As PictureBox
    Friend WithEvents No_Tarifa As DataGridViewTextBoxColumn
    Friend WithEvents Mes As DataGridViewTextBoxColumn
    Friend WithEvents Año As DataGridViewTextBoxColumn
    Friend WithEvents Tar_B As DataGridViewTextBoxColumn
    Friend WithEvents Tar_I As DataGridViewTextBoxColumn
    Friend WithEvents Tar_E As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Usuario_Mod As DataGridViewTextBoxColumn
    Friend WithEvents F_Mod As DataGridViewTextBoxColumn
End Class

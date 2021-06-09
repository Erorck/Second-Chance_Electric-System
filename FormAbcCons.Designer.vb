<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbcCons
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCant_T = New System.Windows.Forms.TextBox()
        Me.ConsumoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tabla_Consumo = New PIA_MAD___ScdChnc.DS_Tabla_Consumo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.Panel_Imagen = New System.Windows.Forms.Panel()
        Me.lbCant_B = New System.Windows.Forms.Label()
        Me.lbCant_E = New System.Windows.Forms.Label()
        Me.lbCant_I = New System.Windows.Forms.Label()
        Me.ConsumoDataViewGrid = New System.Windows.Forms.DataGridView()
        Me.No_Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_I = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario_Mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_Mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DSTablaConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumoTableAdapter = New PIA_MAD___ScdChnc.DS_Tabla_ConsumoTableAdapters.ConsumoTableAdapter()
        Me.AllConsumptionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_ConsumptionsTableAdapter = New PIA_MAD___ScdChnc.DS_Vista_ConsumoTableAdapters.All_ConsumptionsTableAdapter()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSubirArchivo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.DS_Vista_Consumo = New PIA_MAD___ScdChnc.DS_Vista_Consumo()
        Me.AllConsumptionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbUsuarioMod = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbFechaMod = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbId = New System.Windows.Forms.Label()
        Me.cbServicio = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCerrarFormulario = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbMsg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tabla_Consumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Imagen.SuspendLayout()
        CType(Me.ConsumoDataViewGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTablaConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllConsumptionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Vista_Consumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllConsumptionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Nebulosa_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 560)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtCant_T
        '
        Me.txtCant_T.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCant_T.Location = New System.Drawing.Point(147, 434)
        Me.txtCant_T.Name = "txtCant_T"
        Me.txtCant_T.Size = New System.Drawing.Size(94, 20)
        Me.txtCant_T.TabIndex = 29
        Me.txtCant_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConsumoBindingSource1
        '
        Me.ConsumoBindingSource1.DataMember = "Consumo"
        Me.ConsumoBindingSource1.DataSource = Me.DS_Tabla_Consumo
        '
        'DS_Tabla_Consumo
        '
        Me.DS_Tabla_Consumo.DataSetName = "DS_Tabla_Consumo"
        Me.DS_Tabla_Consumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Periodo:"
        '
        'cbMes
        '
        Me.cbMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbMes.Location = New System.Drawing.Point(363, 356)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(65, 26)
        Me.cbMes.TabIndex = 22
        Me.cbMes.Text = "MM"
        '
        'Panel_Imagen
        '
        Me.Panel_Imagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Imagen.Controls.Add(Me.PictureBox1)
        Me.Panel_Imagen.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Imagen.Location = New System.Drawing.Point(550, 0)
        Me.Panel_Imagen.Name = "Panel_Imagen"
        Me.Panel_Imagen.Size = New System.Drawing.Size(250, 560)
        Me.Panel_Imagen.TabIndex = 33
        '
        'lbCant_B
        '
        Me.lbCant_B.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCant_B.AutoSize = True
        Me.lbCant_B.Location = New System.Drawing.Point(364, 396)
        Me.lbCant_B.Name = "lbCant_B"
        Me.lbCant_B.Size = New System.Drawing.Size(29, 13)
        Me.lbCant_B.TabIndex = 34
        Me.lbCant_B.Text = "Kw's"
        '
        'lbCant_E
        '
        Me.lbCant_E.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCant_E.AutoSize = True
        Me.lbCant_E.Location = New System.Drawing.Point(385, 437)
        Me.lbCant_E.Name = "lbCant_E"
        Me.lbCant_E.Size = New System.Drawing.Size(29, 13)
        Me.lbCant_E.TabIndex = 35
        Me.lbCant_E.Text = "Kw's"
        '
        'lbCant_I
        '
        Me.lbCant_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCant_I.AutoSize = True
        Me.lbCant_I.Location = New System.Drawing.Point(385, 416)
        Me.lbCant_I.Name = "lbCant_I"
        Me.lbCant_I.Size = New System.Drawing.Size(29, 13)
        Me.lbCant_I.TabIndex = 36
        Me.lbCant_I.Text = "Kw's"
        '
        'ConsumoDataViewGrid
        '
        Me.ConsumoDataViewGrid.AllowUserToAddRows = False
        Me.ConsumoDataViewGrid.AllowUserToDeleteRows = False
        Me.ConsumoDataViewGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsumoDataViewGrid.AutoGenerateColumns = False
        Me.ConsumoDataViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ConsumoDataViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.NullValue = "NULL"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConsumoDataViewGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ConsumoDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsumoDataViewGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No_Consumo, Me.Año, Me.Mes, Me.Servicio, Me.Cant_B, Me.Cant_I, Me.Cant_E, Me.Estatus, Me.Usuario_Mod, Me.F_Mod})
        Me.ConsumoDataViewGrid.DataSource = Me.ConsumoBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.NullValue = "NULL"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConsumoDataViewGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.ConsumoDataViewGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ConsumoDataViewGrid.Location = New System.Drawing.Point(22, 85)
        Me.ConsumoDataViewGrid.Name = "ConsumoDataViewGrid"
        Me.ConsumoDataViewGrid.ReadOnly = True
        Me.ConsumoDataViewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ConsumoDataViewGrid.Size = New System.Drawing.Size(502, 252)
        Me.ConsumoDataViewGrid.TabIndex = 66
        '
        'No_Consumo
        '
        Me.No_Consumo.DataPropertyName = "No_Consumo"
        Me.No_Consumo.HeaderText = "Consumo"
        Me.No_Consumo.Name = "No_Consumo"
        Me.No_Consumo.ReadOnly = True
        Me.No_Consumo.Width = 76
        '
        'Año
        '
        Me.Año.DataPropertyName = "Año"
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        Me.Año.ReadOnly = True
        Me.Año.Width = 51
        '
        'Mes
        '
        Me.Mes.DataPropertyName = "Mes"
        Me.Mes.HeaderText = "Mes"
        Me.Mes.Name = "Mes"
        Me.Mes.ReadOnly = True
        Me.Mes.Width = 52
        '
        'Servicio
        '
        Me.Servicio.DataPropertyName = "Servicio"
        Me.Servicio.HeaderText = "Servicio"
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        Me.Servicio.Width = 70
        '
        'Cant_B
        '
        Me.Cant_B.DataPropertyName = "Cant_B"
        Me.Cant_B.HeaderText = "Consumo Basico"
        Me.Cant_B.Name = "Cant_B"
        Me.Cant_B.ReadOnly = True
        Me.Cant_B.Width = 102
        '
        'Cant_I
        '
        Me.Cant_I.DataPropertyName = "Cant_I"
        Me.Cant_I.HeaderText = "Consumo Intermedio"
        Me.Cant_I.Name = "Cant_I"
        Me.Cant_I.ReadOnly = True
        Me.Cant_I.Width = 117
        '
        'Cant_E
        '
        Me.Cant_E.DataPropertyName = "Cant_E"
        Me.Cant_E.HeaderText = "Consumo Excendente"
        Me.Cant_E.Name = "Cant_E"
        Me.Cant_E.ReadOnly = True
        Me.Cant_E.Width = 124
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Width = 67
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
        'DSTablaConsumoBindingSource
        '
        Me.DSTablaConsumoBindingSource.DataSource = Me.DS_Tabla_Consumo
        Me.DSTablaConsumoBindingSource.Position = 0
        '
        'ConsumoBindingSource
        '
        Me.ConsumoBindingSource.DataMember = "Consumo"
        Me.ConsumoBindingSource.DataSource = Me.DSTablaConsumoBindingSource
        '
        'ConsumoTableAdapter
        '
        Me.ConsumoTableAdapter.ClearBeforeFill = True
        '
        'All_ConsumptionsTableAdapter
        '
        Me.All_ConsumptionsTableAdapter.ClearBeforeFill = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(282, 507)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(175, 33)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar/Registrar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSubirArchivo
        '
        Me.btnSubirArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubirArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnSubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubirArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubirArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubirArchivo.Location = New System.Drawing.Point(166, 508)
        Me.btnSubirArchivo.Name = "btnSubirArchivo"
        Me.btnSubirArchivo.Size = New System.Drawing.Size(110, 32)
        Me.btnSubirArchivo.TabIndex = 68
        Me.btnSubirArchivo.Text = "Subir Archivo"
        Me.btnSubirArchivo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Servicio:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(17, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(229, 28)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Gestión Consumos"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Consumo #"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(308, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Basico"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(308, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Intermedio"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(308, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Excedente"
        '
        'txtAño
        '
        Me.txtAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(434, 356)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(53, 26)
        Me.txtAño.TabIndex = 75
        Me.txtAño.Text = "YYYY"
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DS_Vista_Consumo
        '
        Me.DS_Vista_Consumo.DataSetName = "DS_Vista_Consumo"
        Me.DS_Vista_Consumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AllConsumptionsBindingSource1
        '
        Me.AllConsumptionsBindingSource1.DataMember = "All Consumptions"
        Me.AllConsumptionsBindingSource1.DataSource = Me.DS_Vista_Consumo
        '
        'lbUsuarioMod
        '
        Me.lbUsuarioMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbUsuarioMod.AutoSize = True
        Me.lbUsuarioMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarioMod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbUsuarioMod.Location = New System.Drawing.Point(98, 480)
        Me.lbUsuarioMod.Name = "lbUsuarioMod"
        Me.lbUsuarioMod.Size = New System.Drawing.Size(97, 15)
        Me.lbUsuarioMod.TabIndex = 106
        Me.lbUsuarioMod.Text = "USUARIO_MOD"
        Me.lbUsuarioMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(96, 465)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 15)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Ultimo usuario en modificar: "
        '
        'lbFechaMod
        '
        Me.lbFechaMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFechaMod.AutoSize = True
        Me.lbFechaMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaMod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbFechaMod.Location = New System.Drawing.Point(295, 480)
        Me.lbFechaMod.Name = "lbFechaMod"
        Me.lbFechaMod.Size = New System.Drawing.Size(46, 15)
        Me.lbFechaMod.TabIndex = 108
        Me.lbFechaMod.Text = "FECHA"
        Me.lbFechaMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(295, 465)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 15)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Fecha modificación:"
        '
        'lbId
        '
        Me.lbId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbId.AutoSize = True
        Me.lbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.Location = New System.Drawing.Point(215, 393)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(71, 20)
        Me.lbId.TabIndex = 109
        Me.lbId.Text = "Numero"
        Me.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbServicio
        '
        Me.cbServicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbServicio.FormattingEnabled = True
        Me.cbServicio.Location = New System.Drawing.Point(119, 358)
        Me.cbServicio.Name = "cbServicio"
        Me.cbServicio.Size = New System.Drawing.Size(169, 21)
        Me.cbServicio.TabIndex = 110
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(83, 507)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(77, 33)
        Me.btnLimpiar.TabIndex = 111
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCerrarFormulario
        '
        Me.btnCerrarFormulario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarFormulario.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Close
        Me.btnCerrarFormulario.Location = New System.Drawing.Point(528, 12)
        Me.btnCerrarFormulario.Name = "btnCerrarFormulario"
        Me.btnCerrarFormulario.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarFormulario.TabIndex = 112
        Me.btnCerrarFormulario.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(144, 418)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 17)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "Consumo Total"
        '
        'lbMsg
        '
        Me.lbMsg.AutoSize = True
        Me.lbMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMsg.ForeColor = System.Drawing.Color.Gold
        Me.lbMsg.Location = New System.Drawing.Point(23, 61)
        Me.lbMsg.Name = "lbMsg"
        Me.lbMsg.Size = New System.Drawing.Size(31, 15)
        Me.lbMsg.TabIndex = 166
        Me.lbMsg.Text = "Msg"
        '
        'FormAbcCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.Controls.Add(Me.lbMsg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCerrarFormulario)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.cbServicio)
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
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSubirArchivo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ConsumoDataViewGrid)
        Me.Controls.Add(Me.lbCant_I)
        Me.Controls.Add(Me.lbCant_E)
        Me.Controls.Add(Me.lbCant_B)
        Me.Controls.Add(Me.Panel_Imagen)
        Me.Controls.Add(Me.txtCant_T)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbMes)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAbcCons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tabla_Consumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Imagen.ResumeLayout(False)
        CType(Me.ConsumoDataViewGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTablaConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllConsumptionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Vista_Consumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllConsumptionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCant_T As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMes As ComboBox
    Friend WithEvents Panel_Imagen As Panel
    Friend WithEvents lbCant_B As Label
    Friend WithEvents lbCant_E As Label
    Friend WithEvents lbCant_I As Label
    Friend WithEvents ConsumoDataViewGrid As DataGridView
    Friend WithEvents DSTablaConsumoBindingSource As BindingSource
    Friend WithEvents DS_Tabla_Consumo As DS_Tabla_Consumo
    Friend WithEvents ConsumoBindingSource As BindingSource
    Friend WithEvents ConsumoTableAdapter As DS_Tabla_ConsumoTableAdapters.ConsumoTableAdapter
    Friend WithEvents AllConsumptionsBindingSource As BindingSource
    Friend WithEvents All_ConsumptionsTableAdapter As DS_Vista_ConsumoTableAdapters.All_ConsumptionsTableAdapter
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSubirArchivo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents ConsumoBindingSource1 As BindingSource
    Friend WithEvents DS_Vista_Consumo As DS_Vista_Consumo
    Friend WithEvents AllConsumptionsBindingSource1 As BindingSource
    Friend WithEvents lbUsuarioMod As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbFechaMod As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbId As Label
    Friend WithEvents No_Consumo As DataGridViewTextBoxColumn
    Friend WithEvents Año As DataGridViewTextBoxColumn
    Friend WithEvents Mes As DataGridViewTextBoxColumn
    Friend WithEvents Servicio As DataGridViewTextBoxColumn
    Friend WithEvents Cant_B As DataGridViewTextBoxColumn
    Friend WithEvents Cant_I As DataGridViewTextBoxColumn
    Friend WithEvents Cant_E As DataGridViewTextBoxColumn
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
    Friend WithEvents Usuario_Mod As DataGridViewTextBoxColumn
    Friend WithEvents F_Mod As DataGridViewTextBoxColumn
    Friend WithEvents cbServicio As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCerrarFormulario As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbMsg As Label
End Class

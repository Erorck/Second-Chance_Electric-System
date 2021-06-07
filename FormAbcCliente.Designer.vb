<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbcCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DVLabel As System.Windows.Forms.Label
        Dim DHSLabel As System.Windows.Forms.Label
        Me.btnCerrarFormulario = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DVTextBox = New System.Windows.Forms.TextBox()
        Me.DHSTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DS_Tabla_Cliente = New PIA_MAD___ScdChnc.DS_Tabla_Cliente()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New PIA_MAD___ScdChnc.DS_Tabla_ClienteTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New PIA_MAD___ScdChnc.DS_Tabla_ClienteTableAdapters.TableAdapterManager()
        Me.DS_Vista_Cliente = New PIA_MAD___ScdChnc.DS_Vista_Cliente()
        Me.DSVistaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_ClientsTableAdapter = New PIA_MAD___ScdChnc.DS_Vista_ClienteTableAdapters.All_ClientsTableAdapter()
        Me.No_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DVLabel = New System.Windows.Forms.Label()
        DHSLabel = New System.Windows.Forms.Label()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tabla_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Vista_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSVistaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrarFormulario
        '
        Me.btnCerrarFormulario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarFormulario.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Close
        Me.btnCerrarFormulario.Location = New System.Drawing.Point(818, 12)
        Me.btnCerrarFormulario.Name = "btnCerrarFormulario"
        Me.btnCerrarFormulario.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarFormulario.TabIndex = 61
        Me.btnCerrarFormulario.TabStop = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(33, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(200, 28)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Gestión Clientes"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(28, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 33)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(120, 518)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 33)
        Me.Button4.TabIndex = 63
        Me.Button4.Text = "Guardar/Registrar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.NullValue = "NULL"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClienteDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No_Usuario, Me.NombreDataGridViewTextBoxColumn, Me.Apellido_P, Me.Apellido_M, Me.DomicilioDataGridViewTextBoxColumn, Me.Estatus})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.NullValue = "NULL"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClienteDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClienteDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClienteDataGridView.Location = New System.Drawing.Point(356, 64)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ClienteDataGridView.Size = New System.Drawing.Size(478, 557)
        Me.ClienteDataGridView.TabIndex = 65
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "F_Mod", True))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(152, 484)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 15)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "FECHA"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Usuario_Mod", True))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(192, 462)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 15)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "USUARIO_MOD"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "No_Usuario", True))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(87, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "1111"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(36, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Genero"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"MA - MASCULINO", "FE - FEMENINO"})
        Me.ComboBox2.Location = New System.Drawing.Point(37, 347)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 101
        '
        'DVLabel
        '
        DVLabel.AutoSize = True
        DVLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DVLabel.Location = New System.Drawing.Point(117, 309)
        DVLabel.Name = "DVLabel"
        DVLabel.Size = New System.Drawing.Size(90, 13)
        DVLabel.TabIndex = 96
        DVLabel.Text = "Digito Verificador:"
        '
        'DVTextBox
        '
        Me.DVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DV", True))
        Me.DVTextBox.Location = New System.Drawing.Point(213, 306)
        Me.DVTextBox.MaxLength = 1
        Me.DVTextBox.Name = "DVTextBox"
        Me.DVTextBox.Size = New System.Drawing.Size(26, 20)
        Me.DVTextBox.TabIndex = 99
        Me.DVTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DHSLabel
        '
        DHSLabel.AutoSize = True
        DHSLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DHSLabel.Location = New System.Drawing.Point(32, 283)
        DHSLabel.Name = "DHSLabel"
        DHSLabel.Size = New System.Drawing.Size(175, 13)
        DHSLabel.TabIndex = 95
        DHSLabel.Text = "Diferenciador de Homonima y Siglo:"
        '
        'DHSTextBox
        '
        Me.DHSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DHS", True))
        Me.DHSTextBox.Location = New System.Drawing.Point(213, 280)
        Me.DHSTextBox.MaxLength = 1
        Me.DHSTextBox.Name = "DHSTextBox"
        Me.DHSTextBox.Size = New System.Drawing.Size(26, 20)
        Me.DHSTextBox.TabIndex = 97
        Me.DHSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(160, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 15)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "Confirmar contraseña"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Contraseña", True))
        Me.TextBox5.Location = New System.Drawing.Point(162, 207)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(115, 20)
        Me.TextBox5.TabIndex = 93
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(36, 484)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 15)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Fecha modificación:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(34, 462)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 15)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Ultimo usuario en modificar: "
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A - ACTIVO", "S - SUSPENDIDO", "E - ELIMINADO"})
        Me.ComboBox1.Location = New System.Drawing.Point(37, 427)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 90
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(237, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Edad: 26 años"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(36, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 15)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Fecha de nacimiento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "F_Nac", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 250)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(195, 20)
        Me.DateTimePicker1.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(177, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 15)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Apellido Materno"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Apellido_M", True))
        Me.TextBox9.Location = New System.Drawing.Point(180, 165)
        Me.TextBox9.MaxLength = 25
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(136, 20)
        Me.TextBox9.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(35, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Número: "
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(34, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Estado"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(164, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "CURP"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CURP", True))
        Me.TextBox8.Location = New System.Drawing.Point(167, 348)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(146, 20)
        Me.TextBox8.TabIndex = 79
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(34, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Email"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Email", True))
        Me.TextBox3.Location = New System.Drawing.Point(37, 387)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(252, 20)
        Me.TextBox3.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(35, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Apellido Paterno"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Apellido_P", True))
        Me.TextBox4.Location = New System.Drawing.Point(38, 165)
        Me.TextBox4.MaxLength = 25
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(136, 20)
        Me.TextBox4.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(36, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Nombre(s)"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(38, 122)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(175, 20)
        Me.txtNombre.TabIndex = 73
        Me.txtNombre.Text = "Tu nombre"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(35, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 15)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Contraseña", True))
        Me.TextBox1.Location = New System.Drawing.Point(38, 207)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 20)
        Me.TextBox1.TabIndex = 71
        '
        'DS_Tabla_Cliente
        '
        Me.DS_Tabla_Cliente.DataSetName = "DS_Tabla_Cliente"
        Me.DS_Tabla_Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DS_Tabla_Cliente
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.UpdateOrder = PIA_MAD___ScdChnc.DS_Tabla_ClienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DS_Vista_Cliente
        '
        Me.DS_Vista_Cliente.DataSetName = "DS_Vista_Cliente"
        Me.DS_Vista_Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DSVistaClienteBindingSource
        '
        Me.DSVistaClienteBindingSource.DataSource = Me.DS_Vista_Cliente
        Me.DSVistaClienteBindingSource.Position = 0
        '
        'AllClientsBindingSource
        '
        Me.AllClientsBindingSource.DataMember = "All Clients"
        Me.AllClientsBindingSource.DataSource = Me.DSVistaClienteBindingSource
        '
        'All_ClientsTableAdapter
        '
        Me.All_ClientsTableAdapter.ClearBeforeFill = True
        '
        'No_Usuario
        '
        Me.No_Usuario.DataPropertyName = "No_Usuario"
        Me.No_Usuario.HeaderText = "Usuario"
        Me.No_Usuario.Name = "No_Usuario"
        Me.No_Usuario.ReadOnly = True
        Me.No_Usuario.Width = 68
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 69
        '
        'Apellido_P
        '
        Me.Apellido_P.DataPropertyName = "Apellido_P"
        Me.Apellido_P.HeaderText = "Apellido paterno"
        Me.Apellido_P.Name = "Apellido_P"
        Me.Apellido_P.Width = 99
        '
        'Apellido_M
        '
        Me.Apellido_M.DataPropertyName = "Apellido_M"
        Me.Apellido_M.HeaderText = "Apellido materno"
        Me.Apellido_M.Name = "Apellido_M"
        Me.Apellido_M.Width = 101
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.Width = 74
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.Width = 67
        '
        'FormAbcCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(860, 776)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(DVLabel)
        Me.Controls.Add(Me.DVTextBox)
        Me.Controls.Add(DHSLabel)
        Me.Controls.Add(Me.DHSTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnCerrarFormulario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAbcCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de clientes"
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tabla_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Vista_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSVistaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrarFormulario As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DVTextBox As TextBox
    Friend WithEvents DHSTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DS_Tabla_Cliente As DS_Tabla_Cliente
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DS_Tabla_ClienteTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As DS_Tabla_ClienteTableAdapters.TableAdapterManager
    Friend WithEvents DSVistaClienteBindingSource As BindingSource
    Friend WithEvents DS_Vista_Cliente As DS_Vista_Cliente
    Friend WithEvents AllClientsBindingSource As BindingSource
    Friend WithEvents All_ClientsTableAdapter As DS_Vista_ClienteTableAdapters.All_ClientsTableAdapter
    Friend WithEvents No_Usuario As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_P As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_M As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
End Class

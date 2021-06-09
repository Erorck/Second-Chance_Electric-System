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
        Dim DVLabel As System.Windows.Forms.Label
        Dim DHSLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrarFormulario = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.No_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DHS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_Nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario_Mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_Mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tabla_Cliente = New PIA_MAD___ScdChnc.DS_Tabla_Cliente()
        Me.lbFechaMod = New System.Windows.Forms.Label()
        Me.lbUsuarioMod = New System.Windows.Forms.Label()
        Me.lbId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.DVTextBox = New System.Windows.Forms.TextBox()
        Me.DHSTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCURP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellidoP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.ClienteTableAdapter = New PIA_MAD___ScdChnc.DS_Tabla_ClienteTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New PIA_MAD___ScdChnc.DS_Tabla_ClienteTableAdapters.TableAdapterManager()
        Me.DS_Vista_Cliente = New PIA_MAD___ScdChnc.DS_Vista_Cliente()
        Me.DSVistaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_ClientsTableAdapter = New PIA_MAD___ScdChnc.DS_Vista_ClienteTableAdapters.All_ClientsTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lbMsg = New System.Windows.Forms.Label()
        DVLabel = New System.Windows.Forms.Label()
        DHSLabel = New System.Windows.Forms.Label()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tabla_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Vista_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSVistaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DVLabel
        '
        DVLabel.AutoSize = True
        DVLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DVLabel.Location = New System.Drawing.Point(118, 351)
        DVLabel.Name = "DVLabel"
        DVLabel.Size = New System.Drawing.Size(90, 13)
        DVLabel.TabIndex = 96
        DVLabel.Text = "Digito Verificador:"
        '
        'DHSLabel
        '
        DHSLabel.AutoSize = True
        DHSLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DHSLabel.Location = New System.Drawing.Point(33, 325)
        DHSLabel.Name = "DHSLabel"
        DHSLabel.Size = New System.Drawing.Size(175, 13)
        DHSLabel.TabIndex = 95
        DHSLabel.Text = "Diferenciador de Homonima y Siglo:"
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
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(38, 600)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(77, 33)
        Me.btnEliminar.TabIndex = 64
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(121, 561)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(175, 33)
        Me.btnGuardar.TabIndex = 63
        Me.btnGuardar.Text = "Guardar/Registrar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.NullValue = "NULL"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClienteDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No_Usuario, Me.Nombre, Me.Apellido_P, Me.Apellido_M, Me.Estatus, Me.Contraseña, Me.Email, Me.CURP, Me.DHS, Me.DV, Me.Genero, Me.Domicilio, Me.F_Nac, Me.Usuario_Mod, Me.F_Mod})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.NullValue = "NULL"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClienteDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClienteDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClienteDataGridView.Location = New System.Drawing.Point(356, 64)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        Me.ClienteDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ClienteDataGridView.Size = New System.Drawing.Size(478, 557)
        Me.ClienteDataGridView.TabIndex = 65
        '
        'No_Usuario
        '
        Me.No_Usuario.DataPropertyName = "No_Usuario"
        Me.No_Usuario.HeaderText = "Usuario"
        Me.No_Usuario.Name = "No_Usuario"
        Me.No_Usuario.ReadOnly = True
        Me.No_Usuario.Width = 68
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 69
        '
        'Apellido_P
        '
        Me.Apellido_P.DataPropertyName = "Apellido_P"
        Me.Apellido_P.HeaderText = "Apellido paterno"
        Me.Apellido_P.Name = "Apellido_P"
        Me.Apellido_P.ReadOnly = True
        Me.Apellido_P.Width = 99
        '
        'Apellido_M
        '
        Me.Apellido_M.DataPropertyName = "Apellido_M"
        Me.Apellido_M.HeaderText = "Apellido materno"
        Me.Apellido_M.Name = "Apellido_M"
        Me.Apellido_M.ReadOnly = True
        Me.Apellido_M.Width = 101
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Width = 67
        '
        'Contraseña
        '
        Me.Contraseña.DataPropertyName = "Contraseña"
        Me.Contraseña.HeaderText = "Contraseña"
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.ReadOnly = True
        Me.Contraseña.Visible = False
        Me.Contraseña.Width = 86
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Visible = False
        Me.Email.Width = 57
        '
        'CURP
        '
        Me.CURP.DataPropertyName = "CURP"
        Me.CURP.HeaderText = "CURP"
        Me.CURP.Name = "CURP"
        Me.CURP.ReadOnly = True
        Me.CURP.Visible = False
        Me.CURP.Width = 62
        '
        'DHS
        '
        Me.DHS.DataPropertyName = "DHS"
        Me.DHS.HeaderText = "DHS"
        Me.DHS.Name = "DHS"
        Me.DHS.ReadOnly = True
        Me.DHS.Visible = False
        Me.DHS.Width = 55
        '
        'DV
        '
        Me.DV.DataPropertyName = "DV"
        Me.DV.HeaderText = "DV"
        Me.DV.Name = "DV"
        Me.DV.ReadOnly = True
        Me.DV.Visible = False
        Me.DV.Width = 47
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        Me.Genero.Visible = False
        Me.Genero.Width = 67
        '
        'Domicilio
        '
        Me.Domicilio.DataPropertyName = "Domicilio"
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
        Me.Domicilio.Visible = False
        Me.Domicilio.Width = 74
        '
        'F_Nac
        '
        Me.F_Nac.DataPropertyName = "F_Nac"
        Me.F_Nac.HeaderText = "F_Nac"
        Me.F_Nac.Name = "F_Nac"
        Me.F_Nac.ReadOnly = True
        Me.F_Nac.Visible = False
        Me.F_Nac.Width = 64
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
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DS_Tabla_Cliente
        '
        'DS_Tabla_Cliente
        '
        Me.DS_Tabla_Cliente.DataSetName = "DS_Tabla_Cliente"
        Me.DS_Tabla_Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbFechaMod
        '
        Me.lbFechaMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFechaMod.AutoSize = True
        Me.lbFechaMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaMod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbFechaMod.Location = New System.Drawing.Point(168, 534)
        Me.lbFechaMod.Name = "lbFechaMod"
        Me.lbFechaMod.Size = New System.Drawing.Size(46, 15)
        Me.lbFechaMod.TabIndex = 105
        Me.lbFechaMod.Text = "FECHA"
        Me.lbFechaMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbUsuarioMod
        '
        Me.lbUsuarioMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbUsuarioMod.AutoSize = True
        Me.lbUsuarioMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarioMod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbUsuarioMod.Location = New System.Drawing.Point(37, 519)
        Me.lbUsuarioMod.Name = "lbUsuarioMod"
        Me.lbUsuarioMod.Size = New System.Drawing.Size(97, 15)
        Me.lbUsuarioMod.TabIndex = 104
        Me.lbUsuarioMod.Text = "USUARIO_MOD"
        Me.lbUsuarioMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbId
        '
        Me.lbId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbId.AutoSize = True
        Me.lbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbId.Location = New System.Drawing.Point(87, 76)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(35, 15)
        Me.lbId.TabIndex = 103
        Me.lbId.Text = "1111"
        Me.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(37, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Genero"
        '
        'cbGenero
        '
        Me.cbGenero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"MA - MASCULINO", "FE - FEMENINO"})
        Me.cbGenero.Location = New System.Drawing.Point(38, 389)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(115, 21)
        Me.cbGenero.TabIndex = 101
        '
        'DVTextBox
        '
        Me.DVTextBox.Location = New System.Drawing.Point(214, 348)
        Me.DVTextBox.MaxLength = 1
        Me.DVTextBox.Name = "DVTextBox"
        Me.DVTextBox.Size = New System.Drawing.Size(26, 20)
        Me.DVTextBox.TabIndex = 99
        Me.DVTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DHSTextBox
        '
        Me.DHSTextBox.Location = New System.Drawing.Point(214, 322)
        Me.DHSTextBox.MaxLength = 1
        Me.DHSTextBox.Name = "DHSTextBox"
        Me.DHSTextBox.Size = New System.Drawing.Size(26, 20)
        Me.DHSTextBox.TabIndex = 97
        Me.DHSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(37, 534)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 15)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Fecha modificación:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(35, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 15)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Ultimo usuario en modificar: "
        '
        'cbEstado
        '
        Me.cbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstado.Enabled = False
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"A - ACTIVO", "S - SUSPENDIDO", "E - ELIMINADO"})
        Me.cbEstado.Location = New System.Drawing.Point(38, 469)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbEstado.TabIndex = 90
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(37, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 15)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Fecha de nacimiento"
        '
        'FechaNac
        '
        Me.FechaNac.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaNac.Location = New System.Drawing.Point(39, 292)
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.Size = New System.Drawing.Size(195, 20)
        Me.FechaNac.TabIndex = 87
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
        'txtApellidoM
        '
        Me.txtApellidoM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidoM.Location = New System.Drawing.Point(180, 165)
        Me.txtApellidoM.MaxLength = 25
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(136, 20)
        Me.txtApellidoM.TabIndex = 85
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
        Me.Label6.Location = New System.Drawing.Point(35, 452)
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
        Me.Label8.Location = New System.Drawing.Point(157, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "CURP"
        '
        'txtCURP
        '
        Me.txtCURP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCURP.Enabled = False
        Me.txtCURP.Location = New System.Drawing.Point(161, 390)
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.ReadOnly = True
        Me.txtCURP.Size = New System.Drawing.Size(135, 20)
        Me.txtCURP.TabIndex = 79
        Me.txtCURP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(35, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(38, 429)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(176, 20)
        Me.txtEmail.TabIndex = 77
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
        'txtApellidoP
        '
        Me.txtApellidoP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidoP.Location = New System.Drawing.Point(38, 165)
        Me.txtApellidoP.MaxLength = 25
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(136, 20)
        Me.txtApellidoP.TabIndex = 75
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
        Me.txtNombre.Location = New System.Drawing.Point(38, 122)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(175, 20)
        Me.txtNombre.TabIndex = 73
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
        'txtPass
        '
        Me.txtPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPass.Location = New System.Drawing.Point(38, 207)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(115, 20)
        Me.txtPass.TabIndex = 71
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
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(37, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Domicilio"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDomicilio.Location = New System.Drawing.Point(39, 253)
        Me.txtDomicilio.MaxLength = 30
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(175, 20)
        Me.txtDomicilio.TabIndex = 106
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHabilitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnHabilitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHabilitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHabilitar.Location = New System.Drawing.Point(121, 600)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(77, 33)
        Me.btnHabilitar.TabIndex = 110
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(38, 561)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(77, 30)
        Me.btnLimpiar.TabIndex = 109
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lbMsg
        '
        Me.lbMsg.AutoSize = True
        Me.lbMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMsg.ForeColor = System.Drawing.Color.Gold
        Me.lbMsg.Location = New System.Drawing.Point(37, 56)
        Me.lbMsg.Name = "lbMsg"
        Me.lbMsg.Size = New System.Drawing.Size(31, 15)
        Me.lbMsg.TabIndex = 164
        Me.lbMsg.Text = "Msg"
        '
        'FormAbcCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(860, 650)
        Me.Controls.Add(Me.lbMsg)
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.lbFechaMod)
        Me.Controls.Add(Me.lbUsuarioMod)
        Me.Controls.Add(Me.lbId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(DVLabel)
        Me.Controls.Add(Me.DVTextBox)
        Me.Controls.Add(DHSLabel)
        Me.Controls.Add(Me.DHSTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FechaNac)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtApellidoM)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCURP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellidoP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnCerrarFormulario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAbcCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de clientes"
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tabla_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Vista_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSVistaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrarFormulario As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents lbFechaMod As Label
    Friend WithEvents lbUsuarioMod As Label
    Friend WithEvents lbId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents DVTextBox As TextBox
    Friend WithEvents DHSTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FechaNac As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCURP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents DS_Tabla_Cliente As DS_Tabla_Cliente
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DS_Tabla_ClienteTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As DS_Tabla_ClienteTableAdapters.TableAdapterManager
    Friend WithEvents DSVistaClienteBindingSource As BindingSource
    Friend WithEvents DS_Vista_Cliente As DS_Vista_Cliente
    Friend WithEvents AllClientsBindingSource As BindingSource
    Friend WithEvents All_ClientsTableAdapter As DS_Vista_ClienteTableAdapters.All_ClientsTableAdapter
    Friend WithEvents No_Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_P As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_M As DataGridViewTextBoxColumn
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents CURP As DataGridViewTextBoxColumn
    Friend WithEvents DHS As DataGridViewTextBoxColumn
    Friend WithEvents DV As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As DataGridViewTextBoxColumn
    Friend WithEvents F_Nac As DataGridViewTextBoxColumn
    Friend WithEvents Usuario_Mod As DataGridViewTextBoxColumn
    Friend WithEvents F_Mod As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents btnHabilitar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lbMsg As Label
End Class

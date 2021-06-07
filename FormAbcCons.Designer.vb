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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel_Imagen = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConsumoDataViewGrid = New System.Windows.Forms.DataGridView()
        Me.DS_Tabla_Consumo = New PIA_MAD___ScdChnc.DS_Tabla_Consumo()
        Me.DSTablaConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumoTableAdapter = New PIA_MAD___ScdChnc.DS_Tabla_ConsumoTableAdapters.ConsumoTableAdapter()
        Me.AllConsumptionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_ConsumptionsTableAdapter = New PIA_MAD___ScdChnc.DS_Vista_ConsumoTableAdapters.All_ConsumptionsTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ConsumoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Vista_Consumo = New PIA_MAD___ScdChnc.DS_Vista_Consumo()
        Me.AllConsumptionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_I = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Imagen.SuspendLayout()
        CType(Me.ConsumoDataViewGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tabla_Consumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTablaConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllConsumptionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Vista_Consumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllConsumptionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Nebulosa_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 520)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumoBindingSource1, "Cant_E", True))
        Me.TextBox3.Location = New System.Drawing.Point(281, 437)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 20)
        Me.TextBox3.TabIndex = 29
        Me.TextBox3.Text = "Excendente"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumoBindingSource1, "Cant_I", True))
        Me.TextBox2.Location = New System.Drawing.Point(176, 437)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 28
        Me.TextBox2.Text = "Intermedio"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumoBindingSource1, "Cant_B", True))
        Me.TextBox1.Location = New System.Drawing.Point(73, 437)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = "Básico"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Periodo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumoBindingSource1, "Mes", True))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(278, 352)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(52, 28)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.Text = "MM"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumoBindingSource1, "Servicio", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(126, 355)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(77, 23)
        Me.TextBox4.TabIndex = 32
        Me.TextBox4.Text = "# de contrato"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_Imagen
        '
        Me.Panel_Imagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Imagen.Controls.Add(Me.PictureBox1)
        Me.Panel_Imagen.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Imagen.Location = New System.Drawing.Point(450, 0)
        Me.Panel_Imagen.Name = "Panel_Imagen"
        Me.Panel_Imagen.Size = New System.Drawing.Size(250, 520)
        Me.Panel_Imagen.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Kw's"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Kw's"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Kw's"
        '
        'ConsumoDataViewGrid
        '
        Me.ConsumoDataViewGrid.AllowUserToDeleteRows = False
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
        Me.ConsumoDataViewGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AñoDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.ServicioDataGridViewTextBoxColumn, Me.No_Consumo, Me.Cant_B, Me.Cant_I, Me.Cant_E})
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
        Me.ConsumoDataViewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ConsumoDataViewGrid.Size = New System.Drawing.Size(401, 252)
        Me.ConsumoDataViewGrid.TabIndex = 66
        '
        'DS_Tabla_Consumo
        '
        Me.DS_Tabla_Consumo.DataSetName = "DS_Tabla_Consumo"
        Me.DS_Tabla_Consumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(197, 475)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 33)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "Guardar/Registrar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'buttonLogin
        '
        Me.buttonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonLogin.Location = New System.Drawing.Point(77, 475)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(110, 32)
        Me.buttonLogin.TabIndex = 68
        Me.buttonLogin.Text = "Subir Archivo"
        Me.buttonLogin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "No. Contrato:"
        '
        'Label16
        '
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
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Consumo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Basico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(171, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Intermedio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(278, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Excedente"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumoBindingSource1, "Año", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(336, 352)
        Me.TextBox5.MaxLength = 4
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(58, 26)
        Me.TextBox5.TabIndex = 75
        Me.TextBox5.Text = "YYYY"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConsumoBindingSource1
        '
        Me.ConsumoBindingSource1.DataMember = "Consumo"
        Me.ConsumoBindingSource1.DataSource = Me.DS_Tabla_Consumo
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
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.Width = 51
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        Me.MesDataGridViewTextBoxColumn.ReadOnly = True
        Me.MesDataGridViewTextBoxColumn.Width = 52
        '
        'ServicioDataGridViewTextBoxColumn
        '
        Me.ServicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.Name = "ServicioDataGridViewTextBoxColumn"
        Me.ServicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioDataGridViewTextBoxColumn.Width = 70
        '
        'No_Consumo
        '
        Me.No_Consumo.DataPropertyName = "No_Consumo"
        Me.No_Consumo.HeaderText = "No_Consumo"
        Me.No_Consumo.Name = "No_Consumo"
        Me.No_Consumo.ReadOnly = True
        Me.No_Consumo.Width = 96
        '
        'Cant_B
        '
        Me.Cant_B.DataPropertyName = "Cant_B"
        Me.Cant_B.HeaderText = "Cant_B"
        Me.Cant_B.Name = "Cant_B"
        Me.Cant_B.Width = 67
        '
        'Cant_I
        '
        Me.Cant_I.DataPropertyName = "Cant_I"
        Me.Cant_I.HeaderText = "Cant_I"
        Me.Cant_I.Name = "Cant_I"
        Me.Cant_I.Width = 63
        '
        'Cant_E
        '
        Me.Cant_E.DataPropertyName = "Cant_E"
        Me.Cant_E.HeaderText = "Cant_E"
        Me.Cant_E.Name = "Cant_E"
        Me.Cant_E.Width = 67
        '
        'FormAbcCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 520)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ConsumoDataViewGrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel_Imagen)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAbcCons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Imagen.ResumeLayout(False)
        CType(Me.ConsumoDataViewGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tabla_Consumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTablaConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllConsumptionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Vista_Consumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllConsumptionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel_Imagen As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ConsumoDataViewGrid As DataGridView
    Friend WithEvents DSTablaConsumoBindingSource As BindingSource
    Friend WithEvents DS_Tabla_Consumo As DS_Tabla_Consumo
    Friend WithEvents ConsumoBindingSource As BindingSource
    Friend WithEvents ConsumoTableAdapter As DS_Tabla_ConsumoTableAdapters.ConsumoTableAdapter
    Friend WithEvents AllConsumptionsBindingSource As BindingSource
    Friend WithEvents All_ConsumptionsTableAdapter As DS_Vista_ConsumoTableAdapters.All_ConsumptionsTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents buttonLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ConsumoBindingSource1 As BindingSource
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents No_Consumo As DataGridViewTextBoxColumn
    Friend WithEvents Cant_B As DataGridViewTextBoxColumn
    Friend WithEvents Cant_I As DataGridViewTextBoxColumn
    Friend WithEvents Cant_E As DataGridViewTextBoxColumn
    Friend WithEvents DS_Vista_Consumo As DS_Vista_Consumo
    Friend WithEvents AllConsumptionsBindingSource1 As BindingSource
End Class

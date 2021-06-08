<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbcRcb
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerarRcb = New System.Windows.Forms.Button()
        Me.GenRcbDataViewGrid = New System.Windows.Forms.DataGridView()
        Me.DS_Tabla_Rcb = New PIA_MAD___ScdChnc.DS_Tabla_Rcb()
        Me.AllReceiptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_ReceiptsTableAdapter = New PIA_MAD___ScdChnc.DS_Tabla_RcbTableAdapters.All_ReceiptsTableAdapter()
        Me.NumeroReciboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroMesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroMedidorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoBasicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoIntermedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoExcedenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroTarifaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifaBasicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifaIntermediaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifaExcedenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalBasicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalIntermedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalExcedenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLimitePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModificadoporDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechamodificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCerrarFormulario = New System.Windows.Forms.PictureBox()
        CType(Me.GenRcbDataViewGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tabla_Rcb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllReceiptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(266, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Periodo"
        '
        'txtAño
        '
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(297, 428)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(80, 26)
        Me.txtAño.TabIndex = 153
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbMes
        '
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(220, 428)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(71, 26)
        Me.cbMes.TabIndex = 4
        Me.cbMes.Text = "MM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(319, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Año"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(236, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Mes"
        '
        'cbTipo
        '
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(385, 428)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(136, 28)
        Me.cbTipo.TabIndex = 156
        Me.cbTipo.Text = "Todos"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(390, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Tipo de servicio"
        '
        'btnGenerarRcb
        '
        Me.btnGenerarRcb.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnGenerarRcb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarRcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarRcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarRcb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnGenerarRcb.Location = New System.Drawing.Point(287, 482)
        Me.btnGenerarRcb.Name = "btnGenerarRcb"
        Me.btnGenerarRcb.Size = New System.Drawing.Size(159, 33)
        Me.btnGenerarRcb.TabIndex = 158
        Me.btnGenerarRcb.Text = "Generar Recibos"
        Me.btnGenerarRcb.UseVisualStyleBackColor = False
        '
        'GenRcbDataViewGrid
        '
        Me.GenRcbDataViewGrid.AllowUserToAddRows = False
        Me.GenRcbDataViewGrid.AllowUserToDeleteRows = False
        Me.GenRcbDataViewGrid.AutoGenerateColumns = False
        Me.GenRcbDataViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GenRcbDataViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.NullValue = "NULL"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GenRcbDataViewGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GenRcbDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GenRcbDataViewGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroReciboDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.CURPDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.AñoDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.NumeroMesDataGridViewTextBoxColumn, Me.NumeroContratoDataGridViewTextBoxColumn, Me.TipoServicioDataGridViewTextBoxColumn, Me.NumeroMedidorDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.NumeroConsumoDataGridViewTextBoxColumn, Me.ConsumoBasicoDataGridViewTextBoxColumn, Me.ConsumoIntermedioDataGridViewTextBoxColumn, Me.ConsumoExcedenteDataGridViewTextBoxColumn, Me.ConsumoTotalDataGridViewTextBoxColumn, Me.NumeroTarifaDataGridViewTextBoxColumn, Me.TarifaBasicaDataGridViewTextBoxColumn, Me.TarifaIntermediaDataGridViewTextBoxColumn, Me.TarifaExcedenteDataGridViewTextBoxColumn, Me.SubtotalBasicoDataGridViewTextBoxColumn, Me.SubtotalIntermedioDataGridViewTextBoxColumn, Me.SubtotalExcedenteDataGridViewTextBoxColumn, Me.SubtotalFinalDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.TotalNumeroDataGridViewTextBoxColumn, Me.TotalNombreDataGridViewTextBoxColumn, Me.FechaLimitePagoDataGridViewTextBoxColumn, Me.FormaPagoDataGridViewTextBoxColumn, Me.ModificadoporDataGridViewTextBoxColumn, Me.FechamodificacionDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.GenRcbDataViewGrid.DataSource = Me.AllReceiptsBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.NullValue = "NULL"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GenRcbDataViewGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.GenRcbDataViewGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GenRcbDataViewGrid.Location = New System.Drawing.Point(22, 67)
        Me.GenRcbDataViewGrid.Name = "GenRcbDataViewGrid"
        Me.GenRcbDataViewGrid.ReadOnly = True
        Me.GenRcbDataViewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GenRcbDataViewGrid.Size = New System.Drawing.Size(742, 291)
        Me.GenRcbDataViewGrid.TabIndex = 159
        '
        'DS_Tabla_Rcb
        '
        Me.DS_Tabla_Rcb.DataSetName = "DS_Tabla_Rcb"
        Me.DS_Tabla_Rcb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AllReceiptsBindingSource
        '
        Me.AllReceiptsBindingSource.DataMember = "All Receipts"
        Me.AllReceiptsBindingSource.DataSource = Me.DS_Tabla_Rcb
        '
        'All_ReceiptsTableAdapter
        '
        Me.All_ReceiptsTableAdapter.ClearBeforeFill = True
        '
        'NumeroReciboDataGridViewTextBoxColumn
        '
        Me.NumeroReciboDataGridViewTextBoxColumn.DataPropertyName = "Numero_Recibo"
        Me.NumeroReciboDataGridViewTextBoxColumn.HeaderText = "Numero_Recibo"
        Me.NumeroReciboDataGridViewTextBoxColumn.Name = "NumeroReciboDataGridViewTextBoxColumn"
        Me.NumeroReciboDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroReciboDataGridViewTextBoxColumn.Width = 109
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 64
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Width = 63
        '
        'CURPDataGridViewTextBoxColumn
        '
        Me.CURPDataGridViewTextBoxColumn.DataPropertyName = "CURP"
        Me.CURPDataGridViewTextBoxColumn.HeaderText = "CURP"
        Me.CURPDataGridViewTextBoxColumn.Name = "CURPDataGridViewTextBoxColumn"
        Me.CURPDataGridViewTextBoxColumn.ReadOnly = True
        Me.CURPDataGridViewTextBoxColumn.Width = 62
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomicilioDataGridViewTextBoxColumn.Width = 74
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
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
        'NumeroMesDataGridViewTextBoxColumn
        '
        Me.NumeroMesDataGridViewTextBoxColumn.DataPropertyName = "Numero_Mes"
        Me.NumeroMesDataGridViewTextBoxColumn.HeaderText = "Numero_Mes"
        Me.NumeroMesDataGridViewTextBoxColumn.Name = "NumeroMesDataGridViewTextBoxColumn"
        Me.NumeroMesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroMesDataGridViewTextBoxColumn.Width = 95
        '
        'NumeroContratoDataGridViewTextBoxColumn
        '
        Me.NumeroContratoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Contrato"
        Me.NumeroContratoDataGridViewTextBoxColumn.HeaderText = "Numero_Contrato"
        Me.NumeroContratoDataGridViewTextBoxColumn.Name = "NumeroContratoDataGridViewTextBoxColumn"
        Me.NumeroContratoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroContratoDataGridViewTextBoxColumn.Width = 115
        '
        'TipoServicioDataGridViewTextBoxColumn
        '
        Me.TipoServicioDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Servicio"
        Me.TipoServicioDataGridViewTextBoxColumn.HeaderText = "Tipo_Servicio"
        Me.TipoServicioDataGridViewTextBoxColumn.Name = "TipoServicioDataGridViewTextBoxColumn"
        Me.TipoServicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoServicioDataGridViewTextBoxColumn.Width = 97
        '
        'NumeroMedidorDataGridViewTextBoxColumn
        '
        Me.NumeroMedidorDataGridViewTextBoxColumn.DataPropertyName = "Numero_Medidor"
        Me.NumeroMedidorDataGridViewTextBoxColumn.HeaderText = "Numero_Medidor"
        Me.NumeroMedidorDataGridViewTextBoxColumn.Name = "NumeroMedidorDataGridViewTextBoxColumn"
        Me.NumeroMedidorDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroMedidorDataGridViewTextBoxColumn.Width = 113
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UbicacionDataGridViewTextBoxColumn.Width = 80
        '
        'NumeroConsumoDataGridViewTextBoxColumn
        '
        Me.NumeroConsumoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Consumo"
        Me.NumeroConsumoDataGridViewTextBoxColumn.HeaderText = "Numero_Consumo"
        Me.NumeroConsumoDataGridViewTextBoxColumn.Name = "NumeroConsumoDataGridViewTextBoxColumn"
        Me.NumeroConsumoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroConsumoDataGridViewTextBoxColumn.Width = 119
        '
        'ConsumoBasicoDataGridViewTextBoxColumn
        '
        Me.ConsumoBasicoDataGridViewTextBoxColumn.DataPropertyName = "Consumo_Basico"
        Me.ConsumoBasicoDataGridViewTextBoxColumn.HeaderText = "Consumo_Basico"
        Me.ConsumoBasicoDataGridViewTextBoxColumn.Name = "ConsumoBasicoDataGridViewTextBoxColumn"
        Me.ConsumoBasicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConsumoBasicoDataGridViewTextBoxColumn.Width = 114
        '
        'ConsumoIntermedioDataGridViewTextBoxColumn
        '
        Me.ConsumoIntermedioDataGridViewTextBoxColumn.DataPropertyName = "Consumo_Intermedio"
        Me.ConsumoIntermedioDataGridViewTextBoxColumn.HeaderText = "Consumo_Intermedio"
        Me.ConsumoIntermedioDataGridViewTextBoxColumn.Name = "ConsumoIntermedioDataGridViewTextBoxColumn"
        Me.ConsumoIntermedioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConsumoIntermedioDataGridViewTextBoxColumn.Width = 131
        '
        'ConsumoExcedenteDataGridViewTextBoxColumn
        '
        Me.ConsumoExcedenteDataGridViewTextBoxColumn.DataPropertyName = "Consumo_Excedente"
        Me.ConsumoExcedenteDataGridViewTextBoxColumn.HeaderText = "Consumo_Excedente"
        Me.ConsumoExcedenteDataGridViewTextBoxColumn.Name = "ConsumoExcedenteDataGridViewTextBoxColumn"
        Me.ConsumoExcedenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConsumoExcedenteDataGridViewTextBoxColumn.Width = 133
        '
        'ConsumoTotalDataGridViewTextBoxColumn
        '
        Me.ConsumoTotalDataGridViewTextBoxColumn.DataPropertyName = "Consumo_Total"
        Me.ConsumoTotalDataGridViewTextBoxColumn.HeaderText = "Consumo_Total"
        Me.ConsumoTotalDataGridViewTextBoxColumn.Name = "ConsumoTotalDataGridViewTextBoxColumn"
        Me.ConsumoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConsumoTotalDataGridViewTextBoxColumn.Width = 106
        '
        'NumeroTarifaDataGridViewTextBoxColumn
        '
        Me.NumeroTarifaDataGridViewTextBoxColumn.DataPropertyName = "Numero_Tarifa"
        Me.NumeroTarifaDataGridViewTextBoxColumn.HeaderText = "Numero_Tarifa"
        Me.NumeroTarifaDataGridViewTextBoxColumn.Name = "NumeroTarifaDataGridViewTextBoxColumn"
        Me.NumeroTarifaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroTarifaDataGridViewTextBoxColumn.Width = 102
        '
        'TarifaBasicaDataGridViewTextBoxColumn
        '
        Me.TarifaBasicaDataGridViewTextBoxColumn.DataPropertyName = "Tarifa_Basica"
        Me.TarifaBasicaDataGridViewTextBoxColumn.HeaderText = "Tarifa_Basica"
        Me.TarifaBasicaDataGridViewTextBoxColumn.Name = "TarifaBasicaDataGridViewTextBoxColumn"
        Me.TarifaBasicaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TarifaBasicaDataGridViewTextBoxColumn.Width = 97
        '
        'TarifaIntermediaDataGridViewTextBoxColumn
        '
        Me.TarifaIntermediaDataGridViewTextBoxColumn.DataPropertyName = "Tarifa_Intermedia"
        Me.TarifaIntermediaDataGridViewTextBoxColumn.HeaderText = "Tarifa_Intermedia"
        Me.TarifaIntermediaDataGridViewTextBoxColumn.Name = "TarifaIntermediaDataGridViewTextBoxColumn"
        Me.TarifaIntermediaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TarifaIntermediaDataGridViewTextBoxColumn.Width = 114
        '
        'TarifaExcedenteDataGridViewTextBoxColumn
        '
        Me.TarifaExcedenteDataGridViewTextBoxColumn.DataPropertyName = "Tarifa_Excedente"
        Me.TarifaExcedenteDataGridViewTextBoxColumn.HeaderText = "Tarifa_Excedente"
        Me.TarifaExcedenteDataGridViewTextBoxColumn.Name = "TarifaExcedenteDataGridViewTextBoxColumn"
        Me.TarifaExcedenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.TarifaExcedenteDataGridViewTextBoxColumn.Width = 116
        '
        'SubtotalBasicoDataGridViewTextBoxColumn
        '
        Me.SubtotalBasicoDataGridViewTextBoxColumn.DataPropertyName = "Subtotal_Basico"
        Me.SubtotalBasicoDataGridViewTextBoxColumn.HeaderText = "Subtotal_Basico"
        Me.SubtotalBasicoDataGridViewTextBoxColumn.Name = "SubtotalBasicoDataGridViewTextBoxColumn"
        Me.SubtotalBasicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalBasicoDataGridViewTextBoxColumn.Width = 109
        '
        'SubtotalIntermedioDataGridViewTextBoxColumn
        '
        Me.SubtotalIntermedioDataGridViewTextBoxColumn.DataPropertyName = "Subtotal_Intermedio"
        Me.SubtotalIntermedioDataGridViewTextBoxColumn.HeaderText = "Subtotal_Intermedio"
        Me.SubtotalIntermedioDataGridViewTextBoxColumn.Name = "SubtotalIntermedioDataGridViewTextBoxColumn"
        Me.SubtotalIntermedioDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalIntermedioDataGridViewTextBoxColumn.Width = 126
        '
        'SubtotalExcedenteDataGridViewTextBoxColumn
        '
        Me.SubtotalExcedenteDataGridViewTextBoxColumn.DataPropertyName = "Subtotal_Excedente"
        Me.SubtotalExcedenteDataGridViewTextBoxColumn.HeaderText = "Subtotal_Excedente"
        Me.SubtotalExcedenteDataGridViewTextBoxColumn.Name = "SubtotalExcedenteDataGridViewTextBoxColumn"
        Me.SubtotalExcedenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalExcedenteDataGridViewTextBoxColumn.Width = 128
        '
        'SubtotalFinalDataGridViewTextBoxColumn
        '
        Me.SubtotalFinalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal_Final"
        Me.SubtotalFinalDataGridViewTextBoxColumn.HeaderText = "Subtotal_Final"
        Me.SubtotalFinalDataGridViewTextBoxColumn.Name = "SubtotalFinalDataGridViewTextBoxColumn"
        Me.SubtotalFinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalFinalDataGridViewTextBoxColumn.Width = 99
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        Me.IVADataGridViewTextBoxColumn.ReadOnly = True
        Me.IVADataGridViewTextBoxColumn.Width = 49
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 56
        '
        'TotalNumeroDataGridViewTextBoxColumn
        '
        Me.TotalNumeroDataGridViewTextBoxColumn.DataPropertyName = "Total_Numero"
        Me.TotalNumeroDataGridViewTextBoxColumn.HeaderText = "Total_Numero"
        Me.TotalNumeroDataGridViewTextBoxColumn.Name = "TotalNumeroDataGridViewTextBoxColumn"
        Me.TotalNumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalNumeroDataGridViewTextBoxColumn.Width = 99
        '
        'TotalNombreDataGridViewTextBoxColumn
        '
        Me.TotalNombreDataGridViewTextBoxColumn.DataPropertyName = "Total_Nombre"
        Me.TotalNombreDataGridViewTextBoxColumn.HeaderText = "Total_Nombre"
        Me.TotalNombreDataGridViewTextBoxColumn.Name = "TotalNombreDataGridViewTextBoxColumn"
        Me.TotalNombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalNombreDataGridViewTextBoxColumn.Width = 99
        '
        'FechaLimitePagoDataGridViewTextBoxColumn
        '
        Me.FechaLimitePagoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Limite_Pago"
        Me.FechaLimitePagoDataGridViewTextBoxColumn.HeaderText = "Fecha_Limite_Pago"
        Me.FechaLimitePagoDataGridViewTextBoxColumn.Name = "FechaLimitePagoDataGridViewTextBoxColumn"
        Me.FechaLimitePagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaLimitePagoDataGridViewTextBoxColumn.Width = 126
        '
        'FormaPagoDataGridViewTextBoxColumn
        '
        Me.FormaPagoDataGridViewTextBoxColumn.DataPropertyName = "Forma_Pago"
        Me.FormaPagoDataGridViewTextBoxColumn.HeaderText = "Forma_Pago"
        Me.FormaPagoDataGridViewTextBoxColumn.Name = "FormaPagoDataGridViewTextBoxColumn"
        Me.FormaPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormaPagoDataGridViewTextBoxColumn.Width = 92
        '
        'ModificadoporDataGridViewTextBoxColumn
        '
        Me.ModificadoporDataGridViewTextBoxColumn.DataPropertyName = "Modificado_por"
        Me.ModificadoporDataGridViewTextBoxColumn.HeaderText = "Modificado_por"
        Me.ModificadoporDataGridViewTextBoxColumn.Name = "ModificadoporDataGridViewTextBoxColumn"
        Me.ModificadoporDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModificadoporDataGridViewTextBoxColumn.Width = 105
        '
        'FechamodificacionDataGridViewTextBoxColumn
        '
        Me.FechamodificacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_modificacion"
        Me.FechamodificacionDataGridViewTextBoxColumn.HeaderText = "Fecha_modificacion"
        Me.FechamodificacionDataGridViewTextBoxColumn.Name = "FechamodificacionDataGridViewTextBoxColumn"
        Me.FechamodificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechamodificacionDataGridViewTextBoxColumn.Width = 127
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 65
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(27, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(207, 28)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "Generar Recibos"
        '
        'btnCerrarFormulario
        '
        Me.btnCerrarFormulario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarFormulario.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Close
        Me.btnCerrarFormulario.Location = New System.Drawing.Point(748, 21)
        Me.btnCerrarFormulario.Name = "btnCerrarFormulario"
        Me.btnCerrarFormulario.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarFormulario.TabIndex = 161
        Me.btnCerrarFormulario.TabStop = False
        '
        'FormAbcRcb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 564)
        Me.Controls.Add(Me.btnCerrarFormulario)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GenRcbDataViewGrid)
        Me.Controls.Add(Me.btnGenerarRcb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbMes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAbcRcb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Recibos"
        CType(Me.GenRcbDataViewGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tabla_Rcb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllReceiptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents cbMes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerarRcb As Button
    Friend WithEvents GenRcbDataViewGrid As DataGridView
    Friend WithEvents DS_Tabla_Rcb As DS_Tabla_Rcb
    Friend WithEvents AllReceiptsBindingSource As BindingSource
    Friend WithEvents All_ReceiptsTableAdapter As DS_Tabla_RcbTableAdapters.All_ReceiptsTableAdapter
    Friend WithEvents NumeroReciboDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CURPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroMesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroMedidorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroConsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsumoBasicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsumoIntermedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsumoExcedenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsumoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroTarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifaBasicaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifaIntermediaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifaExcedenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalBasicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalIntermedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalExcedenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalFinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalNumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaLimitePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModificadoporDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechamodificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label16 As Label
    Friend WithEvents btnCerrarFormulario As PictureBox
End Class

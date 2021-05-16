<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCambiarContra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.txtBPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónTarifasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónConsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsumoHistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeReciboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonLogin
        '
        Me.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonLogin.Location = New System.Drawing.Point(119, 260)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(133, 32)
        Me.buttonLogin.TabIndex = 11
        Me.buttonLogin.Text = "Cambiar contraseña"
        Me.buttonLogin.UseVisualStyleBackColor = True
        '
        'txtBPass
        '
        Me.txtBPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBPass.Location = New System.Drawing.Point(84, 161)
        Me.txtBPass.Name = "txtBPass"
        Me.txtBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBPass.Size = New System.Drawing.Size(198, 20)
        Me.txtBPass.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Khaki
        Me.Label2.Location = New System.Drawing.Point(133, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña nueva"
        '
        'txtBUser
        '
        Me.txtBUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBUser.Location = New System.Drawing.Point(84, 95)
        Me.txtBUser.Name = "txtBUser"
        Me.txtBUser.Size = New System.Drawing.Size(198, 20)
        Me.txtBUser.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Khaki
        Me.Label1.Location = New System.Drawing.Point(126, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Contraseña antigua"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(370, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.GestiónTarifasToolStripMenuItem, Me.GestiónConsumosToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'GestiónTarifasToolStripMenuItem
        '
        Me.GestiónTarifasToolStripMenuItem.Name = "GestiónTarifasToolStripMenuItem"
        Me.GestiónTarifasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GestiónTarifasToolStripMenuItem.Text = "Gestión Tarifas"
        '
        'GestiónConsumosToolStripMenuItem
        '
        Me.GestiónConsumosToolStripMenuItem.Name = "GestiónConsumosToolStripMenuItem"
        Me.GestiónConsumosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GestiónConsumosToolStripMenuItem.Text = "Gestión Consumos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.ConsumoHistóricoToolStripMenuItem, Me.ConsultaDeReciboToolStripMenuItem, Me.TarifasToolStripMenuItem, Me.ConsumosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'ConsumoHistóricoToolStripMenuItem
        '
        Me.ConsumoHistóricoToolStripMenuItem.Name = "ConsumoHistóricoToolStripMenuItem"
        Me.ConsumoHistóricoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ConsumoHistóricoToolStripMenuItem.Text = "Consumo histórico"
        '
        'ConsultaDeReciboToolStripMenuItem
        '
        Me.ConsultaDeReciboToolStripMenuItem.Name = "ConsultaDeReciboToolStripMenuItem"
        Me.ConsultaDeReciboToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ConsultaDeReciboToolStripMenuItem.Text = "Recibos"
        '
        'TarifasToolStripMenuItem
        '
        Me.TarifasToolStripMenuItem.Name = "TarifasToolStripMenuItem"
        Me.TarifasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TarifasToolStripMenuItem.Text = "Tarifas"
        '
        'ConsumosToolStripMenuItem
        '
        Me.ConsumosToolStripMenuItem.Name = "ConsumosToolStripMenuItem"
        Me.ConsumosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ConsumosToolStripMenuItem.Text = "Consumos"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarContraseñaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem1})
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cuenta"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña"
        '
        'CerrarSesiónToolStripMenuItem1
        '
        Me.CerrarSesiónToolStripMenuItem1.Name = "CerrarSesiónToolStripMenuItem1"
        Me.CerrarSesiónToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesiónToolStripMenuItem1.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(84, 211)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(198, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Khaki
        Me.Label3.Location = New System.Drawing.Point(160, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Confirmar"
        '
        'FormCambiarContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(370, 355)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.txtBPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCambiarContra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar contraseña"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonLogin As Button
    Friend WithEvents txtBPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónTarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónConsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumoHistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeReciboToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGeneral
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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
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
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'GestiónTarifasToolStripMenuItem
        '
        Me.GestiónTarifasToolStripMenuItem.Name = "GestiónTarifasToolStripMenuItem"
        Me.GestiónTarifasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestiónTarifasToolStripMenuItem.Text = "Gestión Tarifas"
        '
        'GestiónConsumosToolStripMenuItem
        '
        Me.GestiónConsumosToolStripMenuItem.Name = "GestiónConsumosToolStripMenuItem"
        Me.GestiónConsumosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'ConsumoHistóricoToolStripMenuItem
        '
        Me.ConsumoHistóricoToolStripMenuItem.Name = "ConsumoHistóricoToolStripMenuItem"
        Me.ConsumoHistóricoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsumoHistóricoToolStripMenuItem.Text = "Consumo histórico"
        '
        'ConsultaDeReciboToolStripMenuItem
        '
        Me.ConsultaDeReciboToolStripMenuItem.Name = "ConsultaDeReciboToolStripMenuItem"
        Me.ConsultaDeReciboToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultaDeReciboToolStripMenuItem.Text = "Recibos"
        '
        'TarifasToolStripMenuItem
        '
        Me.TarifasToolStripMenuItem.Name = "TarifasToolStripMenuItem"
        Me.TarifasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TarifasToolStripMenuItem.Text = "Tarifas"
        '
        'ConsumosToolStripMenuItem
        '
        Me.ConsumosToolStripMenuItem.Name = "ConsumosToolStripMenuItem"
        Me.ConsumosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        'FormGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PIA_MAD___ScdChnc.My.Resources.Resources.alexey_shirokikh_landscape06_05
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¡Bienvenido!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumoHistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeReciboToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónTarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónConsumosToolStripMenuItem As ToolStripMenuItem
End Class

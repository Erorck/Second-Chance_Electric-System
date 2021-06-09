<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBUser = New System.Windows.Forms.TextBox()
        Me.txtBPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.checkBRemeber = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbMsg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label1.Location = New System.Drawing.Point(465, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'txtBUser
        '
        Me.txtBUser.Location = New System.Drawing.Point(392, 195)
        Me.txtBUser.MaxLength = 6
        Me.txtBUser.Name = "txtBUser"
        Me.txtBUser.Size = New System.Drawing.Size(198, 20)
        Me.txtBUser.TabIndex = 1
        Me.txtBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBPass
        '
        Me.txtBPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBPass.Location = New System.Drawing.Point(392, 261)
        Me.txtBPass.MaxLength = 20
        Me.txtBPass.Name = "txtBPass"
        Me.txtBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBPass.Size = New System.Drawing.Size(198, 20)
        Me.txtBPass.TabIndex = 3
        Me.txtBPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label2.Location = New System.Drawing.Point(455, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'buttonLogin
        '
        Me.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonLogin.Location = New System.Drawing.Point(392, 355)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(89, 32)
        Me.buttonLogin.TabIndex = 4
        Me.buttonLogin.Text = "Ingresar"
        Me.buttonLogin.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonExit.AutoSize = True
        Me.buttonExit.Location = New System.Drawing.Point(510, 355)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(89, 32)
        Me.buttonExit.TabIndex = 5
        Me.buttonExit.Text = "Salir"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'checkBRemeber
        '
        Me.checkBRemeber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.checkBRemeber.AutoSize = True
        Me.checkBRemeber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBRemeber.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.checkBRemeber.Location = New System.Drawing.Point(447, 311)
        Me.checkBRemeber.Name = "checkBRemeber"
        Me.checkBRemeber.Size = New System.Drawing.Size(97, 17)
        Me.checkBRemeber.TabIndex = 6
        Me.checkBRemeber.Text = "Remeber Me"
        Me.checkBRemeber.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Logo_ScdChnc
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 480)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 480)
        Me.Panel1.TabIndex = 8
        '
        'cbTipoUsuario
        '
        Me.cbTipoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoUsuario.FormattingEnabled = True
        Me.cbTipoUsuario.Items.AddRange(New Object() {"A - ACTIVO", "S - SUSPENDIDO", "E - ELIMINADO"})
        Me.cbTipoUsuario.Location = New System.Drawing.Point(432, 100)
        Me.cbTipoUsuario.Name = "cbTipoUsuario"
        Me.cbTipoUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoUsuario.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label3.Location = New System.Drawing.Point(440, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "¿Usted es un?"
        '
        'lbMsg
        '
        Me.lbMsg.AutoSize = True
        Me.lbMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMsg.ForeColor = System.Drawing.Color.Gold
        Me.lbMsg.Location = New System.Drawing.Point(315, 403)
        Me.lbMsg.Name = "lbMsg"
        Me.lbMsg.Size = New System.Drawing.Size(31, 15)
        Me.lbMsg.TabIndex = 93
        Me.lbMsg.Text = "Msg"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 480)
        Me.Controls.Add(Me.lbMsg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTipoUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.checkBRemeber)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.txtBPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBUser)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBUser As TextBox
    Friend WithEvents txtBPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonLogin As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents checkBRemeber As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbTipoUsuario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbMsg As Label
End Class

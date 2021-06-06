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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Khaki
        Me.Label1.Location = New System.Drawing.Point(482, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'txtBUser
        '
        Me.txtBUser.Location = New System.Drawing.Point(409, 138)
        Me.txtBUser.MaxLength = 6
        Me.txtBUser.Name = "txtBUser"
        Me.txtBUser.Size = New System.Drawing.Size(198, 20)
        Me.txtBUser.TabIndex = 1
        Me.txtBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBPass
        '
        Me.txtBPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBPass.Location = New System.Drawing.Point(409, 204)
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
        Me.Label2.ForeColor = System.Drawing.Color.Khaki
        Me.Label2.Location = New System.Drawing.Point(472, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'buttonLogin
        '
        Me.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonLogin.Location = New System.Drawing.Point(409, 298)
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
        Me.buttonExit.Location = New System.Drawing.Point(527, 298)
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
        Me.checkBRemeber.Location = New System.Drawing.Point(464, 254)
        Me.checkBRemeber.Name = "checkBRemeber"
        Me.checkBRemeber.Size = New System.Drawing.Size(97, 17)
        Me.checkBRemeber.TabIndex = 6
        Me.checkBRemeber.Text = "Remeber Me"
        Me.checkBRemeber.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PIA_MAD___ScdChnc.My.Resources.Resources.Logo_ScdChnc
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 543)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 480)
        Me.Controls.Add(Me.PictureBox1)
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
End Class

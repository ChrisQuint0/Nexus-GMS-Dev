<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblForgotPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.checkBShowPass = New System.Windows.Forms.CheckBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.picLogInFormBg = New System.Windows.Forms.PictureBox()
        CType(Me.picLogInFormBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.AutoSize = True
        Me.lblForgotPassword.BackColor = System.Drawing.Color.White
        Me.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPassword.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblForgotPassword.Location = New System.Drawing.Point(984, 688)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(123, 18)
        Me.lblForgotPassword.TabIndex = 2
        Me.lblForgotPassword.Text = "Forgot Password?"
        '
        'txtUsername
        '
        Me.txtUsername.AutoCompleteCustomSource.AddRange(New String() {"Rodolfo", "Chris"})
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Control
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUsername.Location = New System.Drawing.Point(887, 344)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(395, 44)
        Me.txtUsername.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.AutoCompleteCustomSource.AddRange(New String() {"pass", "passprof"})
        Me.txtPass.BackColor = System.Drawing.SystemColors.Control
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPass.Location = New System.Drawing.Point(887, 471)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(395, 45)
        Me.txtPass.TabIndex = 4
        '
        'checkBShowPass
        '
        Me.checkBShowPass.AutoSize = True
        Me.checkBShowPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkBShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBShowPass.Location = New System.Drawing.Point(822, 556)
        Me.checkBShowPass.Name = "checkBShowPass"
        Me.checkBShowPass.Size = New System.Drawing.Size(15, 14)
        Me.checkBShowPass.TabIndex = 5
        Me.checkBShowPass.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.logInButton
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Location = New System.Drawing.Point(914, 602)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(266, 64)
        Me.btnLogIn.TabIndex = 1
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'picLogInFormBg
        '
        Me.picLogInFormBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.logInFormBg
        Me.picLogInFormBg.Location = New System.Drawing.Point(0, 0)
        Me.picLogInFormBg.Name = "picLogInFormBg"
        Me.picLogInFormBg.Size = New System.Drawing.Size(1536, 864)
        Me.picLogInFormBg.TabIndex = 0
        Me.picLogInFormBg.TabStop = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 825)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.checkBShowPass)
        Me.Controls.Add(Me.lblForgotPassword)
        Me.Controls.Add(Me.picLogInFormBg)
        Me.IsMdiContainer = True
        Me.Name = "mainForm"
        Me.Text = "Nexus GMS"
        CType(Me.picLogInFormBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogInFormBg As PictureBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblForgotPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents checkBShowPass As CheckBox
End Class

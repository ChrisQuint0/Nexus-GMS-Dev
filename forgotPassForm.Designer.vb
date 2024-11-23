<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotPassForm
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
        Me.picForgotPassBg = New System.Windows.Forms.PictureBox()
        Me.btnCancelPass = New System.Windows.Forms.Button()
        Me.btnSubmitPass = New System.Windows.Forms.Button()
        CType(Me.picForgotPassBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picForgotPassBg
        '
        Me.picForgotPassBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.resetPassForm
        Me.picForgotPassBg.Location = New System.Drawing.Point(0, 0)
        Me.picForgotPassBg.Name = "picForgotPassBg"
        Me.picForgotPassBg.Size = New System.Drawing.Size(1536, 864)
        Me.picForgotPassBg.TabIndex = 0
        Me.picForgotPassBg.TabStop = False
        '
        'btnCancelPass
        '
        Me.btnCancelPass.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelPass.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.cancelButtonPass
        Me.btnCancelPass.FlatAppearance.BorderSize = 0
        Me.btnCancelPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPass.Location = New System.Drawing.Point(667, 565)
        Me.btnCancelPass.Name = "btnCancelPass"
        Me.btnCancelPass.Size = New System.Drawing.Size(152, 49)
        Me.btnCancelPass.TabIndex = 1
        Me.btnCancelPass.UseVisualStyleBackColor = False
        '
        'btnSubmitPass
        '
        Me.btnSubmitPass.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmitPass.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.submitButtonPass
        Me.btnSubmitPass.FlatAppearance.BorderSize = 0
        Me.btnSubmitPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitPass.Location = New System.Drawing.Point(825, 565)
        Me.btnSubmitPass.Name = "btnSubmitPass"
        Me.btnSubmitPass.Size = New System.Drawing.Size(152, 49)
        Me.btnSubmitPass.TabIndex = 2
        Me.btnSubmitPass.UseVisualStyleBackColor = False
        '
        'forgotPassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.resetPassForm
        Me.ClientSize = New System.Drawing.Size(1520, 825)
        Me.Controls.Add(Me.btnSubmitPass)
        Me.Controls.Add(Me.btnCancelPass)
        Me.Controls.Add(Me.picForgotPassBg)
        Me.Name = "forgotPassForm"
        Me.Text = "forgotPassForm"
        CType(Me.picForgotPassBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picForgotPassBg As PictureBox
    Friend WithEvents btnCancelPass As Button
    Friend WithEvents btnSubmitPass As Button
End Class

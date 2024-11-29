<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Me.picAdminFormBg = New System.Windows.Forms.PictureBox()
        Me.lblWelcomeStud = New System.Windows.Forms.Label()
        Me.btnLogoutAdmin = New System.Windows.Forms.Button()
        Me.btnEncodeAdminCard = New System.Windows.Forms.Button()
        Me.btnAssignAdminCard = New System.Windows.Forms.Button()
        Me.btnEncodeAdmin = New System.Windows.Forms.Button()
        Me.btnAssignProf = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.picAdminFormBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAdminFormBg
        '
        Me.picAdminFormBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.adminForm
        Me.picAdminFormBg.Location = New System.Drawing.Point(0, 0)
        Me.picAdminFormBg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picAdminFormBg.Name = "picAdminFormBg"
        Me.picAdminFormBg.Size = New System.Drawing.Size(2048, 1063)
        Me.picAdminFormBg.TabIndex = 0
        Me.picAdminFormBg.TabStop = False
        '
        'lblWelcomeStud
        '
        Me.lblWelcomeStud.AutoSize = True
        Me.lblWelcomeStud.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcomeStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeStud.Location = New System.Drawing.Point(276, 166)
        Me.lblWelcomeStud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcomeStud.Name = "lblWelcomeStud"
        Me.lblWelcomeStud.Size = New System.Drawing.Size(448, 69)
        Me.lblWelcomeStud.TabIndex = 3
        Me.lblWelcomeStud.Text = "Welcome Fred,"
        '
        'btnLogoutAdmin
        '
        Me.btnLogoutAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogoutAdmin.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.logoutButton
        Me.btnLogoutAdmin.FlatAppearance.BorderSize = 0
        Me.btnLogoutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutAdmin.Location = New System.Drawing.Point(1448, 218)
        Me.btnLogoutAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogoutAdmin.Name = "btnLogoutAdmin"
        Me.btnLogoutAdmin.Size = New System.Drawing.Size(325, 57)
        Me.btnLogoutAdmin.TabIndex = 4
        Me.btnLogoutAdmin.UseVisualStyleBackColor = False
        '
        'btnEncodeAdminCard
        '
        Me.btnEncodeAdminCard.BackColor = System.Drawing.Color.Transparent
        Me.btnEncodeAdminCard.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.encodeIcon
        Me.btnEncodeAdminCard.FlatAppearance.BorderSize = 0
        Me.btnEncodeAdminCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncodeAdminCard.Location = New System.Drawing.Point(275, 620)
        Me.btnEncodeAdminCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEncodeAdminCard.Name = "btnEncodeAdminCard"
        Me.btnEncodeAdminCard.Size = New System.Drawing.Size(455, 217)
        Me.btnEncodeAdminCard.TabIndex = 5
        Me.btnEncodeAdminCard.UseVisualStyleBackColor = False
        '
        'btnAssignAdminCard
        '
        Me.btnAssignAdminCard.BackColor = System.Drawing.Color.Transparent
        Me.btnAssignAdminCard.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignIcon
        Me.btnAssignAdminCard.FlatAppearance.BorderSize = 0
        Me.btnAssignAdminCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignAdminCard.Location = New System.Drawing.Point(765, 620)
        Me.btnAssignAdminCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAssignAdminCard.Name = "btnAssignAdminCard"
        Me.btnAssignAdminCard.Size = New System.Drawing.Size(449, 217)
        Me.btnAssignAdminCard.TabIndex = 6
        Me.btnAssignAdminCard.UseVisualStyleBackColor = False
        '
        'btnEncodeAdmin
        '
        Me.btnEncodeAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnEncodeAdmin.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.encodeAdminButton
        Me.btnEncodeAdmin.FlatAppearance.BorderSize = 0
        Me.btnEncodeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncodeAdmin.Location = New System.Drawing.Point(275, 862)
        Me.btnEncodeAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEncodeAdmin.Name = "btnEncodeAdmin"
        Me.btnEncodeAdmin.Size = New System.Drawing.Size(455, 57)
        Me.btnEncodeAdmin.TabIndex = 7
        Me.btnEncodeAdmin.UseVisualStyleBackColor = False
        '
        'btnAssignProf
        '
        Me.btnAssignProf.BackColor = System.Drawing.Color.Transparent
        Me.btnAssignProf.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignProfButton
        Me.btnAssignProf.FlatAppearance.BorderSize = 0
        Me.btnAssignProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignProf.Location = New System.Drawing.Point(765, 862)
        Me.btnAssignProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAssignProf.Name = "btnAssignProf"
        Me.btnAssignProf.Size = New System.Drawing.Size(455, 57)
        Me.btnAssignProf.TabIndex = 8
        Me.btnAssignProf.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(1259, 591)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 9
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.adminForm
        Me.ClientSize = New System.Drawing.Size(1924, 1040)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnAssignProf)
        Me.Controls.Add(Me.btnEncodeAdmin)
        Me.Controls.Add(Me.btnAssignAdminCard)
        Me.Controls.Add(Me.btnEncodeAdminCard)
        Me.Controls.Add(Me.btnLogoutAdmin)
        Me.Controls.Add(Me.lblWelcomeStud)
        Me.Controls.Add(Me.picAdminFormBg)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "adminForm"
        Me.Text = "adminForm"
        CType(Me.picAdminFormBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAdminFormBg As PictureBox
    Friend WithEvents lblWelcomeStud As Label
    Friend WithEvents btnLogoutAdmin As Button
    Friend WithEvents btnEncodeAdminCard As Button
    Friend WithEvents btnAssignAdminCard As Button
    Friend WithEvents btnEncodeAdmin As Button
    Friend WithEvents btnAssignProf As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class

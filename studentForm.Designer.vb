<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentForm
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
        Me.picStudFormBg = New System.Windows.Forms.PictureBox()
        Me.lblWelcomeStud = New System.Windows.Forms.Label()
        Me.lblStudId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datagridGradeReport = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.picStudFormBg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridGradeReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStudFormBg
        '
        Me.picStudFormBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.studentFormBg
        Me.picStudFormBg.Location = New System.Drawing.Point(0, 0)
        Me.picStudFormBg.Name = "picStudFormBg"
        Me.picStudFormBg.Size = New System.Drawing.Size(1536, 864)
        Me.picStudFormBg.TabIndex = 1
        Me.picStudFormBg.TabStop = False
        '
        'lblWelcomeStud
        '
        Me.lblWelcomeStud.AutoSize = True
        Me.lblWelcomeStud.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcomeStud.Font = New System.Drawing.Font("Montserrat", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeStud.Location = New System.Drawing.Point(185, 106)
        Me.lblWelcomeStud.Name = "lblWelcomeStud"
        Me.lblWelcomeStud.Size = New System.Drawing.Size(413, 66)
        Me.lblWelcomeStud.TabIndex = 2
        Me.lblWelcomeStud.Text = "Welcome Juan,"
        '
        'lblStudId
        '
        Me.lblStudId.AutoSize = True
        Me.lblStudId.BackColor = System.Drawing.Color.Transparent
        Me.lblStudId.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudId.Location = New System.Drawing.Point(327, 419)
        Me.lblStudId.Name = "lblStudId"
        Me.lblStudId.Size = New System.Drawing.Size(122, 33)
        Me.lblStudId.TabIndex = 3
        Me.lblStudId.Text = "23-00163"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(366, 461)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(236, 33)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "DELA CRUZ, JUAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 505)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BSIT - 2A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1020, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "2024 - 2025 | 1st Sem"
        '
        'datagridGradeReport
        '
        Me.datagridGradeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridGradeReport.Location = New System.Drawing.Point(210, 581)
        Me.datagridGradeReport.Name = "datagridGradeReport"
        Me.datagridGradeReport.Size = New System.Drawing.Size(1083, 209)
        Me.datagridGradeReport.TabIndex = 7
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.logoutButton
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(1073, 153)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(245, 46)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'studentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.studentFormBg
        Me.ClientSize = New System.Drawing.Size(1520, 825)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.datagridGradeReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblStudId)
        Me.Controls.Add(Me.lblWelcomeStud)
        Me.Controls.Add(Me.picStudFormBg)
        Me.Name = "studentForm"
        Me.Text = "studentForm"
        CType(Me.picStudFormBg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridGradeReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picStudFormBg As PictureBox
    Friend WithEvents lblWelcomeStud As Label
    Friend WithEvents lblStudId As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents datagridGradeReport As DataGridView
    Friend WithEvents btnLogout As Button
End Class

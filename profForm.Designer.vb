<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class profForm
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
        Me.picProfFormBg = New System.Windows.Forms.PictureBox()
        Me.lblWelcomeStud = New System.Windows.Forms.Label()
        Me.comboProfCourse = New System.Windows.Forms.ComboBox()
        Me.btnLogoutProf = New System.Windows.Forms.Button()
        Me.lblFacultyID = New System.Windows.Forms.Label()
        Me.lblFacultyName = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblAcadYear = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.calProf = New System.Windows.Forms.MonthCalendar()
        Me.btnEncodeGrades = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        CType(Me.picProfFormBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picProfFormBg
        '
        Me.picProfFormBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.profFormBg1
        Me.picProfFormBg.Location = New System.Drawing.Point(0, 0)
        Me.picProfFormBg.Name = "picProfFormBg"
        Me.picProfFormBg.Size = New System.Drawing.Size(1536, 864)
        Me.picProfFormBg.TabIndex = 0
        Me.picProfFormBg.TabStop = False
        '
        'lblWelcomeStud
        '
        Me.lblWelcomeStud.AutoSize = True
        Me.lblWelcomeStud.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcomeStud.Font = New System.Drawing.Font("Montserrat", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeStud.Location = New System.Drawing.Point(189, 105)
        Me.lblWelcomeStud.Name = "lblWelcomeStud"
        Me.lblWelcomeStud.Size = New System.Drawing.Size(485, 66)
        Me.lblWelcomeStud.TabIndex = 3
        Me.lblWelcomeStud.Text = "Welcome Rodolfo,"
        '
        'comboProfCourse
        '
        Me.comboProfCourse.BackColor = System.Drawing.Color.White
        Me.comboProfCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProfCourse.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProfCourse.FormattingEnabled = True
        Me.comboProfCourse.Items.AddRange(New Object() {"Object Oriented Programming"})
        Me.comboProfCourse.Location = New System.Drawing.Point(215, 421)
        Me.comboProfCourse.Name = "comboProfCourse"
        Me.comboProfCourse.Size = New System.Drawing.Size(669, 45)
        Me.comboProfCourse.TabIndex = 4
        '
        'btnLogoutProf
        '
        Me.btnLogoutProf.BackColor = System.Drawing.Color.Transparent
        Me.btnLogoutProf.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.logoutButton
        Me.btnLogoutProf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogoutProf.FlatAppearance.BorderSize = 0
        Me.btnLogoutProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutProf.Location = New System.Drawing.Point(1072, 150)
        Me.btnLogoutProf.Name = "btnLogoutProf"
        Me.btnLogoutProf.Size = New System.Drawing.Size(251, 43)
        Me.btnLogoutProf.TabIndex = 5
        Me.btnLogoutProf.UseVisualStyleBackColor = False
        '
        'lblFacultyID
        '
        Me.lblFacultyID.AutoSize = True
        Me.lblFacultyID.BackColor = System.Drawing.Color.Transparent
        Me.lblFacultyID.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultyID.ForeColor = System.Drawing.Color.White
        Me.lblFacultyID.Location = New System.Drawing.Point(430, 545)
        Me.lblFacultyID.Name = "lblFacultyID"
        Me.lblFacultyID.Size = New System.Drawing.Size(210, 29)
        Me.lblFacultyID.TabIndex = 6
        Me.lblFacultyID.Text = "321343243231-3234"
        '
        'lblFacultyName
        '
        Me.lblFacultyName.AutoSize = True
        Me.lblFacultyName.BackColor = System.Drawing.Color.Transparent
        Me.lblFacultyName.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultyName.ForeColor = System.Drawing.Color.White
        Me.lblFacultyName.Location = New System.Drawing.Point(430, 588)
        Me.lblFacultyName.Name = "lblFacultyName"
        Me.lblFacultyName.Size = New System.Drawing.Size(207, 29)
        Me.lblFacultyName.TabIndex = 7
        Me.lblFacultyName.Text = "Rodolfo Mirabel Jr."
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.White
        Me.lblDepartment.Location = New System.Drawing.Point(433, 628)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(316, 29)
        Me.lblDepartment.TabIndex = 8
        Me.lblDepartment.Text = "College of Computer Studies"
        '
        'lblAcadYear
        '
        Me.lblAcadYear.AutoSize = True
        Me.lblAcadYear.BackColor = System.Drawing.Color.Transparent
        Me.lblAcadYear.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcadYear.ForeColor = System.Drawing.Color.White
        Me.lblAcadYear.Location = New System.Drawing.Point(433, 668)
        Me.lblAcadYear.Name = "lblAcadYear"
        Me.lblAcadYear.Size = New System.Drawing.Size(154, 29)
        Me.lblAcadYear.TabIndex = 9
        Me.lblAcadYear.Text = "SY 2024-2025"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.editButton
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(191, 765)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 43)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'calProf
        '
        Me.calProf.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calProf.Location = New System.Drawing.Point(1031, 410)
        Me.calProf.Name = "calProf"
        Me.calProf.TabIndex = 11
        '
        'btnEncodeGrades
        '
        Me.btnEncodeGrades.BackColor = System.Drawing.Color.Transparent
        Me.btnEncodeGrades.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.encodeButton
        Me.btnEncodeGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEncodeGrades.FlatAppearance.BorderSize = 0
        Me.btnEncodeGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncodeGrades.Location = New System.Drawing.Point(968, 628)
        Me.btnEncodeGrades.Name = "btnEncodeGrades"
        Me.btnEncodeGrades.Size = New System.Drawing.Size(355, 43)
        Me.btnEncodeGrades.TabIndex = 12
        Me.btnEncodeGrades.UseVisualStyleBackColor = False
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerateReport.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.generateRButton
        Me.btnGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGenerateReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.Location = New System.Drawing.Point(968, 677)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(355, 43)
        Me.btnGenerateReport.TabIndex = 13
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'profForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.profFormBg1
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnEncodeGrades)
        Me.Controls.Add(Me.calProf)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblAcadYear)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblFacultyName)
        Me.Controls.Add(Me.lblFacultyID)
        Me.Controls.Add(Me.btnLogoutProf)
        Me.Controls.Add(Me.comboProfCourse)
        Me.Controls.Add(Me.lblWelcomeStud)
        Me.Controls.Add(Me.picProfFormBg)
        Me.Name = "profForm"
        Me.Text = "profForm"
        CType(Me.picProfFormBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfFormBg As PictureBox
    Friend WithEvents lblWelcomeStud As Label
    Friend WithEvents comboProfCourse As ComboBox
    Friend WithEvents btnLogoutProf As Button
    Friend WithEvents lblFacultyID As Label
    Friend WithEvents lblFacultyName As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblAcadYear As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents calProf As MonthCalendar
    Friend WithEvents btnEncodeGrades As Button
    Friend WithEvents btnGenerateReport As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageData
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
        Me.picManageDataBg = New System.Windows.Forms.PictureBox()
        Me.dataGVUsers = New System.Windows.Forms.DataGridView()
        Me.dataGVStudents = New System.Windows.Forms.DataGridView()
        Me.dataGVProfs = New System.Windows.Forms.DataGridView()
        Me.dataGVCourses = New System.Windows.Forms.DataGridView()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.btnDeleteProf = New System.Windows.Forms.Button()
        Me.btnDeleteCourse = New System.Windows.Forms.Button()
        Me.lblProfDataID = New System.Windows.Forms.Label()
        Me.txtProfDataID = New System.Windows.Forms.TextBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudDataID = New System.Windows.Forms.TextBox()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        CType(Me.picManageDataBg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGVUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGVStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGVProfs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGVCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picManageDataBg
        '
        Me.picManageDataBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.manageDataBackground
        Me.picManageDataBg.Location = New System.Drawing.Point(0, 0)
        Me.picManageDataBg.Name = "picManageDataBg"
        Me.picManageDataBg.Size = New System.Drawing.Size(1538, 884)
        Me.picManageDataBg.TabIndex = 0
        Me.picManageDataBg.TabStop = False
        '
        'dataGVUsers
        '
        Me.dataGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVUsers.Location = New System.Drawing.Point(124, 135)
        Me.dataGVUsers.Name = "dataGVUsers"
        Me.dataGVUsers.Size = New System.Drawing.Size(575, 234)
        Me.dataGVUsers.TabIndex = 1
        '
        'dataGVStudents
        '
        Me.dataGVStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVStudents.Location = New System.Drawing.Point(781, 135)
        Me.dataGVStudents.Name = "dataGVStudents"
        Me.dataGVStudents.Size = New System.Drawing.Size(575, 234)
        Me.dataGVStudents.TabIndex = 2
        '
        'dataGVProfs
        '
        Me.dataGVProfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVProfs.Location = New System.Drawing.Point(124, 509)
        Me.dataGVProfs.Name = "dataGVProfs"
        Me.dataGVProfs.Size = New System.Drawing.Size(575, 234)
        Me.dataGVProfs.TabIndex = 3
        '
        'dataGVCourses
        '
        Me.dataGVCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVCourses.Location = New System.Drawing.Point(781, 509)
        Me.dataGVCourses.Name = "dataGVCourses"
        Me.dataGVCourses.Size = New System.Drawing.Size(575, 234)
        Me.dataGVCourses.TabIndex = 4
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(200, 397)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(225, 27)
        Me.txtUserID.TabIndex = 5
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(120, 400)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(70, 22)
        Me.lblUserID.TabIndex = 6
        Me.lblUserID.Text = "User ID"
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteUser.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeleteUser.FlatAppearance.BorderSize = 0
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Location = New System.Drawing.Point(548, 391)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(160, 45)
        Me.btnDeleteUser.TabIndex = 7
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteStudent.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeleteStudent.FlatAppearance.BorderSize = 0
        Me.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteStudent.Location = New System.Drawing.Point(1196, 391)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(160, 45)
        Me.btnDeleteStudent.TabIndex = 8
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'btnDeleteProf
        '
        Me.btnDeleteProf.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteProf.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeleteProf.FlatAppearance.BorderSize = 0
        Me.btnDeleteProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteProf.Location = New System.Drawing.Point(548, 764)
        Me.btnDeleteProf.Name = "btnDeleteProf"
        Me.btnDeleteProf.Size = New System.Drawing.Size(160, 45)
        Me.btnDeleteProf.TabIndex = 9
        Me.btnDeleteProf.UseVisualStyleBackColor = False
        '
        'btnDeleteCourse
        '
        Me.btnDeleteCourse.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteCourse.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeleteCourse.FlatAppearance.BorderSize = 0
        Me.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCourse.Location = New System.Drawing.Point(1196, 764)
        Me.btnDeleteCourse.Name = "btnDeleteCourse"
        Me.btnDeleteCourse.Size = New System.Drawing.Size(160, 45)
        Me.btnDeleteCourse.TabIndex = 10
        Me.btnDeleteCourse.UseVisualStyleBackColor = False
        '
        'lblProfDataID
        '
        Me.lblProfDataID.AutoSize = True
        Me.lblProfDataID.BackColor = System.Drawing.Color.Transparent
        Me.lblProfDataID.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfDataID.Location = New System.Drawing.Point(129, 773)
        Me.lblProfDataID.Name = "lblProfDataID"
        Me.lblProfDataID.Size = New System.Drawing.Size(111, 22)
        Me.lblProfDataID.TabIndex = 12
        Me.lblProfDataID.Text = "Prof Data ID"
        '
        'txtProfDataID
        '
        Me.txtProfDataID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfDataID.Location = New System.Drawing.Point(247, 770)
        Me.txtProfDataID.Name = "txtProfDataID"
        Me.txtProfDataID.Size = New System.Drawing.Size(225, 27)
        Me.txtProfDataID.TabIndex = 11
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(777, 400)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(143, 22)
        Me.lblStudentID.TabIndex = 14
        Me.lblStudentID.Text = "Student Data ID"
        '
        'txtStudDataID
        '
        Me.txtStudDataID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudDataID.Location = New System.Drawing.Point(924, 397)
        Me.txtStudDataID.Name = "txtStudDataID"
        Me.txtStudDataID.Size = New System.Drawing.Size(225, 27)
        Me.txtStudDataID.TabIndex = 13
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseID.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.Location = New System.Drawing.Point(777, 776)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(90, 22)
        Me.lblCourseID.TabIndex = 16
        Me.lblCourseID.Text = "Course ID"
        '
        'txtCourseID
        '
        Me.txtCourseID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(885, 773)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(225, 27)
        Me.txtCourseID.TabIndex = 15
        '
        'manageData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.manageDataBackground
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.lblCourseID)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.txtStudDataID)
        Me.Controls.Add(Me.lblProfDataID)
        Me.Controls.Add(Me.txtProfDataID)
        Me.Controls.Add(Me.btnDeleteCourse)
        Me.Controls.Add(Me.btnDeleteProf)
        Me.Controls.Add(Me.btnDeleteStudent)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.dataGVCourses)
        Me.Controls.Add(Me.dataGVProfs)
        Me.Controls.Add(Me.dataGVStudents)
        Me.Controls.Add(Me.dataGVUsers)
        Me.Controls.Add(Me.picManageDataBg)
        Me.Name = "manageData"
        Me.Text = "manageData"
        CType(Me.picManageDataBg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGVUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGVStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGVProfs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGVCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picManageDataBg As PictureBox
    Friend WithEvents dataGVUsers As DataGridView
    Friend WithEvents dataGVStudents As DataGridView
    Friend WithEvents dataGVProfs As DataGridView
    Friend WithEvents dataGVCourses As DataGridView
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents btnDeleteProf As Button
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents lblProfDataID As Label
    Friend WithEvents txtProfDataID As TextBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudDataID As TextBox
    Friend WithEvents lblCourseID As Label
    Friend WithEvents txtCourseID As TextBox
End Class

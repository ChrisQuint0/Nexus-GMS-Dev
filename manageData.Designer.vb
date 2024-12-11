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
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.btnDeleteProf = New System.Windows.Forms.Button()
        Me.btnDeleteCourse = New System.Windows.Forms.Button()
        Me.txtProfDataID = New System.Windows.Forms.TextBox()
        Me.txtStudDataID = New System.Windows.Forms.TextBox()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtAccType = New System.Windows.Forms.TextBox()
        Me.txtRecAnswer = New System.Windows.Forms.TextBox()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.txtStudYrSec = New System.Windows.Forms.TextBox()
        Me.txtStudFullName = New System.Windows.Forms.TextBox()
        Me.btnUpdateStud = New System.Windows.Forms.Button()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.btnNextManage = New System.Windows.Forms.Button()
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
        Me.dataGVUsers.Size = New System.Drawing.Size(584, 129)
        Me.dataGVUsers.TabIndex = 1
        '
        'dataGVStudents
        '
        Me.dataGVStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVStudents.Location = New System.Drawing.Point(790, 135)
        Me.dataGVStudents.Name = "dataGVStudents"
        Me.dataGVStudents.Size = New System.Drawing.Size(580, 129)
        Me.dataGVStudents.TabIndex = 2
        '
        'dataGVProfs
        '
        Me.dataGVProfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVProfs.Location = New System.Drawing.Point(133, 598)
        Me.dataGVProfs.Name = "dataGVProfs"
        Me.dataGVProfs.Size = New System.Drawing.Size(575, 160)
        Me.dataGVProfs.TabIndex = 3
        '
        'dataGVCourses
        '
        Me.dataGVCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVCourses.Location = New System.Drawing.Point(787, 594)
        Me.dataGVCourses.Name = "dataGVCourses"
        Me.dataGVCourses.Size = New System.Drawing.Size(580, 173)
        Me.dataGVCourses.TabIndex = 4
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(241, 304)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(225, 27)
        Me.txtUserID.TabIndex = 5
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteUser.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeleteUser.FlatAppearance.BorderSize = 0
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Location = New System.Drawing.Point(548, 475)
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
        Me.btnDeleteStudent.Location = New System.Drawing.Point(1217, 475)
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
        Me.btnDeleteProf.Location = New System.Drawing.Point(555, 787)
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
        Me.btnDeleteCourse.Location = New System.Drawing.Point(1217, 784)
        Me.btnDeleteCourse.Name = "btnDeleteCourse"
        Me.btnDeleteCourse.Size = New System.Drawing.Size(160, 45)
        Me.btnDeleteCourse.TabIndex = 10
        Me.btnDeleteCourse.UseVisualStyleBackColor = False
        '
        'txtProfDataID
        '
        Me.txtProfDataID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfDataID.Location = New System.Drawing.Point(264, 795)
        Me.txtProfDataID.Name = "txtProfDataID"
        Me.txtProfDataID.ReadOnly = True
        Me.txtProfDataID.Size = New System.Drawing.Size(225, 27)
        Me.txtProfDataID.TabIndex = 11
        '
        'txtStudDataID
        '
        Me.txtStudDataID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudDataID.Location = New System.Drawing.Point(960, 312)
        Me.txtStudDataID.Name = "txtStudDataID"
        Me.txtStudDataID.ReadOnly = True
        Me.txtStudDataID.Size = New System.Drawing.Size(225, 27)
        Me.txtStudDataID.TabIndex = 13
        '
        'txtCourseID
        '
        Me.txtCourseID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(914, 794)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.ReadOnly = True
        Me.txtCourseID.Size = New System.Drawing.Size(225, 27)
        Me.txtCourseID.TabIndex = 15
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(243, 356)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(225, 27)
        Me.txtUsername.TabIndex = 16
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(243, 404)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(225, 27)
        Me.txtPass.TabIndex = 17
        '
        'txtAccType
        '
        Me.txtAccType.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccType.Location = New System.Drawing.Point(243, 452)
        Me.txtAccType.Name = "txtAccType"
        Me.txtAccType.Size = New System.Drawing.Size(225, 27)
        Me.txtAccType.TabIndex = 18
        '
        'txtRecAnswer
        '
        Me.txtRecAnswer.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecAnswer.Location = New System.Drawing.Point(243, 493)
        Me.txtRecAnswer.Name = "txtRecAnswer"
        Me.txtRecAnswer.Size = New System.Drawing.Size(225, 27)
        Me.txtRecAnswer.TabIndex = 19
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateUser.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnUpdateData
        Me.btnUpdateUser.FlatAppearance.BorderSize = 0
        Me.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateUser.Location = New System.Drawing.Point(548, 414)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(160, 45)
        Me.btnUpdateUser.TabIndex = 20
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'txtStudYrSec
        '
        Me.txtStudYrSec.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudYrSec.Location = New System.Drawing.Point(960, 468)
        Me.txtStudYrSec.Name = "txtStudYrSec"
        Me.txtStudYrSec.Size = New System.Drawing.Size(225, 27)
        Me.txtStudYrSec.TabIndex = 22
        '
        'txtStudFullName
        '
        Me.txtStudFullName.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudFullName.Location = New System.Drawing.Point(960, 420)
        Me.txtStudFullName.Name = "txtStudFullName"
        Me.txtStudFullName.Size = New System.Drawing.Size(225, 27)
        Me.txtStudFullName.TabIndex = 21
        '
        'btnUpdateStud
        '
        Me.btnUpdateStud.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateStud.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnUpdateData
        Me.btnUpdateStud.FlatAppearance.BorderSize = 0
        Me.btnUpdateStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStud.Location = New System.Drawing.Point(1217, 414)
        Me.btnUpdateStud.Name = "btnUpdateStud"
        Me.btnUpdateStud.Size = New System.Drawing.Size(160, 45)
        Me.btnUpdateStud.TabIndex = 23
        Me.btnUpdateStud.UseVisualStyleBackColor = False
        '
        'txtStudID
        '
        Me.txtStudID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(960, 366)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(225, 27)
        Me.txtStudID.TabIndex = 24
        '
        'btnNextManage
        '
        Me.btnNextManage.BackColor = System.Drawing.Color.Transparent
        Me.btnNextManage.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnNextManage
        Me.btnNextManage.FlatAppearance.BorderSize = 0
        Me.btnNextManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextManage.Location = New System.Drawing.Point(1226, 54)
        Me.btnNextManage.Name = "btnNextManage"
        Me.btnNextManage.Size = New System.Drawing.Size(160, 45)
        Me.btnNextManage.TabIndex = 25
        Me.btnNextManage.UseVisualStyleBackColor = False
        '
        'manageData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.manageDataBackground
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.btnNextManage)
        Me.Controls.Add(Me.txtStudID)
        Me.Controls.Add(Me.btnUpdateStud)
        Me.Controls.Add(Me.txtStudYrSec)
        Me.Controls.Add(Me.txtStudFullName)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.txtRecAnswer)
        Me.Controls.Add(Me.txtAccType)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.txtStudDataID)
        Me.Controls.Add(Me.txtProfDataID)
        Me.Controls.Add(Me.btnDeleteCourse)
        Me.Controls.Add(Me.btnDeleteProf)
        Me.Controls.Add(Me.btnDeleteStudent)
        Me.Controls.Add(Me.btnDeleteUser)
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
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents btnDeleteProf As Button
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents txtProfDataID As TextBox
    Friend WithEvents txtStudDataID As TextBox
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtAccType As TextBox
    Friend WithEvents txtRecAnswer As TextBox
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents txtStudYrSec As TextBox
    Friend WithEvents txtStudFullName As TextBox
    Friend WithEvents btnUpdateStud As Button
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents btnNextManage As Button
End Class

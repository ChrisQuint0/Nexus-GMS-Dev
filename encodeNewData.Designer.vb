﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class encodeNewData
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
        Me.picEncodeNewData = New System.Windows.Forms.PictureBox()
        Me.comboAccountType = New System.Windows.Forms.ComboBox()
        Me.txtNewStudName = New System.Windows.Forms.TextBox()
        Me.txtNewYrSec = New System.Windows.Forms.TextBox()
        Me.txtNewFacultyName = New System.Windows.Forms.TextBox()
        Me.comboNewStudDept = New System.Windows.Forms.ComboBox()
        Me.comboNewStudCourse = New System.Windows.Forms.ComboBox()
        Me.comboNewFacultyDept = New System.Windows.Forms.ComboBox()
        Me.comboNewFacultyCourse = New System.Windows.Forms.ComboBox()
        Me.comboNewStudProgram = New System.Windows.Forms.ComboBox()
        Me.txtNewCourseCode = New System.Windows.Forms.TextBox()
        Me.txtNewCourseTitle = New System.Windows.Forms.TextBox()
        Me.txtNewCourseCurYear = New System.Windows.Forms.TextBox()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnAddFaculty = New System.Windows.Forms.Button()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.btnBackEncodeNew = New System.Windows.Forms.Button()
        Me.txtNewStudUsername = New System.Windows.Forms.TextBox()
        Me.txtNewStudPassword = New System.Windows.Forms.TextBox()
        Me.txtNewFacultyUsername = New System.Windows.Forms.TextBox()
        Me.txtNewFacultyPass = New System.Windows.Forms.TextBox()
        Me.txtNewCoursewareId = New System.Windows.Forms.TextBox()
        Me.txtSecHandling = New System.Windows.Forms.TextBox()
        Me.txtNewFacultyID = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewStudId = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewStudRecovery = New System.Windows.Forms.TextBox()
        Me.txtNewFacultyRecovery = New System.Windows.Forms.TextBox()
        CType(Me.picEncodeNewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncodeNewData
        '
        Me.picEncodeNewData.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.encodeNewData
        Me.picEncodeNewData.Enabled = False
        Me.picEncodeNewData.Location = New System.Drawing.Point(0, 0)
        Me.picEncodeNewData.Name = "picEncodeNewData"
        Me.picEncodeNewData.Size = New System.Drawing.Size(1536, 884)
        Me.picEncodeNewData.TabIndex = 0
        Me.picEncodeNewData.TabStop = False
        '
        'comboAccountType
        '
        Me.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAccountType.FormattingEnabled = True
        Me.comboAccountType.Items.AddRange(New Object() {"Student", "Professor", "Course"})
        Me.comboAccountType.Location = New System.Drawing.Point(316, 207)
        Me.comboAccountType.Name = "comboAccountType"
        Me.comboAccountType.Size = New System.Drawing.Size(366, 28)
        Me.comboAccountType.TabIndex = 1
        '
        'txtNewStudName
        '
        Me.txtNewStudName.Enabled = False
        Me.txtNewStudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewStudName.Location = New System.Drawing.Point(347, 393)
        Me.txtNewStudName.Name = "txtNewStudName"
        Me.txtNewStudName.Size = New System.Drawing.Size(270, 26)
        Me.txtNewStudName.TabIndex = 3
        '
        'txtNewYrSec
        '
        Me.txtNewYrSec.Enabled = False
        Me.txtNewYrSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewYrSec.Location = New System.Drawing.Point(347, 446)
        Me.txtNewYrSec.Name = "txtNewYrSec"
        Me.txtNewYrSec.Size = New System.Drawing.Size(270, 26)
        Me.txtNewYrSec.TabIndex = 4
        '
        'txtNewFacultyName
        '
        Me.txtNewFacultyName.Enabled = False
        Me.txtNewFacultyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewFacultyName.Location = New System.Drawing.Point(909, 282)
        Me.txtNewFacultyName.Name = "txtNewFacultyName"
        Me.txtNewFacultyName.Size = New System.Drawing.Size(270, 26)
        Me.txtNewFacultyName.TabIndex = 6
        '
        'comboNewStudDept
        '
        Me.comboNewStudDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboNewStudDept.Enabled = False
        Me.comboNewStudDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboNewStudDept.FormattingEnabled = True
        Me.comboNewStudDept.Location = New System.Drawing.Point(347, 496)
        Me.comboNewStudDept.Name = "comboNewStudDept"
        Me.comboNewStudDept.Size = New System.Drawing.Size(270, 28)
        Me.comboNewStudDept.TabIndex = 7
        '
        'comboNewStudCourse
        '
        Me.comboNewStudCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboNewStudCourse.Enabled = False
        Me.comboNewStudCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboNewStudCourse.FormattingEnabled = True
        Me.comboNewStudCourse.Location = New System.Drawing.Point(347, 587)
        Me.comboNewStudCourse.Name = "comboNewStudCourse"
        Me.comboNewStudCourse.Size = New System.Drawing.Size(270, 28)
        Me.comboNewStudCourse.TabIndex = 8
        '
        'comboNewFacultyDept
        '
        Me.comboNewFacultyDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboNewFacultyDept.Enabled = False
        Me.comboNewFacultyDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboNewFacultyDept.FormattingEnabled = True
        Me.comboNewFacultyDept.Location = New System.Drawing.Point(910, 320)
        Me.comboNewFacultyDept.Name = "comboNewFacultyDept"
        Me.comboNewFacultyDept.Size = New System.Drawing.Size(270, 28)
        Me.comboNewFacultyDept.TabIndex = 9
        '
        'comboNewFacultyCourse
        '
        Me.comboNewFacultyCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboNewFacultyCourse.Enabled = False
        Me.comboNewFacultyCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboNewFacultyCourse.FormattingEnabled = True
        Me.comboNewFacultyCourse.Location = New System.Drawing.Point(910, 360)
        Me.comboNewFacultyCourse.Name = "comboNewFacultyCourse"
        Me.comboNewFacultyCourse.Size = New System.Drawing.Size(270, 28)
        Me.comboNewFacultyCourse.TabIndex = 10
        '
        'comboNewStudProgram
        '
        Me.comboNewStudProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboNewStudProgram.Enabled = False
        Me.comboNewStudProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboNewStudProgram.FormattingEnabled = True
        Me.comboNewStudProgram.Location = New System.Drawing.Point(347, 545)
        Me.comboNewStudProgram.Name = "comboNewStudProgram"
        Me.comboNewStudProgram.Size = New System.Drawing.Size(270, 28)
        Me.comboNewStudProgram.TabIndex = 11
        '
        'txtNewCourseCode
        '
        Me.txtNewCourseCode.Enabled = False
        Me.txtNewCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewCourseCode.Location = New System.Drawing.Point(903, 656)
        Me.txtNewCourseCode.Name = "txtNewCourseCode"
        Me.txtNewCourseCode.Size = New System.Drawing.Size(270, 26)
        Me.txtNewCourseCode.TabIndex = 12
        '
        'txtNewCourseTitle
        '
        Me.txtNewCourseTitle.Enabled = False
        Me.txtNewCourseTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewCourseTitle.Location = New System.Drawing.Point(903, 697)
        Me.txtNewCourseTitle.Name = "txtNewCourseTitle"
        Me.txtNewCourseTitle.Size = New System.Drawing.Size(270, 26)
        Me.txtNewCourseTitle.TabIndex = 13
        '
        'txtNewCourseCurYear
        '
        Me.txtNewCourseCurYear.Enabled = False
        Me.txtNewCourseCurYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewCourseCurYear.Location = New System.Drawing.Point(902, 739)
        Me.txtNewCourseCurYear.Name = "txtNewCourseCurYear"
        Me.txtNewCourseCurYear.Size = New System.Drawing.Size(270, 26)
        Me.txtNewCourseCurYear.TabIndex = 14
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCourse.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.addCourseButton
        Me.btnAddCourse.Enabled = False
        Me.btnAddCourse.FlatAppearance.BorderSize = 0
        Me.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCourse.Location = New System.Drawing.Point(1203, 704)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(177, 43)
        Me.btnAddCourse.TabIndex = 15
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'btnAddFaculty
        '
        Me.btnAddFaculty.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFaculty.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.addFacultyButton
        Me.btnAddFaculty.Enabled = False
        Me.btnAddFaculty.FlatAppearance.BorderSize = 0
        Me.btnAddFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFaculty.Location = New System.Drawing.Point(1224, 538)
        Me.btnAddFaculty.Name = "btnAddFaculty"
        Me.btnAddFaculty.Size = New System.Drawing.Size(177, 43)
        Me.btnAddFaculty.TabIndex = 16
        Me.btnAddFaculty.UseVisualStyleBackColor = False
        '
        'btnAddStud
        '
        Me.btnAddStud.BackColor = System.Drawing.Color.Transparent
        Me.btnAddStud.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.addStudentButton
        Me.btnAddStud.Enabled = False
        Me.btnAddStud.FlatAppearance.BorderSize = 0
        Me.btnAddStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStud.Location = New System.Drawing.Point(522, 803)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(177, 43)
        Me.btnAddStud.TabIndex = 17
        Me.btnAddStud.UseVisualStyleBackColor = False
        '
        'btnBackEncodeNew
        '
        Me.btnBackEncodeNew.BackColor = System.Drawing.Color.Transparent
        Me.btnBackEncodeNew.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.backButtonReport
        Me.btnBackEncodeNew.FlatAppearance.BorderSize = 0
        Me.btnBackEncodeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackEncodeNew.Location = New System.Drawing.Point(1242, 137)
        Me.btnBackEncodeNew.Name = "btnBackEncodeNew"
        Me.btnBackEncodeNew.Size = New System.Drawing.Size(159, 43)
        Me.btnBackEncodeNew.TabIndex = 18
        Me.btnBackEncodeNew.UseVisualStyleBackColor = False
        '
        'txtNewStudUsername
        '
        Me.txtNewStudUsername.Enabled = False
        Me.txtNewStudUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewStudUsername.Location = New System.Drawing.Point(347, 627)
        Me.txtNewStudUsername.Name = "txtNewStudUsername"
        Me.txtNewStudUsername.Size = New System.Drawing.Size(270, 26)
        Me.txtNewStudUsername.TabIndex = 20
        '
        'txtNewStudPassword
        '
        Me.txtNewStudPassword.Enabled = False
        Me.txtNewStudPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewStudPassword.Location = New System.Drawing.Point(347, 672)
        Me.txtNewStudPassword.Name = "txtNewStudPassword"
        Me.txtNewStudPassword.Size = New System.Drawing.Size(270, 26)
        Me.txtNewStudPassword.TabIndex = 21
        '
        'txtNewFacultyUsername
        '
        Me.txtNewFacultyUsername.Enabled = False
        Me.txtNewFacultyUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewFacultyUsername.Location = New System.Drawing.Point(910, 440)
        Me.txtNewFacultyUsername.Name = "txtNewFacultyUsername"
        Me.txtNewFacultyUsername.Size = New System.Drawing.Size(270, 26)
        Me.txtNewFacultyUsername.TabIndex = 22
        '
        'txtNewFacultyPass
        '
        Me.txtNewFacultyPass.Enabled = False
        Me.txtNewFacultyPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewFacultyPass.Location = New System.Drawing.Point(910, 478)
        Me.txtNewFacultyPass.Name = "txtNewFacultyPass"
        Me.txtNewFacultyPass.Size = New System.Drawing.Size(270, 26)
        Me.txtNewFacultyPass.TabIndex = 23
        '
        'txtNewCoursewareId
        '
        Me.txtNewCoursewareId.Enabled = False
        Me.txtNewCoursewareId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewCoursewareId.Location = New System.Drawing.Point(902, 783)
        Me.txtNewCoursewareId.Name = "txtNewCoursewareId"
        Me.txtNewCoursewareId.Size = New System.Drawing.Size(270, 26)
        Me.txtNewCoursewareId.TabIndex = 24
        '
        'txtSecHandling
        '
        Me.txtSecHandling.Enabled = False
        Me.txtSecHandling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecHandling.Location = New System.Drawing.Point(910, 401)
        Me.txtSecHandling.Name = "txtSecHandling"
        Me.txtSecHandling.Size = New System.Drawing.Size(270, 26)
        Me.txtSecHandling.TabIndex = 25
        '
        'txtNewFacultyID
        '
        Me.txtNewFacultyID.Enabled = False
        Me.txtNewFacultyID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewFacultyID.Location = New System.Drawing.Point(910, 243)
        Me.txtNewFacultyID.Mask = "00-0000000"
        Me.txtNewFacultyID.Name = "txtNewFacultyID"
        Me.txtNewFacultyID.Size = New System.Drawing.Size(270, 27)
        Me.txtNewFacultyID.TabIndex = 26
        '
        'txtNewStudId
        '
        Me.txtNewStudId.Enabled = False
        Me.txtNewStudId.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewStudId.Location = New System.Drawing.Point(347, 345)
        Me.txtNewStudId.Mask = "00-00000"
        Me.txtNewStudId.Name = "txtNewStudId"
        Me.txtNewStudId.Size = New System.Drawing.Size(270, 27)
        Me.txtNewStudId.TabIndex = 27
        '
        'txtNewStudRecovery
        '
        Me.txtNewStudRecovery.Enabled = False
        Me.txtNewStudRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewStudRecovery.Location = New System.Drawing.Point(383, 740)
        Me.txtNewStudRecovery.Name = "txtNewStudRecovery"
        Me.txtNewStudRecovery.Size = New System.Drawing.Size(270, 26)
        Me.txtNewStudRecovery.TabIndex = 28
        '
        'txtNewFacultyRecovery
        '
        Me.txtNewFacultyRecovery.Enabled = False
        Me.txtNewFacultyRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewFacultyRecovery.Location = New System.Drawing.Point(962, 538)
        Me.txtNewFacultyRecovery.Name = "txtNewFacultyRecovery"
        Me.txtNewFacultyRecovery.Size = New System.Drawing.Size(218, 26)
        Me.txtNewFacultyRecovery.TabIndex = 29
        '
        'encodeNewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.encodeNewData
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.txtNewFacultyRecovery)
        Me.Controls.Add(Me.txtNewStudRecovery)
        Me.Controls.Add(Me.txtNewStudId)
        Me.Controls.Add(Me.txtNewFacultyID)
        Me.Controls.Add(Me.txtSecHandling)
        Me.Controls.Add(Me.txtNewCoursewareId)
        Me.Controls.Add(Me.txtNewFacultyPass)
        Me.Controls.Add(Me.txtNewFacultyUsername)
        Me.Controls.Add(Me.txtNewStudPassword)
        Me.Controls.Add(Me.txtNewStudUsername)
        Me.Controls.Add(Me.btnBackEncodeNew)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.btnAddFaculty)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.txtNewCourseCurYear)
        Me.Controls.Add(Me.txtNewCourseTitle)
        Me.Controls.Add(Me.txtNewCourseCode)
        Me.Controls.Add(Me.comboNewStudProgram)
        Me.Controls.Add(Me.comboNewFacultyCourse)
        Me.Controls.Add(Me.comboNewFacultyDept)
        Me.Controls.Add(Me.comboNewStudCourse)
        Me.Controls.Add(Me.comboNewStudDept)
        Me.Controls.Add(Me.txtNewFacultyName)
        Me.Controls.Add(Me.txtNewYrSec)
        Me.Controls.Add(Me.txtNewStudName)
        Me.Controls.Add(Me.comboAccountType)
        Me.Controls.Add(Me.picEncodeNewData)
        Me.Name = "encodeNewData"
        Me.Text = "encodeNewData"
        CType(Me.picEncodeNewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEncodeNewData As PictureBox
    Friend WithEvents comboAccountType As ComboBox
    Friend WithEvents txtNewStudName As TextBox
    Friend WithEvents txtNewYrSec As TextBox
    Friend WithEvents txtNewFacultyName As TextBox
    Friend WithEvents comboNewStudDept As ComboBox
    Friend WithEvents comboNewStudCourse As ComboBox
    Friend WithEvents comboNewFacultyDept As ComboBox
    Friend WithEvents comboNewFacultyCourse As ComboBox
    Friend WithEvents comboNewStudProgram As ComboBox
    Friend WithEvents txtNewCourseCode As TextBox
    Friend WithEvents txtNewCourseTitle As TextBox
    Friend WithEvents txtNewCourseCurYear As TextBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnAddFaculty As Button
    Friend WithEvents btnAddStud As Button
    Friend WithEvents btnBackEncodeNew As Button
    Friend WithEvents txtNewStudUsername As TextBox
    Friend WithEvents txtNewStudPassword As TextBox
    Friend WithEvents txtNewFacultyUsername As TextBox
    Friend WithEvents txtNewFacultyPass As TextBox
    Friend WithEvents txtNewCoursewareId As TextBox
    Friend WithEvents txtSecHandling As TextBox
    Friend WithEvents txtNewFacultyID As MaskedTextBox
    Friend WithEvents txtNewStudId As MaskedTextBox
    Friend WithEvents txtNewStudRecovery As TextBox
    Friend WithEvents txtNewFacultyRecovery As TextBox
End Class

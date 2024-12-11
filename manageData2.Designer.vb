<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageData2
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
        Me.picManageDataBg2 = New System.Windows.Forms.PictureBox()
        Me.txtGradeID = New System.Windows.Forms.TextBox()
        Me.btnDeleteGrade = New System.Windows.Forms.Button()
        Me.txtDeptID = New System.Windows.Forms.TextBox()
        Me.txtProgID = New System.Windows.Forms.TextBox()
        Me.btnDeleteDept = New System.Windows.Forms.Button()
        Me.btnDeletePrograms = New System.Windows.Forms.Button()
        Me.dataGVGrades = New System.Windows.Forms.DataGridView()
        Me.dataGVPrograms = New System.Windows.Forms.DataGridView()
        Me.dataGVDept = New System.Windows.Forms.DataGridView()
        CType(Me.picManageDataBg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGVGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGVPrograms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGVDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picManageDataBg2
        '
        Me.picManageDataBg2.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.manageDataBackground21
        Me.picManageDataBg2.Location = New System.Drawing.Point(0, 0)
        Me.picManageDataBg2.Name = "picManageDataBg2"
        Me.picManageDataBg2.Size = New System.Drawing.Size(1536, 884)
        Me.picManageDataBg2.TabIndex = 0
        Me.picManageDataBg2.TabStop = False
        '
        'txtGradeID
        '
        Me.txtGradeID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeID.Location = New System.Drawing.Point(995, 397)
        Me.txtGradeID.Name = "txtGradeID"
        Me.txtGradeID.Size = New System.Drawing.Size(208, 27)
        Me.txtGradeID.TabIndex = 18
        '
        'btnDeleteGrade
        '
        Me.btnDeleteGrade.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteGrade.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeleteGrade.FlatAppearance.BorderSize = 0
        Me.btnDeleteGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteGrade.Location = New System.Drawing.Point(1209, 391)
        Me.btnDeleteGrade.Name = "btnDeleteGrade"
        Me.btnDeleteGrade.Size = New System.Drawing.Size(160, 45)
        Me.btnDeleteGrade.TabIndex = 19
        Me.btnDeleteGrade.UseVisualStyleBackColor = False
        '
        'txtDeptID
        '
        Me.txtDeptID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeptID.Location = New System.Drawing.Point(925, 745)
        Me.txtDeptID.Name = "txtDeptID"
        Me.txtDeptID.Size = New System.Drawing.Size(208, 27)
        Me.txtDeptID.TabIndex = 20
        '
        'txtProgID
        '
        Me.txtProgID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgID.Location = New System.Drawing.Point(245, 741)
        Me.txtProgID.Name = "txtProgID"
        Me.txtProgID.Size = New System.Drawing.Size(208, 27)
        Me.txtProgID.TabIndex = 21
        '
        'btnDeleteDept
        '
        Me.btnDeleteDept.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteDept.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeleteDept.FlatAppearance.BorderSize = 0
        Me.btnDeleteDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDept.Location = New System.Drawing.Point(1199, 739)
        Me.btnDeleteDept.Name = "btnDeleteDept"
        Me.btnDeleteDept.Size = New System.Drawing.Size(160, 45)
        Me.btnDeleteDept.TabIndex = 22
        Me.btnDeleteDept.UseVisualStyleBackColor = False
        '
        'btnDeletePrograms
        '
        Me.btnDeletePrograms.BackColor = System.Drawing.Color.Transparent
        Me.btnDeletePrograms.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.btnDeleteData
        Me.btnDeletePrograms.FlatAppearance.BorderSize = 0
        Me.btnDeletePrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePrograms.Location = New System.Drawing.Point(558, 735)
        Me.btnDeletePrograms.Name = "btnDeletePrograms"
        Me.btnDeletePrograms.Size = New System.Drawing.Size(160, 45)
        Me.btnDeletePrograms.TabIndex = 23
        Me.btnDeletePrograms.UseVisualStyleBackColor = False
        '
        'dataGVGrades
        '
        Me.dataGVGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVGrades.Location = New System.Drawing.Point(130, 140)
        Me.dataGVGrades.Name = "dataGVGrades"
        Me.dataGVGrades.Size = New System.Drawing.Size(1229, 229)
        Me.dataGVGrades.TabIndex = 24
        '
        'dataGVPrograms
        '
        Me.dataGVPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVPrograms.Location = New System.Drawing.Point(140, 527)
        Me.dataGVPrograms.Name = "dataGVPrograms"
        Me.dataGVPrograms.Size = New System.Drawing.Size(564, 173)
        Me.dataGVPrograms.TabIndex = 25
        '
        'dataGVDept
        '
        Me.dataGVDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGVDept.Location = New System.Drawing.Point(785, 527)
        Me.dataGVDept.Name = "dataGVDept"
        Me.dataGVDept.Size = New System.Drawing.Size(564, 173)
        Me.dataGVDept.TabIndex = 26
        '
        'manageData2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.manageDataBackground2
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.dataGVDept)
        Me.Controls.Add(Me.dataGVPrograms)
        Me.Controls.Add(Me.dataGVGrades)
        Me.Controls.Add(Me.btnDeletePrograms)
        Me.Controls.Add(Me.btnDeleteDept)
        Me.Controls.Add(Me.txtProgID)
        Me.Controls.Add(Me.txtDeptID)
        Me.Controls.Add(Me.btnDeleteGrade)
        Me.Controls.Add(Me.txtGradeID)
        Me.Controls.Add(Me.picManageDataBg2)
        Me.Name = "manageData2"
        Me.Text = "manageData2"
        CType(Me.picManageDataBg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGVGrades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGVPrograms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGVDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picManageDataBg2 As PictureBox
    Friend WithEvents txtGradeID As TextBox
    Friend WithEvents btnDeleteGrade As Button
    Friend WithEvents txtDeptID As TextBox
    Friend WithEvents txtProgID As TextBox
    Friend WithEvents btnDeleteDept As Button
    Friend WithEvents btnDeletePrograms As Button
    Friend WithEvents dataGVGrades As DataGridView
    Friend WithEvents dataGVPrograms As DataGridView
    Friend WithEvents dataGVDept As DataGridView
End Class

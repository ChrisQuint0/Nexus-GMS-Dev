<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editForm
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
        Me.picEditFormBg = New System.Windows.Forms.PictureBox()
        Me.txtEditFacultyId = New System.Windows.Forms.TextBox()
        Me.txtEditFacultyName = New System.Windows.Forms.TextBox()
        Me.txtEditDepartment = New System.Windows.Forms.TextBox()
        Me.txtEditAcademicYear = New System.Windows.Forms.TextBox()
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.btnSaveEdit = New System.Windows.Forms.Button()
        CType(Me.picEditFormBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEditFormBg
        '
        Me.picEditFormBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.editForm
        Me.picEditFormBg.Location = New System.Drawing.Point(0, 0)
        Me.picEditFormBg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEditFormBg.Name = "picEditFormBg"
        Me.picEditFormBg.Size = New System.Drawing.Size(2048, 1088)
        Me.picEditFormBg.TabIndex = 0
        Me.picEditFormBg.TabStop = False
        '
        'txtEditFacultyId
        '
        Me.txtEditFacultyId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditFacultyId.Location = New System.Drawing.Point(867, 447)
        Me.txtEditFacultyId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEditFacultyId.Name = "txtEditFacultyId"
        Me.txtEditFacultyId.Size = New System.Drawing.Size(557, 34)
        Me.txtEditFacultyId.TabIndex = 2
        '
        'txtEditFacultyName
        '
        Me.txtEditFacultyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditFacultyName.Location = New System.Drawing.Point(867, 508)
        Me.txtEditFacultyName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEditFacultyName.Name = "txtEditFacultyName"
        Me.txtEditFacultyName.Size = New System.Drawing.Size(557, 34)
        Me.txtEditFacultyName.TabIndex = 3
        '
        'txtEditDepartment
        '
        Me.txtEditDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditDepartment.Location = New System.Drawing.Point(867, 570)
        Me.txtEditDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEditDepartment.Name = "txtEditDepartment"
        Me.txtEditDepartment.Size = New System.Drawing.Size(557, 34)
        Me.txtEditDepartment.TabIndex = 4
        '
        'txtEditAcademicYear
        '
        Me.txtEditAcademicYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditAcademicYear.Location = New System.Drawing.Point(867, 631)
        Me.txtEditAcademicYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEditAcademicYear.Name = "txtEditAcademicYear"
        Me.txtEditAcademicYear.Size = New System.Drawing.Size(557, 34)
        Me.txtEditAcademicYear.TabIndex = 5
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelEdit.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.cancelEditButton
        Me.btnCancelEdit.FlatAppearance.BorderSize = 0
        Me.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelEdit.Location = New System.Drawing.Point(1060, 815)
        Me.btnCancelEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(209, 54)
        Me.btnCancelEdit.TabIndex = 6
        Me.btnCancelEdit.UseVisualStyleBackColor = False
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveEdit.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.saveEditButton
        Me.btnSaveEdit.FlatAppearance.BorderSize = 0
        Me.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEdit.Location = New System.Drawing.Point(1287, 815)
        Me.btnSaveEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Size = New System.Drawing.Size(209, 54)
        Me.btnSaveEdit.TabIndex = 7
        Me.btnSaveEdit.UseVisualStyleBackColor = False
        '
        'editForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.editForm
        Me.ClientSize = New System.Drawing.Size(1924, 1040)
        Me.Controls.Add(Me.btnSaveEdit)
        Me.Controls.Add(Me.btnCancelEdit)
        Me.Controls.Add(Me.txtEditAcademicYear)
        Me.Controls.Add(Me.txtEditDepartment)
        Me.Controls.Add(Me.txtEditFacultyName)
        Me.Controls.Add(Me.txtEditFacultyId)
        Me.Controls.Add(Me.picEditFormBg)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "editForm"
        Me.Text = "editForm"
        CType(Me.picEditFormBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEditFormBg As PictureBox
    Friend WithEvents txtEditFacultyId As TextBox
    Friend WithEvents txtEditFacultyName As TextBox
    Friend WithEvents txtEditDepartment As TextBox
    Friend WithEvents txtEditAcademicYear As TextBox
    Friend WithEvents btnCancelEdit As Button
    Friend WithEvents btnSaveEdit As Button
End Class

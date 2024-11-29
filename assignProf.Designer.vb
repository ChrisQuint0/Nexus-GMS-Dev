<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assignProf
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
        Me.picAssignProf = New System.Windows.Forms.PictureBox()
        Me.maskedStudId = New System.Windows.Forms.MaskedTextBox()
        Me.txtStudName = New System.Windows.Forms.TextBox()
        Me.txtYrSec = New System.Windows.Forms.TextBox()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.comboProf = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAssignProfSave = New System.Windows.Forms.Button()
        Me.btnAssignProfBack = New System.Windows.Forms.Button()
        CType(Me.picAssignProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAssignProf
        '
        Me.picAssignProf.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignForm
        Me.picAssignProf.Location = New System.Drawing.Point(0, 0)
        Me.picAssignProf.Margin = New System.Windows.Forms.Padding(4)
        Me.picAssignProf.Name = "picAssignProf"
        Me.picAssignProf.Size = New System.Drawing.Size(2048, 1088)
        Me.picAssignProf.TabIndex = 0
        Me.picAssignProf.TabStop = False
        '
        'maskedStudId
        '
        Me.maskedStudId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.maskedStudId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedStudId.Location = New System.Drawing.Point(597, 267)
        Me.maskedStudId.Margin = New System.Windows.Forms.Padding(4)
        Me.maskedStudId.Mask = "00-00000"
        Me.maskedStudId.Name = "maskedStudId"
        Me.maskedStudId.Size = New System.Drawing.Size(449, 27)
        Me.maskedStudId.TabIndex = 1
        Me.maskedStudId.ValidatingType = GetType(Integer)
        '
        'txtStudName
        '
        Me.txtStudName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudName.Location = New System.Drawing.Point(596, 318)
        Me.txtStudName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.ReadOnly = True
        Me.txtStudName.Size = New System.Drawing.Size(451, 27)
        Me.txtStudName.TabIndex = 2
        '
        'txtYrSec
        '
        Me.txtYrSec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrSec.Location = New System.Drawing.Point(597, 373)
        Me.txtYrSec.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYrSec.Name = "txtYrSec"
        Me.txtYrSec.ReadOnly = True
        Me.txtYrSec.Size = New System.Drawing.Size(451, 27)
        Me.txtYrSec.TabIndex = 3
        '
        'comboCourse
        '
        Me.comboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Items.AddRange(New Object() {"IT 102: Object Oriented Programming", "IT 103: Procedural Programming", "COMP 101: Introduction to Computing"})
        Me.comboCourse.Location = New System.Drawing.Point(1149, 249)
        Me.comboCourse.Margin = New System.Windows.Forms.Padding(4)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(601, 33)
        Me.comboCourse.TabIndex = 4
        '
        'comboProf
        '
        Me.comboProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProf.FormattingEnabled = True
        Me.comboProf.Items.AddRange(New Object() {"Rodolfo Mirabel Jr.", "Christopher A. Quinto", "Rebecca Fajardo", "Juanito P. Alvarez Jr.", "Racquel Cortez", "Berlinne Bobis"})
        Me.comboProf.Location = New System.Drawing.Point(1149, 318)
        Me.comboProf.Margin = New System.Windows.Forms.Padding(4)
        Me.comboProf.Name = "comboProf"
        Me.comboProf.Size = New System.Drawing.Size(601, 33)
        Me.comboProf.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(320, 480)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1432, 316)
        Me.DataGridView1.TabIndex = 6
        '
        'btnAssignProfSave
        '
        Me.btnAssignProfSave.BackColor = System.Drawing.Color.Transparent
        Me.btnAssignProfSave.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignProfSaveButton
        Me.btnAssignProfSave.FlatAppearance.BorderSize = 0
        Me.btnAssignProfSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignProfSave.Location = New System.Drawing.Point(1597, 384)
        Me.btnAssignProfSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAssignProfSave.Name = "btnAssignProfSave"
        Me.btnAssignProfSave.Size = New System.Drawing.Size(185, 49)
        Me.btnAssignProfSave.TabIndex = 7
        Me.btnAssignProfSave.UseVisualStyleBackColor = False
        '
        'btnAssignProfBack
        '
        Me.btnAssignProfBack.BackColor = System.Drawing.Color.Transparent
        Me.btnAssignProfBack.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignProfBackButton
        Me.btnAssignProfBack.FlatAppearance.BorderSize = 0
        Me.btnAssignProfBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignProfBack.Location = New System.Drawing.Point(1568, 895)
        Me.btnAssignProfBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAssignProfBack.Name = "btnAssignProfBack"
        Me.btnAssignProfBack.Size = New System.Drawing.Size(215, 49)
        Me.btnAssignProfBack.TabIndex = 8
        Me.btnAssignProfBack.UseVisualStyleBackColor = False
        '
        'assignProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignForm
        Me.ClientSize = New System.Drawing.Size(1924, 1040)
        Me.Controls.Add(Me.btnAssignProfBack)
        Me.Controls.Add(Me.btnAssignProfSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.comboProf)
        Me.Controls.Add(Me.comboCourse)
        Me.Controls.Add(Me.txtYrSec)
        Me.Controls.Add(Me.txtStudName)
        Me.Controls.Add(Me.maskedStudId)
        Me.Controls.Add(Me.picAssignProf)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "assignProf"
        Me.Text = "assignProf"
        CType(Me.picAssignProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAssignProf As PictureBox
    Friend WithEvents maskedStudId As MaskedTextBox
    Friend WithEvents txtStudName As TextBox
    Friend WithEvents txtYrSec As TextBox
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents comboProf As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAssignProfSave As Button
    Friend WithEvents btnAssignProfBack As Button
End Class

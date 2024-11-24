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
        Me.picAssignProf.Name = "picAssignProf"
        Me.picAssignProf.Size = New System.Drawing.Size(1536, 884)
        Me.picAssignProf.TabIndex = 0
        Me.picAssignProf.TabStop = False
        '
        'maskedStudId
        '
        Me.maskedStudId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.maskedStudId.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedStudId.Location = New System.Drawing.Point(448, 217)
        Me.maskedStudId.Mask = "00-00000"
        Me.maskedStudId.Name = "maskedStudId"
        Me.maskedStudId.Size = New System.Drawing.Size(337, 24)
        Me.maskedStudId.TabIndex = 1
        Me.maskedStudId.ValidatingType = GetType(Integer)
        '
        'txtStudName
        '
        Me.txtStudName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudName.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudName.Location = New System.Drawing.Point(447, 258)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.ReadOnly = True
        Me.txtStudName.Size = New System.Drawing.Size(338, 24)
        Me.txtStudName.TabIndex = 2
        '
        'txtYrSec
        '
        Me.txtYrSec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrSec.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrSec.Location = New System.Drawing.Point(448, 303)
        Me.txtYrSec.Name = "txtYrSec"
        Me.txtYrSec.ReadOnly = True
        Me.txtYrSec.Size = New System.Drawing.Size(338, 24)
        Me.txtYrSec.TabIndex = 3
        '
        'comboCourse
        '
        Me.comboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCourse.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Items.AddRange(New Object() {"IT 102: Object Oriented Programming", "IT 103: Procedural Programming", "COMP 101: Introduction to Computing"})
        Me.comboCourse.Location = New System.Drawing.Point(862, 202)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(452, 30)
        Me.comboCourse.TabIndex = 4
        '
        'comboProf
        '
        Me.comboProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProf.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProf.FormattingEnabled = True
        Me.comboProf.Items.AddRange(New Object() {"Rodolfo Mirabel Jr.", "Christopher A. Quinto", "Rebecca Fajardo", "Juanito P. Alvarez Jr.", "Racquel Cortez", "Berlinne Bobis"})
        Me.comboProf.Location = New System.Drawing.Point(862, 258)
        Me.comboProf.Name = "comboProf"
        Me.comboProf.Size = New System.Drawing.Size(452, 30)
        Me.comboProf.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(240, 390)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1074, 257)
        Me.DataGridView1.TabIndex = 6
        '
        'btnAssignProfSave
        '
        Me.btnAssignProfSave.BackColor = System.Drawing.Color.Transparent
        Me.btnAssignProfSave.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignProfSaveButton
        Me.btnAssignProfSave.FlatAppearance.BorderSize = 0
        Me.btnAssignProfSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignProfSave.Location = New System.Drawing.Point(1198, 312)
        Me.btnAssignProfSave.Name = "btnAssignProfSave"
        Me.btnAssignProfSave.Size = New System.Drawing.Size(139, 40)
        Me.btnAssignProfSave.TabIndex = 7
        Me.btnAssignProfSave.UseVisualStyleBackColor = False
        '
        'btnAssignProfBack
        '
        Me.btnAssignProfBack.BackColor = System.Drawing.Color.Transparent
        Me.btnAssignProfBack.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignProfBackButton
        Me.btnAssignProfBack.FlatAppearance.BorderSize = 0
        Me.btnAssignProfBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignProfBack.Location = New System.Drawing.Point(1176, 727)
        Me.btnAssignProfBack.Name = "btnAssignProfBack"
        Me.btnAssignProfBack.Size = New System.Drawing.Size(161, 40)
        Me.btnAssignProfBack.TabIndex = 8
        Me.btnAssignProfBack.UseVisualStyleBackColor = False
        '
        'assignProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.assignForm
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.btnAssignProfBack)
        Me.Controls.Add(Me.btnAssignProfSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.comboProf)
        Me.Controls.Add(Me.comboCourse)
        Me.Controls.Add(Me.txtYrSec)
        Me.Controls.Add(Me.txtStudName)
        Me.Controls.Add(Me.maskedStudId)
        Me.Controls.Add(Me.picAssignProf)
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

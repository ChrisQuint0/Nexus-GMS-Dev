<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profReportForm
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
        Me.picProfReportBg = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblFacultyId = New System.Windows.Forms.Label()
        Me.lblFacultyName = New System.Windows.Forms.Label()
        Me.lblAcadYear = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.btnBackReport = New System.Windows.Forms.Button()
        Me.btnDLProfReport = New System.Windows.Forms.Button()
        CType(Me.picProfReportBg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picProfReportBg
        '
        Me.picProfReportBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.profReportForm
        Me.picProfReportBg.Location = New System.Drawing.Point(0, 0)
        Me.picProfReportBg.Name = "picProfReportBg"
        Me.picProfReportBg.Size = New System.Drawing.Size(1536, 884)
        Me.picProfReportBg.TabIndex = 0
        Me.picProfReportBg.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(254, 375)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1030, 340)
        Me.DataGridView1.TabIndex = 1
        '
        'lblFacultyId
        '
        Me.lblFacultyId.AutoSize = True
        Me.lblFacultyId.BackColor = System.Drawing.Color.Transparent
        Me.lblFacultyId.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultyId.ForeColor = System.Drawing.Color.White
        Me.lblFacultyId.Location = New System.Drawing.Point(397, 232)
        Me.lblFacultyId.Name = "lblFacultyId"
        Me.lblFacultyId.Size = New System.Drawing.Size(192, 26)
        Me.lblFacultyId.TabIndex = 2
        Me.lblFacultyId.Text = "321343243231-3234"
        '
        'lblFacultyName
        '
        Me.lblFacultyName.AutoSize = True
        Me.lblFacultyName.BackColor = System.Drawing.Color.Transparent
        Me.lblFacultyName.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultyName.ForeColor = System.Drawing.Color.White
        Me.lblFacultyName.Location = New System.Drawing.Point(398, 265)
        Me.lblFacultyName.Name = "lblFacultyName"
        Me.lblFacultyName.Size = New System.Drawing.Size(188, 26)
        Me.lblFacultyName.TabIndex = 3
        Me.lblFacultyName.Text = "Rodolfo Mirabel Jr."
        '
        'lblAcadYear
        '
        Me.lblAcadYear.AutoSize = True
        Me.lblAcadYear.BackColor = System.Drawing.Color.Transparent
        Me.lblAcadYear.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcadYear.ForeColor = System.Drawing.Color.White
        Me.lblAcadYear.Location = New System.Drawing.Point(941, 232)
        Me.lblAcadYear.Name = "lblAcadYear"
        Me.lblAcadYear.Size = New System.Drawing.Size(257, 26)
        Me.lblAcadYear.TabIndex = 4
        Me.lblAcadYear.Text = "2024 - 2025 | 1st Semester"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.White
        Me.lblDepartment.Location = New System.Drawing.Point(941, 261)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(286, 26)
        Me.lblDepartment.TabIndex = 5
        Me.lblDepartment.Text = "College of Computer Studies"
        '
        'comboCourse
        '
        Me.comboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCourse.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Items.AddRange(New Object() {"IT 202: Object Oriented Programming"})
        Me.comboCourse.Location = New System.Drawing.Point(260, 308)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(1011, 30)
        Me.comboCourse.TabIndex = 6
        '
        'btnBackReport
        '
        Me.btnBackReport.BackColor = System.Drawing.Color.Transparent
        Me.btnBackReport.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.backButtonReport
        Me.btnBackReport.FlatAppearance.BorderSize = 0
        Me.btnBackReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackReport.Location = New System.Drawing.Point(207, 788)
        Me.btnBackReport.Name = "btnBackReport"
        Me.btnBackReport.Size = New System.Drawing.Size(160, 45)
        Me.btnBackReport.TabIndex = 7
        Me.btnBackReport.UseVisualStyleBackColor = False
        '
        'btnDLProfReport
        '
        Me.btnDLProfReport.BackColor = System.Drawing.Color.Transparent
        Me.btnDLProfReport.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.downloadButton
        Me.btnDLProfReport.FlatAppearance.BorderSize = 0
        Me.btnDLProfReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDLProfReport.Location = New System.Drawing.Point(1170, 788)
        Me.btnDLProfReport.Name = "btnDLProfReport"
        Me.btnDLProfReport.Size = New System.Drawing.Size(160, 45)
        Me.btnDLProfReport.TabIndex = 8
        Me.btnDLProfReport.UseVisualStyleBackColor = False
        '
        'profReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.profReportForm
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.btnDLProfReport)
        Me.Controls.Add(Me.btnBackReport)
        Me.Controls.Add(Me.comboCourse)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblAcadYear)
        Me.Controls.Add(Me.lblFacultyName)
        Me.Controls.Add(Me.lblFacultyId)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.picProfReportBg)
        Me.Name = "profReportForm"
        Me.Text = "profReportForm"
        CType(Me.picProfReportBg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfReportBg As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblFacultyId As Label
    Friend WithEvents lblFacultyName As Label
    Friend WithEvents lblAcadYear As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents btnBackReport As Button
    Friend WithEvents btnDLProfReport As Button
End Class

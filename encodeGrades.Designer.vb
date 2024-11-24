<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class encodeGrades
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
        Me.picEncodeGBg = New System.Windows.Forms.PictureBox()
        Me.lblProfNameEncode = New System.Windows.Forms.Label()
        Me.comboCourseEncode = New System.Windows.Forms.ComboBox()
        Me.comboProgramEncode = New System.Windows.Forms.ComboBox()
        Me.comboSectionEncode = New System.Windows.Forms.ComboBox()
        Me.txtMidAtt = New System.Windows.Forms.TextBox()
        Me.txtMLab = New System.Windows.Forms.TextBox()
        Me.txtMCase = New System.Windows.Forms.TextBox()
        Me.txtMRec = New System.Windows.Forms.TextBox()
        Me.txtMQ1Score = New System.Windows.Forms.TextBox()
        Me.txtMQ1Total = New System.Windows.Forms.TextBox()
        Me.txtMQ2Score = New System.Windows.Forms.TextBox()
        Me.txtMQ2Total = New System.Windows.Forms.TextBox()
        Me.txtMQ3Score = New System.Windows.Forms.TextBox()
        Me.txtMQ3Total = New System.Windows.Forms.TextBox()
        Me.txtMQ4Score = New System.Windows.Forms.TextBox()
        Me.txtMQ4Total = New System.Windows.Forms.TextBox()
        Me.txtMExamScore = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.txtMQuizPerc = New System.Windows.Forms.TextBox()
        Me.txtFAtt = New System.Windows.Forms.TextBox()
        Me.txtFLab = New System.Windows.Forms.TextBox()
        Me.txtFCase = New System.Windows.Forms.TextBox()
        Me.txtFRec = New System.Windows.Forms.TextBox()
        Me.txtFQuizPerc = New System.Windows.Forms.TextBox()
        Me.txtFQ1Score = New System.Windows.Forms.TextBox()
        Me.txtFQuiz1Total = New System.Windows.Forms.TextBox()
        Me.txtFQuiz2Score = New System.Windows.Forms.TextBox()
        Me.txtFQuiz2Total = New System.Windows.Forms.TextBox()
        Me.txtFQuiz3Score = New System.Windows.Forms.TextBox()
        Me.txtFQuiz3Total = New System.Windows.Forms.TextBox()
        Me.txtFQuiz4Score = New System.Windows.Forms.TextBox()
        Me.txtFQuiz4Total = New System.Windows.Forms.TextBox()
        Me.txtFExamScore = New System.Windows.Forms.TextBox()
        Me.txtFExamTotal = New System.Windows.Forms.TextBox()
        Me.txtFExamPerc = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtMidGrade = New System.Windows.Forms.Label()
        Me.txtFinGrade = New System.Windows.Forms.Label()
        Me.txtSemGrade = New System.Windows.Forms.Label()
        Me.txtCompGrade = New System.Windows.Forms.Label()
        Me.txCollegeGrade = New System.Windows.Forms.Label()
        Me.maskedTxtStudId = New System.Windows.Forms.MaskedTextBox()
        Me.txtStudName = New System.Windows.Forms.TextBox()
        Me.comboMidNumQuiz = New System.Windows.Forms.ComboBox()
        Me.comboFinNumQuiz = New System.Windows.Forms.ComboBox()
        Me.btnBackEncode = New System.Windows.Forms.Button()
        Me.btnComputeMid = New System.Windows.Forms.Button()
        Me.btnComputeFin = New System.Windows.Forms.Button()
        Me.btnSaveEncode = New System.Windows.Forms.Button()
        CType(Me.picEncodeGBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncodeGBg
        '
        Me.picEncodeGBg.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.encodeGradesForm
        Me.picEncodeGBg.Location = New System.Drawing.Point(0, 0)
        Me.picEncodeGBg.Name = "picEncodeGBg"
        Me.picEncodeGBg.Size = New System.Drawing.Size(1536, 864)
        Me.picEncodeGBg.TabIndex = 0
        Me.picEncodeGBg.TabStop = False
        '
        'lblProfNameEncode
        '
        Me.lblProfNameEncode.AutoSize = True
        Me.lblProfNameEncode.BackColor = System.Drawing.Color.Transparent
        Me.lblProfNameEncode.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfNameEncode.Location = New System.Drawing.Point(204, 135)
        Me.lblProfNameEncode.Name = "lblProfNameEncode"
        Me.lblProfNameEncode.Size = New System.Drawing.Size(335, 37)
        Me.lblProfNameEncode.TabIndex = 2
        Me.lblProfNameEncode.Text = "Prof. Rodolfo Mirabel Jr."
        '
        'comboCourseEncode
        '
        Me.comboCourseEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCourseEncode.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourseEncode.FormattingEnabled = True
        Me.comboCourseEncode.Items.AddRange(New Object() {"IT 202: Object Oriented Programming"})
        Me.comboCourseEncode.Location = New System.Drawing.Point(219, 327)
        Me.comboCourseEncode.Name = "comboCourseEncode"
        Me.comboCourseEncode.Size = New System.Drawing.Size(1141, 30)
        Me.comboCourseEncode.TabIndex = 15
        '
        'comboProgramEncode
        '
        Me.comboProgramEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProgramEncode.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProgramEncode.FormattingEnabled = True
        Me.comboProgramEncode.Items.AddRange(New Object() {"BS in Information Technology", "BS in Computer Science"})
        Me.comboProgramEncode.Location = New System.Drawing.Point(913, 211)
        Me.comboProgramEncode.Name = "comboProgramEncode"
        Me.comboProgramEncode.Size = New System.Drawing.Size(447, 30)
        Me.comboProgramEncode.TabIndex = 16
        '
        'comboSectionEncode
        '
        Me.comboSectionEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSectionEncode.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSectionEncode.FormattingEnabled = True
        Me.comboSectionEncode.Items.AddRange(New Object() {"1A", "2A", "3A", "4A"})
        Me.comboSectionEncode.Location = New System.Drawing.Point(913, 259)
        Me.comboSectionEncode.Name = "comboSectionEncode"
        Me.comboSectionEncode.Size = New System.Drawing.Size(447, 30)
        Me.comboSectionEncode.TabIndex = 17
        '
        'txtMidAtt
        '
        Me.txtMidAtt.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMidAtt.Location = New System.Drawing.Point(370, 499)
        Me.txtMidAtt.MaxLength = 5
        Me.txtMidAtt.Name = "txtMidAtt"
        Me.txtMidAtt.Size = New System.Drawing.Size(53, 21)
        Me.txtMidAtt.TabIndex = 20
        '
        'txtMLab
        '
        Me.txtMLab.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMLab.Location = New System.Drawing.Point(370, 558)
        Me.txtMLab.MaxLength = 5
        Me.txtMLab.Name = "txtMLab"
        Me.txtMLab.Size = New System.Drawing.Size(53, 21)
        Me.txtMLab.TabIndex = 21
        '
        'txtMCase
        '
        Me.txtMCase.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMCase.Location = New System.Drawing.Point(370, 615)
        Me.txtMCase.MaxLength = 5
        Me.txtMCase.Name = "txtMCase"
        Me.txtMCase.Size = New System.Drawing.Size(53, 21)
        Me.txtMCase.TabIndex = 22
        '
        'txtMRec
        '
        Me.txtMRec.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRec.Location = New System.Drawing.Point(370, 670)
        Me.txtMRec.MaxLength = 5
        Me.txtMRec.Name = "txtMRec"
        Me.txtMRec.Size = New System.Drawing.Size(53, 21)
        Me.txtMRec.TabIndex = 23
        '
        'txtMQ1Score
        '
        Me.txtMQ1Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ1Score.Location = New System.Drawing.Point(463, 573)
        Me.txtMQ1Score.MaxLength = 5
        Me.txtMQ1Score.Name = "txtMQ1Score"
        Me.txtMQ1Score.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ1Score.TabIndex = 24
        '
        'txtMQ1Total
        '
        Me.txtMQ1Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ1Total.Location = New System.Drawing.Point(549, 573)
        Me.txtMQ1Total.MaxLength = 5
        Me.txtMQ1Total.Name = "txtMQ1Total"
        Me.txtMQ1Total.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ1Total.TabIndex = 25
        '
        'txtMQ2Score
        '
        Me.txtMQ2Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ2Score.Location = New System.Drawing.Point(624, 573)
        Me.txtMQ2Score.MaxLength = 5
        Me.txtMQ2Score.Name = "txtMQ2Score"
        Me.txtMQ2Score.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ2Score.TabIndex = 26
        '
        'txtMQ2Total
        '
        Me.txtMQ2Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ2Total.Location = New System.Drawing.Point(709, 572)
        Me.txtMQ2Total.MaxLength = 5
        Me.txtMQ2Total.Name = "txtMQ2Total"
        Me.txtMQ2Total.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ2Total.TabIndex = 27
        '
        'txtMQ3Score
        '
        Me.txtMQ3Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ3Score.Location = New System.Drawing.Point(466, 643)
        Me.txtMQ3Score.MaxLength = 5
        Me.txtMQ3Score.Name = "txtMQ3Score"
        Me.txtMQ3Score.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ3Score.TabIndex = 28
        '
        'txtMQ3Total
        '
        Me.txtMQ3Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ3Total.Location = New System.Drawing.Point(551, 644)
        Me.txtMQ3Total.MaxLength = 5
        Me.txtMQ3Total.Name = "txtMQ3Total"
        Me.txtMQ3Total.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ3Total.TabIndex = 29
        '
        'txtMQ4Score
        '
        Me.txtMQ4Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ4Score.Location = New System.Drawing.Point(627, 642)
        Me.txtMQ4Score.MaxLength = 5
        Me.txtMQ4Score.Name = "txtMQ4Score"
        Me.txtMQ4Score.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ4Score.TabIndex = 30
        '
        'txtMQ4Total
        '
        Me.txtMQ4Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQ4Total.Location = New System.Drawing.Point(711, 642)
        Me.txtMQ4Total.MaxLength = 5
        Me.txtMQ4Total.Name = "txtMQ4Total"
        Me.txtMQ4Total.Size = New System.Drawing.Size(43, 21)
        Me.txtMQ4Total.TabIndex = 31
        '
        'txtMExamScore
        '
        Me.txtMExamScore.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMExamScore.Location = New System.Drawing.Point(402, 726)
        Me.txtMExamScore.MaxLength = 5
        Me.txtMExamScore.Name = "txtMExamScore"
        Me.txtMExamScore.Size = New System.Drawing.Size(43, 21)
        Me.txtMExamScore.TabIndex = 32
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(487, 726)
        Me.TextBox13.MaxLength = 5
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(43, 21)
        Me.TextBox13.TabIndex = 33
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(561, 726)
        Me.TextBox14.MaxLength = 5
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(43, 21)
        Me.TextBox14.TabIndex = 34
        '
        'txtMQuizPerc
        '
        Me.txtMQuizPerc.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMQuizPerc.Location = New System.Drawing.Point(602, 499)
        Me.txtMQuizPerc.MaxLength = 5
        Me.txtMQuizPerc.Name = "txtMQuizPerc"
        Me.txtMQuizPerc.ReadOnly = True
        Me.txtMQuizPerc.Size = New System.Drawing.Size(43, 21)
        Me.txtMQuizPerc.TabIndex = 35
        '
        'txtFAtt
        '
        Me.txtFAtt.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAtt.Location = New System.Drawing.Point(966, 498)
        Me.txtFAtt.MaxLength = 5
        Me.txtFAtt.Name = "txtFAtt"
        Me.txtFAtt.Size = New System.Drawing.Size(53, 21)
        Me.txtFAtt.TabIndex = 36
        '
        'txtFLab
        '
        Me.txtFLab.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFLab.Location = New System.Drawing.Point(966, 557)
        Me.txtFLab.MaxLength = 5
        Me.txtFLab.Name = "txtFLab"
        Me.txtFLab.Size = New System.Drawing.Size(53, 21)
        Me.txtFLab.TabIndex = 37
        '
        'txtFCase
        '
        Me.txtFCase.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFCase.Location = New System.Drawing.Point(966, 613)
        Me.txtFCase.MaxLength = 5
        Me.txtFCase.Name = "txtFCase"
        Me.txtFCase.Size = New System.Drawing.Size(53, 21)
        Me.txtFCase.TabIndex = 38
        '
        'txtFRec
        '
        Me.txtFRec.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFRec.Location = New System.Drawing.Point(966, 669)
        Me.txtFRec.MaxLength = 5
        Me.txtFRec.Name = "txtFRec"
        Me.txtFRec.Size = New System.Drawing.Size(53, 21)
        Me.txtFRec.TabIndex = 39
        '
        'txtFQuizPerc
        '
        Me.txtFQuizPerc.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuizPerc.Location = New System.Drawing.Point(1197, 498)
        Me.txtFQuizPerc.MaxLength = 5
        Me.txtFQuizPerc.Name = "txtFQuizPerc"
        Me.txtFQuizPerc.ReadOnly = True
        Me.txtFQuizPerc.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuizPerc.TabIndex = 40
        '
        'txtFQ1Score
        '
        Me.txtFQ1Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQ1Score.Location = New System.Drawing.Point(1058, 572)
        Me.txtFQ1Score.MaxLength = 5
        Me.txtFQ1Score.Name = "txtFQ1Score"
        Me.txtFQ1Score.Size = New System.Drawing.Size(43, 21)
        Me.txtFQ1Score.TabIndex = 41
        '
        'txtFQuiz1Total
        '
        Me.txtFQuiz1Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuiz1Total.Location = New System.Drawing.Point(1145, 571)
        Me.txtFQuiz1Total.MaxLength = 5
        Me.txtFQuiz1Total.Name = "txtFQuiz1Total"
        Me.txtFQuiz1Total.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuiz1Total.TabIndex = 42
        '
        'txtFQuiz2Score
        '
        Me.txtFQuiz2Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuiz2Score.Location = New System.Drawing.Point(1220, 572)
        Me.txtFQuiz2Score.MaxLength = 5
        Me.txtFQuiz2Score.Name = "txtFQuiz2Score"
        Me.txtFQuiz2Score.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuiz2Score.TabIndex = 43
        '
        'txtFQuiz2Total
        '
        Me.txtFQuiz2Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuiz2Total.Location = New System.Drawing.Point(1305, 571)
        Me.txtFQuiz2Total.MaxLength = 5
        Me.txtFQuiz2Total.Name = "txtFQuiz2Total"
        Me.txtFQuiz2Total.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuiz2Total.TabIndex = 44
        '
        'txtFQuiz3Score
        '
        Me.txtFQuiz3Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuiz3Score.Location = New System.Drawing.Point(1062, 643)
        Me.txtFQuiz3Score.MaxLength = 5
        Me.txtFQuiz3Score.Name = "txtFQuiz3Score"
        Me.txtFQuiz3Score.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuiz3Score.TabIndex = 45
        '
        'txtFQuiz3Total
        '
        Me.txtFQuiz3Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuiz3Total.Location = New System.Drawing.Point(1146, 643)
        Me.txtFQuiz3Total.MaxLength = 5
        Me.txtFQuiz3Total.Name = "txtFQuiz3Total"
        Me.txtFQuiz3Total.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuiz3Total.TabIndex = 46
        '
        'txtFQuiz4Score
        '
        Me.txtFQuiz4Score.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuiz4Score.Location = New System.Drawing.Point(1223, 641)
        Me.txtFQuiz4Score.MaxLength = 5
        Me.txtFQuiz4Score.Name = "txtFQuiz4Score"
        Me.txtFQuiz4Score.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuiz4Score.TabIndex = 47
        '
        'txtFQuiz4Total
        '
        Me.txtFQuiz4Total.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQuiz4Total.Location = New System.Drawing.Point(1308, 640)
        Me.txtFQuiz4Total.MaxLength = 5
        Me.txtFQuiz4Total.Name = "txtFQuiz4Total"
        Me.txtFQuiz4Total.Size = New System.Drawing.Size(43, 21)
        Me.txtFQuiz4Total.TabIndex = 48
        '
        'txtFExamScore
        '
        Me.txtFExamScore.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFExamScore.Location = New System.Drawing.Point(965, 727)
        Me.txtFExamScore.MaxLength = 5
        Me.txtFExamScore.Name = "txtFExamScore"
        Me.txtFExamScore.Size = New System.Drawing.Size(43, 21)
        Me.txtFExamScore.TabIndex = 49
        '
        'txtFExamTotal
        '
        Me.txtFExamTotal.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFExamTotal.Location = New System.Drawing.Point(1049, 728)
        Me.txtFExamTotal.MaxLength = 5
        Me.txtFExamTotal.Name = "txtFExamTotal"
        Me.txtFExamTotal.Size = New System.Drawing.Size(43, 21)
        Me.txtFExamTotal.TabIndex = 50
        '
        'txtFExamPerc
        '
        Me.txtFExamPerc.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFExamPerc.Location = New System.Drawing.Point(1121, 727)
        Me.txtFExamPerc.MaxLength = 5
        Me.txtFExamPerc.Name = "txtFExamPerc"
        Me.txtFExamPerc.ReadOnly = True
        Me.txtFExamPerc.Size = New System.Drawing.Size(43, 21)
        Me.txtFExamPerc.TabIndex = 51
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.ComboBox1.Location = New System.Drawing.Point(593, 379)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(385, 30)
        Me.ComboBox1.TabIndex = 52
        '
        'txtMidGrade
        '
        Me.txtMidGrade.AutoSize = True
        Me.txtMidGrade.BackColor = System.Drawing.Color.Transparent
        Me.txtMidGrade.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMidGrade.ForeColor = System.Drawing.Color.White
        Me.txtMidGrade.Location = New System.Drawing.Point(451, 433)
        Me.txtMidGrade.Name = "txtMidGrade"
        Me.txtMidGrade.Size = New System.Drawing.Size(57, 22)
        Me.txtMidGrade.TabIndex = 53
        Me.txtMidGrade.Text = "00.00"
        '
        'txtFinGrade
        '
        Me.txtFinGrade.AutoSize = True
        Me.txtFinGrade.BackColor = System.Drawing.Color.Transparent
        Me.txtFinGrade.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinGrade.ForeColor = System.Drawing.Color.White
        Me.txtFinGrade.Location = New System.Drawing.Point(1042, 437)
        Me.txtFinGrade.Name = "txtFinGrade"
        Me.txtFinGrade.Size = New System.Drawing.Size(57, 22)
        Me.txtFinGrade.TabIndex = 54
        Me.txtFinGrade.Text = "00.00"
        '
        'txtSemGrade
        '
        Me.txtSemGrade.AutoSize = True
        Me.txtSemGrade.BackColor = System.Drawing.Color.Transparent
        Me.txtSemGrade.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemGrade.ForeColor = System.Drawing.Color.White
        Me.txtSemGrade.Location = New System.Drawing.Point(439, 800)
        Me.txtSemGrade.Name = "txtSemGrade"
        Me.txtSemGrade.Size = New System.Drawing.Size(57, 22)
        Me.txtSemGrade.TabIndex = 55
        Me.txtSemGrade.Text = "00.00"
        '
        'txtCompGrade
        '
        Me.txtCompGrade.AutoSize = True
        Me.txtCompGrade.BackColor = System.Drawing.Color.Transparent
        Me.txtCompGrade.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompGrade.ForeColor = System.Drawing.Color.White
        Me.txtCompGrade.Location = New System.Drawing.Point(749, 800)
        Me.txtCompGrade.Name = "txtCompGrade"
        Me.txtCompGrade.Size = New System.Drawing.Size(57, 22)
        Me.txtCompGrade.TabIndex = 56
        Me.txtCompGrade.Text = "00.00"
        '
        'txCollegeGrade
        '
        Me.txCollegeGrade.AutoSize = True
        Me.txCollegeGrade.BackColor = System.Drawing.Color.Transparent
        Me.txCollegeGrade.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCollegeGrade.ForeColor = System.Drawing.Color.White
        Me.txCollegeGrade.Location = New System.Drawing.Point(823, 800)
        Me.txCollegeGrade.Name = "txCollegeGrade"
        Me.txCollegeGrade.Size = New System.Drawing.Size(57, 22)
        Me.txCollegeGrade.TabIndex = 57
        Me.txCollegeGrade.Text = "00.00"
        '
        'maskedTxtStudId
        '
        Me.maskedTxtStudId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.maskedTxtStudId.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedTxtStudId.Location = New System.Drawing.Point(426, 220)
        Me.maskedTxtStudId.Mask = "00-00000"
        Me.maskedTxtStudId.Name = "maskedTxtStudId"
        Me.maskedTxtStudId.Size = New System.Drawing.Size(115, 20)
        Me.maskedTxtStudId.TabIndex = 58
        Me.maskedTxtStudId.ValidatingType = GetType(Integer)
        '
        'txtStudName
        '
        Me.txtStudName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudName.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudName.Location = New System.Drawing.Point(426, 260)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.Size = New System.Drawing.Size(256, 20)
        Me.txtStudName.TabIndex = 59
        '
        'comboMidNumQuiz
        '
        Me.comboMidNumQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMidNumQuiz.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMidNumQuiz.FormattingEnabled = True
        Me.comboMidNumQuiz.Items.AddRange(New Object() {"2", "3", "4"})
        Me.comboMidNumQuiz.Location = New System.Drawing.Point(534, 498)
        Me.comboMidNumQuiz.Name = "comboMidNumQuiz"
        Me.comboMidNumQuiz.Size = New System.Drawing.Size(43, 24)
        Me.comboMidNumQuiz.TabIndex = 60
        '
        'comboFinNumQuiz
        '
        Me.comboFinNumQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFinNumQuiz.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboFinNumQuiz.FormattingEnabled = True
        Me.comboFinNumQuiz.Items.AddRange(New Object() {"2", "3", "4"})
        Me.comboFinNumQuiz.Location = New System.Drawing.Point(1130, 497)
        Me.comboFinNumQuiz.Name = "comboFinNumQuiz"
        Me.comboFinNumQuiz.Size = New System.Drawing.Size(43, 24)
        Me.comboFinNumQuiz.TabIndex = 61
        '
        'btnBackEncode
        '
        Me.btnBackEncode.BackColor = System.Drawing.Color.Transparent
        Me.btnBackEncode.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.backButton
        Me.btnBackEncode.FlatAppearance.BorderSize = 0
        Me.btnBackEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackEncode.Location = New System.Drawing.Point(1081, 89)
        Me.btnBackEncode.Name = "btnBackEncode"
        Me.btnBackEncode.Size = New System.Drawing.Size(239, 38)
        Me.btnBackEncode.TabIndex = 62
        Me.btnBackEncode.UseVisualStyleBackColor = False
        '
        'btnComputeMid
        '
        Me.btnComputeMid.BackColor = System.Drawing.Color.Transparent
        Me.btnComputeMid.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.computeButton
        Me.btnComputeMid.FlatAppearance.BorderSize = 0
        Me.btnComputeMid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputeMid.Location = New System.Drawing.Point(629, 708)
        Me.btnComputeMid.Name = "btnComputeMid"
        Me.btnComputeMid.Size = New System.Drawing.Size(137, 42)
        Me.btnComputeMid.TabIndex = 63
        Me.btnComputeMid.UseVisualStyleBackColor = False
        '
        'btnComputeFin
        '
        Me.btnComputeFin.BackColor = System.Drawing.Color.Transparent
        Me.btnComputeFin.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.computeButton
        Me.btnComputeFin.FlatAppearance.BorderSize = 0
        Me.btnComputeFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputeFin.Location = New System.Drawing.Point(1223, 715)
        Me.btnComputeFin.Name = "btnComputeFin"
        Me.btnComputeFin.Size = New System.Drawing.Size(137, 42)
        Me.btnComputeFin.TabIndex = 64
        Me.btnComputeFin.UseVisualStyleBackColor = False
        '
        'btnSaveEncode
        '
        Me.btnSaveEncode.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveEncode.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.saveButton
        Me.btnSaveEncode.FlatAppearance.BorderSize = 0
        Me.btnSaveEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEncode.Location = New System.Drawing.Point(1252, 803)
        Me.btnSaveEncode.Name = "btnSaveEncode"
        Me.btnSaveEncode.Size = New System.Drawing.Size(137, 42)
        Me.btnSaveEncode.TabIndex = 65
        Me.btnSaveEncode.UseVisualStyleBackColor = False
        '
        'encodeGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nexus_GMS_Dev.My.Resources.Resources.encodeGradesForm
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.btnSaveEncode)
        Me.Controls.Add(Me.btnComputeFin)
        Me.Controls.Add(Me.btnComputeMid)
        Me.Controls.Add(Me.btnBackEncode)
        Me.Controls.Add(Me.comboFinNumQuiz)
        Me.Controls.Add(Me.comboMidNumQuiz)
        Me.Controls.Add(Me.txtStudName)
        Me.Controls.Add(Me.maskedTxtStudId)
        Me.Controls.Add(Me.txCollegeGrade)
        Me.Controls.Add(Me.txtCompGrade)
        Me.Controls.Add(Me.txtSemGrade)
        Me.Controls.Add(Me.txtFinGrade)
        Me.Controls.Add(Me.txtMidGrade)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtFExamPerc)
        Me.Controls.Add(Me.txtFExamTotal)
        Me.Controls.Add(Me.txtFExamScore)
        Me.Controls.Add(Me.txtFQuiz4Total)
        Me.Controls.Add(Me.txtFQuiz4Score)
        Me.Controls.Add(Me.txtFQuiz3Total)
        Me.Controls.Add(Me.txtFQuiz3Score)
        Me.Controls.Add(Me.txtFQuiz2Total)
        Me.Controls.Add(Me.txtFQuiz2Score)
        Me.Controls.Add(Me.txtFQuiz1Total)
        Me.Controls.Add(Me.txtFQ1Score)
        Me.Controls.Add(Me.txtFQuizPerc)
        Me.Controls.Add(Me.txtFRec)
        Me.Controls.Add(Me.txtFCase)
        Me.Controls.Add(Me.txtFLab)
        Me.Controls.Add(Me.txtFAtt)
        Me.Controls.Add(Me.txtMQuizPerc)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.txtMExamScore)
        Me.Controls.Add(Me.txtMQ4Total)
        Me.Controls.Add(Me.txtMQ4Score)
        Me.Controls.Add(Me.txtMQ3Total)
        Me.Controls.Add(Me.txtMQ3Score)
        Me.Controls.Add(Me.txtMQ2Total)
        Me.Controls.Add(Me.txtMQ2Score)
        Me.Controls.Add(Me.txtMQ1Total)
        Me.Controls.Add(Me.txtMQ1Score)
        Me.Controls.Add(Me.txtMRec)
        Me.Controls.Add(Me.txtMCase)
        Me.Controls.Add(Me.txtMLab)
        Me.Controls.Add(Me.txtMidAtt)
        Me.Controls.Add(Me.comboSectionEncode)
        Me.Controls.Add(Me.comboProgramEncode)
        Me.Controls.Add(Me.comboCourseEncode)
        Me.Controls.Add(Me.lblProfNameEncode)
        Me.Controls.Add(Me.picEncodeGBg)
        Me.Name = "encodeGrades"
        Me.Text = "encodeGrades"
        CType(Me.picEncodeGBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEncodeGBg As PictureBox
    Friend WithEvents lblProfNameEncode As Label
    Friend WithEvents comboCourseEncode As ComboBox
    Friend WithEvents comboProgramEncode As ComboBox
    Friend WithEvents comboSectionEncode As ComboBox
    Friend WithEvents txtMidAtt As TextBox
    Friend WithEvents txtMLab As TextBox
    Friend WithEvents txtMCase As TextBox
    Friend WithEvents txtMRec As TextBox
    Friend WithEvents txtMQ1Score As TextBox
    Friend WithEvents txtMQ1Total As TextBox
    Friend WithEvents txtMQ2Score As TextBox
    Friend WithEvents txtMQ2Total As TextBox
    Friend WithEvents txtMQ3Score As TextBox
    Friend WithEvents txtMQ3Total As TextBox
    Friend WithEvents txtMQ4Score As TextBox
    Friend WithEvents txtMQ4Total As TextBox
    Friend WithEvents txtMExamScore As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents txtMQuizPerc As TextBox
    Friend WithEvents txtFAtt As TextBox
    Friend WithEvents txtFLab As TextBox
    Friend WithEvents txtFCase As TextBox
    Friend WithEvents txtFRec As TextBox
    Friend WithEvents txtFQuizPerc As TextBox
    Friend WithEvents txtFQ1Score As TextBox
    Friend WithEvents txtFQuiz1Total As TextBox
    Friend WithEvents txtFQuiz2Score As TextBox
    Friend WithEvents txtFQuiz2Total As TextBox
    Friend WithEvents txtFQuiz3Score As TextBox
    Friend WithEvents txtFQuiz3Total As TextBox
    Friend WithEvents txtFQuiz4Score As TextBox
    Friend WithEvents txtFQuiz4Total As TextBox
    Friend WithEvents txtFExamScore As TextBox
    Friend WithEvents txtFExamTotal As TextBox
    Friend WithEvents txtFExamPerc As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtMidGrade As Label
    Friend WithEvents txtFinGrade As Label
    Friend WithEvents txtSemGrade As Label
    Friend WithEvents txtCompGrade As Label
    Friend WithEvents txCollegeGrade As Label
    Friend WithEvents maskedTxtStudId As MaskedTextBox
    Friend WithEvents txtStudName As TextBox
    Friend WithEvents comboMidNumQuiz As ComboBox
    Friend WithEvents comboFinNumQuiz As ComboBox
    Friend WithEvents btnBackEncode As Button
    Friend WithEvents btnComputeMid As Button
    Friend WithEvents btnComputeFin As Button
    Friend WithEvents btnSaveEncode As Button
End Class

Imports Mysqlx.Session

Public Class encodeGrades

    Private isClearing As Boolean = False
    Private Sub encodeGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub encodeGrades_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub maskedTxtStudId_TextChanged(sender As Object, e As EventArgs) Handles maskedTxtStudId.TextChanged
        If maskedTxtStudId.Text = "23-00265" Then
            txtStudName.Text = "Keith Tornea"
            txtStudName.Enabled = True
            comboProgramEncode.Enabled = True
            comboProgramEncode.SelectedItem = "BS in Information Technology"
            comboSectionEncode.Enabled = True
            comboSectionEncode.SelectedItem = "2A"
            comboCourseEncode.Enabled = True
            comboCourseEncode.SelectedIndex = 0

            comboSem.Enabled = True
            comboSem.SelectedItem = "1st Semester"

            enableMidterm()
        Else
            disableMidterm()
            txtStudName.Enabled = False
            comboProgramEncode.Enabled = False
            comboSectionEncode.Enabled = False
            comboCourseEncode.Enabled = False
            comboSem.Enabled = False

            txtStudName.Clear()
            comboProgramEncode.SelectedIndex = -1
            comboSectionEncode.SelectedIndex = -1
            comboCourseEncode.SelectedIndex = -1
            comboSem.SelectedIndex = -1
            clearMidterm()

        End If
    End Sub

    Private Sub btnBackEncode_Click(sender As Object, e As EventArgs) Handles btnBackEncode.Click
        Me.Close()
    End Sub

    Public Sub enableMidterm()
        txtMidAtt.Enabled = True
        txtMLab.Enabled = True
        txtMCase.Enabled = True
        txtMRec.Enabled = True
        txtMExamScore.Enabled = True
        txtMExamTotal.Enabled = True
        comboMidNumQuiz.Enabled = True
        comboMidNumQuiz.SelectedItem = "2"
    End Sub

    Public Sub disableMidterm()
        txtMidAtt.Enabled = False
        txtMLab.Enabled = False
        txtMCase.Enabled = False
        txtMRec.Enabled = False
        txtMExamScore.Enabled = False
        txtMExamTotal.Enabled = False
        comboMidNumQuiz.Enabled = False
        comboMidNumQuiz.SelectedIndex = -1
    End Sub

    Public Sub clearMidterm()
        txtMidAtt.Clear()
        txtMLab.Clear()
        txtMCase.Clear()
        txtMRec.Clear()
        txtMExamScore.Clear()
        txtMExamTotal.Clear()
    End Sub

    Public Sub clearQuizzes()
        txtMQ1Score.Clear()
        txtMQ1Total.Clear()
        txtMQ2Score.Clear()
        txtMQ2Total.Clear()
        txtMQ3Score.Clear()
        txtMQ3Total.Clear()
        txtMQ4Score.Clear()
        txtMQ4Total.Clear()
        txtMQuizPerc.Clear()
    End Sub

    Public Sub enableFinals()
        txtFAtt.Enabled = False
        txtFLab.Enabled = False
    End Sub

    Private Sub comboMidNumQuiz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMidNumQuiz.SelectedIndexChanged

        txtMQ1Score.Enabled = False
        txtMQ1Total.Enabled = False
        txtMQ2Score.Enabled = False
        txtMQ2Total.Enabled = False
        txtMQ3Score.Enabled = False
        txtMQ3Total.Enabled = False
        txtMQ4Score.Enabled = False
        txtMQ4Total.Enabled = False
        clearQuizzes()

        If comboMidNumQuiz.SelectedItem = "2" Then
            txtMQ1Score.Enabled = True
            txtMQ1Total.Enabled = True
            txtMQ2Score.Enabled = True
            txtMQ2Total.Enabled = True
        ElseIf comboMidNumQuiz.SelectedItem = "3" Then
            txtMQ1Score.Enabled = True
            txtMQ1Total.Enabled = True
            txtMQ2Score.Enabled = True
            txtMQ2Total.Enabled = True
            txtMQ3Score.Enabled = True
            txtMQ3Total.Enabled = True
        ElseIf comboMidNumQuiz.SelectedItem = "4" Then
            txtMQ1Score.Enabled = True
            txtMQ1Total.Enabled = True
            txtMQ2Score.Enabled = True
            txtMQ2Total.Enabled = True
            txtMQ3Score.Enabled = True
            txtMQ3Total.Enabled = True
            txtMQ4Score.Enabled = True
            txtMQ4Total.Enabled = True
        End If
    End Sub

    Private Sub txtMidAtt_TextChanged(sender As Object, e As EventArgs) Handles txtMidAtt.TextChanged
        validateTxtInput(txtMidAtt)
        computeMidterm()
    End Sub

    Private Sub txtMLab_TextChanged(sender As Object, e As EventArgs) Handles txtMLab.TextChanged
        validateTxtInput(txtMLab)
        computeMidterm()
    End Sub

    Private Sub txtMCase_TextChanged(sender As Object, e As EventArgs) Handles txtMCase.TextChanged
        validateTxtInput(txtMCase)
        computeMidterm()
    End Sub

    Private Sub txtMRec_TextChanged(sender As Object, e As EventArgs) Handles txtMRec.TextChanged
        validateTxtInput(txtMRec)
        computeMidterm()
    End Sub

    Private Sub txtMExamScore_TextChanged(sender As Object, e As EventArgs) Handles txtMExamScore.TextChanged
        validateTxtInput(txtMExamScore)
        If txtMExamScore.Text.Length <> 0 And txtMExamTotal.Text.Length <> 0 Then
            txtMExamPerc.Text = (Integer.Parse(txtMExamScore.Text) / Integer.Parse(txtMExamTotal.Text)) * 50 + 50
        End If

        computeMidterm()
    End Sub

    Private Sub txtMExamTotal_TextChanged(sender As Object, e As EventArgs) Handles txtMExamTotal.TextChanged
        validateTxtInput(txtMExamTotal)
        If txtMExamScore.Text.Length <> 0 And txtMExamTotal.Text.Length <> 0 Then
            txtMExamPerc.Text = (Integer.Parse(txtMExamScore.Text) / Integer.Parse(txtMExamTotal.Text)) * 50 + 50
        End If
        computeMidterm()
    End Sub

    Private Sub txtMQ1Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ1Score.TextChanged
        validateTxtInput(txtMQ1Score)
        computeQuizMidterm()
    End Sub

    Private Sub txtMQ1Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ1Total.TextChanged
        validateTxtInput(txtMQ1Total)
        computeQuizMidterm()
    End Sub

    Private Sub txtMQ2Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ2Score.TextChanged
        validateTxtInput(txtMQ2Score)
        computeQuizMidterm()
    End Sub

    Private Sub txtMQ2Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ2Total.TextChanged
        validateTxtInput(txtMQ2Total)
        computeQuizMidterm()
    End Sub

    Private Sub txtMQ3Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ3Score.TextChanged
        validateTxtInput(txtMQ3Score)
        computeQuizMidterm()
    End Sub

    Private Sub txtMQ3Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ3Total.TextChanged
        validateTxtInput(txtMQ3Total)
        computeQuizMidterm()
    End Sub

    Private Sub txtMQ4Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ4Score.TextChanged
        validateTxtInput(txtMQ4Score)
        computeQuizMidterm()
    End Sub

    Private Sub txtMQ4Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ4Total.TextChanged
        validateTxtInput(txtMQ4Total)
        computeQuizMidterm()
    End Sub

    Public Sub computeQuizMidterm()
        If comboMidNumQuiz.SelectedItem = "2" Then
            If txtMQ1Score.Text.Length <> 0 And txtMQ1Total.Text.Length <> 0 And txtMQ2Score.Text.Length <> 0 And txtMQ2Total.Text.Length <> 0 Then
                Dim quiz1Midterm = Integer.Parse(txtMQ1Score.Text)
                Dim quiz2Midterm = Integer.Parse(txtMQ2Score.Text)

                Dim quiz1MidtermItems = Integer.Parse(txtMQ1Total.Text)
                Dim quiz2MidtermItems = Integer.Parse(txtMQ2Total.Text)

                Dim totalScoreMidtermQuiz = quiz1Midterm + quiz2Midterm
                Dim totalScoreMidtermTotal = quiz1MidtermItems + quiz2MidtermItems

                txtMQuizPerc.Text = (totalScoreMidtermQuiz / totalScoreMidtermTotal) * 50 + 50
            End If
        ElseIf comboMidNumQuiz.SelectedItem = "3" Then
            If txtMQ1Score.Text.Length <> 0 And txtMQ1Total.Text.Length <> 0 And txtMQ2Score.Text.Length <> 0 And txtMQ2Total.Text.Length <> 0 And txtMQ3Score.Text.Length <> 0 And txtMQ3Total.Text.Length <> 0 Then
                Dim quiz1Midterm = Integer.Parse(txtMQ1Score.Text)
                Dim quiz2Midterm = Integer.Parse(txtMQ2Score.Text)
                Dim quiz3Midterm = Integer.Parse(txtMQ3Score.Text)

                Dim quiz1MidtermItems = Integer.Parse(txtMQ1Total.Text)
                Dim quiz2MidtermItems = Integer.Parse(txtMQ2Total.Text)
                Dim quiz3MidtermItems = Integer.Parse(txtMQ3Total.Text)

                Dim totalScoreMidtermQuiz = quiz1Midterm + quiz2Midterm + quiz3Midterm
                Dim totalScoreMidtermTotal = quiz1MidtermItems + quiz2MidtermItems + quiz3MidtermItems

                txtMQuizPerc.Text = (totalScoreMidtermQuiz / totalScoreMidtermTotal) * 50 + 50
            End If
        ElseIf comboMidNumQuiz.SelectedItem = "4" Then
            If txtMQ1Score.Text.Length <> 0 And txtMQ1Total.Text.Length <> 0 And txtMQ2Score.Text.Length <> 0 And txtMQ2Total.Text.Length <> 0 And txtMQ3Score.Text.Length <> 0 And txtMQ3Total.Text.Length <> 0 And txtMQ4Score.Text.Length <> 0 And txtMQ4Total.Text.Length <> 0 Then
                Dim quiz1Midterm = Integer.Parse(txtMQ1Score.Text)
                Dim quiz2Midterm = Integer.Parse(txtMQ2Score.Text)
                Dim quiz3Midterm = Integer.Parse(txtMQ3Score.Text)
                Dim quiz4Midterm = Integer.Parse(txtMQ4Score.Text)

                Dim quiz1MidtermItems = Integer.Parse(txtMQ1Total.Text)
                Dim quiz2MidtermItems = Integer.Parse(txtMQ2Total.Text)
                Dim quiz3MidtermItems = Integer.Parse(txtMQ3Total.Text)
                Dim quiz4MidtermItems = Integer.Parse(txtMQ4Total.Text)

                Dim totalScoreMidtermQuiz = quiz1Midterm + quiz2Midterm + quiz3Midterm + quiz4Midterm
                Dim totalScoreMidtermTotal = quiz1MidtermItems + quiz2MidtermItems + quiz3MidtermItems + quiz4MidtermItems

                txtMQuizPerc.Text = (totalScoreMidtermQuiz / totalScoreMidtermTotal) * 50 + 50
            End If
        End If
    End Sub

    Public Sub computeMidterm()
        If txtMidAtt.Text.Length <> 0 And txtMLab.Text.Length And txtMCase.Text.Length <> 0 And txtMRec.Text.Length <> 0 And txtMQuizPerc.Text.Length <> 0 And txtMExamPerc.Text.Length <> 0 Then
            Dim midAtt = Double.Parse(txtMidAtt.Text)
            Dim midLab = Double.Parse(txtMLab.Text)
            Dim midCase = Double.Parse(txtMCase.Text)
            Dim midRec = Double.Parse(txtMRec.Text)
            Dim midQuizzes = Double.Parse(txtMQuizPerc.Text)
            Dim midExam = Double.Parse(txtMExamPerc.Text)

            Dim lblMidtermGradeNum = (midAtt * 0.05) + (midQuizzes * 0.15) + (midLab * 0.2) + (midExam * 0.3) + (midCase * 0.2) + (midRec * 0.1)

            lblMidGrade.Text = Double.Parse(lblMidtermGradeNum.ToString("F2"))
        Else
            lblMidGrade.Text = "00.00"

        End If

    End Sub

    Private Sub validateTxtInput(textbox As TextBox)
        Dim number As Integer

        If isClearing Then
            Return
        End If

        If String.IsNullOrWhiteSpace(textbox.Text) Then
            Return
        End If

        If Decimal.TryParse(textbox.Text, number) Then
            If number < 0 OrElse number > 100 Then
                MessageBox.Show("Please Enter a Number between 0 and 100", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Error)

                isClearing = True
                textbox.Clear()
                isClearing = False
            End If
        ElseIf Not Decimal.TryParse(textbox.Text, number) AndAlso textbox.Text <> " "c Then
            MessageBox.Show("Invalid Input. Please Enter a Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)

            isClearing = True
            textbox.Clear()
            isClearing = False
        End If
    End Sub

    Private Sub btnComputeMid_Click(sender As Object, e As EventArgs) Handles btnComputeMid.Click
        computeMidterm()
    End Sub
End Class
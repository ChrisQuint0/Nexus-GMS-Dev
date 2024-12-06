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

    Public Sub clearMidQuizzes()
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

    Public Sub clearFinQuizzes()
        txtFQ1Score.Clear()
        txtFQuiz2Score.Clear()
        txtFQuiz3Score.Clear()
        txtFQuiz4Score.Clear()
        txtFQuiz1Total.Clear()
        txtFQuiz2Total.Clear()
        txtFQuiz3Total.Clear()
        txtFQuiz4Total.Clear()
    End Sub

    Public Sub enableFinals()
        txtFAtt.Enabled = True
        txtFLab.Enabled = True
        txtFCase.Enabled = True
        txtFRec.Enabled = True
        txtFExamScore.Enabled = True
        txtFExamTotal.Enabled = True
        comboFinNumQuiz.Enabled = True
        comboFinNumQuiz.SelectedItem = "2"

    End Sub

    Public Sub disableFinals()
        txtFAtt.Enabled = False
        txtFLab.Enabled = False
        txtFCase.Enabled = False
        txtFRec.Enabled = False
        txtFExamScore.Enabled = False
        txtFExamTotal.Enabled = False
        comboFinNumQuiz.Enabled = False
        comboFinNumQuiz.SelectedIndex = -1
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
        clearMidQuizzes()

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

    Private Sub comboFinNumQuiz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboFinNumQuiz.SelectedIndexChanged
        txtFQ1Score.Enabled = False
        txtFQuiz2Score.Enabled = False
        txtFQuiz3Score.Enabled = False
        txtFQuiz4Score.Enabled = False
        txtFQuiz1Total.Enabled = False
        txtFQuiz2Total.Enabled = False
        txtFQuiz3Total.Enabled = False
        txtFQuiz4Total.Enabled = False
        clearFinQuizzes()

        If comboFinNumQuiz.SelectedItem = "2" Then
            txtFQ1Score.Enabled = True
            txtFQuiz2Score.Enabled = True
            txtFQuiz1Total.Enabled = True
            txtFQuiz2Total.Enabled = True
        ElseIf comboFinNumQuiz.SelectedItem = "3" Then
            txtFQ1Score.Enabled = True
            txtFQuiz2Score.Enabled = True
            txtFQuiz3Score.Enabled = True
            txtFQuiz1Total.Enabled = True
            txtFQuiz2Total.Enabled = True
            txtFQuiz3Total.Enabled = True
        ElseIf comboFinNumQuiz.SelectedItem = "4" Then
            txtFQ1Score.Enabled = True
            txtFQuiz2Score.Enabled = True
            txtFQuiz3Score.Enabled = True
            txtFQuiz4Score.Enabled = True
            txtFQuiz1Total.Enabled = True
            txtFQuiz2Total.Enabled = True
            txtFQuiz3Total.Enabled = True
            txtFQuiz4Total.Enabled = True
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

        computeMidterm()
    End Sub

    Private Sub txtMExamTotal_TextChanged(sender As Object, e As EventArgs) Handles txtMExamTotal.TextChanged
        validateTxtInput(txtMExamTotal)


        computeMidterm()
    End Sub

    Private Sub txtMQ1Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ1Score.TextChanged
        validateTxtInput(txtMQ1Score)
        computeQuizMidterm()
        computeMidterm()
    End Sub

    Private Sub txtMQ1Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ1Total.TextChanged
        validateTxtInput(txtMQ1Total)
        computeQuizMidterm()
        computeMidterm()
    End Sub

    Private Sub txtMQ2Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ2Score.TextChanged
        validateTxtInput(txtMQ2Score)
        computeQuizMidterm()
        computeMidterm()
    End Sub

    Private Sub txtMQ2Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ2Total.TextChanged
        validateTxtInput(txtMQ2Total)
        computeQuizMidterm()
        computeMidterm()
    End Sub

    Private Sub txtMQ3Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ3Score.TextChanged
        validateTxtInput(txtMQ3Score)

        computeQuizMidterm()
        computeMidterm()
    End Sub

    Private Sub txtMQ3Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ3Total.TextChanged
        validateTxtInput(txtMQ3Total)

        computeQuizMidterm()
        computeMidterm()
    End Sub

    Private Sub txtMQ4Score_TextChanged(sender As Object, e As EventArgs) Handles txtMQ4Score.TextChanged

        computeQuizMidterm()
        computeMidterm()
    End Sub

    Private Sub txtMQ4Total_TextChanged(sender As Object, e As EventArgs) Handles txtMQ4Total.TextChanged
        validateTxtInput(txtMQ4Total)

        computeQuizMidterm()
        computeMidterm()
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

    Public Sub computeQuizFinals()
        If comboFinNumQuiz.SelectedItem = "2" Then
            If txtFQ1Score.Text.Length <> 0 And txtFQuiz1Total.Text.Length <> 0 And txtFQuiz2Score.Text.Length <> 0 And txtFQuiz2Total.Text.Length <> 0 Then
                Dim quiz1Finals = Integer.Parse(txtFQ1Score.Text)
                Dim quiz2Finals = Integer.Parse(txtFQuiz2Score.Text)

                Dim quiz1FinalsItems = Integer.Parse(txtFQuiz1Total.Text)
                Dim quiz2FinalsItems = Integer.Parse(txtFQuiz2Total.Text)

                Dim totalScoreFinalsQuiz = quiz1Finals + quiz2Finals
                Dim totalScoreFinalsTotal = quiz1FinalsItems + quiz2FinalsItems

                txtFQuizPerc.Text = (totalScoreFinalsQuiz / totalScoreFinalsTotal) * 50 + 50
            End If
        ElseIf comboFinNumQuiz.SelectedItem = "3" Then
            If txtFQ1Score.Text.Length <> 0 And txtFQuiz1Total.Text.Length <> 0 And txtFQuiz2Score.Text.Length <> 0 And txtFQuiz2Total.Text.Length <> 0 And txtFQuiz3Score.Text.Length <> 0 And txtFQuiz3Total.Text.Length <> 0 Then
                Dim quiz1Finals = Integer.Parse(txtFQ1Score.Text)
                Dim quiz2Finals = Integer.Parse(txtFQuiz2Score.Text)
                Dim quiz3Finals = Integer.Parse(txtFQuiz3Score.Text)

                Dim quiz1FinalsItems = Integer.Parse(txtFQuiz1Total.Text)
                Dim quiz2FinalsItems = Integer.Parse(txtFQuiz2Total.Text)
                Dim quiz3FinalsItems = Integer.Parse(txtFQuiz3Total.Text)

                Dim totalScoreFinalsQuiz = quiz1Finals + quiz2Finals + quiz3Finals
                Dim totalScoreFinalsTotal = quiz1FinalsItems + quiz2FinalsItems + quiz3FinalsItems

                txtFQuizPerc.Text = (totalScoreFinalsQuiz / totalScoreFinalsTotal) * 50 + 50
            End If
        ElseIf comboFinNumQuiz.SelectedItem = "4" Then
            If txtFQ1Score.Text.Length <> 0 And txtFQuiz1Total.Text.Length <> 0 And txtFQuiz2Score.Text.Length <> 0 And txtFQuiz2Total.Text.Length <> 0 And txtFQuiz3Score.Text.Length <> 0 And txtFQuiz3Total.Text.Length <> 0 And txtFQuiz4Score.Text.Length <> 0 And txtFQuiz4Total.Text.Length <> 0 Then
                Dim quiz1Finals = Integer.Parse(txtFQ1Score.Text)
                Dim quiz2Finals = Integer.Parse(txtFQuiz2Score.Text)
                Dim quiz3Finals = Integer.Parse(txtFQuiz3Score.Text)
                Dim quiz4Finals = Integer.Parse(txtFQuiz4Score.Text)

                Dim quiz1FinalsItems = Integer.Parse(txtFQuiz1Total.Text)
                Dim quiz2FinalsItems = Integer.Parse(txtFQuiz2Total.Text)
                Dim quiz3FinalsItems = Integer.Parse(txtFQuiz3Total.Text)
                Dim quiz4FinalsItems = Integer.Parse(txtFQuiz4Total.Text)

                Dim totalScoreFinalsQuiz = quiz1Finals + quiz2Finals + quiz3Finals + quiz4Finals
                Dim totalScoreFinalsTotal = quiz1FinalsItems + quiz2FinalsItems + quiz3FinalsItems + quiz4FinalsItems

                txtFQuizPerc.Text = (totalScoreFinalsQuiz / totalScoreFinalsTotal) * 50 + 50
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

            enableFinals()
        Else
            lblMidGrade.Text = "00.00"
            disableFinals()

        End If

    End Sub

    Public Sub computeFinals()
        If txtFAtt.Text.Length <> 0 And txtFLab.Text.Length And txtFCase.Text.Length <> 0 And txtFRec.Text.Length <> 0 And txtFQuizPerc.Text.Length <> 0 And txtFExamPerc.Text.Length <> 0 Then
            Dim finAtt = Double.Parse(txtFAtt.Text)
            Dim finLab = Double.Parse(txtFLab.Text)
            Dim finCase = Double.Parse(txtFCase.Text)
            Dim finRec = Double.Parse(txtFRec.Text)
            Dim finQuizzes = Double.Parse(txtFQuizPerc.Text)
            Dim finExam = Double.Parse(txtFExamPerc.Text)

            Dim lblFinalsGradeNum = (finAtt * 0.05) + (finQuizzes * 0.15) + (finLab * 0.2) + (finExam * 0.3) + (finCase * 0.2) + (finRec * 0.1)

            lblFinGrade.Text = Double.Parse(lblFinalsGradeNum.ToString("F2"))
        Else
            lblFinGrade.Text = "00.00"

        End If
    End Sub

    Public Sub validateQuizzes(type As String)
        Dim scoreControls As TextBox()
        Dim totalControls As TextBox()

        If type = "Midterm" Then
            scoreControls = {txtMQ1Score, txtMQ2Score, txtMQ3Score, txtMQ4Score}
            totalControls = {txtMQ1Total, txtMQ2Total, txtMQ3Total, txtMQ4Total}
        ElseIf type = "Finals" Then
            scoreControls = {txtFQ1Score, txtFQuiz2Score, txtFQuiz3Score, txtFQuiz4Score}
            totalControls = {txtFQuiz1Total, txtFQuiz2Total, txtFQuiz3Total, txtFQuiz4Total}
        Else
            MessageBox.Show("Invalid type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For i As Integer = 0 To scoreControls.Length - 1
            If scoreControls(i).Enabled AndAlso totalControls(i).Enabled Then
                If scoreControls(i).Text.Length <> 0 AndAlso totalControls(i).Text.Length > 0 Then
                    Dim score As Integer = Integer.Parse(scoreControls(i).Text)
                    Dim total As Integer = Integer.Parse(totalControls(i).Text)
                    If total < score Then
                        MessageBox.Show($"Total Items is less than score for Quiz", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        totalControls(i).Clear()
                        Exit Sub
                    End If
                End If
            End If

        Next
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
        If txtMExamScore.Text.Length <> 0 And txtMExamTotal.Text.Length <> 0 Then
            Dim intExamScore = Integer.Parse(txtMExamScore.Text)
            Dim intExamTotal = Integer.Parse(txtMExamTotal.Text)

            If intExamScore > intExamTotal Then
                MessageBox.Show("Exam Total is Less than Exam Score", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return
            End If

            txtMExamPerc.Text = (Integer.Parse(txtMExamScore.Text) / Integer.Parse(txtMExamTotal.Text)) * 50 + 50
        End If

        computeMidterm()
        validateQuizzes("Midterm")
    End Sub

    Private Sub txtFAtt_TextChanged(sender As Object, e As EventArgs) Handles txtFAtt.TextChanged
        validateTxtInput(txtFAtt)
        computeFinals()
    End Sub

    Private Sub txtFLab_TextChanged(sender As Object, e As EventArgs) Handles txtFLab.TextChanged
        validateTxtInput(txtFLab)
        computeFinals()
    End Sub

    Private Sub txtFCase_TextChanged(sender As Object, e As EventArgs) Handles txtFCase.TextChanged
        validateTxtInput(txtFCase)
        computeFinals()
    End Sub

    Private Sub txtFRec_TextChanged(sender As Object, e As EventArgs) Handles txtFRec.TextChanged
        validateTxtInput(txtFRec)
        computeFinals()
    End Sub

    Private Sub txtFExamScore_TextChanged(sender As Object, e As EventArgs) Handles txtFExamScore.TextChanged
        validateTxtInput(txtFExamScore)
        computeFinals()
    End Sub

    Private Sub txtFExamTotal_TextChanged(sender As Object, e As EventArgs) Handles txtFExamTotal.TextChanged
        validateTxtInput(txtFExamTotal)


        computeFinals()
    End Sub

    Private Sub txtFQ1Score_TextChanged(sender As Object, e As EventArgs) Handles txtFQ1Score.TextChanged
        validateTxtInput(txtFQ1Score)
        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub txtFQuiz1Total_TextChanged(sender As Object, e As EventArgs) Handles txtFQuiz1Total.TextChanged
        validateTxtInput(txtFQuiz1Total)
        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub txtFQuiz2Score_TextChanged(sender As Object, e As EventArgs) Handles txtFQuiz2Score.TextChanged
        validateTxtInput(txtFQuiz2Score)

        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub txtFQuiz2Total_TextChanged(sender As Object, e As EventArgs) Handles txtFQuiz2Total.TextChanged
        validateTxtInput(txtFQuiz2Total)
        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub txtFQuiz3Score_TextChanged(sender As Object, e As EventArgs) Handles txtFQuiz3Score.TextChanged
        validateTxtInput(txtFQuiz3Score)
        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub txtFQuiz3Total_TextChanged(sender As Object, e As EventArgs) Handles txtFQuiz3Total.TextChanged
        validateTxtInput(txtFQuiz3Total)
        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub txtFQuiz4Score_TextChanged(sender As Object, e As EventArgs) Handles txtFQuiz4Score.TextChanged
        validateTxtInput(txtFQuiz4Score)
        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub txtFQuiz4Total_TextChanged(sender As Object, e As EventArgs) Handles txtFQuiz4Total.TextChanged
        validateTxtInput(txtFQuiz4Total)
        computeQuizFinals()
        computeFinals()
    End Sub

    Private Sub btnComputeFin_Click(sender As Object, e As EventArgs) Handles btnComputeFin.Click
        If txtFExamScore.Text.Length <> 0 And txtFExamTotal.Text.Length <> 0 Then
            Dim intExamScore = Integer.Parse(txtFExamScore.Text)
            Dim intExamTotal = Integer.Parse(txtFExamTotal.Text)

            If intExamScore > intExamTotal Then
                MessageBox.Show("Exam Total is Less than Exam Score", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return
            End If

            txtFExamPerc.Text = (Integer.Parse(txtFExamScore.Text) / Integer.Parse(txtFExamTotal.Text)) * 50 + 50
        End If

        computeFinals()
        validateQuizzes("Finals")
    End Sub

    Private Sub lblFinGrade_TextChanged(sender As Object, e As EventArgs) Handles lblFinGrade.TextChanged
        If lblMidGrade.Text <> "00.00" And lblFinGrade.Text <> "00.00" Then


            Dim midGrade = Double.Parse(lblMidGrade.Text)
            Dim finGrade = Double.Parse(lblFinGrade.Text)
            Dim semGrade = (midGrade + finGrade) / 2
            lblSemGrade.Text = semGrade.ToString("F2")
            lblCompGrade.Text = semGrade.ToString("F2")

            If semGrade >= 97.5 And semGrade <= 100 Then
                lblCollegeGrade.Text = "1.00"
            ElseIf semGrade >= 94.5 And semGrade <= 97.49 Then
                lblCollegeGrade.Text = "1.25"
            ElseIf semGrade >= 91.5 And semGrade <= 94.49 Then
                lblCollegeGrade.Text = "1.50"
            ElseIf semGrade >= 88.5 And semGrade <= 91.49 Then
                lblCollegeGrade.Text = "1.75"
            ElseIf semGrade >= 85.5 And semGrade <= 88.49 Then
                lblCollegeGrade.Text = "2.00"
            ElseIf semGrade >= 82.5 And semGrade <= 85.49 Then
                lblCollegeGrade.Text = "2.25"
            ElseIf semGrade >= 79.5 And semGrade <= 82.49 Then
                lblCollegeGrade.Text = "2.50"
            ElseIf semGrade >= 76.5 And semGrade <= 79.49 Then
                lblCollegeGrade.Text = "2.75"
            ElseIf semGrade >= 74.5 And semGrade <= 76.49 Then
                lblCollegeGrade.Text = "3.00"
            Else
                lblCollegeGrade.Text = "5.00"
            End If
        End If
    End Sub

    Private Sub btnSaveEncode_Click(sender As Object, e As EventArgs) Handles btnSaveEncode.Click
        Dim str = ""
    End Sub
End Class
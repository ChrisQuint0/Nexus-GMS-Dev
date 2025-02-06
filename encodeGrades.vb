Imports MySql.Data.MySqlClient
Imports Mysqlx.Session


Public Class encodeGrades

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=nexus_db;")

    Private isClearing As Boolean = False
    Dim profId As String

    Public Sub New(ByVal profId As String)
        InitializeComponent()
        Me.profId = profId

    End Sub
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
    Private Sub btnBackEncode_Click(sender As Object, e As EventArgs) Handles btnBackEncode.Click
        Me.Close()
    End Sub

    Private Sub maskedTxtStudId_TextChanged(sender As Object, e As EventArgs) Handles maskedTxtStudId.TextChanged
        If maskedTxtStudId.MaskCompleted Then
            ' Create the first query to fetch student info
            Dim studentQuery As String = "SELECT Full_name, program_id, Year_Section FROM students WHERE Student_ID = @Student_ID"
            Dim studentCmd As New MySqlCommand(studentQuery, conn)
            studentCmd.Parameters.AddWithValue("@Student_ID", maskedTxtStudId.Text)

            Try
                ' Open the connection once
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Execute the student query
                Dim studentReader As MySqlDataReader = studentCmd.ExecuteReader()
                If studentReader.Read() Then
                    ' Read and display student data
                    txtStudName.Text = studentReader("Full_name").ToString()

                    ' Get the program_id from the student data
                    Dim programId As Integer = Convert.ToInt32(studentReader("program_id"))
                    Dim yearSection As String = studentReader("Year_Section").ToString()

                    ' Close the student reader after use
                    studentReader.Close()

                    ' Now create the query for the program name
                    Dim programQuery As String = "SELECT program_name FROM programs WHERE program_id = @program_id"
                    Dim programCmd As New MySqlCommand(programQuery, conn)
                    programCmd.Parameters.AddWithValue("@program_id", programId)

                    ' Execute the program query
                    Dim programReader As MySqlDataReader = programCmd.ExecuteReader()
                    If programReader.Read() Then
                        comboProgramEncode.Items.Clear()
                        comboProgramEncode.Items.Add(programReader("program_name").ToString())
                        comboProgramEncode.SelectedIndex = 0
                    Else
                        MessageBox.Show("Program not found.")
                    End If

                    ' Close the program reader after use
                    programReader.Close()

                    ' Set other details like Year/Section, Semester, etc.
                    comboSectionEncode.Items.Clear()
                    comboSectionEncode.Items.Add(yearSection)
                    comboSectionEncode.SelectedIndex = 0
                    comboSem.Text = "1st Semester"

                    ' Populate courses based on program selection
                    PopulateCourses()

                    ' Enable the relevant UI elements
                    txtStudName.Enabled = True
                    comboCourseEncode.Enabled = True
                    comboProgramEncode.Enabled = True
                    comboSectionEncode.Enabled = True
                    comboSem.Enabled = True
                    enableMidterm()
                Else
                    MessageBox.Show("Student not found.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub PopulateCourses()
        ' Use the IN clause to handle multiple course_ware_id values
        Dim query As String = "SELECT course_code, course_title FROM courses WHERE course_ware_id IN (@course_ware_ids)"
        Dim courseWareIds As List(Of Integer) = New List(Of Integer)()

        ' Determine course_ware_id from program
        If comboSectionEncode.Text.Contains("1  ") Then
            ' Add courses with course_ware_id of 1 and 2
            courseWareIds.Add(1)
            courseWareIds.Add(2)
        ElseIf comboSectionEncode.Text.Contains("2") Then
            ' Add courses with course_ware_id of 3 and 4
            courseWareIds.Add(3)
            courseWareIds.Add(4)
        ElseIf comboSectionEncode.Text.Contains("3") Then
            ' Add courses with course_ware_id of 5 and 6
            courseWareIds.Add(5)
            courseWareIds.Add(6)
        ElseIf comboSectionEncode.Text.Contains("4") Then
            ' Add courses with course_ware_id of 7 and 8
            courseWareIds.Add(7)
            courseWareIds.Add(8)
        Else
            MessageBox.Show("Unknown program selected.")
            Exit Sub
        End If

        ' Dynamically build the query to support multiple IDs
        Dim placeholders As String = String.Join(",", courseWareIds.Select(Function(id, index) "@id" & index))
        query = query.Replace("@course_ware_ids", placeholders)

        ' Create the command and add parameters
        Dim cmd As New MySqlCommand(query, conn)
        For i As Integer = 0 To courseWareIds.Count - 1
            cmd.Parameters.AddWithValue("@id" & i, courseWareIds(i))
        Next

        Try
            ' Open the connection within the method to ensure it's fresh
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            comboCourseEncode.Items.Clear()

            ' Add the retrieved courses to the combo box (both course_code and course_title)
            While reader.Read()
                Dim courseCode As String = reader("course_code").ToString()
                Dim courseTitle As String = reader("course_title").ToString()

                ' Combine course code and title for display
                Dim displayText As String = courseCode & ": " & courseTitle
                comboCourseEncode.Items.Add(displayText)
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub btnSaveGrades_Click(sender As Object, e As EventArgs) Handles btnSaveEncode.Click
        If lblCollegeGrade.Text <> "00.00" Then
            Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=nexus_db;")
            Dim query As String = "INSERT INTO grades (course_id, Student_ID, Prof_ID, Midterm_Attendance, Midterm_quiz_1, 
                            Midterm_quiz_1_total, Midterm_quiz_2, Midterm_quiz_2_total, Midterm_quiz_3, Midterm_quiz_3_total, 
                            Midterm_quiz_4, Midterm_quiz_4_total, Midterm_quiz_total, Midterm_quiz_items, Midterm_quiz_grade, 
                            Midterm_lab, Midterm_recitation, Midterm_casestudy, Midterm_exam, Midterm_exam_items, 
                            Midterm_exam_grade, Midterm_grade, Finals_attendance, Finals_quiz_1, Finals_quiz_1_total, 
                            Finals_quiz_2, Finals_quiz_2_total, Finals_quiz_3, Finals_quiz_3_total, Finals_quiz_4, 
                            Finals_quiz_4_total, Finals_quiz_total, Finals_quiz_items, Finals_quiz_grade, Finals_lab, 
                            Finals_recitation, Finals_casestudy, Finals_exam, Finals_exam_items, Finals_exam_grade, 
                            Finals_grade, Semestral_grade, Semester, College_grade, remarks) 
                            VALUES (@course_id, @Student_ID, @Prof_ID, @Midterm_Attendance, @Midterm_quiz_1, 
                            @Midterm_quiz_1_total, @Midterm_quiz_2, @Midterm_quiz_2_total, @Midterm_quiz_3, @Midterm_quiz_3_total, 
                            @Midterm_quiz_4, @Midterm_quiz_4_total, @Midterm_quiz_total, @Midterm_quiz_items, @Midterm_quiz_grade, 
                            @Midterm_lab, @Midterm_recitation, @Midterm_casestudy, @Midterm_exam, @Midterm_exam_items, 
                            @Midterm_exam_grade, @Midterm_grade, @Finals_attendance, @Finals_quiz_1, @Finals_quiz_1_total, 
                            @Finals_quiz_2, @Finals_quiz_2_total, @Finals_quiz_3, @Finals_quiz_3_total, @Finals_quiz_4, 
                            @Finals_quiz_4_total, @Finals_quiz_total, @Finals_quiz_items, @Finals_quiz_grade, @Finals_lab, 
                            @Finals_recitation, @Finals_casestudy, @Finals_exam, @Finals_exam_items, @Finals_exam_grade, 
                            @Finals_grade, @Semestral_grade, @Semester, @College_grade, @Remarks)"

            Dim cmd As New MySqlCommand(query, conn)

            Dim courseEncode As String = comboCourseEncode.Text
            Dim parts() As String = courseEncode.Split(":"c)
            Dim courseId As String = parts(0).Trim()

            ' Add parameters
            cmd.Parameters.AddWithValue("@course_id", courseId)
            cmd.Parameters.AddWithValue("@Student_ID", maskedTxtStudId.Text)
            cmd.Parameters.AddWithValue("@Prof_ID", profId) ' Example Professor ID, change accordingly
            cmd.Parameters.AddWithValue("@Midterm_Attendance", txtMidAtt.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_1", txtMQ1Score.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_1_total", txtMQ1Total.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_2", txtMQ2Score.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_2_total", txtMQ2Total.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_3", txtMQ3Score.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_3_total", txtMQ3Total.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_4", txtMQ4Score.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_4_total", txtMQ4Total.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_total", txtMQuizPerc.Text)
            cmd.Parameters.AddWithValue("@Midterm_quiz_items", txtMQuizPerc.Text) ' Assuming it's the same
            cmd.Parameters.AddWithValue("@Midterm_quiz_grade", txtMQuizPerc.Text) ' Assuming it's the same
            cmd.Parameters.AddWithValue("@Midterm_lab", txtMLab.Text)
            cmd.Parameters.AddWithValue("@Midterm_recitation", txtMRec.Text)
            cmd.Parameters.AddWithValue("@Midterm_casestudy", txtMCase.Text)
            cmd.Parameters.AddWithValue("@Midterm_exam", txtMExamScore.Text)
            cmd.Parameters.AddWithValue("@Midterm_exam_items", txtMExamTotal.Text)
            cmd.Parameters.AddWithValue("@Midterm_exam_grade", txtMExamPerc.Text)
            cmd.Parameters.AddWithValue("@Midterm_grade", lblMidGrade.Text) ' Assuming calculated grade
            cmd.Parameters.AddWithValue("@Finals_attendance", txtFAtt.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_1", txtFQ1Score.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_1_total", txtFQuiz1Total.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_2", txtFQuiz2Score.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_2_total", txtFQuiz2Total.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_3", txtFQuiz3Score.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_3_total", txtFQuiz3Total.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_4", txtFQuiz4Score.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_4_total", txtFQuiz4Total.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_total", txtFQuizPerc.Text)
            cmd.Parameters.AddWithValue("@Finals_quiz_items", txtFQuizPerc.Text) ' Assuming it's the same
            cmd.Parameters.AddWithValue("@Finals_quiz_grade", txtFQuizPerc.Text) ' Assuming it's the same
            cmd.Parameters.AddWithValue("@Finals_lab", txtFLab.Text)
            cmd.Parameters.AddWithValue("@Finals_recitation", txtFRec.Text)
            cmd.Parameters.AddWithValue("@Finals_casestudy", txtFCase.Text)
            cmd.Parameters.AddWithValue("@Finals_exam", txtFExamScore.Text)
            cmd.Parameters.AddWithValue("@Finals_exam_items", txtFExamTotal.Text)
            cmd.Parameters.AddWithValue("@Finals_exam_grade", txtFExamPerc.Text)
            cmd.Parameters.AddWithValue("@Finals_grade", lblFinGrade.Text) ' Assuming calculated grade
            cmd.Parameters.AddWithValue("@Semestral_grade", lblSemGrade.Text) ' Assuming calculated grade
            cmd.Parameters.AddWithValue("@Semester", comboSem.Text)
            cmd.Parameters.AddWithValue("@College_grade", lblCollegeGrade.Text) ' Assuming calculated grade

            If Double.Parse(lblSemGrade.Text) > 75 Then
                cmd.Parameters.AddWithValue("@Remarks", "PASSED")
            Else
                cmd.Parameters.AddWithValue("@Remarks", "FAILED")
            End If

            Try
                conn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Grades saved successfully!")
                Else
                    MessageBox.Show("Failed to save grades.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("There are missing fields. Please complete all of them", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

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
Imports MySql.Data.MySqlClient

Public Class encodeNewData
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost; user=root; database=nexus_db")
    Private Sub btnBackEncodeNew_Click(sender As Object, e As EventArgs) Handles btnBackEncodeNew.Click
        Me.Close()
    End Sub

    Private Sub comboAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboAccountType.SelectedIndexChanged
        If comboAccountType.SelectedIndex = 0 Then
            enableNewStudent()
            disableNewFaculty()
            disableNewCourse()
            btnAdminGenReport.Enabled = True
        ElseIf comboAccountType.SelectedIndex = 1 Then
            disableNewStudent()
            enableNewFaculty()
            disableNewCourse()
            btnAdminGenReport.Enabled = True
        ElseIf comboAccountType.SelectedIndex = 2 Then
            disableNewStudent()
            disableNewFaculty()
            enableNewCourse()
            btnAdminGenReport.Enabled = True
        Else
            btnAdminGenReport.Enabled = False
        End If
    End Sub

    Public Sub enableNewStudent()
        txtNewStudID.Enabled = True
        txtNewStudName.Enabled = True
        txtNewYrSec.Enabled = True
        txtNewStudUsername.Enabled = True
        txtNewStudPassword.Enabled = True
        comboNewStudDept.Enabled = True
        comboNewStudProgram.Enabled = True
        comboNewStudCourse.Enabled = True
        btnAddStud.Enabled = True

    End Sub

    Public Sub disableNewStudent()
        txtNewStudID.Enabled = False
        txtNewStudName.Enabled = False
        txtNewYrSec.Enabled = False
        txtNewStudUsername.Enabled = False
        txtNewStudPassword.Enabled = False
        comboNewStudDept.Enabled = False
        comboNewStudProgram.Enabled = False
        comboNewStudCourse.Enabled = False
        btnAddStud.Enabled = False

        txtNewStudID.Clear()
        txtNewStudName.Clear()
        txtNewYrSec.Clear()
        txtNewStudUsername.Clear()
        txtNewStudPassword.Clear()
        comboNewStudDept.SelectedIndex = -1
        comboNewStudProgram.SelectedIndex = -1
        comboNewStudCourse.SelectedIndex = -1


    End Sub

    Public Sub enableNewFaculty()
        txtNewFacultyID.Enabled = True
        txtNewFacultyName.Enabled = True
        txtNewFacultyUsername.Enabled = True
        txtNewFacultyPass.Enabled = True
        comboNewFacultyDept.Enabled = True
        comboNewFacultySub.Enabled = True
        btnAddFaculty.Enabled = True

    End Sub

    Public Sub disableNewFaculty()
        txtNewFacultyID.Enabled = False
        txtNewFacultyName.Enabled = False
        txtNewFacultyUsername.Enabled = False
        txtNewFacultyPass.Enabled = False
        comboNewFacultyDept.Enabled = False
        comboNewFacultySub.Enabled = False
        btnAddFaculty.Enabled = False

        txtNewFacultyID.Clear()
        txtNewFacultyName.Clear()
        txtNewFacultyUsername.Clear()
        txtNewFacultyPass.Clear()
        comboNewFacultyDept.SelectedIndex = -1
        comboNewFacultySub.SelectedIndex = -1

    End Sub

    Public Sub enableNewCourse()
        txtNewCourseCode.Enabled = True
        txtNewCourseTitle.Enabled = True
        txtNewCourseCurYear.Enabled = True
        txtNewCoursewareId.Enabled = True
        btnAddCourse.Enabled = True
    End Sub

    Public Sub disableNewCourse()
        txtNewCourseCode.Enabled = False
        txtNewCourseTitle.Enabled = False
        txtNewCourseCurYear.Enabled = False
        btnAddCourse.Enabled = False

        txtNewCourseCode.Clear()
        txtNewCourseTitle.Clear()
        txtNewCourseCurYear.Clear()

    End Sub

    Private Sub encodeNewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        Try
            ' Open the connection
            con.Open()

            ' Define the SQL query to retrieve department names
            Dim query As String = "SELECT Dept_name FROM departments"

            ' Create the command and pass the query and connection
            Using cmd As New MySqlCommand(query, con)
                ' Execute the query and get the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Loop through the results and add to ComboBox
                    While reader.Read()
                        comboNewStudDept.Items.Add(reader("Dept_name").ToString())
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            ' Handle any errors that may have occurred
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            con.Close()
        End Try

    End Sub
    Private Sub encodeNewData_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        If txtNewCourseCode.Text.Length <> 0 And txtNewCourseTitle.Text.Length <> 0 And txtNewCourseCurYear.Text.Length <> 0 And txtNewCoursewareId.Text.Length <> 0 Then
            Try
                con.Open()
                str = "INSERT INTO courses(course_code, course_title, curriculum_year, course_ware_id) values('" & txtNewCourseCode.Text & "','" & txtNewCourseTitle.Text & "','" & txtNewCourseCurYear.Text & "'," & txtNewCoursewareId.Text & ");"

                cmd.Connection = con
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("New Course Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNewCourseCode.Clear()
                txtNewCourseTitle.Clear()
                txtNewCourseCurYear.Clear()
                txtNewCoursewareId.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewCourseCode.Clear()
                txtNewCourseTitle.Clear()
                txtNewCourseCurYear.Clear()
                txtNewCoursewareId.Clear()
            End Try
        End If
    End Sub

    Private Sub comboNewStudDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboNewStudDept.SelectedIndexChanged
        If comboNewStudDept.SelectedItem = "CCS (College of Computer Studies)" Then
            loadPrograms(1)
        ElseIf comboNewStudDept.SelectedItem = "CON (College of Nursing)" Then
            loadPrograms(2)
        End If
    End Sub

    Public Sub loadPrograms(deptId As Integer)
        comboNewStudProgram.Items.Clear()
        comboNewStudCourse.Items.Clear()

        If deptId = 1 Then
            Try
                con.Open()
                Dim query As String = "SELECT program_name FROM programs WHERE Dept_ID = 1"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            comboNewStudProgram.Items.Add(reader("program_name").ToString())
                        End While
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        ElseIf deptId = 2 Then
            Try
                con.Open()
                Dim query As String = "SELECT program_name FROM programs WHERE Dept_ID = 2"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            comboNewStudProgram.Items.Add(reader("program_name").ToString())
                        End While
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub



    Private Sub comboNewStudProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboNewStudProgram.SelectedIndexChanged
        comboNewStudCourse.Items.Clear()

        If comboNewStudProgram.SelectedItem = "BS in Information Technology" Then
            comboNewStudCourse.Items.Add("1st Year IT Courseware")
        ElseIf comboNewStudProgram.SelectedItem = "BS in Computer Science" Then
            comboNewStudCourse.Items.Add("1st Year CS Courseware")
        ElseIf comboNewStudProgram.SelectedItem = "BS in Nursing" Then
            comboNewStudCourse.Items.Add("1st Year Nursing Courseware")
        End If
    End Sub

    Public Sub loadCourses(deptId As Integer)
        comboNewStudCourse.Items.Clear()
        If deptId = 1 Then
            Try
                con.Open()
                Dim query As String = "SELECT CONCAT(course_code, ': ', course_title)  AS displayText from courses WHERE course_ware_id = 1"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            comboNewStudCourse.Items.Add(reader("displayText").ToString())
                        End While
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        ElseIf deptId = 2 Then
            Try
                con.Open()
                Dim query As String = "SELECT CONCAT(course_code, ': ', course_title)  AS displayText from courses WHERE course_ware_id = 2"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            comboNewStudCourse.Items.Add(reader("displayText").ToString())
                        End While
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()

            End Try
        End If
    End Sub

    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        If txtNewStudID.Text.Length <> 0 And txtNewStudName.Text.Length <> 0 And txtNewYrSec.Text.Length <> 0 And comboNewStudDept.SelectedIndex <> -1 And comboNewStudProgram.SelectedIndex <> -1 And comboNewStudCourse.SelectedIndex <> -1 Then

            Dim program_id As Integer

            ' Map program selection to program_id
            If comboNewStudProgram.Text = "BS in Information Technology" Then
                program_id = 1
            ElseIf comboNewStudProgram.Text = "BS in Information Technology" Then
                program_id = 2
            ElseIf comboNewStudProgram.Text = "BS in Nursing" Then
                program_id = 3
            Else
                MessageBox.Show("Invalid program selected.")
                Exit Sub
            End If

            Try
                con.Open()

                ' Retrieve courses for the selected courseware
                Dim selectedCourseware As String = comboNewStudCourse.Text
                Dim coursewareId As Integer

                If selectedCourseware = "1st Year IT Courseware" Then
                    coursewareId = 1
                ElseIf selectedCourseware = "1st Year Nursing Courseware" Then
                    coursewareId = 2
                Else
                    MessageBox.Show("Invalid courseware selected.")
                    Exit Sub
                End If

                Dim insertStudent As String = "INSERT INTO students(Student_ID, Full_name, Year_Section, program_id, courseware_id) VALUES(@StudentID, @FullName, @YearSection, @ProgramID, @CoursesEnrolled);"
                Dim cmdInsertStudent As New MySqlCommand(insertStudent, con)
                cmdInsertStudent.Parameters.AddWithValue("@StudentID", txtNewStudID.Text)
                cmdInsertStudent.Parameters.AddWithValue("@FullName", txtNewStudName.Text)
                cmdInsertStudent.Parameters.AddWithValue("@YearSection", txtNewYrSec.Text)
                cmdInsertStudent.Parameters.AddWithValue("@ProgramID", program_id)
                cmdInsertStudent.Parameters.AddWithValue("@CoursesEnrolled", coursewareId)
                cmdInsertStudent.ExecuteNonQuery()

                Dim insertStudentUser As String = "insert into users(User_name, Password, User_type) values ('" & txtNewStudUsername.Text & "','" & txtNewStudPassword.Text & "', 'student');"

                cmd.Connection = con
                cmd.CommandText = insertStudentUser
                cmd.ExecuteNonQuery()
                con.Close()


                MessageBox.Show("Student and courses added successfully!")

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try

        Else
            MessageBox.Show("Please fill in all the required fields.")
        End If
    End Sub

    Private Sub btnAddFaculty_Click(sender As Object, e As EventArgs) Handles btnAddFaculty.Click
        con.Open()

        Dim insertProfUser As String = "insert into users(User_name, Password, User_type) values ('" & txtNewFacultyUsername.Text & "','" & txtNewFacultyPass.Text & "', 'professor');"

        MsgBox(insertProfUser)

        cmd.Connection = con
        cmd.CommandText = insertProfUser
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class
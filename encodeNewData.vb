Imports System.Linq.Expressions
Imports iText.Bouncycastle.Asn1
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class encodeNewData
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost; user=root; database=nexus_db")
    Dim accountExists As Boolean = False
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
        txtNewStudId.Enabled = True
        txtNewStudName.Enabled = True
        txtNewYrSec.Enabled = True
        txtNewStudUsername.Enabled = True
        txtNewStudPassword.Enabled = True
        comboNewStudDept.Enabled = True
        comboNewStudProgram.Enabled = True
        comboNewStudCourse.Enabled = True
        btnAddStud.Enabled = True
        txtNewStudRecovery.Enabled = True

    End Sub

    Public Sub disableNewStudent()
        txtNewStudId.Enabled = False
        txtNewStudName.Enabled = False
        txtNewYrSec.Enabled = False
        txtNewStudUsername.Enabled = False
        txtNewStudPassword.Enabled = False
        comboNewStudDept.Enabled = False
        comboNewStudProgram.Enabled = False
        comboNewStudCourse.Enabled = False
        btnAddStud.Enabled = False
        txtNewStudRecovery.Enabled = False

        txtNewStudId.Clear()
        txtNewStudName.Clear()
        txtNewYrSec.Clear()
        txtNewStudUsername.Clear()
        txtNewStudPassword.Clear()
        comboNewStudDept.SelectedIndex = -1
        comboNewStudProgram.SelectedIndex = -1
        comboNewStudCourse.SelectedIndex = -1
        txtNewStudRecovery.Clear()


    End Sub

    Public Sub enableNewFaculty()
        txtNewFacultyID.Enabled = True
        txtNewFacultyName.Enabled = True
        txtNewFacultyUsername.Enabled = True
        txtNewFacultyPass.Enabled = True
        comboNewFacultyDept.Enabled = True
        comboNewFacultyCourse.Enabled = True
        btnAddFaculty.Enabled = True
        txtSecHandling.Enabled = True
        txtNewFacultyRecovery.Enabled = True

    End Sub

    Public Sub disableNewFaculty()
        txtNewFacultyID.Enabled = False
        txtNewFacultyName.Enabled = False
        txtNewFacultyUsername.Enabled = False
        txtNewFacultyPass.Enabled = False
        comboNewFacultyDept.Enabled = False
        comboNewFacultyCourse.Enabled = False
        btnAddFaculty.Enabled = False
        txtSecHandling.Enabled = False
        txtNewFacultyRecovery.Enabled = False


        txtNewFacultyID.Clear()
        txtNewFacultyName.Clear()
        txtNewFacultyUsername.Clear()
        txtNewFacultyPass.Clear()
        comboNewFacultyDept.SelectedIndex = -1
        comboNewFacultyCourse.SelectedIndex = -1
        txtNewFacultyRecovery.Clear()

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
        txtNewCoursewareId.Enabled = False
        btnAddCourse.Enabled = False

        txtNewCourseCode.Clear()
        txtNewCourseTitle.Clear()
        txtNewCourseCurYear.Clear()
        txtNewCoursewareId.Clear()

    End Sub

    Private Sub encodeNewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        loadNewStudDept()
        loadNewFacultyDept()

    End Sub

    Public Sub loadNewStudDept()
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

    Public Sub loadNewFacultyDept()
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
                        comboNewFacultyDept.Items.Add(reader("Dept_name").ToString())
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

    Public Sub loadProgramsFaculty(deptId As Integer)
        comboNewFacultyCourse.Items.Clear()
        'comboNew.Items.Clear()

        If deptId = 1 Then
            Try
                con.Open()
                Dim query As String = "SELECT program_name FROM programs WHERE Dept_ID = 1"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            comboNewFacultyCourse.Items.Add(reader("program_name").ToString())
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
                            comboNewFacultyCourse.Items.Add(reader("program_name").ToString())
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
        comboNewFacultyCourse.Items.Clear()
        If deptId = 1 Then
            Try
                con.Open()
                Dim query As String = "SELECT CONCAT(course_code, ': ', course_title)  AS displayText from courses WHERE course_ware_id = 1"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            comboNewFacultyCourse.Items.Add(reader("displayText").ToString())
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
                            comboNewFacultyCourse.Items.Add(reader("displayText").ToString())
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
        Dim program_id As Integer

        ' Map program selection to program_id
        If comboNewStudProgram.Text = "BS in Information Technology" Then
            program_id = 1
        ElseIf comboNewStudProgram.Text = "BS in Computer Science" Then
            program_id = 2
        ElseIf comboNewStudProgram.Text = "BS in Nursing" Then
            program_id = 3
        Else
            MessageBox.Show("Invalid program selected.")
            Exit Sub
        End If

        Try
            con.Open()

            ' Check if student account already exists
            Dim checkStudentQuery As String = "SELECT COUNT(*) FROM students WHERE Student_ID = @StudentID"
            Dim cmdCheck As New MySqlCommand(checkStudentQuery, con)
            cmdCheck.Parameters.AddWithValue("@StudentID", txtNewStudId.Text)
            Dim studentExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If studentExists > 0 Then
                MessageBox.Show("Student account already exists. Please verify the details.")
                Exit Sub
            End If

            ' Insert new user securely using parameters
            Dim insertStudentUser As String = "INSERT INTO users (User_name, Password, User_type) VALUES (@UserName, @Password, 'student');"
            Dim cmdInsertUser As New MySqlCommand(insertStudentUser, con)
            cmdInsertUser.Parameters.AddWithValue("@UserName", txtNewStudUsername.Text)
            cmdInsertUser.Parameters.AddWithValue("@Password", txtNewStudPassword.Text)
            cmdInsertUser.ExecuteNonQuery()

            ' Retrieve User_ID for the new user
            Dim queryUserId As String = "SELECT LAST_INSERT_ID()"
            Dim cmdGetUserId As New MySqlCommand(queryUserId, con)
            Dim userId As Integer = Convert.ToInt32(cmdGetUserId.ExecuteScalar())

            ' Determine courseware ID
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

            ' Retrieve courses associated with the selected courseware ID
            Dim getCoursesQuery As String = "SELECT course_code FROM courses WHERE course_ware_id = @CoursewareID"
            Dim cmdGetCourses As New MySqlCommand(getCoursesQuery, con)
            cmdGetCourses.Parameters.AddWithValue("@CoursewareID", coursewareId)
            Dim reader As MySqlDataReader = cmdGetCourses.ExecuteReader()

            Dim courses As New List(Of String)
            While reader.Read()
                courses.Add(reader("course_code").ToString())
            End While
            reader.Close()

            For Each course As String In courses
                MessageBox.Show("Course: " & course) ' Debug output to confirm course value
                ' Your insert code here...
            Next

            ' Insert student details for each course
            For Each course As String In courses
                Dim insertStudent As String = "INSERT INTO students (Student_ID, Full_name, Year_Section, program_id, course_enrolled, User_ID) VALUES (@StudentID, @FullName, @YearSection, @ProgramID, @CourseEnrolled, @UserID);"
                Dim cmdInsertStudent As New MySqlCommand(insertStudent, con)
                cmdInsertStudent.Parameters.AddWithValue("@StudentID", txtNewStudId.Text)
                cmdInsertStudent.Parameters.AddWithValue("@FullName", txtNewStudName.Text)
                cmdInsertStudent.Parameters.AddWithValue("@YearSection", txtNewYrSec.Text)
                cmdInsertStudent.Parameters.AddWithValue("@ProgramID", program_id)
                cmdInsertStudent.Parameters.AddWithValue("@CourseEnrolled", course)
                cmdInsertStudent.Parameters.AddWithValue("@UserID", userId)
                cmdInsertStudent.ExecuteNonQuery()
            Next

            MessageBox.Show("Student and courses added successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub checkExistingAccount()
        Try
            ' Open the connection
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If

            ' Check if an account with the same faculty ID exists
            Dim checkFacultyQuery As String = "SELECT u.User_name, u.Password, u.recovery_answer " &
                                          "FROM users u " &
                                          "JOIN professors p ON u.User_ID = p.user_id " &
                                          "WHERE p.Prof_ID = @ProfID " &
                                          "LIMIT 1;"
            cmd.Connection = con
            cmd.CommandText = checkFacultyQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ProfID", txtNewFacultyID.Text)

            ' Execute the query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                ' If an account exists, retrieve the username and password
                While reader.Read()
                    txtNewFacultyUsername.Text = reader("User_name").ToString()
                    txtNewFacultyPass.Text = reader("Password").ToString()
                    txtNewFacultyRecovery.Text = reader("recovery_answer").ToString()
                End While

                ' Set textboxes to read-only
                txtNewFacultyUsername.ReadOnly = True
                txtNewFacultyPass.ReadOnly = True
                txtNewFacultyRecovery.ReadOnly = True

                MessageBox.Show("An account with this faculty ID already exists. The username and password have been loaded.",
                            "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)

                accountExists = True
            Else
                ' If no account exists, clear the textboxes and make them editable
                txtNewFacultyUsername.Clear()
                txtNewFacultyPass.Clear()
                txtNewFacultyUsername.ReadOnly = False
                txtNewFacultyPass.ReadOnly = False
                accountExists = False
            End If

            reader.Close() ' Close the reader

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub checkExistingStudAccount()
        Try
            ' Open the connection
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If

            ' Check if an account with the same faculty ID exists
            Dim checkFacultyQuery As String = "SELECT u.User_name, u.Password, u.recovery_answer " &
                                          "FROM users u " &
                                          "JOIN students s ON u.User_ID = s.user_id " &
                                          "WHERE s.Student_ID = @StudID " &
                                          "LIMIT 1;"
            cmd.Connection = con
            cmd.CommandText = checkFacultyQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@StudID", txtNewStudId.Text)

            ' Execute the query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                ' If an account exists, retrieve the username and password
                While reader.Read()
                    txtNewStudUsername.Text = reader("User_name").ToString()
                    txtNewStudPassword.Text = reader("Password").ToString()
                    txtNewStudRecovery.Text = reader("recovery_answer").ToString()
                End While

                ' Set textboxes to read-only
                txtNewStudUsername.ReadOnly = True
                txtNewStudPassword.ReadOnly = True
                txtNewStudRecovery.ReadOnly = True

                MessageBox.Show("An account with this student ID already exists. The username and password have been loaded.", "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)

                disableNewStudent()
                comboAccountType.SelectedIndex = -1
                accountExists = True
            Else
                ' If no account exists, clear the textboxes and make them editable
                txtNewStudUsername.Clear()
                txtNewStudPassword.Clear()
                txtNewStudUsername.ReadOnly = False
                txtNewStudPassword.ReadOnly = False
                accountExists = False
            End If

            reader.Close() ' Close the reader

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Private Sub btnAddFaculty_Click(sender As Object, e As EventArgs) Handles btnAddFaculty.Click
        Dim deptId As Integer

        If comboNewFacultyDept.Text.Contains("CCS") Then
            deptId = 1
        ElseIf comboNewFacultyDept.Text.Contains("CON") Then
            deptId = 2
        End If

        Dim courseHandling As String = comboNewFacultyCourse.Text
        Dim parts() As String = courseHandling.Split(":"c)
        Dim courseId As String = parts(0).Trim()

        con.Open()

        Try
            Dim userId As Integer

            If Not accountExists Then
                ' Insert a new user account
                Dim insertUserQuery As String = "INSERT INTO users (User_name, Password, User_type) VALUES (@UserName, @Password, 'student');"
                Using cmd As New MySqlCommand(insertUserQuery, con)
                    cmd.Parameters.AddWithValue("@UserName", txtNewFacultyUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtNewFacultyPass.Text)
                    cmd.ExecuteNonQuery()
                End Using

                ' Retrieve the new User_ID
                Dim retrieveUserIdQuery As String = "SELECT LAST_INSERT_ID();"
                Using cmd As New MySqlCommand(retrieveUserIdQuery, con)
                    userId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Else
                ' Retrieve existing User_ID
                Dim queryUserId As String = "SELECT User_ID FROM users WHERE User_name = @UserName"
                Using cmd As New MySqlCommand(queryUserId, con)
                    cmd.Parameters.AddWithValue("@UserName", txtNewFacultyUsername.Text)
                    userId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End If

            ' Insert professor details
            Dim insertProfQuery As String = "INSERT INTO professors (Prof_ID, Prof_name, dept_id, course_handling, user_id, section_handling) VALUES (@ProfID, @ProfName, @DeptID, @CourseHandling, @UserID, @SectionHandling);"
            Using cmd As New MySqlCommand(insertProfQuery, con)
                cmd.Parameters.AddWithValue("@ProfID", txtNewFacultyID.Text)
                cmd.Parameters.AddWithValue("@ProfName", txtNewFacultyName.Text)
                cmd.Parameters.AddWithValue("@DeptID", deptId)
                cmd.Parameters.AddWithValue("@CourseHandling", courseId)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.Parameters.AddWithValue("@SectionHandling", txtSecHandling.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Faculty information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub comboNewFacultyDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboNewFacultyDept.SelectedIndexChanged
        If comboNewFacultyDept.Text = "CCS (College of Computer Studies)" Then
            loadCourses(1)
        ElseIf comboNewFacultyDept.Text = "CON (College of Nursing)" Then
            loadCourses(2)
        End If
    End Sub

    Private Sub txtNewFacultyID_TextChanged(sender As Object, e As EventArgs) Handles txtNewFacultyID.TextChanged
        If txtNewFacultyID.MaskCompleted Then
            checkExistingAccount()
        End If
    End Sub

    Private Sub txtNewStudId_TextChanged(sender As Object, e As EventArgs) Handles txtNewStudId.TextChanged
        If txtNewStudId.MaskCompleted Then
            checkExistingStudAccount()
        End If
    End Sub
End Class
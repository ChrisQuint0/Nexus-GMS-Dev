Imports Microsoft.VisualBasic.ApplicationServices
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
        comboNewFacultyCourse.Enabled = True
        btnAddFaculty.Enabled = True
        txtSecHandling.Enabled = True

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

        txtNewFacultyID.Clear()
        txtNewFacultyName.Clear()
        txtNewFacultyUsername.Clear()
        txtNewFacultyPass.Clear()
        comboNewFacultyDept.SelectedIndex = -1
        comboNewFacultyCourse.SelectedIndex = -1

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
        If txtNewStudID.Text.Length <> 0 And txtNewStudName.Text.Length <> 0 And txtNewYrSec.Text.Length <> 0 And comboNewStudDept.SelectedIndex <> -1 And comboNewStudProgram.SelectedIndex <> -1 And comboNewStudCourse.SelectedIndex <> -1 Then

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

                ' Insert new user securely using parameters
                Dim insertStudentUser As String = "INSERT INTO users (User_name, Password, User_type) VALUES (@UserName, @Password, 'student');"
                Dim cmd As New MySqlCommand(insertStudentUser, con)
                cmd.Parameters.AddWithValue("@UserName", txtNewStudUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtNewStudPassword.Text)
                cmd.ExecuteNonQuery()

                ' Retrieve User_ID for the new user
                Dim query As String = "SELECT User_ID FROM users WHERE User_name = @UserName"
                cmd.CommandText = query
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UserName", txtNewStudUsername.Text)
                Dim userId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

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

                ' Insert student details securely, including User_ID
                Dim insertStudent As String = "INSERT INTO students (Student_ID, Full_name, Year_Section, program_id, courseware_id, User_ID) VALUES (@StudentID, @FullName, @YearSection, @ProgramID, @CoursewareID, @UserID);"
                Dim cmdInsertStudent As New MySqlCommand(insertStudent, con)
                cmdInsertStudent.Parameters.AddWithValue("@StudentID", txtNewStudID.Text)
                cmdInsertStudent.Parameters.AddWithValue("@FullName", txtNewStudName.Text)
                cmdInsertStudent.Parameters.AddWithValue("@YearSection", txtNewYrSec.Text)
                cmdInsertStudent.Parameters.AddWithValue("@ProgramID", program_id)
                cmdInsertStudent.Parameters.AddWithValue("@CoursewareID", coursewareId)
                cmdInsertStudent.Parameters.AddWithValue("@UserID", userId)
                cmdInsertStudent.ExecuteNonQuery()

                MessageBox.Show("Student and courses added successfully!")
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try

        Else
            MessageBox.Show("Please fill in all the required fields.")
        End If
    End Sub

    Public Sub checkExistingAccount()
        Try
            ' Open the connection
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If

            ' Check if an account with the same faculty ID exists
            Dim checkFacultyQuery As String = "SELECT u.User_name, u.Password " &
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
                End While

                ' Set textboxes to read-only
                txtNewFacultyUsername.ReadOnly = True
                txtNewFacultyPass.ReadOnly = True

                MessageBox.Show("An account with this faculty ID already exists. The username and password have been loaded.",
                            "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' If no account exists, clear the textboxes and make them editable
                txtNewFacultyUsername.Clear()
                txtNewFacultyPass.Clear()
                txtNewFacultyUsername.ReadOnly = False
                txtNewFacultyPass.ReadOnly = False
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

        ' Retrieve the User_ID for the new or existing user
        Dim queryUserId As String = "SELECT User_ID FROM users WHERE User_name = @UserName"
        cmd.CommandText = queryUserId
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@UserName", txtNewFacultyUsername.Text)
        Dim userId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        ' Insert or update professor details
        Dim insertProfDetails As String = "INSERT INTO professors(Prof_ID, Prof_name, dept_id, course_handling, user_id, section_handling) VALUES (@ProfID, @ProfName, @DeptID, @CourseHandling, @UserID, @SectionHandling);"
        cmd.CommandText = insertProfDetails
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@ProfID", txtNewFacultyID.Text)
        cmd.Parameters.AddWithValue("@ProfName", txtNewFacultyName.Text)
        cmd.Parameters.AddWithValue("@DeptID", deptId)
        cmd.Parameters.AddWithValue("@CourseHandling", courseId)
        cmd.Parameters.AddWithValue("@UserID", userId)
        cmd.Parameters.AddWithValue("@SectionHandling", txtSecHandling.Text)
        cmd.ExecuteNonQuery()

        con.Close()

        MessageBox.Show("Faculty information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class
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
            Dim query As String = "SELECT Dept_name FROM department"

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
                str = "INSERT INTO subjects(Subject_ID, Subject_Name, Curriculum_year, course_ware_id) values('" & txtNewCourseCode.Text & "','" & txtNewCourseTitle.Text & "','" & txtNewCourseCurYear.Text & "'," & txtNewCoursewareId.Text & ");"

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

        If deptId = 1 Then
            Try
                ' Open the connection
                con.Open()

                ' Define the SQL query to retrieve department names
                Dim query As String = "SELECT Course_name FROM courses WHERE Dept_ID = 1"

                ' Create the command and pass the query and connection
                Using cmd As New MySqlCommand(query, con)
                    ' Execute the query and get the result
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Loop through the results and add to ComboBox
                        While reader.Read()
                            comboNewStudProgram.Items.Add(reader("Course_name").ToString())
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
        ElseIf deptId = 2 Then
            Try
                ' Open the connection
                con.Open()

                ' Define the SQL query to retrieve department names
                Dim query As String = "SELECT Course_name FROM courses WHERE Dept_ID = 2"

                ' Create the command and pass the query and connection
                Using cmd As New MySqlCommand(query, con)
                    ' Execute the query and get the result
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Loop through the results and add to ComboBox
                        While reader.Read()
                            comboNewStudProgram.Items.Add(reader("Course_name").ToString())
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

        End If


    End Sub
End Class
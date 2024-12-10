Imports MySql.Data.MySqlClient

Public Class manageData
    Private Sub manageData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "server=localhost;user=root;database=nexus_db"

        Try
            ' Load Users Table
            Using connection As New MySqlConnection(connectionString)
                Dim usersQuery As String = "SELECT * FROM users"
                Dim usersAdapter As New MySqlDataAdapter(usersQuery, connection)
                Dim usersTable As New DataTable()
                usersAdapter.Fill(usersTable)
                dataGVUsers.DataSource = usersTable
            End Using

            ' Load Students Table
            Using connection As New MySqlConnection(connectionString)
                Dim studentsQuery As String = "SELECT * FROM students"
                Dim studentsAdapter As New MySqlDataAdapter(studentsQuery, connection)
                Dim studentsTable As New DataTable()
                studentsAdapter.Fill(studentsTable)
                dataGVStudents.DataSource = studentsTable
            End Using

            ' Load Professors Table
            Using connection As New MySqlConnection(connectionString)
                Dim profsQuery As String = "SELECT * FROM professors"
                Dim profsAdapter As New MySqlDataAdapter(profsQuery, connection)
                Dim profsTable As New DataTable()
                profsAdapter.Fill(profsTable)
                dataGVProfs.DataSource = profsTable
            End Using

            ' Load Courses Table
            Using connection As New MySqlConnection(connectionString)
                Dim coursesQuery As String = "SELECT * FROM courses"
                Dim coursesAdapter As New MySqlDataAdapter(coursesQuery, connection)
                Dim coursesTable As New DataTable()
                coursesAdapter.Fill(coursesTable)
                dataGVCourses.DataSource = coursesTable
            End Using

        Catch ex As MySqlException
            MessageBox.Show($"Error Loading Data: {ex.Message}")
        End Try
    End Sub

    Private Sub DeleteRecord(query As String, parameterName As String, parameterValue As String)
        Dim connectionString As String = "server=localhost;user=root;database=nexus_db"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue(parameterName, parameterValue)

                Try
                    connection.Open()
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        command.ExecuteNonQuery()
                        MessageBox.Show("Record deleted successfully.")
                    End If

                Catch ex As MySqlException
                    MessageBox.Show($"Error Deleting Record: {ex.Message}")
                Finally
                    connection.Close()
                    LoadData() ' Refresh data
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If txtUserID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM users WHERE User_ID = @ID"
            DeleteRecord(query, "@ID", txtUserID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid User ID.")
        End If
    End Sub

    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        If txtStudDataID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM students WHERE Student_ID = @ID"
            DeleteRecord(query, "@ID", txtStudDataID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid Student ID.")
        End If
    End Sub

    Private Sub btnDeleteProf_Click(sender As Object, e As EventArgs) Handles btnDeleteProf.Click
        If txtProfDataID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM professors WHERE id = @ID"
            DeleteRecord(query, "@ID", txtProfDataID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid data ID.")
        End If
    End Sub

    Private Sub btnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        If txtCourseID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM courses WHERE Course_ID = @ID"
            DeleteRecord(query, "@ID", txtCourseID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid Course ID.")
        End If
    End Sub


End Class
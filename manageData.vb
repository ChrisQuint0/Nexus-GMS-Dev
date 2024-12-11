Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class manageData
    Dim mainFormReference As mainForm = Nothing

    Public Sub New(ByVal mainFormIns As mainForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.mainFormReference = mainFormIns
    End Sub
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
            Dim query As String = "DELETE FROM students WHERE id = @ID"
            DeleteRecord(query, "@ID", txtStudDataID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid Student ID.")
        End If

        LoadData()
    End Sub

    Private Sub btnDeleteProf_Click(sender As Object, e As EventArgs) Handles btnDeleteProf.Click
        If txtProfDataID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM professors WHERE id = @ID"
            DeleteRecord(query, "@ID", txtProfDataID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid data ID.")
        End If

        LoadData()
    End Sub

    Private Sub btnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        If txtCourseID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM courses WHERE Course_ID = @ID"
            DeleteRecord(query, "@ID", txtCourseID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid Course ID.")
        End If

        LoadData()
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        ' Connection string (replace with your database details)
        Dim connectionString As String = "server=localhost; user=root; database=nexus_db"

        ' SQL query to update the user record
        Dim query As String = "UPDATE users SET User_name = @username, Password = @password, User_type = @type, recovery_answer = @rec_answer WHERE User_ID = @userid"

        ' Create a connection to the database
        Using connection As New MySqlConnection(connectionString)
            ' Create a command object
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the query
                command.Parameters.AddWithValue("@username", txtUsername.Text)
                command.Parameters.AddWithValue("@password", txtPass.Text)
                command.Parameters.AddWithValue("@type", txtAccType.Text)
                command.Parameters.AddWithValue("@rec_answer", txtRecAnswer.Text)
                command.Parameters.AddWithValue("@userid", txtUserID.Text) ' Assuming you have a txtUserID field for the User_ID


                ' Open the connection
                connection.Open()

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Check if the update was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
                Else
                    MessageBox.Show("No record was updated. Please check the User ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If


            End Using
        End Using
    End Sub



    Private Sub dataGVUsers_CellContentClick(sender As Object, e As EventArgs) Handles dataGVUsers.SelectionChanged
        Try
            If dataGVUsers.CurrentRow IsNot Nothing Then
                Dim current_row As Integer = dataGVUsers.CurrentRow.Index
                txtUserID.Text = dataGVUsers(0, current_row).Value.ToString()
                txtUsername.Text = dataGVUsers(1, current_row).Value.ToString()
                txtPass.Text = dataGVUsers(2, current_row).Value.ToString()
                txtAccType.Text = dataGVUsers(3, current_row).Value.ToString()
                txtRecAnswer.Text = dataGVUsers(4, current_row).Value.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("End of records")
        End Try
    End Sub

    Private Sub dataGVStudents_CellContentClick(sender As Object, e As EventArgs) Handles dataGVStudents.SelectionChanged
        Try
            If dataGVStudents.CurrentRow IsNot Nothing Then
                Dim current_row As Integer = dataGVStudents.CurrentRow.Index
                txtStudDataID.Text = dataGVStudents(0, current_row).Value.ToString()
                txtStudID.Text = dataGVStudents(1, current_row).Value.ToString()
                txtStudFullName.Text = dataGVStudents(2, current_row).Value.ToString()
                txtStudYrSec.Text = dataGVStudents(3, current_row).Value.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("End of records")
        End Try
    End Sub

    Private Sub dataGVProfs_CellContentClick(sender As Object, e As EventArgs) Handles dataGVProfs.SelectionChanged
        Try
            If dataGVProfs.CurrentRow IsNot Nothing Then
                Dim current_row As Integer = dataGVProfs.CurrentRow.Index
                txtProfDataID.Text = dataGVProfs(0, current_row).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("End of records")
        End Try
    End Sub

    Private Sub dataGVCourses_CellContentClick(sender As Object, e As EventArgs) Handles dataGVCourses.SelectionChanged
        Try
            If dataGVCourses.CurrentRow IsNot Nothing Then
                Dim current_row As Integer = dataGVCourses.CurrentRow.Index
                txtCourseID.Text = dataGVCourses(0, current_row).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("End of records")
        End Try
    End Sub

    Private Sub btnUpdateStud_Click(sender As Object, e As EventArgs) Handles btnUpdateStud.Click
        ' Connection string (replace with your database details)
        Dim connectionString As String = "server=localhost; user=root; database=nexus_db"

        ' SQL query to update the user record
        Dim query As String = "update students set Student_ID = @studentid, Full_name = @fullname, Year_Section = @yrsec where id = @id"

        ' Create a connection to the database
        Using connection As New MySqlConnection(connectionString)
            ' Create a command object
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the query
                command.Parameters.AddWithValue("@studentid", txtUsername.Text)
                command.Parameters.AddWithValue("@fullname", txtPass.Text)
                command.Parameters.AddWithValue("@yrsec", txtAccType.Text)
                command.Parameters.AddWithValue("@id", txtStudDataID.Text)


                ' Open the connection
                connection.Open()

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Check if the update was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
                Else
                    MessageBox.Show("No record was updated. Please check the User ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If


            End Using
        End Using
    End Sub

    Private Sub btnNextManage_Click(sender As Object, e As EventArgs) Handles btnNextManage.Click
        Dim manageData2 = New manageData2(mainFormReference)

        manageData2.MdiParent = mainFormReference
        manageData2.StartPosition = FormStartPosition.Manual
        manageData2.Location = New Point(0, 0)

        manageData2.Show()
    End Sub
End Class
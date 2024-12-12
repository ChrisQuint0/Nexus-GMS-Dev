Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Agreement.JPake

Public Class manageData2
    Dim mainformReference As mainForm = Nothing
    Public Sub New(ByVal mainForm As mainForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.mainformReference = mainForm
    End Sub
    Private Sub manageData2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        dataGVDept.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dataGVDept.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        dataGVGrades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dataGVGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        dataGVPrograms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dataGVPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "server=localhost;user=root;database=nexus_db"

        Try
            ' Load Users Table
            Using connection As New MySqlConnection(connectionString)
                Dim gradesQuery As String = "SELECT * FROM grades ORDER BY Student_ID"
                Dim gradesAdapter As New MySqlDataAdapter(gradesQuery, connection)
                Dim gradesTable As New DataTable()
                gradesAdapter.Fill(gradesTable)
                dataGVGrades.DataSource = gradesTable
            End Using

            ' Load Students Table
            Using connection As New MySqlConnection(connectionString)
                Dim programsQuery As String = "SELECT * FROM programs"
                Dim programsAdapter As New MySqlDataAdapter(programsQuery, connection)
                Dim programsTable As New DataTable()
                programsAdapter.Fill(programsTable)
                dataGVPrograms.DataSource = programsTable
            End Using

            ' Load Professors Table
            Using connection As New MySqlConnection(connectionString)
                Dim deptQuery As String = "SELECT * FROM departments"
                Dim deptAdapter As New MySqlDataAdapter(deptQuery, connection)
                Dim deptTable As New DataTable()
                deptAdapter.Fill(deptTable)
                dataGVDept.DataSource = deptTable
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

    Private Sub btnDeleteGrade_Click(sender As Object, e As EventArgs) Handles btnDeleteGrade.Click
        If txtGradeID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM grades WHERE Grade_ID = @ID"
            DeleteRecord(query, "@ID", txtGradeID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid Grade ID.")
        End If
    End Sub

    Private Sub btnDeletePrograms_Click(sender As Object, e As EventArgs) Handles btnDeletePrograms.Click
        If txtProgID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM programs WHERE program_id = @ID"
            DeleteRecord(query, "@ID", txtProgID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid Program ID.")
        End If
    End Sub

    Private Sub btnDeleteDept_Click(sender As Object, e As EventArgs) Handles btnDeleteDept.Click
        If txtDeptID.Text.Trim() <> "" Then
            Dim query As String = "DELETE FROM departments WHERE Dept_ID = @ID"
            DeleteRecord(query, "@ID", txtDeptID.Text.Trim())
        Else
            MessageBox.Show("Please enter a valid User ID.")
        End If
    End Sub
End Class
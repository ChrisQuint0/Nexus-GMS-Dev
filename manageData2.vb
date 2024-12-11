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
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "server=localhost;user=root;database=nexus_db"

        Try
            ' Load Users Table
            Using connection As New MySqlConnection(connectionString)
                Dim gradesQuery As String = "SELECT * FROM grades"
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
                Dim deptQuery As String = "SELECT * FROM courses"
                Dim deptAdapter As New MySqlDataAdapter(deptQuery, connection)
                Dim deptTable As New DataTable()
                deptAdapter.Fill(deptTable)
                dataGVDept.DataSource = deptTable
            End Using

        Catch ex As MySqlException
            MessageBox.Show($"Error Loading Data: {ex.Message}")
        End Try
    End Sub
End Class
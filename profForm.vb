Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class profForm

    Dim mainFormReference As mainForm = Nothing
    Dim username As String = ""
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost; user=root; database=nexus_db")
    Public Sub New(ByVal mainForm As mainForm, username As String)

        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        mainFormReference = mainForm
        Me.username = username


    End Sub

    Private Sub profForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboProfCourse.SelectedIndex = 0
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        Me.KeyPreview = True

        initializeUserInfo()

    End Sub


    Public Sub initializeUserInfo()
        Try
            ' Open the database connection
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If

            ' Define the query to retrieve both course_handling and course_name
            Dim query As String = "SELECT * FROM vCourse_Title WHERE User_name = @UserName"

            ' Set up the command and parameters
            cmd.Connection = con
            cmd.CommandText = query
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UserName", username) ' Replace with dynamic username if needed

            ' Execute the query and read the result
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                comboProfCourse.Items.Clear() ' Clear existing items

                ' Use a HashSet to track unique course entries
                Dim uniqueCourses As New HashSet(Of String)()

                While reader.Read()
                    ' Combine course_handling and course_name into a single display value
                    Dim displayValue As String = reader("course_handling").ToString() & " - " & reader("course_title").ToString()

                    ' Only add the displayValue if it's not already in the HashSet
                    If uniqueCourses.Add(displayValue) Then
                        comboProfCourse.Items.Add(displayValue)
                    End If

                    ' Assign values to other UI elements if this is the first row
                    If comboProfCourse.Items.Count = 1 Then
                        lblWelcomeStud.Text = "Welcome, " & reader("Prof_name").ToString()
                        lblFacultyID.Text = reader("Prof_ID").ToString()
                        lblFacultyName.Text = reader("Prof_name").ToString()

                        ' Map department ID to department name
                        Dim deptName As String = String.Empty
                        Select Case Convert.ToInt32(reader("dept_id"))
                            Case 1
                                deptName = "CCS (College of Computer Studies)"
                            Case 2
                                deptName = "CON (College of Nursing)"
                            Case Else
                                deptName = "Unknown Department"
                        End Select
                        lblDepartment.Text = deptName
                    End If
                End While

                ' Optionally set the default selected item
                If comboProfCourse.Items.Count > 0 Then
                    comboProfCourse.SelectedIndex = 0
                End If
            Else
                MessageBox.Show("No records found for the given username.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close() ' Close the reader

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnLogoutProf_Click(sender As Object, e As EventArgs) Handles btnLogoutProf.Click
        Me.Close()
        If mainFormReference IsNot Nothing Then
            mainFormReference.mainBringToFront()
        End If
    End Sub

    Private Sub btnEncodeGrades_Click(sender As Object, e As EventArgs) Handles btnEncodeGrades.Click
        Dim encodeGradesForm As New encodeGrades()

        encodeGradesForm.MdiParent = mainFormReference
        encodeGradesForm.StartPosition = FormStartPosition.Manual
        encodeGradesForm.Location = New Point(0, 0)

        encodeGradesForm.Show()
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Dim profReportForm As New profReportForm()

        profReportForm.MdiParent = mainFormReference
        profReportForm.StartPosition = FormStartPosition.Manual
        profReportForm.Location = New Point(0, 0)

        profReportForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New editForm()

        editForm.MdiParent = mainFormReference
        editForm.StartPosition = FormStartPosition.Manual
        editForm.Location = New Point(0, 0)

        editForm.Show()
    End Sub

    Private Sub lblWelcomeStud_Click(sender As Object, e As EventArgs) Handles lblWelcomeStud.Click

    End Sub
End Class
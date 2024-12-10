Imports MySql.Data.MySqlClient

Imports iText.Kernel.Geom
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports iText.IO.Font
Imports iText.Kernel.Font
Imports System.IO

Public Class studentForm

    Private mainFormReference As mainForm = Nothing
    Dim username As String = ""
    Public Sub New(ByVal mainForm As mainForm, username As String)

        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        mainFormReference = mainForm
        Me.username = username

    End Sub

    Private Sub studentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        Me.KeyPreview = True

        InitializeStudentForm(username)


        DisplayGrades(username)


    End Sub


    Public Sub InitializeStudentForm(userName As String)
        Dim connectionString As String = "server=localhost; user=root; database=nexus_db"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Step 1: Get User_ID from users table
            Dim queryUser As String = "SELECT User_ID FROM users WHERE User_name = @UserName"
            Dim userId As Integer
            Using cmdUser As New MySqlCommand(queryUser, connection)
                cmdUser.Parameters.AddWithValue("@UserName", userName)
                Dim result = cmdUser.ExecuteScalar()
                If result IsNot Nothing Then
                    userId = Convert.ToInt32(result)
                Else
                    MessageBox.Show("User not found!")
                    Exit Sub
                End If
            End Using

            ' Step 2: Get Student Details from students table
            Dim studentQuery As String = "SELECT Student_ID, Full_name, Year_Section, program_id FROM students WHERE User_ID = @UserID"
            Dim studentId As String = ""
            Dim fullName As String = ""
            Dim yearSection As String = ""
            Dim programId As Integer
            Using cmdStudent As New MySqlCommand(studentQuery, connection)
                cmdStudent.Parameters.AddWithValue("@UserID", userId)
                Using reader = cmdStudent.ExecuteReader()
                    If reader.Read() Then
                        studentId = reader("Student_ID").ToString()
                        fullName = reader("Full_name").ToString()
                        yearSection = reader("Year_Section").ToString()
                        programId = Convert.ToInt32(reader("program_id"))
                    Else
                        MessageBox.Show("Student data not found!")
                        Exit Sub
                    End If
                End Using
            End Using

            ' Step 3: Get Program Name from programs table
            Dim programName As String = ""
            Dim programQuery As String = "SELECT program_name FROM programs WHERE program_id = @ProgramID"
            Using cmdProgram As New MySqlCommand(programQuery, connection)
                cmdProgram.Parameters.AddWithValue("@ProgramID", programId)
                Dim result = cmdProgram.ExecuteScalar()
                If result IsNot Nothing Then
                    programName = result.ToString()
                Else
                    MessageBox.Show("Program data not found!")
                    Exit Sub
                End If
            End Using

            ' Step 4: Update Labels
            lblWelcomeStud.Text = "Welcome " & fullName
            lblStudId.Text = studentId
            lblName.Text = fullName
            lblProgYrSec.Text = $"{programName} - {yearSection}"
        End Using
    End Sub

    Private Sub DisplayGrades(username As String)
        Dim connectionString As String = "server=localhost;user=root;database=nexus_db"
        Dim query As String = "SELECT DISTINCT g.course_id AS COURSE_CODE, " &
                          "v.course_title AS COURSE_TITLE, " &
                          "s.Year_Section AS SECTION, " &
                          "v.Prof_name AS PROFESSOR, " &
                          "g.Semestral_grade AS SEM_GRADE " &
                          "FROM grades g " &
                          "JOIN students s ON g.Student_ID = s.Student_ID " &
                          "JOIN vCourse_Title v ON g.course_id = v.course_handling AND g.Prof_ID = v.Prof_ID " &
                          "WHERE s.Student_ID = (SELECT Student_ID " &
                          "FROM students " &
                          "JOIN users ON students.User_ID = users.User_ID " &
                          "WHERE users.User_name = @Username LIMIT 1);"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)

            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Bind the DataTable to the DataGridView
                datagridGradeReport.DataSource = table

                ' Optional: Customize column headers
                datagridGradeReport.Columns("COURSE_CODE").HeaderText = "Course Code"
                datagridGradeReport.Columns("COURSE_TITLE").HeaderText = "Course Title"
                datagridGradeReport.Columns("SECTION").HeaderText = "Section"
                datagridGradeReport.Columns("PROFESSOR").HeaderText = "Professor"
                datagridGradeReport.Columns("SEM_GRADE").HeaderText = "Semestral Grade"

            Catch ex As MySqlException
                MessageBox.Show($"Display Grades Error: {ex.Message} {ex.StackTrace}")
            Finally
                connection.Close()
            End Try
        End Using
    End Sub


    Private Function GetUserIDByUsername(username As String) As Integer
        Dim userID As Integer = -1 ' Default to -1 to indicate not found
        Dim connectionString As String = "server=localhost;user=root;database=nexus_db"
        Dim query As String = "SELECT User_ID FROM users WHERE User_name = @Username"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)

            Try
                connection.Open()
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing Then
                    userID = Convert.ToInt32(result)
                End If
            Catch ex As MySqlException
                MessageBox.Show($"Error: {ex.Message}")
            Finally
                connection.Close()
            End Try
        End Using

        Return userID
    End Function

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        If mainFormReference IsNot Nothing Then
            mainFormReference.mainBringToFront()
        End If

    End Sub

    Private Sub btnDownloadCopy_Click(sender As Object, e As EventArgs) Handles btnDownloadCopy.Click
        Try
            ' Define the file path
            Dim pdfPath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Grades_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".pdf")

            ' Create PDF writer and document
            Using writer As New PdfWriter(pdfPath)
                Using pdf As New PdfDocument(writer)
                    Dim document As New Document(pdf)

                    ' Add Student ID and Course, Year, Section info
                    Dim studentInfo As String = $"Student ID: {lblStudId.Text}"
                    document.Add(New Paragraph(studentInfo))

                    Dim studentCourseYrSec As String = $"Course, Year and Section: {lblProgYrSec.Text}"
                    document.Add(New Paragraph(studentCourseYrSec))

                    ' Add Student Name and Academic Year info
                    Dim studentName As String = $"Student Name: {lblName.Text}"
                    document.Add(New Paragraph(studentName))

                    Dim acadYear As String = $"Academic Year: {lblAcadYear.Text}"
                    document.Add(New Paragraph(acadYear))


                    ' Add a space before DataGrid
                    document.Add(New Paragraph(Environment.NewLine))

                    ' Create a table with the column count and set width to 100%
                    Dim table As New Table(datagridGradeReport.Columns.Count, True)
                    table.SetWidth(UnitValue.CreatePercentValue(100))

                    ' Add Column Headers with Bold font
                    For Each column As DataGridViewColumn In datagridGradeReport.Columns
                        Dim headerText As New Text(column.HeaderText)
                        Dim font As PdfFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD)
                        headerText.SetFont(font) ' Assign the font to the text
                        table.AddHeaderCell(New Cell().Add(New Paragraph(headerText)))
                    Next

                    ' Add Rows from DataGridView
                    For Each row As DataGridViewRow In datagridGradeReport.Rows
                        If Not row.IsNewRow Then
                            For Each cell As DataGridViewCell In row.Cells
                                table.AddCell(New Cell().Add(New Paragraph(cell.Value?.ToString())))
                            Next
                        End If
                    Next

                    ' Add a bottom border to the table
                    Dim border As New iText.Layout.Borders.SolidBorder(2) ' Define a solid border with thickness 2
                    table.SetBorderBottom(border)

                    ' Add the table to the document
                    document.Add(table)

                    ' Close the document
                    document.Close()
                End Using
            End Using

            ' Notify the user
            MessageBox.Show($"PDF saved successfully at {pdfPath}", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





End Class
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class profReportForm
    Dim profID As String = ""
    Public Sub New(ByVal profID As String)
        InitializeComponent()
        Me.profID = profID
        LoadCourses()
        LoadSections()
    End Sub

    Private Sub profReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(profID) Then
            Dim query As String = "SELECT v.Prof_ID, v.Prof_name, d.Dept_Name " &
                              "FROM vCourse_Title v " &
                              "JOIN departments d ON v.dept_id = d.Dept_ID " &
                              "WHERE v.Prof_ID = @ProfID"
            Using connection As New MySqlConnection("server=localhost; user=root; database=nexus_db")
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProfID", profID)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            lblFacultyId.Text = reader("Prof_ID").ToString()
                            lblFacultyName.Text = reader("Prof_name").ToString()
                            lblDepartment.Text = reader("Dept_Name").ToString()
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub LoadCourses()
        Dim query As String = "SELECT DISTINCT c.course_code, c.course_title " &
                          "FROM vCourse_Title v " &
                          "JOIN courses c ON v.course_handling = c.course_code " &
                          "WHERE v.Prof_ID = @ProfID"
        Using connection As New MySqlConnection("server=localhost; user=root; database=nexus_db")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ProfID", profID)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim courseDisplay As String = $"{reader("course_code")}: {reader("course_title")}"
                        comboCourse.Items.Add(courseDisplay)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadSections()
        Dim query As String = "SELECT DISTINCT section_handling " &
                          "FROM vCourse_Title " &
                          "WHERE Prof_ID = @ProfID"
        Using connection As New MySqlConnection("server=localhost; user=root; database=nexus_db")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ProfID", profID)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        comboSection.Items.Add(reader("section_handling").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadGrades()
        ' Ensure that a course and section are selected
        If comboCourse.SelectedItem IsNot Nothing AndAlso comboSection.SelectedItem IsNot Nothing Then

            dataGradesProf.DataSource = Nothing
            dataGradesProf.Rows.Clear()

            Dim query As String = "SELECT DISTINCT g.Student_ID, 
                s.Full_name, 
                g.course_id, 
                g.Midterm_attendance, 
                g.Midterm_quiz_1, 
                g.Midterm_quiz_1_total, 
                g.Midterm_quiz_2, 
                g.Midterm_quiz_2_total, 
                g.Midterm_lab, 
                g.Midterm_recitation, 
                g.Midterm_exam, 
                g.Midterm_exam_grade, 
                g.Midterm_grade, 
                g.Finals_attendance, 
                g.Finals_quiz_1, 
                g.Finals_quiz_1_total, 
                g.Finals_lab, 
                g.Finals_recitation, 
                g.Finals_exam, 
                g.Finals_exam_grade, 
                g.Finals_grade, 
                g.Semestral_grade, 
                g.Semester, 
                g.College_grade,
                g.remarks
                FROM grades g
                JOIN students s ON g.Student_ID = s.Student_ID
                JOIN vCourse_Title v ON g.course_id = v.course_handling
                WHERE g.Prof_ID = @ProfID 
                  AND g.course_id = @CourseID 
                  AND s.Year_Section = @Section"
            Using connection As New MySqlConnection("server=localhost; user=root; database=nexus_db")
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProfID", profID)
                    command.Parameters.AddWithValue("@CourseID", comboCourse.SelectedItem.ToString().Split(":"c)(0)) ' Extract course_code
                    command.Parameters.AddWithValue("@Section", comboSection.SelectedItem.ToString()) ' Ensure SelectedItem is not Nothing
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dataGradesProf.DataSource = table
                End Using
            End Using
        End If


    End Sub

    Private Sub btnBackReport_Click(sender As Object, e As EventArgs) Handles btnBackReport.Click
        Me.Close()
    End Sub

    Private Sub comboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCourse.SelectedIndexChanged
        LoadGrades()


    End Sub

    Private Sub comboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSection.SelectedIndexChanged

        LoadGrades()
    End Sub
End Class
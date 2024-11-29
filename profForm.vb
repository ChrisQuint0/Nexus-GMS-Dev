Public Class profForm

    Dim mainFormReference As mainForm = Nothing
    Public Sub New(ByVal mainForm As mainForm)

        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        mainFormReference = mainForm


    End Sub

    Private Sub profForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboProfCourse.SelectedIndex = 0
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        Me.KeyPreview = True
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

    Private Sub profForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub
End Class
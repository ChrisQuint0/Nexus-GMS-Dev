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
    End Sub

    Private Sub btnLogoutProf_Click(sender As Object, e As EventArgs) Handles btnLogoutProf.Click
        Me.Close()
        If mainFormReference IsNot Nothing Then
            mainFormReference.mainBringToFront()
        End If
    End Sub
End Class
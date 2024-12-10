Public Class adminForm

    Dim mainFormReference As mainForm = Nothing
    Dim adminUserName As String

    Public Sub New(ByVal mainForm As mainForm, username As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainFormReference = mainForm
        adminUserName = username

    End Sub
    Private Sub btnLogoutAdmin_Click(sender As Object, e As EventArgs) Handles btnLogoutAdmin.Click
        Me.Close()
        If mainFormReference IsNot Nothing Then
            mainFormReference.mainBringToFront()
        End If
    End Sub

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        Me.KeyPreview = True

        lblWelcomeAdmin.Text = "Welcome " & adminUserName

    End Sub

    Private Sub adminForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub


    Private Sub btnEncodeAdminCard_Click(sender As Object, e As EventArgs) Handles btnEncodeAdminCard.Click
        Dim encodeNewDataForm As New encodeNewData()

        encodeNewDataForm.MdiParent = mainFormReference
        encodeNewDataForm.StartPosition = FormStartPosition.Manual
        encodeNewDataForm.Location = New Point(0, 0)

        encodeNewDataForm.Show()
    End Sub

    Private Sub btnEncodeAdmin_Click(sender As Object, e As EventArgs) Handles btnEncodeAdmin.Click
        Dim encodeNewDataForm As New encodeNewData()

        encodeNewDataForm.MdiParent = mainFormReference
        encodeNewDataForm.StartPosition = FormStartPosition.Manual
        encodeNewDataForm.Location = New Point(0, 0)

        encodeNewDataForm.Show()
    End Sub


    Private Sub btnAssignAdminCard_Click(sender As Object, e As EventArgs) Handles btnAssignAdminCard.Click
        Dim manageData As New manageData()

        manageData.MdiParent = mainFormReference
        manageData.StartPosition = FormStartPosition.Manual
        manageData.Location = New Point(0, 0)

        manageData.Show()
    End Sub

    Private Sub btnAssignProf_Click(sender As Object, e As EventArgs) Handles btnAssignProf.Click
        Dim manageData As New manageData()

        manageData.MdiParent = mainFormReference
        manageData.StartPosition = FormStartPosition.Manual
        manageData.Location = New Point(0, 0)

        manageData.Show()
    End Sub


End Class
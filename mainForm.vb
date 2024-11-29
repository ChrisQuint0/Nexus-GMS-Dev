Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class mainForm
    Dim mainFormIns As mainForm
    Dim passwordShown As Boolean = False

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainFormIns = New mainForm()

        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        IsMdiContainer = True

        'Me.TopMost = True
    End Sub

    Private Sub checkBShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkBShowPass.CheckedChanged

        If Not passwordShown Then
            txtPass.PasswordChar = ""
            passwordShown = True
        Else
            txtPass.PasswordChar = "●"
            passwordShown = False
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUsername.Text = "Chris" And txtPass.Text = "pass" Then
            Dim studForm = New studentForm(Me)

            studForm.MdiParent = Me
            studForm.StartPosition = FormStartPosition.Manual
            studForm.Location = New Point(0, 0)

            mainSendToBack()
            studForm.Show()

        ElseIf txtUsername.Text = "Rodolfo" And txtPass.Text = "passprof" Then
            Dim profForm = New profForm(Me)

            profForm.MdiParent = Me
            profForm.StartPosition = FormStartPosition.Manual
            profForm.Location = New Point(0, 0)

            mainSendToBack()
            profForm.Show()
        ElseIf txtUsername.Text = "Fred" And txtPass.Text = "passadmin" Then
            Dim adminForm = New adminForm(Me)

            adminForm.MdiParent = Me
            adminForm.StartPosition = FormStartPosition.Manual
            adminForm.Location = New Point(0, 0)

            mainSendToBack()
            adminForm.Show()
        End If
    End Sub

    Public Sub mainSendToBack()
        picLogInFormBg.SendToBack()
        txtUsername.SendToBack()
        txtPass.SendToBack()
        btnLogIn.SendToBack()
        lblForgotPassword.SendToBack()
        checkBShowPass.SendToBack()

    End Sub

    Public Sub mainBringToFront()
        picLogInFormBg.BringToFront()
        txtUsername.BringToFront()
        txtPass.BringToFront()
        btnLogIn.BringToFront()
        lblForgotPassword.BringToFront()
        checkBShowPass.BringToFront()
    End Sub

    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        Dim forgotPassForm As New forgotPassForm(Me)

        forgotPassForm.MdiParent = Me
        forgotPassForm.StartPosition = FormStartPosition.Manual
        forgotPassForm.Location = New Point(0, 0)

        mainSendToBack()
        forgotPassForm.Show()
    End Sub
End Class

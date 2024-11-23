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


    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub picLogInFormBg_Click(sender As Object, e As EventArgs) Handles picLogInFormBg.Click

    End Sub
End Class

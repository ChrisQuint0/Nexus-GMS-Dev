Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class mainForm
    Dim passwordShown As Boolean = False

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        Me.TopMost = True
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
End Class

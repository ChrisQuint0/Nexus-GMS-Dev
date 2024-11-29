Public Class assignProf
    Private Sub btnAssignProfBack_Click(sender As Object, e As EventArgs) Handles btnAssignProfBack.Click
        Me.Close()
    End Sub

    Private Sub maskedStudId_TextChanged(sender As Object, e As EventArgs) Handles maskedStudId.TextChanged
        If maskedStudId.Text = "23-00265" Then
            txtStudName.Text = "Keith Tornea"
            txtYrSec.Text = "2A"
        Else
            txtStudName.Clear()
            txtYrSec.Clear()
        End If

    End Sub

    Private Sub assignProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub assignProf_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub
End Class
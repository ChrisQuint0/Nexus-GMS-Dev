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
End Class
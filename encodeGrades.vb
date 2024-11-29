Public Class encodeGrades
    Private Sub encodeGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'panelMidEncode.SendToBack()
        Me.KeyPreview = True
    End Sub
    Private Sub encodeGrades_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub maskedTxtStudId_TextChanged(sender As Object, e As EventArgs) Handles maskedTxtStudId.TextChanged
        If maskedTxtStudId.Text = "23-00265" Then
            txtStudName.Text = "Keith Tornea"
            comboProgramEncode.SelectedItem = "BS in Information Technology"
            comboSectionEncode.SelectedItem = "2A"
            comboCourseEncode.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnBackEncode_Click(sender As Object, e As EventArgs) Handles btnBackEncode.Click
        Me.Close()
    End Sub
End Class
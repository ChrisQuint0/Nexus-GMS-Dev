Public Class profReportForm
    Private Sub btnBackReport_Click(sender As Object, e As EventArgs) Handles btnBackReport.Click
        Me.Close()
    End Sub

    Private Sub comboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCourse.SelectedIndexChanged

    End Sub

    Private Sub profReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub profReportForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub
End Class
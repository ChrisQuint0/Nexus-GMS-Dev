Public Class profReportForm
    Private Sub btnBackReport_Click(sender As Object, e As EventArgs) Handles btnBackReport.Click
        Me.Close()
    End Sub

    Private Sub profReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class
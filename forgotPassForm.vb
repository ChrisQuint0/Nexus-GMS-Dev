Imports MySql.Data.MySqlClient

Public Class forgotPassForm
    Dim mainFormReference As mainForm = Nothing
    Dim username As String = ""
    Dim con As New MySqlConnection("server=localhost; user=root; database=nexus_db")
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Public Sub New(ByVal mainForm As mainForm, username As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainFormReference = mainForm

        Me.username = username

    End Sub

    Private Sub forgotPassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        Me.KeyPreview = True
    End Sub

    Private Sub btnCancelPass_Click(sender As Object, e As EventArgs) Handles btnCancelPass.Click
        Me.Close()

        If mainFormReference IsNot Nothing Then
            mainFormReference.mainBringToFront()
        End If
    End Sub

    Private Sub btnSubmitPass_Click(sender As Object, e As EventArgs) Handles btnSubmitPass.Click
        ' Open the connection
        con.Open()

        ' SQL query to validate the user
        Dim query As String = "SELECT * FROM users WHERE User_name = @username;"
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", username)

        ' Execute the reader
        reader = cmd.ExecuteReader()

        ' Check if the reader has data
        If reader.Read() Then
            Dim recoveryAnswer = reader("recovery_answer").ToString()

            ' Compare the recovery answer (case-insensitive)
            If recoveryAnswer = LCase(txtRecoveryAnswer.Text.Trim()) Then
                MessageBox.Show($"Username: {reader("User_name").ToString()}" & vbCrLf &
                                $"Password: {reader("Password").ToString()}")
            Else
                MessageBox.Show("Incorrect recovery answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Username not found.")
        End If

        ' Close the reader and connection
        reader.Close()
        con.Close()
    End Sub

End Class
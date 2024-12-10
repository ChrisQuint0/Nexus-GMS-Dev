Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

'This is the updated master branch 29/11/2024 3:46 PM
'This is the updated master branch 29/11/2024 9:48 PM Add Fia's Esc Functionality
Public Class mainForm
    Dim mainFormIns As mainForm
    Dim passwordShown As Boolean = False

    Dim con As New MySqlConnection("server=localhost; user=root; database=nexus_db")
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainFormIns = New mainForm()

        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds

        IsMdiContainer = True

        'Me.TopMost = True

        Me.KeyPreview = True
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
        ' Retrieve inputs
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPass.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please fill in both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            ' Open the connection
            con.Open()

            ' SQL query to validate the user
            Dim query As String = "SELECT User_type FROM users WHERE User_name = @username AND Password = @password;"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            ' Execute query
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim userType As String = reader("User_type").ToString()

                ' Redirect to the appropriate form based on User_type
                Select Case userType
                    Case "admin"
                        Dim adminForm = New adminForm(Me, username)

                        adminForm.MdiParent = Me
                        adminForm.StartPosition = FormStartPosition.Manual
                        adminForm.Location = New Point(0, 0)

                        mainSendToBack()
                        adminForm.Show()
                    Case "student"
                        Dim studForm = New studentForm(Me, username)

                        studForm.MdiParent = Me
                        studForm.StartPosition = FormStartPosition.Manual
                        studForm.Location = New Point(0, 0)

                        mainSendToBack()
                        studForm.Show()

                    Case "professor"
                        Dim profForm = New profForm(Me, username)

                        profForm.MdiParent = Me
                        profForm.StartPosition = FormStartPosition.Manual
                        profForm.Location = New Point(0, 0)

                        mainSendToBack()
                        profForm.Show()

                    Case Else
                        MessageBox.Show("User type not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

            Else
                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the reader and connection
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then reader.Close()
            con.Close()
        End Try
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
    Private Sub mainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim confirmEsc = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEsc = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub
End Class

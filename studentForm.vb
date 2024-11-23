﻿Public Class studentForm

    Private mainFormReference As mainForm = Nothing
    Public Sub New(ByVal mainForm As mainForm)

        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        mainFormReference = mainForm


    End Sub
    Private Sub studentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        Me.Bounds = Screen.PrimaryScreen.Bounds
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        If mainFormReference IsNot Nothing Then
            mainFormReference.mainBringToFront()
        End If

    End Sub
End Class
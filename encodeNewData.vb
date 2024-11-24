Public Class encodeNewData
    Private Sub btnBackEncodeNew_Click(sender As Object, e As EventArgs) Handles btnBackEncodeNew.Click
        Me.Close()
    End Sub

    Private Sub comboAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboAccountType.SelectedIndexChanged
        If comboAccountType.SelectedIndex = 0 Then
            enableNewStudent()
            disableNewFaculty()
            disableNewCourse()
            btnAdminGenReport.Enabled = True
        ElseIf comboAccountType.SelectedIndex = 1 Then
            disableNewStudent()
            enableNewFaculty()
            disableNewCourse()
            btnAdminGenReport.Enabled = True
        ElseIf comboAccountType.SelectedIndex = 2 Then
            disableNewStudent()
            disableNewFaculty()
            enableNewCourse()
            btnAdminGenReport.Enabled = True
        Else
            btnAdminGenReport.Enabled = False
        End If
    End Sub

    Public Sub enableNewStudent()
        txtNewStudID.Enabled = True
        txtNewStudName.Enabled = True
        txtNewYrSec.Enabled = True
        comboNewStudDept.Enabled = True
        comboNewStudProgram.Enabled = True
        comboNewStudCourse.Enabled = True
        btnAddStud.Enabled = True

    End Sub

    Public Sub disableNewStudent()
        txtNewStudID.Enabled = False
        txtNewStudName.Enabled = False
        txtNewYrSec.Enabled = False
        comboNewStudDept.Enabled = False
        comboNewStudProgram.Enabled = False
        comboNewStudCourse.Enabled = False
        btnAddStud.Enabled = False

        txtNewStudID.Clear()
        txtNewStudName.Clear()
        txtNewYrSec.Clear()
        comboNewStudDept.SelectedIndex = -1
        comboNewStudProgram.SelectedIndex = -1
        comboNewStudCourse.SelectedIndex = -1


    End Sub

    Public Sub enableNewFaculty()
        txtNewFacultyID.Enabled = True
        txtNewFacultyName.Enabled = True
        comboNewFacultyDept.Enabled = True
        comboNewFacultySub.Enabled = True
        btnAddFaculty.Enabled = True

    End Sub

    Public Sub disableNewFaculty()
        txtNewFacultyID.Enabled = False
        txtNewFacultyName.Enabled = False
        comboNewFacultyDept.Enabled = False
        comboNewFacultySub.Enabled = False
        btnAddFaculty.Enabled = False

        txtNewFacultyID.Clear()
        txtNewFacultyName.Clear()
        comboNewFacultyDept.SelectedIndex = -1
        comboNewFacultySub.SelectedIndex = -1

    End Sub

    Public Sub enableNewCourse()
        txtNewCourseCode.Enabled = True
        txtNewCourseTitle.Enabled = True
        txtNewCourseCurYear.Enabled = True
        btnAddCourse.Enabled = True
    End Sub

    Public Sub disableNewCourse()
        txtNewCourseCode.Enabled = False
        txtNewCourseTitle.Enabled = False
        txtNewCourseCurYear.Enabled = False
        btnAddCourse.Enabled = False

        txtNewCourseCode.Clear()
        txtNewCourseTitle.Clear()
        txtNewCourseCurYear.Clear()

    End Sub
End Class
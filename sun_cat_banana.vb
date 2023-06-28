Public Class The Mindful Teacher
    'Define global variables
    Dim totalNumberOfStudents As Integer
    Dim numOfStudentsPresent As Integer
    Dim numOfStudentsLate As Integer

    'Declare the Form Load Event
    Private Sub TheMindfulTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalNumberOfStudents = 20
        numOfStudentsPresent = 0
        numOfStudentsLate = 0
    End Sub

    'Declare the Button Click Event
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        If totalNumberOfStudents > 0 Then
            If txtStudentName.Text <> "" Then
                'Add the student to the list
                lstStudentName.Items.Add(txtStudentName.Text)
                totalNumberOfStudents -= 1
                If cboStudentStatus.Text = "present" Then
                    numOfStudentsPresent += 1
                Else
                    numOfStudentsLate += 1
                End If
                'clear the form
                txtStudentName.Clear()
                cboStudentStatus.SelectedIndex = -1
                'update the labels
                lblNumberOfStudents.Text = totalNumberOfStudents.ToString
                lblPresent.Text = "Present: " & numOfStudentsPresent.ToString
                lblLate.Text = "Late: " & numOfStudentsLate.ToString
            Else
                MessageBox.Show("Please enter a student name.")
            End If
        Else
            MessageBox.Show("All students have been entered.")
        End If
    End Sub

    'Declare the Form Closed Event
    Private Sub TheMindfulTeacher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MessageBox.Show("Number of students present: " & numOfStudentsPresent.ToString &
" Number of students late: " & numOfStudentsLate.ToString, "Summary")
    End Sub

End Class
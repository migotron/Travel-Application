Public Class AnswerQuestionnaireForm
    Private q1 As Boolean = False, q2 As Boolean = False, q3 As Boolean = False, q4 As Boolean = False, q5 As Boolean = False, q6 As Boolean = False, q7 As Boolean = False, q8 As Boolean = False, q9 As Boolean = False, q10 As Boolean = False


    Private a1 As String = "", a2 As String = "", a3 As String = "", a4 As String = "", a5 As String = "", a6 As String = "", a7 As String = "", a8 As String = "", a9 As String = "", a10 As String = ""

    Private a11 As String = "Sub Question1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            a1 = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            a1 = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            a1 = RadioButton3.Text
        End If

        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        q1 = True
    End Sub

    Private Sub Question2(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged, RadioButton6.CheckedChanged, RadioButton5.CheckedChanged, RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            a2 = RadioButton4.Text
        ElseIf RadioButton5.Checked Then
            a2 = RadioButton5.Text
        ElseIf RadioButton6.Checked Then
            a2 = RadioButton6.Text
        ElseIf RadioButton7.Checked Then
            a2 = RadioButton7.Text
        End If

        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton6.Enabled = False
        RadioButton7.Enabled = False
        q2 = True
    End Sub

    Private Sub Question3(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged, RadioButton8.CheckedChanged, RadioButton11.CheckedChanged, RadioButton10.CheckedChanged
        If RadioButton9.Checked Then
            a3 = RadioButton9.Text
        ElseIf RadioButton10.Checked Then
            a3 = RadioButton10.Text
        ElseIf RadioButton11.Checked Then
            a3 = RadioButton11.Text
        ElseIf RadioButton8.Checked Then
            a3 = RadioButton8.Text
        End If

        RadioButton9.Enabled = False
        RadioButton8.Enabled = False
        RadioButton10.Enabled = False
        RadioButton11.Enabled = False
        q3 = True
    End Sub

    Private Sub Question4(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged, RadioButton13.CheckedChanged, RadioButton12.CheckedChanged
        If RadioButton14.Checked Then
            a4 = RadioButton14.Text
        ElseIf RadioButton12.Checked Then
            a4 = RadioButton12.Text
        ElseIf RadioButton13.Checked Then
            a4 = RadioButton13.Text
        End If

        RadioButton14.Enabled = False
        RadioButton12.Enabled = False
        RadioButton13.Enabled = False
        q4 = True
    End Sub

    Private Sub Question5(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged, RadioButton17.CheckedChanged, RadioButton16.CheckedChanged, RadioButton15.CheckedChanged
        If RadioButton15.Checked Then
            a5 = RadioButton15.Text
        ElseIf RadioButton16.Checked Then
            a5 = RadioButton16.Text
        ElseIf RadioButton17.Checked Then
            a5 = RadioButton17.Text
        ElseIf RadioButton18.Checked Then
            a5 = RadioButton18.Text
        End If

        RadioButton15.Enabled = False
        RadioButton16.Enabled = False
        RadioButton17.Enabled = False
        RadioButton18.Enabled = False
        q5 = True
    End Sub

    Private Sub Question6(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged, RadioButton20.CheckedChanged
        If RadioButton21.Checked Then
            a6 = RadioButton21.Text
        ElseIf RadioButton20.Checked Then
            a6 = RadioButton20.Text
        End If

        RadioButton20.Enabled = False
        RadioButton21.Enabled = False
        q6 = True
    End Sub

    Private Sub Question7(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged, RadioButton19.CheckedChanged
        If RadioButton22.Checked Then
            a7 = RadioButton22.Text
        ElseIf RadioButton19.Checked Then
            a7 = RadioButton19.Text
        End If

        RadioButton22.Enabled = False
        RadioButton19.Enabled = False
        q7 = True
    End Sub

    Private Sub Question8(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged, RadioButton25.CheckedChanged, RadioButton24.CheckedChanged, RadioButton23.CheckedChanged
        If RadioButton24.Checked Then
            a8 = RadioButton24.Text
        ElseIf RadioButton25.Checked Then
            a8 = RadioButton25.Text
        ElseIf RadioButton26.Checked Then
            a8 = RadioButton26.Text
        ElseIf RadioButton23.Checked Then
            a8 = RadioButton23.Text
        End If

        RadioButton26.Enabled = False
        RadioButton25.Enabled = False
        RadioButton24.Enabled = False
        RadioButton23.Enabled = False
        q8 = True
    End Sub

    Private Sub Question9(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged, RadioButton29.CheckedChanged, RadioButton28.CheckedChanged, RadioButton27.CheckedChanged
        If RadioButton27.Checked Then
            a9 = RadioButton27.Text
        ElseIf RadioButton28.Checked Then
            a9 = RadioButton28.Text
        ElseIf RadioButton29.Checked Then
            a9 = RadioButton29.Text
        ElseIf RadioButton30.Checked Then
            a9 = RadioButton30.Text
        End If
        RadioButton27.Enabled = False
        RadioButton28.Enabled = False
        RadioButton29.Enabled = False
        RadioButton30.Enabled = False
        q9 = True
    End Sub

    Private Sub Question10(sender As Object, e As EventArgs) Handles RadioButton33.CheckedChanged, RadioButton32.CheckedChanged
        If RadioButton33.Checked Then
            a10 = RadioButton33.Text
        ElseIf RadioButton32.Checked Then
            a10 = RadioButton32.Text
        End If

        RadioButton33.Enabled = False
        RadioButton32.Enabled = False
        q10 = True
    End Sub
"
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (q1 And q2 And q3 And q4 And q5 And q6 And q7 And q8 And q9 And q10) Then
            MessageBox.Show("All questions answered, now it will display!")
            MessageBox.Show("a1: " & a1 & vbCr & "a2: " & a2 & vbCr & "a3: " & a3 & vbCr & "a4: " & a4 & vbCr & "a5: " & a5 & vbCr & "a6: " & a6 & vbCr & "a7: " & a7 & vbCr & "a8: " & a8 & vbCr & "a9: " & a9 & vbCr & "a10: " & a10)
        Else
            MessageBox.Show("Please answer all the questions before proceeding!!")
        End If
    End Sub
End Class
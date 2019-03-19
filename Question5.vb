Public Class Question5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TrackBar1.Value = 0 Then
            InitialSelectionForm.user.setQuestionAnswer5(Label2.Text)
        ElseIf TrackBar1.Value = 1 Then
            InitialSelectionForm.user.setQuestionAnswer5(Label3.Text)
        ElseIf TrackBar1.Value = 2 Then
            InitialSelectionForm.user.setQuestionAnswer5(Label4.Text)
        ElseIf TrackBar1.Value = 3 Then
            InitialSelectionForm.user.setQuestionAnswer5(Label5.Text)
        End If
        Dim oForm As Question6
        oForm = New Question6()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
Public Class Question7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TrackBar1.Value = 0 Then
            InitialSelectionForm.user.setQuestionAnswer7("$")
        ElseIf TrackBar1.Value = 1 Then
            InitialSelectionForm.user.setQuestionAnswer7("$$")
        ElseIf TrackBar1.Value = 2 Then
            InitialSelectionForm.user.setQuestionAnswer7("$$$")
        ElseIf TrackBar1.Value = 3 Then
            InitialSelectionForm.user.setQuestionAnswer7("$$$$")
        End If
        Dim oForm As Question8
        oForm = New Question8()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
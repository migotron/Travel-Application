Public Class Question10
    Private Sub YesButton_CheckedChanged(sender As Object, e As EventArgs) Handles YesButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer10(YesButton.Text)
    End Sub

    Private Sub NoButton_CheckedChanged(sender As Object, e As EventArgs) Handles NoButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer10(NoButton.Text)
    End Sub
End Class
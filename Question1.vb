Public Class Question1
    Private Sub AdventurousButton_CheckedChanged(sender As Object, e As EventArgs) Handles AdventurousButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer1(AdventurousButton.Text)
        Dim oForm As Question2
        oForm = New Question2()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub NatureLoverButton_CheckedChanged(sender As Object, e As EventArgs) Handles NatureLoverButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer1(NatureLoverButton.Text)
        Dim oForm As Question2
        oForm = New Question2()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub DangerJunkieButton_CheckedChanged(sender As Object, e As EventArgs) Handles DangerJunkieButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer1(NatureLoverButton.Text)
        Dim oForm As Question2
        oForm = New Question2()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
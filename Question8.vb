Public Class Question8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ForeignTravelButton.Click
        InitialSelectionForm.user.setQuestionAnswer8("Foreign Travel")
        Dim oForm As Question9
        oForm = New Question9()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub LocalButton_CheckedChanged(sender As Object, e As EventArgs) Handles LocalButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer8("Local Travel")
        Dim oForm As Question9
        oForm = New Question9()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
Public Class Question2
    Private Sub FamilyButton_CheckedChanged(sender As Object, e As EventArgs) Handles FamilyButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer2(FamilyButton.Text)
        Dim oForm As Question3
        oForm = New Question3()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub FriendsButton_CheckedChanged(sender As Object, e As EventArgs) Handles FriendsButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer2(FriendsButton.Text)
        Dim oForm As Question3
        oForm = New Question3()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub SpouseButton_CheckedChanged(sender As Object, e As EventArgs) Handles SpouseButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer2(SpouseButton.Text)
        Dim oForm As Question3
        oForm = New Question3()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub AloneButton_CheckedChanged(sender As Object, e As EventArgs) Handles AloneButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer2(AloneButton.Text)
        Dim oForm As Question3
        oForm = New Question3()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
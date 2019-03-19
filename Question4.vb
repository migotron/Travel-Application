Public Class Question4
    Private Sub SpringButton_CheckedChanged(sender As Object, e As EventArgs) Handles SpringButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer4(SpringButton.Text)
        Dim oForm As Question5
        oForm = New Question5()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub SummerButton_CheckedChanged(sender As Object, e As EventArgs) Handles SummerButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer4(SummerButton.Text)
        Dim oForm As Question5
        oForm = New Question5()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub FallButton_CheckedChanged(sender As Object, e As EventArgs) Handles FallButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer4(FallButton.Text)
        Dim oForm As Question5
        oForm = New Question5()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub WinterButton_CheckedChanged(sender As Object, e As EventArgs) Handles WinterButton.CheckedChanged
        InitialSelectionForm.user.setQuestionAnswer4(WinterButton.Text)
        Dim oForm As Question5
        oForm = New Question5()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
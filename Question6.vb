Public Class Question6
    Private Sub Waterrafting_Click(sender As Object, e As EventArgs) Handles Waterrafting.Click
        InitialSelectionForm.user.setQuestionAnswer5("Water Rafting")
        Dim oForm As Question7
        oForm = New Question7()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub Skiing_Click(sender As Object, e As EventArgs) Handles Skiing.Click
        InitialSelectionForm.user.setQuestionAnswer5("Skiing")
        Dim oForm As Question7
        oForm = New Question7()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub Parasailing_Click(sender As Object, e As EventArgs) Handles Parasailing.Click
        InitialSelectionForm.user.setQuestionAnswer5("Parasailing")
        Dim oForm As Question7
        oForm = New Question7()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub Hiking_Click(sender As Object, e As EventArgs) Handles Hiking.Click
        InitialSelectionForm.user.setQuestionAnswer5("Hiking")
        Dim oForm As Question7
        oForm = New Question7()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
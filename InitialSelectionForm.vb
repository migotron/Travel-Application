Public Class InitialSelectionForm
    Public Shared user As New UserInformation
    Private Sub SelectAdventure_Click(sender As Object, e As EventArgs) Handles SelectAdventure.Click
        Dim oForm As SelectAdventureForm
        oForm = New SelectAdventureForm()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub AnswerQuestionnaire_Click(sender As Object, e As EventArgs) Handles AnswerQuestionnaire.Click
        Dim oForm As Question1
        oForm = New Question1()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
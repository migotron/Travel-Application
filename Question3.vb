Public Class Question3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles USButton.Click
        InitialSelectionForm.user.setQuestionAnswer3(USButton.Text)
        Dim oForm As Question4
        oForm = New Question4()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SAButton.Click
        InitialSelectionForm.user.setQuestionAnswer3(SAButton.Text)
        Dim oForm As Question4
        oForm = New Question4()
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles IndiaButton.Click
        InitialSelectionForm.user.setQuestionAnswer3(IndiaButton.Text)
        Dim oForm As Question4
        oForm = New Question4()
        Me.Hide()
        oForm.Show()
    End Sub
End Class
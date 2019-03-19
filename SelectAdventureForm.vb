Public Class SelectAdventureForm
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.SelectedIndex = 0 Then
            'MessageBox.Show("This is an example of what would show for selecting the United States.")
            PictureBox1.ImageLocation = "C:\Users\Migotronn\Pictures\USflag.png"
        ElseIf ComboBox1.SelectedIndex.Equals(1) Then
            'MessageBox.Show("This is an example of what would show for selecting the Saudi Arabia.")
            PictureBox1.ImageLocation = "C:\Users\Migotronn\Pictures\SaudiArabiaflag.png"
        ElseIf ComboBox1.SelectedIndex.Equals(2) Then
            'MessageBox.Show("This is an example of what would show for selecting the India.")
            PictureBox1.ImageLocation = "C:\Users\Migotronn\Pictures\Indiaflag.png"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ComboBox1.Text.Equals("") Then
            Dim oForm As AdventureBasedOnCountry
            oForm = New AdventureBasedOnCountry()
            Me.Hide()
            oForm.Show()
        Else
            MessageBox.Show("You have not selected a country!")
        End If

    End Sub
End Class

Public Class Form1
    Private Sub PoundButton_Click(sender As Object, e As EventArgs) Handles PoundButton.Click
        Dim dollars As Double = Val(DollarTextBox.Text)
        Dim pounds As Double = dollars * 0.79
        ConvertedCurrencyLabel.Text = "Pounds"
        ConvertedAmountTextBox.Text = pounds.ToString("C")
    End Sub

    Private Sub YuanButton_Click(sender As Object, e As EventArgs) Handles YuanButton.Click
        Dim dollars As Double = Val(DollarTextBox.Text)
        Dim yuan As Double = dollars * 7.12
        ConvertedCurrencyLabel.Text = "Yuan"
        ConvertedAmountTextBox.Text = yuan.ToString("C")
    End Sub

    Private Sub EuroButton_Click(sender As Object, e As EventArgs) Handles EuroButton.Click
        Dim dollars As Double = Val(DollarTextBox.Text)
        Dim euros As Double = dollars * 0.92
        ConvertedCurrencyLabel.Text = "Euro"
        ConvertedAmountTextBox.Text = euros.ToString("C")
    End Sub

    Private Sub CADButton_Click(sender As Object, e As EventArgs) Handles CADButton.Click
        Dim dollars As Double = Val(DollarTextBox.Text)
        Dim cad As Double = dollars * 1.36
        ConvertedCurrencyLabel.Text = "CAD"
        ConvertedAmountTextBox.Text = cad.ToString("C")
    End Sub
End Class

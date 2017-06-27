' Norris Smith 3-20-17
' Purpose: To design a program that changes the background and foreground color of a text area,
'          per the user seletions.

Public Class frmAssignment_1
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        ' changes backcolor to blue
        txtQuote.BackColor = Color.Blue
    End Sub

    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        ' changes backcolor to yellow
        txtQuote.BackColor = Color.Yellow
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        ' changes forecolor to red
        txtQuote.ForeColor = Color.Red
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        ' changes forecolor to green
        txtQuote.ForeColor = Color.Green
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' resets text area to original state
        txtQuote.BackColor = Color.White
        txtQuote.ForeColor = Color.Black
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        ' closes program
        Me.Close()
    End Sub
End Class

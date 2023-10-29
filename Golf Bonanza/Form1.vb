Public Class Form1

    'Validation for the username
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Len(txtOutNameForm1.Text) <= 2 Or Len(txtOutNameForm1.Text) >= 20 Then
            MsgBox("Your fullname must be between 2 and 20 characters long")
        ElseIf txtOutPostCode.Text < 1000 Or txtOutPostCode.Text > 10000 Then
            MsgBox("Your postcode must be in the correct range to be verified as correct")
        Else
            Form2.Show()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Welcome to Golf Bonanza! Your enjoyment is our priority, and here, we only serve the most premium and longlasting golf eqiupment you need to up your game. We hope you have fun!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        backupform.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radioVictoria_CheckedChanged(sender As Object, e As EventArgs) Handles radioVictoria.CheckedChanged

    End Sub

    Private Sub txtOutNameForm1_TextChanged(sender As Object, e As EventArgs) Handles txtOutNameForm1.TextChanged

    End Sub
End Class

Public Class ReceiptForm_5
    Public costv5FINAL As Single = Form6.costv4
    Private Sub txtOutFinal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOut.TextChanged

    End Sub

    Private Sub ReceiptForm_5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOut.Text = FormatCurrency(costv5FINAL)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Thank you for taking a look at my project. Open Sourced and can be redistributed under MIT Lisence. Created By Dario Gerald, 2023, October. Follow me on Github! https://github.com/Pinkk-Flag")
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
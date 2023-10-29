Public Class ReceiptForm_5
    Public costv5FINAL As Single = Form6.costv4

    Private Sub ReceiptForm_5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOut.Text = FormatCurrency(costv5FINAL)
        txtName.Text = Form1.txtOutNameForm1.Text
        txtPost.Text = Form1.txtOutPostCode.Text
        txtAddress.Text = Form1.TextBox3.Text
        txtPhone.Text = Form1.TextBox4.Text
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Thank you for taking a look at my project. Open Sourced and can be redistributed under MIT Lisence. Created By Dario Gerald, 2023, October. Follow me on Github! https://github.com/Pinkk-Flag")
    End Sub
End Class
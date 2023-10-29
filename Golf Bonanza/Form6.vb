Public Class Form6
    Public costv4 As Single = (ExtrasForm_4.costv3 * ExtrasForm_4.quantscroll.Value) * ExtrasForm_4.discount
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Hide()
        ReceiptForm_5.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
﻿Public Class ExtrasForm_4
    Public discount As Single

    Public costv3 As Single = (Form2.selectedBrandCost + Form3.tees + Form3.shoes + Form3.gloves + Form3.none + Form3.buggy + Form3.bag + Form3.balls)
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hello, this is Golf Bonanza. As a note, when you put quantity, the quantity of your extras will also be multipled. What this means is that if you had, for example, a Titlelist Golf Set, and also got some Golf Shoes, if you put the quantity as 2, then you will get two of the Titleist Set AS WELL as Two Shoes. Also keep in mind, clicked the discount is optional and if size is not clicked, it will be automatically set to medium and if orientation is also not clicked, it will be set to right.")
    End Sub

    Private Sub quantscroll_Scroll(sender As Object, e As ScrollEventArgs) Handles quantscroll.Scroll
        Dim quantity As Integer = quantscroll.Value

        txtQuantity.Text = quantity

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub ExtrasForm_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles radioMens.CheckedChanged
        If radioMens.Checked = True Then
            discount = 1
        Else
            discount = 1
        End If
    End Sub

    Private Sub radioWomans_CheckedChanged(sender As Object, e As EventArgs) Handles radioWomans.CheckedChanged
        If radioWomans.Checked = True Then
            discount = 0.95
        Else
            discount = 1
        End If
    End Sub

    Private Sub radioSenior_CheckedChanged(sender As Object, e As EventArgs) Handles radioSenior.CheckedChanged
        If radioSenior.Checked = True Then
            discount = 0.85
        Else
            discount = 1
        End If
    End Sub

    Private Sub radioStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radioStudent.CheckedChanged
        If radioStudent.Checked = True Then
            discount = 0.8
        Else
            discount = 1
        End If
    End Sub
End Class
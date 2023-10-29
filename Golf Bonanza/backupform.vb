Imports System.IO

Public Class backupform
    Public costcalcnew As Single
    Dim cost, extras, sizecost, howmany As Single
    Dim bag, balls, buggy, tees, shoes, gloves As Single
    Sub costcalc()
        extras = bag + balls + buggy + tees + shoes + gloves
        cost = (sizecost + extras) * howmany
        txtCost.Text = FormatCurrency(cost)
    End Sub
    Private Sub chkTees_CheckedChanged(sender As Object, e As EventArgs) Handles chkTees.CheckedChanged
        If chkTees.Checked = True Then
            tees = 11
        Else
            bag = 0
        End If
        costcalc()
    End Sub

    Private Sub chkShoes_CheckedChanged(sender As Object, e As EventArgs) Handles chkShoes.CheckedChanged
        If chkShoes.Checked = True Then
            shoes = 149
        Else
            shoes = 0
        End If
        costcalc()
    End Sub

    Private Sub chkGloves_CheckedChanged(sender As Object, e As EventArgs) Handles chkGloves.CheckedChanged
        If chkShoes.Checked = True Then
            gloves = 23
        Else
            gloves = 0
        End If
        costcalc()
        costcalc()
    End Sub

    Private Sub quantscroll_Scroll(sender As Object, e As ScrollEventArgs) Handles quantscroll.Scroll
        txtQuantity.Text = quantscroll.Value
        howmany = quantscroll.Value
        costcalc()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Hello, customer. You have arrived at the alternate backup form, considering the normal software does not work. Keep in mind, this alternative backup section cannot preform calculations as precise and may produce some errors if the user decides to switch the brand afterwards. Hence, it is best practice to find out what you like first, then pick it out. Have a good day!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            sizecost = 2599.95
        Else
            sizecost = 0
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            sizecost = 2349.5
        Else
            sizecost = 0
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            sizecost = 1989.45
        Else
            sizecost = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub chkBuggy_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuggy.CheckedChanged
        If chkBuggy.Checked = True Then
            buggy = 190
        Else
            buggy = 0
        End If
        costcalc()
    End Sub

    Private Sub chkBalls_CheckedChanged(sender As Object, e As EventArgs) Handles chkBalls.CheckedChanged
        If chkBalls.Checked = True Then
            balls = 45
        Else
            balls = 0
        End If
        costcalc()
    End Sub


    Private Sub chkBag_CheckedChanged(sender As Object, e As EventArgs) Handles chkBag.CheckedChanged
        If chkBag.Checked = True Then
            bag = 325
        Else
            bag = 0
        End If
        costcalc()
    End Sub
End Class
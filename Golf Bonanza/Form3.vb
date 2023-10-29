Public Class Form3
    Public bag, balls, buggy, tees, shoes, gloves, none As Single
    Public extras = bag + balls + buggy + tees + shoes + gloves + none

    Private Sub GolfTees_CheckedChanged(sender As Object, e As EventArgs) Handles GolfTees.CheckedChanged
        If GolfTees.Checked = True Then
            tees = 11
        Else
            tees = 0
        End If
    End Sub

    Private Sub GolfShoes_CheckedChanged(sender As Object, e As EventArgs) Handles GolfShoes.CheckedChanged
        If GolfShoes.Checked = True Then
            shoes = 149
        Else
            shoes = 0
        End If
    End Sub

    Private Sub GolfGloves_CheckedChanged(sender As Object, e As EventArgs) Handles GolfGloves.CheckedChanged
        If GolfGloves.Checked = True Then
            gloves = 149
        Else
            gloves = 0
        End If
    End Sub

    Private Sub NoneSelected_CheckedChanged(sender As Object, e As EventArgs) Handles NoneSelected.CheckedChanged
        If NoneSelected.Checked = True Then
            none = 0
        Else
            none = 0
        End If
    End Sub

    Private Sub txtOutform3SAMPLE_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GolfBuggy_CheckedChanged(sender As Object, e As EventArgs) Handles GolfBuggy.CheckedChanged
        If GolfBuggy.Checked = True Then
            buggy = 190
        Else
            buggy = 0
        End If

    End Sub

    Private Sub GolfBag_CheckedChanged(sender As Object, e As EventArgs) Handles GolfBag.CheckedChanged
        If GolfBag.Checked = True Then
            bag = 325
        Else
            bag = 0
        End If

    End Sub
    Private Sub GolfBalls_CheckedChanged(sender As Object, e As EventArgs) Handles GolfBalls.CheckedChanged
        If GolfBalls.Checked = True Then
            balls = 45
        Else
            balls = 0
        End If

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ExtrasForm_4.Show()
    End Sub


End Class

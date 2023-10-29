Imports System.Security.Policy
Imports System.Windows

Public Class Form2

    Public selectedBrandCost As Single
    Public selectedBrand As String
    Public costv1 As Single = selectedBrandCost
    'Selected brand cost = Costv1

    Private Sub btnTaylormade_Click(sender As Object, e As EventArgs) Handles btnTaylormade.Click
        selectedBrand = "Taylormade"
        selectedBrandCost = 2599.95
        Form3.Show()
        Me.Hide()
        Form1.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCallaway_Click(sender As Object, e As EventArgs) Handles btnCallaway.Click
        selectedBrand = "Callaway"
        selectedBrandCost = 2349.5
        Form3.Show()
        Form1.Hide()
        Me.Hide()
    End Sub

    Private Sub btnTitleist_Click(sender As Object, e As EventArgs) Handles btnTitleist.Click
        selectedBrand = "Titleist"
        selectedBrandCost = 1989.45
        Form3.Show()
        Form1.Hide()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
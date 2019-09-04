''Program: Classic Snake
'Authors: Kyle Colquitt and Nicholas Graves
'Date: April 15th 2018
'Description: A classic game of snake in which there is a playing field and a snake and mouse object. The snake must grab each mouse as it comes up on screen. Each mouse will increase its length.
'The snake must never run into itself or hit the boundaries of the playing field or it will be game over. A Score will be tallied for each mouse the user collects.
Public Class frmStart

    'brings up the game form object while clsoing the start form object
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim SecondForm As New frmSnake
        SecondForm.Show()
        Me.Hide()

    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
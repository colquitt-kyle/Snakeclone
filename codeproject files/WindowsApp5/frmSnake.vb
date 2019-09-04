'Program: Classic Snake
'Authors: Kyle Colquitt and Nicholas Graves
'Date: April 15th 2018
'Description: A classic game of snake in which there is a playing field and a snake and mouse object. The snake must grab each mouse as it comes up on screen. Each mouse will increase its length.
'The snake must never run into itself or hit the boundaries of the playing field or it will be game over. A Score will be tallied for each mouse the user collects.


Public Class frmSnake
    'init variables

    Dim firstForm As New frmStart

    Dim score As Integer = 0
    Dim strScore As String

    'within this region contains the code essential to creating the snake object
#Region "snake"

    'init variables
    Dim snakeObject(500) As PictureBox
    Dim snakeLength As Integer = -1
    Dim random As New Random
    'init movement positions
    Dim lRMove As Integer = 0
    Dim uDMove As Integer = 0




    'this codde creates the snake head with a length of one and places it randomly on the picture box object at the start of the game
    Private Sub Head()
        snakeLength += 1
        snakeObject(snakeLength) = New PictureBox
        With snakeObject(snakeLength)
            .Height = 10
            .Width = 10
            .BackColor = Color.White
            .Top = (pbField.Top + pbField.Bottom) / 2
            .Left = (pbField.Left + pbField.Right) / 2
        End With
        'next bit of code gives the snake object controls within the form and also puts the snake in front of the picture box arena
        Me.Controls.Add(snakeObject(snakeLength))
        snakeObject(snakeLength).BringToFront()

    End Sub

    'sets up a from even for key presses so that the user can move the snake moves snake increments of 10 for simplicity
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        tmSnakeMove.Start()

        Select Case e.KeyChar
            Case "a"
                lRMove = -10
                uDMove = 0
            Case "d"
                lRMove = 10
                uDMove = 0
            Case "w"
                uDMove = -10
                lRMove = 0
            Case "s"
                uDMove = 10
                lRMove = 0
        End Select
    End Sub

    'this moves the snake when the user has pressed a key and will keep the snake moving in the last direction that was pressed based on a timer

    Private Sub tmSnakeMove_Tick(sender As Object, e As EventArgs) Handles tmSnakeMove.Tick

        'this lets the added on length of the snake follow behind the head of the snake by making sure each new piece of the snake is 1 position behind the other in the array
        For i = snakeLength To 1 Step -1
            snakeObject(i).Top = snakeObject(i - 1).Top
            snakeObject(i).Left = snakeObject(i - 1).Left
        Next

        'each timer tick will move the snake in the last key pressed direction
        snakeObject(0).Top += uDMove
        snakeObject(0).Left += lRMove

        'every timer tick will check to see if it is outside of the picture box
        wallCollide()
        mouseCollide()
        snakeCollide()
    End Sub

    'this method increases the snakes length whenever he picks up a "mouse" and adds the new length to the snake object at the end of the "snake head" everything is kept at size 10 for simplicity
    Private Sub increaseSnakeLength()
        snakeLength += 1
        snakeObject(snakeLength) = New PictureBox
        With snakeObject(snakeLength)
            .Height = 10
            .Width = 10
            .BackColor = Color.White
            .Top = snakeObject(snakeLength - 1).Top
            .Left = snakeObject(snakeLength - 1).Left + 10


        End With
        'gives controls to the snake object
        Me.Controls.Add(snakeObject(snakeLength))
        snakeObject(snakeLength).BringToFront()


    End Sub
#End Region

    'Contains information regarding the collision of the game
#Region "Collision"
    'This will create collission if the snake runs out of bounds the game will stop and a message box will say you lose. This basically checks to see if the snake object is outside of the picture box
    Private Sub wallCollide()

        If snakeObject(0).Left < pbField.Left Then
            tmSnakeMove.Stop()
            MsgBox("Game Over! Your Score is: " & score)

            'displays the game over would you like to play again message and also displays yes and no buttons
            lblGameOver.Visible = True
            btnYes.Visible = True
            btnNo.Visible = True
        End If

        If snakeObject(0).Right > pbField.Right Then
            tmSnakeMove.Stop()
            MsgBox("Game Over! Your Score is: " & score)

            'displays the game over would you like to play again message and also displays yes and no buttons
            lblGameOver.Visible = True
            btnYes.Visible = True
            btnNo.Visible = True
        End If

        If snakeObject(0).Top < pbField.Top Then
            tmSnakeMove.Stop()
            MsgBox("Game Over! Your Score is: " & score)

            'displays the game over would you like to play again message and also displays yes and no buttons
            lblGameOver.Visible = True
            btnYes.Visible = True
            btnNo.Visible = True
        End If
        If snakeObject(0).Bottom > pbField.Bottom Then
            tmSnakeMove.Stop()
            MsgBox("Game Over! Your Score is: " & score)

            'displays the game over would you like to play again message and also displays yes and no buttons
            lblGameOver.Visible = True
            btnYes.Visible = True
            btnNo.Visible = True
        End If




    End Sub

    'this method checks to make sure the snake hasnt collided with itself. If it has a message box will appear stating its game over and will also stop the in game timer
    Private Sub snakeCollide()
        For i = 3 To snakeLength

            If snakeObject(0).Bounds.IntersectsWith(snakeObject(i).Bounds) Then
                tmSnakeMove.Stop()

                MsgBox("Game Over! Your Score is: " & score)

                'displays the game over would you like to play again message and also displays yes and no buttons
                lblGameOver.Visible = True
                btnYes.Visible = True
                btnNo.Visible = True
            End If

        Next
    End Sub

    'if snake head touches the mouse object then the snake will increase in size and a new mouse object will be placed randomly on the field
    Private Sub mouseCollide()

        If snakeObject(0).Bounds.IntersectsWith(mouse.Bounds) Then
            increaseSnakeLength()

            mouse.Top = random.Next(pbField.Top, pbField.Bottom - 10)
            mouse.Left = random.Next(pbField.Left, pbField.Right - 10)

            'everytime a mouse is collected the score will increase
            score += 15
            strScore = score.ToString()
            lblScore.Text = strScore

        End If
    End Sub
#End Region

    'Contains information and methods regarding the mouse object
#Region "Mouse"
    Dim mouse As PictureBox
    ' creates a mouse object and places it randomly on the playing field it is the same size as the snake head for simplicity 
    Private Sub mouseObject()
        mouse = New PictureBox
        With mouse
            .Width = 10
            .Height = 10
            .BackColor = Color.Teal

            .Top = random.Next(pbField.Top, pbField.Bottom - 10)
            .Left = random.Next(pbField.Left, pbField.Right - 10)
        End With

        Me.Controls.Add(mouse)
        mouse.BringToFront()

    End Sub
#End Region

    Private Sub frmSnake_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'creates the head
        Head()

        'create mouse
        mouseObject()

        'starts the timer


    End Sub

    'Restarts the game from the beggining resets all positions and snake objects and mouse clear all controls and re initializes controls, clears current snake array and sets length back to -1 also 
    'sets score back to 0
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Controls.Clear()
        InitializeComponent()

        For i = 1 To snakeLength
            Me.Controls.Remove(snakeObject(i))
            Me.Controls.Remove(mouse)
        Next


        Array.Clear(snakeObject, 0, snakeObject.Length)
        snakeLength = -1
        score = 0
        frmSnake_Load(e, e)
    End Sub

    'Closes the game
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Close()
        frmStart.Close()
    End Sub
End Class

Public Class Form1

    Dim Walls(1000) As PictureBox
    Dim snake(100) As PictureBox
    Dim NoOfWalls As Integer = 0
    Dim length As Integer = -1
    Dim left_right As Integer = 0
    Dim up_down As Integer = 0
    Dim ass_up_down As Integer = 0
    Dim ass_left_right As Integer = 0
    Dim eat As PictureBox
    Dim rand As New Random
    Dim Points As Integer = 100
    Dim Score As Integer = 0
    Dim ScoreNew As Integer
    Dim GameStarted As Boolean = False
    Dim nameInput As String
    Dim fullInput As String
    Dim clrScr As String = " "
    Dim fileRead As String
    Dim SettingsVis As Integer = 0
    Dim NewSnakeSpdInt As Integer
    Dim NewGameSpdInt As Integer
    Dim NewGameTimerInt As Integer
    Dim Settings_Saved As Integer = 0
    Dim SpdInc As Integer = 5
    Dim n As Integer
    Dim X_Array As Integer
    Dim Y_Array As Integer
    Dim X_Food As Integer
    Dim Y_Food As Integer
    Dim snake_hit_wall As Boolean
    Dim Apples_Eaten As Integer
    Dim Apples_Needed As Integer
    Dim Apples_Left As Integer
    Dim Level_Number As Integer = 0
    Dim Lives As Integer
    Dim Y_Wall_No As Integer
    Dim No_Apples As Integer
    Dim Difficulty As Integer
    Dim stpw As Stopwatch

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GameStarted = False

        Score = 0
        ScoreNew = 0

        snake_hit_wall = False

        Level_Number = 5

        Calculations()
        Start()

        Lives = 3

        Snake_1.Visible = True
        Snake_2.Visible = True
        Snake_3.Visible = True

        lblLevelNo.Text = Level_Number

        Difficulty = 1
        Points = 100
        txtSnakeSpd.Text = "5"
        No_Apples = 0
        txtSnakeSpd.Text = SpdInc
        txtGametimeSpd.Text = GameTimer.Interval
        txtSpdTime.Text = SpdTimer.Interval
        Settings()

    End Sub

    Sub Calculations()

        X_Array = Panel1.Width / 20
        Y_Array = Panel1.Height / 20

        X_Array += 1
        Y_Array += 3


    End Sub

    Sub Start()

        GameTimer.Start()

        GameStarted = False

        NoOfWalls = -1

        Apples_Eaten = 0

        Head()
        Snake_length()
        Snake_length()
        Snake_length()
        Snake_length()
        Snake_length()
        Snake_length()
        Snake_length()
        Snake_Eat()

        SnakeSpd.Interval = 200

        If Level_Number = 1 Then
            level_1()
        ElseIf Level_Number = 2 Then
            level_2()
        ElseIf Level_Number = 3 Then
            level_3()
        ElseIf Level_Number = 4 Then
            level_4()
        ElseIf Level_Number = 5 Then
            level_5()
        ElseIf Level_Number = 6 Then
            level_6()
        End If

        up_down = 0
        left_right = -20

        stpw = Stopwatch.StartNew

        snake(0).BackgroundImage = SnakeGame_VB.My.Resources.SnakeHeadLeft


    End Sub

    Sub Head()

        length += 1
        snake(length) = New PictureBox
        With snake(length)
            .Width = 20
            .Height = 20
            .BackColor = Color.White
            .Left = (Panel1.Width - snake(length).Width) / 2
            .Top = (Panel1.Height + snake(length).Height) / 2
            .BackgroundImage = SnakeGame_VB.My.Resources.SnakeHead
        End With
        Me.Controls.Add(snake(length))
        snake(length).BringToFront()

    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        Pass_Through_Wall()
        Collision_with_eat()
        lblScore.Text = ScoreNew
        lblLevelNo.Text = Level_Number

        If Apples_Eaten = Apples_Needed Then
            If Level_Number = 6 Then
                Level_Number = 1
                Stop_Game()
                MsgBox("You have completed this level")
                Reset_Game()
                GameStarted = False
            Else
                Stop_Game()
                Score += ScoreNew
                MsgBox("You have completed this level")
                Level_Number += 1
                Reset_Game()
                GameStarted = False
            End If
        End If

        If Lives = 3 Then
            Snake_1.Visible = True
            Snake_2.Visible = True
            Snake_3.Visible = True
        ElseIf Lives = 2 Then
            Snake_1.Visible = True
            Snake_2.Visible = True
            Snake_3.Visible = False
        ElseIf Lives = 1 Then
            Snake_1.Visible = True
            Snake_2.Visible = False
            Snake_3.Visible = False
        End If

        Apples_Left = Apples_Needed - Apples_Eaten

        lblApplesNeeded.Text = Apples_Left

        leftsnakeAssTmr.Interval = (SnakeSpd.Interval * length)
        rightsnakeAssTmr.Interval = (SnakeSpd.Interval * length)
        downsnakeAssTmr.Interval = (SnakeSpd.Interval * length)
        upsnakeAssTmr.Interval = (SnakeSpd.Interval * length)

        Label14.Text = leftsnakeAssTmr.Interval

        If ass_up_down > 0 Then
            Label15.Text = "Down"
        ElseIf ass_up_down < 0 Then
            Label15.Text = "Up"
        ElseIf ass_left_right > 0 Then
            Label15.Text = "Right"
        ElseIf ass_left_right < 0 Then
            Label15.Text = "Left"
        End If


    End Sub

    Sub Collision_with_eat()

        X_Food = rand.Next(1, X_Array)
        Y_Food = rand.Next(3, Y_Array)

        If snake(0).Bounds.IntersectsWith(eat.Bounds) Then

            If Difficulty = 0 Then
                Snake_length()
            ElseIf Difficulty = 1 Then
                Snake_length()
                Snake_length()
            ElseIf Difficulty = 2 Then
                Snake_length()
                Snake_length()
                Snake_length()
            End If

            eat.Top = Y_Food * 20
            eat.Left = X_Food * 20.0
            ScoreNew += Points
            SnakeSpd.Interval -= SpdInc
            Apples_Eaten += 1
        End If

        For i = 0 To NoOfWalls
            If eat.Bounds.IntersectsWith(Walls(i).Bounds) Then
                eat.Top = Y_Food * 20
                eat.Left = X_Food * 20
            End If
        Next

        For i = 1 To length
            If eat.Bounds.IntersectsWith(snake(i).Bounds) Then
                eat.Top = Y_Food * 20
                eat.Left = X_Food * 20
            End If
        Next

        For i = 0 To NoOfWalls
            If snake(0).Bounds.IntersectsWith(Walls(i).Bounds) Then
                snake_hit_wall = True
            End If
        Next

        For i = 1 To length
            If snake(0).Bounds.IntersectsWith(snake(i).Bounds) Or snake_hit_wall = True Then
                Stop_Game()
                Lives -= 1

                If Lives < 1 Then

                    Snake_1.Visible = False

                    If MsgBox("Game Over! Would you like to Record your Score!!", vbQuestion + vbYesNo) = vbYes Then
                        WriteScores(nameInput, fullInput)
                    End If

                    If MsgBox("Game Over!! Would you like to Retry?", vbQuestion + vbYesNo) = vbYes Then
                        GameStarted = False
                        Level_Number = 1
                        Lives = 3
                        ScoreNew = 0
                        Score = 0
                        Reset_Game()
                    Else
                        Application.Exit()
                    End If

                Else

                    MsgBox("You have lost 1 life!!!")
                    MsgBox("You now have " & Lives & " Lives Remaining!")
                    ScoreNew = Score
                    Reset_Game()
                    GameStarted = False

                End If

            End If
        Next


    End Sub

    Sub Stop_Game()
        GameTimer.Stop()
        SnakeSpd.Stop()
        SpdTimer.Stop()
        leftsnakeAssTmr.Stop()
    End Sub

    Sub WriteScores(ByVal nameInput As String, ByVal fullInput As String)
        nameInput = InputBox("Please enter your name below!")
        Dim ScoreStr As String
        ScoreStr = Convert.ToString(Score)
        fullInput = " - Your Score was: " + ScoreStr
        Dim filewriter As New System.IO.StreamWriter("\Games\Snake Game VB\Scores\Snake Scores.txt", True)
        filewriter.WriteLine(nameInput + fullInput & ", ")
        filewriter.Close()
    End Sub

    Sub Pass_Through_Wall()
        If snake(0).Left < Panel1.Left Then
            snake_hit_wall = True

            'snake(0).Left = Panel1.Width - snake(0).Width
        End If
        If snake(0).Right > Panel1.Right Then
            snake_hit_wall = True

            'snake(0).Left = Panel1.Left
        End If
        If snake(0).Top < Panel1.Top Then
            snake_hit_wall = True

            'snake(0).Top = Panel1.Bottom - snake(0).Height
        End If
        If snake(0).Bottom > Panel1.Bottom Then
            snake_hit_wall = True

            'snake(0).Top = Panel1.Top
        End If
    End Sub

    Sub Snake_Eat()

        X_Food = rand.Next(1, X_Array)
        Y_Food = rand.Next(3, Y_Array)

        eat = New PictureBox
        With eat
            .Width = 20
            .Height = 20
            .BackColor = Color.Red
            .Top = Y_Food * 20
            .Left = X_Food * 20
            .BackgroundImage = SnakeGame_VB.My.Resources.Apple
        End With
        Me.Controls.Add(eat)
        eat.BringToFront()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If stpw.ElapsedMilliseconds > (SnakeSpd.Interval - 50) Then
            Select Case e.KeyCode
                Case Keys.W
                    If up_down = 20 Then
                        up_down = 20
                        left_right = 0
                    Else
                        up_down = -20
                        left_right = 0
                        upsnakeAssTmr.Start()
                        stpw = Stopwatch.StartNew
                    End If
                Case Keys.S
                    If up_down = -20 Then
                        up_down = -20
                        left_right = 0
                    Else
                        up_down = 20
                        left_right = 0
                        downsnakeAssTmr.Start()
                        stpw = Stopwatch.StartNew
                    End If
                Case Keys.D
                    If left_right = -20 Then
                        up_down = 0
                        left_right = -20
                    Else
                        up_down = 0
                        left_right = 20
                        rightsnakeAssTmr.Start()
                        stpw = Stopwatch.StartNew
                    End If
                Case Keys.A
                    If left_right = 20 Then
                        up_down = 0
                        left_right = 20
                    Else
                        up_down = 0
                        left_right = -20
                        leftsnakeAssTmr.Start()
                        stpw = Stopwatch.StartNew
                    End If
                Case Keys.R
                    If GameStarted = False Then
                        up_down = 0
                        left_right = -20
                        GameTimer.Start()
                        SnakeSpd.Start()
                        SpdTimer.Start()
                        leftsnakeAssTmr.Start()
                        stpw = Stopwatch.StartNew
                    End If
                    GameStarted = True
            End Select
        End If

    End Sub

    Sub Snake_length()
        length += 1
        snake(length) = New PictureBox
        With snake(length)
            .Width = 20
            .Height = 20
            .BackColor = Color.Green
            .BackgroundImage = SnakeGame_VB.My.Resources.SnakeBody
            If GameStarted = False Then
                .Top = snake(length - 1).Top
                .Left = snake(length - 1).Left + 20
            Else
                If ass_left_right > 0 Then
                    .Top = snake(length - 1).Top
                    .Left = snake(length - 1).Left - 20
                End If
                If ass_left_right < 0 Then
                    .Top = snake(length - 1).Top
                    .Left = snake(length - 1).Left + 20
                End If
                If ass_up_down < 0 Then
                    .Top = snake(length - 1).Top + 20
                    .Left = snake(length - 1).Left
                End If
                If ass_up_down > 0 Then
                    .Top = snake(length - 1).Top - 20
                    .Left = snake(length - 1).Left
                End If
            End If


        End With
        Me.Controls.Add(snake(length))
        snake(length).BringToFront()
    End Sub

    Sub level_1()

        Apples_Needed = 5 + (No_Apples)

        For i = 0 To 61

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Orange
                .Top = (Panel1.Top - 20)
                .Left = Panel1.Left + (i * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next



        For i = 62 To 92

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Orange
                .Top = Panel1.Top + ((i - 62) * 20)
                .Left = Panel1.Right
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next


        For i = 93 To 154

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Orange
                .Top = Panel1.Bottom
                .Left = Panel1.Right - ((i - 93) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 155 To 187

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Orange
                .Top = Panel1.Bottom - ((i - 155) * 20)
                .Left = Panel1.Left - 20
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

    End Sub

    Sub level_2()

        Apples_Needed = 10 + No_Apples

        For i = 0 To 61

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Blue
                .Top = (Panel1.Top - 20)
                .Left = Panel1.Left + (i * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 62 To 92

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Blue
                .Top = Panel1.Top + ((i - 62) * 20)
                .Left = Panel1.Right
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 93 To 154

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Blue
                .Top = Panel1.Bottom
                .Left = Panel1.Right - ((i - 93) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 155 To 187

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Blue
                .Top = Panel1.Bottom - ((i - 155) * 20)
                .Left = Panel1.Left - 20
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 188 To 229

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Blue
                .Top = Panel1.Top + 200
                .Left = Panel1.Left + ((i - 188) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 230 To 271

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Blue
                .Top = Panel1.Bottom - 200
                .Left = Panel1.Right - ((i - 230) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

    End Sub

    Sub level_3()

        Apples_Needed = 15 + No_Apples

        For i = 0 To 61

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Purple
                .Top = (Panel1.Top - 20)
                .Left = Panel1.Left + (i * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 62 To 92

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Purple
                .Top = Panel1.Top + ((i - 62) * 20)
                .Left = Panel1.Right
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 93 To 154

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Purple

                .Top = Panel1.Bottom
                .Left = Panel1.Right - ((i - 93) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 155 To 187

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Purple
                .Top = Panel1.Bottom - ((i - 155) * 20)
                .Left = Panel1.Left - 20
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 188 To 204

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Purple
                .Top = Panel1.Top + ((i - 188) * 20)
                .Left = Panel1.Left + 400
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 205 To 221

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Purple
                .Top = Panel1.Bottom - ((i - 205) * 20)
                .Left = Panel1.Right - 400
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

    End Sub

    Sub level_4()

        Apples_Needed = 15 + No_Apples * 2

        '1
        For i = 0 To 61

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.DeepPink
                .Top = (Panel1.Top - 20)
                .Left = Panel1.Left + (i * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '2
        For i = 62 To 92

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.DeepPink
                .Top = Panel1.Top + ((i - 62) * 20)
                .Left = Panel1.Right
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '3
        For i = 93 To 154

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.DeepPink
                .Top = Panel1.Bottom
                .Left = Panel1.Right - ((i - 93) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '4
        For i = 155 To 187

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.DeepPink
                .Top = Panel1.Bottom - ((i - 155) * 20)
                .Left = Panel1.Left - 20
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '5
        For i = 188 To 217

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.DeepPink
                .Top = Panel1.Top + 160
                .Left = Panel1.Left + (((i - 188) * 20) + 300)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '6
        For i = 218 To 247

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.DeepPink
                .Top = Panel1.Bottom - 160
                .Left = Panel1.Left + (((i - 218) * 20) + 300)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 248 To 263

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.DeepPink
                .Top = Panel1.Top + (((i - 248) * 20) + 160)
                .Left = Panel1.Left + ((30 * 20) + 300)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

    End Sub

    Sub level_5()

        Apples_Needed = 20 + No_Apples * 2

        '1
        For i = 0 To 61

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = (Panel1.Top - 20)
                .Left = Panel1.Left + (i * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '2
        For i = 62 To 92

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + ((i - 62) * 20)
                .Left = Panel1.Right
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '3
        For i = 93 To 154

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom
                .Left = Panel1.Right - ((i - 93) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '4
        For i = 155 To 187

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom - ((i - 155) * 20)
                .Left = Panel1.Left - 20
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '5
        For i = 188 To 208

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + ((i - 188) * 20)
                .Left = Panel1.Left + (13 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '7
        For i = 209 To 229

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + ((i - 209) * 20)
                .Left = Panel1.Left + (14 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '8
        For i = 230 To 250

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + ((i - 230) * 20)
                .Left = Panel1.Left + (15 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '9
        For i = 251 To 259

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (20 * 20)
                .Left = Panel1.Left - ((i - 251) * 20) + (12 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '10
        For i = 260 To 268

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (19 * 20)
                .Left = Panel1.Left - ((i - 260) * 20) + (12 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next
        '11
        For i = 269 To 277

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (18 * 20)
                .Left = Panel1.Left - ((i - 269) * 20) + (12 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 278 To 298

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom - ((i - 278) * 20) - 20
                .Left = Panel1.Left + (23 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 299 To 319

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom - ((i - 299) * 20) - 20
                .Left = Panel1.Left + (24 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 320 To 340

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom - ((i - 320) * 20) - 20
                .Left = Panel1.Left + (25 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 341 To 349

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (10 * 20)
                .Left = Panel1.Left - ((i - 341) * 20) + (34 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 350 To 358

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (11 * 20)
                .Left = Panel1.Left - ((i - 350) * 20) + (34 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 359 To 367

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (12 * 20)
                .Left = Panel1.Left - ((i - 359) * 20) + (34 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 368 To 388

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + ((i - 368) * 20)
                .Left = Panel1.Left + (42 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 389 To 409

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + ((i - 389) * 20)
                .Left = Panel1.Left + (43 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 410 To 430

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + ((i - 410) * 20)
                .Left = Panel1.Left + (44 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 431 To 439

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (20 * 20)
                .Left = Panel1.Left - ((i - 431) * 20) + (41 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 440 To 448

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (19 * 20)
                .Left = Panel1.Left - ((i - 440) * 20) + (41 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 449 To 457

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Top + (18 * 20)
                .Left = Panel1.Left - ((i - 449) * 20) + (41 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 458 To 478

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom - ((i - 458) * 20) - 20
                .Left = Panel1.Left + (58 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 479 To 499

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom - ((i - 479) * 20) - 20
                .Left = Panel1.Left + (59 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 500 To 520

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Yellow
                .Top = Panel1.Bottom - ((i - 500) * 20) - 20
                .Left = Panel1.Left + (60 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

    End Sub

    Sub level_6()

        Apples_Needed = 15 + No_Apples * 2

        For i = 0 To 61

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = (Panel1.Top - 20)
                .Left = Panel1.Left + (i * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next



        For i = 62 To 92

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Top + ((i - 62) * 20)
                .Left = Panel1.Right
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next


        For i = 93 To 154

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Bottom
                .Left = Panel1.Right - ((i - 93) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        For i = 155 To 187

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Bottom - ((i - 155) * 20)
                .Left = Panel1.Left - 20
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
        Next

        Y_Wall_No = 0

        For i = 188 To 203

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Top + ((i - 188) * 20) + ((Y_Wall_No) * 20)
                .Left = Panel1.Left + (15 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
            Y_Wall_No += 1
        Next

        Y_Wall_No = 0

        For i = 204 To 219

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Top + ((i - 204) * 20) + ((Y_Wall_No) * 20)
                .Left = Panel1.Left + (30 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
            Y_Wall_No += 1
        Next

        Y_Wall_No = 0

        For i = 220 To 235

            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Top + ((i - 220) * 20) + ((Y_Wall_No) * 20)
                .Left = Panel1.Left + (45 * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
            Y_Wall_No += 1
        Next

        Y_Wall_No = 0

        For i = 236 To 266
            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Top + (10 * 20)
                .Left = Panel1.Left + ((i - 236) * 20) + ((Y_Wall_No) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
            Y_Wall_No += 1
        Next

        Y_Wall_No = 0

        For i = 267 To 297
            Walls(i) = New PictureBox
            With Walls(i)
                .Width = 20
                .Height = 20
                .BackColor = Color.Cyan
                .Top = Panel1.Top + (20 * 20)
                .Left = Panel1.Left + ((i - 267) * 20) + ((Y_Wall_No) * 20)
            End With
            Me.Controls.Add(Walls(i))
            Walls(i).BringToFront()
            NoOfWalls += 1
            Y_Wall_No += 1
        Next

    End Sub

    Private Sub scoreBtn_Click(sender As Object, e As EventArgs) Handles scoreBtn.Click
        ReadScores()
        MsgBox(fileRead)
    End Sub

    Sub ReadScores()
        Dim filereader As New System.IO.StreamReader("\Games\Snake Game VB\Scores\Snake Scores.txt", True)
        fileRead = filereader.ReadToEnd()
        filereader.Close()

        ' filelist = fileRead.Split()
    End Sub

    Private Sub SnakeSpd_Tick(sender As Object, e As EventArgs) Handles SnakeSpd.Tick

        For i = length To 1 Step -1
            snake(i).Top = snake(i - 1).Top
            snake(i).Left = snake(i - 1).Left
        Next

        snake(0).Top += up_down
        snake(0).Left += left_right

        If SnakeSpd.Interval < 30 Then
            SnakeSpd.Interval = 30
            SpdTimer.Stop()
        End If

        If up_down > 0 Then
            snake(0).BackgroundImage = SnakeGame_VB.My.Resources.SnakeHeadDown
        ElseIf up_down < 0 Then
            snake(0).BackgroundImage = SnakeGame_VB.My.Resources.SnakeHead
        ElseIf left_right > 0 Then
            snake(0).BackgroundImage = SnakeGame_VB.My.Resources.SnakeHeadRight
        ElseIf left_right < 0 Then
            snake(0).BackgroundImage = SnakeGame_VB.My.Resources.SnakeHeadLeft
        End If

    End Sub

    Private Sub SpdTimer_Tick(sender As Object, e As EventArgs) Handles SpdTimer.Tick

        'SnakeSpd.Interval += -10

    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click

        If SettingsVis = 0 Then
            SettingsVis = 1
        ElseIf SettingsVis = 1 Then
            SettingsVis = 0
        End If

        Settings_Visible()



        txtSnakeSpd.Text = SpdInc
        txtGametimeSpd.Text = GameTimer.Interval
        txtSpdTime.Text = SpdTimer.Interval


    End Sub

    Sub Settings()

        If txtSnakeSpd.Text > 10 Then
            MsgBox("Sorry that Number is too High!")
            txtSnakeSpd.Text = SpdInc
        Else
            SpdInc = txtSnakeSpd.Text
        End If

        txtSnakeSpd.Text = SpdInc
        SpdTimer.Interval = txtSpdTime.Text
        GameTimer.Interval = txtGametimeSpd.Text
        lblPoints.Text = Points
        If Difficulty = 0 Then
            lblIncLen.Text = 1
            lblMode.Text = "Easy"
        ElseIf Difficulty = 1 Then
            lblIncLen.Text = 2
            lblMode.Text = "Normal"
        ElseIf Difficulty = 2 Then
            lblIncLen.Text = 3
            lblMode.Text = "Hard"
        End If




    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If SettingsVis = 1 Then
            Settings_Saved = 1
            Settings()
        End If

    End Sub

    Private Sub clrScrBtn_Click(sender As Object, e As EventArgs) Handles clrScrBtn.Click
        ClearScores(clrScr)
    End Sub

    Sub Reset_Game()
        For i = 0 To length
            Me.Controls.Remove(snake(i))
        Next
        For i = 0 To NoOfWalls
            Me.Controls.Remove(Walls(i))
        Next
        Me.Controls.Remove(eat)
        length = -1
        snake_hit_wall = False
        Start()
    End Sub

    Sub ClearScores(ByVal clrScr As String)
        Dim filewriter As New System.IO.StreamWriter("\Games\Snake Game VB\Scores\Snake Scores.txt", False)
        filewriter.WriteLine(clrScr)
        filewriter.Close()
    End Sub

    Private Sub easyBtn_Click(sender As Object, e As EventArgs) Handles easyBtn.Click

        If GameStarted = False And Level_Number = 1 Then
            Difficulty = 0
            Points = 50
            txtSnakeSpd.Text = "3"
            No_Apples = -2
            Settings()
            Reset_Game()
            Settings_Visible()
        End If


    End Sub

    Private Sub normalBtn_Click(sender As Object, e As EventArgs) Handles normalBtn.Click

        If GameStarted = False And Level_Number = 1 Then
            Difficulty = 1
            Points = 100
            txtSnakeSpd.Text = "5"
            No_Apples = 0
            Settings()
            Reset_Game()
            Settings_Visible()
        End If


    End Sub

    Private Sub hardBtn_Click(sender As Object, e As EventArgs) Handles hardBtn.Click

        If GameStarted = False And Level_Number = 1 Then
            Difficulty = 2
            Points = 200
            txtSnakeSpd.Text = "8"
            No_Apples = 3
            Settings()
            Reset_Game()
            Settings_Visible()
        End If



    End Sub

    Private Sub rstBtn_Click(sender As Object, e As EventArgs) Handles rstBtn.Click

        If Lives = 0 Then
            GameStarted = False
            Level_Number = 1
            Lives = 3
            ScoreNew = 0
            Score = 0
        Else
            ScoreNew = 0
            ScoreNew = Score
        End If

        Reset_Game()
        SettingsVis = 0
        Settings_Visible()
    End Sub

    Sub Settings_Visible()
        If SettingsVis = 1 Then
            lblIncLen.Visible = True
            lblPoints.Visible = True
            lblMode.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label16.Visible = True
            Panel2.Visible = True
            Label8.Visible = True
            SaveBtn.Visible = True
            lblGameTimeSpd.Visible = True
            lblSnakeSpd.Visible = True
            lblSpdTime.Visible = True
            txtSpdTime.Visible = True
            txtSnakeSpd.Visible = True
            txtGametimeSpd.Visible = True
            clrScrBtn.Visible = True
            lblControls.Visible = True
            lblR.Visible = True
            lblA.Visible = True
            lblW.Visible = True
            lblD.Visible = True
            lblS.Visible = True
            easyBtn.Visible = True
            normalBtn.Visible = True
            hardBtn.Visible = True
            rstBtn.Visible = True
            For i = 0 To length
                snake(i).Visible = False
            Next
            For i = 188 To NoOfWalls
                Walls(i).Visible = False
            Next
            eat.Visible = False
            Panel2.BringToFront()
            Label8.BringToFront()
            SaveBtn.BringToFront()
            lblSpdTime.BringToFront()
            lblSnakeSpd.BringToFront()
            lblGameTimeSpd.BringToFront()
            txtGametimeSpd.BringToFront()
            txtSnakeSpd.BringToFront()
            txtSpdTime.BringToFront()
            SnakeSpd.Stop()

        Else
            lblIncLen.Visible = False
            lblPoints.Visible = False
            lblMode.Visible = False
            Panel2.Visible = False
            Label8.Visible = False
            SaveBtn.Visible = False
            lblGameTimeSpd.Visible = False
            lblSnakeSpd.Visible = False
            lblSpdTime.Visible = False
            txtSpdTime.Visible = False
            txtSnakeSpd.Visible = False
            txtGametimeSpd.Visible = False
            clrScrBtn.Visible = False
            lblControls.Visible = False
            lblR.Visible = False
            lblA.Visible = False
            lblW.Visible = False
            lblD.Visible = False
            lblS.Visible = False
            easyBtn.Visible = False
            normalBtn.Visible = False
            hardBtn.Visible = False
            rstBtn.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            Label16.Visible = False
            For i = 0 To length
                snake(i).Visible = True
            Next
            For i = 188 To NoOfWalls
                Walls(i).Visible = True
            Next
            eat.Visible = True
            If GameStarted = True Then
                SnakeSpd.Start()
            End If
        End If
    End Sub

    Private Sub leftsnakeAssTmr_Tick(sender As Object, e As EventArgs) Handles leftsnakeAssTmr.Tick

        ass_left_right = -20
        ass_up_down = 0
        leftsnakeAssTmr.Stop()

    End Sub

    Private Sub rightsnakeAssTmr_Tick(sender As Object, e As EventArgs) Handles rightsnakeAssTmr.Tick

        ass_left_right = 20
        ass_up_down = 0
        rightsnakeAssTmr.Stop()

    End Sub

    Private Sub upsnakeAssTmr_Tick(sender As Object, e As EventArgs) Handles upsnakeAssTmr.Tick
        ass_left_right = 0
        ass_up_down = -20
        upsnakeAssTmr.Stop()
    End Sub

    Private Sub downsnakeAssTmr_Tick(sender As Object, e As EventArgs) Handles downsnakeAssTmr.Tick
        ass_left_right = 0
        ass_up_down = 20
        downsnakeAssTmr.Stop()
    End Sub

End Class
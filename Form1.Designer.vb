<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIncLen = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rstBtn = New System.Windows.Forms.Button()
        Me.hardBtn = New System.Windows.Forms.Button()
        Me.normalBtn = New System.Windows.Forms.Button()
        Me.easyBtn = New System.Windows.Forms.Button()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblW = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblControls = New System.Windows.Forms.Label()
        Me.clrScrBtn = New System.Windows.Forms.Button()
        Me.txtSpdTime = New System.Windows.Forms.TextBox()
        Me.txtSnakeSpd = New System.Windows.Forms.TextBox()
        Me.txtGametimeSpd = New System.Windows.Forms.TextBox()
        Me.lblSpdTime = New System.Windows.Forms.Label()
        Me.lblSnakeSpd = New System.Windows.Forms.Label()
        Me.lblGameTimeSpd = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.scoreBtn = New System.Windows.Forms.Button()
        Me.SnakeSpd = New System.Windows.Forms.Timer(Me.components)
        Me.SpdTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblApplesNeeded = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblLevelNo = New System.Windows.Forms.Label()
        Me.leftsnakeAssTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rightsnakeAssTmr = New System.Windows.Forms.Timer(Me.components)
        Me.upsnakeAssTmr = New System.Windows.Forms.Timer(Me.components)
        Me.downsnakeAssTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Snake_3 = New System.Windows.Forms.PictureBox()
        Me.Snake_2 = New System.Windows.Forms.PictureBox()
        Me.Snake_1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Snake_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Snake_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Snake_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(833, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Score:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1220, 620)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.lblMode)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.lblIncLen)
        Me.Panel2.Controls.Add(Me.lblPoints)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.rstBtn)
        Me.Panel2.Controls.Add(Me.hardBtn)
        Me.Panel2.Controls.Add(Me.normalBtn)
        Me.Panel2.Controls.Add(Me.easyBtn)
        Me.Panel2.Controls.Add(Me.lblS)
        Me.Panel2.Controls.Add(Me.lblD)
        Me.Panel2.Controls.Add(Me.lblW)
        Me.Panel2.Controls.Add(Me.lblA)
        Me.Panel2.Controls.Add(Me.lblR)
        Me.Panel2.Controls.Add(Me.lblControls)
        Me.Panel2.Controls.Add(Me.clrScrBtn)
        Me.Panel2.Controls.Add(Me.txtSpdTime)
        Me.Panel2.Controls.Add(Me.txtSnakeSpd)
        Me.Panel2.Controls.Add(Me.txtGametimeSpd)
        Me.Panel2.Controls.Add(Me.lblSpdTime)
        Me.Panel2.Controls.Add(Me.lblSnakeSpd)
        Me.Panel2.Controls.Add(Me.lblGameTimeSpd)
        Me.Panel2.Controls.Add(Me.SaveBtn)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 614)
        Me.Panel2.TabIndex = 6
        Me.Panel2.Visible = False
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(482, 177)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(61, 20)
        Me.lblMode.TabIndex = 38
        Me.lblMode.Text = "Default"
        Me.lblMode.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(280, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 20)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Difficulty:"
        Me.Label16.Visible = False
        '
        'lblIncLen
        '
        Me.lblIncLen.AutoSize = True
        Me.lblIncLen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncLen.Location = New System.Drawing.Point(482, 138)
        Me.lblIncLen.Name = "lblIncLen"
        Me.lblIncLen.Size = New System.Drawing.Size(18, 20)
        Me.lblIncLen.TabIndex = 36
        Me.lblIncLen.Text = "0"
        Me.lblIncLen.Visible = False
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(482, 95)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(18, 20)
        Me.lblPoints.TabIndex = 35
        Me.lblPoints.Text = "0"
        Me.lblPoints.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(280, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(179, 20)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Snake Increase Length:"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(280, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Points:"
        Me.Label12.Visible = False
        '
        'rstBtn
        '
        Me.rstBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rstBtn.Location = New System.Drawing.Point(455, 545)
        Me.rstBtn.Name = "rstBtn"
        Me.rstBtn.Size = New System.Drawing.Size(125, 52)
        Me.rstBtn.TabIndex = 32
        Me.rstBtn.Text = "Restart"
        Me.rstBtn.UseVisualStyleBackColor = True
        Me.rstBtn.UseWaitCursor = True
        Me.rstBtn.Visible = False
        '
        'hardBtn
        '
        Me.hardBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardBtn.Location = New System.Drawing.Point(290, 431)
        Me.hardBtn.Name = "hardBtn"
        Me.hardBtn.Size = New System.Drawing.Size(125, 65)
        Me.hardBtn.TabIndex = 31
        Me.hardBtn.Text = "Hard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Difficulty"
        Me.hardBtn.UseVisualStyleBackColor = True
        Me.hardBtn.UseWaitCursor = True
        Me.hardBtn.Visible = False
        '
        'normalBtn
        '
        Me.normalBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.normalBtn.Location = New System.Drawing.Point(159, 431)
        Me.normalBtn.Name = "normalBtn"
        Me.normalBtn.Size = New System.Drawing.Size(125, 65)
        Me.normalBtn.TabIndex = 30
        Me.normalBtn.Text = "Normal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Difficulty"
        Me.normalBtn.UseVisualStyleBackColor = True
        Me.normalBtn.UseWaitCursor = True
        Me.normalBtn.Visible = False
        '
        'easyBtn
        '
        Me.easyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.easyBtn.Location = New System.Drawing.Point(21, 431)
        Me.easyBtn.Name = "easyBtn"
        Me.easyBtn.Size = New System.Drawing.Size(125, 65)
        Me.easyBtn.TabIndex = 29
        Me.easyBtn.Text = "Easy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Difficulty"
        Me.easyBtn.UseVisualStyleBackColor = True
        Me.easyBtn.UseWaitCursor = True
        Me.easyBtn.Visible = False
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(86, 317)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(74, 20)
        Me.lblS.TabIndex = 28
        Me.lblS.Text = "S - Down"
        Me.lblS.Visible = False
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(166, 317)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(72, 20)
        Me.lblD.TabIndex = 27
        Me.lblD.Text = "D - Right"
        Me.lblD.Visible = False
        '
        'lblW
        '
        Me.lblW.AutoSize = True
        Me.lblW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblW.Location = New System.Drawing.Point(93, 276)
        Me.lblW.Name = "lblW"
        Me.lblW.Size = New System.Drawing.Size(58, 20)
        Me.lblW.TabIndex = 26
        Me.lblW.Text = "W - Up"
        Me.lblW.Visible = False
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(15, 317)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(61, 20)
        Me.lblA.TabIndex = 25
        Me.lblA.Text = "A - Left"
        Me.lblA.Visible = False
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.Location = New System.Drawing.Point(109, 220)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(117, 20)
        Me.lblR.TabIndex = 24
        Me.lblR.Text = "R - Start Game"
        Me.lblR.Visible = False
        '
        'lblControls
        '
        Me.lblControls.AutoSize = True
        Me.lblControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControls.Location = New System.Drawing.Point(17, 220)
        Me.lblControls.Name = "lblControls"
        Me.lblControls.Size = New System.Drawing.Size(72, 20)
        Me.lblControls.TabIndex = 23
        Me.lblControls.Text = "Controls:"
        Me.lblControls.Visible = False
        '
        'clrScrBtn
        '
        Me.clrScrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrScrBtn.Location = New System.Drawing.Point(21, 532)
        Me.clrScrBtn.Name = "clrScrBtn"
        Me.clrScrBtn.Size = New System.Drawing.Size(125, 65)
        Me.clrScrBtn.TabIndex = 22
        Me.clrScrBtn.Text = "Clear " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Scores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.clrScrBtn.UseVisualStyleBackColor = True
        Me.clrScrBtn.UseWaitCursor = True
        Me.clrScrBtn.Visible = False
        '
        'txtSpdTime
        '
        Me.txtSpdTime.BackColor = System.Drawing.Color.Silver
        Me.txtSpdTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSpdTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpdTime.Location = New System.Drawing.Point(175, 177)
        Me.txtSpdTime.Name = "txtSpdTime"
        Me.txtSpdTime.Size = New System.Drawing.Size(100, 19)
        Me.txtSpdTime.TabIndex = 21
        Me.txtSpdTime.Text = "0"
        Me.txtSpdTime.Visible = False
        '
        'txtSnakeSpd
        '
        Me.txtSnakeSpd.BackColor = System.Drawing.Color.Silver
        Me.txtSnakeSpd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSnakeSpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnakeSpd.Location = New System.Drawing.Point(175, 138)
        Me.txtSnakeSpd.Name = "txtSnakeSpd"
        Me.txtSnakeSpd.Size = New System.Drawing.Size(100, 19)
        Me.txtSnakeSpd.TabIndex = 20
        Me.txtSnakeSpd.Text = "0"
        Me.txtSnakeSpd.Visible = False
        '
        'txtGametimeSpd
        '
        Me.txtGametimeSpd.BackColor = System.Drawing.Color.Silver
        Me.txtGametimeSpd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGametimeSpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGametimeSpd.Location = New System.Drawing.Point(175, 96)
        Me.txtGametimeSpd.Name = "txtGametimeSpd"
        Me.txtGametimeSpd.Size = New System.Drawing.Size(100, 19)
        Me.txtGametimeSpd.TabIndex = 19
        Me.txtGametimeSpd.Text = "0"
        Me.txtGametimeSpd.Visible = False
        '
        'lblSpdTime
        '
        Me.lblSpdTime.AutoSize = True
        Me.lblSpdTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpdTime.Location = New System.Drawing.Point(17, 177)
        Me.lblSpdTime.Name = "lblSpdTime"
        Me.lblSpdTime.Size = New System.Drawing.Size(103, 20)
        Me.lblSpdTime.TabIndex = 18
        Me.lblSpdTime.Text = "Speed Timer:"
        Me.lblSpdTime.Visible = False
        '
        'lblSnakeSpd
        '
        Me.lblSnakeSpd.AutoSize = True
        Me.lblSnakeSpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnakeSpd.Location = New System.Drawing.Point(17, 137)
        Me.lblSnakeSpd.Name = "lblSnakeSpd"
        Me.lblSnakeSpd.Size = New System.Drawing.Size(110, 20)
        Me.lblSnakeSpd.TabIndex = 17
        Me.lblSnakeSpd.Text = "Snake Speed:"
        Me.lblSnakeSpd.Visible = False
        '
        'lblGameTimeSpd
        '
        Me.lblGameTimeSpd.AutoSize = True
        Me.lblGameTimeSpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTimeSpd.Location = New System.Drawing.Point(17, 96)
        Me.lblGameTimeSpd.Name = "lblGameTimeSpd"
        Me.lblGameTimeSpd.Size = New System.Drawing.Size(147, 20)
        Me.lblGameTimeSpd.TabIndex = 16
        Me.lblGameTimeSpd.Text = "GameTimer Speed:"
        Me.lblGameTimeSpd.Visible = False
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(307, 545)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(125, 52)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        Me.SaveBtn.UseWaitCursor = True
        Me.SaveBtn.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 37)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Settings"
        Me.Label8.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(1011, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(24, 25)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "0"
        '
        'scoreBtn
        '
        Me.scoreBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scoreBtn.Location = New System.Drawing.Point(1110, 700)
        Me.scoreBtn.Name = "scoreBtn"
        Me.scoreBtn.Size = New System.Drawing.Size(125, 52)
        Me.scoreBtn.TabIndex = 13
        Me.scoreBtn.Text = "Scores"
        Me.scoreBtn.UseVisualStyleBackColor = True
        '
        'SnakeSpd
        '
        Me.SnakeSpd.Interval = 200
        '
        'SpdTimer
        '
        Me.SpdTimer.Interval = 10000
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsBtn.Location = New System.Drawing.Point(979, 700)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(125, 52)
        Me.SettingsBtn.TabIndex = 14
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(344, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Apples Needed to Complete Level:"
        '
        'lblApplesNeeded
        '
        Me.lblApplesNeeded.AutoSize = True
        Me.lblApplesNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplesNeeded.Location = New System.Drawing.Point(377, 9)
        Me.lblApplesNeeded.Name = "lblApplesNeeded"
        Me.lblApplesNeeded.Size = New System.Drawing.Size(24, 25)
        Me.lblApplesNeeded.TabIndex = 16
        Me.lblApplesNeeded.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(704, 720)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Lives:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(499, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 25)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Level:"
        '
        'lblLevelNo
        '
        Me.lblLevelNo.AutoSize = True
        Me.lblLevelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelNo.Location = New System.Drawing.Point(586, 9)
        Me.lblLevelNo.Name = "lblLevelNo"
        Me.lblLevelNo.Size = New System.Drawing.Size(24, 25)
        Me.lblLevelNo.TabIndex = 21
        Me.lblLevelNo.Text = "0"
        '
        'leftsnakeAssTmr
        '
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(673, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 25)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "0"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(728, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 25)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "0"
        Me.Label15.Visible = False
        '
        'rightsnakeAssTmr
        '
        '
        'upsnakeAssTmr
        '
        '
        'downsnakeAssTmr
        '
        '
        'Snake_3
        '
        Me.Snake_3.BackgroundImage = Global.SnakeGame_VB.My.Resources.Resources.Picture2
        Me.Snake_3.Location = New System.Drawing.Point(884, 709)
        Me.Snake_3.Name = "Snake_3"
        Me.Snake_3.Size = New System.Drawing.Size(39, 41)
        Me.Snake_3.TabIndex = 18
        Me.Snake_3.TabStop = False
        '
        'Snake_2
        '
        Me.Snake_2.BackgroundImage = Global.SnakeGame_VB.My.Resources.Resources.Picture2
        Me.Snake_2.Location = New System.Drawing.Point(839, 709)
        Me.Snake_2.Name = "Snake_2"
        Me.Snake_2.Size = New System.Drawing.Size(39, 41)
        Me.Snake_2.TabIndex = 17
        Me.Snake_2.TabStop = False
        '
        'Snake_1
        '
        Me.Snake_1.BackgroundImage = Global.SnakeGame_VB.My.Resources.Resources.Picture2
        Me.Snake_1.Location = New System.Drawing.Point(794, 709)
        Me.Snake_1.Name = "Snake_1"
        Me.Snake_1.Size = New System.Drawing.Size(39, 41)
        Me.Snake_1.TabIndex = 7
        Me.Snake_1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblLevelNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Snake_3)
        Me.Controls.Add(Me.lblApplesNeeded)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Snake_2)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.Snake_1)
        Me.Controls.Add(Me.scoreBtn)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake Game"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Snake_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Snake_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Snake_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GameTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Public WithEvents Panel1 As Panel
    Friend WithEvents scoreBtn As Button
    Friend WithEvents SnakeSpd As Timer
    Friend WithEvents SpdTimer As Timer
    Friend WithEvents SettingsBtn As Button
    Public WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents lblSpdTime As Label
    Friend WithEvents lblSnakeSpd As Label
    Friend WithEvents lblGameTimeSpd As Label
    Friend WithEvents txtSpdTime As TextBox
    Friend WithEvents txtSnakeSpd As TextBox
    Friend WithEvents txtGametimeSpd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblApplesNeeded As Label
    Friend WithEvents clrScrBtn As Button
    Friend WithEvents Snake_1 As PictureBox
    Friend WithEvents Snake_2 As PictureBox
    Friend WithEvents Snake_3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblLevelNo As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblW As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblR As Label
    Friend WithEvents lblControls As Label
    Friend WithEvents hardBtn As Button
    Friend WithEvents normalBtn As Button
    Friend WithEvents easyBtn As Button
    Friend WithEvents rstBtn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblIncLen As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents leftsnakeAssTmr As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents rightsnakeAssTmr As Timer
    Friend WithEvents upsnakeAssTmr As Timer
    Friend WithEvents downsnakeAssTmr As Timer
End Class

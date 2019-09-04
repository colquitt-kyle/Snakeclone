<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnake
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbField = New System.Windows.Forms.PictureBox()
        Me.tmSnakeMove = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblScoreStatic = New System.Windows.Forms.Label()
        Me.lblGameOver = New System.Windows.Forms.Label()
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbField
        '
        Me.pbField.BackColor = System.Drawing.Color.PeachPuff
        Me.pbField.Location = New System.Drawing.Point(40, 12)
        Me.pbField.Name = "pbField"
        Me.pbField.Size = New System.Drawing.Size(834, 515)
        Me.pbField.TabIndex = 0
        Me.pbField.TabStop = False
        '
        'tmSnakeMove
        '
        Me.tmSnakeMove.Interval = 50
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(103, 545)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(23, 25)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "0"
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.FloralWhite
        Me.btnYes.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(232, 598)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(157, 63)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        Me.btnYes.Visible = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.FloralWhite
        Me.btnNo.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNo.Location = New System.Drawing.Point(533, 598)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(157, 63)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        Me.btnNo.Visible = False
        '
        'lblScoreStatic
        '
        Me.lblScoreStatic.AutoSize = True
        Me.lblScoreStatic.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreStatic.Location = New System.Drawing.Point(25, 545)
        Me.lblScoreStatic.Name = "lblScoreStatic"
        Me.lblScoreStatic.Size = New System.Drawing.Size(72, 25)
        Me.lblScoreStatic.TabIndex = 4
        Me.lblScoreStatic.Text = "Score:"
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Transparent
        Me.lblGameOver.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(353, 545)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(217, 25)
        Me.lblGameOver.TabIndex = 5
        Me.lblGameOver.Text = "Want to play again?"
        Me.lblGameOver.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 700)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblScoreStatic)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pbField)
        Me.Name = "Form1"
        Me.Text = "Classic Snake"
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbField As PictureBox
    Friend WithEvents tmSnakeMove As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents lblScoreStatic As Label
    Friend WithEvents lblGameOver As Label
End Class

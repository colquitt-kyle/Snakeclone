<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblSnake = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FloralWhite
        Me.btnStart.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(157, 284)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(138, 67)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblSnake
        '
        Me.lblSnake.AutoSize = True
        Me.lblSnake.BackColor = System.Drawing.Color.Transparent
        Me.lblSnake.Font = New System.Drawing.Font("Kristen ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnake.ForeColor = System.Drawing.Color.Green
        Me.lblSnake.Location = New System.Drawing.Point(3, 0)
        Me.lblSnake.Name = "lblSnake"
        Me.lblSnake.Size = New System.Drawing.Size(447, 83)
        Me.lblSnake.TabIndex = 1
        Me.lblSnake.Text = "Classic Snake"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(447, 375)
        Me.Controls.Add(Me.lblSnake)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmStart"
        Me.Text = "Classic Snake"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lblSnake As Label
End Class

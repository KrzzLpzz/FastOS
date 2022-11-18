<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Snake
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
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.ss = New System.Windows.Forms.StatusStrip()
        Me.tss0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tss1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tss2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssSnakeLength = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssSnakeSpeed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tss3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmr
        '
        Me.tmr.Enabled = True
        Me.tmr.Interval = 50
        '
        'ss
        '
        Me.ss.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss0, Me.tss1, Me.tss2, Me.tssSnakeLength, Me.tssSnakeSpeed, Me.tss3})
        Me.ss.Location = New System.Drawing.Point(0, 476)
        Me.ss.Name = "ss"
        Me.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ss.Size = New System.Drawing.Size(653, 22)
        Me.ss.TabIndex = 0
        Me.ss.Text = "StatusStrip1"
        '
        'tss0
        '
        Me.tss0.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.tss0.Name = "tss0"
        Me.tss0.Size = New System.Drawing.Size(68, 17)
        Me.tss0.Text = "Screen Size:"
        Me.tss0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tss1
        '
        Me.tss1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(90, 17)
        Me.tss1.Text = "Token Location:"
        Me.tss1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tss2
        '
        Me.tss2.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.tss2.Name = "tss2"
        Me.tss2.Size = New System.Drawing.Size(90, 17)
        Me.tss2.Text = "Snake Location:"
        Me.tss2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssSnakeLength
        '
        Me.tssSnakeLength.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.tssSnakeLength.Name = "tssSnakeLength"
        Me.tssSnakeLength.Size = New System.Drawing.Size(81, 17)
        Me.tssSnakeLength.Text = "Snake Length:"
        Me.tssSnakeLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssSnakeSpeed
        '
        Me.tssSnakeSpeed.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.tssSnakeSpeed.Name = "tssSnakeSpeed"
        Me.tssSnakeSpeed.Size = New System.Drawing.Size(76, 17)
        Me.tssSnakeSpeed.Text = "Snake Speed:"
        Me.tssSnakeSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tss3
        '
        Me.tss3.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.tss3.Name = "tss3"
        Me.tss3.Size = New System.Drawing.Size(233, 17)
        Me.tss3.Spring = True
        Me.tss3.Text = "Total Points:"
        Me.tss3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Snake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.FastOS.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(653, 498)
        Me.Controls.Add(Me.ss)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(669, 537)
        Me.MinimumSize = New System.Drawing.Size(669, 537)
        Me.Name = "Snake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake"
        Me.ss.ResumeLayout(False)
        Me.ss.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents ss As System.Windows.Forms.StatusStrip
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tss0 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tss2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tss3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssSnakeLength As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssSnakeSpeed As System.Windows.Forms.ToolStripStatusLabel

End Class

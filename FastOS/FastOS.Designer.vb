<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FastOS
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
        Me.Screen = New System.Windows.Forms.Panel()
        Me.LSTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Screen
        '
        Me.Screen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Screen.Location = New System.Drawing.Point(0, 0)
        Me.Screen.Name = "Screen"
        Me.Screen.Size = New System.Drawing.Size(1083, 590)
        Me.Screen.TabIndex = 2
        '
        'LSTimer
        '
        Me.LSTimer.Enabled = True
        Me.LSTimer.Interval = 6000
        '
        'FastOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 590)
        Me.Controls.Add(Me.Screen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "FastOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FastOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Screen As Panel
    Friend WithEvents LSTimer As Timer
End Class

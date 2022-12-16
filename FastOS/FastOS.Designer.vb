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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FastOS))
        Me.Screen = New System.Windows.Forms.Panel()
        Me.LSTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Screen
        '
        Me.Screen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1099, 629)
        Me.Name = "FastOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FastOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Screen As Panel
    Friend WithEvents LSTimer As Timer
End Class

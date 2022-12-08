<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FactOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FactOS))
        Me.slidingpanel = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.imagepanel = New System.Windows.Forms.Panel()
        Me.headersliadingpanel = New System.Windows.Forms.Panel()
        Me.btnslidingmenu = New System.Windows.Forms.Button()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.headermainpanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.slidingpanel.SuspendLayout()
        Me.headersliadingpanel.SuspendLayout()
        Me.mainpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'slidingpanel
        '
        Me.slidingpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.slidingpanel.Controls.Add(Me.Button5)
        Me.slidingpanel.Controls.Add(Me.Button4)
        Me.slidingpanel.Controls.Add(Me.Button3)
        Me.slidingpanel.Controls.Add(Me.Button2)
        Me.slidingpanel.Controls.Add(Me.Button1)
        Me.slidingpanel.Controls.Add(Me.btnadmin)
        Me.slidingpanel.Controls.Add(Me.imagepanel)
        Me.slidingpanel.Controls.Add(Me.headersliadingpanel)
        Me.slidingpanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.slidingpanel.Location = New System.Drawing.Point(0, 0)
        Me.slidingpanel.Name = "slidingpanel"
        Me.slidingpanel.Size = New System.Drawing.Size(214, 511)
        Me.slidingpanel.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(0, 268)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(214, 43)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Calculadora"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(0, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(214, 43)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Camara"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(0, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(214, 43)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Navegador"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(0, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 43)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Editor de Texto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(0, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Galeria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnadmin
        '
        Me.btnadmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnadmin.FlatAppearance.BorderSize = 0
        Me.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmin.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadmin.Location = New System.Drawing.Point(0, 53)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(214, 43)
        Me.btnadmin.TabIndex = 2
        Me.btnadmin.Text = "Administrador de Usuarios"
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'imagepanel
        '
        Me.imagepanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.imagepanel.Location = New System.Drawing.Point(0, 43)
        Me.imagepanel.Name = "imagepanel"
        Me.imagepanel.Size = New System.Drawing.Size(214, 10)
        Me.imagepanel.TabIndex = 1
        '
        'headersliadingpanel
        '
        Me.headersliadingpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.headersliadingpanel.Controls.Add(Me.btnslidingmenu)
        Me.headersliadingpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headersliadingpanel.Location = New System.Drawing.Point(0, 0)
        Me.headersliadingpanel.Name = "headersliadingpanel"
        Me.headersliadingpanel.Size = New System.Drawing.Size(214, 43)
        Me.headersliadingpanel.TabIndex = 0
        '
        'btnslidingmenu
        '
        Me.btnslidingmenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnslidingmenu.FlatAppearance.BorderSize = 0
        Me.btnslidingmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnslidingmenu.Image = CType(resources.GetObject("btnslidingmenu.Image"), System.Drawing.Image)
        Me.btnslidingmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnslidingmenu.Location = New System.Drawing.Point(150, 0)
        Me.btnslidingmenu.Name = "btnslidingmenu"
        Me.btnslidingmenu.Size = New System.Drawing.Size(64, 43)
        Me.btnslidingmenu.TabIndex = 0
        Me.btnslidingmenu.UseVisualStyleBackColor = True
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.headermainpanel)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(214, 0)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(714, 511)
        Me.mainpanel.TabIndex = 1
        '
        'headermainpanel
        '
        Me.headermainpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.headermainpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headermainpanel.Location = New System.Drawing.Point(0, 0)
        Me.headermainpanel.Name = "headermainpanel"
        Me.headermainpanel.Size = New System.Drawing.Size(714, 43)
        Me.headermainpanel.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'FactOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 511)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.slidingpanel)
        Me.Name = "FactOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FactOS"
        Me.slidingpanel.ResumeLayout(False)
        Me.headersliadingpanel.ResumeLayout(False)
        Me.mainpanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents slidingpanel As Panel
    Friend WithEvents mainpanel As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnadmin As Button
    Friend WithEvents imagepanel As Panel
    Friend WithEvents headersliadingpanel As Panel
    Friend WithEvents btnslidingmenu As Button
    Friend WithEvents headermainpanel As Panel
    Friend WithEvents Timer1 As Timer
End Class

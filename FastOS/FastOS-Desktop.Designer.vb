<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FastOS_Desktop
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnMenu = New FontAwesome.Sharp.IconButton()
        Me.btnSettings = New FontAwesome.Sharp.IconButton()
        Me.btnGallery = New FontAwesome.Sharp.IconButton()
        Me.btnTicTacToe = New FontAwesome.Sharp.IconButton()
        Me.btnPlayer = New FontAwesome.Sharp.IconButton()
        Me.btnTXTEditor = New FontAwesome.Sharp.IconButton()
        Me.btnCalculator = New FontAwesome.Sharp.IconButton()
        Me.btnBrowser = New FontAwesome.Sharp.IconButton()
        Me.PanelEscritorio = New System.Windows.Forms.Panel()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.btnApagar = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPower = New FontAwesome.Sharp.IconButton()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.tmrOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrar2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultar2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrMostrar
        '
        Me.tmrMostrar.Interval = 15
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.btnSettings)
        Me.PanelMenu.Controls.Add(Me.btnGallery)
        Me.PanelMenu.Controls.Add(Me.btnTicTacToe)
        Me.PanelMenu.Controls.Add(Me.btnPlayer)
        Me.PanelMenu.Controls.Add(Me.btnTXTEditor)
        Me.PanelMenu.Controls.Add(Me.btnCalculator)
        Me.PanelMenu.Controls.Add(Me.btnBrowser)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(60, 590)
        Me.PanelMenu.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnMenu.IconColor = System.Drawing.Color.Black
        Me.btnMenu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMenu.IconSize = 30
        Me.btnMenu.Location = New System.Drawing.Point(4, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(50, 50)
        Me.btnMenu.TabIndex = 15
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.IconChar = FontAwesome.Sharp.IconChar.UsersCog
        Me.btnSettings.IconColor = System.Drawing.Color.Black
        Me.btnSettings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSettings.IconSize = 50
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(3, 411)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(191, 50)
        Me.btnSettings.TabIndex = 14
        Me.btnSettings.Text = "     Configuraciones"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnGallery
        '
        Me.btnGallery.FlatAppearance.BorderSize = 0
        Me.btnGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGallery.IconChar = FontAwesome.Sharp.IconChar.Images
        Me.btnGallery.IconColor = System.Drawing.Color.Black
        Me.btnGallery.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGallery.IconSize = 50
        Me.btnGallery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGallery.Location = New System.Drawing.Point(3, 355)
        Me.btnGallery.Name = "btnGallery"
        Me.btnGallery.Size = New System.Drawing.Size(191, 50)
        Me.btnGallery.TabIndex = 13
        Me.btnGallery.Text = "     Galeria"
        Me.btnGallery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGallery.UseVisualStyleBackColor = True
        '
        'btnTicTacToe
        '
        Me.btnTicTacToe.FlatAppearance.BorderSize = 0
        Me.btnTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTicTacToe.IconChar = FontAwesome.Sharp.IconChar.Gamepad
        Me.btnTicTacToe.IconColor = System.Drawing.Color.Black
        Me.btnTicTacToe.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTicTacToe.IconSize = 50
        Me.btnTicTacToe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTicTacToe.Location = New System.Drawing.Point(3, 299)
        Me.btnTicTacToe.Name = "btnTicTacToe"
        Me.btnTicTacToe.Size = New System.Drawing.Size(191, 50)
        Me.btnTicTacToe.TabIndex = 12
        Me.btnTicTacToe.Text = "     Tres en Raya"
        Me.btnTicTacToe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTicTacToe.UseVisualStyleBackColor = True
        '
        'btnPlayer
        '
        Me.btnPlayer.FlatAppearance.BorderSize = 0
        Me.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayer.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.btnPlayer.IconColor = System.Drawing.Color.Black
        Me.btnPlayer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPlayer.IconSize = 50
        Me.btnPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayer.Location = New System.Drawing.Point(3, 243)
        Me.btnPlayer.Name = "btnPlayer"
        Me.btnPlayer.Size = New System.Drawing.Size(191, 50)
        Me.btnPlayer.TabIndex = 11
        Me.btnPlayer.Text = "     Reproductor de Musica"
        Me.btnPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlayer.UseVisualStyleBackColor = True
        '
        'btnTXTEditor
        '
        Me.btnTXTEditor.FlatAppearance.BorderSize = 0
        Me.btnTXTEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTXTEditor.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.btnTXTEditor.IconColor = System.Drawing.Color.Black
        Me.btnTXTEditor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTXTEditor.IconSize = 50
        Me.btnTXTEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTXTEditor.Location = New System.Drawing.Point(3, 187)
        Me.btnTXTEditor.Name = "btnTXTEditor"
        Me.btnTXTEditor.Size = New System.Drawing.Size(191, 50)
        Me.btnTXTEditor.TabIndex = 10
        Me.btnTXTEditor.Text = "     Editor de Texto"
        Me.btnTXTEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTXTEditor.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.FlatAppearance.BorderSize = 0
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.btnCalculator.IconColor = System.Drawing.Color.Black
        Me.btnCalculator.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCalculator.IconSize = 50
        Me.btnCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculator.Location = New System.Drawing.Point(3, 131)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(191, 50)
        Me.btnCalculator.TabIndex = 9
        Me.btnCalculator.Text = "     Calculadora"
        Me.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'btnBrowser
        '
        Me.btnBrowser.FlatAppearance.BorderSize = 0
        Me.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowser.IconChar = FontAwesome.Sharp.IconChar.Chrome
        Me.btnBrowser.IconColor = System.Drawing.Color.Black
        Me.btnBrowser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBrowser.IconSize = 50
        Me.btnBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowser.Location = New System.Drawing.Point(3, 75)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(191, 50)
        Me.btnBrowser.TabIndex = 8
        Me.btnBrowser.Text = "     Navegador"
        Me.btnBrowser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'PanelEscritorio
        '
        Me.PanelEscritorio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEscritorio.AutoSize = True
        Me.PanelEscritorio.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelEscritorio.Location = New System.Drawing.Point(60, 0)
        Me.PanelEscritorio.Name = "PanelEscritorio"
        Me.PanelEscritorio.Size = New System.Drawing.Size(1023, 540)
        Me.PanelEscritorio.TabIndex = 1
        '
        'PanelLogin
        '
        Me.PanelLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLogin.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelLogin.Controls.Add(Me.IconButton2)
        Me.PanelLogin.Controls.Add(Me.btnApagar)
        Me.PanelLogin.Location = New System.Drawing.Point(917, 440)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(100, 100)
        Me.PanelLogin.TabIndex = 2
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOut
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(3, 12)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(94, 35)
        Me.IconButton2.TabIndex = 10
        Me.IconButton2.Text = "Cerrar Sesion"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'btnApagar
        '
        Me.btnApagar.FlatAppearance.BorderSize = 0
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnApagar.IconColor = System.Drawing.Color.Black
        Me.btnApagar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnApagar.IconSize = 30
        Me.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApagar.Location = New System.Drawing.Point(3, 53)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(94, 35)
        Me.btnApagar.TabIndex = 9
        Me.btnApagar.Text = "Apagar"
        Me.btnApagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.btnPower)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(60, 540)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnPower
        '
        Me.btnPower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPower.FlatAppearance.BorderSize = 0
        Me.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPower.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnPower.IconColor = System.Drawing.Color.Black
        Me.btnPower.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPower.IconSize = 30
        Me.btnPower.Location = New System.Drawing.Point(885, 2)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(45, 45)
        Me.btnPower.TabIndex = 16
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.Location = New System.Drawing.Point(936, 26)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(75, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "0/00/0000"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.Location = New System.Drawing.Point(936, 11)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(75, 13)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "00:00"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrOcultar
        '
        Me.tmrOcultar.Interval = 15
        '
        'tmrHora
        '
        Me.tmrHora.Enabled = True
        Me.tmrHora.Interval = 10
        '
        'tmrMostrar2
        '
        Me.tmrMostrar2.Interval = 15
        '
        'tmrOcultar2
        '
        Me.tmrOcultar2.Interval = 15
        '
        'FastOS_Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 590)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelEscritorio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1083, 590)
        Me.Name = "FastOS_Desktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FastOS"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogin.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrMostrar As Timer
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelEscritorio As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tmrOcultar As Timer
    Friend WithEvents btnTXTEditor As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCalculator As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBrowser As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGallery As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTicTacToe As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPlayer As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents tmrHora As Timer
    Friend WithEvents btnPower As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnApagar As FontAwesome.Sharp.IconButton
    Friend WithEvents tmrMostrar2 As Timer
    Friend WithEvents tmrOcultar2 As Timer
End Class

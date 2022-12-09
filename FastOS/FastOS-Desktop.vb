Public Class FastOS_Desktop
    Public UsernameDesk As String
    Public TypeAcc As String

    Private Sub tmrOcultar_Tick(sender As Object, e As EventArgs) Handles tmrOcultar.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmrOcultar.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub ocultar()
        If PanelMenu.Width = 220 Then
            tmrOcultar.Enabled = True
        End If

        If PanelLogin.Height = 100 Then
            tmrOcultar2.Enabled = True
        End If
    End Sub

    Private Sub tmrMostrar_Tick(sender As Object, e As EventArgs) Handles tmrMostrar.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmrMostrar.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub FastOS_Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = DateTime.Today.Day & "/" & DateTime.Now.Month.ToString & "/" & DateTime.Today.Year
        PanelLogin.Height = 0
        tmrHora.Interval = 1000
        ocultar()

        PanelEscritorio.Parent = PictureBox1
        PanelEscritorio.BackColor = Color.Transparent
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmrOcultar.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmrMostrar.Enabled = True
        End If
    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm")
    End Sub

    Private Sub tmrMostrar2_Tick(sender As Object, e As EventArgs) Handles tmrMostrar2.Tick
        If PanelLogin.Height >= 100 Then
            Me.tmrMostrar2.Enabled = False
        Else
            Me.PanelLogin.Height = PanelLogin.Height + 20
        End If
    End Sub

    Private Sub tmrOcultar2_Tick(sender As Object, e As EventArgs) Handles tmrOcultar2.Tick
        If PanelLogin.Height <= 0 Then
            Me.tmrOcultar2.Enabled = False
        Else
            Me.PanelLogin.Height = PanelLogin.Height - 20
        End If
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        If PanelLogin.Height = 100 Then
            tmrOcultar2.Enabled = True
            btnPower.BackColor = Color.FromArgb(184, 50, 50)
        ElseIf PanelLogin.Height = 0 Then
            tmrMostrar2.Enabled = True
            btnPower.BackColor = Color.FromArgb(220, 60, 60)
        End If
    End Sub

    Private Sub PanelEscritorio_Click(sender As Object, e As EventArgs) Handles PanelEscritorio.Click
        ocultar()
    End Sub

    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelEscritorio.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue encontrado/no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            'Formulario.FormBorderStyle = FormBorderStyle.None
            'Formulario.Dock = DockStyle.Fill

            PanelEscritorio.Controls.Add(Formulario)
            PanelEscritorio.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    'METODO/EVENTO AL CERRAR FORMS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If (Application.OpenForms("Browser") Is Nothing) Then
            btnBrowser.BackColor = Color.FromArgb(184, 50, 50)
        End If
        If (Application.OpenForms("Calculator") Is Nothing) Then
            btnCalculator.BackColor = Color.FromArgb(184, 50, 50)
        End If
        If (Application.OpenForms("TextEditor") Is Nothing) Then
            btnTXTEditor.BackColor = Color.FromArgb(184, 50, 50)
        End If
        If (Application.OpenForms("MP3Player") Is Nothing) Then
            btnPlayer.BackColor = Color.FromArgb(184, 50, 50)
        End If
        If (Application.OpenForms("TresEnRaya") Is Nothing) Then
            btnTicTacToe.BackColor = Color.FromArgb(184, 50, 50)
        End If
        If (Application.OpenForms("Gallery") Is Nothing) Then
            btnGallery.BackColor = Color.FromArgb(184, 50, 50)
        End If
        If (Application.OpenForms("Users") Is Nothing) Then
            btnSettings.BackColor = Color.FromArgb(184, 50, 50)
        End If
        If (Application.OpenForms("form2") Is Nothing) Then
            'Button3.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        AbrirFormEnPanel(Of Browser)()
        btnBrowser.BackColor = Color.FromArgb(220, 60, 60)
        ocultar()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        AbrirFormEnPanel(Of Calculator)()
        btnCalculator.BackColor = Color.FromArgb(220, 60, 60)
        ocultar()
    End Sub

    Private Sub btnTXTEditor_Click(sender As Object, e As EventArgs) Handles btnTXTEditor.Click
        AbrirFormEnPanel(Of TextEditor)()
        btnTXTEditor.BackColor = Color.FromArgb(220, 60, 60)
        ocultar()
    End Sub

    Private Sub btnPlayer_Click(sender As Object, e As EventArgs) Handles btnPlayer.Click
        AbrirFormEnPanel(Of MP3Player)()
        btnPlayer.BackColor = Color.FromArgb(220, 60, 60)
        ocultar()
    End Sub

    Private Sub btnTicTacToe_Click(sender As Object, e As EventArgs) Handles btnTicTacToe.Click
        AbrirFormEnPanel(Of TresEnRaya)()
        btnTicTacToe.BackColor = Color.FromArgb(220, 60, 60)
        ocultar()
    End Sub

    Private Sub btnGallery_Click(sender As Object, e As EventArgs) Handles btnGallery.Click
        AbrirFormEnPanel(Of Gallery)()
        btnGallery.BackColor = Color.FromArgb(220, 60, 60)
        ocultar()
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        If MsgBox("¿Está seguro que desea apagar el sistema?", vbQuestion + vbYesNo, "FastOS") = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If MsgBox("¿Está seguro que desea cerrar sesion?", vbQuestion + vbYesNo, "FastOS") = DialogResult.Yes Then
            Me.Close()
            FastOS.Screen.Controls.Clear()
            FastOS.LoginScreen()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        AbrirFormEnPanel(Of Users)()
        btnSettings.BackColor = Color.FromArgb(220, 60, 60)
        ocultar()
    End Sub
End Class
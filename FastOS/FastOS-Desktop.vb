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
        ElseIf PanelLogin.Height = 0 Then
            tmrMostrar2.Enabled = True
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
        If (Application.OpenForms("Form1") Is Nothing) Then
            'Button1.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form2") Is Nothing) Then
            'Button2.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            'Button3.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        AbrirFormEnPanel(Of Browser)()
        ocultar()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        AbrirFormEnPanel(Of Calculator)()
        ocultar()
    End Sub
End Class
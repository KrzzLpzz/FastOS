Public Class Desktop
    Public UsernameDesk As String
    Public TypeAcc As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdminUsers.Click
        UsersAdmin(New Users)
    End Sub

    Public Sub UsersAdmin(frmHijo As Object)
        Dim Users As New Users
        Users = frmHijo
        Users.TopLevel = False
        'Users.Dock = DockStyle.Fill
        Users.TopMost = True

        Me.Screen2.Controls.Add(Users)
        Me.Screen2.Tag = Users

        Users.Show()
    End Sub

    Private Sub Desktop_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEditor(frmHijo2 As Object)
        Dim TextEditor As New TextEditor
        TextEditor = frmHijo2
        TextEditor.TopLevel = False
        Users.TopMost = True

        Me.Screen2.Controls.Add(TextEditor)
        Me.Screen2.Tag = TextEditor

        TextEditor.Show()
    End Sub

    Private Sub btnEditorTexto_Click(sender As Object, e As EventArgs) Handles btnEditorTexto.Click
        TextEditor(New TextEditor)
    End Sub

    Private Sub Gallery(frmHijo3 As Object)
        Dim Gallery As New Gallery
        Gallery = frmHijo3
        Gallery.TopLevel = False
        Gallery.TopMost = True

        Me.Screen2.Controls.Add(Gallery)
        Me.Screen2.Tag = Gallery

        Gallery.Show()
    End Sub

    Private Sub btnGaleria_Click(sender As Object, e As EventArgs) Handles btnGaleria.Click
        Gallery(New Gallery)
    End Sub

    Private Sub btnNavegador_Click(sender As Object, e As EventArgs) Handles btnNavegador.Click
        Navegador(New Browser)
    End Sub

    Private Sub Navegador(frmHijo4 As Object)
        Dim Browser As New Browser
        Browser = frmHijo4
        Browser.TopLevel = False
        Users.TopMost = True

        Me.Screen2.Controls.Add(Browser)
        Me.Screen2.Tag = Browser

        Browser.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        FastOS.Screen.Controls.Clear()
        FastOS.LoginScreen()
    End Sub

    Private Sub Screen2_Paint(sender As Object, e As PaintEventArgs) Handles Screen2.Paint

    End Sub
End Class
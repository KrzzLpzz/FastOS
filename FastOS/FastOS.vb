Public Class FastOS

    Public IDUserGlobal As Integer

    Private Sub LSTimer_Tick(sender As Object, e As EventArgs) Handles LSTimer.Tick
        Screen.Controls.Clear()
        LoadScreen.Close()
        LSTimer.Stop()
        LSTimer.Enabled = False
        LoginScreen()
    End Sub

    Public Sub LoginScreen()
        Dim Login As New Login
        Login.MdiParent = Me
        Me.Screen.Controls.Add(Login)
        Login.Show()
    End Sub

    Public Sub StartScreen()
        Dim LoadScreen As New LoadScreen
        LoadScreen.MdiParent = Me
        Me.Screen.Controls.Add(LoadScreen)
        LoadScreen.Show()
        LSTimer.Start()
        LSTimer.Enabled = True
    End Sub

    Private Sub Screen_Paint(sender As Object, e As PaintEventArgs) Handles Screen.Paint

    End Sub

    Public Sub Desktop()
        Dim Desktop As New Desktop
        Desktop.MdiParent = Me
        Me.Screen.Controls.Add(Desktop)
        Desktop.Show()
    End Sub

    Private Sub FastOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartScreen()
    End Sub

    Public Sub TXTDownloader()
        Dim TXTDownloader As New DownloadTXT
        TXTDownloader.MdiParent = Me
        Me.Screen.Controls.Add(TXTDownloader)

        TXTDownloader.ShowDialog()

    End Sub

    'Public Sub UsersAdmin()
    'Dim Users As New Users
    '   Users.MdiParent = Me
    'Me.Screen.Controls.Add(Users)
    '   Users.Show()
    'End Sub
End Class

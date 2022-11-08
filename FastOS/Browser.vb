Public Class Browser

    Public URLxd As String
    Private Sub Retroceder_Click(sender As Object, e As EventArgs) Handles Retroceder.Click
        WebBrowser.GoBack()
    End Sub

    Private Sub Avanzar_Click(sender As Object, e As EventArgs) Handles Avanzar.Click
        WebBrowser.GoForward()
    End Sub

    Private Sub Ir_Click(sender As Object, e As EventArgs) Handles Ir.Click
        URLxd = "https://" + BarraDeBusqueda.Text
        WebBrowser.Source = New Uri(URLxd)
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        WebBrowser.Reload()
    End Sub

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BarraDeBusqueda.Text = "google.com"
        URLxd = "https://" + BarraDeBusqueda.Text
        WebBrowser.Source = New Uri(URLxd)
    End Sub
End Class
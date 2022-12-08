Public Class FactOS


    Dim slidingmenu As String = "open"

    Private Sub btnslidingmenu_Click(sender As Object, e As EventArgs) Handles btnslidingmenu.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If slidingmenu = "open" Then
            slidingpanel.Width += 25
            imagepanel.Width += 25
            imagepanel.Height += 25
            If slidingpanel.Width >= 250 Then
                Timer1.Stop()
                imagepanel.Visible = True
                slidingmenu = "close"
            End If
        Else
            slidingpanel.Width -= 25
            imagepanel.Width -= 25
            imagepanel.Height -= 25
            If slidingpanel.Width <= 50 Then
                Timer1.Stop()
                imagepanel.Visible = False
                slidingmenu = "open"
            End If
        End If
    End Sub
End Class

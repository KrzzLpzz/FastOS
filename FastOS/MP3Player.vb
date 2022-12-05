Public Class MP3Player
    Private PlayList As WMPLib.IWMPPlaylist = Nothing

    Private Sub BtnAbaut_Click(sender As Object, e As EventArgs)
        'abaut.ShowDialog()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs)
        OFileD.ShowDialog()
    End Sub

    Private Sub OFileD_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFileD.FileOk

        Dim IntCuenta As Integer
        Dim StrRutaCancionMP3 As String
        Dim StrCancionSinRuta As String
        Dim StrcancionReverse As String
        Dim StrFiles() As String

        PlayList = WMP.newPlaylist("media", "")
        Lista.Items.Clear()
        StrFiles = OFileD.FileNames

        For IntCuenta = 0 To UBound(StrFiles)
            StrRutaCancionMP3 = StrFiles(IntCuenta)
            PlayList.appendItem(WMP.newMedia(StrRutaCancionMP3))
            StrcancionReverse = StrReverse(StrRutaCancionMP3)
            StrCancionSinRuta = StrRutaCancionMP3.Substring(Len(StrRutaCancionMP3) - StrcancionReverse.IndexOf("\"))

            Lista.Items.Add(StrCancionSinRuta)
        Next
        Try
            WMP.currentPlaylist = PlayList
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Lista.Enabled = True
        BtnPlay.Visible = False
        BtnPause.Visible = True

    End Sub

    Private Sub Lista_DoubleClick(sender As Object, e As EventArgs) Handles Lista.DoubleClick
        Try
            WMP.Ctlcontrols.playItem(PlayList.Item(Lista.SelectedIndex))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("¿Deseas salir de la aplicacion?", vbYesNo, "Cerrar") = vbYes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnPause.Visible = False
    End Sub
    Private Sub BtnStop_Click(sender As Object, e As EventArgs)
        WMP.Ctlcontrols.stop()
        BtnPause.Visible = False
        BtnPlay.Visible = True
    End Sub

    Private Sub BtnAnt_Click_1(sender As Object, e As EventArgs)
        WMP.Ctlcontrols.previous()
    End Sub

    Private Sub BtnNext_Click_1(sender As Object, e As EventArgs)
        WMP.Ctlcontrols.next()
    End Sub

    Private Sub BtnVolMin_Click_1(sender As Object, e As EventArgs)
        WMP.settings.volume = WMP.settings.volume - 15
    End Sub

    Private Sub BtnVolUp_Click(sender As Object, e As EventArgs)
        WMP.settings.volume = WMP.settings.volume + 15
    End Sub

    Private Sub BtnPause_Click_1(sender As Object, e As EventArgs)
        WMP.Ctlcontrols.pause()
        BtnPause.Visible = False
        BtnPlay.Visible = True
    End Sub

    Private Sub BtnPlay_Click_1(sender As Object, e As EventArgs)
        WMP.Ctlcontrols.play()
        BtnPlay.Visible = False
        BtnPause.Visible = True
    End Sub

    Private Sub Minimizar()
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip("3000", "Informacion", "Reproductor Multimedia - Modo Oculto", ToolTipIcon.Info)

        End If
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs)
        Minimizar()
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Quieres abandonar la aplicacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.Yes Then
            NotifyIcon1.Visible = False
            Me.Close()
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Abaut.ShowDialog()
    End Sub

    Private Sub PalyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PalyToolStripMenuItem.Click
        WMP.Ctlcontrols.play()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        WMP.Ctlcontrols.pause()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        WMP.Ctlcontrols.stop()
    End Sub

    Private Sub AnteriorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnteriorToolStripMenuItem.Click
        WMP.Ctlcontrols.previous()
    End Sub

    Private Sub SiguienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiguienteToolStripMenuItem.Click
        WMP.Ctlcontrols.next()
    End Sub

    Private Sub VolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolToolStripMenuItem.Click
        WMP.settings.volume = WMP.settings.volume + 15
    End Sub

    Private Sub VolToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VolToolStripMenuItem1.Click
        WMP.settings.volume = WMP.settings.volume - 15
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAdd_Click_1(sender As Object, e As EventArgs) Handles BtnAdd.Click
        OFileD.ShowDialog()
    End Sub

    Private Sub BtnVolMin_Click(sender As Object, e As EventArgs) Handles BtnVolMin.Click
        WMP.settings.volume = WMP.settings.volume - 15
    End Sub

    Private Sub BtnVolUp_Click_1(sender As Object, e As EventArgs) Handles BtnVolUp.Click
        WMP.settings.volume = WMP.settings.volume + 15
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        WMP.Ctlcontrols.next()
    End Sub

    Private Sub BtnAnt_Click(sender As Object, e As EventArgs) Handles BtnAnt.Click
        WMP.Ctlcontrols.previous()
    End Sub

    Private Sub BtnStop_Click_1(sender As Object, e As EventArgs) Handles BtnStop.Click
        WMP.Ctlcontrols.stop()
        BtnPause.Visible = False
        BtnPlay.Visible = True
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        WMP.Ctlcontrols.pause()
        BtnPause.Visible = False
        BtnPlay.Visible = True
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        WMP.Ctlcontrols.play()
        BtnPlay.Visible = False
        BtnPause.Visible = True
    End Sub
End Class

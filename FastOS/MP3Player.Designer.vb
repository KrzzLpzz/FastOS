<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MP3Player
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MP3Player))
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PalyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnteriorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiguienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFileD = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.BtnAbaut = New System.Windows.Forms.Button()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnVolUp = New System.Windows.Forms.Button()
        Me.BtnVolMin = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnAnt = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lista
        '
        Me.Lista.BackColor = System.Drawing.Color.Gray
        Me.Lista.Enabled = False
        Me.Lista.ForeColor = System.Drawing.SystemColors.Info
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(361, 12)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(178, 277)
        Me.Lista.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Lista, "Lista de reproduccion")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Reproductor MP3"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaurarToolStripMenuItem, Me.OcultarToolStripMenuItem, Me.ToolStripSeparator2, Me.AcercaDeToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 104)
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.RestaurarToolStripMenuItem.Text = "&Restaurar"
        '
        'OcultarToolStripMenuItem
        '
        Me.OcultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PalyToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StopToolStripMenuItem, Me.AnteriorToolStripMenuItem, Me.SiguienteToolStripMenuItem, Me.VolToolStripMenuItem, Me.VolToolStripMenuItem1})
        Me.OcultarToolStripMenuItem.Name = "OcultarToolStripMenuItem"
        Me.OcultarToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OcultarToolStripMenuItem.Text = "&Controles"
        '
        'PalyToolStripMenuItem
        '
        Me.PalyToolStripMenuItem.Name = "PalyToolStripMenuItem"
        Me.PalyToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PalyToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'AnteriorToolStripMenuItem
        '
        Me.AnteriorToolStripMenuItem.Name = "AnteriorToolStripMenuItem"
        Me.AnteriorToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AnteriorToolStripMenuItem.Text = "Anterior"
        '
        'SiguienteToolStripMenuItem
        '
        Me.SiguienteToolStripMenuItem.Name = "SiguienteToolStripMenuItem"
        Me.SiguienteToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SiguienteToolStripMenuItem.Text = "Siguiente"
        '
        'VolToolStripMenuItem
        '
        Me.VolToolStripMenuItem.Name = "VolToolStripMenuItem"
        Me.VolToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.VolToolStripMenuItem.Text = "Vol (+)"
        '
        'VolToolStripMenuItem1
        '
        Me.VolToolStripMenuItem1.Name = "VolToolStripMenuItem1"
        Me.VolToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.VolToolStripMenuItem1.Text = "Vol ( - )"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(135, 6)
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de ..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'OFileD
        '
        Me.OFileD.Filter = "Audio(*.mp3;*.wav;*.cda)|*.mp3;*.wav;*.cda|Video(*.Avi)|*.avi|Todos los archivo|*" &
    ".*"
        Me.OFileD.InitialDirectory = "C:\"
        Me.OFileD.Multiselect = True
        Me.OFileD.Title = "Selecion de archivos"
        '
        'WMP
        '
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(3, 12)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(352, 277)
        Me.WMP.TabIndex = 12
        '
        'BtnAbaut
        '
        Me.BtnAbaut.Location = New System.Drawing.Point(499, 302)
        Me.BtnAbaut.Name = "BtnAbaut"
        Me.BtnAbaut.Size = New System.Drawing.Size(41, 41)
        Me.BtnAbaut.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.BtnAbaut, "Acerca de ...")
        Me.BtnAbaut.UseVisualStyleBackColor = True
        Me.BtnAbaut.Visible = False
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Location = New System.Drawing.Point(452, 302)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(41, 41)
        Me.BtnMinimize.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.BtnMinimize, "Modo oculto")
        Me.BtnMinimize.UseVisualStyleBackColor = True
        Me.BtnMinimize.Visible = False
        '
        'BtnVolUp
        '
        Me.BtnVolUp.BackgroundImage = Global.FastOS.My.Resources.Resources.sound_increase
        Me.BtnVolUp.Location = New System.Drawing.Point(306, 295)
        Me.BtnVolUp.Name = "BtnVolUp"
        Me.BtnVolUp.Size = New System.Drawing.Size(52, 55)
        Me.BtnVolUp.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.BtnVolUp, "Subir Volumen")
        Me.BtnVolUp.UseVisualStyleBackColor = True
        '
        'BtnVolMin
        '
        Me.BtnVolMin.BackgroundImage = Global.FastOS.My.Resources.Resources.sound_decrease
        Me.BtnVolMin.Location = New System.Drawing.Point(248, 295)
        Me.BtnVolMin.Name = "BtnVolMin"
        Me.BtnVolMin.Size = New System.Drawing.Size(52, 55)
        Me.BtnVolMin.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.BtnVolMin, "Bajar Volumen")
        Me.BtnVolMin.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.BackgroundImage = Global.FastOS.My.Resources.Resources._stop
        Me.BtnStop.Location = New System.Drawing.Point(64, 295)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(52, 55)
        Me.BtnStop.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.BtnStop, "Stop")
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.BackgroundImage = Global.FastOS.My.Resources.Resources.next_
        Me.BtnNext.Location = New System.Drawing.Point(179, 295)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(53, 55)
        Me.BtnNext.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.BtnNext, "Siguiente")
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnAnt
        '
        Me.BtnAnt.BackgroundImage = Global.FastOS.My.Resources.Resources.back1
        Me.BtnAnt.Location = New System.Drawing.Point(121, 295)
        Me.BtnAnt.Name = "BtnAnt"
        Me.BtnAnt.Size = New System.Drawing.Size(53, 55)
        Me.BtnAnt.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.BtnAnt, "Anterior")
        Me.BtnAnt.UseVisualStyleBackColor = True
        '
        'BtnPause
        '
        Me.BtnPause.BackgroundImage = Global.FastOS.My.Resources.Resources.pause
        Me.BtnPause.Location = New System.Drawing.Point(6, 295)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(52, 55)
        Me.BtnPause.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BtnPause, "Pause")
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'BtnPlay
        '
        Me.BtnPlay.BackgroundImage = Global.FastOS.My.Resources.Resources.play
        Me.BtnPlay.Location = New System.Drawing.Point(6, 295)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(52, 55)
        Me.BtnPlay.TabIndex = 25
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.BackgroundImage = Global.FastOS.My.Resources.Resources.download_for_windows
        Me.BtnAdd.Location = New System.Drawing.Point(386, 302)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(41, 41)
        Me.BtnAdd.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.BtnAdd, "Abrir Archivos multimedia")
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'MP3Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 352)
        Me.Controls.Add(Me.BtnVolUp)
        Me.Controls.Add(Me.BtnVolMin)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnAnt)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.BtnAbaut)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.WMP)
        Me.Controls.Add(Me.Lista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MP3Player"
        Me.Text = "Media Player"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lista As System.Windows.Forms.ListBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents OFileD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestaurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OcultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PalyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnteriorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SiguienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BtnVolUp As Button
    Friend WithEvents BtnVolMin As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnAnt As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents BtnPlay As Button
    Friend WithEvents BtnAbaut As Button
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnAdd As Button
End Class

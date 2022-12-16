<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.Navigation = New System.Windows.Forms.ToolStrip()
        Me.Retroceder = New System.Windows.Forms.ToolStripButton()
        Me.Avanzar = New System.Windows.Forms.ToolStripButton()
        Me.Actualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BarraDeBusqueda = New System.Windows.Forms.ToolStripTextBox()
        Me.Ir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WebBrowser = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Navigation.SuspendLayout()
        CType(Me.WebBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Navigation
        '
        Me.Navigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Retroceder, Me.Avanzar, Me.Actualizar, Me.ToolStripSeparator1, Me.BarraDeBusqueda, Me.Ir, Me.ToolStripSeparator2})
        Me.Navigation.Location = New System.Drawing.Point(0, 0)
        Me.Navigation.Name = "Navigation"
        Me.Navigation.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Navigation.Size = New System.Drawing.Size(603, 25)
        Me.Navigation.TabIndex = 0
        Me.Navigation.Text = "Navigation"
        '
        'Retroceder
        '
        Me.Retroceder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Retroceder.Image = Global.FastOS.My.Resources.Resources.bck
        Me.Retroceder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Retroceder.Name = "Retroceder"
        Me.Retroceder.Size = New System.Drawing.Size(23, 22)
        Me.Retroceder.Text = "Volver Atrás"
        '
        'Avanzar
        '
        Me.Avanzar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Avanzar.Image = Global.FastOS.My.Resources.Resources.forward
        Me.Avanzar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Avanzar.Name = "Avanzar"
        Me.Avanzar.Size = New System.Drawing.Size(23, 22)
        Me.Avanzar.Text = "Continuar"
        '
        'Actualizar
        '
        Me.Actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Actualizar.Image = Global.FastOS.My.Resources.Resources.refresh2
        Me.Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(23, 22)
        Me.Actualizar.Text = "Recargar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BarraDeBusqueda
        '
        Me.BarraDeBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarraDeBusqueda.Name = "BarraDeBusqueda"
        Me.BarraDeBusqueda.Size = New System.Drawing.Size(360, 25)
        '
        'Ir
        '
        Me.Ir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ir.Image = Global.FastOS.My.Resources.Resources.go
        Me.Ir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ir.Name = "Ir"
        Me.Ir.Size = New System.Drawing.Size(23, 22)
        Me.Ir.Text = "ToolStripButton5"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'WebBrowser
        '
        Me.WebBrowser.AllowExternalDrop = True
        Me.WebBrowser.CreationProperties = Nothing
        Me.WebBrowser.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.Location = New System.Drawing.Point(0, 25)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(603, 323)
        Me.WebBrowser.TabIndex = 1
        Me.WebBrowser.ZoomFactor = 1.0R
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 348)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.Navigation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(619, 387)
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browser"
        Me.Navigation.ResumeLayout(False)
        Me.Navigation.PerformLayout()
        CType(Me.WebBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Navigation As ToolStrip
    Friend WithEvents Retroceder As ToolStripButton
    Friend WithEvents Avanzar As ToolStripButton
    Friend WithEvents Actualizar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BarraDeBusqueda As ToolStripTextBox
    Friend WithEvents Ir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents WebBrowser As Microsoft.Web.WebView2.WinForms.WebView2
End Class

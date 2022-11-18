<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionartodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContenidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbEditor = New System.Windows.Forms.RichTextBox()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlejarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstilosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem1, Me.toolStripSeparator, Me.GuardarToolStripMenuItem1, Me.ActualizarToolStripMenuItem1, Me.toolStripSeparator1, Me.SalirToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'AbrirToolStripMenuItem1
        '
        Me.AbrirToolStripMenuItem1.Image = CType(resources.GetObject("AbrirToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripMenuItem1.Name = "AbrirToolStripMenuItem1"
        Me.AbrirToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.AbrirToolStripMenuItem1.Text = "&Abrir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(186, 6)
        '
        'GuardarToolStripMenuItem1
        '
        Me.GuardarToolStripMenuItem1.Image = CType(resources.GetObject("GuardarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripMenuItem1.Name = "GuardarToolStripMenuItem1"
        Me.GuardarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.GuardarToolStripMenuItem1.Text = "&Guardar"
        '
        'ActualizarToolStripMenuItem1
        '
        Me.ActualizarToolStripMenuItem1.Name = "ActualizarToolStripMenuItem1"
        Me.ActualizarToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ActualizarToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.ActualizarToolStripMenuItem1.Text = "&Actualizar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.SalirToolStripMenuItem1.Text = "&Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.toolStripSeparator3, Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem1, Me.PegarToolStripMenuItem1, Me.toolStripSeparator4, Me.SeleccionartodoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeshacerToolStripMenuItem.Text = "&Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RehacerToolStripMenuItem.Text = "&Rehacer"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Image = CType(resources.GetObject("CortarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CortarToolStripMenuItem.Text = "Cor&tar"
        '
        'CopiarToolStripMenuItem1
        '
        Me.CopiarToolStripMenuItem1.Image = CType(resources.GetObject("CopiarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripMenuItem1.Name = "CopiarToolStripMenuItem1"
        Me.CopiarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CopiarToolStripMenuItem1.Text = "&Copiar"
        '
        'PegarToolStripMenuItem1
        '
        Me.PegarToolStripMenuItem1.Image = CType(resources.GetObject("PegarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PegarToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripMenuItem1.Name = "PegarToolStripMenuItem1"
        Me.PegarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PegarToolStripMenuItem1.Text = "&Pegar"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(160, 6)
        '
        'SeleccionartodoToolStripMenuItem
        '
        Me.SeleccionartodoToolStripMenuItem.Name = "SeleccionartodoToolStripMenuItem"
        Me.SeleccionartodoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SeleccionartodoToolStripMenuItem.Text = "&Seleccionar todo"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizarToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Enabled = False
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'PersonalizarToolStripMenuItem
        '
        Me.PersonalizarToolStripMenuItem.Name = "PersonalizarToolStripMenuItem"
        Me.PersonalizarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PersonalizarToolStripMenuItem.Text = "&Personalizar"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContenidoToolStripMenuItem, Me.ÍndiceToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.toolStripSeparator5, Me.AcercadeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Enabled = False
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'ContenidoToolStripMenuItem
        '
        Me.ContenidoToolStripMenuItem.Name = "ContenidoToolStripMenuItem"
        Me.ContenidoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ContenidoToolStripMenuItem.Text = "&Contenido"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ÍndiceToolStripMenuItem.Text = "Índic&e"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.BuscarToolStripMenuItem.Text = "&Buscar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(132, 6)
        '
        'AcercadeToolStripMenuItem
        '
        Me.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem"
        Me.AcercadeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercadeToolStripMenuItem.Text = "&Acerca de..."
        '
        'rtbEditor
        '
        Me.rtbEditor.Location = New System.Drawing.Point(0, 60)
        Me.rtbEditor.Name = "rtbEditor"
        Me.rtbEditor.Size = New System.Drawing.Size(686, 330)
        Me.rtbEditor.TabIndex = 1
        Me.rtbEditor.Text = ""
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'AcercarToolStripMenuItem
        '
        Me.AcercarToolStripMenuItem.Name = "AcercarToolStripMenuItem"
        Me.AcercarToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AcercarToolStripMenuItem.Text = "Acercar"
        '
        'AlejarToolStripMenuItem
        '
        Me.AlejarToolStripMenuItem.Name = "AlejarToolStripMenuItem"
        Me.AlejarToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AlejarToolStripMenuItem.Text = "Alejar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'EstilosToolStripMenuItem
        '
        Me.EstilosToolStripMenuItem.Name = "EstilosToolStripMenuItem"
        Me.EstilosToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.EstilosToolStripMenuItem.Text = "Estilos"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTitulo)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 27)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre del Archivo:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(122, 3)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(539, 20)
        Me.txtTitulo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 454)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 514)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rtbEditor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TextEditor"
        Me.Text = "TextEditor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents rtbEditor As RichTextBox
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SeleccionartodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContenidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AcercadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlejarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstilosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FontDialog1 As FontDialog
End Class

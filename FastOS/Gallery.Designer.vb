<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gallery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gallery))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvImagenes = New System.Windows.Forms.DataGridView()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.LblGID = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCamara = New System.Windows.Forms.Button()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombreImagen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picCamera = New System.Windows.Forms.PictureBox()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        CType(Me.dgvImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Listado de imágenes"
        '
        'dgvImagenes
        '
        Me.dgvImagenes.AllowUserToAddRows = False
        Me.dgvImagenes.AllowUserToResizeColumns = False
        Me.dgvImagenes.AllowUserToResizeRows = False
        Me.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImagenes.Location = New System.Drawing.Point(317, 63)
        Me.dgvImagenes.MultiSelect = False
        Me.dgvImagenes.Name = "dgvImagenes"
        Me.dgvImagenes.ReadOnly = True
        Me.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvImagenes.Size = New System.Drawing.Size(280, 247)
        Me.dgvImagenes.TabIndex = 11
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(198, 4)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(85, 28)
        Me.btnExaminar.TabIndex = 7
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(380, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'LblGID
        '
        Me.LblGID.AutoSize = True
        Me.LblGID.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblGID.Location = New System.Drawing.Point(12, 9)
        Me.LblGID.Name = "LblGID"
        Me.LblGID.Size = New System.Drawing.Size(39, 13)
        Me.LblGID.TabIndex = 13
        Me.LblGID.Text = "Label1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Galería de Imágenes"
        '
        'btnCamara
        '
        Me.btnCamara.Location = New System.Drawing.Point(16, 4)
        Me.btnCamara.Name = "btnCamara"
        Me.btnCamara.Size = New System.Drawing.Size(85, 28)
        Me.btnCamara.TabIndex = 15
        Me.btnCamara.Text = "Camara"
        Me.btnCamara.UseVisualStyleBackColor = True
        '
        'btnCapturar
        '
        Me.btnCapturar.Enabled = False
        Me.btnCapturar.Location = New System.Drawing.Point(107, 4)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(85, 28)
        Me.btnCapturar.TabIndex = 16
        Me.btnCapturar.Text = "Capturar"
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Location = New System.Drawing.Point(289, 4)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(85, 28)
        Me.btnVaciar.TabIndex = 17
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(471, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(85, 28)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCamara)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnCapturar)
        Me.Panel1.Controls.Add(Me.btnVaciar)
        Me.Panel1.Controls.Add(Me.btnExaminar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(25, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 37)
        Me.Panel1.TabIndex = 19
        '
        'txtNombreImagen
        '
        Me.txtNombreImagen.Location = New System.Drawing.Point(139, 290)
        Me.txtNombreImagen.Name = "txtNombreImagen"
        Me.txtNombreImagen.Size = New System.Drawing.Size(172, 20)
        Me.txtNombreImagen.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre de la Imagen:"
        '
        'picCamera
        '
        Me.picCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCamera.Location = New System.Drawing.Point(25, 40)
        Me.picCamera.Name = "picCamera"
        Me.picCamera.Size = New System.Drawing.Size(286, 244)
        Me.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCamera.TabIndex = 22
        Me.picCamera.TabStop = False
        Me.picCamera.Visible = False
        '
        'picImagen
        '
        Me.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImagen.Location = New System.Drawing.Point(25, 40)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(286, 244)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImagen.TabIndex = 6
        Me.picImagen.TabStop = False
        '
        'Gallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 362)
        Me.Controls.Add(Me.picCamera)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreImagen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblGID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvImagenes)
        Me.Controls.Add(Me.picImagen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(634, 401)
        Me.MinimumSize = New System.Drawing.Size(634, 401)
        Me.Name = "Gallery"
        Me.Text = "Galeria"
        CType(Me.dgvImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvImagenes As DataGridView
    Friend WithEvents btnExaminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents picImagen As PictureBox
    Friend WithEvents LblGID As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCamara As Button
    Friend WithEvents btnCapturar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombreImagen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents picCamera As PictureBox
End Class

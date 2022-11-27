<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadTXT
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvFiles = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIdFile = New System.Windows.Forms.Label()
        Me.lblTID = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFiles
        '
        Me.dgvFiles.AllowUserToAddRows = False
        Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NameFile, Me.File})
        Me.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFiles.Location = New System.Drawing.Point(0, 0)
        Me.dgvFiles.Name = "dgvFiles"
        Me.dgvFiles.Size = New System.Drawing.Size(398, 229)
        Me.dgvFiles.TabIndex = 0
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'NameFile
        '
        Me.NameFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NameFile.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameFile.HeaderText = "Nombre del Archivo"
        Me.NameFile.Name = "NameFile"
        '
        'File
        '
        Me.File.HeaderText = "Archivo"
        Me.File.Name = "File"
        Me.File.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblIdFile)
        Me.Panel1.Controls.Add(Me.lblTID)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAbrir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 41)
        Me.Panel1.TabIndex = 1
        '
        'lblIdFile
        '
        Me.lblIdFile.AutoSize = True
        Me.lblIdFile.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblIdFile.Location = New System.Drawing.Point(49, 25)
        Me.lblIdFile.Name = "lblIdFile"
        Me.lblIdFile.Size = New System.Drawing.Size(39, 13)
        Me.lblIdFile.TabIndex = 3
        Me.lblIdFile.Text = "Label1"
        '
        'lblTID
        '
        Me.lblTID.AutoSize = True
        Me.lblTID.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTID.Location = New System.Drawing.Point(4, 25)
        Me.lblTID.Name = "lblTID"
        Me.lblTID.Size = New System.Drawing.Size(39, 13)
        Me.lblTID.TabIndex = 2
        Me.lblTID.Text = "Label1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(202, 9)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(121, 9)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrir.TabIndex = 0
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'DownloadTXT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 229)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvFiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DownloadTXT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DownloadTXT"
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvFiles As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents lblTID As Label
    Friend WithEvents lblIdFile As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents NameFile As DataGridViewTextBoxColumn
    Friend WithEvents File As DataGridViewTextBoxColumn
End Class

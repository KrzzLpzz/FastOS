<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gpbExistentes = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.chkMostrarContra = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRContra = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblContra = New System.Windows.Forms.Label()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.cboPrivilegios = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gpbNuevo = New System.Windows.Forms.GroupBox()
        Me.chkMostrarNContra = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRNContra = New System.Windows.Forms.TextBox()
        Me.lblNuevaContra = New System.Windows.Forms.Label()
        Me.lblNuevoUser = New System.Windows.Forms.Label()
        Me.btnNLimpiar = New System.Windows.Forms.Button()
        Me.lblNuevoPrivilegio = New System.Windows.Forms.Label()
        Me.txtNContra = New System.Windows.Forms.TextBox()
        Me.txtNUser = New System.Windows.Forms.TextBox()
        Me.cboNPrivilegio = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblSaveNew = New System.Windows.Forms.Label()
        Me.LblUID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.gpbExistentes.SuspendLayout()
        Me.gpbNuevo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(125, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(217, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Administracion de Usuarios"
        '
        'gpbExistentes
        '
        Me.gpbExistentes.Controls.Add(Me.btnLimpiar)
        Me.gpbExistentes.Controls.Add(Me.chkMostrarContra)
        Me.gpbExistentes.Controls.Add(Me.Label1)
        Me.gpbExistentes.Controls.Add(Me.txtRContra)
        Me.gpbExistentes.Controls.Add(Me.btnEliminar)
        Me.gpbExistentes.Controls.Add(Me.btnActualizar)
        Me.gpbExistentes.Controls.Add(Me.Label4)
        Me.gpbExistentes.Controls.Add(Me.LblContra)
        Me.gpbExistentes.Controls.Add(Me.txtContra)
        Me.gpbExistentes.Controls.Add(Me.Label2)
        Me.gpbExistentes.Controls.Add(Me.txtUser)
        Me.gpbExistentes.Controls.Add(Me.cboPrivilegios)
        Me.gpbExistentes.Controls.Add(Me.btnBuscar)
        Me.gpbExistentes.Location = New System.Drawing.Point(10, 33)
        Me.gpbExistentes.Name = "gpbExistentes"
        Me.gpbExistentes.Size = New System.Drawing.Size(446, 91)
        Me.gpbExistentes.TabIndex = 1
        Me.gpbExistentes.TabStop = False
        Me.gpbExistentes.Text = "Usuarios Existentes"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(234, 57)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 20)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'chkMostrarContra
        '
        Me.chkMostrarContra.AutoSize = True
        Me.chkMostrarContra.Location = New System.Drawing.Point(304, 60)
        Me.chkMostrarContra.Name = "chkMostrarContra"
        Me.chkMostrarContra.Size = New System.Drawing.Size(118, 17)
        Me.chkMostrarContra.TabIndex = 8
        Me.chkMostrarContra.Text = "Mostrar Contraseña"
        Me.chkMostrarContra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Repetir Contraseña:"
        '
        'txtRContra
        '
        Me.txtRContra.Location = New System.Drawing.Point(200, 31)
        Me.txtRContra.Name = "txtRContra"
        Me.txtRContra.Size = New System.Drawing.Size(101, 20)
        Me.txtRContra.TabIndex = 7
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(164, 57)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 20)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(95, 57)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(64, 20)
        Me.btnActualizar.TabIndex = 4
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Privilegios:"
        '
        'LblContra
        '
        Me.LblContra.AutoSize = True
        Me.LblContra.Location = New System.Drawing.Point(109, 15)
        Me.LblContra.Name = "LblContra"
        Me.LblContra.Size = New System.Drawing.Size(64, 13)
        Me.LblContra.TabIndex = 3
        Me.LblContra.Text = "Contraseña:"
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(109, 31)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(86, 20)
        Me.txtContra.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(18, 31)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(86, 20)
        Me.txtUser.TabIndex = 2
        '
        'cboPrivilegios
        '
        Me.cboPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrivilegios.FormattingEnabled = True
        Me.cboPrivilegios.Items.AddRange(New Object() {"Seleccionar", "Administrador", "Usuario"})
        Me.cboPrivilegios.Location = New System.Drawing.Point(307, 31)
        Me.cboPrivilegios.Name = "cboPrivilegios"
        Me.cboPrivilegios.Size = New System.Drawing.Size(104, 21)
        Me.cboPrivilegios.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(25, 57)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 20)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gpbNuevo
        '
        Me.gpbNuevo.Controls.Add(Me.chkMostrarNContra)
        Me.gpbNuevo.Controls.Add(Me.Label3)
        Me.gpbNuevo.Controls.Add(Me.txtRNContra)
        Me.gpbNuevo.Controls.Add(Me.lblNuevaContra)
        Me.gpbNuevo.Controls.Add(Me.lblNuevoUser)
        Me.gpbNuevo.Controls.Add(Me.btnNLimpiar)
        Me.gpbNuevo.Controls.Add(Me.lblNuevoPrivilegio)
        Me.gpbNuevo.Controls.Add(Me.txtNContra)
        Me.gpbNuevo.Controls.Add(Me.txtNUser)
        Me.gpbNuevo.Controls.Add(Me.cboNPrivilegio)
        Me.gpbNuevo.Controls.Add(Me.btnRegistrar)
        Me.gpbNuevo.Location = New System.Drawing.Point(10, 130)
        Me.gpbNuevo.Name = "gpbNuevo"
        Me.gpbNuevo.Size = New System.Drawing.Size(446, 100)
        Me.gpbNuevo.TabIndex = 6
        Me.gpbNuevo.TabStop = False
        Me.gpbNuevo.Text = "Nuevo Usuario"
        '
        'chkMostrarNContra
        '
        Me.chkMostrarNContra.AutoSize = True
        Me.chkMostrarNContra.Location = New System.Drawing.Point(234, 64)
        Me.chkMostrarNContra.Name = "chkMostrarNContra"
        Me.chkMostrarNContra.Size = New System.Drawing.Size(118, 17)
        Me.chkMostrarNContra.TabIndex = 10
        Me.chkMostrarNContra.Text = "Mostrar Contraseña"
        Me.chkMostrarNContra.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Repetir Contraseña:"
        '
        'txtRNContra
        '
        Me.txtRNContra.Location = New System.Drawing.Point(201, 36)
        Me.txtRNContra.Name = "txtRNContra"
        Me.txtRNContra.Size = New System.Drawing.Size(100, 20)
        Me.txtRNContra.TabIndex = 8
        '
        'lblNuevaContra
        '
        Me.lblNuevaContra.AutoSize = True
        Me.lblNuevaContra.Location = New System.Drawing.Point(109, 20)
        Me.lblNuevaContra.Name = "lblNuevaContra"
        Me.lblNuevaContra.Size = New System.Drawing.Size(64, 13)
        Me.lblNuevaContra.TabIndex = 7
        Me.lblNuevaContra.Text = "Contraseña:"
        '
        'lblNuevoUser
        '
        Me.lblNuevoUser.AutoSize = True
        Me.lblNuevoUser.Location = New System.Drawing.Point(18, 20)
        Me.lblNuevoUser.Name = "lblNuevoUser"
        Me.lblNuevoUser.Size = New System.Drawing.Size(46, 13)
        Me.lblNuevoUser.TabIndex = 6
        Me.lblNuevoUser.Text = "Usuario:"
        '
        'btnNLimpiar
        '
        Me.btnNLimpiar.Location = New System.Drawing.Point(164, 61)
        Me.btnNLimpiar.Name = "btnNLimpiar"
        Me.btnNLimpiar.Size = New System.Drawing.Size(64, 20)
        Me.btnNLimpiar.TabIndex = 4
        Me.btnNLimpiar.Text = "Limpiar"
        Me.btnNLimpiar.UseVisualStyleBackColor = True
        '
        'lblNuevoPrivilegio
        '
        Me.lblNuevoPrivilegio.AutoSize = True
        Me.lblNuevoPrivilegio.Location = New System.Drawing.Point(307, 19)
        Me.lblNuevoPrivilegio.Name = "lblNuevoPrivilegio"
        Me.lblNuevoPrivilegio.Size = New System.Drawing.Size(57, 13)
        Me.lblNuevoPrivilegio.TabIndex = 2
        Me.lblNuevoPrivilegio.Text = "Privilegios:"
        '
        'txtNContra
        '
        Me.txtNContra.Location = New System.Drawing.Point(109, 36)
        Me.txtNContra.Name = "txtNContra"
        Me.txtNContra.Size = New System.Drawing.Size(86, 20)
        Me.txtNContra.TabIndex = 3
        '
        'txtNUser
        '
        Me.txtNUser.Location = New System.Drawing.Point(18, 36)
        Me.txtNUser.Name = "txtNUser"
        Me.txtNUser.Size = New System.Drawing.Size(86, 20)
        Me.txtNUser.TabIndex = 2
        '
        'cboNPrivilegio
        '
        Me.cboNPrivilegio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNPrivilegio.FormattingEnabled = True
        Me.cboNPrivilegio.Items.AddRange(New Object() {"Seleccionar", "Administrador", "Usuario"})
        Me.cboNPrivilegio.Location = New System.Drawing.Point(307, 36)
        Me.cboNPrivilegio.Name = "cboNPrivilegio"
        Me.cboNPrivilegio.Size = New System.Drawing.Size(104, 21)
        Me.cboNPrivilegio.TabIndex = 1
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(95, 61)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(64, 20)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblSaveNew
        '
        Me.lblSaveNew.AutoSize = True
        Me.lblSaveNew.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSaveNew.Location = New System.Drawing.Point(210, 127)
        Me.lblSaveNew.Name = "lblSaveNew"
        Me.lblSaveNew.Size = New System.Drawing.Size(39, 13)
        Me.lblSaveNew.TabIndex = 7
        Me.lblSaveNew.Text = "Label1"
        Me.lblSaveNew.Visible = False
        '
        'LblUID
        '
        Me.LblUID.AutoSize = True
        Me.LblUID.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblUID.Location = New System.Drawing.Point(255, 127)
        Me.LblUID.Name = "LblUID"
        Me.LblUID.Size = New System.Drawing.Size(39, 13)
        Me.LblUID.TabIndex = 8
        Me.LblUID.Text = "Label1"
        Me.LblUID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAplicar)
        Me.Panel1.Controls.Add(Me.btnSeleccionar)
        Me.Panel1.Controls.Add(Me.pic6)
        Me.Panel1.Controls.Add(Me.pic5)
        Me.Panel1.Controls.Add(Me.pic4)
        Me.Panel1.Controls.Add(Me.pic3)
        Me.Panel1.Controls.Add(Me.pic2)
        Me.Panel1.Controls.Add(Me.pic1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.LblUID)
        Me.Panel1.Controls.Add(Me.gpbExistentes)
        Me.Panel1.Controls.Add(Me.lblSaveNew)
        Me.Panel1.Controls.Add(Me.gpbNuevo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 247)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fondo de Pantalla"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(115, 440)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 43)
        Me.btnSeleccionar.TabIndex = 16
        Me.btnSeleccionar.Text = "Seleccionar Imagen"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(196, 440)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 43)
        Me.btnAplicar.TabIndex = 17
        Me.btnAplicar.Text = "Aplicar Cambios"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(277, 440)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 43)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(216, 478)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Label6"
        '
        'pic6
        '
        Me.pic6.Image = Global.FastOS.My.Resources.Resources.TouchKeyboardThemeDark003
        Me.pic6.Location = New System.Drawing.Point(306, 358)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(133, 75)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic6.TabIndex = 15
        Me.pic6.TabStop = False
        '
        'pic5
        '
        Me.pic5.Image = Global.FastOS.My.Resources.Resources.img104
        Me.pic5.Location = New System.Drawing.Point(167, 358)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(133, 75)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic5.TabIndex = 14
        Me.pic5.TabStop = False
        '
        'pic4
        '
        Me.pic4.Image = Global.FastOS.My.Resources.Resources.img102
        Me.pic4.Location = New System.Drawing.Point(28, 358)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(133, 75)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic4.TabIndex = 13
        Me.pic4.TabStop = False
        '
        'pic3
        '
        Me.pic3.Image = Global.FastOS.My.Resources.Resources.img101
        Me.pic3.Location = New System.Drawing.Point(306, 277)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(133, 75)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic3.TabIndex = 12
        Me.pic3.TabStop = False
        '
        'pic2
        '
        Me.pic2.Image = Global.FastOS.My.Resources.Resources.img100
        Me.pic2.Location = New System.Drawing.Point(167, 277)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(133, 75)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2.TabIndex = 11
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.FastOS.My.Resources.Resources.img103
        Me.pic1.Location = New System.Drawing.Point(28, 277)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(133, 75)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 10
        Me.pic1.TabStop = False
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 247)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(500, 535)
        Me.MinimumSize = New System.Drawing.Size(500, 286)
        Me.Name = "Users"
        Me.Text = "Users"
        Me.gpbExistentes.ResumeLayout(False)
        Me.gpbExistentes.PerformLayout()
        Me.gpbNuevo.ResumeLayout(False)
        Me.gpbNuevo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gpbExistentes As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Private WithEvents Label4 As Label
    Friend WithEvents LblContra As Label
    Friend WithEvents txtContra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents cboPrivilegios As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents gpbNuevo As GroupBox
    Friend WithEvents btnNLimpiar As Button
    Friend WithEvents lblNuevoPrivilegio As Label
    Friend WithEvents txtNContra As TextBox
    Friend WithEvents txtNUser As TextBox
    Friend WithEvents cboNPrivilegio As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblNuevaContra As Label
    Friend WithEvents lblNuevoUser As Label
    Friend WithEvents lblSaveNew As Label
    Friend WithEvents LblUID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRContra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRNContra As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents chkMostrarContra As CheckBox
    Friend WithEvents chkMostrarNContra As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAplicar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.Screen2 = New System.Windows.Forms.Panel()
        Me.btnSnake = New System.Windows.Forms.Button()
        Me.btnTresEnRaya = New System.Windows.Forms.Button()
        Me.btnCalculadora = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnNavegador = New System.Windows.Forms.Button()
        Me.btnEditorTexto = New System.Windows.Forms.Button()
        Me.btnGaleria = New System.Windows.Forms.Button()
        Me.lblUsernameSave = New System.Windows.Forms.Label()
        Me.lblUserSave = New System.Windows.Forms.Label()
        Me.BtnAdminUsers = New System.Windows.Forms.Button()
        Me.btnTxtLoad = New System.Windows.Forms.Button()
        Me.Screen2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Screen2
        '
        Me.Screen2.Controls.Add(Me.btnTxtLoad)
        Me.Screen2.Controls.Add(Me.btnSnake)
        Me.Screen2.Controls.Add(Me.btnTresEnRaya)
        Me.Screen2.Controls.Add(Me.btnCalculadora)
        Me.Screen2.Controls.Add(Me.btnCerrarSesion)
        Me.Screen2.Controls.Add(Me.btnNavegador)
        Me.Screen2.Controls.Add(Me.btnEditorTexto)
        Me.Screen2.Controls.Add(Me.btnGaleria)
        Me.Screen2.Controls.Add(Me.lblUsernameSave)
        Me.Screen2.Controls.Add(Me.lblUserSave)
        Me.Screen2.Controls.Add(Me.BtnAdminUsers)
        Me.Screen2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Screen2.Location = New System.Drawing.Point(0, 0)
        Me.Screen2.Name = "Screen2"
        Me.Screen2.Size = New System.Drawing.Size(1083, 590)
        Me.Screen2.TabIndex = 1
        '
        'btnSnake
        '
        Me.btnSnake.Location = New System.Drawing.Point(10, 374)
        Me.btnSnake.Name = "btnSnake"
        Me.btnSnake.Size = New System.Drawing.Size(87, 55)
        Me.btnSnake.TabIndex = 9
        Me.btnSnake.Text = "Snake"
        Me.btnSnake.UseVisualStyleBackColor = True
        '
        'btnTresEnRaya
        '
        Me.btnTresEnRaya.Location = New System.Drawing.Point(10, 313)
        Me.btnTresEnRaya.Name = "btnTresEnRaya"
        Me.btnTresEnRaya.Size = New System.Drawing.Size(87, 55)
        Me.btnTresEnRaya.TabIndex = 8
        Me.btnTresEnRaya.Text = "Tres en Raya"
        Me.btnTresEnRaya.UseVisualStyleBackColor = True
        '
        'btnCalculadora
        '
        Me.btnCalculadora.Location = New System.Drawing.Point(10, 252)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(87, 55)
        Me.btnCalculadora.TabIndex = 7
        Me.btnCalculadora.Text = "Calculadora"
        Me.btnCalculadora.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(984, 523)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(87, 55)
        Me.btnCerrarSesion.TabIndex = 6
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnNavegador
        '
        Me.btnNavegador.Location = New System.Drawing.Point(10, 191)
        Me.btnNavegador.Name = "btnNavegador"
        Me.btnNavegador.Size = New System.Drawing.Size(87, 55)
        Me.btnNavegador.TabIndex = 5
        Me.btnNavegador.Text = "Navegador"
        Me.btnNavegador.UseVisualStyleBackColor = True
        '
        'btnEditorTexto
        '
        Me.btnEditorTexto.Location = New System.Drawing.Point(10, 130)
        Me.btnEditorTexto.Name = "btnEditorTexto"
        Me.btnEditorTexto.Size = New System.Drawing.Size(87, 55)
        Me.btnEditorTexto.TabIndex = 4
        Me.btnEditorTexto.Text = "Editor de Texto"
        Me.btnEditorTexto.UseVisualStyleBackColor = True
        '
        'btnGaleria
        '
        Me.btnGaleria.Location = New System.Drawing.Point(10, 70)
        Me.btnGaleria.Name = "btnGaleria"
        Me.btnGaleria.Size = New System.Drawing.Size(87, 55)
        Me.btnGaleria.TabIndex = 3
        Me.btnGaleria.Text = "Galeria"
        Me.btnGaleria.UseVisualStyleBackColor = True
        '
        'lblUsernameSave
        '
        Me.lblUsernameSave.AutoSize = True
        Me.lblUsernameSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblUsernameSave.Location = New System.Drawing.Point(987, 9)
        Me.lblUsernameSave.Name = "lblUsernameSave"
        Me.lblUsernameSave.Size = New System.Drawing.Size(39, 13)
        Me.lblUsernameSave.TabIndex = 2
        Me.lblUsernameSave.Text = "Label1"
        Me.lblUsernameSave.Visible = False
        '
        'lblUserSave
        '
        Me.lblUserSave.AutoSize = True
        Me.lblUserSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblUserSave.Location = New System.Drawing.Point(1032, 9)
        Me.lblUserSave.Name = "lblUserSave"
        Me.lblUserSave.Size = New System.Drawing.Size(39, 13)
        Me.lblUserSave.TabIndex = 1
        Me.lblUserSave.Text = "Label1"
        Me.lblUserSave.Visible = False
        '
        'BtnAdminUsers
        '
        Me.BtnAdminUsers.Location = New System.Drawing.Point(10, 10)
        Me.BtnAdminUsers.Name = "BtnAdminUsers"
        Me.BtnAdminUsers.Size = New System.Drawing.Size(87, 55)
        Me.BtnAdminUsers.TabIndex = 0
        Me.BtnAdminUsers.Text = "Administracion de Usuarios"
        Me.BtnAdminUsers.UseVisualStyleBackColor = True
        '
        'btnTxtLoad
        '
        Me.btnTxtLoad.Location = New System.Drawing.Point(103, 130)
        Me.btnTxtLoad.Name = "btnTxtLoad"
        Me.btnTxtLoad.Size = New System.Drawing.Size(87, 55)
        Me.btnTxtLoad.TabIndex = 10
        Me.btnTxtLoad.Text = "txtLoad"
        Me.btnTxtLoad.UseVisualStyleBackColor = True
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 590)
        Me.Controls.Add(Me.Screen2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.Text = "MainWindow"
        Me.Screen2.ResumeLayout(False)
        Me.Screen2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Screen2 As Panel
    Friend WithEvents BtnAdminUsers As Button
    Friend WithEvents lblUserSave As Label
    Friend WithEvents lblUsernameSave As Label
    Friend WithEvents btnGaleria As Button
    Friend WithEvents btnEditorTexto As Button
    Friend WithEvents btnNavegador As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnCalculadora As Button
    Friend WithEvents btnTresEnRaya As Button
    Friend WithEvents btnSnake As Button
    Friend WithEvents btnTxtLoad As Button
End Class

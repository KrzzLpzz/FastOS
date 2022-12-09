Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Users
    Public Privi As String
    Public UID As Integer

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadType()
        'UID = Login.IDUser
        txtContra.UseSystemPasswordChar = True
        txtRContra.UseSystemPasswordChar = True
        txtNContra.UseSystemPasswordChar = True
        txtRNContra.UseSystemPasswordChar = True
        cboNPrivilegio.Text = "Seleccionar"
        cboPrivilegios.Text = "Seleccionar"
    End Sub

    'Buscar Registro
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Busqueda()
    End Sub

    Private Sub Busqueda()
        Dim Consulta As String = "select User from Users where User = '" & txtUser.Text & "'"
        Comando = New OleDb.OleDbCommand(Consulta, Conexion)
        Adapter.SelectCommand = Comando
        Conexion.Open()
        Lector = Comando.ExecuteReader
        If Lector.HasRows = True Then
            MsgBox("Usuario Encontrado", MsgBoxStyle.Information, "Exito")
            Conexion.Close()
            Search()
        Else
            MsgBox("Usuario No Encontrado", MsgBoxStyle.Critical, "Advertencia")
            Conexion.Close()
        End If
    End Sub

    Private Sub Search()
        Dim Busqueda As New OleDb.OleDbCommand("Select *from Users Where User=@User", Conexion)
        Busqueda.Parameters.Add(New OleDb.OleDbParameter("@User", txtUser.Text))

        Conexion.Open()
        Dim Adapter As New OleDb.OleDbDataAdapter(Busqueda)

        Dim Table As New DataTable()
        Adapter.Fill(Table)

        txtUser.Text = Table.Rows(0)(0).ToString
        Privi = Table.Rows(0)(2).ToString
        LblUID.Text = Table.Rows(0)(3).ToString

        If Privi = "ADMIN" Then
            cboPrivilegios.Text = "Administrador"
        Else
            cboPrivilegios.Text = "Usuario"
        End If

        Conexion.Close()
    End Sub

    'Modificar Registro
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtUser.Text = "" Then
            MsgBox("El usuario no puede estar vacio.", MsgBoxStyle.Exclamation, "Administracion de Usuarios")
        Else
            If txtContra.Text = txtRContra.Text Then
                If cboPrivilegios.Text = "Seleccionar" Then
                    MsgBox("El tipo de privilegio es incorrecto.", MsgBoxStyle.Exclamation, "Administracion de Usuarios")
                Else
                    ActualizarDatos()
                End If
            Else
                MsgBox("Las contraseñas no coinciden.", MsgBoxStyle.Exclamation, "Administracion de Usuarios")
            End If
        End If
    End Sub

    Private Sub ActualizarDatos()
        Dim Consulta3 As String = "SELECT [User] FROM Users WHERE USER = '" & txtUser.Text & "'"
        Comando = New OleDb.OleDbCommand(Consulta3, Conexion)
        Adapter.SelectCommand = Comando
        Conexion.Open()
        Lector = Comando.ExecuteReader
        If Lector.HasRows = True Then
            Conexion.Close()
            SIDUser()
        Else
            MsgBox("Usuario no Encontrado.", MsgBoxStyle.Critical, "Advertencia")
            Conexion.Close()
        End If
    End Sub

    Private Sub SIDUser()
        Dim IDSearch As Integer
        Dim Consulta2 As String = "SELECT IDUser FROM Users WHERE User='" & txtUser.Text & "'"
        Adapter = New OleDb.OleDbDataAdapter(Consulta2, Conexion)
        Dim TUser As New DataSet
        TUser.Tables.Add("Users")
        Adapter.Fill(TUser.Tables("Users"))
        IDSearch = TUser.Tables("Users").Rows(0).Item("IDUser")
        UID = IDSearch
        LblUID.Text = UID.ToString

        Modify2()
    End Sub

    Private Sub Modify()
        'LblUID.Text = UID.ToString

        If cboNPrivilegio.Text = "Administrador" Then
            lblSaveNew.Text = "ADMIN"
        Else
            lblSaveNew.Text = "USER"
        End If

        Comando = New OleDb.OleDbCommand("UPDATE Users SET User='" & txtUser.Text & "', Password='" & txtContra.Text & "', Type='" & lblSaveNew.Text & "' WHERE IDUser='" & LblUID.Text & "'", Conexion)

        'Comando.Parameters.Add(New OleDb.OleDbParameter("@IDUser", LblUID.Text))

        Conexion.Open()
        'Comando.Parameters.AddWithValue("@User", txtUser.Text.ToUpper)
        'Comando.Parameters.AddWithValue("@Password", txtContra.Text.ToUpper)
        'Comando.Parameters.AddWithValue("@Type", lblSaveNew.Text.ToUpper)
        'Comando.Parameters.AddWithValue("@IDUser", UID.ToString.ToUpper)

        Try
            Comando.ExecuteNonQuery()
            MsgBox("Datos actualizados con exito.", MsgBoxStyle.Information, "Administracion de Usuarios")
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Administracion de Usuarios")
        End Try

        Conexion.Close()
    End Sub

    Private Sub Modify2()
        If cboPrivilegios.Text = "Administrador" Then
            lblSaveNew.Text = "ADMIN"
        Else
            lblSaveNew.Text = "USER"
        End If

        'Comando = New OleDb.OleDbCommand("update Users set [User]=@User, [Password]=@Password, Type=@Type, IDUser=@IDUser Where IDUser=@IDUser", Conexion)
        Comando = New OleDb.OleDbCommand("update Users set [User]=@User, [Password]=@Password, Type=@Type Where IDUser=@IDUser", Conexion)

        Conexion.Open()
        Comando.Parameters.AddWithValue("@User", txtUser.Text.ToUpper)
        Comando.Parameters.AddWithValue("@Password", txtContra.Text.ToUpper)
        Comando.Parameters.AddWithValue("@Type", lblSaveNew.Text.ToUpper)
        Comando.Parameters.AddWithValue("@IDUser", LblUID.Text.ToUpper)

        Try
            Comando.ExecuteNonQuery()
            MsgBox("Datos actualizados con exito.", MsgBoxStyle.Information, "Administracion de Usuarios")
            MsgBox("¡Es necesario cerrar sesion, Pulse Aceptar para iniciar sesion!", MsgBoxStyle.Critical, "Advertencia")
            Me.Close()
            'ControlPanel.Close()
            FastOS.Screen.Controls.Clear()
            FastOS.LoginScreen()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Administracion de Usuarios")
        End Try

        Conexion.Close()
    End Sub

    'Eliminar Registro
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarDatos()
    End Sub

    Private Sub EliminarDatos()
        Dim Consulta2 As String = "select [User] from Users where User = '" & txtUser.Text & "'"
        Comando = New OleDb.OleDbCommand(Consulta2, Conexion)
        Adapter.SelectCommand = Comando
        Conexion.Open()
        Lector = Comando.ExecuteReader
        If Lector.HasRows = True Then
            Conexion.Close()
            If MsgBox("Eliminar", vbQuestion + vbYesNo) = DialogResult.Yes Then
                Delete()
            End If
        Else
            MsgBox("Usuario no Encontrado.", MsgBoxStyle.Critical, "Advertencia")
            Conexion.Close()
        End If
    End Sub

    Private Sub Delete()
        Dim delete As New OleDb.OleDbCommand("delete from Users where User=@User", Conexion)
        delete.Parameters.Add(New OleDb.OleDbParameter("@User", txtUser.Text))

        Try
            Conexion.Open()
            delete.ExecuteNonQuery()
            MsgBox("Registro Eliminado", MsgBoxStyle.Information, "Administracion de Usuarios")
            MsgBox("¡Es necesario cerrar sesion, Pulse Aceptar para iniciar sesion!", MsgBoxStyle.Critical, "Advertencia")
            Me.Close()
            'ControlPanel.Close()
            FastOS.Screen.Controls.Clear()
            FastOS.LoginScreen()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Administracion de Usuarios")
        End Try

        Conexion.Close()
    End Sub

    'Nuevo Registro
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNUser.Text = "" Then
            MsgBox("El usuario no peude estar vacio.", MsgBoxStyle.Exclamation, "Administracion de Usuarios")
        Else
            If txtNContra.Text = txtRNContra.Text Then
                If cboNPrivilegio.Text = "Seleccionar" Then
                    MsgBox("El tipo de privilegio es incorrecto.", MsgBoxStyle.Exclamation, "Administracion de Usuarios")
                Else
                    Register()
                End If
            Else
                MsgBox("Las contraseñas no coinciden..", MsgBoxStyle.Exclamation, "Administracion de Usuarios")
            End If
        End If
    End Sub

    Private Sub Register()
        Dim Consulta2 As String = "select User from Users where User = '" & txtNUser.Text & "'"
        Comando = New OleDb.OleDbCommand(Consulta2, Conexion)
        Adapter.SelectCommand = Comando
        Conexion.Open()
        Lector = Comando.ExecuteReader

        If Lector.HasRows = True Then
            MsgBox("Usuario Existente, Por Favor use otro nombre de Usuario.", MsgBoxStyle.Critical, "Advertencia")
            Conexion.Close()
        Else
            Conexion.Close()
            Save()
        End If
    End Sub

    Private Sub Save()
        If cboNPrivilegio.Text = "Administrador" Then
            lblSaveNew.Text = "ADMIN"
        Else
            lblSaveNew.Text = "USER"
        End If

        Conexion.Open()
        Comando = New OleDb.OleDbCommand("INSERT INTO Users ([User], [Password], Type)" &
        "values (TxtNUser, TxtNPass, lblSaveNew)", Conexion)

        '//Datos Personales
        Comando.Parameters.AddWithValue("@User", txtNUser.Text.ToUpper)
        Comando.Parameters.AddWithValue("@Password", txtNContra.Text.ToUpper)
        Comando.Parameters.AddWithValue("@Type", lblSaveNew.Text.ToUpper)

        'Guardar
        Comando.ExecuteNonQuery()
        Conexion.Close()
        MessageBox.Show("Usuario Registrado con exito.")
        LimpiarN()
    End Sub

    'Load
    Private Sub LoadType()
        If Desktop.TypeAcc = "ADMIN" Then
            Admin()
        ElseIf Desktop.TypeAcc = "USER" Then
            User()
        ElseIf Desktop.lblUserSave.Text = "ADMIN" Then
            Admin()
        ElseIf Desktop.lblUserSave.Text = "USER" Then
            User()
        ElseIf Login.Funcs = 1 Then
            Admin()
        ElseIf Login.Funcs = 2 Then
            User()
        End If

    End Sub

    Private Sub Admin()
        btnEliminar.Enabled = True
        txtUser.Enabled = True
        btnBuscar.Enabled = True
        cboPrivilegios.Enabled = True

        txtNContra.Enabled = True
        txtNUser.Enabled = True
        cboNPrivilegio.Enabled = True
        btnRegistrar.Enabled = True
        btnNLimpiar.Enabled = True
    End Sub

    Private Sub User()
        btnEliminar.Enabled = False
        txtUser.Text = Desktop.lblUsernameSave.Text
        txtUser.Enabled = False
        btnBuscar.Enabled = False
        cboPrivilegios.Enabled = False

        txtNContra.Enabled = False
        txtNUser.Enabled = False
        cboNPrivilegio.Enabled = False
        btnRegistrar.Enabled = False
        btnNLimpiar.Enabled = False

        Search()
    End Sub

    Private Sub LimpiarN()
        txtNContra.Text = ""
        txtRNContra.Text = ""
        txtNUser.Text = ""
        cboNPrivilegio.Text = "Seleccionar"
    End Sub

    Private Sub Limpiar()
        txtContra.Text = ""
        txtRContra.Text = ""
        txtUser.Text = ""
        cboPrivilegios.Text = "Seleccionar"
    End Sub

    Private Sub chkMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarContra.CheckedChanged
        If chkMostrarContra.Checked = True Then
            txtContra.UseSystemPasswordChar = False
            txtRContra.UseSystemPasswordChar = False
        Else
            txtContra.UseSystemPasswordChar = True
            txtRContra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub chkMostrarNContra_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarNContra.CheckedChanged
        If chkMostrarNContra.Checked = True Then
            txtNContra.UseSystemPasswordChar = False
            txtRNContra.UseSystemPasswordChar = False
        Else
            txtNContra.UseSystemPasswordChar = True
            txtRNContra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnNLimpiar_Click(sender As Object, e As EventArgs) Handles btnNLimpiar.Click
        LimpiarN()
    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        FastOS_Desktop.PictureBox1.Image = My.Resources.Resources.img103
        'Label5.Text = "xd"
    End Sub

    Private Sub pic2_Click(sender As Object, e As EventArgs) Handles pic2.Click
        FastOS_Desktop.PictureBox1.Image = My.Resources.Resources.img100
    End Sub

    Private Sub pic3_Click(sender As Object, e As EventArgs) Handles pic3.Click
        FastOS_Desktop.PictureBox1.Image = pic3.Image
    End Sub

    Private Sub pic4_Click(sender As Object, e As EventArgs) Handles pic4.Click
        FastOS_Desktop.PictureBox1.Image = pic4.Image
    End Sub

    Private Sub pic5_Click(sender As Object, e As EventArgs) Handles pic5.Click
        FastOS_Desktop.PictureBox1.Image = pic5.Image
    End Sub

    Private Sub pic6_Click(sender As Object, e As EventArgs) Handles pic6.Click
        FastOS_Desktop.PictureBox1.Image = pic6.Image
    End Sub
End Class
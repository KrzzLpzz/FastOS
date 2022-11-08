Public Class Login
    Public Username As String
    Public TypeAccount As String
    Public Funcs As Integer
    Public IDUser As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enlace() 'Enlace a la base de datos
        txtUser.Focus() 'Focus en el textbox de usuario
        txtUser.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Verificacion()
        'Log()
        ClearFocus()
    End Sub

    Private Sub SIDUser()
        Dim IDSearch As Integer
        DBConnect.Consulta = "SELECT User, Password FROM Users WHERE User='" & txtUser.Text & "'AND Password='" & txtPassword.Text & "'"
        Comando = New OleDb.OleDbCommand(DBConnect.Consulta, Conexion)
        Adapter.SelectCommand = Comando
        Lector = Comando.ExecuteReader
        If Lector.HasRows = True Then
            Dim Consulta2 As String = "SELECT IDUser FROM Users WHERE User='" & txtUser.Text & "'AND Password='" & txtPassword.Text & "'"
            Adapter = New OleDb.OleDbDataAdapter(Consulta2, Conexion)
            Dim TUser As New DataSet
            TUser.Tables.Add("Users")
            Adapter.Fill(TUser.Tables("Users"))
            IDSearch = TUser.Tables("Users").Rows(0).Item("IDUser")
            IDUser = IDSearch
            FastOS.IDUserGlobal = IDUser
        End If
    End Sub

    Private Sub Log()
        Dim TypeUser As String
        DBConnect.Consulta = "SELECT User, Password FROM Users WHERE User='" & txtUser.Text & "'AND Password='" & txtPassword.Text & "'"
        Comando = New OleDb.OleDbCommand(DBConnect.Consulta, Conexion)
        Adapter.SelectCommand = Comando
        Conexion.Open()
        Lector = Comando.ExecuteReader
        If Lector.HasRows = True Then
            Dim Consulta2 As String = "SELECT Type FROM Users WHERE User='" & txtUser.Text & "'AND Password='" & txtPassword.Text & "'"
            Adapter = New OleDb.OleDbDataAdapter(Consulta2, Conexion)
            Dim TUser As New DataSet
            TUser.Tables.Add("Users")
            Adapter.Fill(TUser.Tables("Users"))
            TypeUser = TUser.Tables("Users").Rows(0).Item("Type")

            TypeAccount = TypeUser
            Username = txtUser.Text
            Desktop.UsernameDesk = txtUser.Text
            Desktop.TypeAcc = TypeUser
            Desktop.lblUserSave.Text = TypeUser
            Desktop.lblUsernameSave.Text = txtUser.Text

            SIDUser()

            If TypeUser = "ADMIN" Then
                MsgBox("¡Administrador!", MsgBoxStyle.Information, "Mensaje")
                Funcs = 1
                FastOS.Screen.Controls.Clear()
                Me.Close()
                FastOS.Desktop()
            ElseIf TypeUser = "USER" Then
                MsgBox("¡Usuario!", MsgBoxStyle.Information, "Mensaje")
                Funcs = 2
                FastOS.Screen.Controls.Clear()
                Me.Close()
                FastOS.Desktop()
            End If
        Else
            MsgBox("Usuario i/o contraseña incorrectos", MsgBoxStyle.Critical, "Advertencia")
        End If
        Conexion.Close()
    End Sub

    Private Sub Verificacion()
        If txtUser.Text = "" Then
            MsgBox("¡No hay usuario!", MsgBoxStyle.Critical, "Advertencia")
            txtUser.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("¡No hay contraseña!", MsgBoxStyle.Critical, "Advertencia")
            txtPassword.Focus()
        Else
            Log()
        End If

    End Sub

    Private Sub ClearFocus()
        txtUser.Clear()
        txtPassword.Clear()
        txtUser.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm")
    End Sub


End Class
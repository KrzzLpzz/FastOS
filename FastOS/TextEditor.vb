Imports System.Data
Imports System.IO
Imports System.Data.Linq
Imports System.Data.OleDb

Public Class TextEditor
    Dim FilePathName As String
    Dim DirPathName As String
    Dim fileName As String

    Dim route As String = "Files\tmp\"
    Dim localfile As String = "test.txt"

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        SaveLocal()
    End Sub


    Private Sub Save()
        Dim OFD As New OpenFileDialog

        If OFD.ShowDialog() = DialogResult.OK Then
            FilePathName = OFD.FileName
            fileName = Path.GetFileName(FilePathName)
            'txtSaveFilePath.Text = FilePathName
        End If

        SaveFileToDB(FilePathName)
    End Sub

    Private Sub SaveLocal()
        Dim fs As FileStream

        ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(route) Then

                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(route & localfile)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
                WriteText()
            Else

                ':::Si la carpeta no existe la creamos
                Directory.CreateDirectory(route)

                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(route & localfile)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
                WriteText()
            End If

        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub

    Private Sub WriteText()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        ':::El unico cambio es que agregamos el valor TRUE con el fin de indicar que queremos
        ':::Seguir agregando los registros y no sobreescribirlos
        Dim escribir As New StreamWriter(route & localfile, True)
        Try
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            escribir.WriteLine(rtbEditor.Text)
            escribir.Close()
            MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            'txtNombre.Clear()

            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub

    Private Sub SaveFileToDB(filePath As String)
        Dim file As Byte()
        Dim stream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim reader As New BinaryReader(stream)
        file = reader.ReadBytes(Convert.ToInt32(stream.Length))

        Comando = New OleDb.OleDbCommand("INSERT INTO Files ([IdUser], [NameFile], [File])" &
        "values (LblGID, FileName, FileData)", Conexion)

        Conexion.Open()

        'Comando.Parameters.AddWithValue("@Id", LblGID.Text.ToUpper)
        Comando.Parameters.AddWithValue("@FileName", OleDbType.VarWChar).Value = fileName
        Comando.Parameters.AddWithValue("@FileData", OleDbType.VarBinary).Value = file.ToArray()


        If (Comando.ExecuteNonQuery) Then
            MessageBox.Show("Archivo Guardado", "Editor de Texto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Clear()
        Else
            MessageBox.Show("No se pudo guardar el archivo", "Editor de Texto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Conexion.Close()

        'LoadData()
        'txtSaveFilePath.Clear()
    End Sub

    Private Sub AbrirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem1.Click
        Dim FBD As New FolderBrowserDialog

        If FBD.ShowDialog() = DialogResult.OK Then
            DirPathName = FBD.SelectedPath
            ' txtDownloadPath.Text = DirPathName
        End If

        DownloadFile(DirPathName)
    End Sub

    Private Sub DownloadFile(NewFileLocation As String)
        '   Try
        '    NewFileLocation = DirPathName
        'Dim id As Integer = Convert.ToInt32(gvFile.CurrentRow.Cells(0).Value.ToString())
        '  query = "Select * From tblFile Where Id=@Id"
        ' cmd = New OleDbCommand(query, con)
        'cmd.Parameters.Add("@Id", OleDbType.Integer).Value = id
        'da = New OleDbDataAdapter(cmd)
        'dt = New DataTable("tblFile")
        'dt.Clear()
        'da.Fill(dt)

        '       For Each row As DataRow In dt.Rows

        '           Dim filebyte As Byte() = row(2)
        '          Dim fs As New FileStream(NewFileLocation & "\" & row(1), FileMode.Create, FileAccess.Write)
        '         fs.Write(filebyte, 0, filebyte.Length)
        '        fs.Close()
        '   Next
        '      txtDownloadPath.Clear()
        '     MessageBox.Show("File Downloaded Successfully", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception

        ' End Try


    End Sub
End Class
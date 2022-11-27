Imports System.Data
Imports System.IO
Imports System.Data.Linq
Imports System.Data.OleDb

Public Class TextEditor
    Public IDUserGallery As Integer

    Dim FilePathName As String
    Dim DirPathName As String
    Dim fileName As String

    Dim route As String = "Files\tmp\"
    Dim localfile As String '= "test.txt"

    Dim savedfile As String

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        Save()
    End Sub

    'Guardar
    Private Sub Save()
        SaveLocal()
    End Sub

    'Guarda en Local
    Private Sub SaveLocal()
        Dim fs As FileStream

        ':::Validamos si la carpeta de ruta existe, si no existe la creamos

        If txtTitulo.Text.Replace(" ", "") = "" Then
            MsgBox("Ingresa un nombre para el archivo.", MsgBoxStyle.Information, "Editor de Texto")
        Else
            localfile = txtTitulo.Text + ".txt"
            savedfile = localfile

            Try
                If File.Exists(route) Then

                    ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                    fs = File.Create(route & localfile)
                    fs.Close()
                    MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "Editor de Texto")
                    WriteText()
                Else

                    ':::Si la carpeta no existe la creamos
                    Directory.CreateDirectory(route)

                    ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                    fs = File.Create(route & localfile)
                    fs.Close()
                    MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "Editor de Texto")
                    FilePathName = route + localfile
                    fileName = Path.GetFileName(FilePathName)

                    Label2.Text = FilePathName
                    Label3.Text = fileName
                    WriteText()
                End If
            Catch ex As Exception
                MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "Editor de Texto")
            End Try
        End If
    End Sub

    'Escribe en el archivo
    Private Sub WriteText()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        ':::El unico cambio es que agregamos el valor TRUE con el fin de indicar que queremos
        ':::Seguir agregando los registros y no sobreescribirlos
        Dim escribir As New StreamWriter(route & localfile, True)
        Try
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            escribir.WriteLine(rtbEditor.Text)
            escribir.Close()
            MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "Editor de Texto")
            'txtNombre.Clear()

            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()

            SaveFileToDB(FilePathName)
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "Editor de Texto")
        End Try
    End Sub

    'Sube el archivo guardado en local a la base de datos
    Private Sub SaveFileToDB(filePath As String)
        Dim file As Byte()
        Dim stream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim reader As New BinaryReader(stream)
        file = reader.ReadBytes(Convert.ToInt32(stream.Length))

        Comando = New OleDb.OleDbCommand("INSERT INTO Files ([IdUser], [NameFile], [File])" &
        "values (LblGID, FileName, FileData)", Conexion)

        Conexion.Open()

        Comando.Parameters.AddWithValue("@Id", lblTID.Text.ToUpper)
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

    'Abrir documentos
    Private Sub AbrirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem1.Click
        Dim FBD As New FolderBrowserDialog

        'If FBD.ShowDialog() = DialogResult.OK Then
        'DirPathName = FBD.SelectedPath
        ' txtDownloadPath.Text = DirPathName
        'End If

        'DirPathName = route

        'DownloadFile(DirPathName)
    End Sub

    Private Sub PegarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem1.Click
        rtbEditor.Paste()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        If rtbEditor.SelectionLength > 0 Then
            rtbEditor.Cut()
        End If
    End Sub

    Private Sub CopiarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem1.Click
        If rtbEditor.SelectionLength > 0 Then
            rtbEditor.Cut()
        End If
    End Sub

    Private Sub SeleccionartodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionartodoToolStripMenuItem.Click
        rtbEditor.SelectAll()
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        rtbEditor.Undo()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        rtbEditor.Redo()
    End Sub

    Private Sub PersonalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizarToolStripMenuItem.Click
        FontDialog1.Font = rtbEditor.Font
        FontDialog1.ShowDialog()
        rtbEditor.Font = FontDialog1.Font
    End Sub

    Private Sub TextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDUserGallery = FastOS.IDUserGlobal.ToString
        lblTID.Text = IDUserGallery.ToString
    End Sub
End Class
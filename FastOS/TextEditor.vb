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

    Dim DownF As String

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
        Panel2.Visible = True
        rtbEditor.Visible = False
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        DirPathName = route

        DownloadFile(DirPathName)
    End Sub

    Private Sub DownloadFile(NewFileLocation As String)
        Try
            NewFileLocation = DirPathName
            Dim idXD As Integer = Convert.ToInt32(dgvFiles.CurrentRow.Cells(0).Value.ToString())
            DownF = Convert.ToString(dgvFiles.CurrentRow.Cells(1).Value.ToString())
            txtTitulo.Text = DownF

            'TextEditor.txtTitulo = fileNameD
            lblIdFile.Text = idXD.ToString
            Dim Selection As String = "Select * From Files Where IdFile=@IdFile"
            Dim cmd As New OleDb.OleDbCommand(Selection, Conexion)

            cmd.Parameters.Add("@IdFile", OleDbType.Integer).Value = idXD

            Dim Adapt As New OleDb.OleDbDataAdapter(cmd)
            Dim Data As New DataTable()

            Data.Clear()
            Adapt.Fill(Data)

            For Each row As DataRow In Data.Rows

                Dim filebyte As Byte() = row(3)
                Dim fs As New FileStream(NewFileLocation & "\" & row(2), FileMode.Create, FileAccess.Write)
                fs.Write(filebyte, 0, filebyte.Length)
                fs.Close()
            Next

            CargarTxt()
            MessageBox.Show("File Downloaded Successfully", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Panel2.Visible = False
            rtbEditor.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarTxt()
        Try
            rtbEditor.LoadFile(route & DownF, RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub

    'Cargar datos
    Private Sub LoadData()
        Dim Fuel As String = "SELECT * FROM Files Where IdUser='" & lblTID.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Fuel, Conexion)

        Dim Adapt As New OleDb.OleDbDataAdapter(cmd)
        Dim Data As New DataTable

        dgvFiles.Rows.Clear()
        Adapt.Fill(Data)
        'dgvFiles.DataSource = Data

        For Each row As DataRow In Data.Rows
            dgvFiles.Rows.Add(row(0).ToString(), row(2), row(3))
        Next
    End Sub

    'Herramientas
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

    'Load
    Private Sub TextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDUserGallery = FastOS.IDUserGlobal.ToString
        lblTID.Text = IDUserGallery.ToString

        LoadData()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Panel2.Visible = False
        rtbEditor.Visible = True
    End Sub
End Class
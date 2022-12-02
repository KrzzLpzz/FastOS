Imports System.Data
Imports System.IO
Imports System.Data.Linq
Imports System.Data.OleDb

Public Class DownloadTXT
    Public IDTXTLoad As Integer

    Dim FilePathName As String
    Dim DirPathName As String
    Public fileNameD As String

    Dim route As String = "Files\tmp\"
    Dim localfile As String '= "test.txt"

    Dim savedfile As String

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim FBD As New FolderBrowserDialog

        'If FBD.ShowDialog() = DialogResult.OK Then
        'DirPathName = FBD.SelectedPath
        ' txtDownloadPath.Text = DirPathName
        'End If

        DirPathName = route

        DownloadFile(DirPathName)
    End Sub

    Private Sub DownloadFile(NewFileLocation As String)
        Try
            NewFileLocation = DirPathName
            Dim idXD As Integer = Convert.ToInt32(dgvFiles.CurrentRow.Cells(0).Value.ToString())
            fileNameD = Convert.ToString(dgvFiles.CurrentRow.Cells(1).Value.ToString())
            'TextEditor.txtTitulo = fileNameD
            lblIdFile.Text = idXD.ToString
            Dim Selection As String = "SELECT * FROM Files Where IdFile='" & lblIdFile.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Selection, Conexion)

            cmd.Parameters.Add("@IdUser", OleDbType.Integer).Value = idXD

            Dim Adapt As New OleDb.OleDbDataAdapter(cmd)
            Dim Data As New DataTable

            Data.Clear()
            Adapt.Fill(Data)

            For Each row As DataRow In Data.Rows

                Dim filebyte As Byte() = row(2)
                Dim fs As New FileStream(NewFileLocation & "\" & row(1), FileMode.Create, FileAccess.Write)
                fs.Write(filebyte, 0, filebyte.Length)
                fs.Close()
            Next

            Label1.Text = DirPathName + fileNameD


            TextEditor.CargarTxt()

            MessageBox.Show("File Downloaded Successfully", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

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

    Private Sub DownloadTXT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDTXTLoad = FastOS.IDUserGlobal.ToString
        lblTID.Text = IDTXTLoad.ToString
        LoadData()
    End Sub
End Class
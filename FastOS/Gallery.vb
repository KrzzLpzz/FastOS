Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class Gallery
    Public IDUserGallery As Integer

    Dim Camera As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim CamSig As Integer = 0

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        CamOff()
        OpenFileDialog1.Title = "Abrir Imagen"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "All Files |*.*"
        'OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            btnGuardar.Enabled = True
            btnCapturar.Enabled = False
            picCamera.Visible = False
            txtNombreImagen.Enabled = True
            txtNombreImagen.Text = ""
        Else
            btnGuardar.Enabled = False
        End If

        picImagen.ImageLocation = OpenFileDialog1.FileName

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If picImagen.Image Is Nothing Then
            MsgBox("La imagen no puede estar vacia", MsgBoxStyle.Critical, "Advertencia")
        Else
            SaveImg()
        End If
    End Sub

    Private Sub SaveImg()
        picImagen.Image.Save("miFoto.jpg")
        Dim o As System.IO.FileStream
        Dim r As StreamReader
        Dim ms As New IO.MemoryStream()

        o = New FileStream("miFoto.jpg", FileMode.Open, FileAccess.Read, FileShare.Read)
        r = New StreamReader(o)

        Dim FileByteArray(o.Length - 1) As Byte
        o.Read(FileByteArray, 0, o.Length)

        Comando = New OleDb.OleDbCommand("INSERT INTO Images ([IdUser], [NameImg], [Picture])" &
        "values (LblGID, txtNombreImagen, i)", Conexion)

        Conexion.Open()

        Comando.Parameters.AddWithValue("@Id", LblGID.Text.ToUpper)
        Comando.Parameters.AddWithValue("@NameImg", txtNombreImagen.Text.ToUpper)
        Comando.Parameters.AddWithValue("@Foto", o.Length).Value = FileByteArray

        If (Comando.ExecuteNonQuery) Then
            MessageBox.Show("Imagen Guardada")
            Clear()
        Else
            MessageBox.Show("Imagen no Guardada")
        End If

        Conexion.Close()
    End Sub

    Private Sub SaveImgTest()
        Dim ms As New IO.MemoryStream()
        picImagen.Image.Save(ms, picImagen.Image.RawFormat)
        Dim i() As Byte = ms.GetBuffer

        Comando = New OleDb.OleDbCommand("INSERT INTO Images ([IdUser], [NameImg], [Picture])" &
        "values (LblGID, txtNombreImagen, i)", Conexion)

        Conexion.Open()

        Comando.Parameters.AddWithValue("@Id", LblGID.Text.ToUpper)
        Comando.Parameters.AddWithValue("@NameImg", txtNombreImagen.Text.ToUpper)
        Comando.Parameters.AddWithValue("@Foto", i)

        If (Comando.ExecuteNonQuery) Then
            MessageBox.Show("Imagen Guardada")
            Clear()
        Else
            MessageBox.Show("Imagen no Guardada")
        End If

        Conexion.Close()
    End Sub

    Private Sub MostrarImagenes()
        Dim Fuel As String = "SELECT NameImg, Picture FROM Images Where IdUser='" & LblGID.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Fuel, Conexion)

        Dim Adapt As New OleDb.OleDbDataAdapter(cmd)
        Dim Data As New DataTable

        Adapt.Fill(Data)
        dgvImagenes.DataSource = Data
    End Sub

    Private Sub dgvImagenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImagenes.CellClick
        picCamera.Visible = False
        CamOff()
        txtNombreImagen.Text = dgvImagenes.SelectedCells.Item(0).Value
        picImagen.Image = Nothing
        Dim i() As Byte = dgvImagenes.SelectedCells.Item(1).Value
        Dim ms As New IO.MemoryStream(i)
        picImagen.Image = Image.FromStream(ms)
        picImagen.SizeMode = PictureBoxSizeMode.Zoom
        btnGuardar.Enabled = False
        txtNombreImagen.Enabled = False
    End Sub

    Private Sub Gallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDUserGallery = FastOS.IDUserGlobal.ToString
        LblGID.Text = IDUserGallery.ToString
        MostrarImagenes()
    End Sub

    Private Sub btnCamara_Click(sender As Object, e As EventArgs) Handles btnCamara.Click
        Clear()
        Dim Cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If Cameras.ShowDialog() = DialogResult.OK Then
            Camera = Cameras.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf ImgCam)
            picCamera.Image = Nothing
            picCamera.Visible = True
            Camera.Start()
            CamSig = 1
            btnCapturar.Enabled = True
        End If
    End Sub

    Private Sub ImgCam(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picCamera.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click
        picImagen.Image = picCamera.Image
        CamOff()
        picCamera.Visible = False
        btnCapturar.Enabled = False
        btnGuardar.Enabled = True
        txtNombreImagen.Enabled = True
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        Clear()
    End Sub

    Private Sub CamOff()
        If CamSig = 1 Then
            Camera.Stop()
        End If
    End Sub

    Private Sub Clear()
        txtNombreImagen.Text = ""
        picImagen.Image = Nothing
        picCamera.Image = Nothing
        picCamera.Visible = False
        CamOff()
        MostrarImagenes()
        btnCapturar.Enabled = False
        btnGuardar.Enabled = True
        txtNombreImagen.Enabled = True
    End Sub
End Class
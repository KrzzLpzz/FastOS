Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class Gallery
    Public IDUserGallery As Integer

    Dim Camera As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        OpenFileDialog1.Title = "Abrir Imagen"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "All Files |*.*"
        OpenFileDialog1.ShowDialog()
        picImagen.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim ms As New IO.MemoryStream()
        picImagen.Image.Save(ms, picImagen.Image.RawFormat)
        Dim i() As Byte = ms.GetBuffer

        Comando = New OleDb.OleDbCommand("INSERT INTO Files ([IdUser], [Picture])" &
        "values (LblGID, i)", Conexion)

        Conexion.Open()

        Comando.Parameters.AddWithValue("@Id", LblGID.Text.ToUpper)
        Comando.Parameters.AddWithValue("@Foto", i)

        If (Comando.ExecuteNonQuery) Then
            MessageBox.Show("Imagen Guardada")
            MostrarImagenes()
        Else
            MessageBox.Show("imagen no Guardada")
        End If

        Conexion.Close()
    End Sub

    Private Sub MostrarImagenes()
        Dim Fuel As String = "select *from Files"
        Dim cmd As New OleDb.OleDbCommand(Fuel, Conexion)
        Dim Adapt As New OleDb.OleDbDataAdapter(cmd)
        Dim Data As New DataTable

        Adapt.Fill(Data)
        dgvImagenes.DataSource = Data
    End Sub

    Private Sub dgvImagenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImagenes.CellClick
        'txttitulo.Text = dgvImagenes.SelectedCells.Item(0).Value
        picImagen.Image = Nothing
        Dim i() As Byte = dgvImagenes.SelectedCells.Item(2).Value
        Dim ms As New IO.MemoryStream(i)
        picImagen.Image = Image.FromStream(ms)
        picImagen.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Gallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarImagenes()
        IDUserGallery = FastOS.IDUserGlobal.ToString
        LblGID.Text = IDUserGallery.ToString
    End Sub

    Private Sub btnCamara_Click(sender As Object, e As EventArgs) Handles btnCamara.Click
        Dim Cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If Cameras.ShowDialog() = DialogResult.OK Then
            Camera = Cameras.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf ImgCam)
            picCamera.Image = Nothing
            picCamera.Visible = True
            Camera.Start()
        End If
    End Sub

    Private Sub ImgCam(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picCamera.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click
        picImagen.Image = picCamera.Image
        Camera.Stop()
        picCamera.Visible = False
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        txtNombreImagen.Text = ""
        picImagen.Image = Nothing
        picCamera.Image = Nothing
        picCamera.Visible = False
        Camera.Stop()
    End Sub
End Class
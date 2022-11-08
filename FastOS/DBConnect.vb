Imports System.Data
Imports System.Data.OleDb

Module DBConnect
    Public Conexion As New OleDbConnection ' para la conexión
    Public Comando As New OleDbCommand ' para el comando
    Public Adapter As New OleDbDataAdapter ' para el adaptador de datos
    Public Lector As OleDbDataReader ' para realizar la lectura.
    Public Consulta As String ' para realizar la consulta en la BD
    Public Acept As Integer

    Sub Enlace()
        Try
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\BaleadaOS.accdb"
            'Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\crisa\Documents\BaleadaOS.accdb"
            'Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database\AdminProgram.accdb"
            Conexion.Open() ' La abrimos...
            Acept = 1
            Conexion.Close()
        Catch ex As Exception
            Acept = 0
        End Try
    End Sub
End Module

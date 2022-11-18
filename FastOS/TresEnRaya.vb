Public Class TresEnRaya
    Dim Turno As Integer
    Dim ctrl As Control
    Dim G As Boolean



    Sub Activar(sender As Object, e As EventArgs) Handles BTN1.Click, BTN2.Click, BTN3.Click, BTN4.Click, BTN5.Click, BTN6.Click, BTN7.Click, BTN8.Click, BTN9.Click
        If sender.Text = "" Then
            If Turno = 1 Then
               

            ElseIf Turno = 2 Then
                sender.Text = "O"
                Turno = 1


            End If
            
        End If
        Analisis()
        If G = True Then

        Else
            Cpu()
        End If

    End Sub

    Sub Ganador(ByRef B1 As Button, ByRef B2 As Button, ByRef B3 As Button, ByVal Marca As String)
        If B1.Text = Marca And B2.Text = Marca And B3.Text = Marca Then

            B1.BackColor = Color.Green
            B2.BackColor = Color.Green
            B3.BackColor = Color.Green
            MsgBox("Gana Jugador  " + Marca)
            G = True
        End If

    End Sub

    Sub Amenaza(ByRef B1 As Button, ByRef B2 As Button, ByRef B3 As Button, ByVal Marca As String)
        If Turno = 1 Then
            If B1.Text = Marca And B2.Text = Marca And B3.Text = "" Then
                B3.Text = "X"
                Turno = 2
            ElseIf B1.Text = Marca And B2.Text = "" And B3.Text = Marca Then
                B2.Text = "X"
                Turno = 2
            ElseIf B1.Text = "" And B2.Text = Marca And B3.Text = Marca Then
                B1.Text = "X"
                Turno = 2
            End If
        End If
        

    End Sub

    Sub Cpu()
        Amenaza(BTN1, BTN2, BTN3, "X")
        Amenaza(BTN4, BTN5, BTN6, "X")
        Amenaza(BTN7, BTN8, BTN9, "X")

        Amenaza(BTN1, BTN4, BTN7, "X")
        Amenaza(BTN2, BTN5, BTN8, "X")
        Amenaza(BTN3, BTN6, BTN9, "X")

        Amenaza(BTN1, BTN5, BTN9, "X")
        Amenaza(BTN3, BTN5, BTN7, "X")

        Amenaza(BTN1, BTN2, BTN3, "O")
        Amenaza(BTN4, BTN5, BTN6, "O")
        Amenaza(BTN7, BTN8, BTN9, "O")

        Amenaza(BTN1, BTN4, BTN7, "O")
        Amenaza(BTN2, BTN5, BTN8, "O")
        Amenaza(BTN3, BTN6, BTN9, "O")

        Amenaza(BTN1, BTN5, BTN9, "O")
        Amenaza(BTN3, BTN5, BTN7, "O")



        For Each ctrl In Controls
            If TypeOf (ctrl) Is Button Then
                ctrl.Enabled = False
            End If
        Next

        If Turno = "1" Then

            Dim Random As New Random
Line1:
            Dim Numero As Integer = Random.Next(1, 10)


            For Each ctrl In Controls
                If TypeOf (ctrl) Is Button Then
                    If ctrl.Tag = Numero And ctrl.Text = "" Then
                        ctrl.Text = "X"
                        Turno = 2
                    ElseIf ctrl.Tag = Numero And ctrl.Text <> "" Then
                        GoTo Line1

                    End If

                End If
            Next
        End If



        For Each ctrl In Controls
            If TypeOf (ctrl) Is Button Then
                ctrl.Enabled = True

            End If
        Next

        Analisis()
    End Sub

    Sub Analisis()
        Ganador(BTN1, BTN2, BTN3, "X")
        Ganador(BTN4, BTN5, BTN6, "X")
        Ganador(BTN7, BTN8, BTN9, "X")

        Ganador(BTN1, BTN4, BTN7, "X")
        Ganador(BTN2, BTN5, BTN8, "X")
        Ganador(BTN3, BTN6, BTN9, "X")

        Ganador(BTN1, BTN5, BTN9, "X")
        Ganador(BTN3, BTN5, BTN7, "X")

        Ganador(BTN1, BTN2, BTN3, "O")
        Ganador(BTN4, BTN5, BTN6, "O")
        Ganador(BTN7, BTN8, BTN9, "O")

        Ganador(BTN1, BTN4, BTN7, "O")
        Ganador(BTN2, BTN5, BTN8, "O")
        Ganador(BTN3, BTN6, BTN9, "O")

        Ganador(BTN1, BTN5, BTN9, "O")
        Ganador(BTN3, BTN5, BTN7, "O")

    End Sub


   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BTN1.Enabled = True
        BTN2.Enabled = True
        BTN3.Enabled = True
        BTN4.Enabled = True
        BTN5.Enabled = True
        BTN6.Enabled = True
        BTN7.Enabled = True
        BTN8.Enabled = True
        BTN9.Enabled = True
        BTN1.Text = ""
        BTN2.Text = ""
        BTN3.Text = ""
        BTN4.Text = ""
        BTN5.Text = ""
        BTN6.Text = ""
        BTN7.Text = ""
        BTN8.Text = ""
        BTN9.Text = ""
        BTN1.BackColor = Color.White
        BTN2.BackColor = Color.White
        BTN3.BackColor = Color.White
        BTN4.BackColor = Color.White
        BTN5.BackColor = Color.White
        BTN6.BackColor = Color.White
        BTN7.BackColor = Color.White
        BTN8.BackColor = Color.White
        BTN9.BackColor = Color.White


        G = False
        Turno = 1

        Cpu()

    End Sub

   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Turno = 1
    End Sub
End Class

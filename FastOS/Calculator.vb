Public Class Calculator
    Public Numero1 As String
    Public Numero2 As String
    Public Operador As String
    Public Resultado As String

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtResult.Clear()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResult.Text = txtResult.Text + "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResult.Text = txtResult.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtResult.Text = txtResult.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtResult.Text = txtResult.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtResult.Text = txtResult.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtResult.Text = txtResult.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtResult.Text = txtResult.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtResult.Text = txtResult.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtResult.Text = txtResult.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResult.Text = txtResult.Text + "9"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        txtResult.Text = txtResult.Text + "."
    End Sub

    Private Sub btnSQRT_Click(sender As Object, e As EventArgs) Handles btnSQRT.Click
        txtResult.Text = Math.Sqrt(d:=Val(txtResult.Text))
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Numero1 = txtResult.Text
        txtResult.Clear()
        Operador = "Division"
    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        Numero1 = txtResult.Text
        txtResult.Clear()
        Operador = "Multiplicación"
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Numero1 = txtResult.Text
        txtResult.Clear()
        Operador = "Resta"
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Numero1 = txtResult.Text
        txtResult.Clear()
        Operador = "Suma"
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Numero2 = txtResult.Text
        txtResult.Clear()

        If Operador = "Suma" Then
            Resultado = Val(Numero1) + Val(Numero2)
            txtResult.Text = Resultado
        End If
        If Operador = "Resta" Then
            Resultado = Val(Numero1) - Val(Numero2)
            txtResult.Text = Resultado
        End If
        If Operador = "Division" Then
            Resultado = Val(Numero1) / Val(Numero2)
            txtResult.Text = Resultado
        End If
        If Operador = "Multiplicación" Then
            Resultado = Val(Numero1) * Val(Numero2)
            txtResult.Text = Resultado
        End If
    End Sub
End Class

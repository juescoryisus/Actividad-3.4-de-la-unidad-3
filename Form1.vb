Public Class Form1


    Public Class Calculadora

        Public Function Suma(ByVal a As Integer, ByVal b As Integer) As Integer
            Return a + b
        End Function

        Public Function resta(ByVal n As Double, ByVal m As Double) As Double
            Return n - m
        End Function

        Public Function multiplicacion(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
            Return a * b * c
        End Function

    End Class

    Dim a As Integer = 2
    Dim b As Integer = 3
    Dim c As Integer = 5
    Dim n As Double = 2.5
    Dim m As Double = 3.5

    Dim calc As New calculadora()
    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click

        Dim resultado1 As Integer = calc.Suma(a, b)
        MsgBox(resultado1)

        Dim resultado2 As Double = calc.resta(m, n)
        MsgBox(resultado2)


        Dim resultado3 As Integer = calc.multiplicacion(a, b, c)
        MsgBox(resultado3)

    End Sub
End Class


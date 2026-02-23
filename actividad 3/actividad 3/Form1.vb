Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim mat1, mat2, mat3, mat4, mat5 As Double
        Dim promedio As Double

        mat1 = Val(materia1.Text)
        mat2 = Val(materia2.Text)
        mat3 = Val(materia3.Text)
        mat4 = Val(materia4.Text)
        mat5 = Val(materia5.Text)

        promedio = (mat1 + mat2 + mat3 + mat4 + mat5) / 5

        Resultado.Text = promedio.ToString()
    End Sub
End Class

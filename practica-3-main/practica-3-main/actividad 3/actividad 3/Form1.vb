Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim mat1, mat2, mat3, mat4, mat5, mat6, mat7, mat8, mat9, mat10, mat11, mat12, mat13 As Double
        Dim promedio As Double

        mat1 = Val(materia1.Text)
        mat2 = Val(materia2.Text)
        mat3 = Val(materia3.Text)
        mat4 = Val(materia4.Text)
        mat5 = Val(materia5.Text)
        mat6 = Val(materia6.Text)
        mat7 = Val(materia7.Text)
        mat8 = Val(materia8.Text)
        mat9 = Val(materia9.Text)
        mat10 = Val(materia10.Text)
        mat11 = Val(materia11.Text)
        mat12 = Val(materia12.Text)
        mat13 = Val(materia13.Text)

        promedio = (mat1 + mat2 + mat3 + mat4 + mat5 + mat6 + mat7 + mat8 + mat9 + mat10 + mat11 + mat12 + mat13) / 13

        Resultado.Text = promedio.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub materia5_TextChanged(sender As Object, e As EventArgs) Handles materia5.TextChanged

    End Sub
End Class

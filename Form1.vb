Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaMatrizEntera.ColumnCount = 5
        GrillaMatrizEntera.Rows.Add(5)
        GrillaMatrizDiagonales.ColumnCount = 5
        GrillaMatrizDiagonales.Rows.Add(5)
    End Sub
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim matriz(5, 5), count As Integer
        count = 0
        For f = 0 To 4
            For c = 0 To 4
                matriz(f, c) = InputBox("ingresar 25 valores")
                count = count + 1
                lblCount.Text = count & "/25 numeros ingresados"
                GrillaMatrizEntera.Item(c, f).Value = matriz(f, c)
                If f = c Then
                    GrillaMatrizDiagonales.Item(f, c).Value = matriz(f, c)
                End If
            Next
        Next
        GrillaMatrizDiagonales.Item(4, 0).Value = matriz(0, 4)
        GrillaMatrizDiagonales.Item(3, 1).Value = matriz(1, 3)
        GrillaMatrizDiagonales.Item(1, 3).Value = matriz(3, 1)
        GrillaMatrizDiagonales.Item(0, 4).Value = matriz(4, 0)
    End Sub
End Class

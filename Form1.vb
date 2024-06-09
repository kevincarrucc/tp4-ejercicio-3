Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaMatrizEntera.ColumnCount = 5
        GrillaMatrizEntera.Rows.Add(5)
        GrillaMatrizDiagonales.ColumnCount = 5
        GrillaMatrizDiagonales.Rows.Add(5)
    End Sub
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim matriz(5, 5) As Integer
        For f = 0 To 4
            For c = 0 To 4

            Next
        Next

        For f = 0 To 4
            For c = 0 To 4

            Next
        Next

        For f = 0 To 4
            For c = 0 To 4

            Next
        Next

        For f = 0 To 4
            For c = 0 To 4

            Next
        Next
    End Sub
End Class

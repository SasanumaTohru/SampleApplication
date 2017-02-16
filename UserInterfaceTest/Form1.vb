Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim 商品ID As New SampleApplication.BusinessObject.商品.商品ID("999999")
        Debug.Print(商品ID.値)
    End Sub
End Class

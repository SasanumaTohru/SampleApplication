Imports SampleApplication

Public Class スタート画面

    ''' <summary>
    ''' MessageBoxCaption構造体　※検証終了後にクラス化
    ''' </summary>
    Private Structure MessageBoxCaption
        Public Const 入力エラー As String = "入力エラー"
    End Structure

    ''' <summary>
    ''' 実行ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmd実行_Click(sender As Object, e As EventArgs) Handles cmd実行.Click
        Try
            Dim 商品ID As New BusinessObject.商品.商品ID(txt商品ID.Text)
            Debug.Print(商品ID.値)
        Catch ex As Exception
            MessageBox.Show(ex.Message, MessageBoxCaption.入力エラー, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            txt商品ID.Text = String.Empty
        End Try
    End Sub

End Class

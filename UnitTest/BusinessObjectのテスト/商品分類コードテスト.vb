Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class 商品分類コードテスト

    <TestMethod()> Public Sub 商品分類コードテストの基本テスト()
        '分類コードは、1から始まる連番で採番される。分類コードは不変であり、削除されることもない。
        Dim 分類コード As New 分類コード(1)
        Assert.AreEqual(1, 分類コード.値)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品分類クラス例外処理1()
        '商品分類に登録がないものはエラー。
        Dim 商品の分類 As New 分類コード(0)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品分類クラス例外処理2()
        '商品分類に登録がないものはエラー。
        Dim 分類コード As New 分類コード(分類コードの最大値を取得する() + 1)
    End Sub

    ''' <summary>
    ''' 分類コードの最大値を取得するメソッド
    ''' </summary>
    ''' <returns></returns>
    Private Function 分類コードの最大値を取得する() As Integer
        Using MyDB As New SampleApplication.SampleAppDBEntities
            Dim 商品分類コード = From レコード In MyDB.M_商品分類 Select レコード.コード

            Return 商品分類コード.Max
        End Using
    End Function

End Class
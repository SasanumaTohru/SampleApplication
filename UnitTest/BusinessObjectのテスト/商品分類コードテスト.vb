Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class 商品分類コードテスト

    <TestMethod()> Public Sub 商品分類コードテストの基本テスト()
        '生成と参照
        Dim 分類コード As New 商品分類コード(1)
        Assert.AreEqual(1, 分類コード.値)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品分類クラス例外処理1()
        '商品分類に登録がないものはエラー。
        Dim 商品の分類 As New 商品分類コード(0)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品分類クラス例外処理2()
        '商品分類に登録がないものはエラー。
        Dim 商品の分類 As New 商品分類コード(6)
    End Sub

End Class
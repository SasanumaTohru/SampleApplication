Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class 商品分類テスト

    <TestMethod()> Public Sub 商品分類基本テスト()

        '商品分類の参照
        Assert.AreEqual(1, DirectCast(商品分類.分類リスト.家電, Integer))
        Assert.AreEqual(2, DirectCast(商品分類.分類リスト.パソコン, Integer))
        Assert.AreEqual(3, DirectCast(商品分類.分類リスト.AV機器, Integer))
        Assert.AreEqual(4, DirectCast(商品分類.分類リスト.カメラ, Integer))
        Assert.AreEqual(5, DirectCast(商品分類.分類リスト.時計, Integer))

        'インスタンスの生成と値の参照
        Dim 商品の分類 As New 商品分類(商品分類.分類リスト.AV機器)
        Assert.AreEqual("AV機器", 商品の分類.名称.値)

    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub 商品分類クラス例外処理1()
        '商品分類に登録がないものはエラー。
        Dim 商品の分類 As New 商品分類(0)
    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub 商品分類クラス例外処理2()
        '商品分類に登録がないものはエラー。
        Dim 商品の分類 As New 商品分類(6)
    End Sub

End Class
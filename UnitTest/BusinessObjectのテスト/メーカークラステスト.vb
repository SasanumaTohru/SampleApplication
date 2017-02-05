Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class メーカークラステスト

    <TestMethod()> Public Sub メーカークラスの基本テスト()

        'メーカーリストの参照
        Assert.AreEqual(1, DirectCast(メーカー.メーカーリスト.ソニー, Integer))
        Assert.AreEqual(2, DirectCast(メーカー.メーカーリスト.パナソニック, Integer))
        Assert.AreEqual(3, DirectCast(メーカー.メーカーリスト.キヤノン, Integer))
        Assert.AreEqual(4, DirectCast(メーカー.メーカーリスト.カシオ, Integer))
        Assert.AreEqual(5, DirectCast(メーカー.メーカーリスト.ニコン, Integer))
        Assert.AreEqual(6, DirectCast(メーカー.メーカーリスト.富士通, Integer))
        Assert.AreEqual(7, DirectCast(メーカー.メーカーリスト.日立, Integer))
        Assert.AreEqual(8, DirectCast(メーカー.メーカーリスト.ASUS, Integer))
        Assert.AreEqual(9, DirectCast(メーカー.メーカーリスト.セイコー, Integer))
        Assert.AreEqual(10, DirectCast(メーカー.メーカーリスト.NEC, Integer))

        'インスタンスの生成と値の参照
        Dim 製造元 As New メーカー(メーカー.メーカーリスト.キヤノン)
        Assert.AreEqual("キヤノン", 製造元.名称.値)

    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub メーカークラス例外処理1()
        'メーカーリストに登録がないものはエラー。
        Dim 製造元 As New 商品分類(0)
    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub メーカークラス例外処理2()
        'メーカーリストに登録がないものはエラー。
        Dim 製造元 As New 商品分類(11)
    End Sub

End Class
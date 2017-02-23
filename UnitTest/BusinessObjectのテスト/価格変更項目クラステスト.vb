Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格変更項目クラステスト

    <TestMethod()> Public Sub 価格変更項目クラスの基本テスト()
        '生成
        Dim 変更項目1 As New 価格変更項目(New 商品ID("123456"),
                              価格変更項目.価格区分リスト.仕入,
                              New 金額(90000D),
                              New 金額(89800D),
                              New 日付(#03/01/2017#))

        '値取得
        Assert.AreEqual("123456", 変更項目1.商品ID.値)
        Assert.AreEqual(”仕入”, 変更項目1.価格区分.ToString)
        Assert.AreEqual(90000D, 変更項目1.現行価格.値)
        Assert.AreEqual(89800D, 変更項目1.変更後価格.値)
        Assert.AreEqual(#03/01/2017#, 変更項目1.適用開始日.値)

    End Sub

End Class
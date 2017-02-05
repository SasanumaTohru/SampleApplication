Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格変更項目クラステスト

    <TestMethod()> Public Sub 価格変更項目クラスの基本テスト()

        Dim foo As New 価格変更項目(New 商品ID("123456"),
                              価格変更項目.価格区分リスト.仕入,
                              New 金額(90000D),
                              New 金額(89800D),
                              New 日付(#03/01/2017#))

        Assert.AreEqual("123456", foo.商品ID.値)

    End Sub

End Class
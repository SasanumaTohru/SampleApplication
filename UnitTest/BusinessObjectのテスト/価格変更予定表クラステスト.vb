Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格変更予定表クラステスト

    <TestMethod()> Public Sub 価格変更リスト基本テスト()
        '価格変更項目の作成
        Dim 商品ID1 As 商品ID = New 商品ID("123456")
        Dim 価格変更項目1 As New 価格変更項目(商品ID1,
                      価格変更項目.価格区分リスト.仕入,
                      New 金額(90000D),
                      New 金額(89800D),
                      New 日付(#03/01/2017#))

        Assert.AreEqual(商品ID1.値, 価格変更項目1.商品ID.値)
        Assert.AreEqual(”仕入”, 価格変更項目1.価格区分.ToString)
        Assert.AreEqual(90000D, 価格変更項目1.現行価格.値)
        Assert.AreEqual(89800D, 価格変更項目1.変更後価格.値)
        Assert.AreEqual(#03/01/2017#, 価格変更項目1.適用開始日.値)

        '価格変更予定表に価格変更項目を追加する
        Dim 価格変更予定表 As New 価格変更予定表 '新価格表は、価格変更リストが具体化されたものである。
        'メモ：価格変更リストを価格変更予定表に変更
        価格変更予定表.項目を追加する(価格変更項目1)
        Assert.AreEqual(1, 価格変更予定表.項目数)

        '価格変更予定表の項目を参照する
        Assert.AreEqual(商品ID1.値, 価格変更予定表.項目(商品ID1).商品ID.値)

        '価格変更予定表の項目リストを参照する
        For Each 項目 As 価格変更項目 In 価格変更予定表.項目リスト
            Debug.Print(項目.現行価格.円マーク付書式)
        Next

    End Sub

End Class
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

        Dim 商品ID2 As 商品ID = New 商品ID("555555")
        Dim 価格変更項目2 As New 価格変更項目(商品ID2,
                      価格変更項目.価格区分リスト.販売,
                      New 金額(29800D),
                      New 金額(26000D),
                      New 日付(#03/10/2017#))

        '価格変更予定表に価格変更項目を追加する
        Dim 価格変更予定表 As New 価格変更予定表
        'メモ：価格変更リストを価格変更予定表に変更
        With 価格変更予定表
            .項目を追加する(価格変更項目1)
            .項目を追加する(価格変更項目2)
        End With
        Assert.AreEqual(2, 価格変更予定表.項目数)

        '価格変更予定表の項目を参照する
        Assert.AreEqual(商品ID1.値, 価格変更予定表.項目(商品ID1).商品ID.値)
        Assert.AreEqual("販売", 価格変更予定表.項目(商品ID2).価格区分.ToString)
        '価格変更予定表の項目リストを参照する
        For Each 項目 As 価格変更項目 In 価格変更予定表.項目リスト
            Select Case 項目.商品ID.値
                Case 商品ID1.値
                    Assert.AreEqual("2017年3月1日", 項目.適用開始日.西暦年月日文字列())
                Case 商品ID2.値
                    Assert.AreEqual("平成29年3月10日(金)", 項目.適用開始日.和暦年月日文字列(日付.曜日表示.あり))
            End Select
        Next

    End Sub

End Class
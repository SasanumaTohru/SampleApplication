Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格変更項目クラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 価格変更項目クラスの基本テスト()
        'テストデータの確認
        TestDataSetup.テスト用データ商品ID999999の確認()
        '生成
        Dim 変更項目1 As New 価格変更項目(New 商品ID("999999", 商品ID.コンストラクタオプション.参照),
                              価格変更項目.価格区分リスト.仕入,
                              New 金額(90000D),
                              New 金額(89800D),
                              New 日付(Date.Today.AddDays(1)))

        '値取得
        Assert.AreEqual("999999", 変更項目1.商品ID.値)
        Assert.AreEqual(”仕入”, 変更項目1.価格区分.ToString)
        Assert.AreEqual(90000D, 変更項目1.現行価格.値)
        Assert.AreEqual(89800D, 変更項目1.変更後価格.値)
        Assert.AreEqual(Date.Today.AddDays(1), 変更項目1.適用開始日.値)
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 価格変更項目クラス例外処理1()
        'テストデータの確認
        TestDataSetup.テスト用データ商品ID999999の確認()
        '価格区分は「価格変更項目クラス.価格区分リスト」から選択する。
        Dim 変更項目1 As New 価格変更項目(New 商品ID("999999", 商品ID.コンストラクタオプション.参照),
                              0,
                              New 金額(90000D),
                              New 金額(89800D),
                              New 日付(Date.Today.AddDays(1)))
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 価格変更項目クラス例外処理2()
        'テストデータの確認
        TestDataSetup.テスト用データ商品ID999999の確認()
        '価格区分は「価格変更項目クラス.価格区分リスト」から選択する。
        Dim 変更項目1 As New 価格変更項目(New 商品ID("999999", 商品ID.コンストラクタオプション.参照),
                              3,
                              New 金額(90000D),
                              New 金額(89800D),
                              New 日付(Date.Today.AddDays(1)))
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 価格変更項目クラス例外処理3()
        'テストデータの確認
        TestDataSetup.テスト用データ商品ID999999の確認()
        '摘要開始日は明日以降の日付が必要。
        Dim 変更項目1 As New 価格変更項目(New 商品ID("999999", 商品ID.コンストラクタオプション.参照),
                                価格変更項目.価格区分リスト.販売,
                                New 金額(90000D),
                                New 金額(89800D),
                                New 日付(#02/26/2017#))
    End Sub

End Class
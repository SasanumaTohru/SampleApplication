Imports SampleApplication.BusinessObject
Imports SampleApplication.FoundationObject
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 商品クラステスト

    'テストデータ
    '　商品1
    Const m_商品ID As String = "999999"
    Const m_メーカー As Integer = 3
    Const m_分類 As Integer = 4
    Const m_商品 As String = "アナログ一眼レフカメラ"
    Const m_単位 As Integer = 4

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 商品クラス基本テスト()

        TestDataSetup.指定した商品IDが存在する場合には削除する(m_商品ID)

        'Create
        Dim 新しい商品 As New 商品.商品(
            New 商品.商品ID(m_商品ID, 商品.商品ID.コンストラクタオプション.生成),
            New 商品.メーカー(New 商品.メーカーID(m_メーカー)),
            New 名称(m_商品),
            New 商品.分類(New 商品.分類コード(m_分類)),
            New 単位(単位.単位リスト.台))

        Assert.AreEqual(m_商品ID, 新しい商品.商品ID.値)
        Assert.AreEqual("キヤノン", 新しい商品.メーカー.名称.値)
        Assert.AreEqual(m_商品, 新しい商品.名称.値)
        Assert.AreEqual("カメラ", 新しい商品.分類.名称.値)
        Assert.AreEqual("台", 新しい商品.単位.名称.値)

        'Read
        Dim 取扱商品 As New 商品.取扱商品()
        取扱商品.追加する(新しい商品)

        Dim テストデータ As New TestDataSetup
        テストデータ.適用価格のテストデータを準備する()

        Assert.AreEqual(90D, 新しい商品.価格(商品.適用価格.価格.区分リスト.仕入, New 日付(Today)).値)
        Assert.AreEqual(100D, 新しい商品.価格(商品.適用価格.価格.区分リスト.販売, New 日付(Today)).値)
        Assert.AreEqual(10D, 新しい商品.個別売上利益(New 日付(Today)).値)

        Assert.AreEqual(85D, 新しい商品.価格(商品.適用価格.価格.区分リスト.仕入, New 日付(Today.AddDays(-1))).値)
        Assert.AreEqual(90D, 新しい商品.価格(商品.適用価格.価格.区分リスト.販売, New 日付(Today.AddDays(-1))).値)
        Assert.AreEqual(5D, 新しい商品.個別売上利益(New 日付(Today.AddDays(-1))).値)

        Assert.AreEqual(105D, 新しい商品.価格(商品.適用価格.価格.区分リスト.仕入, New 日付(Today.AddDays(1))).値)
        Assert.AreEqual(120D, 新しい商品.価格(商品.適用価格.価格.区分リスト.販売, New 日付(Today.AddDays(1))).値)
        Assert.AreEqual(15D, 新しい商品.個別売上利益(New 日付(Today.AddDays(1))).値)

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 条件に合う適用価格がない()
        Assert.AreEqual(110D, テストアイテム.商品.価格(商品.適用価格.価格.区分リスト.販売, New 日付(#1/1/2017#)).値)
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 照会日の個別売上利益が存在しない()
        Assert.AreEqual(0D, テストアイテム.商品.個別売上利益(New 日付(#1/1/2017#)).値)
    End Sub

End Class
Imports SampleApplication.BusinessObject
Imports SampleApplication.FoundationObject
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 商品クラステスト

    'テストデータ
    '　商品1
    Private Const m_S1商品ID As String = "123456”
    Private Const m_S1メーカー As String = "パナソニック"
    Private Const m_S1名称 As String = "テレビ"
    Private Const m_S1分類 As String = "AV機器"
    Private Const m_S1単位 As String = "台"

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 商品クラス基本テスト()

        '作成
        Dim 新しい商品 As New 商品.商品(
            New 商品.商品ID(m_S1商品ID, 商品.商品ID.コンストラクタオプション.生成),
            New 商品.メーカー(New 商品.メーカーID(2)),
            New 名称(m_S1名称),
            New 商品.分類(New 商品.分類コード(3)),
            New 単位(単位.単位リスト.台))

        Assert.AreEqual(m_S1商品ID, 新しい商品.商品ID.値)
        Assert.AreEqual(m_S1メーカー, 新しい商品.メーカー.名称.値)
        Assert.AreEqual(m_S1名称, 新しい商品.名称.値)
        Assert.AreEqual(m_S1分類, 新しい商品.分類.名称.値)
        Assert.AreEqual(m_S1単位, 新しい商品.単位.名称.値)

        '参照
        Assert.AreEqual(100D, テストデータ.テスト商品.価格(商品.価格.区分リスト.販売, New 日付(Today)).値)
        Assert.AreEqual(90D, テストデータ.テスト商品.価格(商品.価格.区分リスト.仕入, New 日付(Today)).値)
        Assert.AreEqual(90D, テストデータ.テスト商品.価格(商品.価格.区分リスト.販売, New 日付(#3/19/2017#)).値)
        Assert.AreEqual(110D, テストデータ.テスト商品.価格(商品.価格.区分リスト.販売, New 日付(#3/21/2017#)).値)
        Assert.AreEqual(110D, テストデータ.テスト商品.価格(商品.価格.区分リスト.販売, New 日付(#4/1/2017#)).値)

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 条件に合う適用価格がない()
        Assert.AreEqual(110D, テストデータ.テスト商品.価格(商品.価格.区分リスト.販売, New 日付(#1/1/2017#)).値)
    End Sub
End Class

Public Class テストデータ
    Public Shared テスト商品 As New 商品.商品(
            New 商品.商品ID("999999", 商品.商品ID.コンストラクタオプション.参照),
            New 商品.メーカー(New 商品.メーカーID(3)),
            New 名称("アナログ一眼レフカメラ"),
            New 商品.分類(New 商品.分類コード(4)),
            New 単位(単位.単位リスト.台))
End Class
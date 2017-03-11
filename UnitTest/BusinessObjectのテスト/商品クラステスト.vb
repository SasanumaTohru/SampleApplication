Imports SampleApplication

<TestClass()> Public Class 商品クラステスト

    'テストデータ
    '　商品1
    Private Const m_S1商品ID As String = "123456”
    Private Const m_S1メーカー As String = "パナソニック"
    Private Const m_S1名称 As String = "テレビ"
    Private Const m_S1分類 As String = "AV機器"
    Private Const m_S1単位 As String = "台"
    Private Const m_S1仕入価格 As Decimal = 80000D
    Private Const m_S1販売価格 As Decimal = 90000D
    '　商品2
    Private Const m_S2商品ID As String = "654321”
    Private Const m_S2メーカー As String = "ソニー"
    Private Const m_S2名称 As String = "ウォークマン"
    Private Const m_S2分類 As String = "AV機器"
    Private Const m_S2単位 As String = "台"
    Private Const m_S2仕入価格 As Decimal = 18000D
    Private Const m_S2販売価格 As Decimal = 21000D

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 商品クラス基本テスト()

        'ユースケース：新しい商品を登録する
        '商品クラスは完全コンストラクタ。
        'メーカープロパティは、メーカークラスのメーカーリストから選択する。
        '分類プロパティは、商品分類クラスの分類リストから選択する。
        Dim 新しい商品 As New BusinessObject.商品.商品(
            New BusinessObject.商品.商品ID(m_S1商品ID),
            New BusinessObject.商品.メーカー(New BusinessObject.商品.メーカーID(2)),
            New PrimitiveObject.名称(m_S1名称),
            New BusinessObject.商品.分類(New BusinessObject.商品.分類コード(3)),
            New FoundationObject.単位(FoundationObject.単位.単位リスト.台),
            New PrimitiveObject.金額(m_S1仕入価格),
            New PrimitiveObject.金額(m_S1販売価格))

        'ユースケース：登録した商品を参照する
        'すべてのプロパティは読み取り専用。
        Assert.AreEqual(m_S1商品ID, 新しい商品.商品ID.値)
        Assert.AreEqual(m_S1メーカー, 新しい商品.メーカー.名称.値)
        Assert.AreEqual(m_S1名称, 新しい商品.名称.値)
        Assert.AreEqual(m_S1分類, 新しい商品.分類.名称.値)
        Assert.AreEqual(m_S1単位, 新しい商品.単位.名称.値)
        Assert.AreEqual(m_S1仕入価格, 新しい商品.仕入価格.値)
        Assert.AreEqual(m_S1販売価格, 新しい商品.販売価格.値)
        Assert.AreEqual(m_S1販売価格 - m_S1仕入価格, 新しい商品.売上利益.値)

    End Sub

End Class
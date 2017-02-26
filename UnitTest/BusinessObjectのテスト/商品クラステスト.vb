Imports SampleApplication.PrimitiveObject
Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class 商品クラステスト

    'テストデータ
    '　商品1
    Private Const S1商品ID As String = "123456”
    Private Const S1メーカー As String = "パナソニック"
    Private Const S1名称 As String = "テレビ"
    Private Const S1分類 As String = "AV機器"
    Private Const S1仕入価格 As Decimal = 80000D
    Private Const S1販売価格 As Decimal = 90000D
    '　商品2
    Private Const S2商品ID As String = "654321”
    Private Const S2メーカー As String = "ソニー"
    Private Const S2名称 As String = "ウォークマン"
    Private Const S2分類 As String = "AV機器"
    Private Const S2仕入価格 As Decimal = 18000D
    Private Const S2販売価格 As Decimal = 21000D

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 商品クラス基本テスト()

        'ユースケース：新しい商品を登録する
        '商品クラスは完全コンストラクタ。
        'メーカープロパティは、メーカークラスのメーカーリストから選択する。
        '分類プロパティは、商品分類クラスの分類リストから選択する。
        Dim 新しい商品 As New 商品(
            New 商品ID(S1商品ID),
            New メーカー(New メーカーID(2)),
            New 名称(S1名称),
            New 分類(New 分類コード(3)),
            New 金額(S1仕入価格),
            New 金額(S1販売価格))

        'ユースケース：登録した商品を参照する
        'すべてのプロパティは読み取り専用。
        Assert.AreEqual(S1商品ID, 新しい商品.商品ID.値)
        Assert.AreEqual(S1メーカー, 新しい商品.メーカー.名称.値)
        Assert.AreEqual(S1名称, 新しい商品.名称.値)
        Assert.AreEqual(S1分類, 新しい商品.分類.名称.値)
        Assert.AreEqual(S1仕入価格, 新しい商品.仕入価格.値)
        Assert.AreEqual(S1販売価格, 新しい商品.販売価格.値)
        Assert.AreEqual(S1販売価格 - S1仕入価格, 新しい商品.売上利益.値)

    End Sub

End Class
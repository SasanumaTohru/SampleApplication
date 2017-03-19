Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SampleApplication.BusinessObject
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格クラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 価格クラスの基本テスト()

        Dim 価格を変更する商品 As New 商品.商品ID("999999")
        Dim 価格変更日 As New 日付(Today.AddDays(1))

        Dim 販売価格 As New 商品.適用価格(
            価格を変更する商品,
            商品.適用価格.区分リスト.販売,
            New 金額(100),
            価格変更日)

        Assert.AreEqual("999999", 販売価格.商品ID.値)
        Assert.AreEqual("販売", 販売価格.区分.ToString)
        Assert.AreEqual(100D, 販売価格.価格.値)
        Assert.AreEqual(#3/20/2017#, 販売価格.適用開始日.値)

        Dim 仕入価格 As New 商品.適用価格(価格を変更する商品, 商品.適用価格.区分リスト.仕入, New 金額(90), 価格変更日)
        Assert.AreEqual("仕入", 仕入価格.区分.ToString)

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 価格クラスの例外テスト1()
        '価格区分下限オーバー
        Dim 販売価格 As New 商品.適用価格(New 商品.商品ID("999999"), 0, New 金額(100), New 日付(Today.AddDays(1)))
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 価格クラスの例外テスト2()
        '価格区分上限オーバー
        Dim 販売価格 As New 商品.適用価格(New 商品.商品ID("999999"), 3, New 金額(100), New 日付(Today.AddDays(1)))
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 価格クラスの例外テスト3()
        '適用開始日が明日以降になっていない
        Dim 販売価格 As New 商品.適用価格(New 商品.商品ID("999999"), 商品.適用価格.区分リスト.販売, New 金額(100), New 日付(Today.AddDays(0)))
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 価格クラスの例外テスト4()
        '金額が1円以上ではない
        Dim 販売価格 As New 商品.適用価格(New 商品.商品ID("999999"), 商品.適用価格.区分リスト.販売, New 金額(0), New 日付(Today.AddDays(1)))
    End Sub

End Class
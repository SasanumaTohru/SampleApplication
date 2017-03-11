Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class 商品IDテスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 商品IDの基本テスト()

        Const ID As String = "000000"
        Dim 商品ID As New 商品ID(ID, 商品ID.コンストラクタオプション.生成)
        Assert.AreEqual(ID, 商品ID.値)

    End Sub

    '6桁の半角数字以外は使用できない。
    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理1()
        Dim 商品ID As New 商品ID("")
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理2()
        Dim 商品ID As New 商品ID("1234567")
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理2a()
        Dim 商品ID As New 商品ID("123-45")
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理3()
        Dim 商品ID As New 商品ID("123")
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理4()
        Dim 商品ID As New 商品ID("１２３４５６")
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理5()
        Dim 商品ID As New 商品ID("abcdef")
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 商品IDの重複は例外()
        '指定したキーがすでに存在する場合は例外とする。
        TestDataSetup.テスト用データ商品ID999999の確認()
        '重複したキーでの生成は例外になる。
        Dim 商品ID As New 商品ID("999999", 商品ID.コンストラクタオプション.生成)
    End Sub



End Class
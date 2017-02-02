<TestClass()> Public Class 商品IDテスト

    <TestMethod()> Public Sub 商品IDの基本テスト()

        Dim 商品ID As New SampleApplication.BusinessObject.商品ID("000000")
        Assert.AreEqual("000000", 商品ID.値)

    End Sub

    '6桁の半角数字以外は使用できない。

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理1()
        Dim 商品ID As New SampleApplication.BusinessObject.商品ID("")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理2()
        Dim 商品ID As New SampleApplication.BusinessObject.商品ID("1234567")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理2a()
        Dim 商品ID As New SampleApplication.BusinessObject.商品ID("123-45")
    End Sub


    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理3()
        Dim 商品ID As New SampleApplication.BusinessObject.商品ID("123")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理4()
        Dim 商品ID As New SampleApplication.BusinessObject.商品ID("１２３４５６")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理5()
        Dim 商品ID As New SampleApplication.BusinessObject.商品ID("abcdef")
    End Sub



End Class
<TestClass()> Public Class メーカーIDテスト

    <TestMethod()> Public Sub メーカーIDクラス基本テスト()
        Dim メーカーID As New SampleApplication.BusinessObject.商品.メーカーID(3)
        Assert.AreEqual(3, メーカーID.値)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub メーカークラス例外処理1()
        '登録のないIDは例外。
        Dim メーカーID As New SampleApplication.BusinessObject.商品.メーカーID(0)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub メーカークラス例外処理2()
        '登録のないIDは例外。
        Dim メーカーID As New SampleApplication.BusinessObject.商品.メーカーID(11)
    End Sub

End Class
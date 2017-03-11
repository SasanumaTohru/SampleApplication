<TestClass()> Public Class 自然数クラスのテスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 自然数クラス基本テスト()

        '自然数クラスは、０と正の整数とする。
        '自然数クラスは、数量を表す場合などに使用する。
        '数量の表現においても負の整数を用いる考え方もあるが、その場合は、真の意味を表す概念で表現する。
        '例）在庫-5個　→　在庫不足5個

        Dim 数量1 As New SampleApplication.PrimitiveObject.自然数(0)
        Dim 数量2 As New SampleApplication.PrimitiveObject.自然数(4294967295)
        Dim 数量3 As New SampleApplication.PrimitiveObject.自然数(2147483647)
        Assert.AreEqual(0UI, 数量1.値)
        Assert.AreEqual(4294967295UI, 数量2.値)

    End Sub

End Class
Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class メーカークラステスト

    <TestMethod()> Public Sub メーカークラスの基本テスト()

        'インスタンスの生成と値の参照
        Dim 製造元 As New メーカー(New メーカーID(3))
        Assert.AreEqual(3, 製造元.ID.値)
        Assert.AreEqual("キヤノン", 製造元.名称.値)

    End Sub

End Class
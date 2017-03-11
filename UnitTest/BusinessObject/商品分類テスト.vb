Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class 商品分類テスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 商品分類基本テスト()

        'インスタンスの生成と値の参照
        Dim 商品の分類 As New 分類(New 分類コード(3))
        Assert.AreEqual("AV機器", 商品の分類.名称.値)

    End Sub

End Class
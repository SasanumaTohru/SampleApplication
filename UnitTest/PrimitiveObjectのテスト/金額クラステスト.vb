Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class 金額クラステスト

    Private Const テスト値1 As Decimal = 123456789

    <TestMethod()> Public Sub 金額クラス基本テスト()

        Dim 金額 As New SampleApplication.PrimitiveObject.金額(テスト値1)

        Assert.AreEqual(テスト値1, 金額.値)

        Assert.AreEqual("123,456,789", 金額.桁区切値)

        '振る舞いの検討
        'Assert.AreEqual("123,456,789円", 金額.値)
        'Assert.AreEqual("\123,456,789", 金額.値)

    End Sub

End Class
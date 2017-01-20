Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class 名称クラステスト

    <TestMethod()> Public Sub 名称クラスのテスト()

        Dim foo As New SampleApplication.PrimitiveObject.名称("日本")
        Assert.AreEqual("日本", foo.値)

    End Sub

End Class
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class ページクラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub ページクラス基本テスト()
        Dim ページ As New SampleApplication.FoundationObject.ページ(
            New SampleApplication.PrimitiveObject.自然数(10),
            New SampleApplication.PrimitiveObject.自然数(2))
        Assert.AreEqual(1, ページ.現在のページ番号.値)
        Assert.AreEqual(5, ページ.最後のページ番号.値)
    End Sub

End Class
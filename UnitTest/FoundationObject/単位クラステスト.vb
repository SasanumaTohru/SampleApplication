Imports SampleApplication

<TestClass()> Public Class 単位クラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 単位クラスの基本テスト()

        Dim 単位 As New FoundationObject.単位(FoundationObject.単位.単位リスト.式)
        Assert.AreEqual("式", 単位.名称.値)
        Assert.AreEqual(FoundationObject.単位.単位リスト.式, 単位.値)

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 例外テスト1()
        Dim 単位 As New FoundationObject.単位(0)
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 例外テスト2()
        Dim 単位 As New FoundationObject.単位(6)
    End Sub

End Class
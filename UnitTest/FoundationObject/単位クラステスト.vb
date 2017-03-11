Imports SampleApplication.FoundationObject


<TestClass()> Public Class 単位クラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 単位クラスの基本テスト()

        '単位は列挙されたリストから選択する。
        Dim 単位 As New 単位(単位.単位リスト.式)
        'プロパティの参照。
        Assert.AreEqual("式", 単位.名称.値)
        Assert.AreEqual(5UI, 単位.ID.値)
        '単位リストの最大最小値を取得するためのSharedプロパティ。
        Assert.AreEqual(1, 単位.単位リストの最小値)
        Assert.AreEqual(5, 単位.単位リストの最大値)

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 単位クラスの例外テスト1()
        Dim 単位 As New 単位(単位.単位リストの最小値 - 1)
    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 単位クラスの例外テスト2()
        Dim 単位 As New 単位(単位.単位リストの最大値 + 1)
    End Sub

End Class
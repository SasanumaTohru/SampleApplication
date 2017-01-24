Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class 日時クラスのテスト

    <TestMethod()> Public Sub 日時クラス基本テスト()

        Dim 日付と時間 As New SampleApplication.PrimitiveObject.日時
        '日時クラスの初期値は「0001/01/01 0:00:00」とする。
        Assert.AreEqual("0001/01/01 0:00:00", 日付と時間.値.ToString)

    End Sub

End Class
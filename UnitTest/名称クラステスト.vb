Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class 名称クラステスト

    <TestMethod()> Public Sub 名称クラスのテスト()

        Const 入力値 As String = "日本"

        Const 不正値1 As String = "　日本　"
        Const 不正値2 As String = " 日本 "

        '名称クラスを生成する時は、名称となる文字列を設定する。
        Dim 国名 As New SampleApplication.PrimitiveObject.名称(入力値)
        '値プロパティは、名称となる文字列を返す。
        Assert.AreEqual(入力値, 国名.値)

        'インスタンス生成時に値の先頭や末尾にスペースが含まれている場合、コンストラクタで除去する。
        Dim 国名2 As New SampleApplication.PrimitiveObject.名称(不正値1)
        Assert.AreEqual(入力値, 国名2.値)
        Dim 国名3 As New SampleApplication.PrimitiveObject.名称(不正値2)
        Assert.AreEqual(入力値, 国名3.値)

    End Sub

End Class
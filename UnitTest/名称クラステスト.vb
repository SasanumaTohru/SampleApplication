Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class 名称クラステスト

    'テスト用パラメーター
    Const 正値 As String = "日本"

    Const 不正値1 As String = "　日本　"
    Const 不正値2 As String = " 日本 "
    Const 不正値3 As String = ""
    Const 不正値4 As String = " 　"

    <TestMethod()> Public Sub 名称クラスのテスト()

        '名称クラスを生成する時は、名称となる文字列を設定する。
        Dim 国名 As New SampleApplication.PrimitiveObject.名称(正値)
        '値プロパティは、名称となる文字列を返す。
        Assert.AreEqual(正値, 国名.値)

        'インスタンス生成時に値の先頭や末尾にスペースが含まれている場合、コンストラクタで除去する。
        Dim 国名2 As New SampleApplication.PrimitiveObject.名称(不正値1)
        Assert.AreEqual(正値, 国名2.値)
        Dim 国名3 As New SampleApplication.PrimitiveObject.名称(不正値2)
        Assert.AreEqual(正値, 国名3.値)

    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub 例外処理1()
        '次の場合、インスタンス生成時に例外を発生する。
        '文字列０
        Dim 国名4 As New SampleApplication.PrimitiveObject.名称(不正値3)
    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub 例外処理2()
        '次の場合、インスタンス生成時に例外を発生する。
        '文字列がスペースのみ
        Dim 国名5 As New SampleApplication.PrimitiveObject.名称(不正値4)
    End Sub

End Class
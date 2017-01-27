<TestClass()> Public Class 必須文字列クラステスト

    'テスト用パラメーター
    Private Const テスト値1 As String = "日本"
    Private Const テスト値2 As String = "　今日の天気は　"

    <TestMethod()> Public Sub 必須文字列クラス基本テスト()

        '必須文字列クラスを生成する時は、値となる文字列を設定する。
        Dim 必須の文字列1 As New SampleApplication.PrimitiveObject.必須文字列(テスト値1)
        '値プロパティは読み取り専用である。
        Assert.AreEqual(テスト値1, 必須の文字列1.値)

        '必須文字列は、先頭と末尾のスペースを許容する。
        Dim 必須文字列2 As New SampleApplication.PrimitiveObject.必須文字列(テスト値2)
        Assert.AreEqual(テスト値2, 必須文字列2.値)

    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub 必須文字列クラス例外処理1()

        'インスタンスの生成時にセットする文字列が文字列0ならば例外を発生する。
        Dim 必須の文字列 As New SampleApplication.PrimitiveObject.必須文字列(String.Empty)

    End Sub

    <TestMethod()> <ExpectedException(GetType(System.Exception))> Public Sub 必須文字列クラス例外処理2()

        'インスタンスの生成時にセットする文字列がスペースのみならば例外を発生する。
        Dim 必須の文字列 As New SampleApplication.PrimitiveObject.必須文字列("　　　　      　　　　　")

    End Sub

End Class

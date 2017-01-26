Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 日付クラスのテスト

    <TestMethod()> Public Sub 日付クラス基本テスト()

        'インスタンスの生成時に日付をセットする。
        Dim 誕生日 As New 日付(#5/25/2017#)
        Assert.AreEqual(#05/25/2017#, 誕生日.値)

        '振る舞いの検討
        'DateTime型のデフォルト機能
        Assert.AreEqual("2017/05/25", 誕生日.値.ToShortDateString)
        'オリジナルの実装
        Assert.AreEqual("2017年5月25日", 誕生日.西暦年月日文字列())
        Assert.AreEqual("2017年5月25日", 誕生日.西暦年月日文字列(日付.曜日表示.なし))
        Assert.AreEqual("2017年5月25日(木)", 誕生日.西暦年月日文字列(日付.曜日表示.あり))
        Assert.AreEqual("平成29年5月25日", 誕生日.和暦年月日文字列())
        Assert.AreEqual("平成29年5月25日", 誕生日.和暦年月日文字列(日付.曜日表示.なし))
        Assert.AreEqual("平成29年5月25日(木)", 誕生日.和暦年月日文字列(日付.曜日表示.あり))

    End Sub

End Class

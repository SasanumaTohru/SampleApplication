Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 日時クラスのテスト

    <TestMethod()> Public Sub 日時クラス基本テスト()

        'インスタンスの生成時に日付をセットする。
        Dim 日付と時間 As New 日時(#5/25/2017#)
        Assert.AreEqual(#05/25/2017 00:00:00#, 日付と時間.値)

        'インスタンスの生成時に日時をセットする。
        Dim 日付と時間2 As New 日時(#5/25/2017 08:45:00  PM#)
        Assert.AreEqual(#05/25/2017 08:45:00 PM#, 日付と時間2.値)

        '振る舞いの検討
        'DateTime型のデフォルト機能
        Assert.AreEqual("2017/05/25", 日付と時間.値.ToShortDateString)
        Assert.AreEqual("20:45", 日付と時間2.値.ToShortTimeString)
        'オリジナルの実装
        Assert.AreEqual("2017年5月25日", 日付と時間.西暦年月日(日時.曜日表示.なし))
        Assert.AreEqual("2017年5月25日(木)", 日付と時間.西暦年月日(日時.曜日表示.あり))
        Assert.AreEqual("平成29年5月25日", 日付と時間.和暦年月日(日時.曜日表示.なし))
        Assert.AreEqual("平成29年5月25日(木)", 日付と時間.和暦年月日(日時.曜日表示.あり))

    End Sub

End Class

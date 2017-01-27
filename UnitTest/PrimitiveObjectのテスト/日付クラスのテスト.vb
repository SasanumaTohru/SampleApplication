Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 日付クラスのテスト

    <TestMethod()> Public Sub 日付クラス基本テスト()

        'インスタンスの生成時に日付をセットする。
        Dim 誕生日 As New 日付(#5/25/2017#)
        '値プロパティは読み取り専用である。
        Assert.AreEqual(#05/25/2017#, 誕生日.値)

        'その他の振る舞い
        '値プロパティはDateTime型である。
        Assert.AreEqual("2017/05/25", 誕生日.値.ToShortDateString)
        'オリジナルの日付取得プロパティは次のとおり。
        Assert.AreEqual("2017年5月25日", 誕生日.西暦年月日文字列()) 'オプションは省略可能でデフォルトは「曜日表示なし」
        Assert.AreEqual("2017年5月25日", 誕生日.西暦年月日文字列(日付.曜日表示.なし))
        Assert.AreEqual("2017年5月25日(木)", 誕生日.西暦年月日文字列(日付.曜日表示.あり))
        Assert.AreEqual("平成29年5月25日", 誕生日.和暦年月日文字列()) 'オプションは省略可能でデフォルトは「曜日表示なし」
        Assert.AreEqual("平成29年5月25日", 誕生日.和暦年月日文字列(日付.曜日表示.なし))
        Assert.AreEqual("平成29年5月25日(木)", 誕生日.和暦年月日文字列(日付.曜日表示.あり))

    End Sub

End Class

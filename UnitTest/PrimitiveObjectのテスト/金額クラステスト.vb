Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 金額クラステスト

    Private Const テスト値1 As Decimal = 123456789D

    <TestMethod()> Public Sub 金額クラス基本テスト()

        'インスタンスの生成時に値を設定する。
        Dim 金額 As New 金額(テスト値1)
        '値プロパティは読み取り専用である。
        Assert.AreEqual(テスト値1, 金額.値)

        'その他の読み取り専用プロパティ
        '値を円マーク付き文字列を返す。
        Assert.AreEqual("\123,456,789", 金額.円マーク付書式)
        '値を円単位の文字列にして返す。
        Assert.AreEqual("123,456,789", 金額.表示単位指定(金額.表示単位リスト.円))
        '　オプションは省略可能。デフォルトは円単位。
        Assert.AreEqual("123,456,789", 金額.表示単位指定())
        '値を千円単位の文字列にして返す。
        Assert.AreEqual("123,457", 金額.表示単位指定(金額.表示単位リスト.千円))
        '値を百万円単位の文字列にして返す。
        Assert.AreEqual("123", 金額.表示単位指定(金額.表示単位リスト.百万))

        '単位変換した場合は、小数点第一位で四捨五入する。
        Const n1 As Decimal = 100000D
        Const n2 As Decimal = 200400D
        Const n3 As Decimal = 300500D
        Const n4 As Decimal = 400900D
        '四捨五入された値のテスト
        Dim t1 As New 金額(n1)
        Assert.AreEqual("100", t1.表示単位指定(金額.表示単位リスト.千円))
        Dim t2 As New 金額(n2)
        Assert.AreEqual("200", t2.表示単位指定(金額.表示単位リスト.千円))
        Dim t3 As New 金額(n3)
        Assert.AreEqual("301", t3.表示単位指定(金額.表示単位リスト.千円))
        Dim t4 As New 金額(n4)
        Assert.AreEqual("401", t4.表示単位指定(金額.表示単位リスト.千円))

    End Sub

End Class

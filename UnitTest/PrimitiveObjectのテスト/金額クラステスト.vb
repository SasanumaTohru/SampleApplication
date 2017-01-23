Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 金額クラステスト

    Private Const テスト値1 As Decimal = 123456789

    <TestMethod()> Public Sub 金額クラス基本テスト()

        'インスタンスの生成時に値を設定する。
        Dim 金額 As New 金額(テスト値1)
        '値プロパティは読み取り専用である。
        Assert.AreEqual(テスト値1, 金額.値)

        '振る舞いの検討
        Assert.AreEqual("123,456,789", 金額.桁区切値)
        Assert.AreEqual("\123,456,789", 金額.円マーク付書式)
        Assert.AreEqual("123,456,789", 金額.表示単位指定(金額.表示単位リスト.円))
        Assert.AreEqual("123,457", 金額.表示単位指定(金額.表示単位リスト.千円))
        Assert.AreEqual("123", 金額.表示単位指定(金額.表示単位リスト.百万))

        '単位変換した場合は、小数点第一位で四捨五入する。
        Const n1 As Decimal = 100000
        Const n2 As Decimal = 100400
        Const n3 As Decimal = 100500
        Const n4 As Decimal = 100900

        Dim t1 As New 金額(n1)
        Assert.AreEqual("100", t1.表示単位指定(金額.表示単位リスト.千円))
        Dim t2 As New 金額(n2)
        Assert.AreEqual("100", t1.表示単位指定(金額.表示単位リスト.千円))
        Dim t3 As New 金額(n3)
        Assert.AreEqual("101", t3.表示単位指定(金額.表示単位リスト.千円))
        Dim t4 As New 金額(n4)
        Assert.AreEqual("101", t4.表示単位指定(金額.表示単位リスト.千円))


        '負数
        Dim マイナスの金額 As New 金額(-123456D)
        Assert.AreEqual(-123456D, マイナスの金額.値)

    End Sub

End Class

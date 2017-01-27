﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 商品クラステスト

    'テストデータ
    '　商品1
    Private Const S1メーカー製品コード As String = "ABC123”
    Private Const S1メーカー As String = "パナソニック"
    Private Const S1商品名 As String = "テレビ"
    Private Const S1分類 As String = "AV機器"
    Private Const S1仕入金額 As Decimal = 80000D
    Private Const S1販売価格 As Decimal = 90000D
    '　商品2
    Private Const S2メーカー製品コード As String = "XYZ987”
    Private Const S2メーカー As String = "ソニー"
    Private Const S2商品名 As String = "ウォークマン"
    Private Const S2分類 As String = "AV機器"
    Private Const S2仕入金額 As Decimal = 18000D
    Private Const S2販売価格 As Decimal = 21000D

    <TestMethod()> Public Sub 商品クラス基本テスト()

        '新しい商品を登録する
        Dim 新しい商品 As New SampleApplication.BusinessObject.商品(
            New 必須文字列(S1メーカー製品コード),
            New 名称(S1メーカー),
            New 名称(S1商品名),
            New 必須文字列(S1分類),
            New 金額(S1仕入金額),
            New 金額(S1販売価格))

        '登録した商品を参照する
        Assert.AreEqual(S1メーカー製品コード, 新しい商品.メーカー製品コード.値)
        Assert.AreEqual(S1メーカー, 新しい商品.メーカー.値)
        Assert.AreEqual(S1商品名, 新しい商品.商品名.値)
        Assert.AreEqual(S1分類, 新しい商品.分類.値)
        Assert.AreEqual(S1仕入金額, 新しい商品.仕入金額.値)
        Assert.AreEqual(S1販売価格, 新しい商品.販売価格.値)

    End Sub

End Class
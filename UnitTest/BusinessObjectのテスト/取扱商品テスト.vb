Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 取扱商品テスト

    <TestMethod()> <TestCategory("基本テスト")> <TestCategory("基本テスト")> Public Sub 取扱商品テストの基本テスト()

        Dim 商品1 As New 商品(New 商品ID("555555"),
                          New メーカー(New メーカーID(1)), New 名称("カメラ"), New 分類(New 分類コード(1)),
                          New 金額(27000), New 金額(30000))

        Dim 商品2 As New 商品(New 商品ID("666666"),
                          New メーカー(New メーカーID(2)), New 名称("ビデオカメラ"), New 分類(New 分類コード(3)),
                          New 金額(90000), New 金額(100000))

        Dim 取扱商品 As New 取扱商品
        With 取扱商品
            .追加する(商品1)
            .追加する(商品2)
        End With
        '取扱商品数
        Assert.AreEqual(2UI, 取扱商品.数.値)
        '特定商品へのアクセス
        Assert.AreEqual("カメラ", 取扱商品.商品(New 商品ID(555555)).名称.値)
        '全取扱商品の参照
        For Each 商品 In 取扱商品.一覧
            Debug.Print(商品.商品ID.値)
            Debug.Print(商品.メーカー.ID.値)
            Debug.Print(商品.メーカー.名称.値)
            Debug.Print(商品.名称.値)
            Debug.Print(商品.分類.名称.値)
            Debug.Print(商品.仕入価格.円マーク付書式)
            Debug.Print(商品.販売価格.円マーク付書式)
            Debug.Print(商品.売上利益.円マーク付書式)
        Next




    End Sub

End Class
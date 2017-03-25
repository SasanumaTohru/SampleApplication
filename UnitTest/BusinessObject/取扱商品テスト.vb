Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.FoundationObject
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 取扱商品テスト

    <TestMethod()> <TestCategory("基本テスト")> <TestCategory("基本テスト")> Public Sub 取扱商品テストの基本テスト()

        'テストに使うID
        Const 商品1のID As String = "555555"
        Const 商品2のID As String = "666666"

        ''商品1の生成
        Dim 商品1 As New 商品(New 商品ID(商品1のID, 商品ID.コンストラクタオプション.生成),
                          New メーカー(New メーカーID(1)),
                          New 名称("カメラ"),
                          New 分類(New 分類コード(4)),
                          New 単位(単位.単位リスト.台))

        '商品2の生成
        Dim 商品2 As New 商品(New 商品ID(商品2のID, 商品ID.コンストラクタオプション.生成),
                          New メーカー(New メーカーID(2)),
                          New 名称("ビデオカメラ"),
                          New 分類(New 分類コード(3)),
                          New 単位(単位.単位リスト.台))

        '取扱商品の生成
        Dim 取扱商品 As New 取扱商品
        Dim 商品を追加する前の商品数 As Integer = 取扱商品.数.値
        '取扱商品に商品を追加する
        With 取扱商品
            .追加する(商品1)
            .追加する(商品2)
        End With
        '商品追加後の取扱商品数
        Assert.AreEqual(CType(商品を追加する前の商品数 + 2, UInteger), 取扱商品.数.値)
        '特定商品へのアクセス
        Assert.AreEqual("カメラ", 取扱商品.商品(New 商品ID(商品1のID)).名称.値)
        '全取扱商品の参照
        For Each 商品 In 取扱商品.リスト
            Debug.Print(商品.商品ID.値)
            Debug.Print(商品.メーカー.ID.値)
            Debug.Print(商品.メーカー.名称.値)
            Debug.Print(商品.名称.値)
            Debug.Print(商品.分類.名称.値)
            Debug.Print(商品.単位.名称.値)
            Debug.Print("============================")
        Next
        テストデータの削除(商品1のID, 商品2のID)
    End Sub

    ''' <summary>
    ''' テストに使用したデータを削除します。
    ''' </summary>
    ''' <param name="商品1のID"></param>
    ''' <param name="商品2のID"></param>
    Private Shared Sub テストデータの削除(商品1のID As String, 商品2のID As String)
        TestDataSetup.指定した商品IDが存在する場合には削除する(商品1のID)
        TestDataSetup.指定した商品IDが存在する場合には削除する(商品2のID)
    End Sub

End Class
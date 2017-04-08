Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.FoundationObject
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 取扱商品テスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 取扱商品テストの基本テスト()

        テストデータの削除("555555", "666666")
        'テストに使うID
        Dim 商品1のID As New 商品ID("555555", 商品ID.コンストラクタオプション.生成)
        Dim 商品2のID As New 商品ID("666666", 商品ID.コンストラクタオプション.生成)

        Dim テストデータ設定 As New TestDataSetup
        テストデータ設定.適用価格テーブルをクリアする("555555")
        テストデータ設定.適用価格テーブルをクリアする("666666")

        Dim 商品1の価格 As New 適用価格.価格(商品1のID, 適用価格.価格.区分リスト.販売, New 金額(389840), New 日付(#5/25/2000#))
        Dim 商品2の価格 As New 適用価格.価格(商品2のID, 適用価格.価格.区分リスト.販売, New 金額(2870), New 日付(#5/25/2000#))
        Dim 価格変更スケジュール As New 適用価格.スケジュール
        With 価格変更スケジュール
            .追加する(商品1の価格)
            .追加する(商品2の価格)
        End With

        ''商品1の生成
        Dim 商品1 As New 商品(商品1のID,
                          New メーカー(New メーカーID(1)),
                          New 名称("カメラ"),
                          New 分類(New 分類コード(4)),
                          New 単位(単位.単位リスト.台))

        '商品2の生成
        Dim 商品2 As New 商品(商品2のID,
                          New メーカー(New メーカーID(2)),
                          New 名称("ビデオカメラ"),
                          New 分類(New 分類コード(3)),
                          New 単位(単位.単位リスト.台))

        '取扱商品の生成
        Dim 取扱商品 As New 取扱商品()
        Dim 商品を追加する前の商品数 As Integer = 取扱商品.現在のページの商品数.値
        '取扱商品に商品を追加する
        With 取扱商品
            .追加する(商品1)
            .追加する(商品2)
        End With
        '商品追加後の取扱商品数
        Assert.AreEqual(商品を追加する前の商品数 + 2, 取扱商品.現在のページの商品数.値)
        '商品へのアクセス
        Assert.AreEqual("カメラ", 取扱商品.商品(商品1.商品ID).名称.値)
        Assert.AreEqual(389840D, 取扱商品.商品(商品1.商品ID).価格(適用価格.価格.区分リスト.販売, New 日付(Today)).値)
        Assert.AreEqual("ビデオカメラ", 取扱商品.商品(商品2.商品ID).名称.値)
        Assert.AreEqual(2870D, 取扱商品.商品(商品2.商品ID).価格(適用価格.価格.区分リスト.販売, New 日付(Today)).値)

        テストデータの削除(商品1のID.値, 商品2のID.値)
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
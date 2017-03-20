Imports SampleApplication.BusinessObject
Imports SampleApplication.FoundationObject
Imports SampleApplication.PrimitiveObject
Public Class テストデータ
    Public Shared テスト商品 As New 商品.商品(
            New 商品.商品ID("999999", 商品.商品ID.コンストラクタオプション.参照),
            New 商品.メーカー(New 商品.メーカーID(3)),
            New 名称("アナログ一眼レフカメラ"),
            New 商品.分類(New 商品.分類コード(4)),
            New 単位(単位.単位リスト.台))
End Class
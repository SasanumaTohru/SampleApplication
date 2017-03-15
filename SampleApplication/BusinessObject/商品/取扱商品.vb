Namespace BusinessObject.商品
    Public Class 取扱商品
        Inherits CollectionBase
        Private m_List As New List(Of 商品)

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        Public Sub New()
            データベースから商品を読み込む()
        End Sub

        ''' <summary>
        ''' データベースから商品を読み込みます。
        ''' </summary>
        Private Sub データベースから商品を読み込む()
            Using MyDB As New SampleAppDBEntities
                Dim レコードセット = From レコード In MyDB.M_商品

                For Each 商品データ In レコードセット
                    Dim 商品 As New 商品(商品データ)
                    リストに追加する(商品)
                Next
            End Using
        End Sub

        ''' <summary>
        ''' 商品を追加します。
        ''' </summary>
        ''' <param name="商品"></param>
        Public Sub 追加する(商品 As 商品)
            商品を保存する(商品)
            リストに追加する(商品)
        End Sub

        ''' <summary>
        ''' リストに商品を追加します。
        ''' </summary>
        ''' <param name="商品"></param>
        Private Sub リストに追加する(商品 As 商品)
            m_List.Add(商品)
        End Sub

        ''' <summary>
        ''' データベースに商品を保存します。
        ''' </summary>
        ''' <param name="商品"></param>
        Private Sub 商品を保存する(商品 As 商品)
            Using MyDB As New SampleAppDBEntities
                Dim 追加する商品 As New M_商品 With {
                    .商品ID = 商品.商品ID.値,
                    .メーカー = 商品.メーカー.ID.値,
                    .商品名 = 商品.名称.値,
                    .分類 = 商品.分類.ID.値,
                    .単位 = CType(商品.単位.ID.値, Integer),
                    .仕入価格 = 商品.仕入価格.値,
                    .販売価格 = 商品.販売価格.値
                    }
                MyDB.M_商品.Add(追加する商品)
                MyDB.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' 商品の一覧を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property リスト As List(Of 商品)
            Get
                Return m_List
            End Get
        End Property

        ''' <summary>
        ''' 取扱商品の点数を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 数() As PrimitiveObject.自然数
            Get
                Return New PrimitiveObject.自然数(CType(m_List.Count, UInteger))
            End Get
        End Property

        ''' <summary>
        ''' 指定された商品IDの商品を返します。
        ''' </summary>
        ''' <param name="ID"></param>
        ''' <returns></returns>
        Public ReadOnly Property 商品(ID As 商品ID) As 商品
            Get
                Dim レコードセット = From レコード In m_List Where レコード.商品ID.値 = ID.値

                Return レコードセット.First
            End Get
        End Property

    End Class
End Namespace
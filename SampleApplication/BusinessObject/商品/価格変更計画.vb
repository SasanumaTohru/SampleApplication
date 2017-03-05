Namespace BusinessObject.商品
    Public Class 価格変更計画

        Inherits CollectionBase

        Private m_List As New List(Of 価格変更項目)

        ''' <summary>
        ''' 項目を追加するメソッド
        ''' </summary>
        ''' <param name="項目"></param>
        Public Sub 項目を追加する(項目 As 価格変更項目)
            m_List.Add(項目)
        End Sub

        ''' <summary>
        ''' 項目数プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 項目数 As Integer
            Get
                Return m_List.Count
            End Get
        End Property

        ''' <summary>
        ''' 項目リストプロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 項目リスト As List(Of 価格変更項目)
            Get
                Return m_List
            End Get
        End Property

        ''' <summary>
        ''' 項目プロパティ
        ''' </summary>
        ''' <param name="商品ID"></param>
        ''' <returns></returns>
        Public ReadOnly Property 項目(商品ID As 商品ID) As 価格変更項目
            Get
                Dim レコードセット = From レコード In m_List Where レコード.商品ID.値 = 商品ID.値

                Return レコードセット.First
            End Get
        End Property

    End Class
End Namespace

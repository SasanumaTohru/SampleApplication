Namespace BusinessObject.商品
    Public Class 価格変更予定表

        Inherits CollectionBase

        Private m_List As New List(Of 価格変更項目)

        Public Sub 項目を追加する(項目 As 価格変更項目)
            m_List.Add(項目)
        End Sub

        Public ReadOnly Property 項目数 As Integer
            Get
                Return m_List.Count
            End Get
        End Property

        Public ReadOnly Property 項目リスト As IList
            Get
                Return m_List
            End Get
        End Property

        Public ReadOnly Property 項目(商品ID As 商品ID) As 価格変更項目
            Get
                Dim rs = From o In m_List Where o.商品ID.値 = 商品ID.値

                Return rs.First
            End Get
        End Property
    End Class
End Namespace

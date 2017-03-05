Namespace BusinessObject.商品
    Public Class 取扱商品
        Inherits CollectionBase
        Private m_List As New List(Of 商品)

        Public Sub 追加する(商品 As 商品)
            m_List.Add(商品)
        End Sub

        Public ReadOnly Property 一覧 As List(Of 商品)
            Get
                Return m_List
            End Get
        End Property

        Public ReadOnly Property 数() As PrimitiveObject.自然数
            Get
                Return New PrimitiveObject.自然数(CType(m_List.Count, UInteger))
            End Get
        End Property

        Public ReadOnly Property 商品(ID As 商品ID) As 商品
            Get
                Dim レコードセット = From レコード In m_List Where レコード.商品ID.値 = ID.値

                Return レコードセット.First
            End Get
        End Property

    End Class
End Namespace
Namespace BusinessObject.商品

    Public Class 分類リスト

        Inherits CollectionBase
        Private m_List As New List(Of 分類)

        Public Sub New()
            Using MyDB As New SampleAppDBEntities
                Dim rs = From o In MyDB.M_商品分類

                For Each p In rs
                    Dim 分類 As New 分類(p)
                    m_List.Add(分類)
                Next
            End Using
        End Sub

        Public ReadOnly Property リスト As IList(Of 分類)
            Get
                Return m_List
            End Get
        End Property

    End Class
End Namespace

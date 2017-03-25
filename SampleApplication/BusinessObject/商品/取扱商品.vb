Namespace BusinessObject.商品
    Public Class 取扱商品
        Inherits CollectionBase
        Private m_リスト As New List(Of 商品)

        Public Sub New()
            データベースから商品を読み込む()
        End Sub

        Private Sub データベースから商品を読み込む()
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim 商品の集合 = From 集合の要素 In MyDB.M_商品

                    For Each 商品データ In 商品の集合
                        Dim 商品 As New 商品(商品データ)
                        リストに追加する(商品)
                    Next
                End Using
            Catch ex As Exception
                Throw New Exception("データベースを参照できませんでした。")
            End Try
        End Sub

        Public Sub 追加する(商品 As 商品)
            データベースに保存する(商品)
            リストに追加する(商品)
        End Sub

        Private Sub リストに追加する(商品 As 商品)
            m_リスト.Add(商品)
        End Sub

        Private Sub データベースに保存する(商品 As 商品)
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim 追加する商品 As New M_商品 With {
                    .商品ID = 商品.商品ID.値,
                    .メーカー = 商品.メーカー.ID.値,
                    .商品名 = 商品.名称.値,
                    .分類 = 商品.分類.ID.値,
                    .単位 = CType(商品.単位.ID.値, Integer)
                }
                    With MyDB
                        .M_商品.Add(追加する商品)
                        .SaveChanges()
                    End With
                End Using
            Catch ex As Exception
                Throw New Exception("データベースへの保存に失敗しました。")
            End Try
        End Sub

        Public ReadOnly Property リスト As List(Of 商品)
            Get
                Return m_リスト
            End Get
        End Property

        Public ReadOnly Property 数() As PrimitiveObject.自然数
            Get
                Return New PrimitiveObject.自然数(CType(m_リスト.Count, UInteger))
            End Get
        End Property

        Public ReadOnly Property 商品(ID As 商品ID) As 商品
            Get
                Dim ヒットリスト = From レコード In m_リスト Where レコード.商品ID.値 = ID.値

                Return ヒットリスト.First
            End Get
        End Property

    End Class
End Namespace
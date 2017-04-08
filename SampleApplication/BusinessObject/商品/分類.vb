Namespace BusinessObject.商品
    Public Class 分類

        Private m_コード As 分類コード
        Private m_名称 As PrimitiveObject.名称

        Public Sub New(コード As 分類コード)
            m_コード = コード
            m_名称 = 分類名を取得する(コード)
        End Sub

        Private Function 分類名を取得する(コード As 分類コード) As PrimitiveObject.名称
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim ヒットリスト = From レコード In MyDB.M_商品分類 Where レコード.コード = コード.値

                    Return New PrimitiveObject.名称(ヒットリスト.First.名称)
                End Using
            Catch ex As Exception
                Throw New Exception("データベースを参照できませんでした。")
            End Try
        End Function

        Public Sub New(分類 As M_商品分類)
            m_コード = New 分類コード(分類)
            m_名称 = New PrimitiveObject.名称(分類.名称)
        End Sub

        Public ReadOnly Property ID As 分類コード
            Get
                Return m_コード
            End Get
        End Property

        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return m_名称
            End Get
        End Property

    End Class
End Namespace
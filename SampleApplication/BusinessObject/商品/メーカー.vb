Namespace BusinessObject.商品
    Public Class メーカー

        Private m_ID As メーカーID
        Private m_名称 As PrimitiveObject.名称

        Public Sub New（ID As メーカーID)
            m_ID = ID
            m_名称 = メーカー名を取得する(ID)
        End Sub

        Private Function メーカー名を取得する(ID As メーカーID) As PrimitiveObject.名称
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim ヒットリスト = From レコード In MyDB.M_メーカー Where レコード.ID = ID.値

                    Return New PrimitiveObject.名称(ヒットリスト.First.名称)
                End Using
            Catch ex As Exception
                Throw New Exception("データベースを参照できませんでした。")
            End Try
        End Function

        Public ReadOnly Property ID As メーカーID
            Get
                Return m_ID
            End Get
        End Property

        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return m_名称
            End Get
        End Property

    End Class
End Namespace

Namespace BusinessObject.商品
    Public Class メーカー

        Private m_ID As メーカーID
        Private m_名称 As PrimitiveObject.名称

        ''' <summary>
        ''' 参照用コンストラクタ
        ''' </summary>
        ''' <param name="ID"></param>
        Public Sub New（ID As メーカーID)
            m_ID = ID
            m_名称 = メーカー名を取得する(ID)
        End Sub

        ''' <summary>
        ''' メーカー名を取得するメソッド
        ''' </summary>
        ''' <param name="ID"></param>
        ''' <returns></returns>
        Private Function メーカー名を取得する(ID As メーカーID) As PrimitiveObject.名称
            Using MyDB As New SampleAppDBEntities
                Dim ヒットリスト = From レコード In MyDB.M_メーカー Where レコード.ID = ID.値

                Return New PrimitiveObject.名称(ヒットリスト.First.名称)
            End Using
        End Function

        ''' <summary>
        ''' IDプロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ID As メーカーID
            Get
                Return m_ID
            End Get
        End Property

        ''' <summary>
        ''' 名称プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return m_名称
            End Get
        End Property

    End Class
End Namespace

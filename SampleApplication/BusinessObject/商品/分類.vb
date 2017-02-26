Namespace BusinessObject.商品
    Public Class 分類

        Private m_コード As 分類コード
        Private m_名称 As PrimitiveObject.名称

        ''' <summary>
        ''' コンストラクタ。分類リストから値を選択します。
        ''' </summary>
        ''' <param name="コード"></param>
        Public Sub New(コード As 分類コード)
            m_コード = コード
            m_名称 = 分類名を取得する(コード)
        End Sub

        ''' <summary>
        ''' 分類名を取得するメソッド
        ''' </summary>
        ''' <param name="コード"></param>
        ''' <returns></returns>
        Private Function 分類名を取得する(コード As 分類コード) As PrimitiveObject.名称
            Using MyDB As New SampleAppDBEntities
                Dim レコードセット = From レコード In MyDB.M_商品分類 Where レコード.コード = コード.値

                Return New PrimitiveObject.名称(レコードセット.First.名称)
            End Using
        End Function

        ''' <summary>
        ''' IDプロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ID As 分類コード
            Get
                Return m_コード
            End Get
        End Property

        ''' <summary>
        ''' 分類の名称を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return m_名称
            End Get
        End Property

    End Class
End Namespace

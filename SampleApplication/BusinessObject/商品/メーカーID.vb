Namespace BusinessObject.商品
    Public Class メーカーID

        Private m_値 As Integer = 0

        ''' <summary>
        ''' 参照用コンストラクタ
        ''' </summary>
        ''' <param name="ID"></param>
        Public Sub New(ID As Integer)
            Using MyDB As New SampleAppDBEntities
                Dim レコードセット = From レコード In MyDB.M_メーカー Where レコード.ID = ID

                'バリデーション
                If レコードセット.Count <> 1 Then
                    Throw New Exception("指定されたメーカーは存在しません。")
                End If
                '本処理
                m_値 = ID
            End Using
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As Integer
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

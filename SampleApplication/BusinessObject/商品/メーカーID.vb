Namespace BusinessObject.商品
    Public Class メーカーID

        Private m_値 As Integer


        ''' <summary>
        ''' 参照用コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As Integer)
            IDが存在する(値)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' IDの存在を確認するメソッド
        ''' </summary>
        ''' <param name="ID"></param>
        Private Sub IDが存在する(ID As Integer)
            Using MyDB As New SampleAppDBEntities
                Dim レコードセット = From レコード In MyDB.M_メーカー Where レコード.ID = ID

                If レコードセット.Count <> 1 Then
                    Throw New Exception("指定されたメーカーは存在しません。")
                End If
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

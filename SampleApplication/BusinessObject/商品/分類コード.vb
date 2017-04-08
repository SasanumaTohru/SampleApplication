Namespace BusinessObject.商品
    Public Class 分類コード

        Private m_値 As Integer

        Public Sub New(値 As Integer)
            分類コードが存在する(値)
            m_値 = 値
        End Sub

        Private Sub 分類コードが存在する(値 As Integer)
            Using MyDB As New SampleAppDBEntities
                Dim ヒットリスト = From レコード In MyDB.M_商品分類 Where レコード.コード = 値

                If ヒットリスト.Count <> 1 Then
                    Throw New Exception("指定された商品分類コードは存在しません。")
                End If
            End Using
        End Sub

        Public Sub New(分類 As M_商品分類)
            m_値 = 分類.コード
        End Sub

        Public ReadOnly Property 値 As Integer
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace
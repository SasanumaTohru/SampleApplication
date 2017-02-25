Namespace BusinessObject.商品
    Public Class 分類コード

        Private m_値 As Integer = 0

        ''' <summary>
        ''' 参照用コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As Integer)
            Using MyDB As New SampleAppDBEntities
                Dim rs = From o In MyDB.M_商品分類 Where o.コード = 値

                If rs.Count <> 1 Then
                    Throw New Exception("指定された商品分類コードは存在しません。")
                End If

                m_値 = 値

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
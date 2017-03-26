Namespace BusinessObject.商品
    Public Class メーカーID

        Private m_値 As Integer

        Public Sub New(値 As Integer)
            IDが存在する(値)
            m_値 = 値
        End Sub

        Private Sub IDが存在する(ID As Integer)
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim ヒットリスト = From レコード In MyDB.M_メーカー Where レコード.ID = ID

                    If ヒットリスト.Count <> 1 Then
                        Throw New Exception("指定されたメーカーは存在しません。")
                    End If
                End Using
            Catch ex As Exception
                Throw New Exception("データベースを参照できませんでした。")
            End Try
        End Sub

        Public ReadOnly Property 値 As Integer
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace
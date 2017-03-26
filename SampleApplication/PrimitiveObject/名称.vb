Namespace PrimitiveObject
    Public Class 名称

        Private m_値 As String

        Public Sub New(値 As String)
            Dim 検証文字列 As String = 先頭末尾のスペースを除去する(値)
            名称となり得る文字が含まれている(検証文字列)
            m_値 = 検証文字列
        End Sub

        Private Sub 名称となり得る文字が含まれている(値 As String)
            If 値 = String.Empty Then
                Throw New Exception("入力された文字が不正です。")
            End If
        End Sub

        Private Function 先頭末尾のスペースを除去する(値 As String) As String
            Return Trim(値)
        End Function

        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

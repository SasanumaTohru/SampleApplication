Namespace PrimitiveObject
    Public Class 名称

        Private m_値 As String

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値">名称となる文字列を設定します。</param>
        Public Sub New(値 As String)
            Dim _値 As String = 先頭末尾のスペースを除去する(値)
            スペース以外の文字が含まれている(_値)
            m_値 = _値
        End Sub

        Private Sub スペース以外の文字が含まれている(値 As String)
            If 値 = String.Empty Then
                Throw New Exception("入力された文字が不正です。")
            End If
        End Sub

        Private Function 先頭末尾のスペースを除去する(値 As String) As String
            Return Trim(値)
        End Function

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

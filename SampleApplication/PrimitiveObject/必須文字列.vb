Namespace PrimitiveObject
    Public Class 必須文字列

        Private m_値 As String

        Public Sub New(値 As String)
            文字が入力されている(値)
            m_値 = 値
        End Sub

        Private Sub 文字が入力されている(値 As String)
            If 値.Trim() = String.Empty Then
                Throw New Exception("文字が入力されていません。")
            End If
        End Sub

        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

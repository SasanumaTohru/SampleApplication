Namespace PrimitiveObject
    Public Class 必須文字列

        Private m_値 As String

        Public Sub New(値 As String)
            値は正しい(値)
            m_値 = 値
        End Sub

        Private Sub 値は正しい(値 As String)
            If Trim(値) = String.Empty Then
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

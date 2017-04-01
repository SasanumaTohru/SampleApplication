Namespace PrimitiveObject
    Public Class 名称

        Private m_値 As String

        Public Sub New(値 As String)
            Dim 検証文字列 As String = 値.Trim()
            名称になり得る文字が含まれている(検証文字列)
            m_値 = 検証文字列
        End Sub

        Private Sub 名称になり得る文字が含まれている(値 As String)
            If 値 = String.Empty Then
                Throw New Exception("名称になり得る文字列がありません。")
            End If
        End Sub

        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

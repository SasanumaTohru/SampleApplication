Namespace PrimitiveObject
    Public Class 自然数

        Private m_値 As Integer

        Public Sub New(値 As Integer)
            値は0以上である(値)
            m_値 = 値
        End Sub

        Private Shared Sub 値は0以上である(値 As Integer)
            If 値 < 0 Then
                Throw New Exception("負の整数が入力されました。")
            End If
        End Sub

        Public ReadOnly Property 値 As Integer
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace
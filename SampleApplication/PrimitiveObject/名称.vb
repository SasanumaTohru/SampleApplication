Namespace PrimitiveObject
    Public Class 名称

        Private m_値 As String = String.Empty

        Public Sub New(値 As String)
            m_値 = 値
        End Sub

        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

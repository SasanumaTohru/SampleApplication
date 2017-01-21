Namespace PrimitiveObject
    Public Class 金額
        Private m_値 As Decimal = 0

        Public Sub New(値 As Decimal)
            m_値 = 値
        End Sub

        Public ReadOnly Property 値 As Decimal
            Get
                Return m_値
            End Get
        End Property

        Public ReadOnly Property 桁区切値 As String
            Get
                Return m_値.ToString("#,##0")
            End Get
        End Property

    End Class
End Namespace
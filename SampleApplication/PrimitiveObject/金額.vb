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

        Public ReadOnly Property 円マーク付書式 As String
            Get
                Return "\" & m_値.ToString("#,##0")
            End Get
        End Property

        Public Enum 表示単位リスト
            円 = 1
            千円 = 2
            百万 = 3
        End Enum

        Public ReadOnly Property 表示単位指定(表示単位 As 表示単位リスト) As String
            Get
                Dim _値 As String = String.Empty
                Select Case 表示単位
                    Case 表示単位リスト.円
                        _値 = m_値.ToString("#,##0")
                    Case 表示単位リスト.千円
                        _値 = (Math.Round(m_値 / 1000, 0).ToString("#,##0"))
                    Case 表示単位リスト.百万
                        _値 = (Math.Round(m_値 / 1000000, 0).ToString("#,##0"))
                End Select
                Return _値
            End Get
        End Property

    End Class
End Namespace
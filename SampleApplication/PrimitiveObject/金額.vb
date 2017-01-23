Namespace PrimitiveObject
    Public Class 金額

        'フィールド
        Private m_値 As Decimal = 0

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As Decimal)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As Decimal
            Get
                Return m_値
            End Get
        End Property

        ''' <summary>
        ''' 桁区切値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 桁区切値 As String
            Get
                Return m_値.ToString("#,##0")
            End Get
        End Property

        ''' <summary>
        ''' 円マーク付書式プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 円マーク付書式 As String
            Get
                Return "\" & m_値.ToString("#,##0")
            End Get
        End Property

        ''' <summary>
        ''' 表示単位リスト
        ''' </summary>
        Public Enum 表示単位リスト As Integer
            円 = 1
            千円 = 2
            百万 = 3
        End Enum

        ''' <summary>
        ''' 表示単位指定プロパティ
        ''' </summary>
        ''' <param name="表示単位"></param>
        ''' <returns></returns>
        Public ReadOnly Property 表示単位指定(表示単位 As 表示単位リスト) As String
            Get

                Dim _値 As String = String.Empty

                Select Case 表示単位
                    Case 表示単位リスト.円
                        _値 = (桁変更(表示桁.円単位))
                    Case 表示単位リスト.千円
                        _値 = (桁変更(表示桁.千円単位))
                    Case 表示単位リスト.百万
                        _値 = (桁変更(表示桁.百万単位))
                End Select

                Return _値

            End Get
        End Property

        ''' <summary>
        ''' 金額単位の変更用パラメーター
        ''' </summary>
        Private Enum 表示桁 As Integer
            円単位 = 1
            千円単位 = 1000
            百万単位 = 1000000
        End Enum

        ''' <summary>
        ''' 桁変更（内部メソッド）
        ''' </summary>
        ''' <param name="倍率"></param>
        ''' <returns></returns>
        Private Function 桁変更(倍率 As 表示桁) As String
            Return Math.Round(m_値 / 倍率, 0, MidpointRounding.AwayFromZero).ToString("#,##0")
        End Function

    End Class
End Namespace
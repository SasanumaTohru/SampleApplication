Namespace PrimitiveObject
    Public Class 日付

        Private m_値 As Date

        Public Sub New(値 As Date)
            m_値 = 値
        End Sub

        Public ReadOnly Property 値 As Date
            Get
                Return m_値
            End Get
        End Property

        Public Enum 曜日表示 As Integer
            なし = 1
            あり = 2
        End Enum

        Public ReadOnly Property 西暦年月日文字列(Optional 曜日表示 As 曜日表示 = 曜日表示.なし) As String
            Get
                Dim _値 As String
                Select Case 曜日表示
                    Case 曜日表示.なし
                        _値 = m_値.ToString("yyyy年M月d日")
                    Case Else
                        _値 = m_値.ToString("yyyy年M月d日(ddd)")
                End Select
                Return _値
            End Get
        End Property

        Public ReadOnly Property 和暦年月日文字列(Optional 曜日表示 As 曜日表示 = 曜日表示.なし) As String
            Get
                Dim _値 As String
                Dim 文化圏 As New Globalization.CultureInfo("ja-JP", False)
                文化圏.DateTimeFormat.Calendar = New Globalization.JapaneseCalendar()
                Select Case 曜日表示
                    Case 曜日表示.なし
                        _値 = m_値.ToString("gy年M月d日", 文化圏)
                    Case Else
                        _値 = m_値.ToString("gy年M月d日(ddd)", 文化圏)
                End Select
                Return _値
            End Get
        End Property

    End Class
End Namespace

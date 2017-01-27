Namespace PrimitiveObject
    Public Class 日付

    '値フィールド　初期値は「0001/01/01 0:00:00」 ただし、時間はスコープ外
        Private m_値 As Date = Date.MinValue

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As Date)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As Date
            Get
                Return m_値
            End Get
        End Property

        Public Enum 曜日表示 As Integer
            なし = 1
            あり = 2
        End Enum

        ''' <summary>
        ''' 西暦年月日プロパティ
        ''' </summary>
        ''' <param name="曜日表示"></param>
        ''' <returns></returns>
        Public ReadOnly Property 西暦年月日文字列(Optional 曜日表示 As 曜日表示 = 曜日表示.なし) As String
            Get
                Dim _値 As String = String.Empty
                Select Case 曜日表示
                    Case 曜日表示.なし
                        _値 = m_値.ToString("yyyy年M月d日")
                    Case 曜日表示.あり
                        _値 = m_値.ToString("yyyy年M月d日(ddd)")
                End Select
                Return _値
            End Get
        End Property

        ''' <summary>
        ''' DateTime型の値を書式「平成XX年XX月XX日」の文字列で返します。
        ''' </summary>
        ''' <param name="曜日表示">曜日の有無を指定します。曜日の書式は「(X)」です。</param>
        ''' <returns></returns>
        Public ReadOnly Property 和暦年月日文字列(Optional 曜日表示 As 曜日表示 = 曜日表示.なし) As String
            Get
                Dim _値 As String = String.Empty
                Dim 文化圏 As New Globalization.CultureInfo("ja-JP", False)
                文化圏.DateTimeFormat.Calendar = New Globalization.JapaneseCalendar()
                Select Case 曜日表示
                    Case 曜日表示.なし
                        _値 = m_値.ToString("gy年M月d日", 文化圏)
                    Case 曜日表示.あり
                        _値 = m_値.ToString("gy年M月d日(ddd)", 文化圏)
                End Select
                Return _値
            End Get
        End Property

    End Class
End Namespace

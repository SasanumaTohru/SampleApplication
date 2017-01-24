Namespace PrimitiveObject
    Public Class 日時

        '値フィールド　初期値は「0001/01/01 0:00:00」
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

        Public ReadOnly Property 和暦日付文字列 As String
            Get
                Dim 文化圏 As New System.Globalization.CultureInfo("ja-JP", False)
                文化圏.DateTimeFormat.Calendar = New System.Globalization.JapaneseCalendar()
                Return m_値.ToString("gy年M月d日", 文化圏)
            End Get
        End Property

    End Class
End Namespace

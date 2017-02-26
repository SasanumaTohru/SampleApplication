Namespace PrimitiveObject
    Public Class 名称

        Private m_値 As String

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値">名称となる文字列を設定します。</param>
        Public Sub New(値 As String)
            'スペースの除去
            Dim _値 As String = Trim(値)
            'バリデーション
            If _値 = String.Empty Then
                Throw New Exception("入力された文字が不正です。")
            End If
            '本処理
            m_値 = _値
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

Namespace PrimitiveObject
    Public Class 必須文字列

        'Private変数
        Private m_値 As String = String.Empty

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値">文字列を設定します。</param>
        Public Sub New(値 As String)
            'バリデーション
            If 値 = String.Empty Then
                Throw New Exception("文字が入力されていません。")
            End If
            '本処理
            m_値 = 値
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

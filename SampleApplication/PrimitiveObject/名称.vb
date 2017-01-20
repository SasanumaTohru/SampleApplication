Namespace PrimitiveObject
    Public Class 名称

        Private m_値 As String = String.Empty

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値">名称となる文字列を設定します。</param>
        Public Sub New(値 As String)
            m_値 = Trim(値)
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns>名称を返します。</returns>
        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

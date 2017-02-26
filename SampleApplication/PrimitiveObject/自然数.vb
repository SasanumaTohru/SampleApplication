Namespace PrimitiveObject
    Public Class 自然数

        Private m_値 As UInteger

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As UInteger)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As UInteger
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace
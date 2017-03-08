Namespace FoundationObject
    Public Class 単位

        Public Enum 単位リスト As Integer
            個 = 1
            枚 = 2
            本 = 3
            台 = 4
            式 = 5
        End Enum

        Private m_値 As 単位リスト

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As 単位リスト)
            単位の設定は正しい(値)
            m_値 = 値
        End Sub

        Private Sub 単位の設定は正しい(値 As 単位リスト)
            If 単位リスト.個 > 値 Or 値 > 単位リスト.式 Then
                Throw New Exception("単位の設定が正しくありません。")
            End If
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As 単位リスト
            Get
                Return m_値
            End Get
        End Property

        ''' <summary>
        ''' 名称プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return New PrimitiveObject.名称(m_値.ToString)
            End Get
        End Property

    End Class
End Namespace

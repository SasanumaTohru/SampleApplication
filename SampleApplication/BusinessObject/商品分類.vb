Namespace BusinessObject
    Public Class 商品分類

        ''' <summary>
        ''' フィールド
        ''' </summary>
        Private m_分類 As 分類リスト

        ''' <summary>
        ''' 商品の分類リスト
        ''' </summary>
        Public Enum 分類リスト As Integer
            家電 = 1
            パソコン = 2
            AV機器 = 3
            カメラ = 4
            時計 = 5
        End Enum

        ''' <summary>
        ''' コンストラクタ。分類リストから値を選択します。
        ''' </summary>
        ''' <param name="分類"></param>
        Public Sub New(分類 As 分類リスト)
            m_分類 = 分類
        End Sub

        ''' <summary>
        ''' 分類の名称を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return New PrimitiveObject.名称(m_分類.ToString)
            End Get
        End Property

    End Class
End Namespace

Namespace BusinessObject.商品
    Public Class 価格変更項目

        Private m_商品ID As 商品ID
        Private m_価格区分 As 価格区分リスト
        Private m_現行価格 As PrimitiveObject.金額
        Private m_変更後価格 As PrimitiveObject.金額
        Private m_適用開始日 As PrimitiveObject.日付

        Public Enum 価格区分リスト As Integer
            仕入 = 1
            販売 = 2
        End Enum

        Public Sub New(商品ID As 商品ID,
                       価格区分 As 価格区分リスト,
                       現行価格 As PrimitiveObject.金額,
                       変更後価格 As PrimitiveObject.金額,
                       適用開始日 As PrimitiveObject.日付)
            'バリデーション
            If 価格区分 < 価格区分リスト.仕入 Or 価格区分 > 価格区分リスト.販売 Then
                Throw New Exception("価格区分が正しくありません。")
            End If
            '本処理
            m_商品ID = 商品ID
            m_価格区分 = 価格区分
            m_現行価格 = 現行価格
            m_変更後価格 = 変更後価格
            m_適用開始日 = 適用開始日

        End Sub

        Public ReadOnly Property 商品ID As 商品ID
            Get
                Return m_商品ID
            End Get
        End Property

        Public ReadOnly Property 価格区分 As 価格区分リスト
            Get
                Return m_価格区分
            End Get
        End Property

        Public ReadOnly Property 現行価格 As PrimitiveObject.金額
            Get
                Return m_現行価格
            End Get
        End Property

        Public ReadOnly Property 変更後価格 As PrimitiveObject.金額
            Get
                Return m_変更後価格
            End Get
        End Property

        Public ReadOnly Property 適用開始日 As PrimitiveObject.日付
            Get
                Return m_適用開始日
            End Get
        End Property

    End Class
End Namespace

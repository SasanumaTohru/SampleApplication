Namespace BusinessObject.商品
    Public Class 適用価格

        Private m_商品ID As 商品ID
        Private m_区分 As 区分リスト
        Private m_価格 As PrimitiveObject.金額
        Private m_適用開始日 As PrimitiveObject.日付

        Public Enum 区分リスト As Integer
            仕入 = 1
            販売 = 2
        End Enum

        Public Sub New(商品ID As 商品ID, 区分 As 区分リスト, 価格 As PrimitiveObject.金額, 適用開始日 As PrimitiveObject.日付)
            区分は正しい(区分)
            価格は1円以上である(価格)
            適用開始日が明日以降である(適用開始日)

            m_商品ID = 商品ID
            m_区分 = 区分
            m_価格 = 価格
            m_適用開始日 = 適用開始日
        End Sub

        Private Sub 区分は正しい(区分 As 区分リスト)
            If 区分 < 区分リスト.仕入 Or 区分 > 区分リスト.販売 Then
                Throw New Exception("価格区分の設定が正しくありません。")
            End If
        End Sub

        Private Sub 価格は1円以上である(価格 As PrimitiveObject.金額)
            If 価格.値 < 1D Then
                Throw New Exception("価格は1円以上の金額で設定します。")
            End If
        End Sub

        Private Sub 適用開始日が明日以降である(適用開始日 As PrimitiveObject.日付)
            Dim 設定できる日付 As New PrimitiveObject.日付(Date.Today.AddDays(1))
            If 適用開始日.値 < 設定できる日付.値 Then
                Throw New Exception("適用開始日には明日以降の日付が必要です。")
            End If
        End Sub

        Public ReadOnly Property 商品ID As 商品ID
            Get
                Return m_商品ID
            End Get
        End Property

        Public ReadOnly Property 価格 As PrimitiveObject.金額
            Get
                Return m_価格
            End Get
        End Property

        Public ReadOnly Property 区分 As 区分リスト
            Get
                Return m_区分
            End Get
        End Property

        Public ReadOnly Property 適用開始日 As PrimitiveObject.日付
            Get
                Return m_適用開始日
            End Get
        End Property

    End Class
End Namespace
Namespace BusinessObject.商品.適用価格

    ''' <summary>
    ''' 商品ID、価格区分、適用開始日で一意となる。
    ''' </summary>
    Public Class 価格

        Private m_商品ID As 商品ID
        Private m_価格区分 As 区分リスト
        Private m_適用開始日 As PrimitiveObject.日付
        Private m_値 As PrimitiveObject.金額

        Public Enum 区分リスト As Integer
            仕入 = 1
            販売 = 2
        End Enum

        Public Sub New(商品ID As 商品ID,
                       価格区分 As 区分リスト, 変更後価格 As PrimitiveObject.金額,
                       適用開始日 As PrimitiveObject.日付)
            価格区分が正しい(価格区分)
            適用開始日が明日以降である(適用開始日)
            m_商品ID = 商品ID
            m_価格区分 = 価格区分
            m_値 = 変更後価格
            m_適用開始日 = 適用開始日
        End Sub

        Private Sub 価格区分が正しい(価格区分 As 区分リスト)
            If 価格区分 < 価格区分リストの最小値 Or 価格区分 > 価格区分リストの最大値 Then
                Throw New Exception("価格区分が正しくありません。")
            End If
        End Sub

        Private Shared Function 価格区分リストの数列を取得する() As Integer()
            Dim 配列 As Array = [Enum].GetValues(GetType(区分リスト))
            Dim 数列 As Integer() = CType(配列, Integer())
            Return 数列
        End Function

        Private Shared ReadOnly Property 価格区分リストの最小値 As Integer
            Get
                Return 価格区分リストの数列を取得する.Min
            End Get
        End Property

        Private Shared ReadOnly Property 価格区分リストの最大値 As Integer
            Get
                Return 価格区分リストの数列を取得する.Max
            End Get
        End Property

        Private Sub 適用開始日が明日以降である(摘要開始日 As PrimitiveObject.日付)
            Dim 設定できる日付 As New PrimitiveObject.日付(Date.Today.AddDays(1))
            If 摘要開始日.値 < 設定できる日付.値 Then
                Throw New Exception("摘要開始日には明日以降の日付が必要です。")
            End If
        End Sub

        Public ReadOnly Property 商品ID As 商品ID
            Get
                Return m_商品ID
            End Get
        End Property

        Public ReadOnly Property 価格区分 As 区分リスト
            Get
                Return m_価格区分
            End Get
        End Property

        Public ReadOnly Property 値 As PrimitiveObject.金額
            Get
                Return m_値
            End Get
        End Property

        Public ReadOnly Property 適用開始日 As PrimitiveObject.日付
            Get
                Return m_適用開始日
            End Get
        End Property

    End Class
End Namespace
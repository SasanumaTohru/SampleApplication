Namespace BusinessObject.商品.価格変更

    Public Class スケジュール

        Inherits CollectionBase
        Private m_リスト As New List(Of 予定)

        Public Sub 追加する(項目 As 予定)
            予定は一意である(項目)
            m_リスト.Add(項目)
        End Sub

        Private Sub 予定は一意である(予定 As 予定)
            If 予定を検索する(予定.商品ID, 予定.価格区分, 予定.適用開始日).Count = 1 Then
                Throw New Exception($"商品ID、価格区分、適用開始日が重複するため登録できません。{{{予定.商品ID.値} , {予定.価格区分.ToString} , {予定.適用開始日.西暦年月日文字列}}}")
            End If
        End Sub

        Public ReadOnly Property 予定数 As Integer
            Get
                Return m_リスト.Count
            End Get
        End Property

        Public ReadOnly Property 予定リスト As List(Of 予定)
            Get
                Return m_リスト
            End Get
        End Property

        Public ReadOnly Property 予定(商品ID As 商品ID, 価格区分 As 予定.価格区分リスト, 適用開始日 As PrimitiveObject.日付) As 予定
            Get
                Return 予定を検索する(商品ID, 価格区分, 適用開始日).First
            End Get
        End Property

        Private Function 予定を検索する(商品ID As 商品ID, 価格区分 As 予定.価格区分リスト, 適用開始日 As PrimitiveObject.日付) As IEnumerable(Of 予定)
            Dim ヒットリスト = From レコード In m_リスト
                         Where レコード.商品ID.値 = 商品ID.値 And レコード.価格区分 = 価格区分 And レコード.適用開始日.値 = 適用開始日.値

            Return ヒットリスト
        End Function

    End Class
End Namespace

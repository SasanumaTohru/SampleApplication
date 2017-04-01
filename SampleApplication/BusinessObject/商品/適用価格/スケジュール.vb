Namespace BusinessObject.商品.適用価格

    Public Class スケジュール

        Inherits CollectionBase
        Private m_リスト As New List(Of 価格)

        Public Sub New()
            データベースから適用価格を読み込む()
        End Sub

        Private Sub データベースから適用価格を読み込む()
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim 保存済みリスト = From 適用価格 In MyDB.T_適用価格

                    For Each 価格 In 保存済みリスト
                        Dim 登録済み適用価格 As New 価格(New 商品ID(価格.商品ID), CType(価格.区分, 価格.区分リスト),
                                             New PrimitiveObject.金額(価格.価格), New PrimitiveObject.日付(価格.適用開始日))
                        m_リスト.Add(登録済み適用価格)
                    Next
                End Using
            Catch ex As Exception
                Throw New Exception("適用価格の読込に失敗しました。")
            End Try
        End Sub

        Public Sub 追加する(適用価格 As 価格)
            予定は一意である(適用価格)
            データベースに保存する(適用価格)
            m_リスト.Add(適用価格)
        End Sub

        Private Sub データベースに保存する(適用価格 As 価格)
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim 新規適用価格 As New T_適用価格 With {.商品ID = 適用価格.商品ID.値, .区分 = 適用価格.価格区分, .価格 = 適用価格.値.値, .適用開始日 = 適用価格.適用開始日.値}
                    With MyDB
                        .T_適用価格.Add(新規適用価格)
                        .SaveChanges()
                    End With
                End Using
            Catch ex As Exception
                Throw New Exception("データベースへの保存に失敗しました。")
            End Try
        End Sub

        Private Sub 予定は一意である(予定 As 価格)
            If 適用価格を検索する(予定.商品ID, 予定.価格区分, 予定.適用開始日).Count = 1 Then
                Throw New Exception($"商品ID、価格区分、適用開始日が重複するため登録できません。{{{予定.商品ID.値} , {予定.価格区分.ToString} , {予定.適用開始日.西暦年月日文字列}}}")
            End If
        End Sub

        Public ReadOnly Property 適用価格数 As Integer
            Get
                Return m_リスト.Count
            End Get
        End Property

        Public ReadOnly Property リスト As List(Of 価格)
            Get
                Return m_リスト
            End Get
        End Property

        Public ReadOnly Property 項目(商品ID As 商品ID, 価格区分 As 価格.区分リスト, 適用開始日 As PrimitiveObject.日付) As 価格
            Get
                Return 適用価格を検索する(商品ID, 価格区分, 適用開始日).First
            End Get
        End Property

        Private Function 適用価格を検索する(商品ID As 商品ID, 価格区分 As 価格.区分リスト, 適用開始日 As PrimitiveObject.日付) As IEnumerable(Of 価格)
            Dim ヒットリスト = From レコード In m_リスト
                         Where レコード.商品ID.値 = 商品ID.値 And レコード.価格区分 = 価格区分 And レコード.適用開始日.値 = 適用開始日.値

            Return ヒットリスト
        End Function

    End Class
End Namespace

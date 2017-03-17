Namespace BusinessObject.商品
    Public Class 価格変更計画

        Inherits CollectionBase

        Private m_リスト As New List(Of 価格変更項目)

        ''' <summary>
        ''' 項目を追加するメソッド
        ''' </summary>
        ''' <param name="項目"></param>
        Public Sub 項目を追加する(項目 As 価格変更項目)
            項目は一意である(項目)
            m_リスト.Add(項目)
        End Sub

        ''' <summary>
        ''' 追加する項目が一意であることをチェックします。
        ''' </summary>
        ''' <param name="項目"></param>
        Private Sub 項目は一意である(項目 As 価格変更項目)
            Dim ヒットリスト = From レコード In m_リスト
                         Where レコード.商品ID.値 = 項目.商品ID.値 And レコード.価格区分 = 項目.価格区分 And レコード.適用開始日.値 = 項目.適用開始日.値

            If ヒットリスト.Count = 1 Then
                Throw New Exception($"商品ID、価格区分、適用開始日が重複するため登録できません。{{{項目.商品ID.値} , {項目.価格区分.ToString} , {項目.適用開始日.西暦年月日文字列}}}")
            End If
        End Sub

        ''' <summary>
        ''' 項目数プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 項目数 As Integer
            Get
                Return m_リスト.Count
            End Get
        End Property

        ''' <summary>
        ''' 項目リストプロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 項目リスト As List(Of 価格変更項目)
            Get
                Return m_リスト
            End Get
        End Property

        ''' <summary>
        ''' 項目プロパティ
        ''' </summary>
        ''' <param name="商品ID"></param>
        ''' <returns></returns>
        Public ReadOnly Property 項目(商品ID As 商品ID, 価格区分 As 価格変更項目.価格区分リスト) As 価格変更項目
            Get
                Dim ヒットリスト = From レコード In m_リスト
                             Where レコード.商品ID.値 = 商品ID.値 And レコード.価格区分 = 価格区分

                Return ヒットリスト.First
            End Get
        End Property

    End Class
End Namespace

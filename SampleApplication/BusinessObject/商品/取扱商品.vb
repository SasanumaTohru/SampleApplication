Namespace BusinessObject.商品
    Public Class 取扱商品

        Inherits CollectionBase

        Private m_分類コード As 分類コード
        Private m_ページ情報 As FoundationObject.ページ
        Private m_指定した分類の商品数 As PrimitiveObject.自然数
        Private m_リスト As New List(Of 商品)

        Public Sub New()

        End Sub

        Public Sub New(分類 As 分類コード)
            m_分類コード = 分類
            Using MyDB As New SampleAppDBEntities
                Dim rs = From 商品 In MyDB.M_商品 Where 商品.分類 = m_分類コード.値 Select 商品.商品ID

                m_指定した分類の商品数 = New PrimitiveObject.自然数(rs.Count)
                Dim ページごとの項目数 As New PrimitiveObject.自然数(24)
                m_ページ情報 = New FoundationObject.ページ(m_指定した分類の商品数, ページごとの項目数)
            End Using
        End Sub

        Private Sub DBからページごとの商品を読み込む()
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim ページごとの商品リスト = From 商品 In MyDB.M_商品
                                      Where 商品.分類 = m_分類コード.値
                                      Order By 商品.商品ID Descending
                                      Skip (m_ページ情報.ページごとの項目スキップ数.値)
                                      Take (m_ページ情報.ページの項目数.値)

                    For Each 商品データ In ページごとの商品リスト
                        Dim 商品 As New 商品(商品データ)
                        リストに追加する(商品)
                    Next
                End Using
            Catch ex As Exception
                Throw New Exception("データベースを参照できませんでした。")
            End Try
        End Sub

        Public Sub 追加する(商品 As 商品)
            データベースに保存する(商品)
            リストに追加する(商品)
        End Sub

        Private Sub リストに追加する(商品 As 商品)
            m_リスト.Add(商品)
        End Sub

        Private Sub データベースに保存する(商品 As 商品)
            Try
                Using MyDB As New SampleAppDBEntities
                    Dim 追加する商品 As New M_商品 With {
                    .商品ID = 商品.商品ID.値,
                    .メーカー = 商品.メーカー.ID.値,
                    .商品名 = 商品.名称.値,
                    .分類 = 商品.分類.ID.値,
                    .単位 = CType(商品.単位.ID.値, Integer)
                }
                    With MyDB
                        .M_商品.Add(追加する商品)
                        .SaveChanges()
                    End With
                End Using
            Catch ex As Exception
                Throw New Exception("データベースへの保存に失敗しました。")
            End Try
        End Sub

        Public ReadOnly Property リスト(ページ操作 As FoundationObject.ページ.ページ操作リスト) As List(Of 商品)
            Get
                Select Case ページ操作
                    Case FoundationObject.ページ.ページ操作リスト.最初のページ
                        m_ページ情報.最初のページに移動する()
                    Case FoundationObject.ページ.ページ操作リスト.次のページ
                        m_ページ情報.次のページに移動する()
                    Case FoundationObject.ページ.ページ操作リスト.前のページ
                        m_ページ情報.前のページに移動する()
                    Case FoundationObject.ページ.ページ操作リスト.最後のページ
                        m_ページ情報.最後のページに移動する()
                End Select
                m_リスト.Clear()
                DBからページごとの商品を読み込む()
                Return m_リスト
            End Get
        End Property

        Public ReadOnly Property リストのページ As FoundationObject.ページ
            Get
                Return m_ページ情報
            End Get
        End Property

        Public ReadOnly Property 現在のページの商品数() As PrimitiveObject.自然数
            Get
                Return New PrimitiveObject.自然数(m_リスト.Count)
            End Get
        End Property

        Public ReadOnly Property 指定した分類の商品数 As PrimitiveObject.自然数
            Get
                Return m_指定した分類の商品数
            End Get
        End Property

        Public ReadOnly Property 商品(ID As 商品ID) As 商品
            Get
                Using MyDB As New SampleAppDBEntities
                    Dim ヒットリスト = From レコード In MyDB.M_商品 Where レコード.商品ID = ID.値

                    Dim 参照する商品 As New 商品(ヒットリスト.First)
                    Return 参照する商品
                End Using
            End Get
        End Property

    End Class
End Namespace
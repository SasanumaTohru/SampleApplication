Namespace BusinessObject.商品
    Public Class 商品

        Private m_商品ID As 商品ID
        Private m_メーカー As メーカー
        Private m_名称 As PrimitiveObject.名称
        Private m_分類 As 分類
        Private m_単位 As FoundationObject.単位

        Public Sub New(商品ID As 商品ID, メーカー As メーカー, 名称 As PrimitiveObject.名称, 分類 As 分類, 単位 As FoundationObject.単位)
            m_商品ID = 商品ID
            m_メーカー = メーカー
            m_名称 = 名称
            m_分類 = 分類
            m_単位 = 単位
        End Sub

        Public Sub New(商品 As M_商品)
            m_商品ID = New 商品ID(商品)
            m_メーカー = New メーカー(New メーカーID(商品.メーカー))
            m_名称 = New PrimitiveObject.名称(商品.商品名)
            m_分類 = New 分類(New 分類コード(商品.分類))
            m_単位 = New FoundationObject.単位(CType(商品.単位, FoundationObject.単位.単位リスト))
        End Sub

        Public ReadOnly Property 商品ID As 商品ID
            Get
                Return m_商品ID
            End Get
        End Property

        Public ReadOnly Property メーカー As メーカー
            Get
                Return m_メーカー
            End Get
        End Property

        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return m_名称
            End Get
        End Property

        Public ReadOnly Property 分類 As 分類
            Get
                Return m_分類
            End Get
        End Property

        Public ReadOnly Property 単位 As FoundationObject.単位
            Get
                Return m_単位
            End Get
        End Property

        Public ReadOnly Property 価格(価格区分 As 適用価格.価格.区分リスト, 照会日 As PrimitiveObject.日付) As PrimitiveObject.金額
            Get
                Dim 適用価格スケジュール As New 適用価格.スケジュール
                Return 適用価格スケジュール.適用価格を照会する(m_商品ID, 価格区分, 照会日)
            End Get
        End Property

        Public ReadOnly Property 個別売上利益(照会日 As PrimitiveObject.日付) As PrimitiveObject.金額
            Get
                Try
                    Dim 適用価格スケジュール As New BusinessObject.商品.適用価格.スケジュール
                    Dim 販売価格 As Decimal = 適用価格スケジュール.適用価格を照会する(m_商品ID, 適用価格.価格.区分リスト.販売, 照会日).値
                    Dim 仕入価格 As Decimal = 適用価格スケジュール.適用価格を照会する(m_商品ID, 適用価格.価格.区分リスト.仕入, 照会日).値
                    Return New PrimitiveObject.金額(販売価格 - 仕入価格)
                Catch ex As Exception
                    Throw New Exception("照会日に適用される仕入価格または販売価格が存在しないため、個別売上利益を参照できません。")
                End Try
            End Get
        End Property

    End Class
End Namespace
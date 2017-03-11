Namespace BusinessObject.商品
    Public Class 商品

        ''' <summary>
        ''' フィールド
        ''' </summary>
        Private m_商品ID As 商品ID
        Private m_メーカー As メーカー
        Private m_名称 As PrimitiveObject.名称
        Private m_分類 As 分類
        Private m_単位 As FoundationObject.単位
        Private m_仕入価格 As PrimitiveObject.金額
        Private m_販売価格 As PrimitiveObject.金額

        ''' <summary>
        ''' 生成用コンストラクタ
        ''' </summary>
        ''' <param name="商品ID"></param>
        ''' <param name="メーカー"></param>
        ''' <param name="名称"></param>
        ''' <param name="分類"></param>
        ''' <param name="仕入価格"></param>
        ''' <param name="販売価格"></param>
        Public Sub New(商品ID As 商品ID,
                       メーカー As メーカー,
                       名称 As PrimitiveObject.名称,
                       分類 As 分類,
                       単位 As FoundationObject.単位,
                       仕入価格 As PrimitiveObject.金額,
                       販売価格 As PrimitiveObject.金額)

            m_商品ID = 商品ID
            m_メーカー = メーカー
            m_名称 = 名称
            m_分類 = 分類
            m_単位 = 単位
            m_仕入価格 = 仕入価格
            m_販売価格 = 販売価格

        End Sub

        ''' <summary>
        ''' 参照用コンストラクタ
        ''' </summary>
        ''' <param name="商品"></param>
        Public Sub New(商品 As M_商品)
            m_商品ID = New 商品ID(商品.商品ID)
            m_メーカー = New メーカー(New メーカーID(商品.メーカー))
            m_名称 = New PrimitiveObject.名称(商品.商品名)
            m_分類 = New 分類(New 分類コード(商品.分類))
            m_単位 = New FoundationObject.単位(CType(商品.単位, FoundationObject.単位.単位リスト))
            m_仕入価格 = New PrimitiveObject.金額(商品.仕入価格)
            m_販売価格 = New PrimitiveObject.金額(商品.販売価格)
        End Sub

        ''' <summary>
        ''' 商品IDプロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 商品ID As 商品ID
            Get
                Return m_商品ID
            End Get
        End Property

        ''' <summary>
        ''' メーカープロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property メーカー As メーカー
            Get
                Return m_メーカー
            End Get
        End Property

        ''' <summary>
        ''' 商品名プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return m_名称
            End Get
        End Property

        ''' <summary>
        ''' 商品分類プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 分類 As 分類
            Get
                Return m_分類
            End Get
        End Property

        ''' <summary>
        ''' 単位プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 単位 As FoundationObject.単位
            Get
                Return m_単位
            End Get
        End Property

        ''' <summary>
        ''' 仕入価格プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 仕入価格 As PrimitiveObject.金額
            Get
                Return m_仕入価格
            End Get
        End Property

        ''' <summary>
        ''' 販売価格プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 販売価格 As PrimitiveObject.金額
            Get
                Return m_販売価格
            End Get
        End Property

        ''' <summary>
        ''' 売上利益プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 売上利益 As PrimitiveObject.金額
            Get
                Return New PrimitiveObject.金額(m_販売価格.値 - m_仕入価格.値)
            End Get
        End Property

    End Class
End Namespace

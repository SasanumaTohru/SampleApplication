Namespace FoundationObject

    Public Class ページ

        Private m_現在のページ番号 As New PrimitiveObject.自然数(1)
        Private m_最後のページ番号 As PrimitiveObject.自然数
        Private m_ページごとの項目数 As PrimitiveObject.自然数

        Public Enum ページ操作リスト
            最初のページ = 1
            次のページ = 2
            前のページ = 3
            最後のページ = 4
        End Enum

        Public Sub New(項目数 As PrimitiveObject.自然数, ページごとの項目数 As PrimitiveObject.自然数)
            m_最後のページ番号 = New PrimitiveObject.自然数(CType(Math.Ceiling(項目数.値 / ページごとの項目数.値), Integer))
            m_ページごとの項目数 = ページごとの項目数
        End Sub

        Public ReadOnly Property 現在のページ番号 As PrimitiveObject.自然数
            Get
                Return m_現在のページ番号
            End Get
        End Property

        Public ReadOnly Property 最後のページ番号 As PrimitiveObject.自然数
            Get
                Return m_最後のページ番号
            End Get
        End Property

        Friend Sub 最初のページに移動する()
            m_現在のページ番号 = New PrimitiveObject.自然数(1)
        End Sub

        Friend Sub 次のページに移動する()
            If m_現在のページ番号.値 = m_最後のページ番号.値 Then
                Throw New Exception("最後のページです。")
            End If
            m_現在のページ番号.値に加算する(1)
        End Sub

        Friend Sub 前のページに移動する()
            If m_現在のページ番号.値 = 1 Then
                Throw New Exception("最初のページです。")
            End If
            m_現在のページ番号.値に加算する(-1)
        End Sub

        Friend Sub 最後のページに移動する()
            m_現在のページ番号 = m_最後のページ番号
        End Sub

        Public ReadOnly Property ページの項目数 As PrimitiveObject.自然数
            Get
                Return m_ページごとの項目数
            End Get
        End Property

        Public ReadOnly Property ページごとの項目スキップ数 As PrimitiveObject.自然数
            Get
                Return New PrimitiveObject.自然数(m_ページごとの項目数.値 * (m_現在のページ番号.値 - 1))
            End Get
        End Property

    End Class
End Namespace

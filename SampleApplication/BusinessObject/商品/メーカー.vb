Namespace BusinessObject.商品
    Public Class メーカー

        ''' <summary>
        ''' フィールド
        ''' </summary>
        Private m_メーカー As メーカーリスト

        ''' <summary>
        ''' メーカーリスト
        ''' </summary>
        Public Enum メーカーリスト As Integer
            ソニー = 1
            パナソニック = 2
            キヤノン = 3
            カシオ = 4
            ニコン = 5
            富士通 = 6
            日立 = 7
            ASUS = 8
            セイコー = 9
            NEC = 10
        End Enum

        ''' <summary>
        ''' コンストラクタ。メーカーリストから値を選択します。
        ''' </summary>
        ''' <param name="メーカー"></param>
        Public Sub New（メーカー As メーカーリスト)
            'バリデーション
            If メーカーリスト.ソニー > メーカー Or メーカー > メーカーリスト.NEC Then
                Throw New Exception("指定されたメーカーは存在しません。")
            End If
            '本処理
            m_メーカー = メーカー
        End Sub

        ''' <summary>
        ''' 名称プロパティ。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return New PrimitiveObject.名称(m_メーカー.ToString)
            End Get
        End Property

    End Class
End Namespace

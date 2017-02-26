Namespace BusinessObject.商品
    Public Class 商品ID

        Private m_値 As String

        ''' <summary>
        ''' 生成用コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As String)
            'バリデーション
            '商品IDは6桁の半角数字で表現される。
            '商品IDすべての桁は、0から9の数字で満たされる。
            If Text.RegularExpressions.Regex.IsMatch(値, "^[0-9]{6}$") = False Then
                Throw New Exception("商品IDに6桁の数字以外は使用できません。")
            End If

            Using MyDB As New SampleApplication.SampleAppDBEntities
                Dim レコードセット = From レコード In MyDB.M_商品 Where レコード.商品ID = 値

                If レコードセット.Count <> 0 Then
                    Throw New Exception("この商品IDは既に使用されています。")
                End If
            End Using
            '本処理
            m_値 = 値

        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

Namespace BusinessObject
    Public Class 商品ID

        Private m_値 As String = String.Empty

        Public Sub New(値 As String)
            'バリデーション
            '商品IDは6桁の半角数字で表現される。
            '商品IDすべての桁は、0から9の数字で満たされる。
            If Text.RegularExpressions.Regex.IsMatch(値, "^[0-9]{6}$") = False Then
                Throw New Exception("商品IDに6桁の数字以外は使用できません。")
            End If
            '本処理
            m_値 = 値
        End Sub

        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

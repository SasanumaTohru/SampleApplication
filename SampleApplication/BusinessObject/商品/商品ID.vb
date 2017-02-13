Namespace BusinessObject.商品
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
            Using db As New SampleAppDBEntities

                Dim rs = From o In db.M_商品 Where o.商品ID = 値

                If rs.Count <> 0 Then
                    Throw New Exception("この商品IDは既に使用されています。")
                End If

            End Using

            m_値 = 値

        End Sub

        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

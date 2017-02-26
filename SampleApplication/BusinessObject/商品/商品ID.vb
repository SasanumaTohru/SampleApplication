Namespace BusinessObject.商品
    Public Class 商品ID

        Private m_値 As String

        ''' <summary>
        ''' 生成用コンストラクタ
        ''' </summary>
        ''' <param name="値">商品IDは6桁の半角数字を使用する。</param>
        Public Sub New(値 As String)
            値の表現形式が正しい(値)
            値が使用できる(値)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' 値の表現形式が正しいメソッド
        ''' </summary>
        ''' <param name="値"></param>
        Private Sub 値の表現形式が正しい(値 As String)
            If Text.RegularExpressions.Regex.IsMatch(値, "^[0-9]{6}$") = False Then
                Throw New Exception("商品IDに6桁の数字以外は使用できません。")
            End If
        End Sub

        ''' <summary>
        ''' 値が使用できるメソッド
        ''' </summary>
        ''' <param name="値"></param>
        Private Sub 値が使用できる(値 As String)
            Using MyDB As New SampleApplication.SampleAppDBEntities
                Dim レコードセット = From レコード In MyDB.M_商品 Where レコード.商品ID = 値

                If レコードセット.Count <> 0 Then
                    Throw New Exception("この商品IDは既に使用されています。")
                End If
            End Using
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

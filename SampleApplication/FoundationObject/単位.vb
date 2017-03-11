Namespace FoundationObject
    Public Class 単位

        ''' <summary>
        ''' 単利のリスト
        ''' </summary>
        Public Enum 単位リスト As Integer
            個 = 1
            枚 = 2
            本 = 3
            台 = 4
            式 = 5
        End Enum

        Private m_値 As 単位リスト

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As 単位リスト)
            単位の設定は正しい(値)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' コンストラクタにセットされた値をチェックします。
        ''' </summary>
        ''' <param name="値"></param>
        Private Sub 単位の設定は正しい(値 As 単位リスト)
            Dim 正しい値 As Boolean = (単位リストの最小値 <= 値 And 単位リストの最大値 >= 値)
            If 正しい値 = False Then
                Throw New Exception("単位の設定が正しくありません。")
            End If
        End Sub

        ''' <summary>
        ''' 列挙型を数値配列に変換します。
        ''' </summary>
        ''' <returns></returns>
        Private Shared Function 単位リストの数列を取得する() As Integer()
            Dim 配列 As Array = [Enum].GetValues(GetType(FoundationObject.単位.単位リスト))
            Dim 数列 As Integer() = CType(配列, Integer())
            Return 数列
        End Function

        ''' <summary>
        ''' 単位リストの最小値を返します。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property 単位リストの最小値 As Integer
            Get
                Return 単位リストの数列を取得する.Min
            End Get
        End Property

        ''' <summary>
        ''' 単位リスト最大値を返します。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property 単位リストの最大値 As Integer
            Get
                Return 単位リストの数列を取得する.Max
            End Get
        End Property

        ''' <summary>
        ''' 単位のID（整数型）を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ID As PrimitiveObject.自然数
            Get
                Return New PrimitiveObject.自然数(CType(m_値, UInteger))
            End Get
        End Property

        ''' <summary>
        ''' 単位の名称を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 名称 As PrimitiveObject.名称
            Get
                Return New PrimitiveObject.名称(m_値.ToString)
            End Get
        End Property

    End Class
End Namespace
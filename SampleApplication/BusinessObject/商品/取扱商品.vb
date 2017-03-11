Namespace BusinessObject.商品
    Public Class 取扱商品
        Inherits CollectionBase
        Private m_List As New List(Of 商品)

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        Public Sub New()
            Using MyDB As New SampleAppDBEntities
                Dim レコードセット = From レコード In MyDB.M_商品

                For Each 商品データ In レコードセット
                    Dim 商品 As New 商品(商品データ)
                    m_List.Add(商品)
                Next
            End Using
        End Sub

        ''' <summary>
        ''' 商品を追加します。
        ''' </summary>
        ''' <param name="商品"></param>
        Public Sub 追加する(商品 As 商品)
            m_List.Add(商品)
        End Sub

        ''' <summary>
        ''' 商品の一覧を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 一覧 As List(Of 商品)
            Get
                Return m_List
            End Get
        End Property

        ''' <summary>
        ''' 取扱商品の点数を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 数() As PrimitiveObject.自然数
            Get
                Return New PrimitiveObject.自然数(CType(m_List.Count, UInteger))
            End Get
        End Property

        ''' <summary>
        ''' 指定された商品IDの商品を返します。
        ''' </summary>
        ''' <param name="ID"></param>
        ''' <returns></returns>
        Public ReadOnly Property 商品(ID As 商品ID) As 商品
            Get
                Dim レコードセット = From レコード In m_List Where レコード.商品ID.値 = ID.値

                Return レコードセット.First
            End Get
        End Property

    End Class
End Namespace
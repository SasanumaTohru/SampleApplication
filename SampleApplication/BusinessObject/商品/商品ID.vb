﻿Namespace BusinessObject.商品
    Public Class 商品ID

        Private m_値 As String

        Public Enum コンストラクタオプション As Integer
            参照 = 1
            生成 = 2
        End Enum

        ''' <summary>
        ''' 参照用コンストラクタ
        ''' </summary>
        ''' <param name="値">商品IDは6桁の半角数字を使用する。</param>
        Public Sub New(値 As String, Optional 用途 As コンストラクタオプション = コンストラクタオプション.参照)
            値の表現形式が正しい(値)
            インスタンスの用途に対して商品IDは適切である(値, 用途)
        End Sub

        ''' <summary>
        ''' インスタンスの用途に対して商品IDは適切であるメソッド
        ''' </summary>
        ''' <param name="値"></param>
        ''' <param name="用途"></param>
        Private Sub インスタンスの用途に対して商品IDは適切である(値 As String, 用途 As コンストラクタオプション)
            Select Case 用途
                Case コンストラクタオプション.参照
                    If 商品IDは存在する(値) = False Then
                        Throw New Exception("この商品IDは存在していません。")
                    End If
                Case コンストラクタオプション.生成
                    If 商品IDは存在する(値) Then
                        Throw New Exception("この商品IDは既に使用されています。")
                    End If
            End Select
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

        Private Function 商品IDは存在する(商品ID As String) As Boolean
            Dim レスポンス As Boolean
            Using MyDB As New SampleApplication.SampleAppDBEntities
                Dim 商品IDの集合 = From 集合の要素 In MyDB.M_商品 Where 集合の要素.商品ID = 商品ID

                Select Case 商品IDの集合.Count
                    Case 1
                        レスポンス = True
                    Case Else
                        レスポンス = False
                End Select
            End Using
            Return レスポンス
        End Function

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

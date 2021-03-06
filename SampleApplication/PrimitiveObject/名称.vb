﻿Namespace PrimitiveObject
    Public Class 名称

        'フィールド
        Private m_値 As String

        ''' <summary>
        ''' 文字列の先頭と末尾にスペースがあれば除去し、Emptyには例外を発生させます。
        ''' </summary>
        ''' <param name="値">名称となる文字列を設定します。</param>
        Public Sub New(値 As String)
            Dim 検証文字列 As String = 先頭末尾のスペースを除去する(値)
            名称となり得る文字が含まれている(検証文字列)
            m_値 = 検証文字列
        End Sub

        ''' <summary>
        ''' 名称となり得る文字列の存在を確認します。
        ''' </summary>
        ''' <param name="値"></param>
        Private Sub 名称となり得る文字が含まれている(値 As String)
            If 値 = String.Empty Then
                Throw New Exception("入力された文字が不正です。")
            End If
        End Sub

        ''' <summary>
        ''' 先頭と末尾のスペースを除去します。
        ''' </summary>
        ''' <param name="値"></param>
        ''' <returns></returns>
        Private Function 先頭末尾のスペースを除去する(値 As String) As String
            Return Trim(値)
        End Function

        ''' <summary>
        ''' 名称を返します。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As String
            Get
                Return m_値
            End Get
        End Property

    End Class
End Namespace

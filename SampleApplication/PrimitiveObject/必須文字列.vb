﻿Namespace PrimitiveObject
    Public Class 必須文字列

        Private m_値 As String

        ''' <summary>
        ''' コンストラクタ　スペースのみの文字列と文字列0は許可しません。文字の先頭と末尾のスペースは許可します。
        ''' </summary>
        ''' <param name="値">文字列を設定します。</param>
        Public Sub New(値 As String)
            値は正しい(値)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' コンストラクタのパラメータチェック
        ''' </summary>
        ''' <param name="値"></param>
        Private Sub 値は正しい(値 As String)
            If Trim(値) = String.Empty Then
                Throw New Exception("文字が入力されていません。")
            End If
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

﻿Namespace PrimitiveObject
    Public Class 金額

        Private m_値 As Decimal

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="値"></param>
        Public Sub New(値 As Decimal)
            m_値 = 値
        End Sub

        ''' <summary>
        ''' 値プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 値 As Decimal
            Get
                Return m_値
            End Get
        End Property

        ''' <summary>
        ''' 円マーク付書式プロパティ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property 円マーク付書式 As String
            Get
                Return $"\{m_値.ToString("#,##0")}"
            End Get
        End Property

        ''' <summary>
        ''' 表示単位リスト
        ''' </summary>
        Public Enum 表示単位リスト As Integer
            円 = 1
            千円 = 2
            百万 = 3
        End Enum

        ''' <summary>
        ''' 表示単位指定プロパティ
        ''' </summary>
        ''' <param name="表示単位"></param>
        ''' <returns></returns>
        Public ReadOnly Property 表示単位指定(Optional 表示単位 As 表示単位リスト = 表示単位リスト.円) As String
            Get
                Dim _値 As String = String.Empty

                Select Case 表示単位
                    Case 表示単位リスト.円
                        _値 = (表示桁を変更する(単位.円))
                    Case 表示単位リスト.千円
                        _値 = (表示桁を変更する(単位.千円))
                    Case 表示単位リスト.百万
                        _値 = (表示桁を変更する(単位.百万))
                End Select

                Return _値

            End Get
        End Property

        ''' <summary>
        ''' 金額表示単位のパラメーター
        ''' </summary>
        Private Enum 単位 As Integer
            円 = 1
            千円 = 1000
            百万 = 1000000
        End Enum

        ''' <summary>
        ''' 表示桁を変更する（内部メソッド）
        ''' </summary>
        ''' <param name="単位"></param>
        ''' <returns></returns>
        Private Function 表示桁を変更する(単位 As 単位) As String
            Return Math.Round(m_値 / 単位, 0, MidpointRounding.AwayFromZero).ToString("#,##0")
        End Function

    End Class
End Namespace
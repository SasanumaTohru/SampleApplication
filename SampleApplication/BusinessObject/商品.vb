﻿Namespace BusinessObject
    Public Class 商品

        Private m_メーカー製品コード As PrimitiveObject.必須文字列
        Private m_メーカー As BusinessObject.メーカー
        Private m_商品名 As PrimitiveObject.名称
        Private m_分類 As 商品分類
        Private m_仕入金額 As PrimitiveObject.金額
        Private m_販売価格 As PrimitiveObject.金額

        ''' <summary>
        ''' 新規作成時のコンストラクタ
        ''' </summary>
        ''' <param name="メーカー製品コード"></param>
        ''' <param name="メーカー"></param>
        ''' <param name="商品名"></param>
        ''' <param name="分類"></param>
        ''' <param name="仕入金額"></param>
        ''' <param name="販売価格"></param>
        Public Sub New(メーカー製品コード As PrimitiveObject.必須文字列,
                       メーカー As BusinessObject.メーカー,
                       商品名 As PrimitiveObject.名称,
                       分類 As 商品分類,
                       仕入金額 As PrimitiveObject.金額,
                       販売価格 As PrimitiveObject.金額)

            m_メーカー製品コード = メーカー製品コード
            m_メーカー = メーカー
            m_商品名 = 商品名
            m_分類 = 分類
            m_仕入金額 = 仕入金額
            m_販売価格 = 販売価格

        End Sub

        Public ReadOnly Property メーカー製品コード As PrimitiveObject.必須文字列
            Get
                Return m_メーカー製品コード
            End Get
        End Property

        Public ReadOnly Property メーカー As BusinessObject.メーカー
            Get
                Return m_メーカー
            End Get
        End Property

        Public ReadOnly Property 商品名 As PrimitiveObject.名称
            Get
                Return m_商品名
            End Get
        End Property

        Public ReadOnly Property 分類 As 商品分類
            Get
                Return m_分類
            End Get
        End Property

        Public ReadOnly Property 仕入価格 As PrimitiveObject.金額
            Get
                Return m_仕入金額
            End Get
        End Property

        Public ReadOnly Property 販売価格 As PrimitiveObject.金額
            Get
                Return m_販売価格
            End Get
        End Property

        Public Sub 仕入価格を変更する(変更後の仕入価格 As PrimitiveObject.金額)
            m_仕入金額 = 変更後の仕入価格
        End Sub

        Public Sub 販売価格を変更する(変更後の販売価格 As PrimitiveObject.金額)
            m_販売価格 = 変更後の販売価格
        End Sub

    End Class
End Namespace

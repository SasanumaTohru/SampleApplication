﻿<TestClass()> Public Class TestDataSetup

    Inherits CollectionBase
    Dim m_List As New List(Of String)

    Private Const m_DB接続文字列 As String = "Data Source = DESKTOP-J04U41C\SQLEXPRESS;Initial Catalog = SampleAppDB;Integrated Security = SSPI;"

    <TestMethod> <TestCategory("テストデータ作成")> Sub テスト商品データの作成()
        SQLを実行する("SELECT * FROM M_商品;")
    End Sub

    Public Shared Sub SQLを実行する(SQL文 As String)
        'データベースに接続
        Dim DB接続 As New System.Data.SqlClient.SqlConnection(m_DB接続文字列)
        ' データベース接続を開く
        DB接続.Open()
        ' oSqlConnection から SqlCommand のインスタンスを生成する
        Dim SQLコマンド As SqlClient.SqlCommand = DB接続.CreateCommand()
        ' 実行する SQL コマンドを設定する
        SQLコマンド.CommandText = SQL文
        '終了処理
        SQLコマンド.Dispose()
        DB接続.Dispose()
    End Sub

    ''' <summary>
    ''' テスト用データ商品ID999999の存在を確認し、存在しない場合にはデータを作成します。
    ''' </summary>
    Public Shared Sub テスト用データ商品ID999999の確認()
        '参照をSampleApplicationにすることで名前解決する。
        Using TestDB As New SampleApplication.SampleAppDBEntities

            Const _商品ID As String = "999999"
            Const _メーカー As Integer = 3
            Const _分類 As Integer = 4
            Const _商品 As String = "アナログ一眼レフカメラ"
            Const _単位 As Integer = 4
            Const _仕入価格 As Decimal = 270000D
            Const _販売価格 As Decimal = 300000D

            Dim レコードセット = From レコード In TestDB.M_商品 Where レコード.商品ID = _商品ID

            If レコードセット.Count = 0 Then
                'Create
                Dim 商品 As New SampleApplication.M_商品 With {
                    .商品ID = _商品ID,
                    .メーカー = _メーカー,
                    .分類 = _分類,
                    .商品名 = _商品,
                    .単位 = _単位,
                    .仕入価格 = _仕入価格,
                    .販売価格 = _販売価格
                }
                With TestDB
                    .M_商品.Add(商品)
                    .SaveChanges()
                End With
            End If
        End Using
    End Sub

    ''' <summary>
    ''' 指定した商品IDが存在する場合には削除します。
    ''' </summary>
    ''' <param name="商品ID"></param>
    Public Shared Sub 指定した商品IDが存在する場合には削除する(商品ID As String)
        Using TestDB As New SampleApplication.SampleAppDBEntities
            Dim レコードセット = From レコード In TestDB.M_商品 Where レコード.商品ID = 商品ID

            If レコードセット.Count = 1 Then
                With TestDB
                    .M_商品.Remove(レコードセット.First)
                    .SaveChanges()
                End With
            End If
        End Using
    End Sub

    ''' <summary>
    ''' テスト文字列生成メソッドは、指定された数の文字列をListにして返します。
    ''' </summary>
    ''' <param name="任意文字列">任意の文字列を設定します。</param>
    ''' <param name="生成数">生成する文字列の数を設定します。</param>
    ''' <returns></returns>
    Public Function テスト文字列を生成する(任意文字列 As String, 生成数 As Integer) As List(Of String)
        For カウンタ = 1 To 生成数
            m_List.Add("test" & 任意文字列 & カウンタ.ToString)
        Next
        Return m_List
    End Function

End Class
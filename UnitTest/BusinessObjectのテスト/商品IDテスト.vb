Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class 商品IDテスト

    <TestMethod()> Public Sub 商品IDの基本テスト()

        Const ID As String = "000000"
        Dim 商品ID As New 商品ID(ID)
        Assert.AreEqual(ID, 商品ID.値)

    End Sub

    '6桁の半角数字以外は使用できない。
    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理1()
        Dim 商品ID As New 商品ID("")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理2()
        Dim 商品ID As New 商品ID("1234567")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理2a()
        Dim 商品ID As New 商品ID("123-45")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理3()
        Dim 商品ID As New 商品ID("123")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理4()
        Dim 商品ID As New 商品ID("１２３４５６")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDクラス例外処理5()
        Dim 商品ID As New 商品ID("abcdef")
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub 商品IDの重複は例外()
        '指定したキーがすでに存在する場合は例外とする。
        テストデータの確認()
        '重複したキーでの生成は例外になる。
        Dim 商品ID As New 商品ID("999999")
    End Sub

    ''' <summary>
    ''' テストデータの確認メソッド
    ''' </summary>
    Private Shared Sub テストデータの確認()
        '参照をSampleApplicationにすることで名前解決する。
        Using TestDB As New SampleApplication.SampleAppDBEntities

            Const _商品ID As String = "999999"
            Const _メーカー As Integer = 3
            Const _分類 As Integer = 4
            Const _商品 As String = "EOS-1n"
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

End Class
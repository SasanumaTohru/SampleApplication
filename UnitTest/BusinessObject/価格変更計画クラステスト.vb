Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格変更計画クラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 価格変更リスト基本テスト()

        '価格変更項目の作成
        Dim 対象商品ID As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)
        '仕入価格の変更
        Dim 価格変更項目1 As New 価格変更項目(対象商品ID, 価格変更項目.価格区分リスト.仕入,
                      New 金額(90000D), New 金額(89800D),
                      New 日付("#4/1/2020#"))
        '販売価格の変更
        Dim 価格変更項目2 As New 価格変更項目(対象商品ID, 価格変更項目.価格区分リスト.販売,
                      New 金額(98200D), New 金額(92700D),
                      New 日付("#4/1/2020#"))

        '価格変更計画に価格変更項目を追加する
        Dim 価格変更計画 As New 価格変更計画
        With 価格変更計画
            .項目を追加する(価格変更項目1)
            .項目を追加する(価格変更項目2)
        End With
        Assert.AreEqual(2, 価格変更計画.項目数)

        '価格変更計画の項目を参照する
        Assert.AreEqual(対象商品ID.値, 価格変更計画.項目(対象商品ID, 価格変更項目.価格区分リスト.仕入).商品ID.値)
        Assert.AreEqual("販売", 価格変更計画.項目(対象商品ID, 価格変更項目.価格区分リスト.販売).価格区分.ToString)
        '価格変更計画の項目リストを参照する
        For Each 項目 As 価格変更項目 In 価格変更計画.項目リスト
            Debug.Print(項目.商品ID.値.ToString & " , " & 項目.価格区分.ToString & " , " & 項目.適用開始日.西暦年月日文字列)
        Next

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 項目の一意性チェック()
        '価格変更項目の作成
        Dim 対象商品ID As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)
        '仕入価格の変更
        Dim 価格変更項目1 As New 価格変更項目(対象商品ID, 価格変更項目.価格区分リスト.仕入,
                      New 金額(90000D), New 金額(89800D),
                      New 日付("#4/1/2020#"))

        '価格変更計画に価格変更項目を追加する
        Dim 価格変更計画 As New 価格変更計画
        With 価格変更計画
            .項目を追加する(価格変更項目1)
            .項目を追加する(価格変更項目1)
        End With

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> Public Sub 項目の一意性チェック例外メッセージ確認()
        '価格変更項目の作成
        Dim 対象商品ID As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)
        '仕入価格の変更
        Dim 価格変更項目1 As New 価格変更項目(対象商品ID, 価格変更項目.価格区分リスト.仕入,
                      New 金額(90000D), New 金額(89800D),
                      New 日付("#4/1/2020#"))

        '価格変更計画に価格変更項目を追加する
        Dim 価格変更計画 As New 価格変更計画
        Try
            With 価格変更計画
                .項目を追加する(価格変更項目1)
                .項目を追加する(価格変更項目1)
            End With
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

    End Sub

End Class
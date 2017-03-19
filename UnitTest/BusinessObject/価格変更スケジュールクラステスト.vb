Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格変更スケジュールクラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 価格変更スケジュールクラス基本テスト()

        Dim 価格を変更する商品 As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)

        Dim 予定1 As New 価格変更.予定(価格を変更する商品, 価格変更.予定.価格区分リスト.仕入,
                      New 金額(90000D), New 金額(89800D),
                      New 日付("#4/1/2020#"))

        Dim 予定2 As New 価格変更.予定(価格を変更する商品, 価格変更.予定.価格区分リスト.販売,
                      New 金額(98200D), New 金額(92700D),
                      New 日付("#4/1/2020#"))


        Dim スケジュール As New 価格変更.スケジュール
        With スケジュール
            .追加する(予定1)
            .追加する(予定2)
        End With
        Assert.AreEqual(2, スケジュール.予定数)


        Assert.AreEqual(価格を変更する商品.値, スケジュール.予定(価格を変更する商品, 価格変更.予定.価格区分リスト.仕入, New 日付("#4/1/2020#")).商品ID.値)
        Assert.AreEqual("販売", スケジュール.予定(価格を変更する商品, 価格変更.予定.価格区分リスト.販売, New 日付("#4/1/2020#")).価格区分.ToString)

        For Each 予定 As 価格変更.予定 In スケジュール.予定リスト
            Debug.Print(予定.商品ID.値.ToString & " , " & 予定.価格区分.ToString & " , " & 予定.適用開始日.西暦年月日文字列)
        Next

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 予定の一意性チェック()

        Dim 対象商品ID As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)

        Dim 予定1 As New 価格変更.予定(対象商品ID, 価格変更.予定.価格区分リスト.仕入,
                      New 金額(90000D), New 金額(89800D),
                      New 日付("#4/1/2020#"))

        Dim スケジュール As New 価格変更.スケジュール
        With スケジュール
            .追加する(予定1)
            .追加する(予定1)
        End With

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> Public Sub 予定の一意性チェック例外メッセージ確認()

        Dim 対象商品ID As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)

        Dim 予定1 As New 価格変更.予定(対象商品ID, 価格変更.予定.価格区分リスト.仕入,
                      New 金額(90000D), New 金額(89800D),
                      New 日付("#4/1/2020#"))

        Dim スケジュール As New 価格変更.スケジュール
        Try
            With スケジュール
                .追加する(予定1)
                .追加する(予定1)
            End With
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

    End Sub

End Class
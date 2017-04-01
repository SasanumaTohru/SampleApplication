Imports SampleApplication.BusinessObject.商品
Imports SampleApplication.PrimitiveObject

<TestClass()> Public Class 価格変更スケジュールクラステスト

    <TestMethod()> <TestCategory("基本テスト")> Public Sub 価格変更スケジュールクラス基本テスト()

        Dim テストデータ準備 As New TestDataSetup
        テストデータ準備.適用価格テーブルをクリアする()

        Dim 価格を変更する商品 As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)
        Dim 適用価格1 As New 適用価格.価格(価格を変更する商品, 適用価格.価格.区分リスト.仕入, New 金額(89800D), New 日付("#4/1/2020#"))
        Dim 適用価格2 As New 適用価格.価格(価格を変更する商品, 適用価格.価格.区分リスト.販売, New 金額(92700D), New 日付("#4/1/2020#"))

        Dim スケジュール As New 適用価格.スケジュール
        Assert.AreEqual(0, スケジュール.適用価格数)
        With スケジュール
            .追加する(適用価格1)
            .追加する(適用価格2)
        End With
        Assert.AreEqual(2, スケジュール.適用価格数)

        Assert.AreEqual(価格を変更する商品.値, スケジュール.項目(価格を変更する商品, 適用価格.価格.区分リスト.仕入, New 日付("#4/1/2020#")).商品ID.値)
        Assert.AreEqual("販売", スケジュール.項目(価格を変更する商品, 適用価格.価格.区分リスト.販売, New 日付("#4/1/2020#")).価格区分.ToString)

        For Each 適用価格 As 適用価格.価格 In スケジュール.リスト
            Debug.Print(適用価格.商品ID.値.ToString & " , " & 適用価格.価格区分.ToString & " , " & 適用価格.適用開始日.西暦年月日文字列)
        Next

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> <ExpectedException(GetType(Exception))> Public Sub 予定の一意性チェック()

        Dim テストデータ準備 As New TestDataSetup
        テストデータ準備.適用価格テーブルをクリアする()

        Dim 対象商品ID As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)
        Dim 適用価格 As New 適用価格.価格(対象商品ID, SampleApplication.BusinessObject.商品.適用価格.価格.区分リスト.仕入, New 金額(89800D), New 日付("#4/1/2020#"))

        Dim スケジュール As New 適用価格.スケジュール
        With スケジュール
            .追加する(適用価格)
            .追加する(適用価格)
        End With

    End Sub

    <TestMethod()> <TestCategory("例外テスト")> Public Sub 予定の一意性チェック例外メッセージ確認()

        Dim テストデータ準備 As New TestDataSetup
        テストデータ準備.適用価格テーブルをクリアする()

        Dim 対象商品ID As 商品ID = New 商品ID("999999", 商品ID.コンストラクタオプション.参照)
        Dim 適用価格 As New 適用価格.価格(対象商品ID, SampleApplication.BusinessObject.商品.適用価格.価格.区分リスト.仕入, New 金額(89800D), New 日付("#4/1/2020#"))

        Dim スケジュール As New 適用価格.スケジュール
        Try
            With スケジュール
                .追加する(適用価格)
                .追加する(適用価格)
            End With
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

    End Sub

End Class
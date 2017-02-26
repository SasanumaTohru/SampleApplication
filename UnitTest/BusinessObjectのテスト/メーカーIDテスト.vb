Imports SampleApplication.BusinessObject.商品

<TestClass()> Public Class メーカーIDテスト

    <TestMethod()> Public Sub メーカーIDクラス基本テスト()
        'メーカーIDは、1から始まる連番で採番される。メーカーIDは不変であり、削除されることもない。
        Dim メーカーID As New メーカーID(3)
        Assert.AreEqual(3, メーカーID.値)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub メーカークラス例外処理1()
        '登録のないIDは例外。
        Dim メーカーID As New メーカーID(0)
    End Sub

    <TestMethod()> <ExpectedException(GetType(Exception))> Public Sub メーカークラス例外処理2()
        '登録のないIDは例外。
        Dim メーカーID As New メーカーID(メーカーIDの最大値を取得する() + 1)
    End Sub

    ''' <summary>
    ''' 分類コードの最大値を取得するメソッド
    ''' </summary>
    ''' <returns></returns>
    Private Function メーカーIDの最大値を取得する() As Integer
        Using MyDB As New SampleApplication.SampleAppDBEntities
            Dim メーカーID = From レコード In MyDB.M_メーカー Select レコード.ID

            Return メーカーID.Max
        End Using
    End Function

End Class
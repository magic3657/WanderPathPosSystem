Imports System.Data.SQLite

Public Class Form8
    Public Property SourceForm As Form5

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        QueryCharged(SourceForm.ChooseChargeNo.Text)
    End Sub

    '按下回上一層鈕
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ShowDataView.Rows.Clear()
        Hide()
    End Sub

    '查詢收費明細資料
    Private Sub QueryCharged(ByVal form_charge_no As String)
        ShowDataView.Rows.Clear()

        Try
            Dim oCmd As New SQLiteCommand("SELECT fullname, qty, price, subtotal FROM charged WHERE charge_no = '" & form_charge_no & "';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                ShowDataView.Rows.Add(New String() {oDR("fullname"), oDR("qty"), oDR("price"), oDR("subtotal")})
            End While
        Catch ex As Exception
            MsgBox("收費明細查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub
End Class
Imports System.Data.SQLite

Public Class ShowPriceDetail
    Public Property SourceForm As Form3

    Private Sub ShowPriceDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Focus()

        NowPaidAmt.Clear()
        PaidAmt.Clear()
        ChangeAmt.Clear()
        DiscountAmt.Clear()
        TotalAmt.Clear()
        ReturnAmt.Clear()
        NowEmployeeName.Clear()
        NowEmployeeNo.Clear()

        PaidAmt.Text = SourceForm.PaidAmt.Text
        NowPaidAmt.Text = SourceForm.NowPaidAmt.Text
        TotalAmt.Text = SourceForm.TotalAmt.Text
        DiscountAmt.Text = SourceForm.DiscountAmt.Text
        ChangeAmt.Text = SourceForm.ChangeAmt.Text
        ReturnAmt.Text = SourceForm.ReturnAmt.Text
        NowEmployeeName.Text = SourceForm.NowEmployeeName.Text
        NowEmployeeNo.Text = SourceForm.NowEmployeeNo.Text

        '控管如果退款金額小於0(負數)則將付款欄位設定不可修改
        If (ReturnAmt.Text < 0) Then
            Label7.Text = "退款"
        Else
            Label7.Text = "加收"
        End If

        AddHandler TotalAmt.KeyDown, AddressOf Button1_Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()
    End Sub
End Class
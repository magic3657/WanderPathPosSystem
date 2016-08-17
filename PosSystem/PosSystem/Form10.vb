Imports System.Data.SQLite

Public Class Form10
    Public Property SourceForm As Form9
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '取得登入者資訊
        NowEmployeeNo.Text = SourceForm.NowEmployeeNo.Text
        NowEmployeeName.Text = SourceForm.NowEmployeeName.Text
        '取得使用者輸入之補帳資料
        ChargeDate.Text = SourceForm.ChargeDate.Text
        ChargeRemark.Text = SourceForm.ChargeRemark.Text
        ChargeAmt.Text = SourceForm.ChargeAmt.Text
    End Sub

    '確認補帳
    Private Sub Yes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yes.Click
        Dim MaxChargeNo As Integer = 0
        Dim ExecuteInsertWork As Boolean = True
        Dim ChargeDateTime As String = ""
        ChargeDateTime = ChargeDate.Text & DateTime.Now.ToString("HHmm")

        '取得最大收費號碼
        Try
            MaxChargeNo = getMaxChargeNo()
        Catch ex As Exception
            ExecuteInsertWork = False
        End Try

        If (ExecuteInsertWork = True) Then
            Try
                '寫入收費主檔
                InsertCharge("charge", MaxChargeNo, ChargeDateTime, NowEmployeeNo.Text.ToString, ChargeAmt.Text, 0, 0, 0, ChargeAmt.Text, 0, "", 0, "補帳:" & ChargeRemark.Text.ToString)
                MsgBox("補帳成功")
                ChargeDate.Clear()
                ChargeRemark.Clear()
                ChargeAmt.Clear()
                NowEmployeeNo.Clear()
                NowEmployeeName.Clear()

                SourceForm.ChargeDate.Clear()
                SourceForm.ChargeRemark.Clear()
                SourceForm.ChargeAmt.Clear()

                Hide()
            Catch ex As Exception
                MsgBox("補帳失敗，寫入帳檔有誤")
            End Try
        Else
            MsgBox("補帳失敗，取得收費號碼有誤")
        End If
    End Sub

    '取消補帳
    Private Sub No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No.Click
        ChargeDate.Clear()
        ChargeRemark.Clear()
        ChargeAmt.Clear()
        NowEmployeeNo.Clear()
        NowEmployeeName.Clear()

        Hide()
    End Sub

    '寫入收費主檔 / 收費明細檔
    Private Sub InsertCharge(ByVal form_TableName As String, ByVal form_ChargeNo As Integer, ByVal form_DateTime As String, ByVal form_CheckUser As String,
                             ByVal form_TotalAmt As Integer, ByVal form_DiscountAmt As Integer, ByVal form_NowPaidAmt As Integer, ByVal form_ChangeAmt As Integer,
                             ByVal form_PaidAmt As Integer, ByVal form_ReturnAmt As Integer, ByVal form_ScrapDate As String, ByVal form_MealNo As Integer, ByVal form_Remark As String)

        If (form_TableName = "charge") Then
            Try
                Dim oCmd As New SQLiteCommand("INSERT INTO charge (charge_no, charge_datetime, charge_clerk, total_amt, discount_amt, paid_amt, return_amt, scrap_datetime, meal_no, remark) VALUES ('" & form_ChargeNo & "','" & form_DateTime & "','" & form_CheckUser & "','" & form_TotalAmt & "','" & form_DiscountAmt & "','" & form_PaidAmt & "','" & form_ReturnAmt & "','" & form_ScrapDate & "','" & form_MealNo & "','" & form_Remark & "');", oConn)
                oCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("寫入收費主檔失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try
        End If
    End Sub

    '取得目前最大收費號
    Function getMaxChargeNo() As Integer
        Dim chargeNo As Integer = 0

        Try
            Dim oCmd As New SQLiteCommand("SELECT MAX(charge_no) FROM charge;", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()
            oDR.Read()
            chargeNo = oDR("MAX(charge_no)")
        Catch ex As Exception
            chargeNo = 0
        End Try

        If (chargeNo = 0) Then
            chargeNo = 1
        ElseIf (chargeNo > 0) Then
            chargeNo = chargeNo + 1
        End If

        Return chargeNo
    End Function

    '滑鼠點一下補帳金額
    Private Sub ChargeAmt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChargeAmt.MouseClick
        Try
            If (ChargeAmt.Text = 0 Or String.IsNullOrEmpty(ChargeAmt.Text)) Then
                ChargeAmt.Clear()
            End If
        Catch ex As Exception
            ChargeAmt.Text = 0
        End Try
    End Sub

    '補帳欄位非當前控制項時判斷是否為空，若為空則預設給0
    Private Sub ChargeAmt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargeAmt.Leave
        If (ChargeAmt.Text.Length = 0) Then
            ChargeAmt.Text = 0
        End If
    End Sub
End Class
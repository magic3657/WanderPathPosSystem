Imports System.Data.SQLite
Public Class Form5
    Public Property SourceForm As Form3
    Public Property SourceForm2 As Form9
    Dim dayTotalAmt As Integer = 0

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '檢核目前由哪個表單呼叫
        CheckNowCallBy()

        '如果是補帳用途則隱藏帶入功能
        If (Me.Text = "查詢帳款資料") Then
            ShowDataView.Columns(0).Visible = False
        Else
            ShowDataView.Columns(0).Visible = True
        End If

        '只有管理者可以看到日總額
        If (AdminFlag = "Y") Then
            DayTotal.Visible = True
            DayTotalLabel.Visible = True
        Else
            DayTotal.Visible = False
            DayTotalLabel.Visible = False
        End If

        Dim charge_date As String = ""
        charge_date = DateTime.Now.ToString("yyyyMMdd")
        ChargeDate.Text = charge_date
        QueryCharge(charge_date)

        If (Me.Text = "查詢帳款資料") Then
            Hide()
        Else
            AddHandler Cancel.MouseClick, AddressOf SourceForm.Restart_Click
        End If

    End Sub

    '控管只能輸入數字
    Private Sub ChargeDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChargeDate.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(13) Then
            If (CheckDateTime(ChargeDate.Text.ToString)) Then
                '查出結帳明細資料
                QueryCharge(ChargeDate.Text)
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If (Me.Text = "查詢帳款資料") Then
            Hide()
        Else
            If (SourceForm.Status = "") Then
                SourceForm.Status = ""
            End If

            Hide()
        End If

    End Sub

    Private Sub QueryCharge(ByVal form_date As String)
        ShowDataView.Rows.Clear()
        Try
            dayTotalAmt = 0
            Dim oCmd As New SQLiteCommand("SELECT charge_no, charge_datetime, charge_clerk, total_amt, discount_amt, paid_amt, return_amt, meal_no, remark, spec_meal_no, seat, customer_amt FROM charge WHERE substr(charge_datetime, 0,9) = '" & form_date & "' AND scrap_datetime = '" & "" & "'ORDER BY meal_no;", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                ShowDataView.Rows.Add(New String() {"帶入", "明細", oDR("remark"), oDR("meal_no"), oDR("seat").ToString, oDR("spec_meal_no").ToString, oDR("charge_no"), oDR("charge_datetime"), oDR("charge_clerk"), oDR("total_amt"), oDR("discount_amt"), oDR("paid_amt"), oDR("return_amt"), oDR("customer_amt")})
                dayTotalAmt += oDR("paid_amt")
            End While

            DayTotal.Text = dayTotalAmt

        Catch ex As Exception
            MsgBox("收費資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    Private Sub ShowDataView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowDataView.CellContentClick
        If e.ColumnIndex = 0 And ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("MealNo").Value <> 0 Then
            SourceForm.Status = "ModifyOrderData"
            SourceForm.ShowDataView.Rows.Clear()
            SourceForm.MealNumber.Clear()
            SourceForm.ChargeNo.Clear()

            Try
                Dim oCmd As New SQLiteCommand("SELECT id, type, fullname, qty, price, addwith, subtotal, (SELECT addto_flag FROM itemsetting WHERE id = charged.id) addto_flag, remark FROM charged WHERE charge_no = '" & ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ChargeNo").Value & "';", oConn)
                Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

                While oDR.Read()
                    SourceForm.ShowDataView.Rows.Add(New String() {"修改", "一", oDR("id").ToString, oDR("type").ToString, oDR("fullname").ToString, oDR("qty").ToString, oDR("price").ToString, oDR("addwith").ToString, oDR("subtotal").ToString, oDR("addto_flag").ToString, oDR("remark").ToString})
                End While
            Catch ex As Exception
                MsgBox("收費明細查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
            End Try

            SourceForm.MealNumber.Text = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("MealNo").Value
            SourceForm.SpecNumber.Text = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("SpecMealNo").Value
            SourceForm.Seat.Text = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("seat").Value
            SourceForm.ChargeNo.Text = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ChargeNo").Value
            SourceForm.ShowStatus.Text = "修改中"

            Calculator()
            SourceForm.WindowState = FormWindowState.Maximized
            Hide()
        ElseIf e.ColumnIndex = 1 And ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("MealNo").Value <> 0 Then
            ChooseChargeNo.Text = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ChargeNo").Value
            Dim frm As New Form8
            frm.SourceForm = Me
            frm.ShowDialog()
        End If
    End Sub

    '檢核目前是由哪個表單呼叫
    Private Sub CheckNowCallBy()
        Dim CallByForm As String = ""

        Try
            CallByForm = Me.SourceForm2.Text.ToString
            Me.Text = "查詢帳款資料"
        Catch ex As Exception
            CallByForm = ""
            Exit Try
        End Try

        Try
            CallByForm = Me.SourceForm.Text.ToString
            Me.Text = "查詢已結帳資料"
        Catch ex As Exception
            CallByForm = ""
            Exit Try
        End Try
    End Sub

    '計算金額並顯示於畫面上
    Private Sub Calculator()
        'Step1. 檢查付款、折扣是否已經輸入? 若未輸入則預設給0
        'Step2. 檢查已付是否有值? 若未輸入則預設給0
        'Step3. 檢查找零是否已經產生? 若未產生則預設給0
        'Step4. 計算金額並將結果顯示於畫面上

        '計算金額變數
        Dim nowpaid As Integer = 0
        Dim paid As Integer = 0
        Dim change As Integer = 0
        Dim discount As Integer = 0
        Dim total As Integer = 0
        Dim return_amt As Integer = 0

        If (SourceForm.NowPaidAmt.Text.Length = 0) Then
            SourceForm.NowPaidAmt.Text = 0
        End If

        If (SourceForm.DiscountAmt.Text.Length = 0) Then
            SourceForm.DiscountAmt.Text = 0
        End If

        If (SourceForm.PaidAmt.Text.Length = 0) Then
            SourceForm.PaidAmt.Text = 0
        End If

        If (SourceForm.ChangeAmt.Text.Length = 0) Then
            SourceForm.ChangeAmt.Text = 0
        End If

        If (SourceForm.ReturnAmt.Text.Length = 0) Then
            SourceForm.ReturnAmt.Text = 0
        End If

        '初始化總金額, 並全部重算
        total = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("TotalAmt").Value
        '付款金額
        nowpaid = CInt(SourceForm.NowPaidAmt.Text)
        '已付金額
        paid = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("PaidAmt").Value
        '折扣金額
        discount = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("DiscountAmt").Value
        '找零金額
        change = CInt(SourceForm.ChangeAmt.Text)
        '退款/加收金額
        return_amt = CInt(SourceForm.ReturnAmt.Text)

        If (discount > 0) Then
            total = total - discount
        End If

        SourceForm.TotalAmt.Text = total
        SourceForm.PaidAmt.Text = paid
        SourceForm.DiscountAmt.Text = discount
        SourceForm.ReturnAmt.Text = total - paid
        SourceForm.ChangeAmt.Text = 0
    End Sub

    '日期檢核
    Function CheckDateTime(ByVal form_DateTime As String) As Boolean
        Dim tt As String = form_DateTime
        Try
            Dim dd As DateTime = DateTime.ParseExact(tt, "yyyyMMdd", Nothing)
            Return True
        Catch ex As Exception
            MsgBox("輸入日期格式錯誤， 格式範例:20150101")
            Return False
        End Try

        Return True
    End Function
End Class
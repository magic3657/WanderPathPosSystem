Imports System.Data.SQLite
Imports OnBarcode.Barcode
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports WindowsApplication1.QREncrypter
Public Class Form3
    Public Property SourceForm As Form1

    Private Sub SetMdiBackColor()
        Me.Controls(Me.Controls.Count - 1).BackColor = Me.BackColor
    End Sub

    '記錄點餐資料
    'Dim tempOrderArrayList As New ArrayList
    ''ArrayList資料指定至一維陣列, 其一維陣列的索引長度
    ''定義收費明細檔陣列暫存索引值所代表意義:
    ''(如需增加索引項目於此新增即可，無須個別修改每個暫存一維陣列長度，但寫入資料庫需自行增加寫入欄位)
    ''   索引 0 >>> 品項種類
    ''   索引 1 >>> 品項名稱
    ''   索引 2 >>> 數量
    ''   索引 3 >>> 價格
    ''   索引 4 >>> 飲品備註
    ''   索引 5 >>> 品項代號(唯一識別的代號)
    ''   索引 6 >>> 含附加項目共幾項(冰品如有加點項目則一定是大於一項, 用於顯示清單之判斷)
    ''   索引 7 >>> 紀錄該筆紀錄放在點餐清單中的位置索引(用於刪除清單之判斷)
    'Dim ArrayListToArrayIndex As Integer = 7
    'Dim ClickData As Integer = 0
    'Dim PreviousId As Integer = 0

    '計算金額變數
    Dim nowpaid As Integer = 0
    Dim paid As Integer = 0
    Dim change As Integer = 0
    Dim discount As Integer = 0
    Dim total As Integer = 0
    Dim return_amt As Integer = 0

    '點餐號碼
    Dim mealNo As Integer = 0

    '註記是新增模式/修改模式
    Public Mode As String = ""
    '產生點餐次序
    Public OrderSerno As Integer = 0
    '狀態
    Public Status As String = ""
    '切換登入成功否
    Public changeLoginSuccess As Boolean = False
    Dim WithEvents EditingControl As DataGridViewTextBoxEditingControl

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If isNotRun Then
            '取得變更背景控制權
            SetMdiBackColor()

            '取得登入者資訊
            NowEmployeeNo.Text = nowLoginEmpNo
            NowEmployeeName.Text = nowLoginEmpName
            SourceForm.Hide()

            '初始化
            InitailData()
        Else
            MessageBox.Show("[ 溫馨小提示 ]" & vbCrLf & "請勿重複開啟 [ 散步路徑收驚系統 ]... " & vbCrLf & "或者 請關閉 [ 散步路徑補帳/統計系統 ] 才可啟動。")
            End
        End If


    End Sub

    '按下ENTER鍵不跳下一個ROW, 跳至下一個COLUMN
    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '  Select keyData
    '   Case Keys.Enter
    '        SendKeys.Send("{TAB}")
    '         Return True
    '  End Select
    '   Return False
    'End Function

    '取得DataGridView編輯控制權
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles ShowDataView.EditingControlShowing
        If ShowDataView.CurrentCell.ColumnIndex = 5 Then
            EditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)
        End If
    End Sub

    '設定DtaGridView欄位中限定輸入資料為何種型態(英文或數字)
    Private Sub EditingControl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EditingControl.KeyPress
        If ShowDataView.CurrentCell.ColumnIndex = 5 Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    '確認冰品
    Private Sub IceDataView_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles IceDataView.MouseClick
        Mode = "New"

        If (IceDataView.Rows(IceDataView.SelectedRows(0).Index).Cells.Item("IceAddToFlag").Value = "Y") Then
            OrderSerno = OrderSerno + 1
            Dim frm As New Form4
            frm.SourceForm = Me
            frm.ShowDialog()
        ElseIf (IceDataView.Rows(IceDataView.SelectedRows(0).Index).Cells.Item("IceAddToFlag").Value = "N") Then
            ShowOrderList(IceDataView, "Ice")
            Calculator()
        End If
    End Sub

    '確認點心
    Private Sub DessertDataView_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DessertDataView.MouseClick
        Mode = "New"
        ShowOrderList(DessertDataView, "Dessert")
        '計算金額並將結果顯示於畫面上
        Calculator()
    End Sub

    '確認飲料
    Private Sub DrinkDataView_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DrinkDataView.MouseClick
        Mode = "New"
        ShowOrderList(DrinkDataView, "Drink")
        '計算金額並將結果顯示於畫面上
        Calculator()
    End Sub

    '確認其它商品
    Private Sub DataGridView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OthersDataView.MouseClick
        Mode = "New"
        ShowOrderList(OthersDataView, "Others")
        '計算金額並將結果顯示於畫面上
        Calculator()
    End Sub

    '點選兩下進行刪除動作
    Private Sub ShowDataView_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShowDataView.MouseDoubleClick
        '判斷是否點擊畫面上的 "修改" 或 "－" , 如果是--> 不執行刪除資料
        If (ShowDataView.CurrentCell.ColumnIndex > 1) Then
            '刪除畫面上資料
            DoubleClickToDeleteData()
        End If
    End Sub

    '點選付款金額欄位若為0則立即清空欄位數值
    Private Sub NowPaidAmt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NowPaidAmt.MouseClick
        Try
            If (NowPaidAmt.Text = 0 Or String.IsNullOrEmpty(NowPaidAmt.Text)) Then
                NowPaidAmt.Clear()
            End If
        Catch ex As Exception
            NowPaidAmt.Text = 0
        End Try

    End Sub

    '付款金額欄位非當前控制項時判斷是否為空，若為空則預設給0
    Private Sub NowPaidAmt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NowPaidAmt.Leave
        If (NowPaidAmt.Text.Length = 0) Then
            NowPaidAmt.Text = 0
        End If
    End Sub

    '限制付款金額欄位只能輸入數字 (首先先將欄位ImeMode屬性設定為 Disable)
    Private Sub NowPaidAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NowPaidAmt.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    '付款金額欄位及時輸入運算
    Private Sub NowPaidAmt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NowPaidAmt.KeyUp
        Calculator()
    End Sub

    '付款金額按下ENTER直接進行結帳
    Private Sub NowPaidAmt_KeyDown(sender As Object, e As KeyEventArgs) Handles NowPaidAmt.KeyDown
        If (e.KeyCode = 13) Then
            Execute_Charge()
        End If
    End Sub

    '點選折扣金額欄位若為0則立即清空欄位數值
    Private Sub DiscountAmt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DiscountAmt.MouseClick
        Try
            If (DiscountAmt.Text = 0) Then
                DiscountAmt.Clear()
            End If
        Catch ex As Exception
            DiscountAmt.Text = 0
        End Try

    End Sub

    '折扣金額欄位非當前控制項時判斷是否為空，若為空則預設給0
    Private Sub DiscountAmt_Leave(sender As Object, e As EventArgs) Handles DiscountAmt.Leave
        If (DiscountAmt.Text.Length = 0) Then
            DiscountAmt.Text = 0
        End If
    End Sub

    '限制折扣金額欄位只能輸入數字 (首先先將欄位ImeMode屬性設定為 Disable)
    Private Sub DiscountAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DiscountAmt.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    '折扣金額欄位及時輸入運算
    Private Sub DiscountAmt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DiscountAmt.KeyUp
        Calculator()
    End Sub

    '點選特殊註記欄位若為空則立即給初始值NULL
    Private Sub SpecNumber_MouseClick(sender As Object, e As MouseEventArgs)
        If (String.IsNullOrEmpty(SpecNumber.Text)) Then
            SpecNumber.Text = "NULL"
        End If

        If (SpecNumber.Text = "NULL") Then
            SpecNumber.Clear()
        End If
    End Sub

    '特殊註記欄位非當前控制項時判斷是否為空，若為空則預設給NULL
    Private Sub SpecNumber_Leave(sender As Object, e As EventArgs)
        If (String.IsNullOrEmpty(SpecNumber.Text)) Then
            SpecNumber.Text = "NULL"
        End If
    End Sub

    '進行退單作業
    Private Sub ScrapeCharge_Click(sender As Object, e As EventArgs) Handles ScrapeCharge.Click
        If MessageBox.Show("是否確定退單?? 確認退單則會刪除此訂單所有資料!!!", "退單確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ShowDataView.Rows.Clear()
            Calculator()
            Execute_Charge()
        End If
    End Sub

    '執行結帳作業
    Private Sub Execute_Charge()
        Dim MaxChargeNo As Integer = 0
        Dim ExecuteInsertWork As Boolean = True
        Dim ChargeDateTime As String = ""
        Dim ScrapDateTIme As String = ""
        Dim CheckExecute As Boolean = False

        ChargeDateTime = DateTime.Now.ToString("yyyyMMdd") & DateTime.Now.ToString("HHmm")

        '計算金額並將結果顯示於畫面上
        Calculator()

        If (ExecuteInsertWork And ShowDataView.Rows.Count - 2 >= 0 Or CInt(ReturnAmt.Text) < 0) Then
            '若為新增訂單狀態或為修改訂單狀態且為加收狀態則控管必須填付款金額才可結帳
            '若為修改訂單狀態且為退款情形, 付款金額不控管有無輸入

            If ((Status <> "ModifyOrderData" And CInt(NowPaidAmt.Text) > 0) Or
                (Status = "ModifyOrderData" And CInt(TotalAmt.Text) - CInt(PaidAmt.Text) > 0 And CInt(NowPaidAmt.Text) > 0) Or
                (Status = "ModifyOrderData" And CInt(TotalAmt.Text) - CInt(PaidAmt.Text) < 0) Or
                (Status = "ModifyOrderData" And CInt(TotalAmt.Text) - CInt(PaidAmt.Text) = 0) And CInt(NowPaidAmt.Text) = 0) Then

                If (Status = "ModifyOrderData" And CInt(ReturnAmt.Text) > 0 And CInt(NowPaidAmt.Text) < CInt(ReturnAmt.Text)) Then
                    MsgBox("付款金額不可低於加收金額，必須付清，或設定折扣")
                    '非修改模式或修改模式且已付等於零 找零小於零則控管不得結帳
                ElseIf ((Status <> "ModifyOrderData" And ChangeAmt.Text < 0) Or
                        (Status = "ModifyOrderData" And CInt(PaidAmt.Text) = 0 And ChangeAmt.Text < 0)) Then
                    MsgBox("付款金額不可低於總金額，必須付清，或設定折扣")
                Else
                    CheckExecute = True
                    If ((Status = "ModifyOrderData" And CInt(TotalAmt.Text) - CInt(PaidAmt.Text) = 0) And CInt(NowPaidAmt.Text) = 0) Then
                        If MessageBox.Show("總金額與修改前總金額相同，是否確定進行結帳??", "結帳確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            CheckExecute = True
                        Else
                            CheckExecute = False
                        End If
                    End If

                    If (CheckExecute = True) Then
                        mealNo = CInt(MealNumber.Text)

                        If (Status = "ModifyOrderData") Then
                            ScrapDateTIme = DateTime.Now.ToString("yyyyMMdd") & DateTime.Now.ToString("HHmm")
                            UpdateCharge("charge", ChargeNo.Text, ScrapDateTIme)
                            ScrapDateTIme = ""
                        End If

                        '取得最大收費號碼
                        Try
                            MaxChargeNo = getMaxChargeNo()
                            ChargeNo.Text = MaxChargeNo
                        Catch ex As Exception
                            ExecuteInsertWork = False
                        End Try

                        If (ExecuteInsertWork = True) Then
                            '寫入收費主檔
                            InsertCharge("charge", MaxChargeNo, ChargeDateTime, NowEmployeeNo.Text, total, discount, nowpaid, change, paid, return_amt, ScrapDateTIme, mealNo, ConvertNarrow(SpecNumber.Text), Seat.Text)

                            If Not (return_amt < 0 And ShowDataView.Rows.Count - 2 < 0) Then
                                '寫入收費明細檔
                                InsertCharge("charged", MaxChargeNo, ChargeDateTime, NowEmployeeNo.Text, total, discount, nowpaid, change, paid, return_amt, ScrapDateTIme, mealNo, ConvertNarrow(SpecNumber.Text), Seat.Text)
                            End If

                            If (CheckNowPrint.Checked = True And Status <> "ModifyOrderData") Then

                                '列印顧客聯
                                PrintOrder("Customer")

                                '列印廚房內場單
                                PrintOrder("Employee")
                            ElseIf (CheckNowPrint.Checked = True And Status = "ModifyOrderData" And ShowDataView.Rows.Count > 1) Then
                                If (CInt(PaidAmt.Text) > 0) Then
                                    If MessageBox.Show("是否要印內場單??", "修改印單選擇", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                        '列印顧客聯
                                        PrintOrder("Customer")

                                        '列印廚房內場單
                                        PrintOrder("Employee")
                                    Else
                                        '列印顧客聯
                                        PrintOrder("Customer")
                                    End If
                                Else
                                    '列印顧客聯
                                    PrintOrder("Customer")

                                    '列印廚房內場單
                                    PrintOrder("Employee")
                                End If
                            End If

                            '列印電子發票
                            QRCodePrinter()

                            '更新座號資訊
                            UpdateSeatviewerData(ConvertSeatName(Seat.Text.ToString, "CTE"), "PAID", ChargeNo.Text)

                            If (Status = "ModifyOrderData") Then
                                '查詢點餐號碼
                                CheckMealNo("Query")
                            ElseIf (Status <> "ModifyOrderData") Then
                                '更新並產生點餐號碼
                                CheckMealNo("Add")
                            End If

                            '顯示此次結帳資訊
                            Dim frm As New ShowPriceDetail
                            frm.SourceForm = Me
                            frm.ShowDialog()

                            '初始化
                            InitailData()
                        ElseIf (ExecuteInsertWork = False) Then
                            MsgBox("結帳失敗")
                        End If
                    End If
                End If
            Else
                If (CInt(NowPaidAmt.Text) = 0 And Status <> "ModifyOrderData") Then
                    If MessageBox.Show("是否要記帳??", "記帳選擇", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Execute_Unpaid()
                    Else
                        MsgBox("請輸入付款金額")
                    End If
                Else
                    MsgBox("請輸入付款金額")
                End If
            End If
        ElseIf (Status = "ModifyOrderData" And CInt(PaidAmt.Text) = 0) Then
            ScrapDateTIme = DateTime.Now.ToString("yyyyMMdd") & DateTime.Now.ToString("HHmm")
            UpdateCharge("charge", ChargeNo.Text, ScrapDateTIme)
            ScrapDateTIme = ""

            '更新座號資訊
            UpdateSeatviewerData(ConvertSeatName(Seat.Text.ToString, "CTE"), "PAID", ChargeNo.Text)

            If (Status = "ModifyOrderData") Then
                '查詢點餐號碼
                CheckMealNo("Query")
            ElseIf (Status <> "ModifyOrderData") Then
                '更新並產生點餐號碼
                CheckMealNo("Add")
            End If

            '顯示此次結帳資訊
            Dim frm As New ShowPriceDetail
            frm.SourceForm = Me
            frm.ShowDialog()

            '初始化
            InitailData()
        Else
            MsgBox("結帳失敗")
        End If
    End Sub

    '執行記帳作業
    Private Sub Execute_Unpaid()
        Dim MaxChargeNo As Integer = 0
        Dim ExecuteInsertWork As Boolean = True
        Dim ChargeDateTime As String = ""
        Dim ScrapDateTIme As String = ""
        ChargeDateTime = DateTime.Now.ToString("yyyyMMdd") & DateTime.Now.ToString("HHmm")

        '取得最大收費號碼
        Try
            MaxChargeNo = getMaxChargeNo()
            ChargeNo.Text = MaxChargeNo
        Catch ex As Exception
            ExecuteInsertWork = False
        End Try

        If (ExecuteInsertWork = True) Then
            '寫入收費主檔
            InsertCharge("charge", MaxChargeNo, ChargeDateTime, NowEmployeeNo.Text, total, discount, nowpaid, change, CInt(NowPaidAmt.Text), return_amt, ScrapDateTIme, mealNo, ConvertNarrow(SpecNumber.Text), Seat.Text)
            '寫入收費明細檔
            InsertCharge("charged", MaxChargeNo, ChargeDateTime, NowEmployeeNo.Text, total, discount, nowpaid, change, CInt(NowPaidAmt.Text), return_amt, ScrapDateTIme, mealNo, ConvertNarrow(SpecNumber.Text), Seat.Text)
        End If

        '更新座號檔資訊
        UpdateSeatviewerData(ConvertSeatName(Seat.Text.ToString, "CTE"), "UNPAID", ChargeNo.Text)

        If (Status = "ModifyOrderData") Then
            '查詢點餐號碼
            CheckMealNo("Query")
        ElseIf (Status <> "ModifyOrderData") Then
            '更新並產生點餐號碼
            CheckMealNo("Add")
        End If

        '顯示此次結帳資訊
        Dim frm As New ShowPriceDetail
        frm.SourceForm = Me
        frm.ShowDialog()

        '初始化
        InitailData()
    End Sub

    '更新座號檔seatviewer資訊
    Private Sub UpdateSeatviewerData(form_seat As String, form_seat_status As String, form_charge_no As Integer)
        Try
            Dim oCmd As New SQLiteCommand("update seatviewer set seat_status = '" & form_seat_status & "', charge_no = '" & form_charge_no & "' where seat = '" & form_seat & "';", oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("更新座號檔失敗" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '轉換外面座位的代號
    'form_type: ETC (英轉中)  CTE(中轉英)
    Function ConvertSeatName(form_seat As String, form_type As String) As String
        Dim FindThisString(2) As String
        If (form_type = "ETC") Then
            FindThisString = {"R", "L", "O"}
        ElseIf (form_type = "CTE") Then
            FindThisString = {"右", "左", "外"}
        End If

        Dim isFind As Boolean = False

        For Each Str As String In FindThisString
            If (form_seat.ToString.Substring(0, 1).Contains(Str)) Then
                isFind = True
                Exit For
            End If
        Next

        If (isFind = True) Then
            If (form_type = "ETC") Then
                If (form_seat.ToString.Substring(0, 1) = "R") Then
                    Return "右" & form_seat.ToString.Substring(1, 1)
                ElseIf (form_seat.ToString.Substring(0, 1) = "L") Then
                    Return "左" & form_seat.ToString.Substring(1, 1)
                ElseIf (form_seat.ToString.Substring(0, 1) = "O") Then
                    Return "外帶"
                End If
            ElseIf (form_type = "CTE") Then
                If (form_seat.ToString.Substring(0, 1) = "右") Then
                    Return "R" & form_seat.ToString.Substring(1, 1)
                ElseIf (form_seat.ToString.Substring(0, 1) = "左") Then
                    Return "L" & form_seat.ToString.Substring(1, 1)
                ElseIf (form_seat.ToString.Substring(0, 1) = "外") Then
                    Return "O"
                End If
            End If
        End If

        Return form_seat
    End Function

    '按下結帳按鈕動作
    Private Sub Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check.Click
        Execute_Charge()
    End Sub

    '按下點餐清單中修改鈕動作
    Private Sub ShowDataView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowDataView.CellContentClick
        Mode = "Modify"

        If e.ColumnIndex = 0 Then
            If ((ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value = "Ice" Or
                 ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value = "AddTo") And
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowAddToFlag").Value = "Y") Then
                Dim frm As New Form4
                frm.SourceForm = Me
                frm.ShowDialog()
            End If
        End If

        If e.ColumnIndex = 1 Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value > 1) Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value - 1
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value * ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowPrice").Value
            ElseIf (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 1) Then
                If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value = "Ice") Then
                    '刪除畫面上資料
                    DoubleClickToDeleteData()
                Else
                    ShowDataView.Rows.RemoveAt(ShowDataView.SelectedRows(0).Index)
                End If
            End If

            Calculator()
        End If
    End Sub

    '20151004 修改品項備註必須在有點項目時才能輸入
    Private Sub ShowDataView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShowDataView.CellClick
        If (e.ColumnIndex = 10 Or e.ColumnIndex = 5) Then
            If (String.IsNullOrEmpty(ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowId").Value) And
                String.IsNullOrEmpty(ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value) And
                String.IsNullOrEmpty(ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowFullName").Value)) Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowRemark").ReadOnly = True
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").ReadOnly = True
            Else
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowRemark").ReadOnly = False
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").ReadOnly = False
            End If
        End If
    End Sub

    '更改清單中數量欄位時的動作
    Private Sub ShowDataView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowDataView.CellEndEdit
        If (e.ColumnIndex = 5 And ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowFullName").Value <> "") Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value >= 1) Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value * ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowPrice").Value
            ElseIf (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 0) Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 1
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value * ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowPrice").Value
            End If

            '計算金額並將結果顯示於畫面上
            Calculator()
        End If
    End Sub

    '按下修改訂單
    Public Sub ModifyOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyOrder.Click
        Dim frm As New Form5
        frm.SourceForm = Me
        frm.ShowDialog()

    End Sub

    '按下商品維護鈕
    Public Sub ItemMaintain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemMaintain.Click
        If (Status = "") Then
            Dim frm As New Form6
            frm.SourceForm = Me
            frm.ShowDialog()
        End If
    End Sub

    '點選員工基本資料維護
    Public Sub EmployeeMaintain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeMaintain.Click
        If (Status = "") Then
            Dim frm As New Form2
            frm.SourceForm = Me
            frm.ShowDialog()
        End If
    End Sub

    '按下重置鈕
    Public Sub Restart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restart.Click
        '初始化
        InitailData()
    End Sub

    '按下離開系統
    Private Sub CloseProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseProgram.Click
        Me.Close()
    End Sub

    Private Sub Form3_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    '按下執行補帳系統鈕
    Public Sub ExecutePosCharge_Click(sender As Object, e As EventArgs) Handles ExecutePosCharge.Click
        If (Status = "") Then
            Dim frm As New Form9
            frm.SourceForm = Me
            frm.ShowDialog()
        End If
    End Sub

    '列印出單
    Private Sub PrintOrder(ByVal form_print_type As String)
        'form_print_type: Customer表示顧客聯 Employee表示廚房內場單
        '列印否
        Dim printFood As String = "N"
        Dim printDrink As String = "N"
        For i As Integer = 0 To ShowDataView.RowCount - 2
            If (ShowDataView.Rows(i).Cells.Item("ShowType").Value <> "Drink") Then
                printFood = "Y"
            End If

            If (ShowDataView.Rows(i).Cells.Item("ShowType").Value = "Drink") Then
                printDrink = "Y"
            End If
        Next i

        If (form_print_type = "Customer") Then
            Dim PrintPreviewDialog1 As PrintPreviewDialog = New PrintPreviewDialog
            Dim PrintDocument1 As Printing.PrintDocument = New Printing.PrintDocument
            PrintPreviewDialog1.Document = PrintDocument1
            AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
            PrintDocument1.Print()
        ElseIf (form_print_type = "Employee") Then
            '內場印冰品點心其他
            If (printFood = "Y") Then
                Dim PrintPreviewDialog2 As PrintPreviewDialog = New PrintPreviewDialog
                Dim PrintDocument2 As Printing.PrintDocument = New Printing.PrintDocument
                PrintPreviewDialog2.Document = PrintDocument2
                AddHandler PrintDocument2.PrintPage, AddressOf Me.PrintDocument2_PrintPage
                PrintDocument2.Print()
            End If

            '內場印飲料
            If (printDrink = "Y") Then
                Dim PrintPreviewDialog3 As PrintPreviewDialog = New PrintPreviewDialog
                Dim PrintDocument3 As Printing.PrintDocument = New Printing.PrintDocument
                PrintPreviewDialog3.Document = PrintDocument3
                AddHandler PrintDocument3.PrintPage, AddressOf Me.PrintDocument3_PrintPage
                PrintDocument3.Print()
            End If
        End If
    End Sub

    '列印電子發票
    Private Sub QRCodePrinter()
        '產生電子發票QRCODE加密資訊
        Dim qrTotal As Integer = 0
        Dim qrNumber As String = "JL89182138"
        If (Status = "ModifyOrderData" And return_amt > 0 And nowpaid > 0) Then
            '加收
            qrTotal = CInt(ReturnAmt.Text)
        ElseIf (Not (Status = "ModifyOrderData" And TotalAmt.Text - PaidAmt.Text < 0)) Then
            '一般
            qrTotal = CInt(TotalAmt.Text)
        End If

        Sample.Main(qrNumber, qrTotal)

        '列印電子發票
        Dim PrintPreviewDialog4 As PrintPreviewDialog = New PrintPreviewDialog
        Dim PrintDocument4 As Printing.PrintDocument = New Printing.PrintDocument
        PrintPreviewDialog4.Document = PrintDocument4
        AddHandler PrintDocument4.PrintPage, AddressOf Me.PrintDocument4_PrintPage
        PrintDocument4.Print()
    End Sub

    '顧客聯資訊
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim textOfFile As String = ""
        Dim textOfOrder As String = ""
        Dim meal_no As String = ""
        Dim spec_meal_no As String = ""
        Dim PrintDateTIme As String = ""
        Dim symbol As String = "-"
        Dim endArea As String = " "
        Dim pt As Char = " "
        PrintDateTIme = DateTime.Now.ToString("yyyy-MM-dd") & "  " & DateTime.Now.ToString("H:mm")
        '抬頭資訊
        If (Status = "ModifyOrderData") Then
            textOfFile = "日  期: " & PrintDateTIme & "　(修改)" & Seat.Text.ToString.PadLeft(5, " ") & vbCrLf
        ElseIf (Status <> "ModifyOrderData") Then
            textOfFile = "日  期: " & PrintDateTIme & Seat.Text.ToString.PadLeft(5, " ") & vbCrLf
        End If

        '點餐號碼字體加大
        meal_no = MealNumber.Text

        '新增特殊號碼, 字體加大
        spec_meal_no = ConvertNarrow(SpecNumber.Text)

        textOfFile = textOfFile & "收費號: " & ChargeNo.Text & "收費員:".ToString.PadLeft(24, " ") & NowEmployeeNo.Text & vbCrLf
        textOfFile = textOfFile & "點餐號: " & vbCrLf

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(44, "-") & vbCrLf

        '點餐資訊
        For i As Integer = 0 To ShowDataView.RowCount - 2
            textOfOrder = ""
            textOfOrder = textOfOrder & CheckPrintFullName(ShowDataView.Rows(i).Cells.Item("ShowType").Value, ShowDataView.Rows(i).Cells.Item("ShowFullName").Value.ToString)
            textOfOrder = textOfOrder & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowQty").Value).ToString.PadLeft(6 - Len(ShowDataView.Rows(i).Cells.Item("ShowQty").Value.ToString), pt) & "x".PadLeft(1, pt)
            textOfOrder = textOfOrder & ShowDataView.Rows(i).Cells.Item("ShowPrice").Value.ToString.PadLeft(6 - Len(ShowDataView.Rows(i).Cells.Item("ShowPrice").Value.ToString), pt)
            textOfOrder = textOfOrder & ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value.ToString.PadLeft(10 - Len(ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value.ToString), pt) & vbCrLf
            If (Not String.IsNullOrEmpty(ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value))) Then
                textOfOrder = textOfOrder & "◎" & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value) & vbCrLf
            End If
            textOfFile = textOfFile & textOfOrder
        Next i

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(44, "-") & vbCrLf

        '付款明細
        If (discount > 0) Then
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "總計: " & (total + discount).ToString.PadLeft(10 - Len((total + discount).ToString), pt) & vbCrLf
        Else
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "總計: " & (total + discount).ToString.PadLeft(10 - Len((total + discount).ToString), pt) & vbCrLf
        End If

        If (discount > 0) Then
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "折扣: " & discount.ToString.PadLeft(10 - Len(discount.ToString), pt) & vbCrLf
        End If

        If (Status = "ModifyOrderData" And return_amt > 0 And nowpaid > 0) Then
            '此為加收情形
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "已付: " & PaidAmt.Text.ToString.PadLeft(10 - Len(PaidAmt.Text.ToString), pt) & vbCrLf
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "加收: " & return_amt.ToString.PadLeft(10 - Len(return_amt.ToString), pt) & vbCrLf
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "付款: " & ConvertNarrow(nowpaid).ToString.PadLeft(10 - Len(nowpaid.ToString), pt) & vbCrLf
            If (change > 0) Then
                textOfFile = textOfFile & endArea.PadRight(46, " ") & "找零: " & change.ToString.PadLeft(10 - Len(change.ToString), pt) & vbCrLf
            End If
        ElseIf (Status = "ModifyOrderData" And TotalAmt.Text - PaidAmt.Text < 0) Then
            '此為退款情形
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "已付: " & PaidAmt.Text.ToString.PadLeft(10 - Len(PaidAmt.Text.ToString), pt) & vbCrLf
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "退款: " & return_amt.ToString.Remove(0, 1).PadLeft(11 - Len(return_amt.ToString), pt) & vbCrLf
        ElseIf (Status <> "ModifyOrderData") Then
            '此為新增訂單情形
            textOfFile = textOfFile & endArea.PadRight(46, " ") & "付款: " & ConvertNarrow(nowpaid).ToString.PadLeft(10 - Len(nowpaid.ToString), pt) & vbCrLf
            If (change > 0) Then
                textOfFile = textOfFile & endArea.PadRight(46, " ") & "找零: " & change.ToString.PadLeft(10 - Len(change.ToString), pt) & vbCrLf
            End If
        End If

        e.Graphics.DrawString(meal_no, New Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, 55, 45, StringFormat.GenericTypographic)

        e.Graphics.DrawString(textOfFile, New Font("微軟正黑體", 12, FontStyle.Bold), Brushes.Black, 0, 5, StringFormat.GenericTypographic)

        If (spec_meal_no <> "") Then
            e.Graphics.DrawString(spec_meal_no, New Font("微軟正黑體", 13, FontStyle.Bold), Brushes.Black, 110, 48, StringFormat.GenericTypographic)
        End If
    End Sub

    '廚房內場單(非飲料)
    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim textOfFile As String = ""
        Dim textOfOrder As String = ""
        Dim PrintDateTIme As String = ""
        Dim meal_no As String = ""
        Dim spec_meal_no As String = ""
        Dim symbol As String = "-"
        Dim endArea As String = " "
        Dim pt As Char = " "

        'PrintDateTIme = DateTime.Now.ToString("yyyy-MM-dd") & " " & DateTime.Now.ToString("H:mm")
        'Start 20160727 修改內場單不印日期,只印出時間;  特殊號碼顯示範圍增大
        'PrintDateTIme = DateTime.Now.ToString("yyyy-MM-dd")
        PrintDateTIme = DateTime.Now.ToString("H:mm")
        'End   20160727 修改內場單不印日期,只印出時間;  特殊號碼顯示範圍增大

        '抬頭資訊
        If (Status = "ModifyOrderData") Then
            textOfFile = "時  間: " & PrintDateTIme & "(修改)" & Seat.Text.ToString.PadLeft(5, " ") & vbCrLf
        ElseIf (Status <> "ModifyOrderData") Then
            textOfFile = "時  間: " & PrintDateTIme & Seat.Text.ToString.PadLeft(5, " ") & vbCrLf
        End If

        '點餐號碼字體加大
        meal_no = MealNumber.Text

        '新增特殊號碼, 字體加大
        spec_meal_no = ConvertNarrow(SpecNumber.Text)

        textOfFile = textOfFile & "點餐號: " & vbCrLf

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(33, "-") & vbCrLf

        '點餐資訊
        For i As Integer = 0 To ShowDataView.RowCount - 2
            If (ShowDataView.Rows(i).Cells.Item("ShowType").Value <> "Drink") Then
                textOfOrder = ""
                textOfOrder = textOfOrder & CheckPrintFullName(ShowDataView.Rows(i).Cells.Item("ShowType").Value, ShowDataView.Rows(i).Cells.Item("ShowFullName").Value.ToString)
                textOfOrder = textOfOrder & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowQty").Value).ToString.PadLeft(8 - Len(ShowDataView.Rows(i).Cells.Item("ShowQty").Value.ToString), pt) & vbCrLf
                If (Not String.IsNullOrEmpty(ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value))) Then
                    textOfOrder = textOfOrder & "◎" & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value).ToString & vbCrLf
                End If

                textOfFile = textOfFile & textOfOrder
            End If
        Next i

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(33, "-") & vbCrLf

        e.Graphics.DrawString(meal_no, New Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, 70, 28, StringFormat.GenericTypographic)
        e.Graphics.DrawString(textOfFile, New Font("微軟正黑體", 14, FontStyle.Bold), Brushes.Black, 0, 5, StringFormat.GenericTypographic)
        If (spec_meal_no <> "") Then
            e.Graphics.DrawString(spec_meal_no, New Font("微軟正黑體", 11, FontStyle.Bold), Brushes.Black, 120, 33, StringFormat.GenericTypographic)
        End If
    End Sub

    '廚房內場單(飲料)
    Private Sub PrintDocument3_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim textOfFile As String = ""
        Dim textOfOrder As String = ""
        Dim PrintDateTIme As String = ""
        Dim meal_no As String = ""
        Dim spec_meal_no As String = ""
        Dim symbol As String = "-"
        Dim endArea As String = " "
        Dim pt As Char = " "

        'PrintDateTIme = DateTime.Now.ToString("yyyy-MM-dd") & " " & DateTime.Now.ToString("H:mm")
        'Start 20160727 修改內場單不印日期,只印出時間;  特殊號碼顯示範圍增大
        'PrintDateTIme = DateTime.Now.ToString("yyyy-MM-dd")
        PrintDateTIme = DateTime.Now.ToString("H:mm")
        'End   20160727 修改內場單不印日期,只印出時間;  特殊號碼顯示範圍增大

        '抬頭資訊
        If (Status = "ModifyOrderData") Then
            textOfFile = "時  間: " & PrintDateTIme & "(修改)" & Seat.Text.ToString.PadLeft(5, " ") & vbCrLf
        ElseIf (Status <> "ModifyOrderData") Then
            textOfFile = "時  間: " & PrintDateTIme & Seat.Text.ToString.PadLeft(5, " ") & vbCrLf
        End If

        '點餐號碼字體加大
        meal_no = MealNumber.Text

        '新增特殊號碼, 字體加大
        spec_meal_no = ConvertNarrow(SpecNumber.Text)

        textOfFile = textOfFile & "點餐號: " & vbCrLf

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(33, "-") & vbCrLf

        '點餐資訊
        For i As Integer = 0 To ShowDataView.RowCount - 2
            If (ShowDataView.Rows(i).Cells.Item("ShowType").Value = "Drink") Then
                textOfOrder = ""
                textOfOrder = textOfOrder & CheckPrintFullName(ShowDataView.Rows(i).Cells.Item("ShowType").Value, ShowDataView.Rows(i).Cells.Item("ShowFullName").Value.ToString)
                textOfOrder = textOfOrder & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowQty").Value).ToString.PadLeft(8 - Len(ShowDataView.Rows(i).Cells.Item("ShowQty").Value.ToString), pt) & vbCrLf
                If (Not String.IsNullOrEmpty(ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value))) Then
                    textOfOrder = textOfOrder & "◎" & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value).ToString & vbCrLf
                End If

                textOfFile = textOfFile & textOfOrder
            End If
        Next i

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(33, "-") & vbCrLf

        e.Graphics.DrawString(meal_no, New Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, 70, 28, StringFormat.GenericTypographic)
        e.Graphics.DrawString(textOfFile, New Font("微軟正黑體", 14, FontStyle.Bold), Brushes.Black, 0, 5, StringFormat.GenericTypographic)
        If (spec_meal_no <> "") Then
            e.Graphics.DrawString(spec_meal_no, New Font("微軟正黑體", 11, FontStyle.Bold), Brushes.Black, 120, 33, StringFormat.GenericTypographic)
        End If
    End Sub

    '列印電子發票
    Private Sub PrintDocument4_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim textTitle As String = ""
        Dim textOfFile As String = ""
        Dim textOfOrder As String = ""
        Dim printDateTitle As String = ""
        Dim PrintDateTIme As String = ""
        Dim symbol As String = "-"
        Dim endArea As String = " "
        Dim pt As Char = " "
        'e.Graphics.DrawImage(New Bitmap("D:\3415399007.jpg"), New Point(0, 0))
        Dim dtNow = DateTime.Now
        Dim twC = New System.Globalization.TaiwanCalendar()
        Dim invoiceDate As String = twC.GetYear(dtNow).ToString + dtNow.ToString("MMdd")

        '取得圖檔路徑
        'BARCODE
        Dim getBrFolder As String = "\brfile\"
        Dim getBrFileName As String = "brimage.gif"
        'QRCODE
        Dim getQrFolder As String = "\qrfile\"
        Dim getQrFileName As String = "qrimage.gif"

        Dim qrTotal As Integer = 0

        If (Status = "ModifyOrderData" And return_amt > 0 And nowpaid > 0) Then
            '加收
            qrTotal = CInt(ReturnAmt.Text)
        ElseIf (Not (Status = "ModifyOrderData" And TotalAmt.Text - PaidAmt.Text < 0)) Then
            '一般
            qrTotal = CInt(TotalAmt.Text)
        End If
        'remark
        textTitle = "散步路徑" & vbCrLf
        e.Graphics.DrawString(textTitle, New Font("微軟正黑體", 12, FontStyle.Bold), Brushes.Black, 68, 5, StringFormat.GenericTypographic)
        textOfFile = "電子發票證明聯 " & vbCrLf
        e.Graphics.DrawString(textOfFile, New Font("微軟正黑體", 15, FontStyle.Bold), Brushes.Black, 30, 27, StringFormat.GenericTypographic)
        textOfFile = "105年07-08月" & vbCrLf
        e.Graphics.DrawString(textOfFile, New Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, 30, 49, StringFormat.GenericTypographic)
        textOfFile = "JL-89182138" & vbCrLf
        e.Graphics.DrawString(textOfFile, New Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, 30, 71, StringFormat.GenericTypographic)

        PrintDateTIme = DateTime.Now.ToString("yyyy-MM-dd") & " " & DateTime.Now.ToString("H:mm:ss") & vbCrLf &
                        "隨機碼 3669           總計 $" & qrTotal & "   " & vbCrLf & "賣方00867657" & vbCrLf
        e.Graphics.DrawString(PrintDateTIme, New Font("新細明體", 9, FontStyle.Bold), Brushes.Black, 25, 95, StringFormat.GenericTypographic)
        e.Graphics.DrawImage(New Bitmap(Environment.CurrentDirectory & getBrFolder & getBrFileName), New Point(5, 125))
        e.Graphics.DrawImage(New Bitmap(Environment.CurrentDirectory & getQrFolder & getQrFileName), New Point(5, 160))
        e.Graphics.DrawImage(New Bitmap(Environment.CurrentDirectory & getQrFolder & getQrFileName), New Point(115, 160))

    End Sub

    '檢查飲料列印資料
    Function CheckPrintFullName(ByVal form_type As String, ByVal form_checkStr As String) As String
        Dim FindThisString() As String = {"全", "七", "五", "三", "一", "無"}
        Dim FindIndex As Integer = 0
        Dim StrLen As Integer = 0
        Dim ReturnStr As String = ""

        StrLen = Len(form_checkStr)

        If (form_type = "Drink") Then
            For Each Str As String In FindThisString
                If form_checkStr.Contains(Str) Then
                    FindIndex = form_checkStr.IndexOf(Str)
                    Exit For
                End If
            Next

            If (FindIndex > 4) Then
                ReturnStr = (StrConv(form_checkStr.Substring(0, 5), vbWide) &
                             StrConv(form_checkStr.Substring(FindIndex, StrLen - FindIndex), vbWide)).PadRight(10, "　")
            Else
                ReturnStr = StrConv(form_checkStr.ToString.Substring(0, StrLen).PadRight(10, "　"), vbWide)
            End If
        Else
            ReturnStr = StrConv(form_checkStr.ToString.Substring(0, StrLen).PadRight(10, "　"), vbWide)
        End If

        Return ReturnStr
    End Function

    '按下測試列印鈕
    Private Sub RePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RePrint.Click
        If MessageBox.Show("是否確定要重印單據", "重印單據", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Calculator()

            '列印顧客聯
            PrintOrder("Customer")

            '列印廚房內場單
            PrintOrder("Employee")
        End If
    End Sub

    Private Sub InitailData()
        '只有管理者有權限使用補帳系統
        'If (AdminFlag = "Y") Then
        'ExecutePosCharge.Visible = True
        'Else
        'ExecutePosCharge.Visible = False
        'End If

        IceDataView.Rows.Clear()
        DessertDataView.Rows.Clear()
        DrinkDataView.Rows.Clear()
        DrinkIceDataView.Rows.Clear()
        DrinkSugarDataView.Rows.Clear()
        OthersDataView.Rows.Clear()

        '列出冰品MENU
        QueryMenuList(IceDataView, "Ice")

        '列出點心MENU
        QueryMenuList(DessertDataView, "Dessert")

        '列出飲品MENU
        QueryMenuList(DrinkDataView, "Drink")

        '列出飲品相關項目
        'Sugar
        DrinkSugarDataView.Rows.Add(New String() {"全糖"})
        DrinkSugarDataView.Rows.Add(New String() {"七分"})
        DrinkSugarDataView.Rows.Add(New String() {"五分"})
        DrinkSugarDataView.Rows.Add(New String() {"三分"})
        DrinkSugarDataView.Rows.Add(New String() {"一分"})
        DrinkSugarDataView.Rows.Add(New String() {"無糖"})

        'Ice
        '20160818 選項變更: 冰/熱
        'DrinkIceDataView.Rows.Add(New String() {"正常"})
        'DrinkIceDataView.Rows.Add(New String() {"少冰"})
        'DrinkIceDataView.Rows.Add(New String() {"微冰"})
        'DrinkIceDataView.Rows.Add(New String() {"去冰"})
        'DrinkIceDataView.Rows.Add(New String() {"溫"})
        'DrinkIceDataView.Rows.Add(New String() {"熱"})
        DrinkIceDataView.Rows.Add(New String() {"冰"})
        DrinkIceDataView.Rows.Add(New String() {"熱"})

        '列出其它商品MENU
        QueryMenuList(OthersDataView, "Others")

        '如當日還未產生點餐號碼則初始化
        CheckMealNo("Initail")

        '初始化員工切換資料
        QueryUserList()
        ChangePassword.Clear()
        '切換使用者密碼欄位隱藏
        ChangePassword.Visible = False

        '初始金額變數及畫面欄位
        nowpaid = 0
        paid = 0
        change = 0
        discount = 0
        total = 0
        return_amt = 0
        NowPaidAmt.Text = nowpaid
        PaidAmt.Text = paid
        ChangeAmt.Text = change
        DiscountAmt.Text = discount
        TotalAmt.Text = total
        ReturnAmt.Text = return_amt
        Label7.Text = "退款"
        NowPaidAmt.Enabled = True
        SpecNumber.Text = ""
        ShowStatus.Text = ""

        '初始化新增模式/修改模式
        Mode = ""

        Status = ""

        '初始化點餐次序
        OrderSerno = 0

        '清除點餐清單
        ShowDataView.Rows.Clear()

        '清除修改狀態的收費號碼
        ChargeNo.Text = ""

        Me.Focus()
        Me.WindowState = FormWindowState.Minimized

        '直接呼叫座位表
        Dim frm As New Form_Seat
        frm.SourceForm = Me
        frm.ShowDialog()
        'frm.Close()
    End Sub

    'form_object: 傳入物件; 
    'form_type: 傳入MENU類別(對應itemsetting.type)
    '   目前共有五種類別>>> 
    '       1. Ice      : 冰品
    '       2. AddTo    : 加點
    '       3. Drink    : 飲品
    '       4. Dessert  : 點心
    '       5. Others   : 其他(建議使用者新增品項時盡量歸類於上述四種類別中)
    Private Sub QueryMenuList(ByVal form_object As Object, ByVal form_type As String)
        Try
            Dim oCmd As New SQLiteCommand("SELECT id, type, fullname, price, addto_flag FROM itemsetting WHERE type = '" & form_type & "' AND stop_flag = 'N';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                form_object.Rows.Add(New String() {oDR("id"), oDR("type"), oDR("fullname"), oDR("price"), oDR("addto_flag")})
            End While

            '檢核各分類區塊中若無資料則設定項目停止回應使用者操作
            If (form_type = "Ice") Then
                If (IceDataView.Rows.Count = 1) Then
                    IceDataView.Enabled = False
                Else
                    IceDataView.Enabled = True
                End If
            ElseIf (form_type = "Dessert") Then
                If (DessertDataView.Rows.Count = 1) Then
                    DessertDataView.Enabled = False
                Else
                    DessertDataView.Enabled = True
                End If
            ElseIf (form_type = "Drink") Then
                If (DrinkDataView.Rows.Count = 1) Then
                    DrinkIceDataView.Rows.Clear()
                    DrinkSugarDataView.Rows.Clear()
                    DrinkDataView.Enabled = False
                    DrinkIceDataView.Enabled = False
                    DrinkSugarDataView.Enabled = False
                Else
                    DrinkDataView.Enabled = True
                End If
            ElseIf (form_type = "Others") Then
                If (OthersDataView.Rows.Count = 1) Then
                    OthersDataView.Enabled = False
                Else
                    OthersDataView.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("MENU資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '查詢出員工資料(切帳號用)
    Private Sub QueryUserList()
        ChangeEmpNo.Text = ""
        ChangeEmpNo.Items.Clear()
        '切換使用者密碼欄位隱藏
        ChangePassword.Visible = False
        Try
            Dim oCmd As New SQLiteCommand("SELECT emp_no, emp_name, password FROM employee WHERE leave_flag = 'N';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                ChangeEmpNo.Items.Add(oDR("emp_no"))
            End While
        Catch ex As Exception
            MsgBox("員工資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '切換密碼欄位點一下清空
    Public Sub ChangePassword_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChangePassword.MouseClick
        ChangePassword.Clear()
    End Sub

    '切換密碼欄位按下ENTER件即執行切換使用者登入
    Public Sub ChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles ChangePassword.KeyDown
        If (e.KeyCode = 13) Then
            changeLoginSuccess = CheckLogin(ChangeEmpNo.Text, ChangePassword.Text)

            If (changeLoginSuccess = True) Then
                '登入成功時
                NowEmployeeNo.Text = nowLoginEmpNo
                NowEmployeeName.Text = nowLoginEmpName
            Else
                '登入失敗時
                QueryUserList()
                ChangePassword.Clear()
            End If

            '切換使用不論成功失敗 重置目前狀態
            InitailData()
        End If
    End Sub

    '切換帳號欄位值變更時
    Private Sub ChangeEmpNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChangeEmpNo.SelectedIndexChanged
        ChangePassword.Visible = True
        ChangePassword.Focus()
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

    '顯示已點清單
    Private Sub ShowOrderList(ByVal form_object As Object, ByVal form_type As String)
        Dim Exist As Boolean = False
        Dim DrinkMark As String = ""

        If (form_type = "Drink") Then
            'DrinkMark = DrinkSugarDataView.Rows(DrinkSugarDataView.SelectedRows(0).Index).Cells.Item("DrinkSugar").Value.ToString() & "／" &
            '           DrinkIceDataView.Rows(DrinkIceDataView.SelectedRows(0).Index).Cells.Item("DrinkIce").Value.ToString()
            DrinkMark = "／" & DrinkIceDataView.Rows(DrinkIceDataView.SelectedRows(0).Index).Cells.Item("DrinkIce").Value.ToString()
        End If

        If (form_type <> "Drink") Then
            For i As Integer = 0 To ShowDataView.RowCount - 2
                If (ShowDataView.Rows(i).Cells.Item("ShowId").Value = form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Id").Value) And
                    (String.IsNullOrEmpty(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value)) Then  '20150912 modify
                    Exist = True
                    ShowDataView.Rows(i).Cells.Item("ShowQty").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value + 1
                    ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value * form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Price").Value
                    Exit For
                End If
            Next i
        ElseIf (form_type = "Drink") Then
            For i As Integer = 0 To ShowDataView.RowCount - 2
                If ((ShowDataView.Rows(i).Cells.Item("ShowId").Value = form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Id").Value) And
                    (ShowDataView.Rows(i).Cells.Item("ShowFullName").Value = form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "FullName").Value & DrinkMark) And
                    (String.IsNullOrEmpty(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value))) Then  '20150912 modify
                    Exist = True
                    ShowDataView.Rows(i).Cells.Item("ShowQty").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value + 1
                    ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value * form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Price").Value
                    Exit For
                End If
            Next i
        End If

        If (Exist = False) Then
            OrderSerno = OrderSerno + 1
            ShowDataView.Rows.Add(New String() {"修改",
                                                "一",
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Id").Value,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Type").Value,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "FullName").Value & DrinkMark,
                                                1,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Price").Value,
                                                OrderSerno,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "Price").Value,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item(form_type & "AddToFlag").Value})
        End If

    End Sub

    'Check 點餐號碼
    Private Sub CheckMealNo(ByVal form_Status As String)
        Dim nowDate As String
        nowDate = Format(Now(), "yyyyMMdd").ToString

        mealNo = 0
        '取出下一位顧客的點餐號碼
        '   定義:
        '   now_meal_no : 目前已給點餐號
        '   next_meal_no: 新的點餐號
        Try
            Dim oCmd As New SQLiteCommand("SELECT next_meal_no FROM meal WHERE meal_date = '" & nowDate & "';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()
            oDR.Read()
            mealNo = oDR("next_meal_no")

            MealNumber.Text = mealNo
        Catch ex As Exception
            mealNo = 0
        End Try

        '初始點餐號碼(當日還未產生過則執行此段)
        If (mealNo = 0 And form_Status = "Initail") Then
            Try
                Dim oCmd As New SQLiteCommand("INSERT INTO meal (meal_date, now_meal_no, next_meal_no) VALUES ('" & nowDate & "','" & mealNo & "','" & mealNo + 1 & "');", oConn)
                oCmd.ExecuteNonQuery()
                MealNumber.Text = mealNo + 1
            Catch ex As Exception
                MsgBox("寫入餐點號碼檔失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try

            '進行結帳時更新點餐號碼檔
        ElseIf (mealNo > 0 And form_Status = "Add") Then
            Try
                Dim oCmd As New SQLiteCommand("UPDATE meal SET now_meal_no = '" & mealNo & "', next_meal_no = '" & mealNo + 1 & "' WHERE meal_date = '" & nowDate & "';", oConn)
                oCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("更新餐點號碼檔失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try

            MealNumber.Text = mealNo + 1
        End If
    End Sub

    '刪除畫面上資料
    Private Sub DoubleClickToDeleteData()
        Dim RemoveArrayList As New ArrayList
        RemoveArrayList.Clear()

        If (ShowDataView.RowCount >= 2 And ShowDataView.RowCount - 1 > ShowDataView.SelectedRows(0).Index) Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value = "Ice") Then
                For i As Integer = 0 To ShowDataView.Rows.Count - 2
                    If (ShowDataView.Rows(i).Cells.Item("AddWith").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("AddWith").Value) Then
                        RemoveArrayList.Add(i)
                    End If
                Next i
            Else
                ShowDataView.Rows.RemoveAt(ShowDataView.SelectedRows(0).Index)
            End If

            If (RemoveArrayList.Count > 0) Then
                For i As Integer = 0 To RemoveArrayList.Count - 1
                    ShowDataView.Rows.RemoveAt(RemoveArrayList.Item(0))
                Next i
            End If

            '計算金額並將結果顯示於畫面上
            Calculator()
        End If
    End Sub

    '計算金額並顯示於畫面上
    Private Sub Calculator()
        'Step1. 檢查付款、折扣是否已經輸入? 若未輸入則預設給0
        'Step2. 檢查已付是否有值? 若未輸入則預設給0
        'Step3. 檢查找零是否已經產生? 若未產生則預設給0
        'Step4. 計算金額並將結果顯示於畫面上

        If (NowPaidAmt.Text.Length = 0) Then
            NowPaidAmt.Text = 0
        End If

        If (DiscountAmt.Text.Length = 0) Then
            DiscountAmt.Text = 0
        End If

        If (PaidAmt.Text.Length = 0) Then
            PaidAmt.Text = 0
        End If

        If (ChangeAmt.Text.Length = 0) Then
            ChangeAmt.Text = 0
        End If

        If (ReturnAmt.Text.Length = 0) Then
            ReturnAmt.Text = 0
        End If

        '初始化總金額, 並全部重算
        total = 0
        For i As Integer = 0 To ShowDataView.RowCount - 2
            total = total + ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value
        Next i

        '付款金額
        nowpaid = CInt(NowPaidAmt.Text)
        '已付金額
        paid = CInt(PaidAmt.Text)
        '折扣金額
        discount = CInt(DiscountAmt.Text)
        '找零金額
        change = CInt(ChangeAmt.Text)
        '退款/加收金額
        return_amt = CInt(ReturnAmt.Text)

        If (discount > 0) Then
            total = total - discount
        End If

        TotalAmt.Text = total

        If (Status = "ModifyOrderData") Then
            paid = PaidAmt.Text


            If (total - paid < -paid And discount > 0) Then
                total = 0
                TotalAmt.Text = total
                return_amt = total - paid
            Else
                return_amt = total - paid
            End If


            '判斷退款金額是否已經超過已付金額, 若超過且是折扣情況下, 退款金額應要等於已付金額
            '並加以判斷目前的總金額是否已經小於0, 若是, 則總金額應要為0

            '定義已付paid = 0 表示記帳狀態 (當時一毛錢都沒付) 故不需要有加收退款金額顯示
            '反之則跑原本修改訂單流程
            If (paid = 0) Then
                return_amt = 0
                ReturnAmt.Text = return_amt
                change = nowpaid - total
                ChangeAmt.Text = change
                paid = nowpaid - change
            Else
                ReturnAmt.Text = return_amt

                change = nowpaid - return_amt
                ChangeAmt.Text = change
                paid = total
            End If
        Else
            change = nowpaid - total
            ChangeAmt.Text = change
            paid = nowpaid - change
        End If

        '控管如果退款金額小於0(負數)則將付款欄位設定不可修改
        If (return_amt < 0) Then
            change = 0
            ChangeAmt.Text = change
            NowPaidAmt.Enabled = False
            Label7.Text = "退款"
        Else
            NowPaidAmt.Enabled = True
            Label7.Text = "加收"
        End If
    End Sub

    '寫入收費主檔 / 收費明細檔
    Private Sub InsertCharge(ByVal form_TableName As String, ByVal form_ChargeNo As Integer, ByVal form_DateTime As String, ByVal form_CheckUser As String,
                             ByVal form_TotalAmt As Integer, ByVal form_DiscountAmt As Integer, ByVal form_NowPaidAmt As Integer, ByVal form_ChangeAmt As Integer,
                             ByVal form_PaidAmt As Integer, ByVal form_ReturnAmt As Integer, ByVal form_ScrapDate As String, ByVal form_MealNo As Integer, ByVal form_Spec_Meal_No As String,
                             ByVal form_seat As String)

        If (form_TableName = "charge") Then
            '還原未折扣前的總價寫入主檔紀錄
            If (form_DiscountAmt > 0 And form_TotalAmt <> 0) Then
                form_TotalAmt = form_TotalAmt + form_DiscountAmt
            End If

            Try
                Dim oCmd As New SQLiteCommand("INSERT INTO charge (charge_no, charge_datetime, charge_clerk, total_amt, discount_amt, paid_amt, return_amt, scrap_datetime, meal_no, spec_meal_no, seat, customer_amt) VALUES ('" & form_ChargeNo & "','" & form_DateTime & "','" & form_CheckUser & "','" & form_TotalAmt & "','" & form_DiscountAmt & "','" & form_PaidAmt & "','" & form_ReturnAmt & "','" & form_ScrapDate & "','" & form_MealNo & "','" & form_Spec_Meal_No.ToString & "','" & form_seat & "','" & form_NowPaidAmt & "');", oConn)
                oCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("寫入收費主檔失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try
        ElseIf (form_TableName = "charged") Then
            For i As Integer = 0 To ShowDataView.Rows.Count - 2
                Try
                    Dim oCmd As New SQLiteCommand("INSERT INTO charged (charge_no, id, type, fullname, qty, price, subtotal, addwith, new_add, remark, charge_datetime) VALUES ('" & form_ChargeNo & "','" & ShowDataView.Rows(i).Cells.Item("ShowId").Value & "','" & ShowDataView.Rows(i).Cells.Item("ShowType").Value & "','" & ShowDataView.Rows(i).Cells.Item("ShowFullName").Value & "','" & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowQty").Value) & "','" & ShowDataView.Rows(i).Cells.Item("ShowPrice").Value & "','" & ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value & "','" & ShowDataView.Rows(i).Cells.Item("AddWith").Value & "','" & "Y" & "','" & ConvertNarrow(ShowDataView.Rows(i).Cells.Item("ShowRemark").Value) & "','" & form_DateTime & "');", oConn)
                    oCmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("寫入收費明細檔失敗" & vbCrLf & ex.GetBaseException.ToString)
                End Try
            Next i

        End If
    End Sub

    '刪除收費主檔 / 收費明細檔
    Private Sub UpdateCharge(ByVal form_TableName As String, ByVal form_ChargeNo As Integer, ByVal form_ScrapDate As String)
        If (form_TableName = "charge") Then
            Try
                Dim oCmd As New SQLiteCommand("update charge set scrap_datetime = '" & form_ScrapDate & "' where charge_no = '" & form_ChargeNo & "';", oConn)
                oCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("更新收費主檔作廢日期失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try
        End If
    End Sub

    '全形轉半形
    Function ConvertNarrow(ByVal form_str As String) As String
        Dim StrNarrow As String = ""

        StrNarrow = StrConv(form_str, vbNarrow)

        Return StrNarrow
    End Function

    Private Sub SpecNumber_MouseClick_1(sender As Object, e As MouseEventArgs) Handles SpecNumber.MouseClick
        If (String.IsNullOrEmpty(SpecNumber.Text.ToString) Or SpecNumber.Text.ToString = "NULL") Then
            SpecNumber.Clear()
        End If
    End Sub

    Private Sub SpecNumber_Leave_1(sender As Object, e As EventArgs) Handles SpecNumber.Leave
        If (String.IsNullOrEmpty(SpecNumber.Text)) Then
            SpecNumber.Text = "NULL"
        End If
    End Sub

End Class
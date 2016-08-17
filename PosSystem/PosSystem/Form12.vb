Imports System.Data.SQLite
Public Class Form_Seat
    Public Property SourceForm As Form3

    Private Sub SetMdiBackColor()
        Me.Controls(Me.Controls.Count - 1).BackColor = Me.BackColor
    End Sub

    ' 覆寫 WndProc 進行視窗訊息處理
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND = &H112
        Const SC_CLOSE = &HF060 ' 關閉
        Const SC_MIN = &HF020 ' 最小化
        ' Const SC_MAX = &HF030 ' 最大化
        If m.Msg = WM_SYSCOMMAND Then
            If m.WParam = SC_CLOSE Then
                ' =============== 你要做的事情 ==================
                AddHandler CloseProgram.Click, AddressOf CloseProgram_Click
                ' =============== 你要做的事情 ==================
                Return
            ElseIf m.WParam = SC_MIN Then
                SourceForm.WindowState = FormWindowState.Minimized
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    '重要: 取得當前被控制的按鈕元件NAME
    Dim nowClickButton As String = ""

    '換位子時需要之陣列 (只存放兩個桌位..兩筆資料)
    Dim choiceSeatAL As New ArrayList

    '記錄整間店目前有哪些座位
    Dim SeatRecord As New ArrayList

    '紀錄charge / charged的資訊
    Public ChargeDataAL As New ArrayList()
    Public ChargedDataAL As New ArrayList()
    Public GetNowDoStatus As String = ""

    '初始化自動生成按鈕位置(for 快速登入功能)
    Public createBtnXLocation As Integer = 185
    Public createBtnYLocation As Integer = 365

    '快速登入必須考量到admin權限的判斷,建立一個map存放
    Dim dictionary As New Dictionary(Of String, String)

    Private Sub Form_Seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '取得變更背景控制權
        SetMdiBackColor()

        '開啟資料庫(暫時 到時需拿掉)
        'oConn.Open()

        '取得座位狀態(於charge中依據seat_status IN ('PAID' , UNPAID''))
        '已付及記帳還在店內故依此為判斷顯示狀態變更按鈕顏色(紅色:記帳; 藍色:已付; 橘色:空位)
        GetSeatViewer()

        '只有管理者權限功能控制
        adminSystemControl()

        '初始化切換帳號資訊
        ChangeEmpNo.Text = ""
        ChangeEmpNo.Items.Clear()
        QueryUserList()

        '初始化當前狀態
        GetNowDoStatus = ""

        '初始化換位子陣列資料
        choiceSeatAL.Clear()

        '取得登入者資訊
        NowEmployeeNo.Text = SourceForm.NowEmployeeNo.Text
        NowEmployeeName.Text = SourceForm.NowEmployeeName.Text

        'A區座位
        AddHandler A1.MouseClick, AddressOf EnterOrder_Click
        'AddHandler A1.MouseUp, AddressOf myButton_mouse
        AddHandler A2.MouseClick, AddressOf EnterOrder_Click
        'AddHandler A2.MouseUp, AddressOf myButton_mouse
        AddHandler A3.MouseClick, AddressOf EnterOrder_Click
        'AddHandler A3.MouseUp, AddressOf myButton_mouse
        AddHandler A4.MouseClick, AddressOf EnterOrder_Click
        'AddHandler A4.MouseUp, AddressOf myButton_mouse
        AddHandler A5.MouseClick, AddressOf EnterOrder_Click
        'AddHandler A5.MouseUp, AddressOf myButton_mouse
        'B區座位
        AddHandler B1.MouseClick, AddressOf EnterOrder_Click
        'AddHandler B1.MouseUp, AddressOf myButton_mouse
        AddHandler B2.MouseClick, AddressOf EnterOrder_Click
        'AddHandler B2.MouseUp, AddressOf myButton_mouse
        'C區座位
        AddHandler C1.MouseClick, AddressOf EnterOrder_Click
        'AddHandler C1.MouseUp, AddressOf myButton_mouse
        AddHandler C2.MouseClick, AddressOf EnterOrder_Click
        'AddHandler C2.MouseUp, AddressOf myButton_mouse
        AddHandler C3.MouseClick, AddressOf EnterOrder_Click
        'AddHandler C3.MouseUp, AddressOf myButton_mouse
        'R區座位
        AddHandler R1.MouseClick, AddressOf EnterOrder_Click
        'AddHandler R1.MouseUp, AddressOf myButton_mouse
        AddHandler R2.MouseClick, AddressOf EnterOrder_Click
        'AddHandler R2.MouseUp, AddressOf myButton_mouse
        AddHandler R3.MouseClick, AddressOf EnterOrder_Click
        'AddHandler R3.MouseUp, AddressOf myButton_mouse
        'L區座位
        AddHandler L1.MouseClick, AddressOf EnterOrder_Click
        'AddHandler L1.MouseUp, AddressOf myButton_mouse
        AddHandler L2.MouseClick, AddressOf EnterOrder_Click
        'AddHandler L2.MouseUp, AddressOf myButton_mouse
        AddHandler L3.MouseClick, AddressOf EnterOrder_Click
        'AddHandler L3.MouseUp, AddressOf myButton_mouse
        '外帶
        AddHandler O.MouseClick, AddressOf EnterOrder_Click
        'AddHandler O.MouseUp, AddressOf myButton_mouse

        '連結點餐主畫面中的相關按鈕功能
        AddHandler ModifyOrder.MouseClick, AddressOf SourceForm.ModifyOrder_Click
        AddHandler ItemMaintain.MouseClick, AddressOf SourceForm.ItemMaintain_Click
        AddHandler EmployeeMaintain.MouseClick, AddressOf SourceForm.EmployeeMaintain_Click
        AddHandler ExecutePosCharge.MouseClick, AddressOf SourceForm.ExecutePosCharge_Click

        '取得最新快速登入使用者
        quickLogin()

    End Sub

    '管理者系統權限控制
    Public Sub adminSystemControl()
        '只有管理者有權限使用補帳系統
        If (AdminFlag = "Y") Then
            ExecutePosCharge.Visible = True
        Else
            ExecutePosCharge.Visible = False
        End If
    End Sub

    '取得最新快速登入使用者
    Public Sub quickLogin()
        Dim LoginDate = DateTime.Now.ToString("yyyyMMdd")
        Dim LoginTime = DateTime.Now.ToString("HHmm")
        '加入自動生成按鈕並包含事件
        Dim xPosition = createBtnXLocation
        Dim yPosition = createBtnYLocation
        '取得登入歷史紀錄
        Dim loginData As New ArrayList
        Dim loginDataCount As Integer = 0
        loginData = CheckOrQueryLoginHistory(LoginDate, "", "Y", True)
        loginDataCount = loginData.Count
        '若當日登入者超過六位,快速登入按鈕列最多顯示六位
        If (loginDataCount > 6) Then
            loginDataCount = 6
        End If
        'MsgBox("[loginData All count] " & loginData.Count)

        '清空權限清單,以便寫入最新的已登入者權限資訊
        dictionary.Clear()

        For i As Integer = 1 To loginDataCount
            Dim index As Integer = i - 1
            Dim resultArray(7) As String
            Dim resultEmpNo As String = ""
            Dim resultEmpName As String = ""
            Dim resultAdminFlag As String = ""

            '取得當日登入者清單
            resultArray = loginData(index)
            'MsgBox("[resultArray] " + resultArray(2))

            '登入者清單資訊(目前只取 [登入ID] [登入姓名]
            resultEmpNo = resultArray(1)
            resultEmpName = resultArray(2)
            resultAdminFlag = resultArray(3)

            '寫入權限清單
            dictionary.Add(resultEmpNo, resultAdminFlag)

            If (i = 4) Then
                xPosition = createBtnXLocation
                yPosition += 60
            ElseIf (i <> 1) Then
                xPosition += 65
            End If

            '產生登入者按鈕
            CreateBtnAttribute(resultEmpNo, resultEmpName, xPosition, yPosition)
        Next i
    End Sub

    '自動生成按鈕-按鈕屬性設定
    Private Sub CreateBtnAttribute(btnName As String, btnText As String, xPosition As Integer, yPosition As Integer)
        Dim btnxxx As New Button
        btnxxx.Name = btnName
        btnxxx.Text = btnText
        btnxxx.Size = New Size(60, 55)
        btnxxx.Location = New Point(xPosition, yPosition)
        btnxxx.TextAlign = ContentAlignment.MiddleCenter
        btnxxx.BackColor = SystemColors.HighlightText
        btnxxx.ForeColor = SystemColors.ControlText
        btnxxx.FlatStyle = FlatStyle.Flat
        btnxxx.FlatAppearance.BorderColor = Color.Black
        btnxxx.FlatAppearance.BorderSize = 3
        btnxxx.Font = New Font(btnxxx.Font, FontStyle.Bold)
        Me.Controls.Add(btnxxx)
        Me.BringToFront()
        AddHandler btnxxx.Click, AddressOf btnMove_click
    End Sub

    '自動生成按鈕-綁定事件 進行快速登入作業(當日已有登入紀錄不需做登入檢核 直接替換當前操作人員ID及名稱)
    Private Sub btnMove_click(ByVal sender As Object, ByVal e As System.EventArgs)
        '取得ID
        Dim btnName = CType(sender, Button).Name
        '取得名稱
        Dim btnText = CType(sender, Button).Text
        '取得使用者權限
        Dim adminListValue = ""

        nowLoginEmpNo = btnName
        nowLoginEmpName = btnText

        NowEmployeeNo.Text = nowLoginEmpNo
        NowEmployeeName.Text = nowLoginEmpName
        SourceForm.NowEmployeeNo.Text = nowLoginEmpNo
        SourceForm.NowEmployeeName.Text = nowLoginEmpName

        '取出目前快速登入使用者的權限
        dictionary.TryGetValue(btnName, adminListValue)

        If (String.IsNullOrEmpty(adminListValue) = False) Then
            AdminFlag = adminListValue
        End If

        '管理員系統權限判斷
        adminSystemControl()

    End Sub

    '取得座位狀態(於seatviewer中依據seat取得 seat_status (CLEAR  UNPAID  PAID)
    '已付及記帳還在店內故依此為判斷顯示狀態變更按鈕顏色(紅色:記帳; 藍色:已付; 橘色:空位)
    Private Sub GetSeatViewer()
        SeatRecord.Clear()

        Try
            Dim oCmd As New SQLiteCommand("SELECT seat, seat_status, charge_no FROM seatviewer;", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                GetSeatStaus(ConvertSeatName(oDR("seat"), "CTE"), oDR("seat_status"))
                SeatRecord.Add(oDR("seat"))
            End While
        Catch ex As Exception
            MsgBox("座位資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '執行相關動作需取得seat資訊請用此方法
    'form_how: 用途為?  兩種狀態: 1.GET:取得此座位資訊  2.LIST:取得全部座位並列出清單
    Function CheckSeatViewerData(form_seat As String, form_how As String) As ArrayList
        Dim sqlstm As String = ""
        Dim myAL As New ArrayList()
        myAL.Clear()

        Try
            If (form_how = "GET") Then
                sqlstm = "SELECT seat, seat_status, charge_no FROM seatviewer WHERE seat = '" & form_seat & "';"
            ElseIf (form_how = "LIST") Then
                '列出全部座位時要排除自己本身控制項目的座位號碼
                sqlstm = "SELECT seat FROM seatviewer WHERE seat <> '" & form_seat & "';"
            End If

            Dim oCmd As New SQLiteCommand(sqlstm, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            If (form_how = "GET") Then
                While oDR.Read()
                    myAL.Add(oDR("seat"))
                    myAL.Add(oDR("seat_status"))
                    myAL.Add(oDR("charge_no"))
                End While
            ElseIf (form_how = "LIST") Then
                While oDR.Read()
                    myAL.Add(oDR("seat"))
                End While
            End If
        Catch ex As Exception
            MsgBox("確認座位資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try

        Return myAL
    End Function

    '取得目前座位狀態(依據顏色轉換出 seat_status -> UNPAID:記帳 ; PAID:已付 ; CLEAR:空位)
    '用於需依據狀態做不同動作時的方法
    Private Sub GetSeatStaus(form_seat As Object, form_status As String)
        'If (form_status = "CLEAR") Then
        'Me.Controls(form_seat).BackColor = BackColor
        If (form_status = "UNPAID") Then
            Me.Controls(form_seat).BackColor = Color.Crimson
        Else
            Me.Controls(form_seat).BackColor = SystemColors.HighlightText

            'ElseIf (form_status = "PAID") Then
            'Me.Controls(form_seat).BackColor = Color.DodgerBlue
        End If
    End Sub

    '統一方法: 用於按鈕按下後依據所選擇不同動作進行作業 (點餐/結帳 ; 換位子 ; 清桌)
    Private Sub ExecuteAction(form_action As String, form_click_button As String, form_change_seat As String)
        If (form_action = "EnterOrder") Then
            '進行點餐/結帳確認
            EnterOrderCheck()
            SourceForm.Seat.Text = ConvertSeatName(form_click_button, "ETC")
            SourceForm.Focus()
            SourceForm.WindowState = FormWindowState.Maximized
            Hide()
        ElseIf (form_action = "ChangeSeat") Then
            '進行換桌確認
            ChangeSeatCheck(form_click_button, form_change_seat)
            '重新取得座位狀態
            GetSeatViewer()
        ElseIf (form_action = "ChangeSeatNew") Then
            ChangeSeatCheckNew()
        ElseIf (form_action = "ClearSeat") Then
            '進行清桌確認
            ClearSeatCheck()
            '重新取得座位狀態
            GetSeatViewer()
        End If
    End Sub

    '執行點餐/結帳確認
    Private Sub EnterOrderCheck()
        Dim enterOrderAL1 As New ArrayList

        enterOrderAL1 = CheckSeatViewerData(nowClickButton, "GET")

        If (enterOrderAL1(1) = "UNPAID" And enterOrderAL1(2) > 0) Then
            Try
                GetChargeData(enterOrderAL1(2))
            Catch ex As Exception
                MsgBox("點餐/結帳確認失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try
        End If

    End Sub

    '執行換桌確認新版本
    'choiceSeatAL(0):起始桌   choiceSeatAL(1):對象桌
    Private Sub ChangeSeatCheckNew()
        Dim origSeatAL1 As New ArrayList
        Dim changeSeatAL1 As New ArrayList
        Try
            If MessageBox.Show("是否確認換桌??", "換桌確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                origSeatAL1 = CheckSeatViewerData(choiceSeatAL(0).ToString, "GET")
                changeSeatAL1 = CheckSeatViewerData(choiceSeatAL(1).ToString, "GET")

                '將對象桌位的狀態、收費號資訊更新為原本桌位的
                UpdateSeatviewerData(choiceSeatAL(1).ToString, origSeatAL1(1), origSeatAL1(2))
                '更新帳款主檔座位號(將原本單號的座位更改成改變之後的座位號)
                UpdateChargeSeatData(ConvertSeatName(choiceSeatAL(1).ToString, "ETC"), ConvertSeatName(origSeatAL1(2), "ETC"))

                '將原本桌位的狀態、收費號資訊更新為對象桌位的
                UpdateSeatviewerData(choiceSeatAL(0).ToString, changeSeatAL1(1), changeSeatAL1(2))
                '更新帳款主檔座位號(將對象單號的座位更改成改變之後的座位號)
                UpdateChargeSeatData(ConvertSeatName(choiceSeatAL(0).ToString, "ETC"), ConvertSeatName(changeSeatAL1(2), "ETC"))
            End If
            nowClickButton = ""
            GetNowDoStatus = ""
            ChangeSeatEffectSetting(GetNowDoStatus, nowClickButton)
            GetSeatViewer()
        Catch ex As Exception
            nowClickButton = ""
            GetNowDoStatus = ""
            ChangeSeatEffectSetting(GetNowDoStatus, nowClickButton)
            GetSeatViewer()
            MsgBox("換桌失敗" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '換桌狀態下畫面特效
    Private Sub ChangeSeatEffectSetting(form_status As String, form_seat As Object)
        Dim tmpButton As Object

        If (form_status = "DoChangeSeat") Then
            Me.BackColor = Color.SkyBlue
            For i As Integer = 0 To SeatRecord.Count - 1
                If (form_seat.ToString = SeatRecord(i)) Then
                    Me.Controls(form_seat).BackColor = Color.Salmon
                End If
            Next i
        Else
            '清除換位資訊及初始化所有按鈕的背景色
            choiceSeatAL.Clear()
            Me.BackColor = SystemColors.ControlLightLight
            For i As Integer = 0 To SeatRecord.Count - 1
                tmpButton = ConvertSeatName(SeatRecord(i), "CTE")
                Me.Controls(tmpButton).BackColor = SystemColors.HighlightText
            Next i
        End If

        '取得變更背景控制權
        SetMdiBackColor()
    End Sub

    '執行換桌確認
    Private Sub ChangeSeatCheck(form_orig_seat As String, form_change_seat As String)
        Dim origSeatAL1 As New ArrayList
        Dim changeSeatAL1 As New ArrayList

        origSeatAL1 = CheckSeatViewerData(form_orig_seat, "GET")
        changeSeatAL1 = CheckSeatViewerData(form_change_seat, "GET")

        '將對象桌位的狀態、收費號資訊更新為原本桌位的
        UpdateSeatviewerData(form_change_seat, origSeatAL1(1), origSeatAL1(2))
        '更新帳款主檔座位號(將原本單號的座位更改成改變之後的座位號)
        UpdateChargeSeatData(form_change_seat, origSeatAL1(2))

        '將原本桌位的狀態、收費號資訊更新為對象桌位的
        UpdateSeatviewerData(form_orig_seat, changeSeatAL1(1), changeSeatAL1(2))
        '更新帳款主檔座位號(將對象單號的座位更改成改變之後的座位號)
        UpdateChargeSeatData(form_orig_seat, changeSeatAL1(2))
    End Sub

    '執行清桌確認
    Private Sub ClearSeatCheck()
        Dim clearSeatAL1 As New ArrayList

        clearSeatAL1 = CheckSeatViewerData(nowClickButton, "GET")
        '將指定桌位的狀態設定為CLEAR 收費號設定為0 (注意:未付清不得清桌)
        If (clearSeatAL1(1) = "UNPAID") Then
            MsgBox("此桌位還沒有結帳不能清桌")
        Else
            UpdateSeatviewerData(nowClickButton, "CLEAR", 0)
        End If
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

    '更新帳款主檔seat資訊(如果有的話)
    Private Sub UpdateChargeSeatData(form_seat As String, form_charge_no As Integer)
        If (form_charge_no <> 0) Then
            Try
                Dim oCmd As New SQLiteCommand("update charge set seat = '" & form_seat & "' where charge_no = '" & form_charge_no & "';", oConn)
                oCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("更新帳款主檔座號失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try
        End If

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

    'ChargeDataAL :
    '  『0』: charge_no  『1』: charge_datetime  『2』: charge_clerk   『3』: total_amt  『4』: discount_amt  
    '  『5』: paid_amt   『6』: return_amt       『7』: meal_no        『8』: remark     『9』: spec_meal_no 
    'ChargedDataAL : 
    '  『0』: id       『1』: Type       『2』: fullname    『3』: qty         『4』: price  
    '  『5』: addwith  『6』: subtotal   『7』: addto_flag  『8』: remark     
    Private Sub GetChargeData(form_charge_no As Integer)
        '清除charge/charged暫存資料以便重新取得
        If ChargeDataAL.Count > 0 Then
            ChargeDataAL.Clear()
        End If
        If ChargedDataAL.Count > 0 Then
            ChargedDataAL.Clear()
        End If

        Try
            Dim oCmd As New SQLiteCommand("SELECT charge_no, charge_datetime, charge_clerk, total_amt, discount_amt, paid_amt, return_amt, meal_no, remark, spec_meal_no FROM charge WHERE charge_no = '" & form_charge_no & "' AND scrap_datetime = '" & "" & "'ORDER BY meal_no;", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                ChargeDataAL.Add(oDR("charge_no"))
                ChargeDataAL.Add(oDR("charge_datetime"))
                ChargeDataAL.Add(oDR("charge_clerk"))
                ChargeDataAL.Add(oDR("total_amt"))
                ChargeDataAL.Add(oDR("discount_amt"))
                ChargeDataAL.Add(oDR("paid_amt"))
                ChargeDataAL.Add(oDR("return_amt"))
                ChargeDataAL.Add(oDR("meal_no"))
                ChargeDataAL.Add(oDR("remark"))
                ChargeDataAL.Add(oDR("spec_meal_no"))
            End While
        Catch ex As Exception
            MsgBox("收費資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try

        SourceForm.Status = "ModifyOrderData"
        SourceForm.ShowDataView.Rows.Clear()
        SourceForm.MealNumber.Clear()
        SourceForm.ChargeNo.Clear()

        '查詢出明細並且放到點餐畫面的欄位中
        Try
            Dim oCmd As New SQLiteCommand("SELECT id, type, fullname, qty, price, addwith, subtotal, (SELECT addto_flag FROM itemsetting WHERE id = charged.id) addto_flag, remark FROM charged WHERE charge_no = '" & form_charge_no & "';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                ChargedDataAL.Add(oDR("id"))
                ChargedDataAL.Add(oDR("type"))
                ChargedDataAL.Add(oDR("fullname"))
                ChargedDataAL.Add(oDR("qty"))
                ChargedDataAL.Add(oDR("price"))
                ChargedDataAL.Add(oDR("addwith"))
                ChargedDataAL.Add(oDR("subtotal"))
                ChargedDataAL.Add(oDR("addto_flag"))
                ChargedDataAL.Add(oDR("remark"))
                SourceForm.ShowDataView.Rows.Add(New String() {"修改", "一", oDR("id"), oDR("type"), oDR("fullname"), oDR("qty"), oDR("price"), oDR("addwith"), oDR("subtotal"), oDR("addto_flag"), oDR("remark")})
            End While
        Catch ex As Exception
            MsgBox("收費明細查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try

        SourceForm.MealNumber.Text = ChargeDataAL(7)
        SourceForm.SpecNumber.Text = ChargeDataAL(9)
        SourceForm.ChargeNo.Text = ChargeDataAL(0)
        SourceForm.ShowStatus.Text = "修改中"

        Calculator()
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
        '建立一個虛擬的fake_paid (只用於記帳) 用來假定有已付金額(因為原本計算加收/退款機制是依照總金額-已付)
        Dim fake_paid As Integer = 0

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
        total = ChargeDataAL(3)
        '付款金額
        nowpaid = CInt(SourceForm.NowPaidAmt.Text)
        '已付金額
        paid = ChargeDataAL(5)
        '折扣金額
        discount = ChargeDataAL(4)
        '找零金額
        change = CInt(SourceForm.ChangeAmt.Text)
        '退款/加收金額
        return_amt = CInt(SourceForm.ReturnAmt.Text)

        '建立一個虛擬的fake_paid (只用於記帳) 用來假定有已付金額(因為原本計算加收/退款機制是依照總金額-已付)
        '其金額就維持抓取charge.total (假裝這個已付金額已經付清了)
        fake_paid = ChargeDataAL(3)

        If (discount > 0) Then
            total = total - discount
        End If

        SourceForm.TotalAmt.Text = total
        SourceForm.PaidAmt.Text = paid
        SourceForm.DiscountAmt.Text = discount

        '定義已付paid = 0 表示記帳狀態 (當時一毛錢都沒付)
        If (paid = 0) Then
            SourceForm.ReturnAmt.Text = total - fake_paid
        Else
            SourceForm.ReturnAmt.Text = total - paid
        End If

        SourceForm.ChangeAmt.Text = 0

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

    '點餐/結帳 傳入參數 EnterOrder
    Private Sub EnterOrder_Click(sender As Object, e As EventArgs) Handles EnterOrder.Click
        'nowClickButton = CType(sender, Button).Text
        nowClickButton = CType(sender, Button).Name

        '當狀態不是換位子狀態時才可以進行點入點餐結帳動作
        If (GetNowDoStatus = "") Then
            ExecuteAction("EnterOrder", nowClickButton, "")
        ElseIf (GetNowDoStatus = "DoChangeSeat" And nowClickButton.ToString <> "O") Then
            Dim canDo As Boolean = True

            If (choiceSeatAL.Count = 1) Then
                For i As Integer = 0 To choiceSeatAL.Count - 1
                    If (choiceSeatAL(i).ToString = nowClickButton.ToString) Then
                        canDo = False
                        Exit For
                    End If
                Next i
            End If

            If (canDo = True) Then
                ChangeSeatEffectSetting(GetNowDoStatus, nowClickButton)

                If (choiceSeatAL.Count < 3) Then
                    choiceSeatAL.Add(nowClickButton)
                End If

                If (choiceSeatAL.Count = 2) Then
                    ExecuteAction("ChangeSeatNew", nowClickButton, ChangeSeat.Text)
                End If
            End If
        End If
    End Sub

    '滑鼠離開換座位選項時列出座位選項
    Private Sub ChangeSeat_Leave(sender As Object, e As EventArgs) Handles ChangeSeat.Leave
        ChangeSeat.DroppedDown = False

    End Sub

    '滑鼠移到換座位選項時列出座位選項
    Private Sub ChangeSeat_MouseEnter(sender As Object, e As EventArgs) Handles ChangeSeat.MouseEnter
        Dim changeSeatListAL1 As New ArrayList
        ChangeSeat.Text = ""
        ChangeSeat.Items.Clear()
        '取得座位LIST清單
        changeSeatListAL1 = CheckSeatViewerData(nowClickButton, "LIST")
        '將LIST清單顯示於ChangeSeatList下拉清單中
        For i As Integer = 0 To changeSeatListAL1.Count - 1
            ChangeSeat.Items.Add(changeSeatListAL1(i))
        Next i

        ChangeSeat.DroppedDown = True

    End Sub

    '選擇要換到的位子
    Private Sub ChangeSeat_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ChangeSeat.SelectedIndexChanged
        ExecuteAction("ChangeSeat", nowClickButton, ChangeSeat.Text)
        ContextMenuStrip1.Close()
    End Sub

    '當滑鼠按下右鍵時立即取得觸發是從哪個按鈕
    Private Sub myButton_mouse(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            nowClickButton = CType(sender, Button).Name
        End If
    End Sub

    '離開系統
    Private Sub CloseProgram_Click(sender As Object, e As EventArgs) Handles CloseProgram.Click
        '先關閉結帳系統表單
        SourceForm.Close()
        '接著再關閉座位表
        Me.Close()
    End Sub

    '按下連結修改訂單鈕
    Private Sub ModifyOrder_Click(sender As Object, e As EventArgs) Handles ModifyOrder.Click
        Me.Hide()
    End Sub

    '按下連結商品維護鈕
    Private Sub ItemMaintain_Click(sender As Object, e As EventArgs) Handles ItemMaintain.Click
        Me.Hide()
    End Sub

    '按下連結員工基本資料維護鈕
    Private Sub EmployeeMaintain_Click(sender As Object, e As EventArgs) Handles EmployeeMaintain.Click
        Me.Hide()
    End Sub

    '按下連結補帳系統鈕
    Private Sub ExecutePosCharge_Click(sender As Object, e As EventArgs) Handles ExecutePosCharge.Click
        Me.Hide()
    End Sub

    '選擇登入帳號
    Private Sub ChangeEmpNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChangeEmpNo.SelectedIndexChanged
        ChangePassword.Visible = True
        ChangePassword.Focus()
    End Sub

    '當滑鼠移至切換使用者帳號時
    Private Sub ChangeEmpNo_MouseEnter(sender As Object, e As EventArgs) Handles ChangeEmpNo.MouseEnter
        'ChangeEmpNo.DroppedDown = True
    End Sub

    '當輸入完切換密碼按下ENTER鍵
    Private Sub ChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles ChangePassword.KeyDown
        If (e.KeyCode = 13) Then
            Dim changeLoginSuccess As Boolean = False
            changeLoginSuccess = CheckLogin(ChangeEmpNo.Text, ChangePassword.Text)

            If (changeLoginSuccess = True) Then
                '登入成功時
                NowEmployeeNo.Text = nowLoginEmpNo
                NowEmployeeName.Text = nowLoginEmpName
                SourceForm.NowEmployeeNo.Text = nowLoginEmpNo
                SourceForm.NowEmployeeName.Text = nowLoginEmpName

                '取得最新快速登入使用者
                quickLogin()
                '取得系統權限控制
                adminSystemControl()
            End If

            '切換使用不論成功失敗 重置目前狀態
            QueryUserList()
            ChangePassword.Clear()
        End If
    End Sub

    '當點選密碼欄位時清空密碼
    Private Sub ChangePassword_MouseClick(sender As Object, e As MouseEventArgs) Handles ChangePassword.MouseClick
        ChangePassword.Clear()
    End Sub

    '切換至換座位功能 (設為 DoChangeSeat)
    Private Sub OpenChangeSeat_Click(sender As Object, e As EventArgs) Handles OpenChangeSeat.Click
        GetNowDoStatus = "DoChangeSeat"
        ChangeSeatEffectSetting(GetNowDoStatus, nowClickButton)
    End Sub

    '取消換座位功能 (設為 空值)
    Private Sub CancelChangeSeat_Click(sender As Object, e As EventArgs) Handles CancelChangeSeat.Click
        nowClickButton = ""
        GetNowDoStatus = ""
        ChangeSeatEffectSetting(GetNowDoStatus, nowClickButton)
    End Sub

    '交班功能
    Private Sub WorkOffCharge_Click(sender As Object, e As EventArgs) Handles WorkOffCharge.Click

        Dim frm As New Form_WorkOff
        frm.SourceForm = Me
        frm.ShowDialog()

    End Sub
End Class
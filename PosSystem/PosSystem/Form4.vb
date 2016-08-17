Imports System.Data.SQLite
Public Class Form4
    Public Property SourceForm As Form3
    Dim Qty As Integer = 1
    Dim WithEvents EditingControl As DataGridViewTextBoxEditingControl
    Dim addWithNumber As Integer = 0

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ClickData As Integer = 1
        Dim RemoveArrayList As New ArrayList
        RemoveArrayList.Clear()

        If (SourceForm.Mode = "Modify") Then
            addWithNumber = SourceForm.ShowDataView.Rows(SourceForm.ShowDataView.SelectedRows(0).Index).Cells.Item("AddWith").Value
        ElseIf (SourceForm.Mode = "New") Then
            addWithNumber = SourceForm.OrderSerno
        End If

        If (SourceForm.Mode = "New") Then
            IceTemp.Rows.Add(New String() {SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IceId").Value,
                                           SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IceFullName").Value,
                                           SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IcePrice").Value,
                                           "十",
                                           "一"})

            ShowDataView.Rows.Add(New String() {"一",
                                                SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IceId").Value,
                                                SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IceType").Value,
                                                SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IceFullName").Value,
                                                1,
                                                SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IcePrice").Value,
                                                addWithNumber,
                                                SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IcePrice").Value,
                                                SourceForm.IceDataView.Rows(SourceForm.IceDataView.SelectedRows(0).Index).Cells.Item("IceAddToFlag").Value})
        ElseIf (SourceForm.Mode = "Modify") Then
            For i As Integer = 0 To SourceForm.ShowDataView.RowCount - 2

                If ((SourceForm.ShowDataView.Rows(i).Cells.Item("ShowType").Value = "Ice" Or SourceForm.ShowDataView.Rows(i).Cells.Item("ShowType").Value = "AddTo") And
                    (SourceForm.ShowDataView.Rows(i).Cells.Item("AddWith").Value = SourceForm.ShowDataView.Rows(SourceForm.ShowDataView.SelectedRows(0).Index).Cells.Item("AddWith").Value)) Then
                    If (SourceForm.ShowDataView.Rows(i).Cells.Item("ShowType").Value = "Ice") Then
                        IceTemp.Rows.Add(New String() {SourceForm.ShowDataView.Rows(i).Cells.Item("ShowId").Value,
                                                       SourceForm.ShowDataView.Rows(i).Cells.Item("ShowFullName").Value,
                                                       SourceForm.ShowDataView.Rows(i).Cells.Item("ShowPrice").Value,
                                                      "十",
                                                      "一"})
                    End If

                    ShowDataView.Rows.Add(New String() {"一",
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("ShowId").Value,
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("ShowType").Value,
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("ShowFullName").Value,
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("ShowQty").Value,
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("ShowPrice").Value,
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("AddWith").Value,
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value,
                                                        SourceForm.ShowDataView.Rows(i).Cells.Item("ShowAddToFlag").Value})

                    RemoveArrayList.Add(i)
                End If
            Next i
        End If

        If (RemoveArrayList.Count > 0) Then
            For i As Integer = 0 To RemoveArrayList.Count - 1
                SourceForm.ShowDataView.Rows.RemoveAt(RemoveArrayList.Item(0))
            Next i
        End If

        QueryMenuList(AddToTemp, "AddTo")
    End Sub

    '按下ENTER鍵不跳下一個ROW, 跳至下一個COLUMN
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Enter
                SendKeys.Send("{TAB}")
                Return True
        End Select
        Return False
    End Function

    '取得DataGridView編輯控制權
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles ShowDataView.EditingControlShowing
        If ShowDataView.CurrentCell.ColumnIndex = 4 Then
            EditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)
        End If
    End Sub

    '設定DtaGridView欄位中限定輸入資料為何種型態(英文或數字)
    Private Sub EditingControl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EditingControl.KeyPress
        If ShowDataView.CurrentCell.ColumnIndex = 4 Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AddToTemp_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AddToTemp.MouseClick
        AddToShowList(AddToTemp)
    End Sub

    Private Sub Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finish.Click
        Dim ReturnAddWith As Integer = 0
        ReturnAddWith = CheckIceAddToExist()

        If (ReturnAddWith = 0) Then
            For i As Integer = 0 To ShowDataView.RowCount - 2
                Dim Mark As String = ""

                If (ShowDataView.Rows(i).Cells.Item("ShowType").Value = "AddTo" And
                    ShowDataView.Rows(i).Cells.Item("ShowFullName").Value.ToString.Substring(0, 1) <> "◎") Then
                    Mark = "◎"
                End If

                SourceForm.ShowDataView.Rows.Add(New String() {"修改",
                                                               "一",
                                                               ShowDataView.Rows(i).Cells.Item("ShowId").Value,
                                                               ShowDataView.Rows(i).Cells.Item("ShowType").Value,
                                                               Mark & ShowDataView.Rows(i).Cells.Item("ShowFullName").Value,
                                                               ShowDataView.Rows(i).Cells.Item("ShowQty").Value,
                                                               ShowDataView.Rows(i).Cells.Item("ShowPrice").Value,
                                                               ShowDataView.Rows(i).Cells.Item("AddWith").Value,
                                                               ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value,
                                                               ShowDataView.Rows(i).Cells.Item("ShowAddToFlag").Value})
            Next i
        ElseIf (ReturnAddWith > 0) Then
            For i As Integer = 0 To ShowDataView.RowCount - 2
                For j As Integer = 0 To SourceForm.ShowDataView.RowCount - 2
                    If (SourceForm.ShowDataView.Rows(j).Cells.Item("ShowId").Value = ShowDataView.Rows(i).Cells.Item("ShowId").Value And
                        SourceForm.ShowDataView.Rows(j).Cells.Item("AddWith").Value = ReturnAddWith) Then
                        SourceForm.ShowDataView.Rows(j).Cells.Item("ShowQty").Value = SourceForm.ShowDataView.Rows(j).Cells.Item("ShowQty").Value + CInt(ShowDataView.Rows(i).Cells.Item("ShowQty").Value)
                        SourceForm.ShowDataView.Rows(j).Cells.Item("ShowSubTotal").Value = SourceForm.ShowDataView.Rows(j).Cells.Item("ShowQty").Value * ShowDataView.Rows(i).Cells.Item("ShowPrice").Value
                    End If
                Next j
            Next i
        End If


        '計算金額並將結果顯示於畫面上
        Calculator()
        Hide()
    End Sub

    '檢查是否已經存在相同的點餐項目，是則合併
    Function CheckIceAddToExist() As Integer
        Dim arrayIndex As Integer = 0
        Dim tmpAddWith As New ArrayList
        Dim CheckResult As Boolean = False
        Dim countScreen As Integer = 0

        For i As Integer = 0 To SourceForm.ShowDataView.RowCount - 2
            If (SourceForm.ShowDataView.Rows(i).Cells.Item("ShowType").Value = "Ice" And
                SourceForm.ShowDataView.Rows(i).Cells.Item("ShowId").Value = IceTemp.Rows(0).Cells.Item("IceId").Value) Then
                tmpAddWith.Add(SourceForm.ShowDataView.Rows(i).Cells.Item("AddWith").Value)
            End If
        Next i

        arrayIndex = 0
        While (arrayIndex < tmpAddWith.Count)
            For j As Integer = 0 To ShowDataView.RowCount - 2
                CheckResult = False
                countScreen = 0
                For k As Integer = 0 To SourceForm.ShowDataView.RowCount - 2
                    If (SourceForm.ShowDataView.Rows(k).Cells.Item("AddWith").Value = tmpAddWith(arrayIndex)) Then
                        countScreen += 1

                        If (SourceForm.ShowDataView.Rows(k).Cells.Item("ShowId").Value = ShowDataView.Rows(j).Cells.Item("ShowId").Value) Then
                            CheckResult = True
                        End If
                    End If
                Next k

                If (countScreen > ShowDataView.RowCount - 1) Then
                    CheckResult = False
                End If

                If (CheckResult = False) Then
                    Exit For
                End If
            Next j

            If (CheckResult = True) Then
                Exit While
            ElseIf (CheckResult = False) Then
                arrayIndex += 1
            End If
        End While


        If (CheckResult = True) Then
            Return tmpAddWith(arrayIndex)
        End If

        Return 0
    End Function

    Private Sub ShowDataView_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShowDataView.MouseDoubleClick
        If (ShowDataView.RowCount >= 2 And ShowDataView.RowCount - 1 > ShowDataView.SelectedRows(0).Index) Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value <> "Ice") Then
                ShowDataView.Rows.RemoveAt(ShowDataView.SelectedRows(0).Index)
            End If

            '計算金額並將結果顯示於畫面上
            Calculator()
        End If
    End Sub

    Private Sub IceTemp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles IceTemp.CellContentClick
        If e.ColumnIndex = 3 Then
            For i As Integer = 0 To ShowDataView.RowCount - 2
                If (ShowDataView.Rows(i).Cells.Item("ShowId").Value =
                    IceTemp.Rows(0).Cells.Item("IceId").Value) Then
                    ShowDataView.Rows(i).Cells.Item("ShowQty").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value + 1
                    ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value * IceTemp.Rows(0).Cells.Item("IcePrice").Value
                End If
            Next i
        End If

        If e.ColumnIndex = 4 Then
            For i As Integer = 0 To ShowDataView.RowCount - 2
                If (ShowDataView.Rows(i).Cells.Item("ShowQty").Value > 1) Then
                    If (ShowDataView.Rows(i).Cells.Item("ShowId").Value =
                        IceTemp.Rows(0).Cells.Item("IceId").Value) Then
                        ShowDataView.Rows(i).Cells.Item("ShowQty").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value - 1
                        ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value * IceTemp.Rows(0).Cells.Item("IcePrice").Value
                    End If
                End If
            Next i
        End If
    End Sub

    '點選清單中的"－" 進行的動作
    Private Sub ShowDataView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowDataView.CellContentClick
        If e.ColumnIndex = 0 Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value > 1) Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value - 1
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value * ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowPrice").Value
            ElseIf (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 1 And ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value <> "Ice") Then
                ShowDataView.Rows.RemoveAt(ShowDataView.SelectedRows(0).Index)
            End If
        End If
    End Sub

    '更改清單中數量欄位時的動作
    Private Sub ShowDataView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowDataView.CellEndEdit
        If (e.ColumnIndex = 4 And ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowFullName").Value <> "") Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value >= 1) Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value * ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowPrice").Value
            ElseIf (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 0 And ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value <> "Ice") Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 1
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value * ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowPrice").Value
            ElseIf (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 0 And ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowType").Value = "Ice") Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value = 1
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowQty").Value * ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("ShowPrice").Value
            End If
        End If
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
            Dim oCmd As New SQLiteCommand("SELECT id, type, fullname, price FROM itemsetting WHERE type = '" & form_type & "';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()
            Dim rowNum As Integer = 1

            While oDR.Read()
                form_object.Rows.Add(New String() {oDR("id"), oDR("type"), oDR("fullname"), oDR("price")})
            End While
        Catch ex As Exception
            MsgBox("MENU資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '加點項目顯示清單
    Private Sub AddToShowList(ByVal form_object As Object)
        Dim Exist As Boolean = False

        For i As Integer = 0 To ShowDataView.RowCount - 2
            If (ShowDataView.Rows(i).Cells.Item("ShowId").Value =
                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item("AddToId").Value) Then
                Exist = True
                ShowDataView.Rows(i).Cells.Item("ShowQty").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value + 1
                ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value = ShowDataView.Rows(i).Cells.Item("ShowQty").Value * form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item("AddToPrice").Value
                Exit For
            End If
        Next i

        If (Exist = False) Then
            ShowDataView.Rows.Add(New String() {"一",
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item("AddToId").Value,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item("AddToType").Value,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item("AddToFullName").Value,
                                                1,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item("AddToPrice").Value,
                                                addWithNumber,
                                                form_object.Rows(form_object.SelectedRows(0).Index).Cells.Item("AddToPrice").Value,
                                                "Y"})
        End If
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
        total = 0
        'For i As Integer = 0 To ShowDataView.RowCount - 2
        '    total = total + ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value
        'Next i

        For i As Integer = 0 To SourceForm.ShowDataView.RowCount - 2
            total = total + SourceForm.ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value
        Next i

        '付款金額
        nowpaid = CInt(SourceForm.NowPaidAmt.Text)
        '已付金額
        paid = CInt(SourceForm.PaidAmt.Text)
        '折扣金額
        discount = CInt(SourceForm.DiscountAmt.Text)
        '找零金額
        change = CInt(SourceForm.ChangeAmt.Text)
        '退款/加收金額
        return_amt = CInt(SourceForm.ReturnAmt.Text)


        If (discount > 0) Then
            total = total - discount
        End If

        SourceForm.TotalAmt.Text = total


        If (SourceForm.Status = "ModifyOrderData") Then
            paid = SourceForm.PaidAmt.Text
            return_amt = total - paid
            SourceForm.ReturnAmt.Text = return_amt

            change = nowpaid - return_amt
            SourceForm.ChangeAmt.Text = change

            '控管如果退款金額小於0(負數)則將付款欄位設定不可修改
            If (return_amt < 0) Then
                change = 0
                SourceForm.ChangeAmt.Text = change
                SourceForm.NowPaidAmt.Enabled = False
                SourceForm.Label7.Text = "退款"
            Else
                SourceForm.NowPaidAmt.Enabled = True
                SourceForm.Label7.Text = "加收"
            End If
        Else
            change = nowpaid - total
            SourceForm.ChangeAmt.Text = change
        End If
    End Sub
End Class
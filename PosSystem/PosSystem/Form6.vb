Imports System.Data.SQLite
Public Class Form6
    Public Property SourceForm As Form3

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '預設查詢條件(會觸發執行查詢)
        QueryType.Text = "冰品"

        AddHandler Cancel.MouseClick, AddressOf SourceForm.Restart_Click
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

    '按下存檔鈕(需修改 未完成)
    Private Sub SaveData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveData.Click
        For i As Integer = 0 To ShowDataView.RowCount - 2
            If (ShowDataView.Rows(i).Cells.Item("id").Value <> Nothing) Then
                UpdateItemSetting(ShowDataView.Rows(i).Cells.Item("id").Value,
                                  GetTypeId(ShowDataView.Rows(i).Cells.Item("type").Value),
                                  ShowDataView.Rows(i).Cells.Item("fullname").Value,
                                  ShowDataView.Rows(i).Cells.Item("price").Value,
                                  ShowDataView.Rows(i).Cells.Item("addto_flag").Value,
                                  ShowDataView.Rows(i).Cells.Item("stop_flag").Value)
            ElseIf (ShowDataView.Rows(i).Cells.Item("id").Value = Nothing) Then
                InsertItemSetting(GetTypeId(ShowDataView.Rows(i).Cells.Item("type").Value),
                                  ShowDataView.Rows(i).Cells.Item("fullname").Value,
                                  ShowDataView.Rows(i).Cells.Item("price").Value,
                                  ShowDataView.Rows(i).Cells.Item("addto_flag").Value,
                                  ShowDataView.Rows(i).Cells.Item("stop_flag").Value)
            End If
        Next i
        MsgBox("存檔成功")
        '清除畫面資料
        ShowDataView.Rows.Clear()
        '清除畫面變動是下拉控制項目
        ShowDataView.Columns.Remove("type")
        QueryItemList(ShowDataView, GetTypeId(QueryType.Text.ToString))
    End Sub

    '按下回主畫面鈕
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Hide()
        InitailData()
    End Sub

    '變更下拉查詢條件時做查詢
    Private Sub QueryType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryType.SelectedIndexChanged
        QueryItemList(ShowDataView, GetTypeId(QueryType.Text.ToString))
    End Sub

    '進行查詢清單
    Private Sub QueryItemList(ByVal form_object As Object, ByVal form_type As String)
        '清除畫面資料
        ShowDataView.Rows.Clear()
        '判斷是否需要清除畫面變動是下拉控制項目
        If (ShowDataView.Columns(1).Name = "type") Then
            ShowDataView.Columns.Remove("type")
        End If

        Dim cmd As New SQLiteCommand
        Dim da As New SQLiteDataAdapter
        Dim ds As New DataSet
        Dim cbo As New DataGridViewComboBoxColumn
        cbo.Name = "type"
        cbo.HeaderText = "商品種類"
        cbo.DefaultCellStyle.Font = New Font("微軟正黑體", 12, FontStyle.Bold)
        cbo.FlatStyle = FlatStyle.Flat
        cbo.DataSource = ds.Tables("typedata")
        cbo.DisplayMember = "type_name"
        cbo.ValueMember = "type_id"
        form_object.Columns.Insert(1, cbo)
        cmd.CommandText = "SELECT type_id, type_name FROM typedata"
        cmd.Connection = oConn
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(ds)
        For I = 0 To ds.Tables(0).Rows.Count - 1
            cbo.Items.Add(ds.Tables(0).Rows(I).Item("type_name"))
        Next
        ds.Clear()

        Try
            Dim SqlString = ""
            If (form_type = "All") Then
                SqlString = "SELECT id, type, fullname, price, addto_flag, stop_flag FROM itemsetting ORDER BY type;"
            Else
                SqlString = "SELECT id, type, fullname, price, addto_flag, stop_flag FROM itemsetting WHERE type = '" & form_type & "' ORDER BY type;"
            End If

            Dim oCmd As New SQLiteCommand(SqlString, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                form_object.Rows.Add(New String() {oDR("id"), GetTypeName(oDR("type")), oDR("fullname"), oDR("price"), oDR("addto_flag"), oDR("stop_flag")})
            End While
        Catch ex As Exception
            MsgBox("MENU資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '回傳種類ID
    Function GetTypeId(ByVal form_type As String) As String
        Dim TypeName As String = ""
        Try
            TypeName = ""

            If (form_type = "冰品") Then
                TypeName = "Ice"
            ElseIf (form_type = "加點") Then
                TypeName = "AddTo"
            ElseIf (form_type = "點心") Then
                TypeName = "Dessert"
            ElseIf (form_type = "飲品") Then
                TypeName = "Drink"
            ElseIf (form_type = "其它") Then
                TypeName = "Others"
            ElseIf (form_type = "全部") Then '只有在查詢才有意義, 品項本身並無"全部"這項種類
                TypeName = "All"
            End If
        Catch ex As Exception
            Return ""
        End Try

        Return TypeName
    End Function

    '回傳種類名稱
    Function GetTypeName(ByVal form_type As String) As String
        Dim TypeName As String = ""
        Try
            TypeName = ""

            If (form_type = "Ice") Then
                TypeName = "冰品"
            ElseIf (form_type = "AddTo") Then
                TypeName = "加點"
            ElseIf (form_type = "Dessert") Then
                TypeName = "點心"
            ElseIf (form_type = "Drink") Then
                TypeName = "飲品"
            ElseIf (form_type = "Others") Then
                TypeName = "其它"
            End If
        Catch ex As Exception
            Return ""
        End Try

        Return TypeName
    End Function

    '寫入商品檔
    Private Sub InsertItemSetting(ByVal form_type As String, ByVal form_fullname As String, ByVal form_price As Integer,
                                  ByVal form_addto_flag As String, ByVal form_stop_flag As String)

        If (form_addto_flag = Nothing) Then
            form_addto_flag = "N"
        End If

        If (form_stop_flag = Nothing) Then
            form_stop_flag = "N"
        End If

        If (form_type = "AddTo") Then
            form_addto_flag = "Y"
        End If

        Try
            Dim oCmd As New SQLiteCommand("INSERT INTO itemsetting (type, fullname, price, addto_flag, stop_flag) VALUES ('" & form_type & "','" & form_fullname & "','" & form_price & "','" & form_addto_flag & "','" & form_stop_flag & "');", oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("寫入商品檔失敗" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '更新商品檔
    Private Sub UpdateItemSetting(ByVal form_id As Integer, ByVal form_type As String, ByVal form_fullname As String,
                                  ByVal form_price As Integer, ByVal form_addto_flag As String, ByVal form_stop_flag As String)
        Try
            Dim oCmd As New SQLiteCommand("update itemsetting set type = '" & form_type & "', fullname = '" & form_fullname & "', price = '" & form_price & "', addto_flag = '" & form_addto_flag & "', stop_flag = '" & form_stop_flag & "' where id = '" & form_id & "';", oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("更新商品檔失敗" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    Private Sub InitailData()
        SourceForm.IceDataView.Rows.Clear()
        SourceForm.DrinkDataView.Rows.Clear()
        SourceForm.DessertDataView.Rows.Clear()
        SourceForm.DrinkIceDataView.Rows.Clear()
        SourceForm.DrinkSugarDataView.Rows.Clear()
        SourceForm.OthersDataView.Rows.Clear()

        '列出冰品MENU
        QueryMenuList(SourceForm.IceDataView, "Ice")

        '列出飲品MENU
        QueryMenuList(SourceForm.DrinkDataView, "Drink")

        '列出點心MENU
        QueryMenuList(SourceForm.DessertDataView, "Dessert")

        '列出飲品相關項目
        'Ice
        SourceForm.DrinkIceDataView.Rows.Add(New String() {"正常"})
        SourceForm.DrinkIceDataView.Rows.Add(New String() {"少冰"})
        SourceForm.DrinkIceDataView.Rows.Add(New String() {"微冰"})
        SourceForm.DrinkIceDataView.Rows.Add(New String() {"去冰"})
        SourceForm.DrinkIceDataView.Rows.Add(New String() {"溫"})
        SourceForm.DrinkIceDataView.Rows.Add(New String() {"熱"})

        'Sugar
        SourceForm.DrinkSugarDataView.Rows.Add(New String() {"全糖"})
        SourceForm.DrinkSugarDataView.Rows.Add(New String() {"7分"})
        SourceForm.DrinkSugarDataView.Rows.Add(New String() {"5分"})
        SourceForm.DrinkSugarDataView.Rows.Add(New String() {"3分"})
        SourceForm.DrinkSugarDataView.Rows.Add(New String() {"1分"})
        SourceForm.DrinkSugarDataView.Rows.Add(New String() {"無糖"})

        '列出其它商品MENU
        QueryMenuList(SourceForm.OthersDataView, "Others")
    End Sub

    '取得商品資料並刷新主畫面商品資訊
    Private Sub QueryMenuList(ByVal form_object As Object, ByVal form_type As String)
        Try
            Dim oCmd As New SQLiteCommand("SELECT id, type, fullname, price, addto_flag FROM itemsetting WHERE type = '" & form_type & "' AND stop_flag = 'N';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                form_object.Rows.Add(New String() {oDR("id"), oDR("type"), oDR("fullname"), oDR("price"), oDR("addto_flag")})
            End While

            '檢核各分類區塊中若無資料則設定項目停止回應使用者操作
            If (form_type = "Ice") Then
                If (SourceForm.IceDataView.Rows.Count = 1) Then
                    SourceForm.IceDataView.Enabled = False
                Else
                    SourceForm.IceDataView.Enabled = True
                End If
            ElseIf (form_type = "Dessert") Then
                If (SourceForm.DessertDataView.Rows.Count = 1) Then
                    SourceForm.DessertDataView.Enabled = False
                Else
                    SourceForm.DessertDataView.Enabled = True
                End If
            ElseIf (form_type = "Drink") Then
                If (SourceForm.DrinkDataView.Rows.Count = 1) Then
                    SourceForm.DrinkIceDataView.Rows.Clear()
                    SourceForm.DrinkSugarDataView.Rows.Clear()
                    SourceForm.DrinkDataView.Enabled = False
                    SourceForm.DrinkIceDataView.Enabled = False
                    SourceForm.DrinkSugarDataView.Enabled = False
                Else
                    SourceForm.DrinkDataView.Enabled = True
                End If
            ElseIf (form_type = "Others") Then
                If (SourceForm.OthersDataView.Rows.Count = 1) Then
                    SourceForm.OthersDataView.Enabled = False
                Else
                    SourceForm.OthersDataView.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("MENU資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '強制設定區 (未完成)
    Private Sub ShowDataView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowDataView.CellContentClick
        If (e.ColumnIndex = 4) Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("type").Value = "加點") Then
                If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("addto_flag").Value = "Y") Then
                    ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("addto_flag").Value = "Y"
                End If

            ElseIf (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("type").Value <> "冰品" And
                    ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("type").Value <> "加點") Then
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("addto_flag").Value = "N"
            End If
        End If
    End Sub

End Class
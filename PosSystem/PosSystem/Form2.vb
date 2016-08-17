Imports System.Data.SQLite
Public Class Form2
    Public Property SourceForm As Form3
    Public Property SourceForm2 As Form1

    Dim WithEvents EditingControl As DataGridViewTextBoxEditingControl

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '檢核目前由哪個表單呼叫
        CheckNowCallBy()

        If (Me.Text = "員工基本資料維護") Then
            AddHandler Cancel.MouseClick, AddressOf SourceForm.Restart_Click
        Else
            AddHandler Cancel.MouseClick, AddressOf Cancel_Click
        End If
    End Sub

    '將密碼欄位進行資訊隱藏，顯示時一律顯示固定格式，但實際上是使用者輸入的值
    Private Sub DataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles ShowDataView.CellFormatting
        If ShowDataView.Columns(e.ColumnIndex).Name.Equals("password") Then
            Dim strValue As String = TryCast(e.Value, String)
            If strValue Is Nothing Then Return
            e.Value = "********"
        End If
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
        If (ShowDataView.CurrentCell.ColumnIndex = 0 Or
            ShowDataView.CurrentCell.ColumnIndex = 3 Or
            ShowDataView.CurrentCell.ColumnIndex = 4 Or
            ShowDataView.CurrentCell.ColumnIndex = 5 Or
            ShowDataView.CurrentCell.ColumnIndex = 7) Then
            EditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)
        End If
    End Sub

    '設定DtaGridView欄位中限定輸入資料為何種型態(英文或數字)
    Private Sub EditingControl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EditingControl.KeyPress
        If ShowDataView.CurrentCell.ColumnIndex = 0 Or
           ShowDataView.CurrentCell.ColumnIndex = 3 Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf ShowDataView.CurrentCell.ColumnIndex = 4 Or
               ShowDataView.CurrentCell.ColumnIndex = 5 Or
               ShowDataView.CurrentCell.ColumnIndex = 7 Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    '按下回主畫面鈕
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If (Me.Text <> "員工基本資料維護") Then
            SourceForm2.QueryUserList()
        End If

        Hide()
    End Sub

    '按下存檔鈕
    Private Sub SaveData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveData.Click
        Dim isOk As Boolean = False
        Dim CreateDateTIme As String = ""
        Dim CreateClerk As String = ""
        Dim tmpLeaveflag As String = ""
        CreateDateTIme = DateTime.Now.ToString("yyyyMMdd") & DateTime.Now.ToString("HHmm")

        For i As Integer = 0 To ShowDataView.RowCount - 2
            isOk = False
            isOk = CheckFillDataOK(ShowDataView.Rows(i).Cells.Item("emp_no").Value,
                                   ShowDataView.Rows(i).Cells.Item("emp_name").Value,
                                   ShowDataView.Rows(i).Cells.Item("password").Value,
                                   ShowDataView.Rows(i).Cells.Item("id_no").Value,
                                   ShowDataView.Rows(i).Cells.Item("h_tel").Value,
                                   ShowDataView.Rows(i).Cells.Item("mobile").Value,
                                   ShowDataView.Rows(i).Cells.Item("address").Value,
                                   ShowDataView.Rows(i).Cells.Item("take_office").Value,
                                   ShowDataView.Rows(i).Cells.Item("leave_flag").Value,
                                   ShowDataView.Rows(i).Cells.Item("create_datetime").Value,
                                   ShowDataView.Rows(i).Cells.Item("create_clerk").Value,
                                   ShowDataView.Rows(i).Cells.Item("modify_datetime").Value,
                                   ShowDataView.Rows(i).Cells.Item("modify_clerk").Value)
            If (isOk = True) Then
                If (Me.Text = "員工基本資料維護") Then
                    CreateClerk = SourceForm.NowEmployeeNo.Text
                ElseIf (Me.Text = "建立帳號") Then
                    CreateClerk = ShowDataView.Rows(i).Cells.Item("emp_no").Value
                End If

                If (ShowDataView.Rows(i).Cells.Item("leave_flag").Value = Nothing) Then
                    tmpLeaveflag = "N"
                Else
                    tmpLeaveflag = ShowDataView.Rows(i).Cells.Item("leave_flag").Value
                End If

                If (ShowDataView.Rows(i).Cells.Item("emp_no").Value <> "" And
                    ShowDataView.Rows(i).Cells.Item("create_datetime").Value <> "") Then
                    InsertItemSetting("Update",
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("emp_no").Value),
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("emp_name").Value),
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("password").Value),
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("id_no").Value),
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("h_tel").Value),
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("mobile").Value),
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("address").Value),
                                      ConvertNarrow(ShowDataView.Rows(i).Cells.Item("take_office").Value),
                                      ConvertNarrow(tmpLeaveflag),
                                      ConvertNarrow(CreateDateTIme),
                                      ConvertNarrow(CreateClerk),
                                      ConvertNarrow(CreateDateTIme),
                                      ConvertNarrow(CreateClerk))
                Else
                    Dim Count As Integer = 0

                    Try
                        Dim SqlStr As String = ""

                        SqlStr = "SELECT COUNT(*) countData FROM employee WHERE emp_no = '" & ShowDataView.Rows(i).Cells.Item("emp_no").Value & "';"

                        Dim oCmd As New SQLiteCommand(SqlStr, oConn)
                        Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

                        While oDR.Read()
                            Count = oDR("countData")
                        End While
                    Catch ex As Exception
                        MsgBox("檢核帳號重複錯誤" & vbCrLf & ex.GetBaseException.ToString)
                    End Try

                    If (Count = 0) Then
                        InsertItemSetting("Insert",
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("emp_no").Value),
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("emp_name").Value),
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("password").Value),
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("id_no").Value),
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("h_tel").Value),
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("mobile").Value),
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("address").Value),
                                          ConvertNarrow(ShowDataView.Rows(i).Cells.Item("take_office").Value),
                                          ConvertNarrow(tmpLeaveflag),
                                          ConvertNarrow(CreateDateTIme),
                                          ConvertNarrow(CreateClerk),
                                          ConvertNarrow(CreateDateTIme),
                                          ConvertNarrow(CreateClerk))
                    Else
                        MsgBox("帳號 " & ShowDataView.Rows(i).Cells.Item("emp_no").Value & " 已被使用")
                        isOk = False
                    End If
                End If
            Else
                Exit For
            End If
        Next i

        If (isOk = True) Then
            MsgBox("存檔成功")

            ShowDataView.Rows.Clear()
            CheckNowCallBy()
        End If
    End Sub

    '控管不可修改已經新增的帳號名稱
    Private Sub ShowDataView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowDataView.CellClick
        If e.ColumnIndex = 0 Then
            If (ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("emp_no").Value <> "" And
                ShowDataView.Rows(ShowDataView.SelectedRows(0).Index).Cells.Item("create_datetime").Value <> "") Then
                MsgBox("不可修改已新增的帳號名稱")
            End If
        End If
    End Sub

    '全形轉半形
    Function ConvertNarrow(ByVal form_str As String) As String
        Dim StrNarrow As String = ""

        StrNarrow = StrConv(form_str, vbNarrow)

        Return StrNarrow
    End Function

    '檢核目前是由哪個表單呼叫
    Private Sub CheckNowCallBy()
        Dim CallByForm As String = ""

        Try
            CallByForm = Me.SourceForm2.Text.ToString
            Me.Text = "建立帳號"
            QueryMemberData(ShowDataView, "")
        Catch ex As Exception
            CallByForm = ""
            Exit Try
        End Try

        Try
            CallByForm = Me.SourceForm.Text.ToString
            Me.Text = "員工基本資料維護"
            QueryMemberData(ShowDataView, SourceForm.NowEmployeeNo.Text)
        Catch ex As Exception
            CallByForm = ""
            Exit Try
        End Try
    End Sub

    '檢核必填欄位
    Function CheckFillDataOK(ByVal form_emp_no As String, ByVal form_emp_name As String, ByVal form_pssword As String,
                                  ByVal form_id_no As String, ByVal form_h_tel As String, ByVal form_mobile As String,
                                  ByVal form_address As String, ByVal form_take_office As String, ByVal form_leave_flag As String,
                                  ByVal form_create_datetime As String, ByVal form_create_clerk As String, ByVal form_modify_datetime As String,
                                  ByVal form_modify_clerk As String) As Boolean
        Dim Msgstr As String = ""

        If (IsDBNull(form_emp_no) Or form_emp_no = "") Then
            Msgstr = Msgstr & "員工帳號 / "
        End If
        If (IsDBNull(form_emp_name) Or form_emp_name = "") Then
            Msgstr = Msgstr & "員工姓名 / "
        End If
        If (IsDBNull(form_pssword) Or form_pssword = "") Then
            Msgstr = Msgstr & "密碼 / "
        End If
        If (IsDBNull(form_id_no) Or form_id_no = "") Then
            Msgstr = Msgstr & "身份證字號 / "
        End If
        If (IsDBNull(form_h_tel) Or form_h_tel = "") Then
            Msgstr = Msgstr & "家用電話 / "
        End If
        If (IsDBNull(form_mobile) Or form_mobile = "") Then
            Msgstr = Msgstr & "手機號碼 / "
        End If
        If (IsDBNull(form_address) Or form_address = "") Then
            Msgstr = Msgstr & "詳細住址 / "
        End If
        If (IsDBNull(form_take_office) Or form_take_office = "") Then
            Msgstr = Msgstr & "到職日期 / "
        End If

        If (Msgstr = "") Then
            If (CheckDateTime(ConvertNarrow(form_take_office))) Then
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("未填項目如下(請確認):" & vbCrLf & Msgstr)
            Return False
        End If

        Return False
    End Function

    Private Sub QueryMemberData(ByVal form_object As Object, ByVal form_emp_no As String)
        If (AdminFlag = "Y") Then
            ShowDataView.Columns(0).ReadOnly = False
        Else
            If (Me.Text = "建立帳號") Then
                ShowDataView.Columns(0).ReadOnly = False
            Else
                ShowDataView.Columns(0).ReadOnly = True
            End If
        End If

        Try
            Dim SqlStr As String = ""
            If (AdminFlag = "Y") Then
                SqlStr = "SELECT emp_no, emp_name, password, id_no, h_tel, mobile, address, take_office, leave_flag, admin_flag, create_datetime, create_clerk, modify_datetime, modify_clerk FROM employee;"
            Else
                SqlStr = "SELECT emp_no, emp_name, password, id_no, h_tel, mobile, address, take_office, leave_flag, admin_flag, create_datetime, create_clerk, modify_datetime, modify_clerk FROM employee WHERE emp_no = '" & form_emp_no & "';"
            End If

            Dim oCmd As New SQLiteCommand(SqlStr, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                form_object.Rows.Add(New String() {oDR("emp_no"), oDR("emp_name"), oDR("password"), oDR("id_no"), oDR("h_tel"), oDR("mobile"), oDR("address"), oDR("take_office"), oDR("leave_flag"), oDR("create_datetime"), oDR("create_clerk"), oDR("modify_datetime"), oDR("modify_clerk")})
            End While
        Catch ex As Exception
            MsgBox("員工基本資料查詢錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '寫入商品檔
    Private Sub InsertItemSetting(ByVal form_status As String, ByVal form_emp_no As String, ByVal form_emp_name As String, ByVal form_pssword As String,
                                  ByVal form_id_no As String, ByVal form_h_tel As String, ByVal form_mobile As String,
                                  ByVal form_address As String, ByVal form_take_office As String, ByVal form_leave_flag As String,
                                  ByVal form_create_datetime As String, ByVal form_create_clerk As String, ByVal form_modify_datetime As String,
                                  ByVal form_modify_clerk As String)
        Dim SqlStr As String = ""

        If (form_status = "Insert") Then
            Try
                SqlStr = ""
                SqlStr = "INSERT INTO employee (emp_no, emp_name, password, id_no, h_tel, mobile, address, take_office, leave_flag, create_datetime, create_clerk, modify_datetime, modify_clerk) VALUES ('" & form_emp_no & "','" & form_emp_name & "','" & form_pssword & "','" & form_id_no & "','" & form_h_tel & "','" & form_mobile & "','" & CheckNull(form_address) & "','" & form_take_office & "','" & CheckNull(form_leave_flag) & "','" & form_create_datetime & "','" & form_create_clerk & "','" & "" & "','" & "" & "');"

                Dim oCmd As New SQLiteCommand(SqlStr, oConn)
                oCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("新增員工資料失敗" & vbCrLf & ex.GetBaseException.ToString)
            End Try
        ElseIf (form_status = "Update") Then
            Try
                SqlStr = ""
                SqlStr = "update employee set emp_name = '" & form_emp_name & _
                                             "', password = '" & form_pssword & _
                                             "', id_no = '" & form_id_no & _
                                             "', h_tel = '" & form_h_tel & _
                                             "', mobile = '" & form_mobile & _
                                             "', address = '" & form_address & _
                                             "', take_office = '" & form_take_office & _
                                             "', leave_flag = '" & form_leave_flag & _
                                             "', modify_datetime = '" & form_modify_datetime & _
                                             "', modify_clerk = '" & form_modify_clerk & _
                                             "' where emp_no = '" & form_emp_no & "';"

                Dim oCmd As New SQLiteCommand(SqlStr, oConn)
                oCmd.ExecuteNonQuery()
            Catch ex2 As Exception
                MsgBox("更新員工資料失敗" & vbCrLf & ex2.GetBaseException.ToString)
            End Try
        End If
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

    Function CheckNull(ByVal form_data As String) As String
        If (IsDBNull(form_data)) Then
            form_data = ""
        End If
        Return form_data
    End Function
End Class
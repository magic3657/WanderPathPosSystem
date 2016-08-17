Imports System.Data.SQLite
Module Module1
    Public oConn As New SQLiteConnection("Data Source=C:\sqlite3\myposdb.sl3; Version=3")

    Public isNotRun As Boolean
    Public m As New System.Threading.Mutex(True, "PosSystem", isNotRun)
    Public AdminFlag As Char = "N"
    Public nowLoginEmpNo As String = ""
    Public nowLoginEmpName As String = ""

    '檢核登入者權限
    Public Function CheckAdminFlag(form_emp_no As String) As Boolean
        Try
            Dim SqlStr As String = ""
            AdminFlag = "N"

            SqlStr = "SELECT admin_flag FROM employee WHERE emp_no = '" & form_emp_no & "' AND leave_flag = '" & "N" & "';"

            Dim oCmd As New SQLiteCommand(SqlStr, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                AdminFlag = oDR("admin_flag")
            End While
        Catch ex As Exception
            AdminFlag = "N"
            MsgBox("檢核管理員身份錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
        Return False
    End Function

    '切換帳號檢核登入
    Public Function CheckLogin(ByVal form_emp_no As String, ByVal form_password As String) As Boolean
        Dim changeLoginSuccess As Boolean = False
        'MsgBox("[CheckLogin] " & form_emp_no)
        Try
            Dim SqlStr As String = ""
            Dim tmpEmpNo As String = ""
            Dim tmpEmpName As String = ""
            Dim tmpPassword As String = ""
            Dim tmpLeaveflag As String = ""
            Dim LoginDate = DateTime.Now.ToString("yyyyMMdd")
            Dim LoginTime = DateTime.Now.ToString("HHmm")

            SqlStr = "SELECT emp_no, emp_name, password, leave_flag, admin_flag FROM employee WHERE emp_no = '" & form_emp_no & "';"

            Dim oCmd As New SQLiteCommand(SqlStr, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                tmpEmpNo = oDR("emp_no")
                tmpEmpName = oDR("emp_name")
                tmpPassword = oDR("password")
                If (oDR("leave_flag") = Nothing) Then
                    tmpLeaveflag = "N"
                Else
                    tmpLeaveflag = oDR("leave_flag")
                End If
            End While

            If (tmpLeaveflag = "Y") Then
                MsgBox(tmpEmpNo & " - " & tmpEmpName & " 該名員工已經離職")
                '寫入登入記錄檔
                InsertLoginHistory(LoginDate, form_emp_no, tmpEmpName, "X", "N", "該名員工已經離職", LoginTime)
                changeLoginSuccess = False
            ElseIf (form_emp_no <> "" And form_password <> "") Then
                If (form_emp_no = tmpEmpNo And form_password = tmpPassword) Then
                    '檢核登入者權限
                    CheckAdminFlag(form_emp_no)
                    '登入成功即更新當前登入者ID及名稱
                    nowLoginEmpNo = form_emp_no
                    nowLoginEmpName = tmpEmpName
                    changeLoginSuccess = True

                    '取得登入歷史紀錄
                    Dim loginData As New ArrayList
                    Dim loginDataCount As Integer = 0
                    loginData = CheckOrQueryLoginHistory(LoginDate, form_emp_no, "Y", False)
                    loginDataCount = loginData.Count
                    'MsgBox("[loginData count] " & loginData.Count.ToString & "[loginDataCount] " & loginDataCount)
                    '成功登入者當日首次登入必須寫入登入紀錄檔(for 更快速登入按鈕功能) 登入記錄狀態(成功/失敗 Y/N) 及 登入失敗原因(登入成功則為空)
                    If (loginDataCount = 0) Then
                        InsertLoginHistory(LoginDate, form_emp_no, tmpEmpName, AdminFlag, "Y", "", LoginTime)
                    End If

                    'InitailData()
                Else
                    MsgBox("查無此帳號或密碼，請重新輸入")
                    '寫入登入記錄檔
                    InsertLoginHistory(LoginDate, form_emp_no, tmpEmpName, "X", "N", "查無此帳號或密碼", LoginTime)
                    changeLoginSuccess = False
                End If
            Else
                MsgBox("請輸入帳號密碼")
                '寫入登入記錄檔
                InsertLoginHistory(LoginDate, form_emp_no, tmpEmpName, "X", "N", "未輸入帳號密碼", LoginTime)
                changeLoginSuccess = False
            End If
        Catch ex As Exception
            MsgBox("登入錯誤" & vbCrLf & ex.GetBaseException.ToString)
            changeLoginSuccess = False
        End Try

        Return changeLoginSuccess
    End Function

    '取得登入歷史紀錄
    Public Function CheckOrQueryLoginHistory(formLoginDate As String, formEmpNo As String, formStatus As String, formQueryAll As Boolean) As ArrayList
        Dim data As New ArrayList
        Dim querySql = ""

        If (formQueryAll) Then
            querySql = "SELECT login_date, login_emp_no, login_emp_name, admin_flag, login_status, login_fail_reason, login_time FROM loginhistory WHERE login_date = '" & formLoginDate & "' AND login_status = '" & formStatus & "';"
        Else
            querySql = "SELECT login_date, login_emp_no, login_emp_name, admin_flag, login_status, login_fail_reason, login_time FROM loginhistory WHERE login_date = '" & formLoginDate & "' AND login_emp_no = '" & formEmpNo & "' AND login_status = '" & formStatus & "';"
        End If
        data.Clear()
        'MsgBox(formLoginDate & " // " & formEmpNo & " // " & formStatus)

        Try
            Dim oCmd As New SQLiteCommand(querySql, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()
            Dim fieldCount = oDR.FieldCount

            While oDR.Read()
                Dim dataArray(fieldCount) As String
                For i = 0 To fieldCount - 1
                    dataArray(i) = oDR(i)
                    'MsgBox(dataArray(i).ToString)
                Next i
                data.Add(dataArray)
            End While
            'MsgBox("[data count] " & data.Count.ToString)

        Catch ex As Exception
            MsgBox("[data Error - method: CheckOrQueryLoginHistory] ")
            data.Clear()
        End Try

        Return data
    End Function

    '登入記錄檔
    'formAdminFlag 定義為 該登入者使用權限,這裡設定的機制為: 登入失敗時此欄位寫入無效的權限值(X), 因為登入失敗的情況, 權限欄位並無意義.
    Public Sub InsertLoginHistory(formLoginDate As String, formEmpNo As String, formEmpName As String, formAdminFlag As String, formStatus As String, formFailReason As String, formLoginTime As String)

        If (String.IsNullOrEmpty(formEmpNo)) Then
            formEmpNo = "None"
        End If

        If (String.IsNullOrEmpty(formEmpName)) Then
            formEmpName = "None"
        End If

        Try
            Dim oCmd As New SQLiteCommand("INSERT INTO loginhistory (login_date, login_emp_no, login_emp_name, admin_flag, login_status, login_fail_reason, login_time, logout_datetime) VALUES ('" & formLoginDate & "','" & formEmpNo & "','" & formEmpName & "','" & formAdminFlag & "','" & formStatus & "','" & formFailReason & "','" & formLoginTime & "','" & " " & "');", oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("寫入登入記錄檔失敗" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub
End Module

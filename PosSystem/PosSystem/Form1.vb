Imports System.Data.SQLite

Public Class Form1
    Private Sub SetMdiBackColor()
        Me.Controls(Me.Controls.Count - 1).BackColor = Me.BackColor
    End Sub

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        SetMdiBackColor()

        If isNotRun Then
            '開啟資料庫
            oConn.Open()
        Else
            MessageBox.Show("[ 溫馨小提示 ]" & vbCrLf & "請勿重複開啟 [ 散步路徑收驚系統 ]... " & vbCrLf & "或者 請關閉 [ 散步路徑補帳/統計系統 ] 才可啟動。")
            End
        End If

        QueryUserList()
    End Sub

    '密碼欄位按下ENTER則直接觸發登入鈕
    Private Sub EmpPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmpPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Login_Click_1(Login, New System.EventArgs())
        End If
    End Sub

    '滑鼠點一下即清空帳號欄位
    Private Sub EmpNo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        EmpNo.Text = ""
    End Sub

    '滑鼠點一下即清空密碼欄位
    Private Sub EmpPassword_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles EmpPassword.MouseClick
        EmpPassword.Clear()
    End Sub

    '按下登入鈕
    Private Sub Login_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        Dim startLoginSuccess As Boolean = False
        startLoginSuccess = CheckLogin(EmpNo.Text, EmpPassword.Text)

        If (startLoginSuccess = True) Then
            '登入成功時
            EmpName.Text = nowLoginEmpName
            Dim frm As New Form3
            frm.SourceForm = Me
            frm.ShowDialog()
            frm.Close()
        Else
            '登入失敗時
            EmpPassword.Clear()
            EmpNo.Text = ""
        End If
    End Sub

    '按下建立帳號鈕
    Private Sub CreateEmp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateEmp.Click
        Dim frm As New Form2
        frm.SourceForm2 = Me
        frm.ShowDialog()
    End Sub

    '按下離開鈕
    Private Sub CloseProgram_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseProgram.Click
        End
    End Sub

    '員工List清單改變時
    Private Sub EmpNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmpNo.SelectedIndexChanged
        EmpPassword.Focus()
    End Sub

    'LIST員工資料
    Public Sub QueryUserList()
        EmpNo.Text = ""
        EmpNo.Items.Clear()

        Try
            Dim oCmd As New SQLiteCommand("SELECT emp_no, emp_name, password FROM employee WHERE leave_flag = 'N';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                EmpNo.Items.Add(oDR("emp_no"))
            End While
        Catch ex As Exception
            MsgBox("員工資料List錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try

    End Sub

    '當滑鼠移至帳號時自動展開
    Private Sub EmpNo_MouseEnter(sender As Object, e As EventArgs) Handles EmpNo.MouseEnter
        EmpNo.DroppedDown = True
    End Sub
End Class


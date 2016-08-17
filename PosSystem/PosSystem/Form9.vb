Imports System.Data.SQLite

Public Class Form9
    Public Property SourceForm As Form3

    Private Sub SetMdiBackColor()
        Me.Controls(Me.Controls.Count - 1).BackColor = Me.BackColor
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NowEmployeeNo.Text = SourceForm.NowEmployeeNo.Text
        NowEmployeeName.Text = SourceForm.NowEmployeeName.Text

        SetMdiBackColor()

        If (Len(ChargeAmt.Text) = 0) Then
            ChargeAmt.Text = 0
        End If

        Dim charge_date As String = ""
        charge_date = DateTime.Now.ToString("yyyyMMdd")
        ChargeDate.Text = charge_date

        ChargeDate.ShortcutsEnabled = False  '不啟用快速鍵
        ChargeAmt.ShortcutsEnabled = False  '不啟用快速鍵

        AddHandler Cancel.MouseClick, AddressOf SourceForm.Restart_Click
    End Sub

    '按下離開鈕
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ChargeDate.Clear()
        ChargeRemark.Clear()
        ChargeAmt.Clear()
        Hide()
    End Sub

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
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

    '日期欄位限定只能輸入數字
    Private Sub ChargeDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChargeDate.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    '控管不得輸入 "-"及數字 以外的字元
    Private Sub ChargeAmt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChargeAmt.KeyUp
        Dim strLen As Integer = 0
        Dim strChargeAmt As String = ""
        Dim strChargeAmtFinal As String = ""
        strLen = Len(ChargeAmt.Text)
        strChargeAmt = ChargeAmt.Text

        If (strLen > 0) Then
            Try
                If Not (Char.IsDigit(ChargeAmt.Text)) Then
                    If (StrConv(ChargeAmt.Text.Substring(0, 1), vbNarrow) <> "-" And StrConv(ChargeAmt.Text.Substring(strLen - 1, 1), vbNarrow) <> "-") Then
                        strChargeAmtFinal = Replace(strChargeAmt, StrConv(ChargeAmt.Text.Substring(strLen - 1, 1), vbNarrow), "")
                        ChargeAmt.Text = strChargeAmtFinal
                    End If
                End If
            Catch ex As Exception
                ChargeAmt.Text = 0
            End Try
        End If
    End Sub

    '付款金額欄位非當前控制項時判斷是否為空，若為空則預設給0
    Private Sub ChargeAmt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargeAmt.Leave
        If (ChargeAmt.Text.Length = 0 Or StrConv(ChargeAmt.Text, vbNarrow) = "-") Then
            ChargeAmt.Text = 0
        End If
    End Sub

    '點選補帳金額欄位若為0則立即清空欄位數值
    Private Sub ChargeAmt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChargeAmt.MouseClick
        If (ChargeAmt.Text = 0) Then
            ChargeAmt.Clear()
        End If
    End Sub

    '按下確認補帳鈕
    Private Sub ConfirmFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmFill.Click
        If (ChargeDate.Text <> "" And ChargeRemark.Text <> "" And (ChargeAmt.Text <> "" And ChargeAmt.Text <> 0)) Then
            If (CheckDateTime(ChargeDate.Text)) Then
                Dim frm As New Form10
                frm.SourceForm = Me
                frm.ShowDialog()
            End If
        Else
            MsgBox("補帳失敗，請確認是否有尚未填寫的欄位")
        End If
    End Sub

    '按下查詢帳款鈕
    Private Sub CheckCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCharge.Click
        Dim frm As New Form5
        frm.SourceForm2 = Me
        frm.ShowDialog()
    End Sub

    '清帳統計表
    Private Sub ConfirmStatis_Click(sender As Object, e As EventArgs) Handles ConfirmStatis.Click
        Dim frm As New Form11
        frm.SourceForm = Me
        frm.ShowDialog()
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
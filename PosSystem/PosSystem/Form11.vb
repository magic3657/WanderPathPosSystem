Imports System.Data.SQLite

Public Class Form11
    Public Property SourceForm As Form9

    Private Sub SetMdiBackColor()
        Me.Controls(Me.Controls.Count - 1).BackColor = Me.BackColor
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMdiBackColor()

        '預設帶入起迄日期
        StartDate.Text = SourceForm.ChargeDate.Text.ToString
        EndDate.Text = SourceForm.ChargeDate.Text.ToString

        StatisData(StartDate.Text.ToString, EndDate.Text.ToString)
    End Sub

    '按下查詢鈕時進行統計
    Private Sub Query_Click(sender As Object, e As EventArgs) Handles Query.Click
        If CheckDateTime(StartDate.Text.ToString) And CheckDateTime(EndDate.Text.ToString) Then
            StatisData(StartDate.Text.ToString, EndDate.Text.ToString)
        End If
    End Sub

    '輸入起日控管
    Private Sub StartDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StartDate.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(13) Then
            EndDate.Focus()
        End If
    End Sub

    '輸入迄日控管及進行查詢
    Private Sub EndDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EndDate.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(13) Then
            StatisData(StartDate.Text.ToString, EndDate.Text.ToString)
        End If
    End Sub

    '進行統計
    Private Sub StatisData(form_start_date As String, form_end_date As String)
        Dim SqlStr As String = ""
        '總數量
        Dim qytTotal As Integer = 0
        '總金額
        Dim totalAmt As Integer = 0
        '總實收
        Dim paidAmt As Integer = 0
        '總折扣
        Dim discountAmt As Integer = 0

        '初始化金錢資訊
        QtyTotal.Text = 0
        AmtTotal.Text = 0
        DiscountTotal.Text = 0
        PaidTotal.Text = 0

        ShowDataView.Rows.Clear()

        Try
            SqlStr = ""
            SqlStr = "SELECT id id, price price, SUM(qty) qtySum, SUM(subtotal) subtotalSum FROM charged WHERE charge_no IN (SELECT charge_no FROM charge WHERE substr(charge_datetime, 0,9) >= '" & form_start_date & "' AND substr(charge_datetime, 0,9) <= '" & form_end_date & "' AND scrap_datetime = '" & "" & "')GROUP BY id, price ORDER BY type DESC;'"

            Dim oCmd As New SQLiteCommand(SqlStr, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                If (oDR("id") <> 0) Then
                    ShowDataView.Rows.Add(New String() {oDR("id"), "", "", oDR("qtySum"), oDR("price"), oDR("subtotalSum")})
                    '總數量
                    qytTotal += oDR("qtySum")
                End If
            End While

            For i As Integer = 0 To ShowDataView.RowCount - 2
                Dim oCmd2 As New SQLiteCommand("SELECT type, fullname FROM itemsetting WHERE id = '" & ShowDataView.Rows(i).Cells.Item("ShowId").Value() & "';'", oConn)
                Dim oDR2 As SQLiteDataReader = oCmd2.ExecuteReader()

                While oDR2.Read()
                    ShowDataView.Item(1, i).Value = GetTypeName(oDR2("type"))
                    ShowDataView.Item(2, i).Value = oDR2("fullname")
                End While
            Next i

            SqlStr = ""
            SqlStr = "SELECT SUBSTR(a.charge_datetime, 0, 9) charge_date, SUM(a.total_amt) sum_total_amt, SUM(a.paid_amt) sum_paid_amt, SUM(a.discount_amt) sum_discount_amt FROM charge a WHERE SUBSTR(a.charge_datetime, 0, 9) >=  '" & form_start_date & "' AND substr(charge_datetime, 0,9) <= '" & form_end_date & "' AND scrap_datetime = '" & "" & "' GROUP BY charge_date ORDER BY charge_date DESC;'"

            Dim oCmd3 As New SQLiteCommand(SqlStr, oConn)
            Dim oDR3 As SQLiteDataReader = oCmd3.ExecuteReader()

            While oDR3.Read()
                discountAmt += oDR3("sum_discount_amt")
                paidAmt += oDR3("sum_paid_amt")
                '總金額
                totalAmt += oDR3("sum_total_amt")
            End While

            '將金錢資訊放到畫面上顯示
            QtyTotal.Text = qytTotal
            AmtTotal.Text = totalAmt
            DiscountTotal.Text = discountAmt
            PaidTotal.Text = paidAmt
        Catch ex As Exception
            MsgBox("統計錯誤" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '按下回上一層
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        ShowDataView.Rows.Clear()
        Hide()
    End Sub

    '按下列印鈕
    Private Sub PrintData_Click(sender As Object, e As EventArgs) Handles PrintData.Click
        PrintOrder()
    End Sub

    '列印出單
    Private Sub PrintOrder()
        'form_print_type: Customer表示顧客聯 Employee表示廚房內場單
        Dim PrintPreviewDialog1 As PrintPreviewDialog = New PrintPreviewDialog
        Dim PrintDocument1 As Printing.PrintDocument = New Printing.PrintDocument
        PrintPreviewDialog1.Document = PrintDocument1
        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        PrintDocument1.Print()

    End Sub

    '清帳資訊
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim textOfFile As String = ""
        Dim textOfOrder As String = ""
        Dim tmpType As String = ""
        Dim meal_no As String = ""
        Dim spec_meal_no As String = ""
        Dim PrintDateTIme As String = ""
        Dim symbol As String = "-"
        Dim endArea As String = " "
        Dim pt As Char = " "

        PrintDateTIme = DateTime.Now.ToString("yyyy-MM-dd") & "  " & DateTime.Now.ToString("H:mm")
        '抬頭資訊
        textOfFile = "清帳日期: " & PrintDateTIme & vbCrLf

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(38, "-") & vbCrLf

        '點餐資訊
        For i As Integer = 0 To ShowDataView.RowCount - 2
            textOfOrder = ""
            If (String.IsNullOrEmpty(tmpType)) Then
                tmpType = ShowDataView.Rows(i).Cells.Item("ShowType").Value
                textOfOrder = textOfOrder & "《" & ShowDataView.Rows(i).Cells.Item("ShowType").Value & "》" & vbCrLf
            Else
                If (tmpType <> ShowDataView.Rows(i).Cells.Item("ShowType").Value) Then
                    textOfOrder = textOfOrder & vbCrLf
                    textOfOrder = textOfOrder & "《" & ShowDataView.Rows(i).Cells.Item("ShowType").Value & "》" & vbCrLf
                End If

                tmpType = ShowDataView.Rows(i).Cells.Item("ShowType").Value
            End If

            textOfOrder = textOfOrder & CheckPrintFullName(GetTypeId(ShowDataView.Rows(i).Cells.Item("ShowType").Value), ShowDataView.Rows(i).Cells.Item("ShowFullName").Value.ToString)
            textOfOrder = textOfOrder & ShowDataView.Rows(i).Cells.Item("ShowQty").Value.ToString.PadLeft(6 - Len(ShowDataView.Rows(i).Cells.Item("ShowQty").Value.ToString), pt)
            textOfOrder = textOfOrder & ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value.ToString.PadLeft(13 - Len(ShowDataView.Rows(i).Cells.Item("ShowSubTotal").Value.ToString), pt) & vbCrLf

            textOfFile = textOfFile & textOfOrder
        Next i

        '分隔線
        textOfFile = textOfFile & symbol.PadRight(38, "-") & vbCrLf

        '付款明細
        'endArea.PadRight(38, " ")
        If (CInt(DiscountTotal.Text) > 0) Then
            textOfFile = textOfFile & "總折扣: " & (DiscountTotal.Text).ToString.PadLeft(46 - Len((DiscountTotal.Text).ToString), pt) & vbCrLf
        End If

        textOfFile = textOfFile & "總實收: " & (PaidTotal.Text).ToString.PadLeft(46 - Len((PaidTotal.Text).ToString), pt) & vbCrLf

        e.Graphics.DrawString(textOfFile, New Font("微軟正黑體", 12, FontStyle.Bold), Brushes.Black, 0, 5, StringFormat.GenericTypographic)
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
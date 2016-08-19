Imports System.Data.SQLite
Imports OnBarcode.Barcode
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports WindowsApplication1.QREncrypter


Public Class Form_WorkOff
    Public Property SourceForm As Form_Seat
    Public execute As Boolean
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '取得登入者資訊
        WorkEmpNo.Text = nowLoginEmpNo
        WorkEmpName.Text = nowLoginEmpName

        '取得交班相關資訊
        GetInitailData()

        '畫面控制
        Me.Show()
        Application.DoEvents()
        WorkPaidAmt.Focus()

        'System.Diagnostics.Process.Start("cmd", "c:\Program Files\electric\tool\genKey.bat")

    End Sub

    '重新取得交班相關資訊
    Public Sub GetInitailData()
        Dim workDate As String = DateTime.Now.ToString("yyyyMMdd")
        Dim workTime As String = DateTime.Now.ToString("HHmm")

        '取得交班歷史紀錄
        getWorkOffChargeAll(workDate, workTime)

        '取得本次需要點清的帳款
        execute = getWorkAmt(workDate, workTime)
    End Sub


    '取得交班歷史紀錄
    Public Function getWorkOffChargeAll(formWorkDate As String, formWorkTime As String) As Boolean
        ShowDataView.Rows.Clear()
        Try
            Dim resultAll As New ArrayList
            Dim resultAllCount As Integer = 0

            resultAll = CheckOrQueryWorkOffCharge(formWorkDate, True)
            resultAllCount = resultAll.Count

            If Not (resultAllCount = 0) Then
                For i As Integer = 0 To resultAllCount - 1
                    '定義取出的欄位變數
                    Dim resultArray(8) As String
                    Dim resultWorkDate As String = ""
                    Dim resultWorkEmpNo As String = ""
                    Dim resultWorkEmpName As String = ""
                    Dim resultWorkAmt As String = ""
                    Dim resultWorkPaidAmt As String = ""
                    Dim resultWorkLostAmt As String = ""
                    Dim resultWorkTotalAmt As String = ""
                    Dim resultWorkTime As String = ""

                    '依序取出陣列資料
                    resultArray = resultAll(i)

                    '將資料取得並顯示於畫面
                    resultWorkDate = resultArray(0).ToString
                    resultWorkEmpNo = resultArray(1).ToString
                    resultWorkEmpName = resultArray(2).ToString
                    resultWorkAmt = resultArray(3).ToString
                    resultWorkPaidAmt = resultArray(4).ToString
                    resultWorkTotalAmt = resultArray(5).ToString
                    resultWorkLostAmt = resultArray(6).ToString

                    resultWorkTime = resultArray(7).ToString

                    ShowDataView.Rows.Add(New String() {"帶入", "明細", resultWorkDate, resultWorkEmpName, resultWorkAmt,
                                                        resultWorkPaidAmt, resultWorkLostAmt, resultWorkTotalAmt,
                                                        resultWorkTime})
                Next i
            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox("取得交班歷史紀錄錯誤" & vbCrLf & ex.GetBaseException.ToString)
            Return False
        End Try
    End Function

    '取得本次需要點清的帳款(並非當下累積全部金額,若非第一次點帳,則需要取得與前次的差額作為本次的點帳金額)
    Public Function getWorkAmt(formWorkDate As String, formWorkTime As String) As Boolean
        '顯示欄位初始
        WorkAmt.Text = 0
        WorkPaidAmt.Text = 0
        WorkTotalAmt.Text = 0


        '當日目前營收總金額
        Dim paidAmtSum As Integer = 0
        '本次要清點的點帳(應收)金額  [計算方式] 本次要清點的款項 = 當日目前營收總金額 - 點帳紀錄最後一次的應收總金額
        Dim workPaid As Integer = 0
        Try

            Dim oCmd As New SQLiteCommand("SELECT SUM(paid_amt) paidAmtSum FROM charge WHERE substr(charge_datetime, 0,9) = '" & formWorkDate & "' AND scrap_datetime = '" & "" & "';", oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                If (String.IsNullOrEmpty(oDR("paidAmtSum").ToString) = False) Then
                    paidAmtSum = oDR("paidAmtSum")
                End If

            End While

            '當日尚未有收費紀錄不得進行交班
            If (paidAmtSum = 0) Then
                MsgBox("本日尚未有收入帳, 無法進行交班")
                WorkAmt.Text = 0
                WorkPaidAmt.Text = 0
                WorkTotalAmt.Text = 0
                Return False
            Else
                '當前累計總金額
                WorkTotalAmt.Text = paidAmtSum.ToString

                '取得點帳紀錄最後一次的應收總金額
                Dim workData As New ArrayList
                Dim workDataCount As Integer = 0

                workData = CheckOrQueryWorkOffCharge(formWorkDate, False)

                workDataCount = workData.Count

                If (workDataCount = 0) Then
                    workPaid = paidAmtSum
                Else
                    Dim resultArray(2) As String
                    Dim resultWorkTotalAmt As Integer = 0
                    '取得點帳紀錄查詢結果(ArrayList workData中每一筆存放的都是一組陣列)
                    resultArray = workData(0)
                    'MsgBox(resultArray(1).ToString)
                    '取得點帳紀錄最後一次的應收總金額
                    resultWorkTotalAmt = Convert.ToInt32(resultArray(1).ToString)

                    workPaid = paidAmtSum - resultWorkTotalAmt
                End If
                '顯示於畫面上的點帳(應收)金額
                WorkAmt.Text = workPaid
            End If

            Return True
        Catch ex As Exception
            MsgBox("收費資料統計錯誤" & vbCrLf & ex.GetBaseException.ToString)
            WorkAmt.Text = 0
            WorkPaidAmt.Text = 0
            WorkTotalAmt.Text = 0
            Return False
        End Try
    End Function

    '取得當日點帳全部紀錄OR取得最近一次點帳的總金額
    Public Function CheckOrQueryWorkOffCharge(formWorkDate As String, formQueryAll As Boolean) As ArrayList
        Dim data As New ArrayList
        Dim querySql = ""
        If (CountWorkOffCharge(formWorkDate) > 0) Then
            If (formQueryAll) Then
                querySql = "SELECT work_date, work_emp_no, work_emp_name, work_amt, work_paid_amt, work_total_amt, work_lost_amt, work_time FROM workoffcharge WHERE work_date ='" & formWorkDate & "' ORDER BY work_time DESC;"
            Else
                querySql = "SELECT MAX(work_time) workTime, work_total_amt FROM workoffcharge WHERE work_date = '" & formWorkDate & "';"
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
                        dataArray(i) = oDR(i).ToString
                        'MsgBox(dataArray(i).ToString)
                    Next i

                    data.Add(dataArray)
                End While
                'MsgBox("[data count] " & data.Count.ToString)

            Catch ex As Exception
                MsgBox("[data Error - method: CheckOrQueryWorkOffCharge] ")
                data.Clear()
            End Try
        Else
            data.Clear()
        End If

        Return data
    End Function

    '取得當日點帳全部紀錄OR取得最近一次點帳的總金額
    Public Function CountWorkOffCharge(formWorkDate As String) As Integer

        Dim querySql = ""
        Dim count As Integer = 0

        querySql = "SELECT COUNT(1) count FROM workoffcharge WHERE work_date ='" & formWorkDate & "';"

        Try
            Dim oCmd As New SQLiteCommand(querySql, oConn)
            Dim oDR As SQLiteDataReader = oCmd.ExecuteReader()

            While oDR.Read()
                count = oDR(0)
            End While
            'MsgBox("[data count] " & data.Count.ToString)
        Catch ex As Exception
            Return 0
        End Try

        Return count
    End Function

    '寫入交班歷史記錄檔
    'formAdminFlag 定義為 該登入者使用權限,這裡設定的機制為: 登入失敗時此欄位寫入無效的權限值(X), 因為登入失敗的情況, 權限欄位並無意義.
    Public Sub InsertWorkOffCharge(formWorkDate As String, formWorkEmpNo As String, formWorkEmpName As String, formWorkAmt As Integer, formWorkPaidAmt As Integer, formWorkTotalAmt As Integer, formWorkLostAmt As Integer, formWorkTime As String)
        Try
            Dim oCmd As New SQLiteCommand("INSERT INTO workoffcharge (work_date, work_emp_no, work_emp_name, work_amt, work_paid_amt, work_total_amt, work_lost_amt, work_time) VALUES ('" & formWorkDate & "','" & formWorkEmpNo & "','" & formWorkEmpName & "','" & formWorkAmt & "','" & formWorkPaidAmt & "','" & formWorkTotalAmt & "','" & formWorkLostAmt & "','" & formWorkTime & "');", oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("寫入交班歷史記錄檔失敗" & vbCrLf & ex.GetBaseException.ToString)
        End Try
    End Sub

    '取消
    Private Sub No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No.Click
        Hide()
    End Sub

    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        executeWorkOffCharge()
    End Sub

    Private Sub executeWorkOffCharge()
        Try
            If (WorkAmt.Text = 0 Or
            WorkPaidAmt.Text = 0 Or
            WorkTotalAmt.Text = 0) Then
                MsgBox("資料不齊全無法進行交班" & vbCrLf & "原因:1.營收尚未增加 2.清點(實收)金額未填寫 3.本日尚未開始營業")
            Else
                If MessageBox.Show("是否確定要交班?? 此動作會進行清帳作業, 請確認後再執行!!!", "交班清帳確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'MsgBox("[開始點帳]")

                    Dim WorkDate As String = DateTime.Now.ToString("yyyyMMdd")
                    Dim WorkTime As String = DateTime.Now.ToString("HHmm")
                    Dim workLostAmt As Integer = 0
                    workLostAmt = Integer.Parse(WorkPaidAmt.Text) - Integer.Parse(WorkAmt.Text)
                    InsertWorkOffCharge(WorkDate, WorkEmpNo.Text, WorkEmpName.Text, Integer.Parse(WorkAmt.Text),
                                        Integer.Parse(WorkPaidAmt.Text), Integer.Parse(WorkTotalAmt.Text), workLostAmt,
                                        WorkTime)

                    'MsgBox("[點帳成功]")
                End If
            End If

            '重新取得交班相關資訊
            GetInitailData()
        Catch ex As Exception
            MsgBox("[點帳失敗]" & vbCrLf & ex.GetBaseException.ToString)

            '重新取得交班相關資訊
            GetInitailData()
        End Try
    End Sub


    Private Sub WorkPaidAmt_MouseClick(sender As Object, e As MouseEventArgs) Handles WorkPaidAmt.MouseClick
        Try
            If (WorkPaidAmt.Text = 0 Or String.IsNullOrEmpty(WorkPaidAmt.Text)) Then
                WorkPaidAmt.Clear()
            End If
        Catch ex As Exception
            WorkPaidAmt.Text = 0
        End Try
    End Sub

    Private Sub WorkPaidAmt_KeyDown(sender As Object, e As KeyEventArgs) Handles WorkPaidAmt.KeyDown
        If (e.KeyCode = 13) Then
            executeWorkOffCharge()
        End If
    End Sub

    Private Sub WorkPaidAmt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WorkPaidAmt.KeyPress

        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Public Shared Property CurrentDirectory As String

    Private Sub general_Click(sender As Object, e As EventArgs) Handles general.Click
        'create QRCode method A
        'If (genericQRCodeMethodA()) Then
        'MsgBox("產生QRCODE成功")
        'End If

        'create QRCode method B
        'Dim batFilePath As String = Environment.CurrentDirectory & "\qrfile\QRCode.bat"
        'MsgBox(batFilePath)
        'System.Diagnostics.Process.Start("cmd", "/k " & batFilePath)
        Sample.Main("JL89182138", 240)
    End Sub

    Public Function genericQRCodeMethodA() As Boolean
        Try
            Dim barcode As QRCode = New QRCode
            MsgBox(Environment.CurrentDirectory & "\qrfile\123.gif")
            ' QRCode Barcode Basic Settings

            '   QRCode Valid data char set:
            '         numeric data (digits 0 - 9);  
            '         alphanumeric data (digits 0 - 9; upper case letters A -Z;
            '         nine other characters: space, $ % * + - . / : );
            '         byte data (default: ISO/IEC 8859-1);
            '         Kanji(characters)
            barcode.Data = "112233445566"

            barcode.DataMode = QRCodeDataMode.Auto
            barcode.Version = QRCodeVersion.V1
            barcode.ECL = QRCodeECL.L

            '  Set the ProcessTilde property to true, if you want use the tilde character "~" 
            '  to specify special characters in the input data. Default is false.
            '
            '  1) 1-byte character: ~0dd/~1dd/~2dd (character value from 000 ~ 255);
            '       ASCII character '~' is presented by ~126;Strings from "~256" to "~299" are unused
            '       modified to FS, GS, RS and US respectively.
            '  2) 2-byte character (Unicode): ~6ddddd (character value from 00000 ~ 65535)
            '         Strings from "~665536" to "~699999" are unused
            '  3) for GS1 AI Code: 
            '         ~ai2: AI with 2 digits
            '         ~ai3: AI with 3 digits
            '         ~ai4: AI with 4 digits
            '         ~ai5: AI with 5 digits
            '         ~ai6: AI with 6 digits
            '         ~ai7: AI with 7 digits
            '  4) ECI: ~7dddddd (valid value of dddddd from 000000 to 999999)
            '  5) SJIS: from ~9ddddd (Shift JIS 0x8140 ~ 0x9FFC and 0xE040 ~ 0xEBBF)
            barcode.ProcessTilde = True

            ' Barcode Size Related Settings
            barcode.UOM = UnitOfMeasure.PIXEL
            barcode.X = 3
            barcode.LeftMargin = 0
            barcode.RightMargin = 0
            barcode.TopMargin = 0
            barcode.BottomMargin = 0
            barcode.Resolution = 96
            barcode.Rotate = Rotate.Rotate0

            ' Image format setting
            barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Gif()

            barcode.drawBarcode(Environment.CurrentDirectory & "\qrfile\123.gif")
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function


End Class
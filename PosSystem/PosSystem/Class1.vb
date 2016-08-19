Imports System
Imports System.Collections.Generic
Imports System.Text


Namespace QREncrypter
    Class Sample
        Shared Sub Main(ByVal number As String, ByVal totalamt As Integer)
            Dim qrEncrypter As com.tradevan.qrutil.QREncrypter = New com.tradevan.qrutil.QREncrypter()
            Try

                Dim abc()() As String = New String(1)() {}

                '發票字軌號
                Dim invoiceNumber As String = number
                '發票開立年月日(民國年月日 七碼)
                Dim dtNow = DateTime.Now
                Dim twC = New System.Globalization.TaiwanCalendar()
                Dim invoiceDate As String = twC.GetYear(dtNow).ToString + dtNow.ToString("MMdd")
                '發票開立時間(24小時制 共六碼 時時分分秒秒)
                Dim invoiceTime As String = DateTime.Now.ToString("HHmmss")
                '四位隨機碼(字串)
                Dim randomNumber As String = ""
                randomNumber = getRadomCode()
                '銷售額(需大於0)
                Dim salesAmount As Integer = 0
                '稅額(無法分離稅額填寫0)
                Dim taxAmount As Integer = 0
                '總計金額(含稅)
                Dim totalAmount As Integer = totalamt
                '買受人統編,若為一班消費者則填寫八碼0字串
                Dim buyerIdentifier As String = "00000000"
                '代表店統一編號,若無代表店則填寫八碼0字串
                Dim representIdentifier As String = "00000000"
                '銷售店統一編號
                Dim sellerIdentifier As String = "12345678"
                '總公司統一編號
                Dim businessIdentifier As String = "12345678"

                '產生77碼QRCODE字串
                Dim qrResult As String = qrEncrypter.QRCodeINV(invoiceNumber, invoiceDate, invoiceTime, randomNumber, salesAmount, taxAmount, totalAmount, buyerIdentifier, representIdentifier, sellerIdentifier, businessIdentifier, "7DE1747AA8613314C0C95ACCC5568911")
                Dim brResult As String = "10508" & number & randomNumber
                'MsgBox("[result]: " & result)

                '產生BARCODE  目前格式暫定為 民國年(3碼)+發票後月份(2碼)+發票號碼(10碼)+四碼隨機碼
                If (Not BarCodeGenerator(brResult)) Then
                    MsgBox("Creat BARCODE image ERROR")
                End If

                '產生QRCODE
                If (Not QRCodeGenerator(qrResult)) Then
                    MsgBox("Creat QRCODE image ERROR")
                End If

            Catch e As Exception
                Console.WriteLine(e.Message)
            End Try
            Console.ReadLine()
        End Sub

    End Class
End Namespace


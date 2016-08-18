Imports System
Imports System.Collections.Generic
Imports System.Text
Imports OnBarcode.Barcode

Namespace QREncrypter
    Class Sample
        Shared Sub Main(ByVal totalamt)
            Dim qrEncrypter As com.tradevan.qrutil.QREncrypter = New com.tradevan.qrutil.QREncrypter()
            Try

                Dim abc()() As String = New String(1)() {}

                '發票字軌號
                Dim invoiceNumber As String = "JL89182138"
                '發票開立年月日(民國年月日 七碼)
                Dim dtNow = DateTime.Now
                Dim twC = New System.Globalization.TaiwanCalendar()
                Dim invoiceDate As String = twC.GetYear(dtNow).ToString + dtNow.ToString("MMdd")
                '發票開立時間(24小時制 共六碼 時時分分秒秒)
                Dim invoiceTime As String = DateTime.Now.ToString("HHmmss")
                '四位隨機碼(字串)
                Dim randomNumber As String = ""
                '銷售額(無法分離稅額填寫0)
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

                Dim RndNum As New Random

                For i As Integer = 1 To 4
                    randomNumber = randomNumber & RndNum.Next(10).ToString
                Next i

                Dim result As String = qrEncrypter.QRCodeINV(invoiceNumber, invoiceDate, invoiceTime, randomNumber, salesAmount, taxAmount, totalAmount, buyerIdentifier, representIdentifier, sellerIdentifier, businessIdentifier, "7DE1747AA8613314C0C95ACCC5568911")

                MsgBox("[result]: " & result)

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
                    'barcode.Data = "112233445566"
                    barcode.Data = result

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

                End Try

            Catch e As Exception
                Console.WriteLine(e.Message)
            End Try
            Console.ReadLine()
        End Sub

    End Class
End Namespace


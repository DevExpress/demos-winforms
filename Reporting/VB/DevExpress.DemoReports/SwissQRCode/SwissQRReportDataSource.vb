Imports System.Collections.Generic

Namespace XtraReportsDemos.SwissQRCode

    Public Class BillDS

        Public Shared Function DataSource() As BillInfo
            Return New BillInfo() With {.BillDate = Date.Parse("2019.12.01"), .BillNumber = "1598/7", .Creditor = New PersonInfo() With {.Address = "Museumstrasse 258" & Microsoft.VisualBasic.Constants.vbLf & "2501 Biel", .Email = "h.schmid@schmid-workers.ch", .Website = "www.schmid-workers.ch", .Phone = "044 012 34 56", .Name = "Henri Schmid AG", .FullName = "Henri Schmid Service Switzerland AG"}, .Debtor = New PersonInfo() With {.Address = "Breitenrain 857" & Microsoft.VisualBasic.Constants.vbLf & "CH-2552 Orpund", .Name = "Ms. Rutschmann", .FullName = "Pia-Maria Rutschmann-Schnyder", .Phone = "", .Email = "", .Website = ""}, .QRBillData = New QRBillPaymentPartData() With {.Account = "CH44 4499 5599 0008 99901", .AdditionalInformation = "Order of 25.10.2019
##S1/01/20170309/11/10201409/20/14000000/22/36958/30/CH106017086/40/1020/41/3010", .ReferenceNumber = "21 0000 0000 3139 4004 3000 9017", .UltimateCreditor = "Henri Schmid Service Switzerland AG
Museumstrasse 258
CH - 2501 Biel", .Creditor = "Henri Schmid AG
Museumstrasse 258
CH - 2501 Biel", .Debtor = "Pia-Maria Rutschmann-Schnyder
Breitenrain 857
CH-2552 Orpund", .DueDate = Date.Parse("2019.12.31"), .QRCodeData = "SPC
0100
1
CH4444995599000899901
Henri Schmid AG
Museumstrasse
258
2501
Biel
CH
Henri Schmid Service Switzerland AG
Museumstrasse
258
2501
Biel
CH
8690
CHF
2019-12-31
Pia-Maria Rutschmann-Schnyder
Breitenrain
857
2552
Orpund
CH
QRR
210000000003139471430009017
Auftrag vom 25.10.2019##S1/01/20170309/11/10201409/20/14000/22/36958/30/CH10646546/40/1020/41/3010
UV1;1.1;1278564;1A-2F-43-AC-9B-33-21-B0-CC-D4-28-56;TCXVMKC22;2019-02-10T15:12:39; 2019-02-10T15:18:16
XY2;2a-2.2r;_R2-CH1_Conra1dCH-2074-1_3350_2019-03-13T10:23:47_16,919_0,00_0,00_0,00_0,00_+8FADt/DQ=_1==", .Currency = "CHF", .Amount = 8690, .Support = "Credit transfer"}, .BillItems = New List(Of BillItem)() From {New BillItem() With {.Description = "Repair swimming pool", .Amount = "40", .PricePerUnit = 105, .TotalPrice = 4200}, New BillItem() With {.Description = "Garden works", .Amount = "25", .PricePerUnit = 155, .TotalPrice = 3875}, New BillItem() With {.Description = "Repair water heater", .Amount = "5", .PricePerUnit = 55, .TotalPrice = 275}, New BillItem() With {.Description = "Repair & Replace Faucets", .Amount = "1", .PricePerUnit = 90, .TotalPrice = 90}, New BillItem() With {.Description = "House cleaning", .Amount = "10", .PricePerUnit = 25, .TotalPrice = 250}}}
        End Function
    End Class

    Public Class BillInfo

        Public Property QRBillData As QRBillPaymentPartData

        Public Property Debtor As PersonInfo

        Public Property Creditor As PersonInfo

        Public Property BillItems As List(Of BillItem)

        Public Property BillDate As Date

        Public Property BillNumber As String
    End Class

    Public Class BillItem

        Public Property Description As String

        Public Property Amount As String

        Public Property PricePerUnit As Single

        Public Property TotalPrice As Single
    End Class

    Public Class QRBillPaymentPartData

        Public Property Support As String

        Public Property QRCodeData As String

        Public Property Currency As String

        Public Property Amount As Single

        Public Property Account As String

        Public Property Creditor As String

        Public Property UltimateCreditor As String

        Public Property ReferenceNumber As String

        Public Property AdditionalInformation As String

        Public Property Debtor As String

        Public Property DueDate As Date
    End Class

    Public Class PersonInfo

        Public Property Name As String

        Public Property FullName As String

        Public Property Address As String

        Public Property Phone As String

        Public Property Email As String

        Public Property Website As String
    End Class
End Namespace

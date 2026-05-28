Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.VideoRent.Win.Reports
	Partial Public Class LatefeeReceipt
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal overdueReceipt As Receipt)
			Me.New()
			InitData(overdueReceipt)
		End Sub
		Private Sub InitData(ByVal overdueReceipt As Receipt)
			DataSource = overdueReceipt.OverdueRents
			xrlReceiptNumber.Text = String.Format("# {0:d8}", overdueReceipt.ReceiptId)
			xrlDate.Text = String.Format("({0:g})", overdueReceipt.Date)
			xrlDiscount.Text = String.Format("{0:c}", overdueReceipt.Discount)
			xrlPayment.Text = String.Format("{0:c}", overdueReceipt.Payment)
			xrlCustomerName.Text = overdueReceipt.Customer.FullName
			xrlCustomerAddress.Text = overdueReceipt.Customer.Address
			xrlCustomerPhone.Text = overdueReceipt.Customer.Phone
		End Sub
	End Class
End Namespace

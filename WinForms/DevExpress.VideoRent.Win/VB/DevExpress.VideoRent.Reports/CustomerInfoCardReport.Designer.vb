Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Reports
	Partial Public Class CustomerInfoCardReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim code128Generator1 As New DevExpress.XtraPrinting.BarCode.Code128Generator()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPanelCustomerInfoCard = New DevExpress.XtraReports.UI.XRPanel()
			Me.xrLabelDiscountLevel = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabelFullName = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPictBoxPhoto = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCustomerInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowBirthdayInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellBirthdayLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellBirthday = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowAddressInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellAddressLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellAddress = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowPhoneInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPhoneLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellPhone = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrBarCodeCustomerId = New DevExpress.XtraReports.UI.XRBarCode()
			Me.topMarginBand = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfoPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xpCollectionCustomers = New DevExpress.Xpo.XPCollection()
			CType(Me.xrTableCustomerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanelCustomerInfoCard})
			Me.Detail.HeightF = 222.5F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPanelCustomerInfoCard
			' 
			Me.xrPanelCustomerInfoCard.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.xrPanelCustomerInfoCard.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(144))))))
			Me.xrPanelCustomerInfoCard.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPanelCustomerInfoCard.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabelDiscountLevel, Me.xrLabelFullName, Me.xrPictBoxPhoto, Me.xrTableCustomerInfo, Me.xrBarCodeCustomerId})
			Me.xrPanelCustomerInfoCard.LocationFloat = New DevExpress.Utils.PointFloat(125F, 12.5F)
			Me.xrPanelCustomerInfoCard.Name = "xrPanelCustomerInfoCard"
			Me.xrPanelCustomerInfoCard.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F)
			Me.xrPanelCustomerInfoCard.SizeF = New System.Drawing.SizeF(500F, 210F)
			Me.xrPanelCustomerInfoCard.StylePriority.UseBackColor = False
			Me.xrPanelCustomerInfoCard.StylePriority.UseBorderColor = False
			Me.xrPanelCustomerInfoCard.StylePriority.UseBorders = False
			Me.xrPanelCustomerInfoCard.StylePriority.UsePadding = False
			' 
			' xrLabelDiscountLevel
			' 
			Me.xrLabelDiscountLevel.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabelDiscountLevel.CanGrow = False
			Me.xrLabelDiscountLevel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DiscountLevel")})
			Me.xrLabelDiscountLevel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrLabelDiscountLevel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(88))))), (CInt(Fix((CByte(72))))), (CInt(Fix((CByte(83))))))
			Me.xrLabelDiscountLevel.LocationFloat = New DevExpress.Utils.PointFloat(166F, 53.0001F)
			Me.xrLabelDiscountLevel.Name = "xrLabelDiscountLevel"
			Me.xrLabelDiscountLevel.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
			Me.xrLabelDiscountLevel.SizeF = New System.Drawing.SizeF(108.3333F, 14.66666F)
			Me.xrLabelDiscountLevel.StylePriority.UseBorders = False
			Me.xrLabelDiscountLevel.StylePriority.UseFont = False
			Me.xrLabelDiscountLevel.StylePriority.UseForeColor = False
			Me.xrLabelDiscountLevel.StylePriority.UsePadding = False
			Me.xrLabelDiscountLevel.Text = "xrLabelDiscountLevel"
			' 
			' xrLabelFullName
			' 
			Me.xrLabelFullName.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabelFullName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FullNameLastSorting")})
			Me.xrLabelFullName.Font = New DevExpress.Drawing.DXFont("Segoe UI", 12F)
			Me.xrLabelFullName.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(88))))), (CInt(Fix((CByte(72))))), (CInt(Fix((CByte(83))))))
			Me.xrLabelFullName.LocationFloat = New DevExpress.Utils.PointFloat(166F, 27F)
			Me.xrLabelFullName.Name = "xrLabelFullName"
			Me.xrLabelFullName.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
			Me.xrLabelFullName.SizeF = New System.Drawing.SizeF(182.2916F, 25.70834F)
			Me.xrLabelFullName.StylePriority.UseBorders = False
			Me.xrLabelFullName.StylePriority.UseFont = False
			Me.xrLabelFullName.StylePriority.UseForeColor = False
			Me.xrLabelFullName.StylePriority.UsePadding = False
			Me.xrLabelFullName.StylePriority.UseTextAlignment = False
			Me.xrLabelFullName.Text = "xrLabelFullName"
			Me.xrLabelFullName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrPictBoxPhoto
			' 
			Me.xrPictBoxPhoto.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(196))))))
			Me.xrPictBoxPhoto.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(144))))))
			Me.xrPictBoxPhoto.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPictBoxPhoto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Photo")})
			Me.xrPictBoxPhoto.LocationFloat = New DevExpress.Utils.PointFloat(15F, 15F)
			Me.xrPictBoxPhoto.Name = "xrPictBoxPhoto"
			Me.xrPictBoxPhoto.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 100F)
			Me.xrPictBoxPhoto.SizeF = New System.Drawing.SizeF(140F, 180F)
			Me.xrPictBoxPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
			Me.xrPictBoxPhoto.StylePriority.UseBackColor = False
			Me.xrPictBoxPhoto.StylePriority.UseBorderColor = False
			Me.xrPictBoxPhoto.StylePriority.UseBorders = False
			Me.xrPictBoxPhoto.StylePriority.UsePadding = False
'			Me.xrPictBoxPhoto.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrPictBoxPhoto_BeforePrint);
			' 
			' xrTableCustomerInfo
			' 
			Me.xrTableCustomerInfo.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.xrTableCustomerInfo.Borders = DevExpress.XtraPrinting.BorderSide.Right
			Me.xrTableCustomerInfo.Font = New DevExpress.Drawing.DXFont("Verdana", 11.25F)
			Me.xrTableCustomerInfo.LocationFloat = New DevExpress.Utils.PointFloat(155F, 79.37502F)
			Me.xrTableCustomerInfo.Name = "xrTableCustomerInfo"
			Me.xrTableCustomerInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowBirthdayInfo, Me.xrTableRowAddressInfo, Me.xrTableRowPhoneInfo})
			Me.xrTableCustomerInfo.SizeF = New System.Drawing.SizeF(343F, 100F)
			Me.xrTableCustomerInfo.StylePriority.UseBackColor = False
			Me.xrTableCustomerInfo.StylePriority.UseBorders = False
			Me.xrTableCustomerInfo.StylePriority.UseFont = False
			' 
			' xrTableRowBirthdayInfo
			' 
			Me.xrTableRowBirthdayInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellBirthdayLabel, Me.xrTableCellBirthday})
			Me.xrTableRowBirthdayInfo.Name = "xrTableRowBirthdayInfo"
			Me.xrTableRowBirthdayInfo.Weight = 0.55990991683711044
			' 
			' xrTableCellBirthdayLabel
			' 
			Me.xrTableCellBirthdayLabel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(182))))))
			Me.xrTableCellBirthdayLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellBirthdayLabel.CanGrow = False
			Me.xrTableCellBirthdayLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8F)
			Me.xrTableCellBirthdayLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(101))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(95))))))
			Me.xrTableCellBirthdayLabel.Name = "xrTableCellBirthdayLabel"
			Me.xrTableCellBirthdayLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 0, 0, 0, 100F)
			Me.xrTableCellBirthdayLabel.StylePriority.UseBackColor = False
			Me.xrTableCellBirthdayLabel.StylePriority.UseBorders = False
			Me.xrTableCellBirthdayLabel.StylePriority.UseFont = False
			Me.xrTableCellBirthdayLabel.StylePriority.UseForeColor = False
			Me.xrTableCellBirthdayLabel.StylePriority.UsePadding = False
			Me.xrTableCellBirthdayLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellBirthdayLabel.Text = "Birthdate:"
			Me.xrTableCellBirthdayLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellBirthdayLabel.Weight = 0.7152040187714277
			' 
			' xrTableCellBirthday
			' 
			Me.xrTableCellBirthday.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(182))))))
			Me.xrTableCellBirthday.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.xrTableCellBirthday.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellBirthday.CanGrow = False
			Me.xrTableCellBirthday.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BirthDate", "{0:d}")})
			Me.xrTableCellBirthday.Font = New DevExpress.Drawing.DXFont("Verdana", 8.25F)
			Me.xrTableCellBirthday.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(88))))), (CInt(Fix((CByte(72))))), (CInt(Fix((CByte(83))))))
			Me.xrTableCellBirthday.Multiline = True
			Me.xrTableCellBirthday.Name = "xrTableCellBirthday"
			Me.xrTableCellBirthday.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 100F)
			Me.xrTableCellBirthday.StylePriority.UseBackColor = False
			Me.xrTableCellBirthday.StylePriority.UseBorderColor = False
			Me.xrTableCellBirthday.StylePriority.UseBorders = False
			Me.xrTableCellBirthday.StylePriority.UseFont = False
			Me.xrTableCellBirthday.StylePriority.UseForeColor = False
			Me.xrTableCellBirthday.StylePriority.UsePadding = False
			Me.xrTableCellBirthday.StylePriority.UseTextAlignment = False
			Me.xrTableCellBirthday.Text = "xrTableCellBirthday"
			Me.xrTableCellBirthday.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCellBirthday.Weight = 2.2847959812285721
			' 
			' xrTableRowAddressInfo
			' 
			Me.xrTableRowAddressInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellAddressLabel, Me.xrTableCellAddress})
			Me.xrTableRowAddressInfo.Name = "xrTableRowAddressInfo"
			Me.xrTableRowAddressInfo.Weight = 0.55990991683711044
			' 
			' xrTableCellAddressLabel
			' 
			Me.xrTableCellAddressLabel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.xrTableCellAddressLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellAddressLabel.CanGrow = False
			Me.xrTableCellAddressLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellAddressLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(101))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(95))))))
			Me.xrTableCellAddressLabel.Name = "xrTableCellAddressLabel"
			Me.xrTableCellAddressLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 0, 0, 0, 100F)
			Me.xrTableCellAddressLabel.StylePriority.UseBackColor = False
			Me.xrTableCellAddressLabel.StylePriority.UseBorders = False
			Me.xrTableCellAddressLabel.StylePriority.UseFont = False
			Me.xrTableCellAddressLabel.StylePriority.UseForeColor = False
			Me.xrTableCellAddressLabel.StylePriority.UsePadding = False
			Me.xrTableCellAddressLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellAddressLabel.Text = "Phone"
			Me.xrTableCellAddressLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellAddressLabel.Weight = 0.7152040187714277
			' 
			' xrTableCellAddress
			' 
			Me.xrTableCellAddress.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.xrTableCellAddress.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.xrTableCellAddress.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellAddress.CanGrow = False
			Me.xrTableCellAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Phone")})
			Me.xrTableCellAddress.Font = New DevExpress.Drawing.DXFont("Verdana", 8.25F)
			Me.xrTableCellAddress.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(88))))), (CInt(Fix((CByte(72))))), (CInt(Fix((CByte(83))))))
			Me.xrTableCellAddress.Multiline = True
			Me.xrTableCellAddress.Name = "xrTableCellAddress"
			Me.xrTableCellAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 100F)
			Me.xrTableCellAddress.StylePriority.UseBackColor = False
			Me.xrTableCellAddress.StylePriority.UseBorderColor = False
			Me.xrTableCellAddress.StylePriority.UseBorders = False
			Me.xrTableCellAddress.StylePriority.UseFont = False
			Me.xrTableCellAddress.StylePriority.UseForeColor = False
			Me.xrTableCellAddress.StylePriority.UsePadding = False
			Me.xrTableCellAddress.StylePriority.UseTextAlignment = False
			Me.xrTableCellAddress.Text = "xrTableCellAddress"
			Me.xrTableCellAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCellAddress.Weight = 2.2847959812285721
			' 
			' xrTableRowPhoneInfo
			' 
			Me.xrTableRowPhoneInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPhoneLabel, Me.xrTableCellPhone})
			Me.xrTableRowPhoneInfo.Name = "xrTableRowPhoneInfo"
			Me.xrTableRowPhoneInfo.Weight = 1.1198198336742209
			' 
			' xrTableCellPhoneLabel
			' 
			Me.xrTableCellPhoneLabel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(182))))))
			Me.xrTableCellPhoneLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellPhoneLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(101))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(95))))))
			Me.xrTableCellPhoneLabel.Name = "xrTableCellPhoneLabel"
			Me.xrTableCellPhoneLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 0, 5, 0, 100F)
			Me.xrTableCellPhoneLabel.StylePriority.UseBackColor = False
			Me.xrTableCellPhoneLabel.StylePriority.UseBorders = False
			Me.xrTableCellPhoneLabel.StylePriority.UseFont = False
			Me.xrTableCellPhoneLabel.StylePriority.UseForeColor = False
			Me.xrTableCellPhoneLabel.StylePriority.UsePadding = False
			Me.xrTableCellPhoneLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellPhoneLabel.Text = "Address:"
			Me.xrTableCellPhoneLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCellPhoneLabel.Weight = 0.7152040187714277
			' 
			' xrTableCellPhone
			' 
			Me.xrTableCellPhone.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(182))))))
			Me.xrTableCellPhone.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.xrTableCellPhone.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellPhone.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Address")})
			Me.xrTableCellPhone.Font = New DevExpress.Drawing.DXFont("Verdana", 8.25F)
			Me.xrTableCellPhone.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(88))))), (CInt(Fix((CByte(72))))), (CInt(Fix((CByte(83))))))
			Me.xrTableCellPhone.Multiline = True
			Me.xrTableCellPhone.Name = "xrTableCellPhone"
			Me.xrTableCellPhone.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 100F)
			Me.xrTableCellPhone.StylePriority.UseBackColor = False
			Me.xrTableCellPhone.StylePriority.UseBorderColor = False
			Me.xrTableCellPhone.StylePriority.UseBorders = False
			Me.xrTableCellPhone.StylePriority.UseFont = False
			Me.xrTableCellPhone.StylePriority.UseForeColor = False
			Me.xrTableCellPhone.StylePriority.UsePadding = False
			Me.xrTableCellPhone.StylePriority.UseTextAlignment = False
			Me.xrTableCellPhone.Text = "xrTableCellPhone"
			Me.xrTableCellPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCellPhone.Weight = 2.2847959812285721
			' 
			' xrBarCodeCustomerId
			' 
			Me.xrBarCodeCustomerId.AutoModule = True
			Me.xrBarCodeCustomerId.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrBarCodeCustomerId.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8F)
			Me.xrBarCodeCustomerId.LocationFloat = New DevExpress.Utils.PointFloat(360F, 14.99999F)
			Me.xrBarCodeCustomerId.Name = "xrBarCodeCustomerId"
			Me.xrBarCodeCustomerId.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrBarCodeCustomerId.SizeF = New System.Drawing.SizeF(127F, 52F)
			Me.xrBarCodeCustomerId.StylePriority.UseBorders = False
			Me.xrBarCodeCustomerId.StylePriority.UseFont = False
			Me.xrBarCodeCustomerId.StylePriority.UsePadding = False
			Me.xrBarCodeCustomerId.StylePriority.UseTextAlignment = False
			Me.xrBarCodeCustomerId.Symbology = code128Generator1
			Me.xrBarCodeCustomerId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
'			Me.xrBarCodeCustomerId.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrBarCodeCustomer_BeforePrint);
			' 
			' topMarginBand
			' 
			Me.topMarginBand.HeightF = 22F
			Me.topMarginBand.Name = "topMarginBand"
			' 
			' bottomMarginBand
			' 
			Me.bottomMarginBand.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfoPageCount})
			Me.bottomMarginBand.HeightF = 35F
			Me.bottomMarginBand.Name = "bottomMarginBand"
			' 
			' xrPageInfoPageCount
			' 
			Me.xrPageInfoPageCount.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrPageInfoPageCount.LocationFloat = New DevExpress.Utils.PointFloat(649F, 2.000014F)
			Me.xrPageInfoPageCount.Name = "xrPageInfoPageCount"
			Me.xrPageInfoPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfoPageCount.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrPageInfoPageCount.StylePriority.UseFont = False
			Me.xrPageInfoPageCount.StylePriority.UseTextAlignment = False
			Me.xrPageInfoPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xpCollectionCustomers
			' 
			Me.xpCollectionCustomers.ObjectType = GetType(DevExpress.VideoRent.Customer)
			Me.xpCollectionCustomers.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
'			Me.xpCollectionCustomers.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionCustomers_ResolveSession);
			' 
			' CustomerInfoCardReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand, Me.bottomMarginBand})
			Me.DataSource = Me.xpCollectionCustomers
			Me.Margins = New DevExpress.Drawing.DXMargins(51, 50, 22, 35)
			Me.Version = "10.2"
			CType(Me.xrTableCustomerInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrPanelCustomerInfoCard As DevExpress.XtraReports.UI.XRPanel
		Private WithEvents xrPictBoxPhoto As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableCustomerInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowBirthdayInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellBirthdayLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellBirthday As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowAddressInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellAddressLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowPhoneInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPhoneLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellPhone As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrBarCodeCustomerId As DevExpress.XtraReports.UI.XRBarCode
		Private WithEvents xpCollectionCustomers As DevExpress.Xpo.XPCollection
		Private xrPageInfoPageCount As DevExpress.XtraReports.UI.XRPageInfo
		Private xrTableCellAddress As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabelDiscountLevel As DevExpress.XtraReports.UI.XRLabel
		Private xrLabelFullName As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace

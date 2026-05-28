Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Reports
	Partial Public Class ActiveCustomersListReport
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
			Me.DetailCustomer = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTableActiveCustomers = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowActiveCustomersInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPhoto = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBoxPhoto = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCellCustomerInfo = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCustomerInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowCustomerInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellFullName = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellDiscountLevel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowBirthDate = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellBirthDate = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowContacts = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellEmail = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellPhone = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowAddress = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellAddress = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellRentsCount = New DevExpress.XtraReports.UI.XRTableCell()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrTableActiveCustomersHeaders = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowColumnHeaders = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPhotoColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellFullNameColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellRentsCountColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.topMarginBand = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfoPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabelHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.xpCollectionCustomers = New DevExpress.Xpo.XPCollection()
			Me.calcFieldCustomerReceiptsCount = New DevExpress.XtraReports.UI.CalculatedField()
			CType(Me.xrTableActiveCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTableCustomerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTableActiveCustomersHeaders, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' DetailCustomer
			' 
			Me.DetailCustomer.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableActiveCustomers})
			Me.DetailCustomer.HeightF = 125F
			Me.DetailCustomer.Name = "DetailCustomer"
			Me.DetailCustomer.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.DetailCustomer.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("calcFieldCustomerReceiptsCount", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
			Me.DetailCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableActiveCustomers
			' 
			Me.xrTableActiveCustomers.BorderColor = System.Drawing.Color.White
			Me.xrTableActiveCustomers.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableActiveCustomers.Font = New DevExpress.Drawing.DXFont("Calibri", 12F)
			Me.xrTableActiveCustomers.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTableActiveCustomers.Name = "xrTableActiveCustomers"
			Me.xrTableActiveCustomers.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowActiveCustomersInfo})
			Me.xrTableActiveCustomers.SizeF = New System.Drawing.SizeF(650F, 125F)
			Me.xrTableActiveCustomers.StylePriority.UseBorderColor = False
			Me.xrTableActiveCustomers.StylePriority.UseBorders = False
			Me.xrTableActiveCustomers.StylePriority.UseFont = False
			' 
			' xrTableRowActiveCustomersInfo
			' 
			Me.xrTableRowActiveCustomersInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPhoto, Me.xrTableCellCustomerInfo, Me.xrTableCellRentsCount})
			Me.xrTableRowActiveCustomersInfo.Name = "xrTableRowActiveCustomersInfo"
			Me.xrTableRowActiveCustomersInfo.Weight = 1
			' 
			' xrTableCellPhoto
			' 
			Me.xrTableCellPhoto.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellPhoto.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBoxPhoto})
			Me.xrTableCellPhoto.Name = "xrTableCellPhoto"
			Me.xrTableCellPhoto.StylePriority.UseBorders = False
			Me.xrTableCellPhoto.StylePriority.UseTextAlignment = False
			Me.xrTableCellPhoto.Text = "xrTableCellPhoto"
			Me.xrTableCellPhoto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellPhoto.Weight = 0.49134635338416455
			' 
			' xrPictureBoxPhoto
			' 
			Me.xrPictureBoxPhoto.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(196))))), (CInt(Fix((CByte(220))))), (CInt(Fix((CByte(182))))))
			Me.xrPictureBoxPhoto.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPictureBoxPhoto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Photo")})
			Me.xrPictureBoxPhoto.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPictureBoxPhoto.Name = "xrPictureBoxPhoto"
			Me.xrPictureBoxPhoto.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F)
			Me.xrPictureBoxPhoto.SizeF = New System.Drawing.SizeF(106.4584F, 125F)
			Me.xrPictureBoxPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
			Me.xrPictureBoxPhoto.StylePriority.UseBackColor = False
			Me.xrPictureBoxPhoto.StylePriority.UseBorders = False
			Me.xrPictureBoxPhoto.StylePriority.UsePadding = False
'			Me.xrPictureBoxPhoto.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrPictureBoxPhoto_BeforePrint);
			' 
			' xrTableCellCustomerInfo
			' 
			Me.xrTableCellCustomerInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellCustomerInfo.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableCustomerInfo})
			Me.xrTableCellCustomerInfo.Font = New DevExpress.Drawing.DXFont("Verdana", 9.75F)
			Me.xrTableCellCustomerInfo.Name = "xrTableCellCustomerInfo"
			Me.xrTableCellCustomerInfo.StylePriority.UseBorders = False
			Me.xrTableCellCustomerInfo.StylePriority.UseFont = False
			Me.xrTableCellCustomerInfo.StylePriority.UseTextAlignment = False
			Me.xrTableCellCustomerInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellCustomerInfo.Weight = 2.0278844158466045
			' 
			' xrTableCustomerInfo
			' 
			Me.xrTableCustomerInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCustomerInfo.LocationFloat = New DevExpress.Utils.PointFloat(3.814697E-05F, 0F)
			Me.xrTableCustomerInfo.Name = "xrTableCustomerInfo"
			Me.xrTableCustomerInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowCustomerInfo, Me.xrTableRowBirthDate, Me.xrTableRowContacts, Me.xrTableRowAddress})
			Me.xrTableCustomerInfo.SizeF = New System.Drawing.SizeF(439.3749F, 125F)
			Me.xrTableCustomerInfo.StylePriority.UseBorders = False
			' 
			' xrTableRowCustomerInfo
			' 
			Me.xrTableRowCustomerInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellFullName, Me.xrTableCellDiscountLevel})
			Me.xrTableRowCustomerInfo.Name = "xrTableRowCustomerInfo"
			Me.xrTableRowCustomerInfo.Weight = 0.65749233708776544
			' 
			' xrTableCellFullName
			' 
			Me.xrTableCellFullName.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(196))))), (CInt(Fix((CByte(220))))), (CInt(Fix((CByte(182))))))
			Me.xrTableCellFullName.BorderColor = System.Drawing.Color.White
			Me.xrTableCellFullName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCellFullName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FullNameLastSorting")})
			Me.xrTableCellFullName.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
			Me.xrTableCellFullName.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(52))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(49))))))
			Me.xrTableCellFullName.Name = "xrTableCellFullName"
			Me.xrTableCellFullName.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
			Me.xrTableCellFullName.StylePriority.UseBackColor = False
			Me.xrTableCellFullName.StylePriority.UseBorderColor = False
			Me.xrTableCellFullName.StylePriority.UseBorders = False
			Me.xrTableCellFullName.StylePriority.UseFont = False
			Me.xrTableCellFullName.StylePriority.UseForeColor = False
			Me.xrTableCellFullName.StylePriority.UsePadding = False
			Me.xrTableCellFullName.StylePriority.UseTextAlignment = False
			Me.xrTableCellFullName.Text = "xrTableCellFullName"
			Me.xrTableCellFullName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellFullName.Weight = 1.8739841368140242
			' 
			' xrTableCellDiscountLevel
			' 
			Me.xrTableCellDiscountLevel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(196))))), (CInt(Fix((CByte(220))))), (CInt(Fix((CByte(182))))))
			Me.xrTableCellDiscountLevel.BorderColor = System.Drawing.Color.White
			Me.xrTableCellDiscountLevel.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellDiscountLevel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DiscountLevel")})
			Me.xrTableCellDiscountLevel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
			Me.xrTableCellDiscountLevel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(52))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(49))))))
			Me.xrTableCellDiscountLevel.Name = "xrTableCellDiscountLevel"
			Me.xrTableCellDiscountLevel.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
			Me.xrTableCellDiscountLevel.StylePriority.UseBackColor = False
			Me.xrTableCellDiscountLevel.StylePriority.UseBorderColor = False
			Me.xrTableCellDiscountLevel.StylePriority.UseBorders = False
			Me.xrTableCellDiscountLevel.StylePriority.UseFont = False
			Me.xrTableCellDiscountLevel.StylePriority.UseForeColor = False
			Me.xrTableCellDiscountLevel.StylePriority.UsePadding = False
			Me.xrTableCellDiscountLevel.StylePriority.UseTextAlignment = False
			Me.xrTableCellDiscountLevel.Text = "[DiscountLevel]"
			Me.xrTableCellDiscountLevel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellDiscountLevel.Weight = 1.1260158631859758
			' 
			' xrTableRowBirthDate
			' 
			Me.xrTableRowBirthDate.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellBirthDate})
			Me.xrTableRowBirthDate.Name = "xrTableRowBirthDate"
			Me.xrTableRowBirthDate.Weight = 0.65749239345051447
			' 
			' xrTableCellBirthDate
			' 
			Me.xrTableCellBirthDate.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellBirthDate.BorderColor = System.Drawing.Color.White
			Me.xrTableCellBirthDate.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellBirthDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BirthDate", "{0:d}")})
			Me.xrTableCellBirthDate.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellBirthDate.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(111))))), (CInt(Fix((CByte(116))))), (CInt(Fix((CByte(106))))))
			Me.xrTableCellBirthDate.Multiline = True
			Me.xrTableCellBirthDate.Name = "xrTableCellBirthDate"
			Me.xrTableCellBirthDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
			Me.xrTableCellBirthDate.StylePriority.UseBackColor = False
			Me.xrTableCellBirthDate.StylePriority.UseBorderColor = False
			Me.xrTableCellBirthDate.StylePriority.UseBorders = False
			Me.xrTableCellBirthDate.StylePriority.UseFont = False
			Me.xrTableCellBirthDate.StylePriority.UseForeColor = False
			Me.xrTableCellBirthDate.StylePriority.UsePadding = False
			Me.xrTableCellBirthDate.StylePriority.UseTextAlignment = False
			Me.xrTableCellBirthDate.Text = "xrTableCellBirthDate"
			Me.xrTableCellBirthDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellBirthDate.Weight = 3
			' 
			' xrTableRowContacts
			' 
			Me.xrTableRowContacts.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellEmail, Me.xrTableCellPhone})
			Me.xrTableRowContacts.Name = "xrTableRowContacts"
			Me.xrTableRowContacts.Weight = 0.65749230973854911
			' 
			' xrTableCellEmail
			' 
			Me.xrTableCellEmail.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellEmail.BorderColor = System.Drawing.Color.White
			Me.xrTableCellEmail.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCellEmail.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Email")})
			Me.xrTableCellEmail.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellEmail.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(111))))), (CInt(Fix((CByte(116))))), (CInt(Fix((CByte(106))))))
			Me.xrTableCellEmail.Name = "xrTableCellEmail"
			Me.xrTableCellEmail.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
			Me.xrTableCellEmail.StylePriority.UseBackColor = False
			Me.xrTableCellEmail.StylePriority.UseBorderColor = False
			Me.xrTableCellEmail.StylePriority.UseBorders = False
			Me.xrTableCellEmail.StylePriority.UseFont = False
			Me.xrTableCellEmail.StylePriority.UseForeColor = False
			Me.xrTableCellEmail.StylePriority.UsePadding = False
			Me.xrTableCellEmail.StylePriority.UseTextAlignment = False
			Me.xrTableCellEmail.Text = "xrTableCellEmail"
			Me.xrTableCellEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellEmail.Weight = 1.8739841368140244
			' 
			' xrTableCellPhone
			' 
			Me.xrTableCellPhone.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellPhone.BorderColor = System.Drawing.Color.White
			Me.xrTableCellPhone.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellPhone.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Phone")})
			Me.xrTableCellPhone.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellPhone.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(111))))), (CInt(Fix((CByte(116))))), (CInt(Fix((CByte(106))))))
			Me.xrTableCellPhone.Name = "xrTableCellPhone"
			Me.xrTableCellPhone.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
			Me.xrTableCellPhone.StylePriority.UseBackColor = False
			Me.xrTableCellPhone.StylePriority.UseBorderColor = False
			Me.xrTableCellPhone.StylePriority.UseBorders = False
			Me.xrTableCellPhone.StylePriority.UseFont = False
			Me.xrTableCellPhone.StylePriority.UseForeColor = False
			Me.xrTableCellPhone.StylePriority.UsePadding = False
			Me.xrTableCellPhone.StylePriority.UseTextAlignment = False
			Me.xrTableCellPhone.Text = "xrTableCellPhone"
			Me.xrTableCellPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellPhone.Weight = 1.1260158631859756
			' 
			' xrTableRowAddress
			' 
			Me.xrTableRowAddress.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellAddress})
			Me.xrTableRowAddress.Name = "xrTableRowAddress"
			Me.xrTableRowAddress.Weight = 1.577981644667604
			' 
			' xrTableCellAddress
			' 
			Me.xrTableCellAddress.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellAddress.BorderColor = System.Drawing.Color.White
			Me.xrTableCellAddress.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Address")})
			Me.xrTableCellAddress.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellAddress.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(111))))), (CInt(Fix((CByte(116))))), (CInt(Fix((CByte(106))))))
			Me.xrTableCellAddress.Name = "xrTableCellAddress"
			Me.xrTableCellAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F)
			Me.xrTableCellAddress.StylePriority.UseBackColor = False
			Me.xrTableCellAddress.StylePriority.UseBorderColor = False
			Me.xrTableCellAddress.StylePriority.UseBorders = False
			Me.xrTableCellAddress.StylePriority.UseFont = False
			Me.xrTableCellAddress.StylePriority.UseForeColor = False
			Me.xrTableCellAddress.StylePriority.UsePadding = False
			Me.xrTableCellAddress.StylePriority.UseTextAlignment = False
			Me.xrTableCellAddress.Text = "xrTableCellAddress"
			Me.xrTableCellAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCellAddress.Weight = 3
			' 
			' xrTableCellRentsCount
			' 
			Me.xrTableCellRentsCount.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(201))))))
			Me.xrTableCellRentsCount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCellRentsCount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "calcFieldCustomerReceiptsCount")})
			Me.xrTableCellRentsCount.Font = New DevExpress.Drawing.DXFont("Segoe UI", 27.75F)
			Me.xrTableCellRentsCount.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(80))))), (CInt(Fix((CByte(92))))), (CInt(Fix((CByte(87))))))
			Me.xrTableCellRentsCount.Name = "xrTableCellRentsCount"
			Me.xrTableCellRentsCount.StylePriority.UseBackColor = False
			Me.xrTableCellRentsCount.StylePriority.UseBorders = False
			Me.xrTableCellRentsCount.StylePriority.UseFont = False
			Me.xrTableCellRentsCount.StylePriority.UseForeColor = False
			Me.xrTableCellRentsCount.StylePriority.UseTextAlignment = False
			Me.xrTableCellRentsCount.Text = "xrTableCellRentsCount"
			Me.xrTableCellRentsCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellRentsCount.Weight = 0.48076923076923073
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableActiveCustomersHeaders})
			Me.PageHeader.HeightF = 31.04167F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableActiveCustomersHeaders
			' 
			Me.xrTableActiveCustomersHeaders.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
			Me.xrTableActiveCustomersHeaders.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(122))))), (CInt(Fix((CByte(110))))))
			Me.xrTableActiveCustomersHeaders.BorderColor = System.Drawing.Color.White
			Me.xrTableActiveCustomersHeaders.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableActiveCustomersHeaders.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
			Me.xrTableActiveCustomersHeaders.ForeColor = System.Drawing.Color.White
			Me.xrTableActiveCustomersHeaders.LocationFloat = New DevExpress.Utils.PointFloat(0F, 1.041666F)
			Me.xrTableActiveCustomersHeaders.Name = "xrTableActiveCustomersHeaders"
			Me.xrTableActiveCustomersHeaders.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowColumnHeaders})
			Me.xrTableActiveCustomersHeaders.SizeF = New System.Drawing.SizeF(650F, 30F)
			Me.xrTableActiveCustomersHeaders.StylePriority.UseBackColor = False
			Me.xrTableActiveCustomersHeaders.StylePriority.UseBorderColor = False
			Me.xrTableActiveCustomersHeaders.StylePriority.UseBorders = False
			Me.xrTableActiveCustomersHeaders.StylePriority.UseFont = False
			Me.xrTableActiveCustomersHeaders.StylePriority.UseForeColor = False
			' 
			' xrTableRowColumnHeaders
			' 
			Me.xrTableRowColumnHeaders.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPhotoColumnHeader, Me.xrTableCellFullNameColumnHeader, Me.xrTableCellRentsCountColumnHeader})
			Me.xrTableRowColumnHeaders.Name = "xrTableRowColumnHeaders"
			Me.xrTableRowColumnHeaders.Weight = 1
			' 
			' xrTableCellPhotoColumnHeader
			' 
			Me.xrTableCellPhotoColumnHeader.CanGrow = False
			Me.xrTableCellPhotoColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellPhotoColumnHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(212))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(217))))))
			Me.xrTableCellPhotoColumnHeader.Name = "xrTableCellPhotoColumnHeader"
			Me.xrTableCellPhotoColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellPhotoColumnHeader.StylePriority.UseForeColor = False
			Me.xrTableCellPhotoColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellPhotoColumnHeader.Text = "Photo"
			Me.xrTableCellPhotoColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellPhotoColumnHeader.Weight = 0.49134638859675472
			' 
			' xrTableCellFullNameColumnHeader
			' 
			Me.xrTableCellFullNameColumnHeader.CanGrow = False
			Me.xrTableCellFullNameColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellFullNameColumnHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(212))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(217))))))
			Me.xrTableCellFullNameColumnHeader.Name = "xrTableCellFullNameColumnHeader"
			Me.xrTableCellFullNameColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellFullNameColumnHeader.StylePriority.UseForeColor = False
			Me.xrTableCellFullNameColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellFullNameColumnHeader.Text = "Customer Info"
			Me.xrTableCellFullNameColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellFullNameColumnHeader.Weight = 2.0278846623347362
			' 
			' xrTableCellRentsCountColumnHeader
			' 
			Me.xrTableCellRentsCountColumnHeader.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellRentsCountColumnHeader.CanGrow = False
			Me.xrTableCellRentsCountColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellRentsCountColumnHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(212))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(217))))))
			Me.xrTableCellRentsCountColumnHeader.Name = "xrTableCellRentsCountColumnHeader"
			Me.xrTableCellRentsCountColumnHeader.StylePriority.UseBorders = False
			Me.xrTableCellRentsCountColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellRentsCountColumnHeader.StylePriority.UseForeColor = False
			Me.xrTableCellRentsCountColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellRentsCountColumnHeader.Text = "Rentals"
			Me.xrTableCellRentsCountColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellRentsCountColumnHeader.Weight = 0.48076894906850964
			' 
			' topMarginBand
			' 
			Me.topMarginBand.HeightF = 48F
			Me.topMarginBand.Name = "topMarginBand"
			' 
			' bottomMarginBand
			' 
			Me.bottomMarginBand.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfoPageCount})
			Me.bottomMarginBand.HeightF = 61.50001F
			Me.bottomMarginBand.Name = "bottomMarginBand"
			' 
			' xrPageInfoPageCount
			' 
			Me.xrPageInfoPageCount.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrPageInfoPageCount.LocationFloat = New DevExpress.Utils.PointFloat(545.8333F, 0F)
			Me.xrPageInfoPageCount.Name = "xrPageInfoPageCount"
			Me.xrPageInfoPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfoPageCount.SizeF = New System.Drawing.SizeF(104.1667F, 25F)
			Me.xrPageInfoPageCount.StylePriority.UseFont = False
			Me.xrPageInfoPageCount.StylePriority.UseTextAlignment = False
			Me.xrPageInfoPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabelHeader})
			Me.ReportHeader.HeightF = 35F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabelHeader
			' 
			Me.xrLabelHeader.AutoWidth = True
			Me.xrLabelHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 16F)
			Me.xrLabelHeader.LocationFloat = New DevExpress.Utils.PointFloat(237.5F, 0F)
			Me.xrLabelHeader.Name = "xrLabelHeader"
			Me.xrLabelHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabelHeader.SizeF = New System.Drawing.SizeF(183.3333F, 35F)
			Me.xrLabelHeader.StylePriority.UseFont = False
			Me.xrLabelHeader.StylePriority.UseTextAlignment = False
			Me.xrLabelHeader.Text = "Active Customers"
			Me.xrLabelHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xpCollectionCustomers
			' 
			Me.xpCollectionCustomers.CaseSensitive = True
			Me.xpCollectionCustomers.ObjectType = GetType(DevExpress.VideoRent.Customer)
'			Me.xpCollectionCustomers.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionCustomers_ResolveSession);
			' 
			' calcFieldCustomerReceiptsCount
			' 
			Me.calcFieldCustomerReceiptsCount.DataSource = Me.xpCollectionCustomers
			Me.calcFieldCustomerReceiptsCount.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
			Me.calcFieldCustomerReceiptsCount.Name = "calcFieldCustomerReceiptsCount"
'			Me.calcFieldCustomerReceiptsCount.GetValue += New DevExpress.XtraReports.UI.GetValueEventHandler(Me.calculatedFieldCustomerReceiptsCount_GetValue);
			' 
			' ActiveCustomersListReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.DetailCustomer, Me.PageHeader, Me.topMarginBand, Me.bottomMarginBand, Me.ReportHeader})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calcFieldCustomerReceiptsCount})
			Me.DataSource = Me.xpCollectionCustomers
			Me.Extensions.Add("ParametersRequestExtension", "TimePeriodReport")
			Me.Extensions.Add("DataSerializationExtension", "TimePeriodReport")
			Me.Extensions.Add("DataEditorExtension", "TimePeriodReport")
			Me.Extensions.Add("ParameterEditorExtension", "TimePeriodReport")
			Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 48, 62)
            Me.ReportPrintOptions.PrintOnEmptyDataSource = False
			Me.RequestParameters = False
			Me.Version = "10.2"
'			Me.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.ActiveCustomersListReport_BeforePrint);
			CType(Me.xrTableActiveCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTableCustomerInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTableActiveCustomersHeaders, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private DetailCustomer As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private topMarginBand As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand As DevExpress.XtraReports.UI.BottomMarginBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabelHeader As DevExpress.XtraReports.UI.XRLabel
		Private xrTableActiveCustomers As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowActiveCustomersInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPhoto As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellCustomerInfo As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellRentsCount As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableActiveCustomersHeaders As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowColumnHeaders As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPhotoColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellFullNameColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellRentsCountColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xpCollectionCustomers As DevExpress.Xpo.XPCollection
		Private WithEvents xrPictureBoxPhoto As DevExpress.XtraReports.UI.XRPictureBox
		Private xrPageInfoPageCount As DevExpress.XtraReports.UI.XRPageInfo
		Private WithEvents calcFieldCustomerReceiptsCount As DevExpress.XtraReports.UI.CalculatedField
		Private xrTableCustomerInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowCustomerInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellFullName As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellDiscountLevel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowBirthDate As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellBirthDate As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowContacts As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellEmail As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellPhone As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowAddress As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellAddress As DevExpress.XtraReports.UI.XRTableCell
	End Class
End Namespace

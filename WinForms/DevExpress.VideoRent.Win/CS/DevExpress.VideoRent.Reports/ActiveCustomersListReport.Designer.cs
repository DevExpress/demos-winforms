namespace DevExpress.VideoRent.Reports {
    partial class ActiveCustomersListReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveCustomersListReport));
            this.DetailCustomer = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTableActiveCustomers = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowActiveCustomersInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPhoto = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBoxPhoto = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCellCustomerInfo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCustomerInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowCustomerInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellFullName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellDiscountLevel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowBirthDate = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellBirthDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowContacts = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellEmail = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellPhone = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowAddress = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellRentsCount = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTableActiveCustomersHeaders = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowColumnHeaders = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPhotoColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellFullNameColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellRentsCountColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.topMarginBand = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfoPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabelHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xpCollectionCustomers = new DevExpress.Xpo.XPCollection(this.components);
            this.calcFieldCustomerReceiptsCount = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableActiveCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableActiveCustomersHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DetailCustomer
            // 
            this.DetailCustomer.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableActiveCustomers});
            resources.ApplyResources(this.DetailCustomer, "DetailCustomer");
            this.DetailCustomer.Name = "DetailCustomer";
            this.DetailCustomer.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailCustomer.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("calcFieldCustomerReceiptsCount", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)});
            // 
            // xrTableActiveCustomers
            // 
            resources.ApplyResources(this.xrTableActiveCustomers, "xrTableActiveCustomers");
            this.xrTableActiveCustomers.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableActiveCustomers.Name = "xrTableActiveCustomers";
            this.xrTableActiveCustomers.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowActiveCustomersInfo});
            this.xrTableActiveCustomers.StylePriority.UseBorderColor = false;
            this.xrTableActiveCustomers.StylePriority.UseBorders = false;
            this.xrTableActiveCustomers.StylePriority.UseFont = false;
            // 
            // xrTableRowActiveCustomersInfo
            // 
            this.xrTableRowActiveCustomersInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPhoto,
            this.xrTableCellCustomerInfo,
            this.xrTableCellRentsCount});
            this.xrTableRowActiveCustomersInfo.Name = "xrTableRowActiveCustomersInfo";
            resources.ApplyResources(this.xrTableRowActiveCustomersInfo, "xrTableRowActiveCustomersInfo");
            // 
            // xrTableCellPhoto
            // 
            this.xrTableCellPhoto.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellPhoto.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBoxPhoto});
            this.xrTableCellPhoto.Name = "xrTableCellPhoto";
            this.xrTableCellPhoto.StylePriority.UseBorders = false;
            this.xrTableCellPhoto.StylePriority.UseTextAlignment = false;
            resources.ApplyResources(this.xrTableCellPhoto, "xrTableCellPhoto");
            // 
            // xrPictureBoxPhoto
            // 
            resources.ApplyResources(this.xrPictureBoxPhoto, "xrPictureBoxPhoto");
            this.xrPictureBoxPhoto.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPictureBoxPhoto.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Image", "[Photo]")});
            this.xrPictureBoxPhoto.Name = "xrPictureBoxPhoto";
            this.xrPictureBoxPhoto.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F);
            this.xrPictureBoxPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBoxPhoto.StylePriority.UseBackColor = false;
            this.xrPictureBoxPhoto.StylePriority.UseBorders = false;
            this.xrPictureBoxPhoto.StylePriority.UsePadding = false;
            this.xrPictureBoxPhoto.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrPictureBoxPhoto_BeforePrint);
            // 
            // xrTableCellCustomerInfo
            // 
            this.xrTableCellCustomerInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellCustomerInfo.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableCustomerInfo});
            resources.ApplyResources(this.xrTableCellCustomerInfo, "xrTableCellCustomerInfo");
            this.xrTableCellCustomerInfo.Name = "xrTableCellCustomerInfo";
            this.xrTableCellCustomerInfo.StylePriority.UseBorders = false;
            this.xrTableCellCustomerInfo.StylePriority.UseFont = false;
            this.xrTableCellCustomerInfo.StylePriority.UseTextAlignment = false;
            // 
            // xrTableCustomerInfo
            // 
            this.xrTableCustomerInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            resources.ApplyResources(this.xrTableCustomerInfo, "xrTableCustomerInfo");
            this.xrTableCustomerInfo.Name = "xrTableCustomerInfo";
            this.xrTableCustomerInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowCustomerInfo,
            this.xrTableRowBirthDate,
            this.xrTableRowContacts,
            this.xrTableRowAddress});
            this.xrTableCustomerInfo.StylePriority.UseBorders = false;
            // 
            // xrTableRowCustomerInfo
            // 
            this.xrTableRowCustomerInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellFullName,
            this.xrTableCellDiscountLevel});
            this.xrTableRowCustomerInfo.Name = "xrTableRowCustomerInfo";
            resources.ApplyResources(this.xrTableRowCustomerInfo, "xrTableRowCustomerInfo");
            // 
            // xrTableCellFullName
            // 
            resources.ApplyResources(this.xrTableCellFullName, "xrTableCellFullName");
            this.xrTableCellFullName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellFullName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FullNameLastSorting]")});
            this.xrTableCellFullName.Name = "xrTableCellFullName";
            this.xrTableCellFullName.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableCellFullName.StylePriority.UseBackColor = false;
            this.xrTableCellFullName.StylePriority.UseBorderColor = false;
            this.xrTableCellFullName.StylePriority.UseBorders = false;
            this.xrTableCellFullName.StylePriority.UseFont = false;
            this.xrTableCellFullName.StylePriority.UseForeColor = false;
            this.xrTableCellFullName.StylePriority.UsePadding = false;
            this.xrTableCellFullName.StylePriority.UseTextAlignment = false;
            // 
            // xrTableCellDiscountLevel
            // 
            resources.ApplyResources(this.xrTableCellDiscountLevel, "xrTableCellDiscountLevel");
            this.xrTableCellDiscountLevel.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellDiscountLevel.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiscountLevelCaption]")});
            this.xrTableCellDiscountLevel.Name = "xrTableCellDiscountLevel";
            this.xrTableCellDiscountLevel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableCellDiscountLevel.StylePriority.UseBackColor = false;
            this.xrTableCellDiscountLevel.StylePriority.UseBorderColor = false;
            this.xrTableCellDiscountLevel.StylePriority.UseBorders = false;
            this.xrTableCellDiscountLevel.StylePriority.UseFont = false;
            this.xrTableCellDiscountLevel.StylePriority.UseForeColor = false;
            this.xrTableCellDiscountLevel.StylePriority.UsePadding = false;
            this.xrTableCellDiscountLevel.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRowBirthDate
            // 
            this.xrTableRowBirthDate.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellBirthDate});
            this.xrTableRowBirthDate.Name = "xrTableRowBirthDate";
            resources.ApplyResources(this.xrTableRowBirthDate, "xrTableRowBirthDate");
            // 
            // xrTableCellBirthDate
            // 
            resources.ApplyResources(this.xrTableCellBirthDate, "xrTableCellBirthDate");
            this.xrTableCellBirthDate.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellBirthDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BirthDate]")});
            this.xrTableCellBirthDate.Multiline = true;
            this.xrTableCellBirthDate.Name = "xrTableCellBirthDate";
            this.xrTableCellBirthDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableCellBirthDate.StylePriority.UseBackColor = false;
            this.xrTableCellBirthDate.StylePriority.UseBorderColor = false;
            this.xrTableCellBirthDate.StylePriority.UseBorders = false;
            this.xrTableCellBirthDate.StylePriority.UseFont = false;
            this.xrTableCellBirthDate.StylePriority.UseForeColor = false;
            this.xrTableCellBirthDate.StylePriority.UsePadding = false;
            this.xrTableCellBirthDate.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRowContacts
            // 
            this.xrTableRowContacts.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellEmail,
            this.xrTableCellPhone});
            this.xrTableRowContacts.Name = "xrTableRowContacts";
            resources.ApplyResources(this.xrTableRowContacts, "xrTableRowContacts");
            // 
            // xrTableCellEmail
            // 
            resources.ApplyResources(this.xrTableCellEmail, "xrTableCellEmail");
            this.xrTableCellEmail.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellEmail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            this.xrTableCellEmail.Name = "xrTableCellEmail";
            this.xrTableCellEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableCellEmail.StylePriority.UseBackColor = false;
            this.xrTableCellEmail.StylePriority.UseBorderColor = false;
            this.xrTableCellEmail.StylePriority.UseBorders = false;
            this.xrTableCellEmail.StylePriority.UseFont = false;
            this.xrTableCellEmail.StylePriority.UseForeColor = false;
            this.xrTableCellEmail.StylePriority.UsePadding = false;
            this.xrTableCellEmail.StylePriority.UseTextAlignment = false;
            // 
            // xrTableCellPhone
            // 
            resources.ApplyResources(this.xrTableCellPhone, "xrTableCellPhone");
            this.xrTableCellPhone.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellPhone.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
            this.xrTableCellPhone.Name = "xrTableCellPhone";
            this.xrTableCellPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableCellPhone.StylePriority.UseBackColor = false;
            this.xrTableCellPhone.StylePriority.UseBorderColor = false;
            this.xrTableCellPhone.StylePriority.UseBorders = false;
            this.xrTableCellPhone.StylePriority.UseFont = false;
            this.xrTableCellPhone.StylePriority.UseForeColor = false;
            this.xrTableCellPhone.StylePriority.UsePadding = false;
            this.xrTableCellPhone.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRowAddress
            // 
            this.xrTableRowAddress.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellAddress});
            this.xrTableRowAddress.Name = "xrTableRowAddress";
            resources.ApplyResources(this.xrTableRowAddress, "xrTableRowAddress");
            // 
            // xrTableCellAddress
            // 
            resources.ApplyResources(this.xrTableCellAddress, "xrTableCellAddress");
            this.xrTableCellAddress.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellAddress.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")});
            this.xrTableCellAddress.Name = "xrTableCellAddress";
            this.xrTableCellAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F);
            this.xrTableCellAddress.StylePriority.UseBackColor = false;
            this.xrTableCellAddress.StylePriority.UseBorderColor = false;
            this.xrTableCellAddress.StylePriority.UseBorders = false;
            this.xrTableCellAddress.StylePriority.UseFont = false;
            this.xrTableCellAddress.StylePriority.UseForeColor = false;
            this.xrTableCellAddress.StylePriority.UsePadding = false;
            this.xrTableCellAddress.StylePriority.UseTextAlignment = false;
            // 
            // xrTableCellRentsCount
            // 
            resources.ApplyResources(this.xrTableCellRentsCount, "xrTableCellRentsCount");
            this.xrTableCellRentsCount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellRentsCount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calcFieldCustomerReceiptsCount]")});
            this.xrTableCellRentsCount.Name = "xrTableCellRentsCount";
            this.xrTableCellRentsCount.StylePriority.UseBackColor = false;
            this.xrTableCellRentsCount.StylePriority.UseBorders = false;
            this.xrTableCellRentsCount.StylePriority.UseFont = false;
            this.xrTableCellRentsCount.StylePriority.UseForeColor = false;
            this.xrTableCellRentsCount.StylePriority.UseTextAlignment = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableActiveCustomersHeaders});
            resources.ApplyResources(this.PageHeader, "PageHeader");
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrTableActiveCustomersHeaders
            // 
            this.xrTableActiveCustomersHeaders.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            resources.ApplyResources(this.xrTableActiveCustomersHeaders, "xrTableActiveCustomersHeaders");
            this.xrTableActiveCustomersHeaders.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableActiveCustomersHeaders.Name = "xrTableActiveCustomersHeaders";
            this.xrTableActiveCustomersHeaders.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowColumnHeaders});
            this.xrTableActiveCustomersHeaders.StylePriority.UseBackColor = false;
            this.xrTableActiveCustomersHeaders.StylePriority.UseBorderColor = false;
            this.xrTableActiveCustomersHeaders.StylePriority.UseBorders = false;
            this.xrTableActiveCustomersHeaders.StylePriority.UseFont = false;
            this.xrTableActiveCustomersHeaders.StylePriority.UseForeColor = false;
            // 
            // xrTableRowColumnHeaders
            // 
            this.xrTableRowColumnHeaders.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPhotoColumnHeader,
            this.xrTableCellFullNameColumnHeader,
            this.xrTableCellRentsCountColumnHeader});
            this.xrTableRowColumnHeaders.Name = "xrTableRowColumnHeaders";
            resources.ApplyResources(this.xrTableRowColumnHeaders, "xrTableRowColumnHeaders");
            // 
            // xrTableCellPhotoColumnHeader
            // 
            this.xrTableCellPhotoColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellPhotoColumnHeader, "xrTableCellPhotoColumnHeader");
            this.xrTableCellPhotoColumnHeader.Name = "xrTableCellPhotoColumnHeader";
            this.xrTableCellPhotoColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellPhotoColumnHeader.StylePriority.UseForeColor = false;
            this.xrTableCellPhotoColumnHeader.StylePriority.UseTextAlignment = false;
            // 
            // xrTableCellFullNameColumnHeader
            // 
            this.xrTableCellFullNameColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellFullNameColumnHeader, "xrTableCellFullNameColumnHeader");
            this.xrTableCellFullNameColumnHeader.Name = "xrTableCellFullNameColumnHeader";
            this.xrTableCellFullNameColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellFullNameColumnHeader.StylePriority.UseForeColor = false;
            this.xrTableCellFullNameColumnHeader.StylePriority.UseTextAlignment = false;
            // 
            // xrTableCellRentsCountColumnHeader
            // 
            this.xrTableCellRentsCountColumnHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellRentsCountColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellRentsCountColumnHeader, "xrTableCellRentsCountColumnHeader");
            this.xrTableCellRentsCountColumnHeader.Name = "xrTableCellRentsCountColumnHeader";
            this.xrTableCellRentsCountColumnHeader.StylePriority.UseBorders = false;
            this.xrTableCellRentsCountColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellRentsCountColumnHeader.StylePriority.UseForeColor = false;
            this.xrTableCellRentsCountColumnHeader.StylePriority.UseTextAlignment = false;
            // 
            // topMarginBand
            // 
            resources.ApplyResources(this.topMarginBand, "topMarginBand");
            this.topMarginBand.Name = "topMarginBand";
            // 
            // bottomMarginBand
            // 
            this.bottomMarginBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfoPageCount});
            resources.ApplyResources(this.bottomMarginBand, "bottomMarginBand");
            this.bottomMarginBand.Name = "bottomMarginBand";
            // 
            // xrPageInfoPageCount
            // 
            resources.ApplyResources(this.xrPageInfoPageCount, "xrPageInfoPageCount");
            this.xrPageInfoPageCount.Name = "xrPageInfoPageCount";
            this.xrPageInfoPageCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfoPageCount.StylePriority.UseFont = false;
            this.xrPageInfoPageCount.StylePriority.UseTextAlignment = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelHeader});
            resources.ApplyResources(this.ReportHeader, "ReportHeader");
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabelHeader
            // 
            resources.ApplyResources(this.xrLabelHeader, "xrLabelHeader");
            this.xrLabelHeader.Name = "xrLabelHeader";
            this.xrLabelHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelHeader.StylePriority.UseFont = false;
            this.xrLabelHeader.StylePriority.UseTextAlignment = false;
            // 
            // xpCollectionCustomers
            // 
            this.xpCollectionCustomers.CaseSensitive = true;
            this.xpCollectionCustomers.ObjectType = typeof(DevExpress.VideoRent.Customer);
            this.xpCollectionCustomers.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionCustomers_ResolveSession);
            // 
            // calcFieldCustomerReceiptsCount
            // 
            this.calcFieldCustomerReceiptsCount.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.calcFieldCustomerReceiptsCount.Name = "calcFieldCustomerReceiptsCount";
            this.calcFieldCustomerReceiptsCount.GetValue += new DevExpress.XtraReports.UI.GetValueEventHandler(this.calculatedFieldCustomerReceiptsCount_GetValue);
            // 
            // ActiveCustomersListReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.DetailCustomer,
            this.PageHeader,
            this.topMarginBand,
            this.bottomMarginBand,
            this.ReportHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calcFieldCustomerReceiptsCount});
            this.DataSource = this.xpCollectionCustomers;
            this.Extensions.Add("ParametersRequestExtension", "TimePeriodReport");
            this.Extensions.Add("DataSerializationExtension", "TimePeriodReport");
            this.Extensions.Add("DataEditorExtension", "TimePeriodReport");
            this.Extensions.Add("ParameterEditorExtension", "TimePeriodReport");
            resources.ApplyResources(this, "$this");
            this.ReportPrintOptions.PrintOnEmptyDataSource = false;
            this.RequestParameters = false;
            this.Version = "17.2";
            this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.ActiveCustomersListReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTableActiveCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableActiveCustomersHeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand DetailCustomer;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabelHeader;
        private DevExpress.XtraReports.UI.XRTable xrTableActiveCustomers;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowActiveCustomersInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPhoto;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellCustomerInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRentsCount;
        private DevExpress.XtraReports.UI.XRTable xrTableActiveCustomersHeaders;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowColumnHeaders;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPhotoColumnHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellFullNameColumnHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRentsCountColumnHeader;
        private DevExpress.Xpo.XPCollection xpCollectionCustomers;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxPhoto;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfoPageCount;
        private DevExpress.XtraReports.UI.CalculatedField calcFieldCustomerReceiptsCount;
        private DevExpress.XtraReports.UI.XRTable xrTableCustomerInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowCustomerInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellFullName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellDiscountLevel;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowBirthDate;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellBirthDate;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowContacts;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellEmail;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPhone;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowAddress;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellAddress;
    }
}

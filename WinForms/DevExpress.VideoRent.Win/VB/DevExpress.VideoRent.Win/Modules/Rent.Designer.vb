Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Rent
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode3 As New DevExpress.XtraGrid.GridLevelNode()
			Dim styleFormatCondition2 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gvRents = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colRentId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReturnedOn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDays = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMovieInfo = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPaymentRent = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gcReceipts = New DevExpress.XtraGrid.GridControl()
			Me.gvOverdue = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOverdueRentId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMovieInfoOverdue = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOverdue = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOverduePayment = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gvSales = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colSaleId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMovieInfoSale = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPaymentSale = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gvReceipts = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPayment = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReceiptId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOverdueActive = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.gcActiveRents = New DevExpress.XtraGrid.GridControl()
			Me.gvActiveRents = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colRentIdActive = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDaysActive = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colActiveRent = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRentedOn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPaymentActive = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMovieTitleActive = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colActiveType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReturn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.colItemFormat = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ucCustomerInfo1 = New DevExpress.VideoRent.Win.Controls.ucCustomerInfo()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciCustomerInfo = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.tcgViews = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.lcgReceipts = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciRecepts = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lcgActiveRents = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciActiveRents = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.gvRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvOverdue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvSales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.gcActiveRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvActiveRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCustomerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tcgViews, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRecepts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgActiveRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciActiveRents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colActive
			' 
			Me.colActive.FieldName = "Active"
			Me.colActive.Name = "colActive"
			Me.colActive.OptionsColumn.AllowFocus = False
			Me.colActive.Visible = True
			Me.colActive.VisibleIndex = 4
			Me.colActive.Width = 82
			' 
			' gvRents
			' 
			Me.gvRents.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colRentId, Me.colReturnedOn, Me.colDays, Me.colActive, Me.colMovieInfo, Me.colPaymentRent})
			styleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			styleFormatCondition1.Appearance.Options.UseFont = True
			styleFormatCondition1.ApplyToRow = True
			styleFormatCondition1.Column = Me.colActive
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
			styleFormatCondition1.Value1 = True
			Me.gvRents.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
			Me.gvRents.GridControl = Me.gcReceipts
			Me.gvRents.Name = "gvRents"
			Me.gvRents.OptionsBehavior.Editable = False
			Me.gvRents.OptionsView.AllowHtmlDrawHeaders = True
			Me.gvRents.OptionsView.ShowGroupPanel = False
            Me.gvRents.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			' 
			' colRentId
			' 
			Me.colRentId.AppearanceCell.Options.UseTextOptions = True
			Me.colRentId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colRentId.Caption = "<b>Rental</b> Id"
			Me.colRentId.DisplayFormat.FormatString = "d8"
			Me.colRentId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colRentId.FieldName = "RentId"
			Me.colRentId.Name = "colRentId"
			Me.colRentId.OptionsColumn.AllowFocus = False
			Me.colRentId.Visible = True
			Me.colRentId.VisibleIndex = 0
			Me.colRentId.Width = 100
			' 
			' colReturnedOn
			' 
			Me.colReturnedOn.FieldName = "ReturnedOn"
			Me.colReturnedOn.Name = "colReturnedOn"
			Me.colReturnedOn.OptionsColumn.AllowFocus = False
			Me.colReturnedOn.Visible = True
			Me.colReturnedOn.VisibleIndex = 2
			Me.colReturnedOn.Width = 82
			' 
			' colDays
			' 
			Me.colDays.FieldName = "Days"
			Me.colDays.Name = "colDays"
			Me.colDays.OptionsColumn.AllowFocus = False
			Me.colDays.Visible = True
			Me.colDays.VisibleIndex = 3
			Me.colDays.Width = 82
			' 
			' colMovieInfo
			' 
			Me.colMovieInfo.Caption = "Movie"
			Me.colMovieInfo.FieldName = "MovieInfo"
			Me.colMovieInfo.Name = "colMovieInfo"
			Me.colMovieInfo.OptionsColumn.AllowFocus = False
			Me.colMovieInfo.Visible = True
			Me.colMovieInfo.VisibleIndex = 1
			Me.colMovieInfo.Width = 248
			' 
			' colPaymentRent
			' 
			Me.colPaymentRent.DisplayFormat.FormatString = "c"
			Me.colPaymentRent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPaymentRent.FieldName = "Payment"
			Me.colPaymentRent.Name = "colPaymentRent"
			Me.colPaymentRent.OptionsColumn.AllowFocus = False
			Me.colPaymentRent.Visible = True
			Me.colPaymentRent.VisibleIndex = 5
			Me.colPaymentRent.Width = 96
			' 
			' gcReceipts
			' 
			gridLevelNode1.LevelTemplate = Me.gvRents
			gridLevelNode1.RelationName = "Rents"
			gridLevelNode2.LevelTemplate = Me.gvOverdue
			gridLevelNode2.RelationName = "OverdueRents"
			gridLevelNode3.LevelTemplate = Me.gvSales
			gridLevelNode3.RelationName = "Sales"
			Me.gcReceipts.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode2, gridLevelNode3})
			Me.gcReceipts.Location = New System.Drawing.Point(241, 24)
			Me.gcReceipts.MainView = Me.gvReceipts
			Me.gcReceipts.Name = "gcReceipts"
			Me.gcReceipts.ShowOnlyPredefinedDetails = True
			Me.gcReceipts.Size = New System.Drawing.Size(724, 498)
			Me.gcReceipts.TabIndex = 1
			Me.gcReceipts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvOverdue, Me.gvSales, Me.gvReceipts, Me.gvRents})
			' 
			' gvOverdue
			' 
			Me.gvOverdue.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOverdueRentId, Me.colMovieInfoOverdue, Me.colOverdue, Me.colOverduePayment})
			Me.gvOverdue.GridControl = Me.gcReceipts
			Me.gvOverdue.Name = "gvOverdue"
			Me.gvOverdue.OptionsBehavior.Editable = False
			Me.gvOverdue.OptionsView.AllowHtmlDrawHeaders = True
			Me.gvOverdue.OptionsView.ShowGroupPanel = False
            Me.gvOverdue.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			' 
			' colOverdueRentId
			' 
			Me.colOverdueRentId.AppearanceCell.Options.UseTextOptions = True
			Me.colOverdueRentId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colOverdueRentId.Caption = "<b>Rental</b> Id"
			Me.colOverdueRentId.DisplayFormat.FormatString = "d8"
			Me.colOverdueRentId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colOverdueRentId.FieldName = "RentId"
			Me.colOverdueRentId.Name = "colOverdueRentId"
			Me.colOverdueRentId.OptionsColumn.AllowFocus = False
			Me.colOverdueRentId.Visible = True
			Me.colOverdueRentId.VisibleIndex = 0
			Me.colOverdueRentId.Width = 102
			' 
			' colMovieInfoOverdue
			' 
			Me.colMovieInfoOverdue.Caption = "Movie"
			Me.colMovieInfoOverdue.FieldName = "MovieInfo"
			Me.colMovieInfoOverdue.Name = "colMovieInfoOverdue"
			Me.colMovieInfoOverdue.OptionsColumn.AllowFocus = False
			Me.colMovieInfoOverdue.Visible = True
			Me.colMovieInfoOverdue.VisibleIndex = 1
			Me.colMovieInfoOverdue.Width = 312
			' 
			' colOverdue
			' 
			Me.colOverdue.Caption = "Days Overdue"
			Me.colOverdue.FieldName = "Overdue"
			Me.colOverdue.Name = "colOverdue"
			Me.colOverdue.OptionsColumn.AllowFocus = False
			Me.colOverdue.Visible = True
			Me.colOverdue.VisibleIndex = 2
			Me.colOverdue.Width = 134
			' 
			' colOverduePayment
			' 
			Me.colOverduePayment.Caption = "Payment <b>Due</b>"
			Me.colOverduePayment.DisplayFormat.FormatString = "c"
			Me.colOverduePayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colOverduePayment.FieldName = "OverduePayment"
			Me.colOverduePayment.Name = "colOverduePayment"
			Me.colOverduePayment.OptionsColumn.AllowFocus = False
			Me.colOverduePayment.Visible = True
			Me.colOverduePayment.VisibleIndex = 3
			Me.colOverduePayment.Width = 142
			' 
			' gvSales
			' 
			Me.gvSales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSaleId, Me.colMovieInfoSale, Me.colPaymentSale})
			Me.gvSales.GridControl = Me.gcReceipts
			Me.gvSales.Name = "gvSales"
			Me.gvSales.OptionsBehavior.Editable = False
			Me.gvSales.OptionsView.AllowHtmlDrawHeaders = True
			Me.gvSales.OptionsView.ShowGroupPanel = False
            Me.gvSales.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			' 
			' colSaleId
			' 
			Me.colSaleId.AppearanceCell.Options.UseTextOptions = True
			Me.colSaleId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colSaleId.Caption = "<b>Purchase</b> Id"
			Me.colSaleId.DisplayFormat.FormatString = "d8"
			Me.colSaleId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colSaleId.FieldName = "RentId"
			Me.colSaleId.Name = "colSaleId"
			Me.colSaleId.OptionsColumn.AllowFocus = False
			Me.colSaleId.Visible = True
			Me.colSaleId.VisibleIndex = 0
			Me.colSaleId.Width = 110
			' 
			' colMovieInfoSale
			' 
			Me.colMovieInfoSale.Caption = "Movie"
			Me.colMovieInfoSale.FieldName = "MovieInfo"
			Me.colMovieInfoSale.Name = "colMovieInfoSale"
			Me.colMovieInfoSale.OptionsColumn.AllowFocus = False
			Me.colMovieInfoSale.Visible = True
			Me.colMovieInfoSale.VisibleIndex = 1
			Me.colMovieInfoSale.Width = 406
			' 
			' colPaymentSale
			' 
			Me.colPaymentSale.DisplayFormat.FormatString = "c"
			Me.colPaymentSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPaymentSale.FieldName = "Payment"
			Me.colPaymentSale.Name = "colPaymentSale"
			Me.colPaymentSale.OptionsColumn.AllowFocus = False
			Me.colPaymentSale.Visible = True
			Me.colPaymentSale.VisibleIndex = 2
			Me.colPaymentSale.Width = 187
			' 
			' gvReceipts
			' 
			Me.gvReceipts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gvReceipts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colDate, Me.colPayment, Me.colReceiptId, Me.colType, Me.colDiscount})
			Me.gvReceipts.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
			Me.gvReceipts.DetailVerticalIndent = 8
			Me.gvReceipts.GridControl = Me.gcReceipts
			Me.gvReceipts.GroupCount = 1
            Me.gvReceipts.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
			Me.gvReceipts.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ReceiptId", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Payment", Me.colPayment, "SUM={0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Discount", Me.colDiscount, "SUM={0:c}")})
			Me.gvReceipts.Name = "gvReceipts"
			Me.gvReceipts.OptionsBehavior.Editable = False
			Me.gvReceipts.OptionsDetail.ShowDetailTabs = False
			Me.gvReceipts.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails
			Me.gvReceipts.OptionsPrint.ExpandAllDetails = True
			Me.gvReceipts.OptionsPrint.PrintDetails = True
			Me.gvReceipts.OptionsView.ShowAutoFilterRow = True
			Me.gvReceipts.OptionsView.ShowFooter = True
			Me.gvReceipts.OptionsView.ShowIndicator = False
			Me.gvReceipts.OptionsView.ShowViewCaption = True
			Me.gvReceipts.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colType, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colReceiptId, DevExpress.Data.ColumnSortOrder.Ascending)})
			Me.gvReceipts.SynchronizeClones = False
			Me.gvReceipts.ViewCaption = "Receipts period"
'			Me.gvReceipts.MasterRowGetLevelDefaultView += New DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(Me.gvReceipts_MasterRowGetLevelDefaultView);
'			Me.gvReceipts.MasterRowGetRelationDisplayCaption += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(Me.gvReceipts_MasterRowGetRelationDisplayCaption);
'			Me.gvReceipts.EndGrouping += New System.EventHandler(Me.gvReceipts_EndGrouping);
			' 
			' colDate
			' 
			Me.colDate.FieldName = "Date"
			Me.colDate.Name = "colDate"
			Me.colDate.OptionsColumn.AllowFocus = False
			Me.colDate.Visible = True
			Me.colDate.VisibleIndex = 1
			Me.colDate.Width = 184
			' 
			' colPayment
			' 
			Me.colPayment.DisplayFormat.FormatString = "c"
			Me.colPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPayment.FieldName = "Payment"
			Me.colPayment.Name = "colPayment"
			Me.colPayment.OptionsColumn.AllowFocus = False
			Me.colPayment.SummaryItem.DisplayFormat = "SUM={0:c}"
			Me.colPayment.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
			Me.colPayment.Visible = True
			Me.colPayment.VisibleIndex = 3
			Me.colPayment.Width = 158
			' 
			' colReceiptId
			' 
			Me.colReceiptId.AppearanceCell.Options.UseTextOptions = True
			Me.colReceiptId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colReceiptId.DisplayFormat.FormatString = "d8"
			Me.colReceiptId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colReceiptId.FieldName = "ReceiptId"
			Me.colReceiptId.Name = "colReceiptId"
			Me.colReceiptId.OptionsColumn.AllowFocus = False
			Me.colReceiptId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colReceiptId.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
			Me.colReceiptId.Visible = True
			Me.colReceiptId.VisibleIndex = 0
			Me.colReceiptId.Width = 205
			' 
			' colType
			' 
			Me.colType.FieldName = "Type"
			Me.colType.Name = "colType"
			Me.colType.OptionsColumn.AllowFocus = False
			Me.colType.Visible = True
			Me.colType.VisibleIndex = 1
			Me.colType.Width = 167
			' 
			' colDiscount
			' 
			Me.colDiscount.DisplayFormat.FormatString = "c"
			Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colDiscount.FieldName = "Discount"
			Me.colDiscount.Name = "colDiscount"
			Me.colDiscount.OptionsColumn.AllowFocus = False
			Me.colDiscount.SummaryItem.DisplayFormat = "SUM={0:c}"
			Me.colDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
			Me.colDiscount.Visible = True
			Me.colDiscount.VisibleIndex = 2
			Me.colDiscount.Width = 159
			' 
			' colOverdueActive
			' 
			Me.colOverdueActive.Caption = "Days <b>Overdue</b>"
			Me.colOverdueActive.DisplayFormat.FormatString = "0;(0)"
			Me.colOverdueActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colOverdueActive.FieldName = "Overdue"
			Me.colOverdueActive.Name = "colOverdueActive"
			Me.colOverdueActive.OptionsColumn.AllowEdit = False
			Me.colOverdueActive.OptionsColumn.AllowFocus = False
			Me.colOverdueActive.OptionsColumn.ReadOnly = True
			Me.colOverdueActive.Visible = True
			Me.colOverdueActive.VisibleIndex = 7
			Me.colOverdueActive.Width = 103
			' 
			' lcMain
			' 
            Me.lcMain.AllowCustomization = False
			Me.lcMain.Controls.Add(Me.gcActiveRents)
			Me.lcMain.Controls.Add(Me.ucCustomerInfo1)
			Me.lcMain.Controls.Add(Me.gcReceipts)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(6, 6)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(968, 525)
			Me.lcMain.TabIndex = 2
			Me.lcMain.Text = "layoutControl1"
			' 
			' gcActiveRents
			' 
			Me.gcActiveRents.Location = New System.Drawing.Point(241, 24)
			Me.gcActiveRents.MainView = Me.gvActiveRents
			Me.gcActiveRents.Name = "gcActiveRents"
			Me.gcActiveRents.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1})
			Me.gcActiveRents.ShowOnlyPredefinedDetails = True
			Me.gcActiveRents.Size = New System.Drawing.Size(724, 498)
			Me.gcActiveRents.TabIndex = 5
			Me.gcActiveRents.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvActiveRents})
			' 
			' gvActiveRents
			' 
			Me.gvActiveRents.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gvActiveRents.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colRentIdActive, Me.colDaysActive, Me.colOverdueActive, Me.colActiveRent, Me.colRentedOn, Me.colPaymentActive, Me.colMovieTitleActive, Me.colActiveType, Me.colReturn, Me.colItemFormat})
			styleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			styleFormatCondition2.Appearance.Options.UseFont = True
			styleFormatCondition2.ApplyToRow = True
			styleFormatCondition2.Column = Me.colOverdueActive
			styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			styleFormatCondition2.Value1 = 0
			Me.gvActiveRents.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition2})
			Me.gvActiveRents.GridControl = Me.gcActiveRents
			Me.gvActiveRents.Name = "gvActiveRents"
			Me.gvActiveRents.OptionsView.AllowHtmlDrawHeaders = True
			Me.gvActiveRents.OptionsView.ShowGroupPanel = False
			Me.gvActiveRents.OptionsView.ShowIndicator = False
            Me.gvActiveRents.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
'			Me.gvActiveRents.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gvActiveRents_CustomUnboundColumnData);
			' 
			' colRentIdActive
			' 
			Me.colRentIdActive.AppearanceCell.Options.UseTextOptions = True
			Me.colRentIdActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colRentIdActive.Caption = "<b>Rental</b> Id"
			Me.colRentIdActive.DisplayFormat.FormatString = "d8"
			Me.colRentIdActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colRentIdActive.FieldName = "RentId"
			Me.colRentIdActive.Name = "colRentIdActive"
			Me.colRentIdActive.OptionsColumn.AllowEdit = False
			Me.colRentIdActive.OptionsColumn.AllowFocus = False
			Me.colRentIdActive.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colRentIdActive.Visible = True
			Me.colRentIdActive.VisibleIndex = 2
			Me.colRentIdActive.Width = 92
			' 
			' colDaysActive
			' 
			Me.colDaysActive.FieldName = "Days"
			Me.colDaysActive.Name = "colDaysActive"
			Me.colDaysActive.OptionsColumn.AllowEdit = False
			Me.colDaysActive.OptionsColumn.AllowFocus = False
			Me.colDaysActive.Visible = True
			Me.colDaysActive.VisibleIndex = 6
			Me.colDaysActive.Width = 43
			' 
			' colActiveRent
			' 
			Me.colActiveRent.FieldName = "Active"
			Me.colActiveRent.Name = "colActiveRent"
			Me.colActiveRent.OptionsColumn.AllowFocus = False
			Me.colActiveRent.OptionsColumn.ReadOnly = True
			' 
			' colRentedOn
			' 
			Me.colRentedOn.FieldName = "RentedOn"
			Me.colRentedOn.Name = "colRentedOn"
			Me.colRentedOn.OptionsColumn.AllowEdit = False
			Me.colRentedOn.OptionsColumn.AllowFocus = False
			Me.colRentedOn.OptionsColumn.ReadOnly = True
			Me.colRentedOn.Visible = True
			Me.colRentedOn.VisibleIndex = 5
			Me.colRentedOn.Width = 68
			' 
			' colPaymentActive
			' 
			Me.colPaymentActive.DisplayFormat.FormatString = "c"
			Me.colPaymentActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPaymentActive.FieldName = "Payment"
			Me.colPaymentActive.Name = "colPaymentActive"
			Me.colPaymentActive.OptionsColumn.AllowEdit = False
			Me.colPaymentActive.OptionsColumn.AllowFocus = False
			Me.colPaymentActive.Visible = True
			Me.colPaymentActive.VisibleIndex = 8
			Me.colPaymentActive.Width = 91
			' 
			' colMovieTitleActive
			' 
			Me.colMovieTitleActive.FieldName = "MovieTitle"
			Me.colMovieTitleActive.Name = "colMovieTitleActive"
			Me.colMovieTitleActive.OptionsColumn.AllowEdit = False
			Me.colMovieTitleActive.OptionsColumn.AllowFocus = False
			Me.colMovieTitleActive.OptionsColumn.ReadOnly = True
			Me.colMovieTitleActive.Visible = True
			Me.colMovieTitleActive.VisibleIndex = 3
			Me.colMovieTitleActive.Width = 216
			' 
			' colActiveType
			' 
			Me.colActiveType.FieldName = "ActiveType"
			Me.colActiveType.ImageAlignment = System.Drawing.StringAlignment.Center
			Me.colActiveType.Name = "colActiveType"
			Me.colActiveType.OptionsColumn.AllowEdit = False
			Me.colActiveType.OptionsColumn.AllowFocus = False
			Me.colActiveType.OptionsColumn.AllowMove = False
			Me.colActiveType.OptionsColumn.AllowSize = False
			Me.colActiveType.OptionsColumn.FixedWidth = True
			Me.colActiveType.OptionsColumn.ShowCaption = False
			Me.colActiveType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colActiveType.Visible = True
			Me.colActiveType.VisibleIndex = 1
			Me.colActiveType.Width = 40
			' 
			' colReturn
			' 
			Me.colReturn.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.colReturn.FieldName = "Return"
			Me.colReturn.ImageAlignment = System.Drawing.StringAlignment.Center
			Me.colReturn.Name = "colReturn"
			Me.colReturn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colReturn.OptionsColumn.AllowMove = False
			Me.colReturn.OptionsColumn.AllowSize = False
			Me.colReturn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colReturn.OptionsColumn.FixedWidth = True
			Me.colReturn.OptionsColumn.ShowCaption = False
			Me.colReturn.OptionsFilter.AllowAutoFilter = False
			Me.colReturn.OptionsFilter.AllowFilter = False
			Me.colReturn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
			Me.colReturn.Visible = True
			Me.colReturn.VisibleIndex = 0
			Me.colReturn.Width = 40
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
'			Me.repositoryItemCheckEdit1.CheckStateChanged += New System.EventHandler(Me.repositoryItemCheckEdit1_CheckStateChanged);
			' 
			' colItemFormat
			' 
			Me.colItemFormat.Caption = "Format"
			Me.colItemFormat.FieldName = "ItemFormat"
			Me.colItemFormat.Name = "colItemFormat"
			Me.colItemFormat.OptionsColumn.AllowEdit = False
			Me.colItemFormat.OptionsColumn.AllowFocus = False
			Me.colItemFormat.Visible = True
			Me.colItemFormat.VisibleIndex = 4
			Me.colItemFormat.Width = 62
			' 
			' ucCustomerInfo1
			' 
			Me.ucCustomerInfo1.Location = New System.Drawing.Point(2, 2)
			Me.ucCustomerInfo1.Name = "ucCustomerInfo1"
			Me.ucCustomerInfo1.Size = New System.Drawing.Size(228, 521)
			Me.ucCustomerInfo1.TabIndex = 4
'			Me.ucCustomerInfo1.DoEdit += New System.EventHandler(Me.ucCustomerInfo1_DoEdit);
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "Root"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciCustomerInfo, Me.splitterItem1, Me.tcgViews})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(968, 525)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' lciCustomerInfo
			' 
			Me.lciCustomerInfo.Control = Me.ucCustomerInfo1
			Me.lciCustomerInfo.CustomizationFormText = "Current Customer:"
			Me.lciCustomerInfo.Location = New System.Drawing.Point(0, 0)
			Me.lciCustomerInfo.Name = "lciCustomerInfo"
			Me.lciCustomerInfo.Size = New System.Drawing.Size(232, 525)
			Me.lciCustomerInfo.Text = "Current Customer:"
			Me.lciCustomerInfo.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciCustomerInfo.TextSize = New System.Drawing.Size(0, 0)
			Me.lciCustomerInfo.TextToControlDistance = 0
			Me.lciCustomerInfo.TextVisible = False
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(232, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(6, 525)
			' 
			' tcgViews
			' 
			Me.tcgViews.CustomizationFormText = "tcgViews"
			Me.tcgViews.Location = New System.Drawing.Point(238, 0)
			Me.tcgViews.Name = "tcgViews"
			Me.tcgViews.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.tcgViews.SelectedTabPage = Me.lcgReceipts
			Me.tcgViews.SelectedTabPageIndex = 0
			Me.tcgViews.Size = New System.Drawing.Size(730, 525)
			Me.tcgViews.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgReceipts, Me.lcgActiveRents})
			Me.tcgViews.Text = "tcgViews"
			' 
			' lcgReceipts
			' 
			Me.lcgReceipts.CustomizationFormText = "Receipts"
			Me.lcgReceipts.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciRecepts})
			Me.lcgReceipts.Location = New System.Drawing.Point(0, 0)
			Me.lcgReceipts.Name = "lcgReceipts"
			Me.lcgReceipts.Size = New System.Drawing.Size(724, 498)
			Me.lcgReceipts.Text = "Receipts"
			' 
			' lciRecepts
			' 
			Me.lciRecepts.Control = Me.gcReceipts
			Me.lciRecepts.CustomizationFormText = "Recepts:"
			Me.lciRecepts.Location = New System.Drawing.Point(0, 0)
			Me.lciRecepts.Name = "lciRecepts"
			Me.lciRecepts.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciRecepts.Size = New System.Drawing.Size(724, 498)
			Me.lciRecepts.Text = "Recepts:"
			Me.lciRecepts.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciRecepts.TextSize = New System.Drawing.Size(0, 0)
			Me.lciRecepts.TextToControlDistance = 0
			Me.lciRecepts.TextVisible = False
			' 
			' lcgActiveRents
			' 
			Me.lcgActiveRents.CustomizationFormText = "Active Rents"
			Me.lcgActiveRents.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciActiveRents})
			Me.lcgActiveRents.Location = New System.Drawing.Point(0, 0)
			Me.lcgActiveRents.Name = "lcgActiveRents"
			Me.lcgActiveRents.Size = New System.Drawing.Size(724, 498)
			Me.lcgActiveRents.Text = "Active Rentals"
			' 
			' lciActiveRents
			' 
			Me.lciActiveRents.Control = Me.gcActiveRents
			Me.lciActiveRents.CustomizationFormText = "lciActiveRents"
			Me.lciActiveRents.Location = New System.Drawing.Point(0, 0)
			Me.lciActiveRents.Name = "lciActiveRents"
			Me.lciActiveRents.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciActiveRents.Size = New System.Drawing.Size(724, 498)
			Me.lciActiveRents.Text = "lciActiveRents"
			Me.lciActiveRents.TextSize = New System.Drawing.Size(0, 0)
			Me.lciActiveRents.TextToControlDistance = 0
			Me.lciActiveRents.TextVisible = False
			' 
			' Rent
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.Name = "Rent"
			Me.Padding = New System.Windows.Forms.Padding(6)
			Me.Size = New System.Drawing.Size(980, 537)
			CType(Me.gvRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcReceipts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvOverdue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvReceipts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.gcActiveRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvActiveRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCustomerInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tcgViews, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgReceipts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRecepts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgActiveRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciActiveRents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gcReceipts As DevExpress.XtraGrid.GridControl
		Private WithEvents gvReceipts As DevExpress.XtraGrid.Views.Grid.GridView
		Private gvRents As DevExpress.XtraGrid.Views.Grid.GridView
		Private colDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colPayment As DevExpress.XtraGrid.Columns.GridColumn
		Private colReceiptId As DevExpress.XtraGrid.Columns.GridColumn
		Private colType As DevExpress.XtraGrid.Columns.GridColumn
		Private gvOverdue As DevExpress.XtraGrid.Views.Grid.GridView
		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private WithEvents ucCustomerInfo1 As DevExpress.VideoRent.Win.Controls.ucCustomerInfo
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciCustomerInfo As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private tcgViews As DevExpress.XtraLayout.TabbedControlGroup
		Private lcgReceipts As DevExpress.XtraLayout.LayoutControlGroup
		Private lciRecepts As DevExpress.XtraLayout.LayoutControlItem
		Private lcgActiveRents As DevExpress.XtraLayout.LayoutControlGroup
		Private colRentId As DevExpress.XtraGrid.Columns.GridColumn
		Private colReturnedOn As DevExpress.XtraGrid.Columns.GridColumn
		Private colDays As DevExpress.XtraGrid.Columns.GridColumn
		Private colActive As DevExpress.XtraGrid.Columns.GridColumn
		Private colMovieInfo As DevExpress.XtraGrid.Columns.GridColumn
		Private colPaymentRent As DevExpress.XtraGrid.Columns.GridColumn
		Private gvSales As DevExpress.XtraGrid.Views.Grid.GridView
		Private colSaleId As DevExpress.XtraGrid.Columns.GridColumn
		Private colMovieInfoSale As DevExpress.XtraGrid.Columns.GridColumn
		Private colPaymentSale As DevExpress.XtraGrid.Columns.GridColumn
		Private colOverdueRentId As DevExpress.XtraGrid.Columns.GridColumn
		Private colMovieInfoOverdue As DevExpress.XtraGrid.Columns.GridColumn
		Private colOverdue As DevExpress.XtraGrid.Columns.GridColumn
		Private colOverduePayment As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
		Private gcActiveRents As DevExpress.XtraGrid.GridControl
		Private WithEvents gvActiveRents As DevExpress.XtraGrid.Views.Grid.GridView
		Private colRentIdActive As DevExpress.XtraGrid.Columns.GridColumn
		Private colDaysActive As DevExpress.XtraGrid.Columns.GridColumn
		Private colOverdueActive As DevExpress.XtraGrid.Columns.GridColumn
		Private colActiveRent As DevExpress.XtraGrid.Columns.GridColumn
		Private colRentedOn As DevExpress.XtraGrid.Columns.GridColumn
		Private colPaymentActive As DevExpress.XtraGrid.Columns.GridColumn
		Private colMovieTitleActive As DevExpress.XtraGrid.Columns.GridColumn
		Private lciActiveRents As DevExpress.XtraLayout.LayoutControlItem
		Private colActiveType As DevExpress.XtraGrid.Columns.GridColumn
		Private colReturn As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private colItemFormat As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

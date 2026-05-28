Namespace DevExpress.XtraGrid.Demos

    Partial Class CustomDataSummaries

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.CustomDataSummaries))
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.numCustom = New DevExpress.XtraEditors.SpinEdit()
            Me.pnlLeftlayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.numCustomitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.numCustom.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pnlLeftlayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLeftlayoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.numCustomitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' colFreight
            ' 
            resources.ApplyResources(Me.colFreight, "colFreight")
            Me.colFreight.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colFreight.DisplayFormat.FormatString = "c"
            Me.colFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight.FieldName = "Freight"
            Me.colFreight.Name = "colFreight"
            Me.colFreight.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colFreight.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colFreight.Summary1"), resources.GetString("colFreight.Summary2"))})
            ' 
            ' repositoryItemSpinEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' gridControl2
            ' 
            resources.ApplyResources(Me.gridControl2, "gridControl2")
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit2, Me.repositoryItemLookUpEdit2, Me.repositoryItemLookUpEdit3})
            Me.gridControl2.ShowOnlyPredefinedDetails = True
            Me.gridControl2.Tag = ""
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrder, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colFreight, Me.colShipCountry})
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
            styleFormatCondition1.Appearance.BackColor2 = CType((resources.GetObject("resource.BackColor2")), System.Drawing.Color)
            styleFormatCondition1.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
            styleFormatCondition1.Appearance.GradientMode = CType((resources.GetObject("resource.GradientMode")), System.Drawing.Drawing2D.LinearGradientMode)
            styleFormatCondition1.Appearance.Options.UseBackColor = True
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.Column = Me.colFreight
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
            styleFormatCondition1.Value1 = "100"
            Me.gridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.GroupCount = 1
            Me.gridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView2.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView2.GroupSummary1"), CType((resources.GetObject("gridView2.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView2.GroupSummary3")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView2.GroupSummary4")), DevExpress.Data.SummaryItemType), resources.GetString("gridView2.GroupSummary5"), CType((resources.GetObject("gridView2.GroupSummary6")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView2.GroupSummary7"))})
            Me.gridView2.HorzScrollStep = 30
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView2.OptionsView.ShowFooter = True
            Me.gridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEmployeeID, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView2.CustomDrawFooterCell, New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(AddressOf Me.gridView2_CustomDrawFooterCell)
            AddHandler Me.gridView2.PopupMenuShowing, New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf Me.gridView2_PopupMenuShowing)
            AddHandler Me.gridView2.CustomSummaryCalculate, New DevExpress.Data.CustomSummaryEventHandler(AddressOf Me.gridView2_CustomSummaryCalculate)
            ' 
            ' colOrder
            ' 
            resources.ApplyResources(Me.colOrder, "colOrder")
            Me.colOrder.FieldName = "OrderID"
            Me.colOrder.Name = "colOrder"
            Me.colOrder.OptionsFilter.AllowFilter = False
            Me.colOrder.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colOrder.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colCustomerID
            ' 
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.ColumnEdit = Me.repositoryItemLookUpEdit2
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemLookUpEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit2, "repositoryItemLookUpEdit2")
            Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemLookUpEdit2.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit2.Columns"), resources.GetString("repositoryItemLookUpEdit2.Columns1"))})
            Me.repositoryItemLookUpEdit2.DisplayMember = "CompanyName"
            Me.repositoryItemLookUpEdit2.DropDownRows = 10
            Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
            Me.repositoryItemLookUpEdit2.PopupWidth = 200
            Me.repositoryItemLookUpEdit2.ValueMember = "CustomerID"
            ' 
            ' colEmployeeID
            ' 
            resources.ApplyResources(Me.colEmployeeID, "colEmployeeID")
            Me.colEmployeeID.ColumnEdit = Me.repositoryItemLookUpEdit3
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            Me.colEmployeeID.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemLookUpEdit3
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit3, "repositoryItemLookUpEdit3")
            Me.repositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemLookUpEdit3.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit3.Columns"), resources.GetString("repositoryItemLookUpEdit3.Columns1")), New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit3.Columns2"), resources.GetString("repositoryItemLookUpEdit3.Columns3"))})
            Me.repositoryItemLookUpEdit3.DisplayMember = "Name"
            Me.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3"
            Me.repositoryItemLookUpEdit3.PopupWidth = 200
            Me.repositoryItemLookUpEdit3.ValueMember = "EmployeeID"
            ' 
            ' colOrderDate
            ' 
            resources.ApplyResources(Me.colOrderDate, "colOrderDate")
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            ' 
            ' colShipCountry
            ' 
            resources.ApplyResources(Me.colShipCountry, "colShipCountry")
            Me.colShipCountry.FieldName = "ShipCountry"
            Me.colShipCountry.Name = "colShipCountry"
            ' 
            ' numCustom
            ' 
            resources.ApplyResources(Me.numCustom, "numCustom")
            Me.numCustom.Name = "numCustom"
            Me.numCustom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.numCustom.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.numCustom.Properties.ValidateOnEnterKey = True
            Me.numCustom.StyleController = Me.pnlLeftlayoutControl1ConvertedLayout
            AddHandler Me.numCustom.EditValueChanged, New System.EventHandler(AddressOf Me.numCustom_ValueChanged)
            ' 
            ' pnlLeftlayoutControl1ConvertedLayout
            ' 
            Me.pnlLeftlayoutControl1ConvertedLayout.AllowCustomization = False
            Me.pnlLeftlayoutControl1ConvertedLayout.Controls.Add(Me.numCustom)
            resources.ApplyResources(Me.pnlLeftlayoutControl1ConvertedLayout, "pnlLeftlayoutControl1ConvertedLayout")
            Me.pnlLeftlayoutControl1ConvertedLayout.Name = "pnlLeftlayoutControl1ConvertedLayout"
            Me.pnlLeftlayoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 468)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.numCustomitem})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 66)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' numCustomitem
            ' 
            Me.numCustomitem.Control = Me.numCustom
            Me.numCustomitem.Location = New System.Drawing.Point(0, 0)
            Me.numCustomitem.Name = "numCustomitem"
            Me.numCustomitem.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.numCustomitem, "numCustomitem")
            Me.numCustomitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.numCustomitem.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 66)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 402)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            resources.ApplyResources(Me.tabPane1, "tabPane1")
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 501)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            ' 
            ' tabNavigationPage1
            ' 
            resources.ApplyResources(Me.tabNavigationPage1, "tabNavigationPage1")
            Me.tabNavigationPage1.Controls.Add(Me.pnlLeftlayoutControl1ConvertedLayout)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            ' 
            ' CustomDataSummaries
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl2)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "CustomDataSummaries"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.CustomDataSummaries_Load)
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.numCustom.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pnlLeftlayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLeftlayoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.numCustomitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colFreight As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrder As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private repositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private numCustom As DevExpress.XtraEditors.SpinEdit

        Private pnlLeftlayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private numCustomitem As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class OrderReports

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
            Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProduct = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSum = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.rgReport = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbeOrder = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.dsReports1 = New DevExpress.XtraPivotGrid.Demos.dsReports()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.rgReport.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbeOrder.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsReports1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' fieldOrderID
            ' 
            Me.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderID.AreaIndex = 0
            Me.fieldOrderID.Caption = "Order"
            Me.fieldOrderID.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderID")
            Me.fieldOrderID.Name = "fieldOrderID"
            Me.fieldOrderID.Width = 105
            ' 
            ' fieldProduct
            ' 
            Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProduct.AreaIndex = 1
            Me.fieldProduct.Caption = "Product Name"
            Me.fieldProduct.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            Me.fieldProduct.Name = "fieldProduct"
            Me.fieldProduct.Width = 185
            ' 
            ' fieldUnitPrice
            ' 
            Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitPrice.AreaIndex = 0
            Me.fieldUnitPrice.Caption = "Unit Price"
            Me.fieldUnitPrice.CellFormat.FormatString = "c"
            Me.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldUnitPrice.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("UnitPrice")
            Me.fieldUnitPrice.Name = "fieldUnitPrice"
            Me.fieldUnitPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            Me.fieldQuantity.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Quantity")
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' fieldDiscount
            ' 
            Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldDiscount.AreaIndex = 2
            Me.fieldDiscount.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Discount")
            Me.fieldDiscount.Name = "fieldDiscount"
            Me.fieldDiscount.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldDiscount.TotalCellFormat.FormatString = "P"
            Me.fieldDiscount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldDiscount.Width = 99
            ' 
            ' fieldSum
            ' 
            Me.fieldSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldSum.AreaIndex = 3
            Me.fieldSum.CellFormat.FormatString = "c"
            Me.fieldSum.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldSum.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Extended Price")
            Me.fieldSum.Name = "fieldSum"
            Me.fieldSum.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldSum.Width = 120
            ' 
            ' rgReport
            ' 
            Me.rgReport.AutoSizeInLayoutControl = True
            Me.rgReport.Location = New System.Drawing.Point(12, 31)
            Me.rgReport.Name = "rgReport"
            Me.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgReport.Properties.Appearance.Options.UseBackColor = True
            Me.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgReport.Properties.Columns = 1
            Me.rgReport.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Orders"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Orders (filtering)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quantity"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Average Unit Price")})
            Me.rgReport.Size = New System.Drawing.Size(175, 68)
            Me.rgReport.StyleController = Me.layoutControl1
            Me.rgReport.TabIndex = 0
            AddHandler Me.rgReport.SelectedIndexChanged, New System.EventHandler(AddressOf Me.rgReport_SelectedIndexChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cbeOrder)
            Me.layoutControl1.Controls.Add(Me.rgReport)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(462, 490, 814, 613)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 594)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbeOrder
            ' 
            Me.cbeOrder.EditValue = ""
            Me.cbeOrder.Location = New System.Drawing.Point(58, 103)
            Me.cbeOrder.Name = "cbeOrder"
            Me.cbeOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeOrder.Size = New System.Drawing.Size(129, 20)
            Me.cbeOrder.StyleController = Me.layoutControl1
            Me.cbeOrder.TabIndex = 1
            AddHandler Me.cbeOrder.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbeOrder_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 594)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 135)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 459)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 135)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Order Reports"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.rgReport
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 72)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbeOrder
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem2.Text = "OrderID:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(43, 13)
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.ActiveFilterString = ""
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.pivotGridControl1.DataSource = Me.dsReports1.OrderReports
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldOrderID, Me.fieldProduct, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldDiscount, Me.fieldSum})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(831, 621)
            Me.pivotGridControl1.TabIndex = 4
            ' 
            ' dsReports1
            ' 
            Me.dsReports1.DataSetName = "dsReports"
            Me.dsReports1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl1)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(831, 621)
            Me.mainPanel.TabIndex = 13
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(831, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 621)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 621)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 621)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 594)
            ' 
            ' OrderReports
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "OrderReports"
            Me.Size = New System.Drawing.Size(1031, 621)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OrderReports_Load)
            CType((Me.rgReport.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbeOrder.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsReports1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private fieldOrderID As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProduct As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSum As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private dsReports1 As DevExpress.XtraPivotGrid.Demos.dsReports

        Private rgReport As DevExpress.XtraEditors.RadioGroup

        Private cbeOrder As DevExpress.XtraEditors.ComboBoxEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace

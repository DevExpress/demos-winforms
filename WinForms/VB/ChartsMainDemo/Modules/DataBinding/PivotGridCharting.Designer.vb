Namespace DevExpress.XtraCharts.Demos

    Partial Class PivotGridChartingDemo

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim seriesTemplateAdapter1 As DevExpress.XtraCharts.SeriesTemplateAdapter = New DevExpress.XtraCharts.SeriesTemplateAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim seriesKeyColorColorizer1 As DevExpress.XtraCharts.SeriesKeyColorColorizer = New DevExpress.XtraCharts.SeriesKeyColorColorizer()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditSelectionOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditShowColumnGrandTotal = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditGenerateSeriesByColumns = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditShowRowGrandTotal = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lcgCommonOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciShowColumnGrandTotal = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciShowRowGrandTotal = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgLabelOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditSelectionOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowColumnGrandTotal.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditGenerateSeriesByColumns.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowRowGrandTotal.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgCommonOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciShowColumnGrandTotal), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciShowRowGrandTotal), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgLabelOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Margin = New System.Windows.Forms.Padding(2)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(4)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.pivotGridControl)
            Me.sidePanel1.Controls.Add(Me.sidePanel2)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(546, 571)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldExtendedPrice, Me.fieldOrderDate, Me.fieldOrderYear})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
            Me.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = False
            Me.pivotGridControl.OptionsChartDataSource.UpdateDelay = 500
            Me.pivotGridControl.Size = New System.Drawing.Size(546, 355)
            Me.pivotGridControl.TabIndex = 3
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 155
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldOrderDate
            ' 
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Order Month"
            Me.fieldOrderDate.FieldName = "OrderDate"
            Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
            ' 
            ' fieldOrderYear
            ' 
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Order Year"
            Me.fieldOrderYear.FieldName = "OrderDate"
            Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.Options.IsFilterRadioMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.fieldOrderYear.UnboundFieldName = "pivotGridField1"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.AllowResize = False
            Me.sidePanel2.Controls.Add(Me.chart)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanel2.Location = New System.Drawing.Point(0, 355)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(546, 216)
            Me.sidePanel2.TabIndex = 0
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ShowArgumentLine = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.MaxHorizontalPercentage = 30R
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 1)
            Me.chart.Name = "chart"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}"
            dataMember1.ColumnName = "Arguments"
            dataMember2.ColumnName = "Values"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "Series"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            Me.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1
            Me.chart.Size = New System.Drawing.Size(546, 215)
            Me.chart.TabIndex = 4
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chart_BoundDataChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl1.Controls.Add(Me.checkEditSelectionOnly)
            Me.layoutControl1.Controls.Add(Me.checkEditShowColumnGrandTotal)
            Me.layoutControl1.Controls.Add(Me.checkEditGenerateSeriesByColumns)
            Me.layoutControl1.Controls.Add(Me.checkEditShowRowGrandTotal)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(941, 150, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 172)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl1
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' checkEditSelectionOnly
            ' 
            Me.checkEditSelectionOnly.EditValue = True
            Me.checkEditSelectionOnly.Location = New System.Drawing.Point(12, 34)
            Me.checkEditSelectionOnly.Name = "checkEditSelectionOnly"
            Me.checkEditSelectionOnly.Properties.Caption = "Selection Only"
            Me.checkEditSelectionOnly.Size = New System.Drawing.Size(217, 20)
            Me.checkEditSelectionOnly.StyleController = Me.layoutControl1
            Me.checkEditSelectionOnly.TabIndex = 17
            AddHandler Me.checkEditSelectionOnly.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditSelectionOnly_CheckedChanged)
            ' 
            ' checkEditShowColumnGrandTotal
            ' 
            Me.checkEditShowColumnGrandTotal.Location = New System.Drawing.Point(12, 106)
            Me.checkEditShowColumnGrandTotal.Name = "checkEditShowColumnGrandTotal"
            Me.checkEditShowColumnGrandTotal.Properties.Caption = "Show Column Grand Total"
            Me.checkEditShowColumnGrandTotal.Size = New System.Drawing.Size(217, 20)
            Me.checkEditShowColumnGrandTotal.StyleController = Me.layoutControl1
            Me.checkEditShowColumnGrandTotal.TabIndex = 18
            AddHandler Me.checkEditShowColumnGrandTotal.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditShowColumnGrandTotals_CheckedChanged)
            ' 
            ' checkEditGenerateSeriesByColumns
            ' 
            Me.checkEditGenerateSeriesByColumns.Location = New System.Drawing.Point(12, 58)
            Me.checkEditGenerateSeriesByColumns.Name = "checkEditGenerateSeriesByColumns"
            Me.checkEditGenerateSeriesByColumns.Properties.Caption = "Generate Series by Columns"
            Me.checkEditGenerateSeriesByColumns.Size = New System.Drawing.Size(217, 20)
            Me.checkEditGenerateSeriesByColumns.StyleController = Me.layoutControl1
            Me.checkEditGenerateSeriesByColumns.TabIndex = 19
            AddHandler Me.checkEditGenerateSeriesByColumns.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditGenerateSeriesByColumns_CheckedChanged)
            ' 
            ' checkEditShowRowGrandTotal
            ' 
            Me.checkEditShowRowGrandTotal.Location = New System.Drawing.Point(12, 82)
            Me.checkEditShowRowGrandTotal.Name = "checkEditShowRowGrandTotal"
            Me.checkEditShowRowGrandTotal.Properties.Caption = "Show Row Grand Total"
            Me.checkEditShowRowGrandTotal.Size = New System.Drawing.Size(217, 20)
            Me.checkEditShowRowGrandTotal.StyleController = Me.layoutControl1
            Me.checkEditShowRowGrandTotal.TabIndex = 20
            AddHandler Me.checkEditShowRowGrandTotal.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditShowRowGrandTotals_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.lcgCommonOptions, Me.lcgLabelOptions})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 204)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(241, 334)
            Me.layoutControlGroup2.Text = "Marker Kind"
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(241, 334)
            ' 
            ' lcgCommonOptions
            ' 
            Me.lcgCommonOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.lcgCommonOptions.AppearanceGroup.Options.UseBorderColor = True
            Me.lcgCommonOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgCommonOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.lciShowColumnGrandTotal, Me.layoutControlItem4, Me.lciShowRowGrandTotal})
            Me.lcgCommonOptions.Location = New System.Drawing.Point(0, 0)
            Me.lcgCommonOptions.Name = "lcgCommonOptions"
            Me.lcgCommonOptions.Size = New System.Drawing.Size(241, 138)
            Me.lcgCommonOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgCommonOptions.Text = "General"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.checkEditSelectionOnly
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' lciShowColumnGrandTotal
            ' 
            Me.lciShowColumnGrandTotal.Control = Me.checkEditShowColumnGrandTotal
            Me.lciShowColumnGrandTotal.Location = New System.Drawing.Point(0, 72)
            Me.lciShowColumnGrandTotal.Name = "lciShowColumnGrandTotal"
            Me.lciShowColumnGrandTotal.Size = New System.Drawing.Size(221, 24)
            Me.lciShowColumnGrandTotal.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.checkEditGenerateSeriesByColumns
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' lciShowRowGrandTotal
            ' 
            Me.lciShowRowGrandTotal.Control = Me.checkEditShowRowGrandTotal
            Me.lciShowRowGrandTotal.Enabled = False
            Me.lciShowRowGrandTotal.Location = New System.Drawing.Point(0, 48)
            Me.lciShowRowGrandTotal.Name = "lciShowRowGrandTotal"
            Me.lciShowRowGrandTotal.Size = New System.Drawing.Size(221, 24)
            Me.lciShowRowGrandTotal.TextVisible = False
            ' 
            ' lcgLabelOptions
            ' 
            Me.lcgLabelOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.lcgLabelOptions.AppearanceGroup.Options.UseBorderColor = True
            Me.lcgLabelOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgLabelOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.lcgLabelOptions.Location = New System.Drawing.Point(0, 138)
            Me.lcgLabelOptions.Name = "lcgLabelOptions"
            Me.lcgLabelOptions.Size = New System.Drawing.Size(241, 66)
            Me.lcgLabelOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgLabelOptions.Text = "Label"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.checkEditLabelVisible
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' PivotGridChartingDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "PivotGridChartingDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditSelectionOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowColumnGrandTotal.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditGenerateSeriesByColumns.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowRowGrandTotal.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgCommonOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciShowColumnGrandTotal), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciShowRowGrandTotal), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgLabelOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private checkEditSelectionOnly As DevExpress.XtraEditors.CheckEdit

        Private checkEditShowColumnGrandTotal As DevExpress.XtraEditors.CheckEdit

        Private checkEditGenerateSeriesByColumns As DevExpress.XtraEditors.CheckEdit

        Private checkEditShowRowGrandTotal As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private lcgCommonOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private lciShowColumnGrandTotal As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private lciShowRowGrandTotal As DevExpress.XtraLayout.LayoutControlItem

        Private lcgLabelOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace

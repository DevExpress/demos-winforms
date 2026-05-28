Namespace DevExpress.XtraCharts.Demos

    Partial Class DataGridChartingDemo

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
            Dim seriesKeyColorColorizer1 As DevExpress.XtraCharts.SeriesKeyColorColorizer = New DevExpress.XtraCharts.SeriesKeyColorColorizer()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleAboveBelowAverage1 As DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage = New DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleAboveBelowAverage2 As DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage = New DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim seriesTemplateAdapter2 As DevExpress.XtraCharts.SeriesTemplateAdapter = New DevExpress.XtraCharts.SeriesTemplateAdapter()
            Dim dataMember4 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember5 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember6 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim xySeriesUnwindAnimation1 As DevExpress.XtraCharts.XYSeriesUnwindAnimation = New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.gridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.chartTotalUnitsSold = New DevExpress.XtraCharts.ChartControl()
            Me.controlRowSourceTotalUnitsSold = New DevExpress.Data.Controls.ControlRowSource()
            Me.gridView = New DevExpress.XtraCharts.Demos.SalesGridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chartMonthlyRevenue = New DevExpress.XtraCharts.ChartControl()
            Me.controlRowSourceMonthlyRevenue = New DevExpress.Data.Controls.ControlRowSource()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.chartTotalUnitsSold), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.controlRowSourceTotalUnitsSold), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chartMonthlyRevenue), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.controlRowSourceMonthlyRevenue), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridColumn9
            ' 
            Me.gridColumn9.Caption = "SalesDynamic"
            Me.gridColumn9.FieldName = "SalesDynamic"
            Me.gridColumn9.Name = "gridColumn9"
            Me.gridColumn9.Visible = True
            Me.gridColumn9.VisibleIndex = 7
            ' 
            ' chartTotalUnitsSold
            ' 
            Me.chartTotalUnitsSold.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.chartTotalUnitsSold.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartTotalUnitsSold.DataSource = Me.controlRowSourceTotalUnitsSold
            xyDiagram1.AxisX.QualitativeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartTotalUnitsSold.Diagram = xyDiagram1
            Me.chartTotalUnitsSold.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartTotalUnitsSold.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartTotalUnitsSold.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartTotalUnitsSold.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartTotalUnitsSold.Legend.Name = "Default Legend"
            Me.chartTotalUnitsSold.Location = New System.Drawing.Point(12, 273)
            Me.chartTotalUnitsSold.Name = "chartTotalUnitsSold"
            Me.chartTotalUnitsSold.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            dataMember1.ColumnName = "Category"
            dataMember2.ColumnName = "UnitsSold"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "State"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            Me.chartTotalUnitsSold.SeriesTemplate.DataAdapter = seriesTemplateAdapter1
            Me.chartTotalUnitsSold.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1
            Me.chartTotalUnitsSold.Size = New System.Drawing.Size(300, 147)
            Me.chartTotalUnitsSold.TabIndex = 2
            chartTitle1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
            chartTitle1.Text = "Total Units Sold"
            Me.chartTotalUnitsSold.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chartTotalUnitsSold.Click, New System.EventHandler(AddressOf Me.OnChartControlClick)
            ' 
            ' controlRowSourceTotalUnitsSold
            ' 
            Me.controlRowSourceTotalUnitsSold.Control = Me.gridView
            Me.controlRowSourceTotalUnitsSold.ControlRows = DevExpress.Data.Controls.ControlRows.Selected
            ' 
            ' gridView
            ' 
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7, Me.gridColumn8, Me.gridColumn9, Me.gridColumn10})
            gridFormatRule1.Column = Me.gridColumn9
            gridFormatRule1.Name = "Format0"
            formatConditionRuleAboveBelowAverage1.AverageType = DevExpress.XtraEditors.FormatConditionAboveBelowType.EqualOrAbove
            formatConditionRuleAboveBelowAverage1.PredefinedName = "Green Text"
            gridFormatRule1.Rule = formatConditionRuleAboveBelowAverage1
            gridFormatRule2.Column = Me.gridColumn9
            gridFormatRule2.Name = "Format1"
            formatConditionRuleAboveBelowAverage2.AverageType = DevExpress.XtraEditors.FormatConditionAboveBelowType.Below
            formatConditionRuleAboveBelowAverage2.PredefinedName = "Red Text"
            gridFormatRule2.Rule = formatConditionRuleAboveBelowAverage2
            Me.gridView.FormatRules.Add(gridFormatRule1)
            Me.gridView.FormatRules.Add(gridFormatRule2)
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.GroupCount = 2
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsCustomization.AllowColumnMoving = False
            Me.gridView.OptionsSelection.MultiSelect = True
            Me.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            Me.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "State"
            Me.gridColumn1.FieldName = "State"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 1
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Product"
            Me.gridColumn2.FieldName = "Product"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "Category"
            Me.gridColumn3.FieldName = "Category"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 10
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.Caption = "UnitsSold"
            Me.gridColumn4.FieldName = "UnitsSold"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 2
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.Caption = "Price"
            Me.gridColumn5.FieldName = "Price"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 3
            ' 
            ' gridColumn6
            ' 
            Me.gridColumn6.Caption = "Revenue"
            Me.gridColumn6.DisplayFormat.FormatString = "c2"
            Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn6.FieldName = "Revenue"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 4
            ' 
            ' gridColumn7
            ' 
            Me.gridColumn7.Caption = "UnitsSoldTarget"
            Me.gridColumn7.FieldName = "UnitsSoldTarget"
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.Visible = True
            Me.gridColumn7.VisibleIndex = 5
            ' 
            ' gridColumn8
            ' 
            Me.gridColumn8.Caption = "RevenueTarget"
            Me.gridColumn8.FieldName = "RevenueTarget"
            Me.gridColumn8.Name = "gridColumn8"
            Me.gridColumn8.Visible = True
            Me.gridColumn8.VisibleIndex = 6
            ' 
            ' gridColumn10
            ' 
            Me.gridColumn10.Caption = "ReportDate"
            Me.gridColumn10.FieldName = "ReportDate"
            Me.gridColumn10.Name = "gridColumn10"
            Me.gridColumn10.Visible = True
            Me.gridColumn10.VisibleIndex = 8
            ' 
            ' gridControl
            ' 
            Me.gridControl.Location = New System.Drawing.Point(12, 47)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(760, 222)
            Me.gridControl.TabIndex = 3
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.gridControl)
            Me.layoutControl1.Controls.Add(Me.chartTotalUnitsSold)
            Me.layoutControl1.Controls.Add(Me.chartMonthlyRevenue)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(671, 55, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(784, 432)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chartMonthlyRevenue
            ' 
            Me.chartMonthlyRevenue.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartMonthlyRevenue.DataSource = Me.controlRowSourceMonthlyRevenue
            xyDiagram2.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.Label.TextPattern = "${V:#,##0,,}M"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartMonthlyRevenue.Diagram = xyDiagram2
            Me.chartMonthlyRevenue.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartMonthlyRevenue.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartMonthlyRevenue.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartMonthlyRevenue.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartMonthlyRevenue.Legend.Name = "Default Legend"
            Me.chartMonthlyRevenue.Location = New System.Drawing.Point(316, 273)
            Me.chartMonthlyRevenue.Name = "chartMonthlyRevenue"
            Me.chartMonthlyRevenue.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartMonthlyRevenue.SeriesTemplate.CrosshairLabelPattern = "{V:$0.00}"
            dataMember4.ColumnName = "ReportDate"
            dataMember5.ColumnName = "Revenue"
            dataMember5.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember6.ColumnName = "Category"
            dataMember6.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateAdapter2.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember4, dataMember5, dataMember6})
            Me.chartMonthlyRevenue.SeriesTemplate.DataAdapter = seriesTemplateAdapter2
            xySeriesUnwindAnimation1.Duration = System.TimeSpan.Parse("00:00:02")
            lineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1
            Me.chartMonthlyRevenue.SeriesTemplate.View = lineSeriesView1
            Me.chartMonthlyRevenue.Size = New System.Drawing.Size(456, 147)
            Me.chartMonthlyRevenue.TabIndex = 5
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
            chartTitle2.Text = "Monthly Revenue"
            Me.chartMonthlyRevenue.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2})
            AddHandler Me.chartMonthlyRevenue.Click, New System.EventHandler(AddressOf Me.OnChartControlClick)
            ' 
            ' controlRowSourceMonthlyRevenue
            ' 
            Me.controlRowSourceMonthlyRevenue.Control = Me.gridView
            Me.controlRowSourceMonthlyRevenue.ControlRows = DevExpress.Data.Controls.ControlRows.Selected
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.simpleLabelItem1, Me.layoutControlItem3, Me.layoutControlItem2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(784, 432)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.chartMonthlyRevenue
            Me.layoutControlItem4.Location = New System.Drawing.Point(304, 261)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(460, 151)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' simpleLabelItem1
            ' 
            Me.simpleLabelItem1.AllowHotTrack = False
            Me.simpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
            Me.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 12)
            Me.simpleLabelItem1.Size = New System.Drawing.Size(764, 35)
            Me.simpleLabelItem1.Text = "Product Sales YTD"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(154, 23)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chartTotalUnitsSold
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 261)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(304, 151)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gridControl
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 35)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(764, 226)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' DataGridChartingDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "DataGridChartingDemo"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartTotalUnitsSold), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.controlRowSourceTotalUnitsSold), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartMonthlyRevenue), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.controlRowSourceMonthlyRevenue), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chartTotalUnitsSold As DevExpress.XtraCharts.ChartControl

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView As DevExpress.XtraCharts.Demos.SalesGridView

        Private controlRowSourceTotalUnitsSold As DevExpress.Data.Controls.ControlRowSource

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private chartMonthlyRevenue As DevExpress.XtraCharts.ChartControl

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private controlRowSourceMonthlyRevenue As DevExpress.Data.Controls.ControlRowSource

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn9 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

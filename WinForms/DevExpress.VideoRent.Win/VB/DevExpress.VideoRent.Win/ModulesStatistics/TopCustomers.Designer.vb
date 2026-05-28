Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class TopCustomersStatistics
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
            Dim SimpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D
            Dim Pie3DSeriesLabel1 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel
            Dim Pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView
            Dim SeriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.spinCustomerCount = New DevExpress.XtraEditors.SpinEdit
            Me.comboPeriod = New DevExpress.XtraEditors.ComboBoxEdit
            Me.chart = New DevExpress.XtraCharts.ChartControl
            Me.pivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl
            Me.fieldRevenue = New DevExpress.XtraPivotGrid.PivotGridField
            Me.fieldCustomer = New DevExpress.XtraPivotGrid.PivotGridField
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.spinCustomerCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.spinCustomerCount)
            Me.layoutControl1.Controls.Add(Me.comboPeriod)
            Me.layoutControl1.Controls.Add(Me.chart)
            Me.layoutControl1.Controls.Add(Me.pivotGrid)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1016, 537)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'spinCustomerCount
            '
            Me.spinCustomerCount.EditValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.spinCustomerCount.Location = New System.Drawing.Point(94, 32)
            Me.spinCustomerCount.Name = "spinCustomerCount"
            Me.spinCustomerCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinCustomerCount.Properties.IsFloatValue = False
            Me.spinCustomerCount.Properties.Mask.EditMask = "N00"
            Me.spinCustomerCount.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinCustomerCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinCustomerCount.Size = New System.Drawing.Size(173, 20)
            Me.spinCustomerCount.StyleController = Me.layoutControl1
            Me.spinCustomerCount.TabIndex = 7
            '
            'comboPeriod
            '
            Me.comboPeriod.EditValue = "Last Month"
            Me.comboPeriod.Location = New System.Drawing.Point(94, 8)
            Me.comboPeriod.Name = "comboPeriod"
            Me.comboPeriod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboPeriod.Properties.Items.AddRange(New Object() {"This Month", "Last Month", "Last 12 Months"})
            Me.comboPeriod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboPeriod.Size = New System.Drawing.Size(173, 20)
            Me.comboPeriod.StyleController = Me.layoutControl1
            Me.comboPeriod.TabIndex = 6
            '
            'chart
            '
            Me.chart.DataSource = Me.pivotGrid
            SimpleDiagram3D1.Dimension = 2
            SimpleDiagram3D1.LabelsResolveOverlappingMinIndent = 6
            SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.80449948567803;-0.5939533462687;0;0;0.5939533462687;0.80449948567803;" & _
                "0;0;0;0;1"
            SimpleDiagram3D1.RuntimeRotation = True
            SimpleDiagram3D1.RuntimeScrolling = True
            SimpleDiagram3D1.RuntimeZooming = True
            Me.chart.Diagram = SimpleDiagram3D1
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.MaxVerticalPercentage = 30
            Me.chart.Location = New System.Drawing.Point(276, 8)
            Me.chart.Name = "chart"
            Me.chart.PaletteName = "Concourse"
            Me.chart.SeriesDataMember = "Series"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Pie3DSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            Pie3DSeriesLabel1.TextPattern = "{V:C2}"
            Pie3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
            Pie3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            Me.chart.SeriesTemplate.Label = Pie3DSeriesLabel1
            Me.chart.SeriesTemplate.LegendTextPattern = "{A}"
            Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Pie3DSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle1})
            Me.chart.SeriesTemplate.View = Pie3DSeriesView1
            Me.chart.Size = New System.Drawing.Size(732, 521)
            Me.chart.TabIndex = 4
            ChartTitle1.Text = "Top Customers"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'pivotGrid
            '
            Me.pivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRevenue, Me.fieldCustomer})
            Me.pivotGrid.Location = New System.Drawing.Point(8, 56)
            Me.pivotGrid.Name = "pivotGrid"
            Me.pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
            Me.pivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = True
            Me.pivotGrid.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGrid.OptionsCustomization.AllowDrag = False
            Me.pivotGrid.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGrid.OptionsView.ShowColumnHeaders = False
            Me.pivotGrid.OptionsView.ShowFilterHeaders = False
            Me.pivotGrid.Size = New System.Drawing.Size(259, 473)
            Me.pivotGrid.TabIndex = 5
            '
            'fieldRevenue
            '
            Me.fieldRevenue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldRevenue.AreaIndex = 0
            Me.fieldRevenue.Caption = "Income"
            Me.fieldRevenue.FieldName = "Payment"
            Me.fieldRevenue.Name = "fieldRevenue"
            '
            'fieldCustomer
            '
            Me.fieldCustomer.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCustomer.AreaIndex = 0
            Me.fieldCustomer.Caption = "Customer"
            Me.fieldCustomer.FieldName = "Customer!"
            Me.fieldCustomer.Name = "fieldCustomer"
            Me.fieldCustomer.SortBySummaryInfo.Field = Me.fieldRevenue
            Me.fieldCustomer.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldCustomer.TopValueCount = 10
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1016, 537)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.chart
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(268, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(736, 525)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.pivotGrid
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(263, 477)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.comboPeriod
            Me.layoutControlItem3.CustomizationFormText = "Period"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(263, 24)
            Me.layoutControlItem3.Text = "Period:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(82, 13)
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.spinCustomerCount
            Me.layoutControlItem4.CustomizationFormText = "Customer Count"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(263, 24)
            Me.layoutControlItem4.Text = "Customer Count:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(82, 13)
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(263, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 525)
            '
            'TopCustomersStatistics
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "TopCustomersStatistics"
            Me.Size = New System.Drawing.Size(1016, 537)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.spinCustomerCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents pivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private fieldRevenue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCustomer As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents comboPeriod As DevExpress.XtraEditors.ComboBoxEdit
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents spinCustomerCount As DevExpress.XtraEditors.SpinEdit
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private chart As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

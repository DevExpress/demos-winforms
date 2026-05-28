Namespace DevExpress.RealtorWorld.Win

    Partial Class ucLoanCalculator

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        Private Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stackedBarSeriesLabel1 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
            Dim stackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stackedBarSeriesLabel2 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
            Dim stackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gcMonth = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.gcBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcPayment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.lcInfo = New DevExpress.XtraEditors.LabelControl()
            Me.editInterestRate = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.editTermOfLoan = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.sbCalc = New DevExpress.XtraEditors.SimpleButton()
            Me.editStart = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.editLoanAmount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciInfo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCalc = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.editInterestRate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.editTermOfLoan.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.editStart.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.editLoanAmount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciInfo), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCalc), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.chartControl1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.lcInfo)
            Me.layoutControl1.Controls.Add(Me.editInterestRate)
            Me.layoutControl1.Controls.Add(Me.editTermOfLoan)
            Me.layoutControl1.Controls.Add(Me.sbCalc)
            Me.layoutControl1.Controls.Add(Me.editStart)
            Me.layoutControl1.Controls.Add(Me.editLoanAmount)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1288, 616)
            Me.layoutControl1.TabIndex = 7
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.CacheToMemory = True
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy}"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.Label.TextPattern = "{V:C0}"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Location = New System.Drawing.Point(2, 162)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Padding.Bottom = 20
            Me.chartControl1.Padding.Left = 20
            Me.chartControl1.Padding.Right = 20
            Me.chartControl1.Padding.Top = 20
            Me.chartControl1.PaletteBaseColorNumber = 5
            Me.chartControl1.PaletteName = "Flow"
            series1.ArgumentDataMember = "Month"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            stackedBarSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            stackedBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.BottomInside
            stackedBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            stackedBarSeriesLabel1.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop
            stackedBarSeriesLabel1.TextPattern = "{V:C0}"
            series1.Label = stackedBarSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Name = "Interest"
            series1.ValueDataMembersSerializable = "Interest"
            series1.View = stackedBarSeriesView1
            series2.ArgumentDataMember = "Month"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            stackedBarSeriesLabel2.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            stackedBarSeriesLabel2.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.TopInside
            stackedBarSeriesLabel2.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop
            stackedBarSeriesLabel2.TextPattern = "{V:C0}"
            series2.Label = stackedBarSeriesLabel2
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.Name = "Principal"
            series2.ValueDataMembersSerializable = "Principal"
            series2.View = stackedBarSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.Size = New System.Drawing.Size(737, 452)
            Me.chartControl1.TabIndex = 12
            chartTitle1.Font = New System.Drawing.Font("Tahoma", 12F)
            chartTitle1.Text = "Payment by Year"
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chartControl1.CustomDrawSeries, New DevExpress.XtraCharts.CustomDrawSeriesEventHandler(AddressOf Me.chartControl1_CustomDrawSeries)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(748, 2)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemButtonEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(538, 612)
            Me.gridControl1.TabIndex = 11
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.gridView1.Appearance.Row.Options.UseFont = True
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcMonth, Me.gcBalance, Me.gcPayment})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            AddHandler Me.gridView1.CustomDrawColumnHeader, New DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(AddressOf Me.gridView1_CustomDrawColumnHeader)
            AddHandler Me.gridView1.CustomDrawCell, New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(AddressOf Me.gridView1_CustomDrawCell)
            AddHandler Me.gridView1.CustomDrawFooterCell, New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(AddressOf Me.gridView1_CustomDrawFooterCell)
            AddHandler Me.gridView1.PopupMenuShowing, New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf Me.gridView1_PopupMenuShowing)
            AddHandler Me.gridView1.CustomSummaryCalculate, New DevExpress.Data.CustomSummaryEventHandler(AddressOf Me.gridView1_CustomSummaryCalculate)
            AddHandler Me.gridView1.FilterPopupExcelData, New DevExpress.XtraGrid.Views.Grid.FilterPopupExcelDataEventHandler(AddressOf Me.gridView1_FilterPopupExcelData)
            ' 
            ' gcMonth
            ' 
            Me.gcMonth.AppearanceCell.Options.UseTextOptions = True
            Me.gcMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gcMonth.Caption = "Month"
            Me.gcMonth.ColumnEdit = Me.repositoryItemButtonEdit1
            Me.gcMonth.FieldName = "MonthNumber"
            Me.gcMonth.Name = "gcMonth"
            Me.gcMonth.OptionsColumn.AllowFocus = False
            Me.gcMonth.OptionsColumn.FixedWidth = True
            Me.gcMonth.OptionsFilter.PopupExcelFilterNumericValuesTabFilterType = DevExpress.XtraGrid.Columns.ExcelFilterNumericValuesTabFilterType.List
            Me.gcMonth.Visible = True
            Me.gcMonth.VisibleIndex = 0
            Me.gcMonth.Width = 156
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            Me.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' gcBalance
            ' 
            Me.gcBalance.DisplayFormat.FormatString = "c0"
            Me.gcBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcBalance.FieldName = "Balance"
            Me.gcBalance.Name = "gcBalance"
            Me.gcBalance.OptionsColumn.AllowFocus = False
            Me.gcBalance.Visible = True
            Me.gcBalance.VisibleIndex = 1
            Me.gcBalance.Width = 101
            ' 
            ' gcPayment
            ' 
            Me.gcPayment.DisplayFormat.FormatString = "c"
            Me.gcPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcPayment.FieldName = "MonthlyPayment"
            Me.gcPayment.MinWidth = 200
            Me.gcPayment.Name = "gcPayment"
            Me.gcPayment.OptionsColumn.AllowFocus = False
            Me.gcPayment.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gcPayment.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.gcPayment.OptionsFilter.AllowAutoFilter = False
            Me.gcPayment.OptionsFilter.AllowFilter = False
            Me.gcPayment.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "MonthlyPayment", "{0:c}")})
            Me.gcPayment.Visible = True
            Me.gcPayment.VisibleIndex = 2
            Me.gcPayment.Width = 338
            ' 
            ' lcInfo
            ' 
            Me.lcInfo.AllowHtmlString = True
            Me.lcInfo.Appearance.Options.UseTextOptions = True
            Me.lcInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lcInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lcInfo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lcInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lcInfo.Location = New System.Drawing.Point(339, 2)
            Me.lcInfo.Name = "lcInfo"
            Me.lcInfo.Size = New System.Drawing.Size(400, 156)
            Me.lcInfo.StyleController = Me.layoutControl1
            Me.lcInfo.TabIndex = 7
            ' 
            ' editInterestRate
            ' 
            Me.editInterestRate.Location = New System.Drawing.Point(74, 28)
            Me.editInterestRate.Name = "editInterestRate"
            Me.editInterestRate.Properties.Appearance.Options.UseTextOptions = True
            Me.editInterestRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.editInterestRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.editInterestRate.Properties.DropDownRows = 12
            Me.editInterestRate.Size = New System.Drawing.Size(261, 20)
            Me.editInterestRate.StyleController = Me.layoutControl1
            Me.editInterestRate.TabIndex = 5
            ' 
            ' editTermOfLoan
            ' 
            Me.editTermOfLoan.EditValue = "15"
            Me.editTermOfLoan.Location = New System.Drawing.Point(74, 54)
            Me.editTermOfLoan.Name = "editTermOfLoan"
            Me.editTermOfLoan.Properties.Appearance.Options.UseTextOptions = True
            Me.editTermOfLoan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.editTermOfLoan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.editTermOfLoan.Size = New System.Drawing.Size(261, 20)
            Me.editTermOfLoan.StyleController = Me.layoutControl1
            Me.editTermOfLoan.TabIndex = 6
            ' 
            ' sbCalc
            ' 
            Me.sbCalc.Location = New System.Drawing.Point(0, 114)
            Me.sbCalc.Name = "sbCalc"
            Me.sbCalc.Size = New System.Drawing.Size(337, 22)
            Me.sbCalc.StyleController = Me.layoutControl1
            Me.sbCalc.TabIndex = 5
            Me.sbCalc.Text = "Calculate"
            AddHandler Me.sbCalc.Click, New System.EventHandler(AddressOf Me.sbCalc_Click)
            ' 
            ' editStart
            ' 
            Me.editStart.Location = New System.Drawing.Point(74, 80)
            Me.editStart.Name = "editStart"
            Me.editStart.Properties.Appearance.Options.UseTextOptions = True
            Me.editStart.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.editStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.editStart.Size = New System.Drawing.Size(261, 20)
            Me.editStart.StyleController = Me.layoutControl1
            Me.editStart.TabIndex = 10
            ' 
            ' editLoanAmount
            ' 
            Me.editLoanAmount.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.editLoanAmount.Location = New System.Drawing.Point(74, 2)
            Me.editLoanAmount.Name = "editLoanAmount"
            Me.editLoanAmount.Properties.Appearance.Options.UseTextOptions = True
            Me.editLoanAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.editLoanAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.editLoanAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.editLoanAmount.Properties.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.editLoanAmount.Properties.Mask.EditMask = "c"
            Me.editLoanAmount.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.editLoanAmount.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.editLoanAmount.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.editLoanAmount.Size = New System.Drawing.Size(261, 20)
            Me.editLoanAmount.StyleController = Me.layoutControl1
            Me.editLoanAmount.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem7, Me.layoutControlItem8, Me.lciInfo, Me.lciCalc, Me.layoutControlItem9, Me.splitterItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1288, 616)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.editLoanAmount
            Me.layoutControlItem1.CustomizationFormText = "Loan Amount:"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem1.Size = New System.Drawing.Size(337, 26)
            Me.layoutControlItem1.Text = "Loan Amount:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.editInterestRate
            Me.layoutControlItem2.CustomizationFormText = "Interest Rate:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(337, 26)
            Me.layoutControlItem2.Text = "Interest Rate:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.editTermOfLoan
            Me.layoutControlItem3.CustomizationFormText = "Term of Loan:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 52)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(337, 26)
            Me.layoutControlItem3.Text = "Term of Loan:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.editStart
            Me.layoutControlItem7.CustomizationFormText = "Start Month:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 78)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(337, 24)
            Me.layoutControlItem7.Text = "Start Month:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(69, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.gridControl1
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItem8.Location = New System.Drawing.Point(746, 0)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(500, 24)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(542, 616)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' lciInfo
            ' 
            Me.lciInfo.Control = Me.lcInfo
            Me.lciInfo.CustomizationFormText = "layoutControlItem5"
            Me.lciInfo.Location = New System.Drawing.Point(337, 0)
            Me.lciInfo.MinSize = New System.Drawing.Size(14, 17)
            Me.lciInfo.Name = "lciInfo"
            Me.lciInfo.Size = New System.Drawing.Size(404, 160)
            Me.lciInfo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciInfo.TextSize = New System.Drawing.Size(0, 0)
            Me.lciInfo.TextVisible = False
            ' 
            ' lciCalc
            ' 
            Me.lciCalc.Control = Me.sbCalc
            Me.lciCalc.CustomizationFormText = "layoutControlItem4"
            Me.lciCalc.Location = New System.Drawing.Point(0, 102)
            Me.lciCalc.Name = "lciCalc"
            Me.lciCalc.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 24)
            Me.lciCalc.Size = New System.Drawing.Size(337, 58)
            Me.lciCalc.TextSize = New System.Drawing.Size(0, 0)
            Me.lciCalc.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.chartControl1
            Me.layoutControlItem9.CustomizationFormText = "layoutControlItem9"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 160)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(741, 456)
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(741, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 616)
            ' 
            ' ucLoanCalculator
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ucLoanCalculator"
            Me.Size = New System.Drawing.Size(1288, 616)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.editInterestRate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.editTermOfLoan.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.editStart.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.editLoanAmount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciInfo), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCalc), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private lcInfo As DevExpress.XtraEditors.LabelControl

        Private editInterestRate As DevExpress.XtraEditors.ImageComboBoxEdit

        Private editTermOfLoan As DevExpress.XtraEditors.ImageComboBoxEdit

        Private sbCalc As DevExpress.XtraEditors.SimpleButton

        Private editStart As DevExpress.XtraEditors.ImageComboBoxEdit

        Private editLoanAmount As DevExpress.XtraEditors.SpinEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciInfo As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private lciCalc As DevExpress.XtraLayout.LayoutControlItem

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private gcMonth As DevExpress.XtraGrid.Columns.GridColumn

        Private gcBalance As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

        Private gcPayment As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

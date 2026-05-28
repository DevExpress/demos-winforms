namespace DevExpress.RealtorWorld.Win {
    partial class ucLoanCalculator {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesLabel stackedBarSeriesLabel1 = new DevExpress.XtraCharts.StackedBarSeriesLabel();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesLabel stackedBarSeriesLabel2 = new DevExpress.XtraCharts.StackedBarSeriesLabel();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView2 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcInfo = new DevExpress.XtraEditors.LabelControl();
            this.editInterestRate = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.editTermOfLoan = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.sbCalc = new DevExpress.XtraEditors.SimpleButton();
            this.editStart = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.editLoanAmount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCalc = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInterestRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTermOfLoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLoanAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.lcInfo);
            this.layoutControl1.Controls.Add(this.editInterestRate);
            this.layoutControl1.Controls.Add(this.editTermOfLoan);
            this.layoutControl1.Controls.Add(this.sbCalc);
            this.layoutControl1.Controls.Add(this.editStart);
            this.layoutControl1.Controls.Add(this.editLoanAmount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1288, 616);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chartControl1
            // 
            this.chartControl1.CacheToMemory = true;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy}";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Label.TextPattern = "{V:C0}";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(2, 162);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Padding.Bottom = 20;
            this.chartControl1.Padding.Left = 20;
            this.chartControl1.Padding.Right = 20;
            this.chartControl1.Padding.Top = 20;
            this.chartControl1.PaletteBaseColorNumber = 5;
            this.chartControl1.PaletteName = "Flow";
            series1.ArgumentDataMember = "Month";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stackedBarSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            stackedBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.BottomInside;
            stackedBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            stackedBarSeriesLabel1.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop;
            stackedBarSeriesLabel1.TextPattern = "{V:C0}";
            series1.Label = stackedBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Interest";
            series1.ValueDataMembersSerializable = "Interest";
            series1.View = stackedBarSeriesView1;
            series2.ArgumentDataMember = "Month";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stackedBarSeriesLabel2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            stackedBarSeriesLabel2.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.TopInside;
            stackedBarSeriesLabel2.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop;
            stackedBarSeriesLabel2.TextPattern = "{V:C0}";
            series2.Label = stackedBarSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "Principal";
            series2.ValueDataMembersSerializable = "Principal";
            series2.View = stackedBarSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Size = new System.Drawing.Size(737, 452);
            this.chartControl1.TabIndex = 12;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 12F);
            chartTitle1.Text = "Payment by Year";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartControl1.CustomDrawSeries += new DevExpress.XtraCharts.CustomDrawSeriesEventHandler(this.chartControl1_CustomDrawSeries);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(748, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(538, 612);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMonth,
            this.gcBalance,
            this.gcPayment});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.gridView1_CustomDrawColumnHeader);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gridView1_CustomSummaryCalculate);
            this.gridView1.FilterPopupExcelData += new DevExpress.XtraGrid.Views.Grid.FilterPopupExcelDataEventHandler(this.gridView1_FilterPopupExcelData);
            // 
            // gcMonth
            // 
            this.gcMonth.AppearanceCell.Options.UseTextOptions = true;
            this.gcMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gcMonth.Caption = "Month";
            this.gcMonth.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gcMonth.FieldName = "MonthNumber";
            this.gcMonth.Name = "gcMonth";
            this.gcMonth.OptionsColumn.AllowFocus = false;
            this.gcMonth.OptionsColumn.FixedWidth = true;
            this.gcMonth.OptionsFilter.PopupExcelFilterNumericValuesTabFilterType = XtraGrid.Columns.ExcelFilterNumericValuesTabFilterType.List;
            this.gcMonth.Visible = true;
            this.gcMonth.VisibleIndex = 0;
            this.gcMonth.Width = 156;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gcBalance
            // 
            this.gcBalance.DisplayFormat.FormatString = "c0";
            this.gcBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcBalance.FieldName = "Balance";
            this.gcBalance.Name = "gcBalance";
            this.gcBalance.OptionsColumn.AllowFocus = false;
            this.gcBalance.Visible = true;
            this.gcBalance.VisibleIndex = 1;
            this.gcBalance.Width = 101;
            // 
            // gcPayment
            // 
            this.gcPayment.DisplayFormat.FormatString = "c";
            this.gcPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcPayment.FieldName = "MonthlyPayment";
            this.gcPayment.MinWidth = 200;
            this.gcPayment.Name = "gcPayment";
            this.gcPayment.OptionsColumn.AllowFocus = false;
            this.gcPayment.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcPayment.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcPayment.OptionsFilter.AllowAutoFilter = false;
            this.gcPayment.OptionsFilter.AllowFilter = false;
            this.gcPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "MonthlyPayment", "{0:c}")});
            this.gcPayment.Visible = true;
            this.gcPayment.VisibleIndex = 2;
            this.gcPayment.Width = 338;
            // 
            // lcInfo
            // 
            this.lcInfo.AllowHtmlString = true;
            this.lcInfo.Appearance.Options.UseTextOptions = true;
            this.lcInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lcInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcInfo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lcInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lcInfo.Location = new System.Drawing.Point(339, 2);
            this.lcInfo.Name = "lcInfo";
            this.lcInfo.Size = new System.Drawing.Size(400, 156);
            this.lcInfo.StyleController = this.layoutControl1;
            this.lcInfo.TabIndex = 7;
            // 
            // editInterestRate
            // 
            this.editInterestRate.Location = new System.Drawing.Point(74, 28);
            this.editInterestRate.Name = "editInterestRate";
            this.editInterestRate.Properties.Appearance.Options.UseTextOptions = true;
            this.editInterestRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editInterestRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editInterestRate.Properties.DropDownRows = 12;
            this.editInterestRate.Size = new System.Drawing.Size(261, 20);
            this.editInterestRate.StyleController = this.layoutControl1;
            this.editInterestRate.TabIndex = 5;
            // 
            // editTermOfLoan
            // 
            this.editTermOfLoan.EditValue = "15";
            this.editTermOfLoan.Location = new System.Drawing.Point(74, 54);
            this.editTermOfLoan.Name = "editTermOfLoan";
            this.editTermOfLoan.Properties.Appearance.Options.UseTextOptions = true;
            this.editTermOfLoan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editTermOfLoan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editTermOfLoan.Size = new System.Drawing.Size(261, 20);
            this.editTermOfLoan.StyleController = this.layoutControl1;
            this.editTermOfLoan.TabIndex = 6;
            // 
            // sbCalc
            // 
            this.sbCalc.Location = new System.Drawing.Point(0, 114);
            this.sbCalc.Name = "sbCalc";
            this.sbCalc.Size = new System.Drawing.Size(337, 22);
            this.sbCalc.StyleController = this.layoutControl1;
            this.sbCalc.TabIndex = 5;
            this.sbCalc.Text = "Calculate";
            this.sbCalc.Click += new System.EventHandler(this.sbCalc_Click);
            // 
            // editStart
            // 
            this.editStart.Location = new System.Drawing.Point(74, 80);
            this.editStart.Name = "editStart";
            this.editStart.Properties.Appearance.Options.UseTextOptions = true;
            this.editStart.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editStart.Size = new System.Drawing.Size(261, 20);
            this.editStart.StyleController = this.layoutControl1;
            this.editStart.TabIndex = 10;
            // 
            // editLoanAmount
            // 
            this.editLoanAmount.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.editLoanAmount.Location = new System.Drawing.Point(74, 2);
            this.editLoanAmount.Name = "editLoanAmount";
            this.editLoanAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.editLoanAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.editLoanAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.editLoanAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.editLoanAmount.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editLoanAmount.Properties.Mask.EditMask = "c";
            this.editLoanAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.editLoanAmount.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.editLoanAmount.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.editLoanAmount.Size = new System.Drawing.Size(261, 20);
            this.editLoanAmount.StyleController = this.layoutControl1;
            this.editLoanAmount.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.lciInfo,
            this.lciCalc,
            this.layoutControlItem9,
            this.splitterItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1288, 616);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.editLoanAmount;
            this.layoutControlItem1.CustomizationFormText = "Loan Amount:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(337, 26);
            this.layoutControlItem1.Text = "Loan Amount:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.editInterestRate;
            this.layoutControlItem2.CustomizationFormText = "Interest Rate:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(337, 26);
            this.layoutControlItem2.Text = "Interest Rate:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.editTermOfLoan;
            this.layoutControlItem3.CustomizationFormText = "Term of Loan:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(337, 26);
            this.layoutControlItem3.Text = "Term of Loan:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.editStart;
            this.layoutControlItem7.CustomizationFormText = "Start Month:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(337, 24);
            this.layoutControlItem7.Text = "Start Month:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.gridControl1;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(746, 0);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(500, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(542, 616);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // lciInfo
            // 
            this.lciInfo.Control = this.lcInfo;
            this.lciInfo.CustomizationFormText = "layoutControlItem5";
            this.lciInfo.Location = new System.Drawing.Point(337, 0);
            this.lciInfo.MinSize = new System.Drawing.Size(14, 17);
            this.lciInfo.Name = "lciInfo";
            this.lciInfo.Size = new System.Drawing.Size(404, 160);
            this.lciInfo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciInfo.TextVisible = false;
            // 
            // lciCalc
            // 
            this.lciCalc.Control = this.sbCalc;
            this.lciCalc.CustomizationFormText = "layoutControlItem4";
            this.lciCalc.Location = new System.Drawing.Point(0, 102);
            this.lciCalc.Name = "lciCalc";
            this.lciCalc.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 24);
            this.lciCalc.Size = new System.Drawing.Size(337, 58);
            this.lciCalc.TextSize = new System.Drawing.Size(0, 0);
            this.lciCalc.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.chartControl1;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(741, 456);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(741, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 616);
            // 
            // ucLoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucLoanCalculator";
            this.Size = new System.Drawing.Size(1288, 616);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInterestRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTermOfLoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLoanAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl lcInfo;
        private DevExpress.XtraEditors.ImageComboBoxEdit editInterestRate;
        private DevExpress.XtraEditors.ImageComboBoxEdit editTermOfLoan;
        private DevExpress.XtraEditors.SimpleButton sbCalc;
        private DevExpress.XtraEditors.ImageComboBoxEdit editStart;
        private DevExpress.XtraEditors.SpinEdit editLoanAmount;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem lciCalc;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcMonth;
        private DevExpress.XtraGrid.Columns.GridColumn gcBalance;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcPayment;
    }
}

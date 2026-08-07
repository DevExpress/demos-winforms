Namespace DevExpress.XtraCharts.Demos

    Partial Class BindingIndividualSeriesDemo

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
        Private Overloads Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim summaryDataAdapter1 As DevExpress.XtraCharts.SummaryDataAdapter = New DevExpress.XtraCharts.SummaryDataAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim barGrowUpAnimation1 As DevExpress.XtraCharts.BarGrowUpAnimation = New DevExpress.XtraCharts.BarGrowUpAnimation()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim summaryDataAdapter2 As DevExpress.XtraCharts.SummaryDataAdapter = New DevExpress.XtraCharts.SummaryDataAdapter()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember4 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.labelSortOrder = New DevExpress.XtraEditors.LabelControl()
            Me.labelSortBy = New DevExpress.XtraEditors.LabelControl()
            Me.labelFilter = New DevExpress.XtraEditors.LabelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sidePanel3 = New DevExpress.XtraEditors.SidePanel()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEditFilterBy = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditSortBy = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditSortOrdering = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditArgumentDataMember = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditValueDataMember = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciNorthArgumentDataMember = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciNorthSortingKey = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciNorthFilterByCategory = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciNorthValueDataMember = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciNorthSortOrdering = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.sidePanel2.SuspendLayout()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel3.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.comboBoxEditFilterBy.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditSortBy.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditSortOrdering.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditArgumentDataMember.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditValueDataMember.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciNorthArgumentDataMember), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciNorthSortingKey), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciNorthFilterByCategory), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciNorthValueDataMember), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciNorthSortOrdering), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ShowOutOfRangePoints = True
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.MinIndent = -5
            xyDiagram1.AxisX.QualitativeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.Title.Text = "Products"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Interlaced = True
            xyDiagram1.AxisY.Title.Text = "Amount"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            series1.CrosshairLabelPattern = "{S} : ${V}K"
            dataMember1.ColumnName = "Product"
            dataMember2.ColumnName = "Income"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            summaryDataAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2})
            summaryDataAdapter1.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])"
            series1.DataAdapter = summaryDataAdapter1
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Label = sideBySideBarSeriesLabel1
            series1.Name = "DevAV North"
            series1.SeriesID = 0
            barGrowUpAnimation1.Duration = System.TimeSpan.Parse("00:00:00.8000000")
            barGrowUpAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.0100000")
            sideBySideBarSeriesView1.Animation = barGrowUpAnimation1
            series1.View = sideBySideBarSeriesView1
            series2.CrosshairLabelPattern = "{S} : ${V}K"
            dataMember3.ColumnName = "Product"
            dataMember4.ColumnName = "Income"
            dataMember4.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            summaryDataAdapter2.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember3, dataMember4})
            summaryDataAdapter2.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])"
            series2.DataAdapter = summaryDataAdapter2
            series2.Name = "DevAV South"
            series2.SeriesID = 1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel2
            Me.chart.Size = New System.Drawing.Size(546, 347)
            Me.chart.TabIndex = 1
            Me.chart.TabStop = False
            chartTitle1.DXAlignment = DevExpress.Drawing.DXStringAlignment.Near
            chartTitle1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            chartTitle1.Text = ""
            chartTitle1.TitleID = 0
            chartTitle2.Text = "Volume (thousands of USD)"
            chartTitle2.TitleID = 1
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chart_BoundDataChanged)
            ' 
            ' labelSortOrder
            ' 
            Me.labelSortOrder.Location = New System.Drawing.Point(12, 12)
            Me.labelSortOrder.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
            Me.labelSortOrder.Name = "labelSortOrder"
            Me.labelSortOrder.Size = New System.Drawing.Size(55, 13)
            Me.labelSortOrder.TabIndex = 13
            Me.labelSortOrder.Text = "Sort Order:"
            ' 
            ' labelSortBy
            ' 
            Me.labelSortBy.Location = New System.Drawing.Point(12, 40)
            Me.labelSortBy.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
            Me.labelSortBy.Name = "labelSortBy"
            Me.labelSortBy.Size = New System.Drawing.Size(39, 13)
            Me.labelSortBy.TabIndex = 14
            Me.labelSortBy.Text = "Sort By:"
            ' 
            ' labelFilter
            ' 
            Me.labelFilter.Location = New System.Drawing.Point(188, 12)
            Me.labelFilter.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
            Me.labelFilter.Name = "labelFilter"
            Me.labelFilter.Size = New System.Drawing.Size(91, 13)
            Me.labelFilter.TabIndex = 15
            Me.labelFilter.Text = "Filter By Category:"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.chart)
            Me.sidePanel1.Controls.Add(Me.sidePanel2)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(546, 571)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.gridControl2)
            Me.sidePanel2.Controls.Add(Me.sidePanel3)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanel2.Location = New System.Drawing.Point(0, 347)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(546, 224)
            Me.sidePanel2.TabIndex = 0
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl2.Location = New System.Drawing.Point(403, 1)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.Size = New System.Drawing.Size(143, 223)
            Me.gridControl2.TabIndex = 1
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn8})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView2.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView2.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView2.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView2.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView2.OptionsBehavior.AllowValidationErrors = False
            Me.gridView2.OptionsBehavior.Editable = False
            Me.gridView2.OptionsBehavior.[ReadOnly] = True
            Me.gridView2.OptionsCustomization.AllowColumnMoving = False
            Me.gridView2.OptionsCustomization.AllowColumnResizing = False
            Me.gridView2.OptionsCustomization.AllowFilter = False
            Me.gridView2.OptionsCustomization.AllowGroup = False
            Me.gridView2.OptionsCustomization.AllowQuickHideColumns = False
            Me.gridView2.OptionsFilter.AllowFilterEditor = False
            Me.gridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView2.OptionsSelection.MultiSelect = True
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.OptionsView.ShowViewCaption = True
            Me.gridView2.ViewCaption = "DevAV South"
            AddHandler Me.gridView2.SelectionChanged, New DevExpress.Data.SelectionChangedEventHandler(AddressOf Me.OnGridViewSelectionChanged)
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.Caption = "Category"
            Me.gridColumn4.FieldName = "Category"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 0
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.Caption = "Product"
            Me.gridColumn5.FieldName = "Product"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 1
            ' 
            ' gridColumn6
            ' 
            Me.gridColumn6.Caption = "Income"
            Me.gridColumn6.FieldName = "Income"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 2
            ' 
            ' gridColumn8
            ' 
            Me.gridColumn8.Caption = "Revenue"
            Me.gridColumn8.CustomizationCaption = "Revenue"
            Me.gridColumn8.FieldName = "Revenue"
            Me.gridColumn8.Name = "gridColumn8"
            Me.gridColumn8.Visible = True
            Me.gridColumn8.VisibleIndex = 3
            ' 
            ' sidePanel3
            ' 
            Me.sidePanel3.Controls.Add(Me.gridControl1)
            Me.sidePanel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel3.Location = New System.Drawing.Point(0, 1)
            Me.sidePanel3.Name = "sidePanel3"
            Me.sidePanel3.Size = New System.Drawing.Size(403, 223)
            Me.sidePanel3.TabIndex = 0
            Me.sidePanel3.Text = "sidePanel3"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(402, 223)
            Me.gridControl1.TabIndex = 2
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn7})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowPartialRedrawOnScrolling = False
            Me.gridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowValidationErrors = False
            Me.gridView1.OptionsBehavior.AutoSelectAllInEditor = False
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsBehavior.[ReadOnly] = True
            Me.gridView1.OptionsCustomization.AllowColumnMoving = False
            Me.gridView1.OptionsCustomization.AllowColumnResizing = False
            Me.gridView1.OptionsCustomization.AllowFilter = False
            Me.gridView1.OptionsCustomization.AllowGroup = False
            Me.gridView1.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsCustomization.AllowQuickHideColumns = False
            Me.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsFilter.AllowFilterEditor = False
            Me.gridView1.OptionsFind.AllowFindPanel = False
            Me.gridView1.OptionsMenu.EnableColumnMenu = False
            Me.gridView1.OptionsMenu.EnableFooterMenu = False
            Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
            Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowViewCaption = True
            Me.gridView1.ViewCaption = "DevAV North"
            AddHandler Me.gridView1.SelectionChanged, New DevExpress.Data.SelectionChangedEventHandler(AddressOf Me.OnGridViewSelectionChanged)
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "Category"
            Me.gridColumn1.FieldName = "Category"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
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
            Me.gridColumn3.Caption = "Income"
            Me.gridColumn3.FieldName = "Income"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            ' 
            ' gridColumn7
            ' 
            Me.gridColumn7.Caption = "Revenue"
            Me.gridColumn7.FieldName = "Revenue"
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.Visible = True
            Me.gridColumn7.VisibleIndex = 3
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.comboBoxEditFilterBy)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditSortBy)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditSortOrdering)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditArgumentDataMember)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditValueDataMember)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(941, 150, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' comboBoxEditFilterBy
            ' 
            Me.comboBoxEditFilterBy.EditValue = "All Categories"
            Me.comboBoxEditFilterBy.Location = New System.Drawing.Point(142, 60)
            Me.comboBoxEditFilterBy.Name = "comboBoxEditFilterBy"
            Me.comboBoxEditFilterBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditFilterBy.Properties.Items.AddRange(New Object() {"All Categories", "Cameras", "Cell Phones", "Computers", "TV, Audio"})
            Me.comboBoxEditFilterBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditFilterBy.Size = New System.Drawing.Size(87, 20)
            Me.comboBoxEditFilterBy.StyleController = Me.layoutControl1
            Me.comboBoxEditFilterBy.TabIndex = 17
            AddHandler Me.comboBoxEditFilterBy.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditFilterBy_SelectedIndexChanged)
            ' 
            ' comboBoxEditSortBy
            ' 
            Me.comboBoxEditSortBy.EditValue = "Argument"
            Me.comboBoxEditSortBy.Location = New System.Drawing.Point(142, 108)
            Me.comboBoxEditSortBy.Name = "comboBoxEditSortBy"
            Me.comboBoxEditSortBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSortBy.Properties.Items.AddRange(New Object() {"Argument", "Series1 Value", "Series2 Value"})
            Me.comboBoxEditSortBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSortBy.Size = New System.Drawing.Size(87, 20)
            Me.comboBoxEditSortBy.StyleController = Me.layoutControl1
            Me.comboBoxEditSortBy.TabIndex = 18
            AddHandler Me.comboBoxEditSortBy.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSortBy_SelectedIndexChanged)
            ' 
            ' comboBoxEditSortOrdering
            ' 
            Me.comboBoxEditSortOrdering.EditValue = "None"
            Me.comboBoxEditSortOrdering.Location = New System.Drawing.Point(142, 84)
            Me.comboBoxEditSortOrdering.Name = "comboBoxEditSortOrdering"
            Me.comboBoxEditSortOrdering.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSortOrdering.Properties.Items.AddRange(New Object() {"None", "Ascending", "Descending"})
            Me.comboBoxEditSortOrdering.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSortOrdering.Size = New System.Drawing.Size(87, 20)
            Me.comboBoxEditSortOrdering.StyleController = Me.layoutControl1
            Me.comboBoxEditSortOrdering.TabIndex = 19
            AddHandler Me.comboBoxEditSortOrdering.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSortOrdering_SelectedIndexChanged)
            ' 
            ' comboBoxEditArgumentDataMember
            ' 
            Me.comboBoxEditArgumentDataMember.EditValue = "Product"
            Me.comboBoxEditArgumentDataMember.Location = New System.Drawing.Point(142, 12)
            Me.comboBoxEditArgumentDataMember.Name = "comboBoxEditArgumentDataMember"
            Me.comboBoxEditArgumentDataMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditArgumentDataMember.Properties.Items.AddRange(New Object() {"Product", "Category"})
            Me.comboBoxEditArgumentDataMember.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditArgumentDataMember.Size = New System.Drawing.Size(87, 20)
            Me.comboBoxEditArgumentDataMember.StyleController = Me.layoutControl1
            Me.comboBoxEditArgumentDataMember.TabIndex = 20
            AddHandler Me.comboBoxEditArgumentDataMember.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditArgumentDataMember_SelectedIndexChanged)
            ' 
            ' comboBoxEditValueDataMember
            ' 
            Me.comboBoxEditValueDataMember.EditValue = "Income"
            Me.comboBoxEditValueDataMember.Location = New System.Drawing.Point(142, 36)
            Me.comboBoxEditValueDataMember.Name = "comboBoxEditValueDataMember"
            Me.comboBoxEditValueDataMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditValueDataMember.Properties.Items.AddRange(New Object() {"Income", "Revenue"})
            Me.comboBoxEditValueDataMember.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditValueDataMember.Size = New System.Drawing.Size(87, 20)
            Me.comboBoxEditValueDataMember.StyleController = Me.layoutControl1
            Me.comboBoxEditValueDataMember.TabIndex = 21
            AddHandler Me.comboBoxEditValueDataMember.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditValueDataMember_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.lciNorthArgumentDataMember, Me.lciNorthSortingKey, Me.lciNorthFilterByCategory, Me.lciNorthValueDataMember, Me.lciNorthSortOrdering})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(221, 518)
            Me.layoutControlGroup2.Text = "Marker Kind"
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(221, 398)
            ' 
            ' lciNorthArgumentDataMember
            ' 
            Me.lciNorthArgumentDataMember.Control = Me.comboBoxEditArgumentDataMember
            Me.lciNorthArgumentDataMember.Location = New System.Drawing.Point(0, 0)
            Me.lciNorthArgumentDataMember.Name = "lciNorthArgumentDataMember"
            Me.lciNorthArgumentDataMember.Size = New System.Drawing.Size(221, 24)
            Me.lciNorthArgumentDataMember.Text = "Argument Data Member:"
            Me.lciNorthArgumentDataMember.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' lciNorthSortingKey
            ' 
            Me.lciNorthSortingKey.Control = Me.comboBoxEditSortBy
            Me.lciNorthSortingKey.Enabled = False
            Me.lciNorthSortingKey.Location = New System.Drawing.Point(0, 96)
            Me.lciNorthSortingKey.Name = "lciNorthSortingKey"
            Me.lciNorthSortingKey.Size = New System.Drawing.Size(221, 24)
            Me.lciNorthSortingKey.Text = "Sort By:"
            Me.lciNorthSortingKey.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' lciNorthFilterByCategory
            ' 
            Me.lciNorthFilterByCategory.Control = Me.comboBoxEditFilterBy
            Me.lciNorthFilterByCategory.Location = New System.Drawing.Point(0, 48)
            Me.lciNorthFilterByCategory.Name = "lciNorthFilterByCategory"
            Me.lciNorthFilterByCategory.Size = New System.Drawing.Size(221, 24)
            Me.lciNorthFilterByCategory.Text = "Filter By:"
            Me.lciNorthFilterByCategory.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' lciNorthValueDataMember
            ' 
            Me.lciNorthValueDataMember.Control = Me.comboBoxEditValueDataMember
            Me.lciNorthValueDataMember.Location = New System.Drawing.Point(0, 24)
            Me.lciNorthValueDataMember.Name = "lciNorthValueDataMember"
            Me.lciNorthValueDataMember.Size = New System.Drawing.Size(221, 24)
            Me.lciNorthValueDataMember.Text = "Value Data Member:"
            Me.lciNorthValueDataMember.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' lciNorthSortOrdering
            ' 
            Me.lciNorthSortOrdering.Control = Me.comboBoxEditSortOrdering
            Me.lciNorthSortOrdering.Location = New System.Drawing.Point(0, 72)
            Me.lciNorthSortOrdering.Name = "lciNorthSortOrdering"
            Me.lciNorthSortOrdering.Size = New System.Drawing.Size(221, 24)
            Me.lciNorthSortOrdering.Text = "Sort Ordering:"
            Me.lciNorthSortOrdering.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' BindingIndividualSeriesDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "BindingIndividualSeriesDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel3.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.comboBoxEditFilterBy.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditSortBy.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditSortOrdering.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditArgumentDataMember.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditValueDataMember.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciNorthArgumentDataMember), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciNorthSortingKey), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciNorthFilterByCategory), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciNorthValueDataMember), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciNorthSortOrdering), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private labelSortOrder As DevExpress.XtraEditors.LabelControl

        Private labelFilter As DevExpress.XtraEditors.LabelControl

        Private labelSortBy As DevExpress.XtraEditors.LabelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private sidePanel3 As DevExpress.XtraEditors.SidePanel

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

        Private comboBoxEditFilterBy As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditSortBy As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditSortOrdering As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditArgumentDataMember As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditValueDataMember As DevExpress.XtraEditors.ComboBoxEdit

        Private lciNorthFilterByCategory As DevExpress.XtraLayout.LayoutControlItem

        Private lciNorthArgumentDataMember As DevExpress.XtraLayout.LayoutControlItem

        Private lciNorthSortOrdering As DevExpress.XtraLayout.LayoutControlItem

        Private lciNorthValueDataMember As DevExpress.XtraLayout.LayoutControlItem

        Private lciNorthSortingKey As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

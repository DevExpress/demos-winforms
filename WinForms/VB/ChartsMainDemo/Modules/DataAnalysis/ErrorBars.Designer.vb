Namespace DevExpress.XtraCharts.Demos

    Partial Class ErrorBarsDemo

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
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Me.dataSet = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.dataColumn4 = New System.Data.DataColumn()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupEndStyle = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupDirection = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupErrorBarsKind = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupSeriesView = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupDirection = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemDirection = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupErrorBarKind = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemErrorBarKind = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupSeriesView = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeriesView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupEndStyle = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemEndStyle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.dataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.radioGroupEndStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupDirection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupErrorBarsKind.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupSeriesView.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupDirection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemDirection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupErrorBarKind), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemErrorBarKind), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupSeriesView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupEndStyle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemEndStyle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 544)
            ' 
            ' dataSet
            ' 
            Me.dataSet.DataSetName = "ChartDataSource"
            Me.dataSet.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
            Me.dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.Caption = "Argument"
            Me.dataColumn1.ColumnName = "Argument"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Value"
            Me.dataColumn2.DataType = GetType(Double)
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "PositiveError"
            Me.dataColumn3.DataType = GetType(Double)
            ' 
            ' dataColumn4
            ' 
            Me.dataColumn4.ColumnName = "NegativeError"
            Me.dataColumn4.DataType = GetType(Double)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupEndStyle)
            Me.layoutControl.Controls.Add(Me.radioGroupDirection)
            Me.layoutControl.Controls.Add(Me.radioGroupErrorBarsKind)
            Me.layoutControl.Controls.Add(Me.radioGroupSeriesView)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 544)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupEndStyle
            ' 
            Me.radioGroupEndStyle.AutoSizeInLayoutControl = True
            Me.radioGroupEndStyle.EditValue = 0
            Me.radioGroupEndStyle.Location = New System.Drawing.Point(12, 259)
            Me.radioGroupEndStyle.Name = "radioGroupEndStyle"
            Me.radioGroupEndStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupEndStyle.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupEndStyle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupEndStyle.Properties.Columns = 1
            Me.radioGroupEndStyle.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Cap"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "No Cap")})
            Me.radioGroupEndStyle.Size = New System.Drawing.Size(217, 38)
            Me.radioGroupEndStyle.StyleController = Me.layoutControl
            Me.radioGroupEndStyle.TabIndex = 17
            AddHandler Me.radioGroupEndStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupEndStyle_SelectedIndexChanged)
            ' 
            ' radioGroupDirection
            ' 
            Me.radioGroupDirection.AutoSizeInLayoutControl = True
            Me.radioGroupDirection.EditValue = 0
            Me.radioGroupDirection.Location = New System.Drawing.Point(12, 163)
            Me.radioGroupDirection.Name = "radioGroupDirection"
            Me.radioGroupDirection.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupDirection.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupDirection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupDirection.Properties.Columns = 1
            Me.radioGroupDirection.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Both"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Minus"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Plus")})
            Me.radioGroupDirection.Size = New System.Drawing.Size(217, 53)
            Me.radioGroupDirection.StyleController = Me.layoutControl
            Me.radioGroupDirection.TabIndex = 18
            AddHandler Me.radioGroupDirection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupDirection_SelectedIndexChanged)
            ' 
            ' radioGroupErrorBarsKind
            ' 
            Me.radioGroupErrorBarsKind.AutoSizeInLayoutControl = True
            Me.radioGroupErrorBarsKind.Location = New System.Drawing.Point(12, 112)
            Me.radioGroupErrorBarsKind.Name = "radioGroupErrorBarsKind"
            Me.radioGroupErrorBarsKind.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupErrorBarsKind.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupErrorBarsKind.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupErrorBarsKind.Properties.Columns = 1
            Me.radioGroupErrorBarsKind.Size = New System.Drawing.Size(217, 8)
            Me.radioGroupErrorBarsKind.StyleController = Me.layoutControl
            Me.radioGroupErrorBarsKind.TabIndex = 16
            AddHandler Me.radioGroupErrorBarsKind.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupErrorBarsKind_SelectedIndexChanged)
            ' 
            ' radioGroupSeriesView
            ' 
            Me.radioGroupSeriesView.AutoSizeInLayoutControl = True
            Me.radioGroupSeriesView.EditValue = 0
            Me.radioGroupSeriesView.Location = New System.Drawing.Point(12, 31)
            Me.radioGroupSeriesView.Name = "radioGroupSeriesView"
            Me.radioGroupSeriesView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupSeriesView.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupSeriesView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupSeriesView.Properties.Columns = 1
            Me.radioGroupSeriesView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Bar"), New DevExpress.XtraEditors.Controls.RadioGroupItem(9, "Point")})
            Me.radioGroupSeriesView.Size = New System.Drawing.Size(217, 38)
            Me.radioGroupSeriesView.StyleController = Me.layoutControl
            Me.radioGroupSeriesView.TabIndex = 15
            AddHandler Me.radioGroupSeriesView.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupSeriesView_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupDirection, Me.layoutControlGroupErrorBarKind, Me.layoutControlGroupSeriesView, Me.emptySpaceItem1, Me.layoutControlGroupEndStyle})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupDirection
            ' 
            Me.layoutControlGroupDirection.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupDirection.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemDirection})
            Me.layoutControlGroupDirection.Location = New System.Drawing.Point(0, 132)
            Me.layoutControlGroupDirection.Name = "layoutControlGroupDirection"
            Me.layoutControlGroupDirection.Size = New System.Drawing.Size(241, 96)
            Me.layoutControlGroupDirection.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupDirection.Text = "Direction"
            ' 
            ' layoutControlItemDirection
            ' 
            Me.layoutControlItemDirection.Control = Me.radioGroupDirection
            Me.layoutControlItemDirection.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemDirection.Name = "layoutControlItemDirection"
            Me.layoutControlItemDirection.Size = New System.Drawing.Size(221, 57)
            Me.layoutControlItemDirection.Text = "Direction:"
            Me.layoutControlItemDirection.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemDirection.TextVisible = False
            ' 
            ' layoutControlGroupErrorBarKind
            ' 
            Me.layoutControlGroupErrorBarKind.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupErrorBarKind.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemErrorBarKind})
            Me.layoutControlGroupErrorBarKind.Location = New System.Drawing.Point(0, 81)
            Me.layoutControlGroupErrorBarKind.Name = "layoutControlGroupErrorBarKind"
            Me.layoutControlGroupErrorBarKind.Size = New System.Drawing.Size(241, 51)
            Me.layoutControlGroupErrorBarKind.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupErrorBarKind.Text = "Error Bar Kind"
            ' 
            ' layoutControlItemErrorBarKind
            ' 
            Me.layoutControlItemErrorBarKind.Control = Me.radioGroupErrorBarsKind
            Me.layoutControlItemErrorBarKind.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemErrorBarKind.Name = "layoutControlItemErrorBarKind"
            Me.layoutControlItemErrorBarKind.Size = New System.Drawing.Size(221, 12)
            Me.layoutControlItemErrorBarKind.Text = "Error Bar Kind:"
            Me.layoutControlItemErrorBarKind.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemErrorBarKind.TextVisible = False
            ' 
            ' layoutControlGroupSeriesView
            ' 
            Me.layoutControlGroupSeriesView.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupSeriesView.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeriesView})
            Me.layoutControlGroupSeriesView.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupSeriesView.Name = "layoutControlGroupSeriesView"
            Me.layoutControlGroupSeriesView.Size = New System.Drawing.Size(241, 81)
            Me.layoutControlGroupSeriesView.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupSeriesView.Text = "SeriesV iew"
            ' 
            ' layoutControlItemSeriesView
            ' 
            Me.layoutControlItemSeriesView.Control = Me.radioGroupSeriesView
            Me.layoutControlItemSeriesView.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView"
            Me.layoutControlItemSeriesView.Size = New System.Drawing.Size(221, 42)
            Me.layoutControlItemSeriesView.Text = "Series View"
            Me.layoutControlItemSeriesView.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemSeriesView.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 309)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(241, 235)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupEndStyle
            ' 
            Me.layoutControlGroupEndStyle.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupEndStyle.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemEndStyle})
            Me.layoutControlGroupEndStyle.Location = New System.Drawing.Point(0, 228)
            Me.layoutControlGroupEndStyle.Name = "layoutControlGroupEndStyle"
            Me.layoutControlGroupEndStyle.Size = New System.Drawing.Size(241, 81)
            Me.layoutControlGroupEndStyle.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupEndStyle.Text = "End Style"
            ' 
            ' layoutControlItemEndStyle
            ' 
            Me.layoutControlItemEndStyle.Control = Me.radioGroupEndStyle
            Me.layoutControlItemEndStyle.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemEndStyle.Name = "layoutControlItemEndStyle"
            Me.layoutControlItemEndStyle.Size = New System.Drawing.Size(221, 42)
            Me.layoutControlItemEndStyle.Text = "End Style:"
            Me.layoutControlItemEndStyle.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemEndStyle.TextVisible = False
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.Auto = False
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "65"
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentDataMember = "Table1.Argument"
            series1.DataSource = Me.dataSet
            series1.LegendName = "Default Legend"
            series1.Name = "Series 1"
            series1.ValueDataMembersSerializable = "Table1.Value"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.SeriesTemplate.LegendName = "Default Legend"
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 3
            ' 
            ' ErrorBarsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "ErrorBarsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.dataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.radioGroupEndStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupDirection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupErrorBarsKind.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupSeriesView.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupDirection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemDirection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupErrorBarKind), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemErrorBarKind), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupSeriesView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupEndStyle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemEndStyle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemDirection As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemEndStyle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemErrorBarKind As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemSeriesView As DevExpress.XtraLayout.LayoutControlItem

        Private dataSet As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private dataColumn4 As System.Data.DataColumn

        Private radioGroupEndStyle As DevExpress.XtraEditors.RadioGroup

        Private radioGroupDirection As DevExpress.XtraEditors.RadioGroup

        Private radioGroupErrorBarsKind As DevExpress.XtraEditors.RadioGroup

        Private radioGroupSeriesView As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupEndStyle As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupDirection As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupErrorBarKind As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupSeriesView As DevExpress.XtraLayout.LayoutControlGroup

        Private chart As DevExpress.XtraCharts.ChartControl

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

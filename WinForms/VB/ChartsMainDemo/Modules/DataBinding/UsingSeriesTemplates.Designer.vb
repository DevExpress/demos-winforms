Namespace DevExpress.XtraCharts.Demos

    Partial Class UsingSeriesTemplatesDemo

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
            Dim seriesTemplateSummaryAdapter1 As DevExpress.XtraCharts.SeriesTemplateSummaryAdapter = New DevExpress.XtraCharts.SeriesTemplateSummaryAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEditSeriesDataMember = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditArgumentDataMember = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditValueDataMember = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditSummaryFunction = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciSeriesDataMember = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciSummaryFunction = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.comboBoxEditSeriesDataMember.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditArgumentDataMember.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditValueDataMember.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditSummaryFunction.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciSeriesDataMember), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciSummaryFunction), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(577, 0)
            Me.sidePanelOptions.Size = New System.Drawing.Size(241, 571)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(240, 571)
            Me.tabPaneOptions.Size = New System.Drawing.Size(240, 571)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(240, 538)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.comboBoxEditSeriesDataMember)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditArgumentDataMember)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditValueDataMember)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditSummaryFunction)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(843, 250, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(240, 538)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' comboBoxEditSeriesDataMember
            ' 
            Me.comboBoxEditSeriesDataMember.EditValue = "Company"
            Me.comboBoxEditSeriesDataMember.Location = New System.Drawing.Point(142, 12)
            Me.comboBoxEditSeriesDataMember.Name = "comboBoxEditSeriesDataMember"
            Me.comboBoxEditSeriesDataMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSeriesDataMember.Properties.Items.AddRange(New Object() {"Company", "Product", "Month"})
            Me.comboBoxEditSeriesDataMember.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSeriesDataMember.Size = New System.Drawing.Size(86, 20)
            Me.comboBoxEditSeriesDataMember.StyleController = Me.layoutControl1
            Me.comboBoxEditSeriesDataMember.TabIndex = 0
            AddHandler Me.comboBoxEditSeriesDataMember.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSeriesDataMember_SelectedIndexChanged)
            ' 
            ' comboBoxEditArgumentDataMember
            ' 
            Me.comboBoxEditArgumentDataMember.EditValue = "Month"
            Me.comboBoxEditArgumentDataMember.Location = New System.Drawing.Point(142, 36)
            Me.comboBoxEditArgumentDataMember.Name = "comboBoxEditArgumentDataMember"
            Me.comboBoxEditArgumentDataMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditArgumentDataMember.Properties.Items.AddRange(New Object() {"Product", "Month"})
            Me.comboBoxEditArgumentDataMember.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditArgumentDataMember.Size = New System.Drawing.Size(86, 20)
            Me.comboBoxEditArgumentDataMember.StyleController = Me.layoutControl1
            Me.comboBoxEditArgumentDataMember.TabIndex = 2
            AddHandler Me.comboBoxEditArgumentDataMember.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditArgumentDataMember_SelectedIndexChanged)
            ' 
            ' comboBoxEditValueDataMember
            ' 
            Me.comboBoxEditValueDataMember.EditValue = "Income"
            Me.comboBoxEditValueDataMember.Location = New System.Drawing.Point(142, 60)
            Me.comboBoxEditValueDataMember.Name = "comboBoxEditValueDataMember"
            Me.comboBoxEditValueDataMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditValueDataMember.Properties.Items.AddRange(New Object() {"Income", "Revenue"})
            Me.comboBoxEditValueDataMember.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditValueDataMember.Size = New System.Drawing.Size(86, 20)
            Me.comboBoxEditValueDataMember.StyleController = Me.layoutControl1
            Me.comboBoxEditValueDataMember.TabIndex = 3
            AddHandler Me.comboBoxEditValueDataMember.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditValueDataMember_SelectedIndexChanged)
            ' 
            ' comboBoxEditSummaryFunction
            ' 
            Me.comboBoxEditSummaryFunction.EditValue = "SUM"
            Me.comboBoxEditSummaryFunction.Location = New System.Drawing.Point(142, 84)
            Me.comboBoxEditSummaryFunction.Name = "comboBoxEditSummaryFunction"
            Me.comboBoxEditSummaryFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSummaryFunction.Properties.Items.AddRange(New Object() {"SUM", "MIN", "MAX", "AVERAGE", "STDDEV (Custom)"})
            Me.comboBoxEditSummaryFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSummaryFunction.Size = New System.Drawing.Size(86, 20)
            Me.comboBoxEditSummaryFunction.StyleController = Me.layoutControl1
            Me.comboBoxEditSummaryFunction.TabIndex = 5
            AddHandler Me.comboBoxEditSummaryFunction.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSummaryFunction_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.lciSeriesDataMember, Me.layoutControlItem2, Me.layoutControlItem3, Me.lciSummaryFunction})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(240, 538)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(220, 422)
            Me.layoutControlGroup2.Text = "Marker Kind"
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(220, 422)
            ' 
            ' lciSeriesDataMember
            ' 
            Me.lciSeriesDataMember.Control = Me.comboBoxEditSeriesDataMember
            Me.lciSeriesDataMember.Location = New System.Drawing.Point(0, 0)
            Me.lciSeriesDataMember.Name = "lciSeriesDataMember"
            Me.lciSeriesDataMember.Size = New System.Drawing.Size(220, 24)
            Me.lciSeriesDataMember.Text = "Series Data Member:"
            Me.lciSeriesDataMember.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.comboBoxEditArgumentDataMember
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(220, 24)
            Me.layoutControlItem2.Text = "Argument Data Member:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.comboBoxEditValueDataMember
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(220, 24)
            Me.layoutControlItem3.Text = "Value Data Member:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' lciSummaryFunction
            ' 
            Me.lciSummaryFunction.Control = Me.comboBoxEditSummaryFunction
            Me.lciSummaryFunction.Location = New System.Drawing.Point(0, 72)
            Me.lciSummaryFunction.Name = "lciSummaryFunction"
            Me.lciSummaryFunction.Size = New System.Drawing.Size(220, 24)
            Me.lciSummaryFunction.Text = "Summary Function:"
            Me.lciSummaryFunction.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.chart)
            Me.sidePanel1.Controls.Add(Me.sidePanel2)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(577, 571)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.GroupHeaderPattern = "<b>{A:yyyy-MM-dd}</b>"
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy-MM-dd}"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.chart.Legend.Title.Text = "Company"
            Me.chart.Legend.Title.Visible = True
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S:yyyy-MM-dd}: {V}"
            dataMember1.ColumnName = "Month"
            dataMember2.ColumnName = "Income"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "Company"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateSummaryAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            Me.chart.SeriesTemplate.DataAdapter = seriesTemplateSummaryAdapter1
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            sideBySideBarSeriesLabel1.TextPattern = "{V:F2}"
            Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chart.SeriesTemplate.LegendTextPattern = "{A:yyyy-MM-dd}"
            Me.chart.Size = New System.Drawing.Size(577, 386)
            Me.chart.TabIndex = 2
            Me.chart.TabStop = False
            chartTitle1.Text = "Volume (Thousands of USD)"
            chartTitle1.TitleID = 0
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chart_BoundDataChanged)
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.gridControl)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanel2.Location = New System.Drawing.Point(0, 386)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(577, 185)
            Me.sidePanel2.TabIndex = 0
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' gridControl
            ' 
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 1)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(577, 184)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            ' 
            ' gridView
            ' 
            Me.gridView.ActiveFilterEnabled = False
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsCustomization.AllowColumnMoving = False
            Me.gridView.OptionsCustomization.AllowFilter = False
            Me.gridView.OptionsFilter.AllowFilterEditor = False
            Me.gridView.OptionsFind.AllowFindPanel = False
            Me.gridView.OptionsMenu.EnableColumnMenu = False
            Me.gridView.OptionsMenu.EnableFooterMenu = False
            Me.gridView.OptionsMenu.EnableGroupPanelMenu = False
            Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView.OptionsSelection.MultiSelect = True
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.OptionsView.ShowViewCaption = True
            Me.gridView.ViewCaption = "Source Data"
            AddHandler Me.gridView.SelectionChanged, New DevExpress.Data.SelectionChangedEventHandler(AddressOf Me.gridView_SelectionChanged)
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "Company"
            Me.gridColumn1.FieldName = "Company"
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
            Me.gridColumn2.Width = 187
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "Month"
            Me.gridColumn3.FieldName = "Month"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 3
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.Caption = "Income"
            Me.gridColumn4.FieldName = "Income"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Income", "SUM={0:0.##}")})
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 2
            Me.gridColumn4.Width = 190
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.Caption = "Revenue"
            Me.gridColumn5.FieldName = "Revenue"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            Me.gridColumn5.Width = 184
            ' 
            ' UsingSeriesTemplatesDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "UsingSeriesTemplatesDemo"
            Me.Size = New System.Drawing.Size(818, 571)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.comboBoxEditSeriesDataMember.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditArgumentDataMember.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditValueDataMember.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditSummaryFunction.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciSeriesDataMember), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciSummaryFunction), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private comboBoxEditSeriesDataMember As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditArgumentDataMember As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditValueDataMember As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private chart As DevExpress.XtraCharts.ChartControl

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private comboBoxEditSummaryFunction As DevExpress.XtraEditors.ComboBoxEdit

        Private lciSeriesDataMember As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private lciSummaryFunction As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

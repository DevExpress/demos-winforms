Namespace DevExpress.XtraCharts.Demos

    Partial Class EmptyPointsDemo

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
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane2 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.labelViewType = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupSeriesView = New DevExpress.XtraEditors.RadioGroup()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupViewType = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeriesView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.radioGroupSeriesView.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupViewType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' labelViewType
            ' 
            Me.labelViewType.Location = New System.Drawing.Point(12, 12)
            Me.labelViewType.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
            Me.labelViewType.Name = "labelViewType"
            Me.labelViewType.Size = New System.Drawing.Size(53, 13)
            Me.labelViewType.TabIndex = 58
            Me.labelViewType.Text = "View Type:"
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupSeriesView)
            Me.layoutControl.Controls.Add(Me.checkEdit1)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(244, 313, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupSeriesView
            ' 
            Me.radioGroupSeriesView.AutoSizeInLayoutControl = True
            Me.radioGroupSeriesView.Location = New System.Drawing.Point(14, 36)
            Me.radioGroupSeriesView.Name = "radioGroupSeriesView"
            Me.radioGroupSeriesView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupSeriesView.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupSeriesView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupSeriesView.Properties.Columns = 1
            Me.radioGroupSeriesView.Size = New System.Drawing.Size(213, 8)
            Me.radioGroupSeriesView.StyleController = Me.layoutControl
            Me.radioGroupSeriesView.TabIndex = 4
            AddHandler Me.radioGroupSeriesView.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup_SelectedIndexChanged)
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.EditValue = True
            Me.checkEdit1.Location = New System.Drawing.Point(12, 92)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Display Empty Points"
            Me.checkEdit1.Size = New System.Drawing.Size(217, 20)
            Me.checkEdit1.StyleController = Me.layoutControl
            Me.checkEdit1.TabIndex = 4
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupViewType, Me.emptySpaceItem, Me.layoutControlGroup1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupViewType
            ' 
            Me.layoutControlGroupViewType.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupViewType.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeriesView})
            Me.layoutControlGroupViewType.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupViewType.Name = "layoutControlGroupViewType"
            Me.layoutControlGroupViewType.Size = New System.Drawing.Size(241, 58)
            Me.layoutControlGroupViewType.Text = "Series Views"
            ' 
            ' layoutControlItemSeriesView
            ' 
            Me.layoutControlItemSeriesView.Control = Me.radioGroupSeriesView
            Me.layoutControlItemSeriesView.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView"
            Me.layoutControlItemSeriesView.Size = New System.Drawing.Size(217, 12)
            Me.layoutControlItemSeriesView.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 124)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 414)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "Empty Points"
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlGroup1.Name = "layoutControlGroupLabel"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 3
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 66)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Empty Points"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.checkEdit1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItemLabelVisible"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ShowOnlyInFocusedPane = False
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "1"
            xyDiagram1.AxisY.Title.Text = "Wind, m/s"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagramPane2.Name = "Pane 2"
            xyDiagramPane2.PaneID = 1
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1, xyDiagramPane2})
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.GridLines.Visible = True
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.Title.Text = "Pressure, mmHg"
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY2.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY2.AxisID = 1
            secondaryAxisY2.GridLines.Visible = True
            secondaryAxisY2.Name = "Secondary AxisY 2"
            secondaryAxisY2.Title.Text = "Temperature, °C"
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            secondaryAxisY2.VisibleInPanesSerializable = "1"
            secondaryAxisY2.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1, secondaryAxisY2})
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentDataMember = "Date"
            series1.CrosshairLabelPattern = "{S}: {V} m/s"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Name = "Wind"
            series1.SeriesID = 0
            series1.ValueDataMembersSerializable = "Wind"
            series2.ArgumentDataMember = "Date"
            series2.CrosshairLabelPattern = "{S}: {V} mmHG"
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.Name = "Pressure"
            series2.SeriesID = 1
            series2.ValueDataMembersSerializable = "Pressure"
            sideBySideBarSeriesView1.AxisYName = "Secondary AxisY 1"
            sideBySideBarSeriesView1.PaneName = "Pane 1"
            series2.View = sideBySideBarSeriesView1
            series3.ArgumentDataMember = "Date"
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series3.Name = "Temperature"
            series3.SeriesID = 2
            series3.ValueDataMembersSerializable = "DayTemperature"
            sideBySideBarSeriesView2.AxisYName = "Secondary AxisY 2"
            sideBySideBarSeriesView2.PaneName = "Pane 2"
            series3.View = sideBySideBarSeriesView2
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3}
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 2
            chartTitle1.Text = "Weather in Washington for July"
            chartTitle1.TitleID = 0
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' EmptyPointsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "EmptyPointsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.radioGroupSeriesView.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupViewType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private labelViewType As DevExpress.XtraEditors.LabelControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private radioGroupSeriesView As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupViewType As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemSeriesView As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private chart As DevExpress.XtraCharts.ChartControl

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

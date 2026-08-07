Namespace DevExpress.XtraCharts.Demos

    Partial Class CustomPaintDemo

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
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView1 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.toggleSwitchClusteringMode = New DevExpress.XtraEditors.ToggleSwitch()
            Me.simpleButtonGeneratePoints = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButtonClearClusters = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupClusteringMode = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemClusteringMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemGeneratePoints = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemClearClusters = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.toggleSwitchClusteringMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupClusteringMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemClusteringMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemGeneratePoints), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemClearClusters), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CacheToMemory = True
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.GridLines.MinorVisible = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Title.Text = "Arguments"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.MinorCount = 4
            xyDiagram1.AxisY.Title.Text = "Values"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Multiple
            Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            pointSeriesLabel1.TextPattern = "{V:F2}"
            series1.Label = pointSeriesLabel1
            series1.Name = "Random Series"
            series1.View = pointSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 3
            chartTitle1.Text = "Random Points Generator"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.SelectedItemsChanging, New DevExpress.XtraCharts.SelectedItemsChangingEventHandler(AddressOf Me.chart_SelectedItemsChanging)
            AddHandler Me.chart.ObjectHotTracked, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chart_ObjectHotTracked)
            AddHandler Me.chart.CustomPaint, New DevExpress.XtraCharts.CustomPaintEventHandler(AddressOf Me.chart_CustomPaint)
            AddHandler Me.chart.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.chart_MouseDown)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.toggleSwitchClusteringMode)
            Me.layoutControl.Controls.Add(Me.simpleButtonGeneratePoints)
            Me.layoutControl.Controls.Add(Me.simpleButtonClearClusters)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' toggleSwitchClusteringMode
            ' 
            Me.toggleSwitchClusteringMode.EditValue = True
            Me.toggleSwitchClusteringMode.Location = New System.Drawing.Point(12, 34)
            Me.toggleSwitchClusteringMode.Name = "toggleSwitchClusteringMode"
            Me.toggleSwitchClusteringMode.Properties.OffText = "Manual"
            Me.toggleSwitchClusteringMode.Properties.OnText = "Automatic"
            Me.toggleSwitchClusteringMode.Size = New System.Drawing.Size(217, 18)
            Me.toggleSwitchClusteringMode.StyleController = Me.layoutControl
            Me.toggleSwitchClusteringMode.TabIndex = 4
            AddHandler Me.toggleSwitchClusteringMode.Toggled, New System.EventHandler(AddressOf Me.toggleSwitchClusteringMode_Toggled)
            ' 
            ' simpleButtonGeneratePoints
            ' 
            Me.simpleButtonGeneratePoints.Location = New System.Drawing.Point(2, 74)
            Me.simpleButtonGeneratePoints.Name = "simpleButtonGeneratePoints"
            Me.simpleButtonGeneratePoints.Size = New System.Drawing.Size(237, 22)
            Me.simpleButtonGeneratePoints.StyleController = Me.layoutControl
            Me.simpleButtonGeneratePoints.TabIndex = 5
            Me.simpleButtonGeneratePoints.Text = "Generate Points"
            AddHandler Me.simpleButtonGeneratePoints.Click, New System.EventHandler(AddressOf Me.simpleButtonGeneratePoints_Click)
            ' 
            ' simpleButtonClearClusters
            ' 
            Me.simpleButtonClearClusters.Location = New System.Drawing.Point(2, 108)
            Me.simpleButtonClearClusters.Name = "simpleButtonClearClusters"
            Me.simpleButtonClearClusters.Size = New System.Drawing.Size(237, 22)
            Me.simpleButtonClearClusters.StyleController = Me.layoutControl
            Me.simpleButtonClearClusters.TabIndex = 6
            Me.simpleButtonClearClusters.Text = "Clear Clusters"
            AddHandler Me.simpleButtonClearClusters.Click, New System.EventHandler(AddressOf Me.simpleButtonClearClusters_Click)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroupClusteringMode, Me.layoutControlItemGeneratePoints, Me.layoutControlItemClearClusters})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 132)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(241, 406)
            ' 
            ' layoutControlGroupClusteringMode
            ' 
            Me.layoutControlGroupClusteringMode.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupClusteringMode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemClusteringMode})
            Me.layoutControlGroupClusteringMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupClusteringMode.Name = "layoutControlGroupClusteringMode"
            Me.layoutControlGroupClusteringMode.Size = New System.Drawing.Size(241, 64)
            Me.layoutControlGroupClusteringMode.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupClusteringMode.Text = "Clustering Mode"
            ' 
            ' layoutControlItemClusteringMode
            ' 
            Me.layoutControlItemClusteringMode.Control = Me.toggleSwitchClusteringMode
            Me.layoutControlItemClusteringMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemClusteringMode.Name = "layoutControlItemClusteringMode"
            Me.layoutControlItemClusteringMode.Size = New System.Drawing.Size(221, 22)
            Me.layoutControlItemClusteringMode.TextVisible = False
            ' 
            ' layoutControlItemGeneratePoints
            ' 
            Me.layoutControlItemGeneratePoints.Control = Me.simpleButtonGeneratePoints
            Me.layoutControlItemGeneratePoints.Location = New System.Drawing.Point(0, 64)
            Me.layoutControlItemGeneratePoints.Name = "layoutControlItemGeneratePoints"
            Me.layoutControlItemGeneratePoints.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItemGeneratePoints.Size = New System.Drawing.Size(241, 34)
            Me.layoutControlItemGeneratePoints.Text = "Generate Points"
            Me.layoutControlItemGeneratePoints.TextVisible = False
            ' 
            ' layoutControlItemClearClusters
            ' 
            Me.layoutControlItemClearClusters.Control = Me.simpleButtonClearClusters
            Me.layoutControlItemClearClusters.Location = New System.Drawing.Point(0, 98)
            Me.layoutControlItemClearClusters.Name = "layoutControlItemClearClusters"
            Me.layoutControlItemClearClusters.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItemClearClusters.Size = New System.Drawing.Size(241, 34)
            Me.layoutControlItemClearClusters.TextVisible = False
            ' 
            ' CustomPaintDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "CustomPaintDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.toggleSwitchClusteringMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupClusteringMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemClusteringMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemGeneratePoints), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemClearClusters), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private toggleSwitchClusteringMode As DevExpress.XtraEditors.ToggleSwitch

        Private simpleButtonGeneratePoints As DevExpress.XtraEditors.SimpleButton

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupClusteringMode As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemClusteringMode As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemGeneratePoints As DevExpress.XtraLayout.LayoutControlItem

        Private simpleButtonClearClusters As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItemClearClusters As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

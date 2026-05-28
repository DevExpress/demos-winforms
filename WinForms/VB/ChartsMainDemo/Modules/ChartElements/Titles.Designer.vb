Namespace DevExpress.XtraCharts.Demos

    Partial Class TitlesDemo

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
            Dim pieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim seriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEditSeriesView = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.textEditTitleText = New DevExpress.XtraEditors.TextEdit()
            Me.checkEditWordWrap = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditDock = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupText = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemWordWrap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemTitleText = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeriesView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupLayout = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemDock = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAlignment = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.comboBoxEditSeriesView.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditTitleText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditWordWrap.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditDock.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditAlignment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupText), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemWordWrap), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTitleText), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemDock), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAlignment), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(772, 0)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 544)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Title.Text = "Products"
            Me.chart.Legend.Title.Visible = True
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.RuntimeHitTesting = True
            Me.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
            Me.chart.SeriesDataMember = "Region"
            Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Argument
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.ArgumentDataMember = "ProductCategory"
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
            pieSeriesLabel1.TextPattern = "{VP:0%}"
            Me.chart.SeriesTemplate.Label = pieSeriesLabel1
            Me.chart.SeriesTemplate.LegendTextPattern = "{A}"
            Me.chart.SeriesTemplate.SeriesDataMember = "Region"
            Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            pieSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {seriesTitle1})
            Me.chart.SeriesTemplate.View = pieSeriesView1
            Me.chart.Size = New System.Drawing.Size(772, 571)
            Me.chart.TabIndex = 2
            Me.chart.TabStop = False
            chartTitle1.Text = "With XtraCharts, <b>you</b> can display an <u>unlimited</u> number of <color=blue" & ">chart titles</color>"
            chartTitle1.WordWrap = True
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.Text = "<size=14>Title</size> <size=+2>with <size=+6>a</size></size> <size=24>variable</s" & "ize> <size=14>font <size=+6>size</size></size>"
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left
            chartTitle3.Text = "<i>Italicized</i> title"
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Right
            chartTitle4.Text = "<color=red>Multi</color>-<color=green>color</color> <color=blue>title</color>"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2, chartTitle3, chartTitle4})
            AddHandler Me.chart.ObjectSelected, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chart_ObjectSelected)
            AddHandler Me.chart.ObjectHotTracked, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chart_ObjectHotTracked)
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chart_BoundDataChanged)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.comboBoxEditSeriesView)
            Me.layoutControl.Controls.Add(Me.textEditTitleText)
            Me.layoutControl.Controls.Add(Me.checkEditWordWrap)
            Me.layoutControl.Controls.Add(Me.comboBoxEditDock)
            Me.layoutControl.Controls.Add(Me.comboBoxEditAlignment)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 544)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' comboBoxEditSeriesView
            ' 
            Me.comboBoxEditSeriesView.Location = New System.Drawing.Point(73, 31)
            Me.comboBoxEditSeriesView.Name = "comboBoxEditSeriesView"
            Me.comboBoxEditSeriesView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSeriesView.Properties.Items.AddRange(New Object() {"Pie", "Bar"})
            Me.comboBoxEditSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSeriesView.Size = New System.Drawing.Size(156, 20)
            Me.comboBoxEditSeriesView.StyleController = Me.layoutControl
            Me.comboBoxEditSeriesView.TabIndex = 4
            AddHandler Me.comboBoxEditSeriesView.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSeriesView_SelectedIndexChanged)
            ' 
            ' textEditTitleText
            ' 
            Me.textEditTitleText.Location = New System.Drawing.Point(12, 94)
            Me.textEditTitleText.Name = "textEditTitleText"
            Me.textEditTitleText.Size = New System.Drawing.Size(217, 20)
            Me.textEditTitleText.StyleController = Me.layoutControl
            Me.textEditTitleText.TabIndex = 5
            AddHandler Me.textEditTitleText.TextChanged, New System.EventHandler(AddressOf Me.textEditTitleText_TextChanged)
            ' 
            ' checkEditWordWrap
            ' 
            Me.checkEditWordWrap.Location = New System.Drawing.Point(12, 118)
            Me.checkEditWordWrap.Name = "checkEditWordWrap"
            Me.checkEditWordWrap.Properties.Caption = "Word Wrap"
            Me.checkEditWordWrap.Size = New System.Drawing.Size(217, 19)
            Me.checkEditWordWrap.StyleController = Me.layoutControl
            Me.checkEditWordWrap.TabIndex = 6
            AddHandler Me.checkEditWordWrap.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditWordWrap_CheckedChanged)
            ' 
            ' comboBoxEditDock
            ' 
            Me.comboBoxEditDock.Location = New System.Drawing.Point(73, 180)
            Me.comboBoxEditDock.Name = "comboBoxEditDock"
            Me.comboBoxEditDock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditDock.Properties.Items.AddRange(New Object() {"Top", "Bottom", "Left", "Right"})
            Me.comboBoxEditDock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditDock.Size = New System.Drawing.Size(156, 20)
            Me.comboBoxEditDock.StyleController = Me.layoutControl
            Me.comboBoxEditDock.TabIndex = 7
            AddHandler Me.comboBoxEditDock.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditDock_SelectedIndexChanged)
            ' 
            ' comboBoxEditAlignment
            ' 
            Me.comboBoxEditAlignment.Location = New System.Drawing.Point(73, 204)
            Me.comboBoxEditAlignment.Name = "comboBoxEditAlignment"
            Me.comboBoxEditAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditAlignment.Properties.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.comboBoxEditAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditAlignment.Size = New System.Drawing.Size(156, 20)
            Me.comboBoxEditAlignment.StyleController = Me.layoutControl
            Me.comboBoxEditAlignment.TabIndex = 8
            AddHandler Me.comboBoxEditAlignment.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditAlignment_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupText, Me.layoutControlGroupGeneral, Me.emptySpaceItem, Me.layoutControlGroupLayout})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupText
            ' 
            Me.layoutControlGroupText.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupText.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemWordWrap, Me.layoutControlItemTitleText})
            Me.layoutControlGroupText.Location = New System.Drawing.Point(0, 63)
            Me.layoutControlGroupText.Name = "layoutControlGroupText"
            Me.layoutControlGroupText.Size = New System.Drawing.Size(241, 86)
            Me.layoutControlGroupText.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupText.Text = "Selected Title Text"
            ' 
            ' layoutControlItemWordWrap
            ' 
            Me.layoutControlItemWordWrap.Control = Me.checkEditWordWrap
            Me.layoutControlItemWordWrap.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemWordWrap.Name = "layoutControlItemWordWrap"
            Me.layoutControlItemWordWrap.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemWordWrap.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemWordWrap.TextVisible = False
            ' 
            ' layoutControlItemTitleText
            ' 
            Me.layoutControlItemTitleText.Control = Me.textEditTitleText
            Me.layoutControlItemTitleText.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemTitleText.Name = "layoutControlItemTitleText"
            Me.layoutControlItemTitleText.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemTitleText.Text = "Text: "
            Me.layoutControlItemTitleText.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemTitleText.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeriesView})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 63)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemSeriesView
            ' 
            Me.layoutControlItemSeriesView.Control = Me.comboBoxEditSeriesView
            Me.layoutControlItemSeriesView.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView"
            Me.layoutControlItemSeriesView.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemSeriesView.Text = "Series View:"
            Me.layoutControlItemSeriesView.TextSize = New System.Drawing.Size(58, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 236)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 308)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupLayout
            ' 
            Me.layoutControlGroupLayout.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLayout.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemDock, Me.layoutControlItemAlignment})
            Me.layoutControlGroupLayout.Location = New System.Drawing.Point(0, 149)
            Me.layoutControlGroupLayout.Name = "layoutControlGroupLayout"
            Me.layoutControlGroupLayout.Size = New System.Drawing.Size(241, 87)
            Me.layoutControlGroupLayout.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLayout.Text = "Selected Title Layout"
            ' 
            ' layoutControlItemDock
            ' 
            Me.layoutControlItemDock.Control = Me.comboBoxEditDock
            Me.layoutControlItemDock.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemDock.Name = "layoutControlItemDock"
            Me.layoutControlItemDock.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemDock.Text = "Dock:"
            Me.layoutControlItemDock.TextSize = New System.Drawing.Size(58, 13)
            ' 
            ' layoutControlItemAlignment
            ' 
            Me.layoutControlItemAlignment.Control = Me.comboBoxEditAlignment
            Me.layoutControlItemAlignment.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemAlignment.Name = "layoutControlItemAlignment"
            Me.layoutControlItemAlignment.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemAlignment.Text = "Alignment:"
            Me.layoutControlItemAlignment.TextSize = New System.Drawing.Size(58, 13)
            ' 
            ' TitlesDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "TitlesDemo"
            Me.Size = New System.Drawing.Size(1014, 571)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.comboBoxEditSeriesView.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditTitleText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditWordWrap.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditDock.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditAlignment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupText), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemWordWrap), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTitleText), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemDock), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAlignment), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private comboBoxEditSeriesView As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemSeriesView As DevExpress.XtraLayout.LayoutControlItem

        Private textEditTitleText As DevExpress.XtraEditors.TextEdit

        Private layoutControlItemTitleText As DevExpress.XtraLayout.LayoutControlItem

        Private checkEditWordWrap As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItemWordWrap As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditDock As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditAlignment As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupText As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupLayout As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemDock As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAlignment As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

Namespace DevExpress.XtraCharts.Demos

    Partial Class ScaleBreaksDemo

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
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Mercury", New Object() {(CObj((0.06R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Venus", New Object() {(CObj((0.82R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Earth", New Object() {(CObj((1R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Mars", New Object() {(CObj((0.11R)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Jupiter", New Object() {(CObj((318R)))})
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Saturn", New Object() {(CObj((95R)))})
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Uranus", New Object() {(CObj((14.6R)))})
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Neptune", New Object() {(CObj((17.2R)))})
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim barSlideAnimation1 As DevExpress.XtraCharts.BarSlideAnimation = New DevExpress.XtraCharts.BarSlideAnimation()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.simpleButtonRestoreColor = New DevExpress.XtraEditors.SimpleButton()
            Me.colorEditScaleBreakColor = New DevExpress.XtraEditors.ColorEdit()
            Me.spinEditSize = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditShowScaleBreaks = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditMaxCount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemMaxCount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemShowScaleBreaks = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupAppearance = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemRestoreColor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemColor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.colorEditScaleBreakColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowScaleBreaks.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMaxCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMaxCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemShowScaleBreaks), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupAppearance), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRestoreColor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemColor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(542, 0)
            Me.sidePanelOptions.Size = New System.Drawing.Size(242, 567)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(241, 567)
            Me.tabPaneOptions.Size = New System.Drawing.Size(241, 567)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 534)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.simpleButtonRestoreColor)
            Me.layoutControl.Controls.Add(Me.colorEditScaleBreakColor)
            Me.layoutControl.Controls.Add(Me.spinEditSize)
            Me.layoutControl.Controls.Add(Me.checkEditShowScaleBreaks)
            Me.layoutControl.Controls.Add(Me.spinEditMaxCount)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 534)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' simpleButtonRestoreColor
            ' 
            Me.simpleButtonRestoreColor.Location = New System.Drawing.Point(12, 180)
            Me.simpleButtonRestoreColor.Name = "simpleButtonRestoreColor"
            Me.simpleButtonRestoreColor.Size = New System.Drawing.Size(217, 22)
            Me.simpleButtonRestoreColor.StyleController = Me.layoutControl
            Me.simpleButtonRestoreColor.TabIndex = 9
            Me.simpleButtonRestoreColor.Text = "Restore Default Color"
            AddHandler Me.simpleButtonRestoreColor.Click, New System.EventHandler(AddressOf Me.simpleButtonRestoreColor_Click)
            ' 
            ' colorEditScaleBreakColor
            ' 
            Me.colorEditScaleBreakColor.EditValue = System.Drawing.Color.Empty
            Me.colorEditScaleBreakColor.Location = New System.Drawing.Point(83, 148)
            Me.colorEditScaleBreakColor.Name = "colorEditScaleBreakColor"
            Me.colorEditScaleBreakColor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.colorEditScaleBreakColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditScaleBreakColor.Size = New System.Drawing.Size(146, 20)
            Me.colorEditScaleBreakColor.StyleController = Me.layoutControl
            Me.colorEditScaleBreakColor.TabIndex = 8
            AddHandler Me.colorEditScaleBreakColor.EditValueChanged, New System.EventHandler(AddressOf Me.colorEditScaleBreakColor_EditValueChanged)
            ' 
            ' spinEditSize
            ' 
            Me.spinEditSize.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditSize.Location = New System.Drawing.Point(83, 124)
            Me.spinEditSize.Name = "spinEditSize"
            Me.spinEditSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEditSize.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditSize.Properties.IsFloatValue = False
            Me.spinEditSize.Properties.Mask.EditMask = "N00"
            Me.spinEditSize.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinEditSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.spinEditSize.Properties.ValidateOnEnterKey = True
            Me.spinEditSize.Size = New System.Drawing.Size(146, 20)
            Me.spinEditSize.StyleController = Me.layoutControl
            Me.spinEditSize.TabIndex = 7
            AddHandler Me.spinEditSize.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditSize_EditValueChanged)
            ' 
            ' checkEditShowScaleBreaks
            ' 
            Me.checkEditShowScaleBreaks.Location = New System.Drawing.Point(12, 34)
            Me.checkEditShowScaleBreaks.Name = "checkEditShowScaleBreaks"
            Me.checkEditShowScaleBreaks.Properties.Caption = "Enable Scale Breaks"
            Me.checkEditShowScaleBreaks.Size = New System.Drawing.Size(217, 20)
            Me.checkEditShowScaleBreaks.StyleController = Me.layoutControl
            Me.checkEditShowScaleBreaks.TabIndex = 4
            AddHandler Me.checkEditShowScaleBreaks.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditShowScaleBreaks_CheckedChanged)
            ' 
            ' spinEditMaxCount
            ' 
            Me.spinEditMaxCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMaxCount.Location = New System.Drawing.Point(83, 58)
            Me.spinEditMaxCount.Name = "spinEditMaxCount"
            Me.spinEditMaxCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMaxCount.Properties.IsFloatValue = False
            Me.spinEditMaxCount.Properties.Mask.EditMask = "N00"
            Me.spinEditMaxCount.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
            Me.spinEditMaxCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMaxCount.Size = New System.Drawing.Size(146, 20)
            Me.spinEditMaxCount.StyleController = Me.layoutControl
            Me.spinEditMaxCount.TabIndex = 5
            AddHandler Me.spinEditMaxCount.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditMaxCount_EditValueChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupGeneral, Me.emptySpaceItem, Me.layoutControlGroupAppearance})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 534)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemMaxCount, Me.layoutControlItemShowScaleBreaks})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemMaxCount
            ' 
            Me.layoutControlItemMaxCount.Control = Me.spinEditMaxCount
            Me.layoutControlItemMaxCount.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemMaxCount.Name = "layoutControlItemMaxCount"
            Me.layoutControlItemMaxCount.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMaxCount.Text = "Max Count: "
            Me.layoutControlItemMaxCount.TextSize = New System.Drawing.Size(59, 13)
            ' 
            ' layoutControlItemShowScaleBreaks
            ' 
            Me.layoutControlItemShowScaleBreaks.Control = Me.checkEditShowScaleBreaks
            Me.layoutControlItemShowScaleBreaks.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemShowScaleBreaks.Name = "layoutControlItemShowScaleBreaks"
            Me.layoutControlItemShowScaleBreaks.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemShowScaleBreaks.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 214)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 320)
            ' 
            ' layoutControlGroupAppearance
            ' 
            Me.layoutControlGroupAppearance.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupAppearance.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemRestoreColor, Me.layoutControlItemColor, Me.layoutControlItemSize})
            Me.layoutControlGroupAppearance.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlGroupAppearance.Name = "layoutControlGroupAppearance"
            Me.layoutControlGroupAppearance.Size = New System.Drawing.Size(241, 124)
            Me.layoutControlGroupAppearance.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupAppearance.Text = "Appearance"
            ' 
            ' layoutControlItemRestoreColor
            ' 
            Me.layoutControlItemRestoreColor.Control = Me.simpleButtonRestoreColor
            Me.layoutControlItemRestoreColor.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemRestoreColor.Name = "layoutControlItemRestoreColor"
            Me.layoutControlItemRestoreColor.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItemRestoreColor.Size = New System.Drawing.Size(221, 34)
            Me.layoutControlItemRestoreColor.TextVisible = False
            ' 
            ' layoutControlItemColor
            ' 
            Me.layoutControlItemColor.Control = Me.colorEditScaleBreakColor
            Me.layoutControlItemColor.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemColor.Name = "layoutControlItemColor"
            Me.layoutControlItemColor.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemColor.Text = "Color:"
            Me.layoutControlItemColor.TextSize = New System.Drawing.Size(59, 13)
            ' 
            ' layoutControlItemSize
            ' 
            Me.layoutControlItemSize.Control = Me.spinEditSize
            Me.layoutControlItemSize.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSize.Name = "layoutControlItemSize"
            Me.layoutControlItemSize.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemSize.Text = "Size:"
            Me.layoutControlItemSize.TextSize = New System.Drawing.Size(59, 13)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Title.Text = "Planets"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.AutoScaleBreaks.Enabled = True
            xyDiagram1.AxisY.AutoScaleBreaks.MaxCount = 4
            xyDiagram1.AxisY.Interlaced = True
            xyDiagram1.AxisY.ScaleBreakOptions.Style = DevExpress.XtraCharts.ScaleBreakStyle.Straight
            xyDiagram1.AxisY.Title.Text = "Multiple of Earth mass"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.LegendTextPattern = "{A}: {V}"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series1.SeriesID = 0
            barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            barSlideAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Inverted
            sideBySideBarSeriesView1.Animation = barSlideAnimation1
            sideBySideBarSeriesView1.ColorEach = True
            series1.View = sideBySideBarSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.Size = New System.Drawing.Size(542, 567)
            Me.chart.TabIndex = 3
            chartTitle1.Text = "Mass of Planets in the Solar System"
            chartTitle1.TitleID = 0
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' ScaleBreaksDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "ScaleBreaksDemo"
            Me.Size = New System.Drawing.Size(784, 567)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.colorEditScaleBreakColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowScaleBreaks.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMaxCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMaxCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemShowScaleBreaks), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupAppearance), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRestoreColor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemColor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private checkEditShowScaleBreaks As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItemShowScaleBreaks As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditMaxCount As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemMaxCount As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditSize As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemSize As DevExpress.XtraLayout.LayoutControlItem

        Private colorEditScaleBreakColor As DevExpress.XtraEditors.ColorEdit

        Private layoutControlItemColor As DevExpress.XtraLayout.LayoutControlItem

        Private simpleButtonRestoreColor As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroupAppearance As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemRestoreColor As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

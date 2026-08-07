Namespace DevExpress.XtraCharts.Demos

    Partial Class LargeDataSourceDemo

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
            Dim swiftPlotDiagram1 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
            Dim swiftPlotSeriesView1 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.btnAdd500K = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAdd1M = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAdd250K = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((swiftPlotDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((swiftPlotSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(4)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.GroupHeaderPattern = "Argument: {A}"
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            swiftPlotDiagram1.EnableAxisXScrolling = True
            swiftPlotDiagram1.EnableAxisXZooming = True
            swiftPlotDiagram1.EnableAxisYScrolling = True
            swiftPlotDiagram1.EnableAxisYZooming = True
            Me.chart.Diagram = swiftPlotDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesDataMember = "FakeMember"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.SeriesDataMember = "FakeMember"
            Me.chart.SeriesTemplate.View = swiftPlotSeriesView1
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 1
            chartTitle1.Text = "Large Data Source"
            chartTitle1.TitleID = 0
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle2.Text = "Total points count: 50000"
            chartTitle2.TitleID = 1
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.btnAdd500K)
            Me.layoutControl.Controls.Add(Me.btnAdd1M)
            Me.layoutControl.Controls.Add(Me.btnAdd250K)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' btnAdd500K
            ' 
            Me.btnAdd500K.Location = New System.Drawing.Point(10, 44)
            Me.btnAdd500K.Name = "btnAdd500K"
            Me.btnAdd500K.Size = New System.Drawing.Size(221, 22)
            Me.btnAdd500K.StyleController = Me.layoutControl
            Me.btnAdd500K.TabIndex = 4
            Me.btnAdd500K.Text = "Add 500K Points"
            AddHandler Me.btnAdd500K.Click, New System.EventHandler(AddressOf Me.btnAdd500K_Click)
            ' 
            ' btnAdd1M
            ' 
            Me.btnAdd1M.Location = New System.Drawing.Point(10, 76)
            Me.btnAdd1M.Name = "btnAdd1M"
            Me.btnAdd1M.Size = New System.Drawing.Size(221, 22)
            Me.btnAdd1M.StyleController = Me.layoutControl
            Me.btnAdd1M.TabIndex = 5
            Me.btnAdd1M.Text = "Add 1M Points"
            AddHandler Me.btnAdd1M.Click, New System.EventHandler(AddressOf Me.btnAdd1M_Click)
            ' 
            ' btnAdd250K
            ' 
            Me.btnAdd250K.Location = New System.Drawing.Point(10, 12)
            Me.btnAdd250K.Name = "btnAdd250K"
            Me.btnAdd250K.Size = New System.Drawing.Size(221, 22)
            Me.btnAdd250K.StyleController = Me.layoutControl
            Me.btnAdd250K.TabIndex = 8
            Me.btnAdd250K.Text = "Add 250K Points"
            AddHandler Me.btnAdd250K.Click, New System.EventHandler(AddressOf Me.btnAdd250K_Click)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem5, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.btnAdd500K
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10)
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 32)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.btnAdd1M
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 66)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(221, 22)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 88)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(221, 32)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.btnAdd250K
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 2, 10)
            Me.layoutControlItem5.Size = New System.Drawing.Size(221, 34)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 120)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(221, 398)
            ' 
            ' LargeDataSourceDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "LargeDataSourceDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((swiftPlotDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((swiftPlotSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private btnAdd500K As DevExpress.XtraEditors.SimpleButton

        Private btnAdd1M As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private btnAdd250K As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

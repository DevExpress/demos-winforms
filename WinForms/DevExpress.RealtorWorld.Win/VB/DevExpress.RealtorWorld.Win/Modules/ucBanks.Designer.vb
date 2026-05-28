Namespace DevExpress.RealtorWorld.Win

    Partial Class ucBanks

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
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.ccBank = New DevExpress.XtraCharts.ChartControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFRM30 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFRM15 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colARM1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType((Me.ccBank), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcMain), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ccBank
            ' 
            Me.ccBank.CacheToMemory = True
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Week
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Week
            xyDiagram1.AxisX.GridLines.MinorVisible = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            Me.ccBank.Diagram = xyDiagram1
            Me.ccBank.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.ccBank.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            Me.ccBank.Legend.Margins.Bottom = 10
            Me.ccBank.Legend.Margins.Left = 10
            Me.ccBank.Legend.Margins.Right = 10
            Me.ccBank.Legend.Margins.Top = 10
            Me.ccBank.Legend.Padding.Bottom = 10
            Me.ccBank.Legend.Padding.Left = 10
            Me.ccBank.Legend.Padding.Right = 10
            Me.ccBank.Legend.Padding.Top = 10
            Me.ccBank.Location = New System.Drawing.Point(2, 2)
            Me.ccBank.Name = "ccBank"
            Me.ccBank.Padding.Bottom = 20
            Me.ccBank.Padding.Left = 20
            Me.ccBank.Padding.Right = 20
            Me.ccBank.Padding.Top = 20
            Me.ccBank.PaletteName = "Flow"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series1.Name = "30 year FRM"
            series1.View = lineSeriesView1
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "15 year FRM"
            series2.View = lineSeriesView2
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series3.Name = "1 year ARM"
            series3.View = lineSeriesView3
            Me.ccBank.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3}
            Me.ccBank.Size = New System.Drawing.Size(806, 615)
            Me.ccBank.TabIndex = 0
            chartTitle1.Font = New System.Drawing.Font("Tahoma", 12F)
            chartTitle1.Text = "Mortgage Rate Data"
            Me.ccBank.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(817, 2)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(366, 615)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDate, Me.colFRM30, Me.colFRM15, Me.colARM1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            Me.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colDate
            ' 
            Me.colDate.FieldName = "Date"
            Me.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
            Me.colDate.Name = "colDate"
            Me.colDate.OptionsColumn.AllowEdit = False
            Me.colDate.OptionsColumn.AllowFocus = False
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 0
            Me.colDate.Width = 131
            ' 
            ' colFRM30
            ' 
            Me.colFRM30.Caption = "30 <size=-2>year FRM"
            Me.colFRM30.FieldName = "FRM30"
            Me.colFRM30.Name = "colFRM30"
            Me.colFRM30.OptionsColumn.AllowEdit = False
            Me.colFRM30.OptionsColumn.AllowFocus = False
            Me.colFRM30.OptionsFilter.AllowFilter = False
            Me.colFRM30.Visible = True
            Me.colFRM30.VisibleIndex = 1
            Me.colFRM30.Width = 89
            ' 
            ' colFRM15
            ' 
            Me.colFRM15.Caption = "15 <size=-2>year FRM"
            Me.colFRM15.FieldName = "FRM15"
            Me.colFRM15.Name = "colFRM15"
            Me.colFRM15.OptionsColumn.AllowEdit = False
            Me.colFRM15.OptionsColumn.AllowFocus = False
            Me.colFRM15.OptionsFilter.AllowFilter = False
            Me.colFRM15.Visible = True
            Me.colFRM15.VisibleIndex = 2
            Me.colFRM15.Width = 89
            ' 
            ' colARM1
            ' 
            Me.colARM1.Caption = "1 <size=-2>year ARM"
            Me.colARM1.FieldName = "ARM1"
            Me.colARM1.Name = "colARM1"
            Me.colARM1.OptionsColumn.AllowEdit = False
            Me.colARM1.OptionsColumn.AllowFocus = False
            Me.colARM1.OptionsFilter.AllowFilter = False
            Me.colARM1.Visible = True
            Me.colARM1.VisibleIndex = 3
            Me.colARM1.Width = 91
            ' 
            ' lcMain
            ' 
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Controls.Add(Me.gridControl1)
            Me.lcMain.Controls.Add(Me.ccBank)
            Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcMain.Location = New System.Drawing.Point(0, 0)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(735, 410, 450, 350)
            Me.lcMain.Root = Me.layoutControlGroup1
            Me.lcMain.Size = New System.Drawing.Size(1185, 619)
            Me.lcMain.TabIndex = 3
            Me.lcMain.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1185, 619)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ccBank
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(810, 619)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gridControl1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(815, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(370, 619)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(810, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 619)
            ' 
            ' ucBanks
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lcMain)
            Me.Name = "ucBanks"
            Me.Size = New System.Drawing.Size(1185, 619)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ccBank), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcMain), System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ccBank As DevExpress.XtraCharts.ChartControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colFRM30 As DevExpress.XtraGrid.Columns.GridColumn

        Private colFRM15 As DevExpress.XtraGrid.Columns.GridColumn

        Private colARM1 As DevExpress.XtraGrid.Columns.GridColumn

        Private lcMain As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace

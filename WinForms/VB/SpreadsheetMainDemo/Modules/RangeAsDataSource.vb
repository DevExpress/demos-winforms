Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Class RangeAsDataSourceModule
        Inherits SpreadSheetTutorialControlBase

        Private timer1 As Timer

        Private components As IContainer

        Private labelControl2 As LabelControl

        Private trbStdDev As ZoomTrackBarControl

        Private labelControl1 As LabelControl

        Private trbMean As ZoomTrackBarControl

        Private sidePanel2 As SidePanel

        Private spreadsheet As SpreadsheetControl

        Private chartControl1 As ChartControl

        Private mean As Double

        Private layoutControl1 As XtraLayout.LayoutControl

        Private Root As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private separatorControl1 As SeparatorControl

        Private standardDeviation As Double

        Public Sub New()
            InitializeComponent()
            spreadsheet.LoadDocument(DemoUtils.GetRelativePath("RangeAsDataSource_template.xlsx"))
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            spreadsheet.Focus()
            timer1.Enabled = True
        End Sub

        Protected Overrides Sub DoHide()
            timer1.Enabled = False
            MyBase.DoHide()
        End Sub

        Private Sub Spreadsheet_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            Dim workbook As IWorkbook = spreadsheet.Document
            Dim sheet As Worksheet = workbook.Worksheets(0)
            chartControl1.DataSource = sheet("B3:D103").GetDataSource()
            Dim series As Series = chartControl1.Series(0)
            series.ArgumentDataMember = "Column 0"
            series.ValueDataMembers.AddRange(New String() {"Column 1"})
            series = chartControl1.Series(1)
            series.ArgumentDataMember = "Column 0"
            series.ValueDataMembers.AddRange(New String() {"Column 2"})
            mean = trbMean.Value / 10.0
            standardDeviation = trbStdDev.Value / 100.0
        End Sub

        Private Sub RangeAsDataSourceModule_Resize(ByVal sender As Object, ByVal e As EventArgs)
            sidePanel2.Width = Width \ 2
        End Sub

        Private Sub Mean_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            mean = trbMean.Value / 10.0
        End Sub

        Private Sub StdDev_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            standardDeviation = trbStdDev.Value / 100.0
        End Sub

        Private Sub Spreadsheet_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
            If Equals(e.Cell.GetReferenceA1(), "F3") Then
                trbMean.Value = CInt(e.Cell.Value.NumericValue * 10)
            ElseIf Equals(e.Cell.GetReferenceA1(), "F6") Then
                trbStdDev.Value = CInt(e.Cell.Value.NumericValue * 100)
            End If
        End Sub

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheet.BeginUpdate()
            Try
                Dim sheet As Worksheet = spreadsheet.Document.Worksheets(0)
                If sheet("F3").Value.NumericValue <> mean Then sheet("F3").Value = mean
                If sheet("F6").Value.NumericValue <> standardDeviation Then sheet("F6").Value = standardDeviation
            Finally
                spreadsheet.EndUpdate()
            End Try
        End Sub

#Region "InitializeComponent"
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim columnDefinition25 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition26 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition27 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition28 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition29 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition30 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition5 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim xyDiagram5 As XYDiagram = New XYDiagram()
            Dim strip21 As Strip = New Strip()
            Dim strip22 As Strip = New Strip()
            Dim strip23 As Strip = New Strip()
            Dim strip24 As Strip = New Strip()
            Dim strip25 As Strip = New Strip()
            Dim xyDiagramPane5 As XYDiagramPane = New XYDiagramPane()
            Dim series9 As Series = New Series()
            Dim scatterLineSeriesView9 As ScatterLineSeriesView = New ScatterLineSeriesView()
            Dim series10 As Series = New Series()
            Dim scatterLineSeriesView10 As ScatterLineSeriesView = New ScatterLineSeriesView()
            Dim chartTitle9 As ChartTitle = New ChartTitle()
            Dim chartTitle10 As ChartTitle = New ChartTitle()
            timer1 = New Timer(components)
            labelControl2 = New LabelControl()
            layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            trbStdDev = New ZoomTrackBarControl()
            trbMean = New ZoomTrackBarControl()
            labelControl1 = New LabelControl()
            Root = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            sidePanel2 = New SidePanel()
            spreadsheet = New SpreadsheetControl()
            chartControl1 = New ChartControl()
            separatorControl1 = New SeparatorControl()
            CType(layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            layoutControl1.SuspendLayout()
            CType(trbStdDev, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(trbStdDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(trbMean, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(trbMean.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            sidePanel2.SuspendLayout()
            CType(chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(strip21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(strip22, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(strip23, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(strip24, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(strip25, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagramPane5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(scatterLineSeriesView9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(scatterLineSeriesView10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(separatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' timer1
            ' 
            AddHandler timer1.Tick, New EventHandler(AddressOf Timer_Tick)
            ' 
            ' labelControl2
            ' 
            labelControl2.Location = New System.Drawing.Point(301, 13)
            labelControl2.Name = "labelControl2"
            labelControl2.Size = New System.Drawing.Size(95, 13)
            labelControl2.StyleController = layoutControl1
            labelControl2.TabIndex = 6
            labelControl2.Text = "Standard deviation:"
            ' 
            ' layoutControl1
            ' 
            layoutControl1.AllowCustomization = False
            layoutControl1.AutoScroll = False
            layoutControl1.AutoSize = True
            layoutControl1.Controls.Add(trbStdDev)
            layoutControl1.Controls.Add(labelControl2)
            layoutControl1.Controls.Add(trbMean)
            layoutControl1.Controls.Add(labelControl1)
            layoutControl1.Dock = DockStyle.Top
            layoutControl1.Location = New System.Drawing.Point(0, 0)
            layoutControl1.Name = "layoutControl1"
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(693, 282, 650, 400)
            layoutControl1.Root = Root
            layoutControl1.Size = New System.Drawing.Size(1228, 39)
            layoutControl1.TabIndex = 8
            layoutControl1.Text = "layoutControl1"
            ' 
            ' trbStdDev
            ' 
            trbStdDev.EditValue = 55
            trbStdDev.Location = New System.Drawing.Point(400, 12)
            trbStdDev.Name = "trbStdDev"
            trbStdDev.Properties.Maximum = 100
            trbStdDev.Properties.Minimum = 10
            trbStdDev.Size = New System.Drawing.Size(171, 16)
            trbStdDev.StyleController = layoutControl1
            trbStdDev.TabIndex = 7
            trbStdDev.Value = 55
            AddHandler trbStdDev.EditValueChanged, New EventHandler(AddressOf StdDev_EditValueChanged)
            ' 
            ' trbMean
            ' 
            trbMean.Location = New System.Drawing.Point(46, 12)
            trbMean.Name = "trbMean"
            trbMean.Properties.Maximum = 50
            trbMean.Properties.Minimum = -50
            trbMean.Size = New System.Drawing.Size(171, 16)
            trbMean.StyleController = layoutControl1
            trbMean.TabIndex = 5
            trbMean.Value = 0
            AddHandler trbMean.EditValueChanged, New EventHandler(AddressOf Mean_EditValueChanged)
            ' 
            ' labelControl1
            ' 
            labelControl1.Location = New System.Drawing.Point(12, 13)
            labelControl1.Name = "labelControl1"
            labelControl1.Size = New System.Drawing.Size(30, 13)
            labelControl1.StyleController = layoutControl1
            labelControl1.TabIndex = 4
            labelControl1.Text = "Mean:"
            ' 
            ' Root
            ' 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Root.GroupBordersVisible = False
            Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4})
            Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Root.Name = "Root"
            columnDefinition25.SizeType = SizeType.AutoSize
            columnDefinition25.Width = 34R
            columnDefinition26.SizeType = SizeType.Absolute
            columnDefinition26.Width = 175R
            columnDefinition27.SizeType = SizeType.Absolute
            columnDefinition27.Width = 80R
            columnDefinition28.SizeType = SizeType.AutoSize
            columnDefinition28.Width = 99R
            columnDefinition29.SizeType = SizeType.Absolute
            columnDefinition29.Width = 175R
            columnDefinition30.SizeType = SizeType.AutoSize
            columnDefinition30.Width = 645R
            Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition25, columnDefinition26, columnDefinition27, columnDefinition28, columnDefinition29, columnDefinition30})
            rowDefinition5.Height = 19R
            rowDefinition5.SizeType = SizeType.AutoSize
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition5})
            Root.Size = New System.Drawing.Size(1228, 39)
            Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            layoutControlItem1.Control = labelControl1
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Size = New System.Drawing.Size(34, 19)
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            layoutControlItem2.Control = trbMean
            layoutControlItem2.Location = New System.Drawing.Point(34, 0)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1
            layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            layoutControlItem2.Size = New System.Drawing.Size(175, 19)
            layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            layoutControlItem3.Control = labelControl2
            layoutControlItem3.Location = New System.Drawing.Point(289, 0)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 3
            layoutControlItem3.Size = New System.Drawing.Size(99, 19)
            layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            layoutControlItem4.Control = trbStdDev
            layoutControlItem4.Location = New System.Drawing.Point(388, 0)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 4
            layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            layoutControlItem4.Size = New System.Drawing.Size(175, 19)
            layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem4.TextVisible = False
            ' 
            ' sidePanel2
            ' 
            sidePanel2.Controls.Add(spreadsheet)
            sidePanel2.Dock = DockStyle.Left
            sidePanel2.Location = New System.Drawing.Point(0, 40)
            sidePanel2.Name = "sidePanel2"
            sidePanel2.Size = New System.Drawing.Size(614, 654)
            sidePanel2.TabIndex = 3
            sidePanel2.Text = "sidePanel1"
            ' 
            ' spreadsheet
            ' 
            spreadsheet.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            spreadsheet.Dock = DockStyle.Fill
            spreadsheet.Location = New System.Drawing.Point(0, 0)
            spreadsheet.Name = "spreadsheet"
            spreadsheet.Options.Behavior.Column.Delete = DocumentCapability.Disabled
            spreadsheet.Options.Behavior.Column.Insert = DocumentCapability.Disabled
            spreadsheet.Options.Behavior.Row.Delete = DocumentCapability.Disabled
            spreadsheet.Options.Behavior.Row.Insert = DocumentCapability.Disabled
            spreadsheet.Options.Behavior.UseSkinColors = False
            spreadsheet.Options.Export.Csv.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.Export.Txt.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.Import.Csv.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.Import.Txt.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.View.Charts.Antialiasing = DocumentCapability.Enabled
            spreadsheet.Options.View.ShowPrintArea = False
            spreadsheet.Size = New System.Drawing.Size(613, 654)
            spreadsheet.TabIndex = 8
            AddHandler spreadsheet.DocumentLoaded, New EventHandler(AddressOf Spreadsheet_DocumentLoaded)
            AddHandler spreadsheet.CellValueChanged, New CellValueChangedEventHandler(AddressOf Spreadsheet_CellValueChanged)
            ' 
            ' chartControl1
            ' 
            chartControl1.AppearanceNameSerializable = "Light"
            chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
            xyDiagram5.AxisX.GridLines.Visible = True
            strip21.Color = System.Drawing.Color.FromArgb(242, 242, 242)
            strip21.MaxLimit.AxisValueSerializable = "1"
            strip21.MinLimit.AxisValueSerializable = "-1"
            strip21.Name = "Strip 1"
            strip21.ShowInLegend = False
            strip22.Color = System.Drawing.Color.FromArgb(242, 242, 242)
            strip22.MaxLimit.AxisValueSerializable = "-2"
            strip22.MinLimit.AxisValueSerializable = "-3"
            strip22.Name = "Strip 2"
            strip22.ShowInLegend = False
            strip23.Color = System.Drawing.Color.FromArgb(242, 242, 242)
            strip23.MaxLimit.AxisValueSerializable = "-4"
            strip23.MinLimit.AxisValueSerializable = "-5"
            strip23.Name = "Strip 3"
            strip23.ShowInLegend = False
            strip24.Color = System.Drawing.Color.FromArgb(242, 242, 242)
            strip24.MaxLimit.AxisValueSerializable = "3"
            strip24.MinLimit.AxisValueSerializable = "2"
            strip24.Name = "Strip 4"
            strip24.ShowInLegend = False
            strip25.Color = System.Drawing.Color.FromArgb(242, 242, 242)
            strip25.MaxLimit.AxisValueSerializable = "5"
            strip25.MinLimit.AxisValueSerializable = "4"
            strip25.Name = "Strip 5"
            strip25.ShowInLegend = False
            xyDiagram5.AxisX.Strips.AddRange(New Strip() {strip21, strip22, strip23, strip24, strip25})
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1;0"
            xyDiagram5.AxisX.VisualRange.Auto = False
            xyDiagram5.AxisX.VisualRange.MaxValueSerializable = "5"
            xyDiagram5.AxisX.VisualRange.MinValueSerializable = "-5"
            xyDiagram5.AxisX.WholeRange.Auto = False
            xyDiagram5.AxisX.WholeRange.MaxValueSerializable = "5"
            xyDiagram5.AxisX.WholeRange.MinValueSerializable = "-5"
            xyDiagram5.AxisY.Alignment = AxisAlignment.Zero
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1;0"
            xyDiagramPane5.Name = "Pane 1"
            xyDiagramPane5.PaneID = 0
            xyDiagram5.Panes.AddRange(New XYDiagramPane() {xyDiagramPane5})
            chartControl1.Diagram = xyDiagram5
            chartControl1.Dock = DockStyle.Fill
            chartControl1.Legend.Name = "Default Legend"
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            chartControl1.Location = New System.Drawing.Point(614, 40)
            chartControl1.Name = "chartControl1"
            series9.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}"
            series9.Name = "PDF"
            series9.View = scatterLineSeriesView9
            series10.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}"
            series10.Name = "CDF"
            scatterLineSeriesView10.PaneName = "Pane 1"
            series10.View = scatterLineSeriesView10
            chartControl1.SeriesSerializable = New Series() {series9, series10}
            chartControl1.Size = New System.Drawing.Size(614, 654)
            chartControl1.TabIndex = 4
            chartTitle9.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
            chartTitle9.Font = New System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204)
            chartTitle9.Text = "PROBABILITY DENSITY FUNCTION"
            chartTitle9.TextColor = System.Drawing.Color.DimGray
            chartTitle10.Dock = ChartTitleDockStyle.Bottom
            chartTitle10.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
            chartTitle10.Font = New System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204)
            chartTitle10.Text = "CUMULATIVE DISTRIBUTION FUNCTION"
            chartTitle10.TextColor = System.Drawing.Color.DimGray
            chartControl1.Titles.AddRange(New ChartTitle() {chartTitle9, chartTitle10})
            ' 
            ' separatorControl1
            ' 
            separatorControl1.AutoSizeMode = True
            separatorControl1.Dock = DockStyle.Top
            separatorControl1.Location = New System.Drawing.Point(0, 39)
            separatorControl1.Margin = New Padding(0)
            separatorControl1.Name = "separatorControl1"
            separatorControl1.Padding = New Padding(0, 0, 0, 0)
            separatorControl1.Size = New System.Drawing.Size(1228, 1)
            separatorControl1.TabIndex = 13
            ' 
            ' RangeAsDataSourceModule
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            Controls.Add(chartControl1)
            Controls.Add(sidePanel2)
            Controls.Add(separatorControl1)
            Controls.Add(layoutControl1)
            Name = "RangeAsDataSourceModule"
            Size = New System.Drawing.Size(1228, 694)
            AddHandler Resize, New EventHandler(AddressOf RangeAsDataSourceModule_Resize)
            CType(layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            layoutControl1.ResumeLayout(False)
            CType(trbStdDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(trbStdDev, System.ComponentModel.ISupportInitialize).EndInit()
            CType(trbMean.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(trbMean, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            sidePanel2.ResumeLayout(False)
            CType(strip21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(strip22, System.ComponentModel.ISupportInitialize).EndInit()
            CType(strip23, System.ComponentModel.ISupportInitialize).EndInit()
            CType(strip24, System.ComponentModel.ISupportInitialize).EndInit()
            CType(strip25, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xyDiagramPane5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xyDiagram5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(scatterLineSeriesView9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(scatterLineSeriesView10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(separatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
#Region "Dispose"
        Private isModuleDisposed As Boolean = False

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Not isModuleDisposed Then
                timer1.Enabled = False
                isModuleDisposed = True
            End If

            MyBase.Dispose(disposing)
        End Sub
#End Region
    End Class
End Namespace

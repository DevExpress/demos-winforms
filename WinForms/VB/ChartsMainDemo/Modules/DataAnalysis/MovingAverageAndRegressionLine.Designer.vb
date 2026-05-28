Namespace DevExpress.XtraCharts.Demos

    Partial Class MovingAverageAndRegressionLineDemo

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
            Dim pointSeriesView1 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim exponentialMovingAverage1 As DevExpress.XtraCharts.ExponentialMovingAverage = New DevExpress.XtraCharts.ExponentialMovingAverage()
            Dim simpleMovingAverage1 As DevExpress.XtraCharts.SimpleMovingAverage = New DevExpress.XtraCharts.SimpleMovingAverage()
            Dim triangularMovingAverage1 As DevExpress.XtraCharts.TriangularMovingAverage = New DevExpress.XtraCharts.TriangularMovingAverage()
            Dim tripleExponentialMovingAverageTema1 As DevExpress.XtraCharts.TripleExponentialMovingAverageTema = New DevExpress.XtraCharts.TripleExponentialMovingAverageTema()
            Dim weightedMovingAverage1 As DevExpress.XtraCharts.WeightedMovingAverage = New DevExpress.XtraCharts.WeightedMovingAverage()
            Dim regressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
            Dim xyMarkerWidenAnimation1 As DevExpress.XtraCharts.XYMarkerWidenAnimation = New DevExpress.XtraCharts.XYMarkerWidenAnimation()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupMovingAverage = New DevExpress.XtraEditors.RadioGroup()
            Me.comboBoxEditMovingAverageKind = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditPointsCount = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditEnvelopePercent = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditRegressionLineVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupMovingAverage = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemMovingAverageKind = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemEnvelopePercent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMovingAverage = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPointsCount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupRegressionLine = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemShowRegressionLine = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((exponentialMovingAverage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((simpleMovingAverage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((triangularMovingAverage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((tripleExponentialMovingAverageTema1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((weightedMovingAverage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((regressionLine1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.radioGroupMovingAverage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditMovingAverageKind.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditPointsCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditEnvelopePercent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditRegressionLineVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupMovingAverage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMovingAverageKind), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemEnvelopePercent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMovingAverage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPointsCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRegressionLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemShowRegressionLine), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(528, 0)
            Me.sidePanelOptions.Size = New System.Drawing.Size(260, 571)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(259, 571)
            Me.tabPaneOptions.Size = New System.Drawing.Size(259, 571)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(259, 544)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:n1}"
            Me.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            Me.chart.CrosshairOptions.ShowValueLine = True
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
            xyDiagram1.AxisX.GridLines.MinorVisible = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.EnableAxisYScrolling = True
            xyDiagram1.EnableAxisYZooming = True
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.CrosshairLabelPattern = "{A:F0}: {V}"
            series1.Name = "Measurements Data"
            exponentialMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
            exponentialMovingAverage1.EnvelopePercent = 35R
            exponentialMovingAverage1.LineStyle.Thickness = 2
            exponentialMovingAverage1.Name = "Exponential Moving Average"
            exponentialMovingAverage1.PointsCount = 50
            exponentialMovingAverage1.ShowInLegend = True
            exponentialMovingAverage1.Visible = False
            simpleMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
            simpleMovingAverage1.EnvelopePercent = 35R
            simpleMovingAverage1.LineStyle.Thickness = 2
            simpleMovingAverage1.Name = "Simple Moving Average"
            simpleMovingAverage1.PointsCount = 50
            simpleMovingAverage1.ShowInLegend = True
            simpleMovingAverage1.Visible = False
            triangularMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
            triangularMovingAverage1.EnvelopePercent = 35R
            triangularMovingAverage1.LineStyle.Thickness = 2
            triangularMovingAverage1.Name = "Triangular Moving Average"
            triangularMovingAverage1.PointsCount = 50
            triangularMovingAverage1.ShowInLegend = True
            triangularMovingAverage1.Visible = False
            tripleExponentialMovingAverageTema1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
            tripleExponentialMovingAverageTema1.EnvelopePercent = 35R
            tripleExponentialMovingAverageTema1.LineStyle.Thickness = 2
            tripleExponentialMovingAverageTema1.Name = "Triple Exponential Moving Average (TEMA)"
            tripleExponentialMovingAverageTema1.PointsCount = 50
            tripleExponentialMovingAverageTema1.ShowInLegend = True
            tripleExponentialMovingAverageTema1.Visible = False
            weightedMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
            weightedMovingAverage1.EnvelopePercent = 35R
            weightedMovingAverage1.LineStyle.Thickness = 2
            weightedMovingAverage1.Name = "Weighted Moving Average"
            weightedMovingAverage1.PointsCount = 50
            weightedMovingAverage1.ShowInLegend = True
            weightedMovingAverage1.Visible = False
            regressionLine1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
            regressionLine1.Color = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((143)))))), (CInt(((CByte((33)))))))
            regressionLine1.LineStyle.Thickness = 2
            regressionLine1.Name = "Regression Line"
            regressionLine1.ShowInLegend = True
            regressionLine1.Visible = False
            pointSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {exponentialMovingAverage1, simpleMovingAverage1, triangularMovingAverage1, tripleExponentialMovingAverageTema1, weightedMovingAverage1, regressionLine1})
            pointSeriesView1.PointMarkerOptions.Size = 2
            xyMarkerWidenAnimation1.Enabled = False
            pointSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1
            series1.View = pointSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.Size = New System.Drawing.Size(528, 571)
            Me.chart.TabIndex = 1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.radioGroupMovingAverage)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditMovingAverageKind)
            Me.layoutControl1.Controls.Add(Me.spinEditPointsCount)
            Me.layoutControl1.Controls.Add(Me.spinEditEnvelopePercent)
            Me.layoutControl1.Controls.Add(Me.checkEditRegressionLineVisible)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(428, 287, 650, 400)
            Me.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
            Me.layoutControl1.Root = Me.layoutControlGroupRoot
            Me.layoutControl1.Size = New System.Drawing.Size(259, 544)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' radioGroupMovingAverage
            ' 
            Me.radioGroupMovingAverage.AutoSizeInLayoutControl = True
            Me.radioGroupMovingAverage.Location = New System.Drawing.Point(12, 31)
            Me.radioGroupMovingAverage.Name = "radioGroupMovingAverage"
            Me.radioGroupMovingAverage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupMovingAverage.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupMovingAverage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupMovingAverage.Properties.Columns = 1
            Me.radioGroupMovingAverage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Simple Moving Average", "Simple Moving Average"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Exponential Moving Average", "Exponential Moving Average"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Weighted Moving Average", "Weighted Moving Average"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Triangular Moving Average", "Triangular Moving Average"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Triple Exponential Moving Average (TEMA)", "Triple Exponential Moving Average (TEMA)")})
            Me.radioGroupMovingAverage.Size = New System.Drawing.Size(235, 83)
            Me.radioGroupMovingAverage.StyleController = Me.layoutControl1
            Me.radioGroupMovingAverage.TabIndex = 4
            AddHandler Me.radioGroupMovingAverage.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupMovingAverage_SelectedIndexChanged)
            ' 
            ' comboBoxEditMovingAverageKind
            ' 
            Me.comboBoxEditMovingAverageKind.Location = New System.Drawing.Point(103, 142)
            Me.comboBoxEditMovingAverageKind.Name = "comboBoxEditMovingAverageKind"
            Me.comboBoxEditMovingAverageKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditMovingAverageKind.Properties.Items.AddRange(New Object() {"MovingAverage", "Envelope", "Moving Average and Envelope"})
            Me.comboBoxEditMovingAverageKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditMovingAverageKind.Size = New System.Drawing.Size(144, 20)
            Me.comboBoxEditMovingAverageKind.StyleController = Me.layoutControl1
            Me.comboBoxEditMovingAverageKind.TabIndex = 5
            AddHandler Me.comboBoxEditMovingAverageKind.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditMovingAverageKind_SelectedIndexChanged)
            ' 
            ' spinEditPointsCount
            ' 
            Me.spinEditPointsCount.EditValue = New Decimal(New Integer() {3, 0, 0, 0})
            Me.spinEditPointsCount.Location = New System.Drawing.Point(103, 118)
            Me.spinEditPointsCount.Name = "spinEditPointsCount"
            Me.spinEditPointsCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditPointsCount.Properties.IsFloatValue = False
            Me.spinEditPointsCount.Properties.Mask.EditMask = "N00"
            Me.spinEditPointsCount.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinEditPointsCount.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
            AddHandler Me.spinEditPointsCount.Properties.ValueChanged, New System.EventHandler(AddressOf Me.spinEditPointsCount_Properties_ValueChanged)
            Me.spinEditPointsCount.Size = New System.Drawing.Size(144, 20)
            Me.spinEditPointsCount.StyleController = Me.layoutControl1
            Me.spinEditPointsCount.TabIndex = 6
            ' 
            ' spinEditEnvelopePercent
            ' 
            Me.spinEditEnvelopePercent.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditEnvelopePercent.Location = New System.Drawing.Point(103, 166)
            Me.spinEditEnvelopePercent.Name = "spinEditEnvelopePercent"
            Me.spinEditEnvelopePercent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditEnvelopePercent.Properties.DisplayFormat.FormatString = "0\%"
            Me.spinEditEnvelopePercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditEnvelopePercent.Properties.IsFloatValue = False
            Me.spinEditEnvelopePercent.Properties.Mask.EditMask = "N00"
            Me.spinEditEnvelopePercent.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinEditEnvelopePercent.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.spinEditEnvelopePercent.Properties.ValueChanged, New System.EventHandler(AddressOf Me.spinEditEnvelopePercent_Properties_ValueChanged)
            Me.spinEditEnvelopePercent.Size = New System.Drawing.Size(144, 20)
            Me.spinEditEnvelopePercent.StyleController = Me.layoutControl1
            Me.spinEditEnvelopePercent.TabIndex = 7
            ' 
            ' checkEditRegressionLineVisible
            ' 
            Me.checkEditRegressionLineVisible.Location = New System.Drawing.Point(12, 229)
            Me.checkEditRegressionLineVisible.Name = "checkEditShowRegressionLine"
            Me.checkEditRegressionLineVisible.Properties.Caption = "Show"
            Me.checkEditRegressionLineVisible.Size = New System.Drawing.Size(235, 19)
            Me.checkEditRegressionLineVisible.StyleController = Me.layoutControl1
            Me.checkEditRegressionLineVisible.TabIndex = 8
            AddHandler Me.checkEditRegressionLineVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditRegressionLineVisible_CheckedChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroupMovingAverage, Me.layoutControlGroupRegressionLine})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(259, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 260)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(259, 284)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupMovingAverage
            ' 
            Me.layoutControlGroupMovingAverage.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupMovingAverage.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemMovingAverageKind, Me.layoutControlItemEnvelopePercent, Me.layoutControlItemMovingAverage, Me.layoutControlItemPointsCount})
            Me.layoutControlGroupMovingAverage.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupMovingAverage.Name = "layoutControlGroupMovingAverage"
            Me.layoutControlGroupMovingAverage.Size = New System.Drawing.Size(259, 198)
            Me.layoutControlGroupMovingAverage.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupMovingAverage.Text = "Moving Average"
            ' 
            ' layoutControlItemMovingAverageKind
            ' 
            Me.layoutControlItemMovingAverageKind.Control = Me.comboBoxEditMovingAverageKind
            Me.layoutControlItemMovingAverageKind.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlItemMovingAverageKind.Name = "layoutControlItemMovingAverageKind"
            Me.layoutControlItemMovingAverageKind.Size = New System.Drawing.Size(239, 24)
            Me.layoutControlItemMovingAverageKind.Text = "Kind:"
            Me.layoutControlItemMovingAverageKind.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlItemEnvelopePercent
            ' 
            Me.layoutControlItemEnvelopePercent.Control = Me.spinEditEnvelopePercent
            Me.layoutControlItemEnvelopePercent.Location = New System.Drawing.Point(0, 135)
            Me.layoutControlItemEnvelopePercent.Name = "layoutControlItemEnvelopePercent"
            Me.layoutControlItemEnvelopePercent.Size = New System.Drawing.Size(239, 24)
            Me.layoutControlItemEnvelopePercent.Text = "Envelope Percent:"
            Me.layoutControlItemEnvelopePercent.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlItemMovingAverage
            ' 
            Me.layoutControlItemMovingAverage.Control = Me.radioGroupMovingAverage
            Me.layoutControlItemMovingAverage.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemMovingAverage.Name = "layoutControlItemMovingAverage"
            Me.layoutControlItemMovingAverage.Size = New System.Drawing.Size(239, 87)
            Me.layoutControlItemMovingAverage.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemMovingAverage.TextVisible = False
            ' 
            ' layoutControlItemPointsCount
            ' 
            Me.layoutControlItemPointsCount.Control = Me.spinEditPointsCount
            Me.layoutControlItemPointsCount.Location = New System.Drawing.Point(0, 87)
            Me.layoutControlItemPointsCount.Name = "layoutControlItemPointsCount"
            Me.layoutControlItemPointsCount.Size = New System.Drawing.Size(239, 24)
            Me.layoutControlItemPointsCount.Text = "Point Count:"
            Me.layoutControlItemPointsCount.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlGroupRegressionLine
            ' 
            Me.layoutControlGroupRegressionLine.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupRegressionLine.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemShowRegressionLine})
            Me.layoutControlGroupRegressionLine.Location = New System.Drawing.Point(0, 198)
            Me.layoutControlGroupRegressionLine.Name = "layoutControlGroupRegressionLine"
            Me.layoutControlGroupRegressionLine.Size = New System.Drawing.Size(259, 62)
            Me.layoutControlGroupRegressionLine.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRegressionLine.Text = "Regression Line"
            ' 
            ' layoutControlItemShowRegressionLine
            ' 
            Me.layoutControlItemShowRegressionLine.Control = Me.checkEditRegressionLineVisible
            Me.layoutControlItemShowRegressionLine.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemShowRegressionLine.Name = "layoutControlItemShowRegressionLine"
            Me.layoutControlItemShowRegressionLine.Size = New System.Drawing.Size(239, 23)
            Me.layoutControlItemShowRegressionLine.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemShowRegressionLine.TextVisible = False
            ' 
            ' MovingAverageAndRegressionLineDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "MovingAverageAndRegressionLineDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((exponentialMovingAverage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((simpleMovingAverage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((triangularMovingAverage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((tripleExponentialMovingAverageTema1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((weightedMovingAverage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((regressionLine1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.radioGroupMovingAverage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditMovingAverageKind.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditPointsCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditEnvelopePercent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditRegressionLineVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupMovingAverage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMovingAverageKind), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemEnvelopePercent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMovingAverage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPointsCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRegressionLine), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemShowRegressionLine), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private radioGroupMovingAverage As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemMovingAverage As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditMovingAverageKind As DevExpress.XtraEditors.ComboBoxEdit

        Private spinEditPointsCount As DevExpress.XtraEditors.SpinEdit

        Private spinEditEnvelopePercent As DevExpress.XtraEditors.SpinEdit

        Private checkEditRegressionLineVisible As DevExpress.XtraEditors.CheckEdit

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupMovingAverage As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemMovingAverageKind As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemEnvelopePercent As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemPointsCount As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupRegressionLine As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemShowRegressionLine As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

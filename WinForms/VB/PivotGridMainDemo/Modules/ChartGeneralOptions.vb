Imports System
Imports DevExpress.XtraCharts

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class ChartGeneralOptions
        Inherits TutorialControl

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked
            pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked
            chartControl.CrosshairOptions.ShowArgumentLine = False
            Dim viewTypes As ViewType() = New ViewType() {ViewType.Bar, ViewType.StackedBar, ViewType.Waterfall, ViewType.FullStackedBar, ViewType.Point, ViewType.Line, ViewType.StepLine, ViewType.Area, ViewType.Pie, ViewType.Doughnut, ViewType.Funnel, ViewType.RadarPoint, ViewType.RadarLine}
            comboChartType.Properties.Items.AddRange(viewTypes)
            comboChartType.SelectedItem = ViewType.Bar
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            pivotGridControl.DataSource = GetNWindData("SalesPerson")
            SetFilter()
            SetSelection()
            chartControl.DataSource = pivotGridControl
        End Sub

        Private Sub SetFilter()
            fieldProductName.FilterValues.SetValues(New Object() {"Chai", "Chang", "Chocolade", "Filo Mix", "Geitost", "Ikura", "Konbu", "Maxilaku", "Pavlova", "Spegesild", "Tourtiere"}, PivotFilterType.Included, False)
            fieldOrderYear.FilterValues.SetValues(New Object() {2015}, PivotFilterType.Included, False)
        End Sub

        Private Sub SetSelection()
            pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() {"Chocolade"})
            pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() {"Chai"})
        End Sub

        '<comboChartType>
        Private Sub comboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim viewType As ViewType = CType(comboChartType.SelectedItem, ViewType)
            chartControl.SeriesTemplate.ChangeView(viewType)
            If chartControl.SeriesTemplate.Label IsNot Nothing Then
                chartControl.SeriesTemplate.LabelsVisibility = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
                chartControl.CrosshairEnabled = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
                checkShowPointLabels.Enabled = True
            Else
                checkShowPointLabels.Enabled = False
            End If

            Dim view As SeriesViewBase = chartControl.SeriesTemplate.View
            If TryCast(view, SimpleDiagramSeriesViewBase) Is Nothing Then chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            If TryCast(view, FunnelSeriesView) IsNot Nothing Then
                CType(view, FunnelSeriesView).ColorEach = True
            ElseIf TryCast(view, SeriesViewColorEachSupportBase) IsNot Nothing Then
                CType(view, SeriesViewColorEachSupportBase).ColorEach = False
            ElseIf TryCast(view, RadarSeriesViewBase) IsNot Nothing Then
                CType(view, RadarSeriesViewBase).ColorEach = False
            ElseIf TryCast(view, SeriesView3DColorEachSupportBase) IsNot Nothing Then
                CType(view, SeriesView3DColorEachSupportBase).ColorEach = False
            End If

            If TypeOf chartControl.Diagram Is Diagram3D Then
                Dim diagram As Diagram3D = CType(chartControl.Diagram, Diagram3D)
                diagram.RuntimeRotation = True
                diagram.RuntimeZooming = True
                diagram.RuntimeScrolling = True
            End If

            For Each series As Series In chartControl.Series
                UpdateSeriesTransparency(series.View)
            Next

            UpdateSeriesTransparency(view)
            UpdateAxisYLabels(viewType)
        End Sub

        Private Sub UpdateAxisYLabels(ByVal viewType As ViewType)
            Dim textPattern As String = If(viewType = ViewType.FullStackedBar, "{VP:P0}", "{V:C2}")
            Dim xyDiagram As XYDiagram = TryCast(chartControl.Diagram, XYDiagram)
            If TypeOf chartControl.Diagram Is XYDiagram Then
                TryCast(chartControl.Diagram, XYDiagram).AxisY.Label.TextPattern = textPattern
            ElseIf TypeOf chartControl.Diagram Is XYDiagram3D Then
                TryCast(chartControl.Diagram, XYDiagram3D).AxisY.Label.TextPattern = textPattern
            End If
        End Sub

        Private Sub UpdateSeriesTransparency(ByVal seriesView As SeriesViewBase)
            Dim supportTransparency As ISupportTransparency = TryCast(seriesView, ISupportTransparency)
            If supportTransparency IsNot Nothing Then
                If(TypeOf seriesView Is AreaSeriesView) OrElse (TypeOf seriesView Is Area3DSeriesView) OrElse (TypeOf seriesView Is RadarAreaSeriesView) OrElse (TypeOf seriesView Is Bar3DSeriesView) Then
                    supportTransparency.Transparency = 135
                Else
                    supportTransparency.Transparency = 0
                End If
            End If
        End Sub

        '</comboChartType>
        '<checkShowPointLabels>
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            chartControl.SeriesTemplate.LabelsVisibility = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
            chartControl.CrosshairEnabled = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        End Sub

        '</checkShowPointLabels>
        '<ceChartDataVertical>
        Private Sub ceChartDataVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked
        End Sub

        '</ceChartDataVertical>
        '<ceSelectionOnly>
        Private Sub ceSelectionOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked
            seUpdateDelay.Enabled = ceSelectionOnly.Checked
        End Sub

        '</ceSelectionOnly>
        '<ceShowColumnGrandTotals>
        Private Sub ceShowColumnGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked
        End Sub

        '</ceShowColumnGrandTotals>
        '<ceShowRowGrandTotals>
        Private Sub ceShowRowGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked
        End Sub

        '</ceShowRowGrandTotals>
        '<seUpdateDelay>
        Private Sub seUpdateDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.UpdateDelay = CInt(seUpdateDelay.Value)
        End Sub
    '</seUpdateDelay>
    End Class
End Namespace

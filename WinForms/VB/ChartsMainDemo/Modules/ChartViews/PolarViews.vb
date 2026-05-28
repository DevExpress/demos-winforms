Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class PolarViewsDemo
        Inherits ChartDemoModuleMarkerViews

        Private ReadOnly polarDiagramFunctions As String() = New String() {"Circles", "Cardioid", "Lemniscate"}

        Private ReadOnly scatterLineFunctions As String() = New String() {"Archimedean Spiral", "Cardioid", "Cartesian Folium"}

        Private ReadOnly Property IsScatterLineSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is ScatterPolarLineSeriesView
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsLayoutControl As LayoutControl
            Get
                Return layoutControl
            End Get
        End Property

        Protected Overrides ReadOnly Property LabelVisibleCheckEdit As CheckEdit
            Get
                Return checkEditLabelVisible
            End Get
        End Property

        Protected Overrides ReadOnly Property MarkerKindComboBox As ComboBoxEdit
            Get
                Return comboBoxEditMarkerKind
            End Get
        End Property

        Protected Overrides ReadOnly Property MarkerSizeSpinEdit As SpinEdit
            Get
                Return spinEditMarkerSize
            End Get
        End Property

        Protected Overrides ReadOnly Property MarkerVisibleCheckEdit As CheckEdit
            Get
                Return checkEditMarkerVisible
            End Get
        End Property

        Protected Overrides ReadOnly Property TabbedView As TabbedView
            Get
                Return currentTabbedView
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartPoint, chartLine, chartArea, chartScatterLine, chartRangeArea}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
            comboBoxEditFunction.Properties.Items.Clear()
            comboBoxEditFunction.Properties.Items.AddRange(If(IsScatterLineSeriesActive, scatterLineFunctions, polarDiagramFunctions))
            comboBoxEditFunction.SelectedIndex = If(IsScatterLineSeriesActive, 0, 2)
            UpdatePoints()
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility()
        End Sub

        Private Sub checkEditMarkerVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetMarkerVisibility(layoutControlItemKind, layoutControlItemSize)
        End Sub

        Private Sub comboBoxEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As PolarDiagram = TryCast(ChartControl.Diagram, PolarDiagram)
            If diagram IsNot Nothing Then diagram.DrawingStyle = CType(comboBoxStyle.SelectedIndex, RadarDiagramDrawingStyle)
        End Sub

        Private Sub comboBoxEditFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChartControl.Series.Count > 0 AndAlso TypeOf ChartControl.Diagram Is PolarDiagram Then UpdatePoints()
        End Sub

        Private Sub comboBoxEditRotationDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As PolarDiagram = TryCast(ChartControl.Diagram, PolarDiagram)
            If diagram IsNot Nothing Then diagram.RotationDirection = CType(comboBoxEditRotationDirection.SelectedIndex, RadarDiagramRotationDirection)
        End Sub

        Private Sub spinEditStartAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As PolarDiagram = TryCast(ChartControl.Diagram, PolarDiagram)
            If diagram IsNot Nothing Then diagram.StartAngleInDegrees = CInt(spinEditStartAngle.Value)
        End Sub

        Private Sub spinEditAxisLabelAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As PolarDiagram = TryCast(ChartControl.Diagram, PolarDiagram)
            If diagram IsNot Nothing Then diagram.AxisY.Label.Angle = CInt(spinEditAxisLabelAngle.Value)
        End Sub

        Private Sub UpdatePoints()
            Dim points As SeriesPoint() = Nothing
            If IsScatterLineSeriesActive Then
                Dim functionCalculator As DegreeScatterFunctionCalculator = New DegreeScatterFunctionCalculator()
                points = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunction.SelectedIndex)
            Else
                Dim pointCount As Integer = If(TypeOf ActiveSeries.View Is PolarRangeAreaSeriesView, 2, 1)
                points = GenerateFunctionPoints(comboBoxEditFunction.SelectedIndex, pointCount)
            End If

            ChartControl.Series(0).Points.Clear()
            ChartControl.Series(0).Points.AddRange(points)
            ChartControl.Series(0).Name = comboBoxEditFunction.Text
            ChartControl.Animate()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentPoint)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            Dim diagram As PolarDiagram = TryCast(ChartControl.Diagram, PolarDiagram)
            If diagram IsNot Nothing Then
                comboBoxStyle.SelectedIndex = CInt(diagram.DrawingStyle)
                comboBoxEditRotationDirection.SelectedIndex = CInt(diagram.RotationDirection)
                spinEditStartAngle.EditValue = diagram.StartAngleInDegrees
                spinEditAxisLabelAngle.EditValue = diagram.AxisY.Label.Angle
            End If

            layoutControlItemMarkerVisible.Visibility = UpdateRadarMarkerOptions()
        End Sub

        Protected Overrides Function SetRangeMarkerVisibility(ByVal view As SeriesViewBase, ByVal visibility As DefaultBoolean) As Boolean
            Dim rangeAreaView As PolarRangeAreaSeriesView = TryCast(view, PolarRangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1Visibility = visibility
            rangeAreaView.Marker2Visibility = visibility
            Return True
        End Function

        Protected Overrides Function SetRangeMarkerSize(ByVal view As SeriesViewBase, ByVal size As Integer) As Boolean
            Dim rangeAreaView As PolarRangeAreaSeriesView = TryCast(view, PolarRangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1.Size = size
            rangeAreaView.Marker2.Size = size
            Return True
        End Function

        Protected Overrides Function SetRangeMarkerKind(ByVal view As SeriesViewBase, ByVal kind As MarkerKind, ByVal starCount As Integer) As Boolean
            Dim rangeAreaView As PolarRangeAreaSeriesView = TryCast(view, PolarRangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1.Kind = kind
            rangeAreaView.Marker1.StarPointCount = starCount
            rangeAreaView.Marker2.Kind = kind
            rangeAreaView.Marker2.StarPointCount = starCount
            Return True
        End Function
    End Class
End Namespace

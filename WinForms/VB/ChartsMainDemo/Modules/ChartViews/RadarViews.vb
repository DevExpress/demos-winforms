Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class RadarViewsDemo
        Inherits ChartDemoModuleMarkerViews

        Private ReadOnly Property IsScatterLineSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is ScatterRadarLineSeriesView
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
                Return New List(Of ChartControl)() From {chartPoint, chartLine, chartArea, chartRangeArea, chartScatterLine}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
            If IsScatterLineSeriesActive Then comboBoxEditFunction.SelectedIndex = 0
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility()
        End Sub

        Private Sub checkEditMarkerVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetMarkerVisibility(layoutControlItemMarkerKind, layoutControlItemMarkerSize)
        End Sub

        Private Sub comboBoxEditTextDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim textDirection As RadarAxisXLabelTextDirection = CType(comboBoxEditTextDirection.EditValue, DirectionComboBoxItem).Direction
            Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
            If diagram IsNot Nothing Then diagram.AxisX.Label.TextDirection = textDirection
        End Sub

        Private Sub comboBoxEditDiagramStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
            If diagram IsNot Nothing Then diagram.DrawingStyle = CType(comboBoxDiagramStyle.SelectedIndex, RadarDiagramDrawingStyle)
        End Sub

        Private Sub comboBoxEditFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim series As Series = TryCast(ActiveSeries, Series)
            If series Is Nothing Then Return
            series.Points.Clear()
            Dim functionCalculator As RadianScatterFunctionCalculator = New RadianScatterFunctionCalculator()
            Dim points As SeriesPoint() = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunction.SelectedIndex)
            series.Points.AddRange(points)
            ChartControl.Animate()
        End Sub

        Private Sub comboBoxEditRotationDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
            If diagram IsNot Nothing Then diagram.RotationDirection = CType(comboBoxEditRotationDirection.SelectedIndex, RadarDiagramRotationDirection)
        End Sub

        Private Sub spinEditStartAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
            If diagram IsNot Nothing Then diagram.StartAngleInDegrees = CInt(spinEditStartAngle.Value)
        End Sub

        Private Sub spinEditAxisLabelAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
            If diagram IsNot Nothing Then diagram.AxisY.Label.Angle = CInt(spinEditAxisLabelAngle.Value)
        End Sub

        Protected Overrides Sub InitControls()
            MyBase.InitControls()
            Dim directions As Array = [Enum].GetValues(GetType(RadarAxisXLabelTextDirection))
            For Each direction As RadarAxisXLabelTextDirection In directions
                comboBoxEditTextDirection.Properties.Items.Add(New DirectionComboBoxItem(direction))
            Next
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentPoint)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            layoutControlItemTextDirection.Visibility = If(IsScatterLineSeriesActive, LayoutVisibility.Never, LayoutVisibility.Always)
            layoutControlItemFunction.Visibility = If(IsScatterLineSeriesActive, LayoutVisibility.Always, LayoutVisibility.Never)
            layoutControlGroupGeneral.Visibility = If(IsScatterLineSeriesActive, LayoutVisibility.Always, LayoutVisibility.Never)
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
            If diagram IsNot Nothing Then
                comboBoxEditTextDirection.EditValue = New DirectionComboBoxItem(diagram.AxisX.Label.TextDirection)
                comboBoxDiagramStyle.SelectedIndex = CInt(diagram.DrawingStyle)
                comboBoxEditRotationDirection.SelectedIndex = CInt(diagram.RotationDirection)
                spinEditStartAngle.EditValue = diagram.StartAngleInDegrees
                spinEditAxisLabelAngle.EditValue = diagram.AxisY.Label.Angle
            End If

            layoutControlItemMarkerVisible.Visibility = UpdateRadarMarkerOptions()
        End Sub

        Protected Overrides Function SetRangeMarkerVisibility(ByVal view As SeriesViewBase, ByVal visibility As DefaultBoolean) As Boolean
            Dim rangeAreaView As RadarRangeAreaSeriesView = TryCast(view, RadarRangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1Visibility = visibility
            rangeAreaView.Marker2Visibility = visibility
            Return True
        End Function

        Protected Overrides Function SetRangeMarkerSize(ByVal view As SeriesViewBase, ByVal size As Integer) As Boolean
            Dim rangeAreaView As RadarRangeAreaSeriesView = TryCast(view, RadarRangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1.Size = size
            rangeAreaView.Marker2.Size = size
            Return True
        End Function

        Protected Overrides Function SetRangeMarkerKind(ByVal view As SeriesViewBase, ByVal kind As MarkerKind, ByVal starCount As Integer) As Boolean
            Dim rangeAreaView As RadarRangeAreaSeriesView = TryCast(view, RadarRangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1.Kind = kind
            rangeAreaView.Marker1.StarPointCount = starCount
            rangeAreaView.Marker2.Kind = kind
            rangeAreaView.Marker2.StarPointCount = starCount
            Return True
        End Function
    End Class

    Friend Class DirectionComboBoxItem

        Private _Text As String, _Direction As RadarAxisXLabelTextDirection

        Public Property Text As String
            Get
                Return _Text
            End Get

            Private Set(ByVal value As String)
                _Text = value
            End Set
        End Property

        Public Property Direction As RadarAxisXLabelTextDirection
            Get
                Return _Direction
            End Get

            Private Set(ByVal value As RadarAxisXLabelTextDirection)
                _Direction = value
            End Set
        End Property

        Public Sub New(ByVal textDirection As RadarAxisXLabelTextDirection)
            Direction = textDirection
            Text = SplitByWords(textDirection.ToString()).Replace("To ", "to ")
        End Sub

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            If obj Is Nothing Then Return False
            Dim directionComboBoxItem As DirectionComboBoxItem = TryCast(obj, DirectionComboBoxItem)
            If directionComboBoxItem Is Nothing Then Return False
            Return Direction = directionComboBoxItem.Direction
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return Direction.GetHashCode()
        End Function

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class
End Namespace

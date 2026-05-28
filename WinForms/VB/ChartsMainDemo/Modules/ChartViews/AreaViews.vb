Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class AreaViewsDemo
        Inherits ChartDemoModuleMarkerViews

        Private ReadOnly Property IsStackedAreaSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is StackedAreaSeriesView OrElse TypeOf view Is StackedSplineAreaSeriesView OrElse TypeOf view Is StackedStepAreaSeriesView OrElse IsFullStackedAreaSeriesActive
            End Get
        End Property

        Private ReadOnly Property IsFullStackedAreaSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is FullStackedAreaSeriesView OrElse TypeOf view Is FullStackedSplineAreaSeriesView OrElse TypeOf view Is FullStackedStepAreaSeriesView
            End Get
        End Property

        Private ReadOnly Property IsStepAreaSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is StepAreaSeriesView OrElse TypeOf view Is StackedStepAreaSeriesView OrElse TypeOf view Is FullStackedStepAreaSeriesView
            End Get
        End Property

        Private ReadOnly Property IsSplineAreaSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is SplineAreaSeriesView OrElse TypeOf view Is StackedSplineAreaSeriesView OrElse TypeOf view Is FullStackedSplineAreaSeriesView
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsLayoutControl As LayoutControl
            Get
                Return layoutControl
            End Get
        End Property

        Protected Overrides ReadOnly Property LabelAngleSpinEdit As SpinEdit
            Get
                Return spinEditLabelAngle
            End Get
        End Property

        Protected Overrides ReadOnly Property ValueAsPercentCheckEdit As CheckEdit
            Get
                Return checkEditValueAsPercent
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
                Return tabbedViewField
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartArea, chartStackedArea, chartFullStackedArea, chartStepArea, chartStackedStepArea, chartFullStackedStepArea, chartSplineArea, chartStackedSplineArea, chartFullStackedSplineArea}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub documentManager_DocumentActivate(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub checkEditMarkerVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetMarkerVisibility(layoutControlItemKind, layoutControlItemSize)
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemAngle, layoutControlItemValueAsPercent)
        End Sub

        Private Sub spinEditTransparency_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetTransparency))
        End Sub

        Private Sub checkEditInvertedStep_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetInvertedStep))
        End Sub

        Private Sub comboBoxEditSplineAlgorithm_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetSplineAlgorithm))
        End Sub

        Private Sub spinEditLineTension_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetLineTension))
        End Sub

        Private Sub SetTransparency(ByVal view As SeriesViewBase)
            Dim transparency As Byte = CByte(spinEditTransparency.Value)
            Dim areaView As AreaSeriesView = TryCast(view, AreaSeriesView)
            If areaView IsNot Nothing Then areaView.Transparency = transparency
        End Sub

        Private Sub SetInvertedStep(ByVal view As SeriesViewBase)
            Dim invertedStep As Boolean = checkEditInvertedStep.Checked
            Dim stepAreaView As StepAreaSeriesView = TryCast(view, StepAreaSeriesView)
            Dim stackedStepAreaView As StackedStepAreaSeriesView = TryCast(view, StackedStepAreaSeriesView)
            Dim fullStackedStepAreaView As FullStackedStepAreaSeriesView = TryCast(view, FullStackedStepAreaSeriesView)
            If stepAreaView IsNot Nothing Then stepAreaView.InvertedStep = invertedStep
            If stackedStepAreaView IsNot Nothing Then stackedStepAreaView.InvertedStep = invertedStep
            If fullStackedStepAreaView IsNot Nothing Then fullStackedStepAreaView.InvertedStep = invertedStep
        End Sub

        Private Sub SetSplineAlgorithm(ByVal view As SeriesViewBase)
            Dim splineAlgorithm As SplineAlgorithm = CType(comboBoxEditSplineAlgorithm.SelectedIndex, SplineAlgorithm)
            Dim splineView As SplineAreaSeriesView = TryCast(view, SplineAreaSeriesView)
            If splineView IsNot Nothing Then
                splineView.SplineAlgorithm = splineAlgorithm
                Return
            End If

            Dim stackedSplineView As StackedSplineAreaSeriesView = TryCast(view, StackedSplineAreaSeriesView)
            If stackedSplineView IsNot Nothing Then
                stackedSplineView.SplineAlgorithm = splineAlgorithm
                Return
            End If

            Dim fullStackedSplineView As FullStackedSplineAreaSeriesView = TryCast(view, FullStackedSplineAreaSeriesView)
            If fullStackedSplineView IsNot Nothing Then
                fullStackedSplineView.SplineAlgorithm = splineAlgorithm
                Return
            End If
        End Sub

        Private Sub SetLineTension(ByVal view As SeriesViewBase)
            Dim lineTension As Integer = Convert.ToInt32(spinEditLineTension.EditValue)
            Dim splineView As SplineAreaSeriesView = TryCast(view, SplineAreaSeriesView)
            If splineView IsNot Nothing Then
                splineView.LineTensionPercent = lineTension
                Return
            End If

            Dim stackedSplineView As StackedSplineAreaSeriesView = TryCast(view, StackedSplineAreaSeriesView)
            If stackedSplineView IsNot Nothing Then
                stackedSplineView.LineTensionPercent = lineTension
                Return
            End If

            Dim fullStackedSplineView As FullStackedSplineAreaSeriesView = TryCast(view, FullStackedSplineAreaSeriesView)
            If fullStackedSplineView IsNot Nothing Then
                fullStackedSplineView.LineTensionPercent = lineTension
                Return
            End If
        End Sub

        Private Function GetSplineAlgorithmIndex(ByVal view As SeriesViewBase) As Integer
            Dim splineView As SplineAreaSeriesView = TryCast(view, SplineAreaSeriesView)
            If splineView IsNot Nothing Then Return CInt(splineView.SplineAlgorithm)
            Dim stackedSplineView As StackedSplineAreaSeriesView = TryCast(view, StackedSplineAreaSeriesView)
            If stackedSplineView IsNot Nothing Then Return CInt(stackedSplineView.SplineAlgorithm)
            Dim fullStackedSplineView As FullStackedSplineAreaSeriesView = TryCast(view, FullStackedSplineAreaSeriesView)
            If fullStackedSplineView IsNot Nothing Then Return CInt(fullStackedSplineView.SplineAlgorithm)
            Return 0
        End Function

        Private Function GetLineTension(ByVal view As SeriesViewBase) As Integer
            Dim splineView As SplineAreaSeriesView = TryCast(view, SplineAreaSeriesView)
            If splineView IsNot Nothing Then Return splineView.LineTensionPercent
            Dim stackedSplineView As StackedSplineAreaSeriesView = TryCast(view, StackedSplineAreaSeriesView)
            If stackedSplineView IsNot Nothing Then Return stackedSplineView.LineTensionPercent
            Dim fullStackedSplineView As FullStackedSplineAreaSeriesView = TryCast(view, FullStackedSplineAreaSeriesView)
            If fullStackedSplineView IsNot Nothing Then Return fullStackedSplineView.LineTensionPercent
            Return 0
        End Function

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            layoutControlItemInvertedStep.Visibility = If(IsStepAreaSeriesActive, LayoutVisibility.Always, LayoutVisibility.Never)
            If IsFullStackedAreaSeriesActive Then
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Always
                layoutControlItemAngle.Visibility = LayoutVisibility.Never
                checkEditValueAsPercent.Checked = Equals(ActiveSeries.Label.TextPattern, PercentPattern)
            Else
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never
                layoutControlItemAngle.Visibility = LayoutVisibility.Always
                Dim pointLabel As PointSeriesLabel = TryCast(ActiveSeries.Label, PointSeriesLabel)
                Dim rangeAreaLabel As RangeAreaSeriesLabel = TryCast(ActiveSeries.Label, RangeAreaSeriesLabel)
                If pointLabel IsNot Nothing Then spinEditLabelAngle.Value = pointLabel.Angle
                If rangeAreaLabel IsNot Nothing Then spinEditLabelAngle.Value = rangeAreaLabel.MinValueAngle
            End If

            If IsSplineAreaSeriesActive Then
                layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Always
                comboBoxEditSplineAlgorithm.SelectedIndex = GetSplineAlgorithmIndex(ActiveSeries.View)
                layoutControlItemLineTension.Visibility = LayoutVisibility.Always
                spinEditLineTension.EditValue = GetLineTension(ActiveSeries.View)
            Else
                layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Never
                layoutControlItemLineTension.Visibility = LayoutVisibility.Never
            End If

            Dim view As AreaSeriesView = TryCast(ActiveSeries.View, AreaSeriesView)
            If view IsNot Nothing Then
                spinEditTransparency.Value = view.Transparency
                Dim markerOptionsVisible As Boolean = Not IsStackedAreaSeriesActive
                layoutControlGroupMarker.Visibility = If(markerOptionsVisible, LayoutVisibility.Always, LayoutVisibility.Never)
                If markerOptionsVisible Then
                    Dim rangeView As RangeAreaSeriesView = TryCast(view, RangeAreaSeriesView)
                    If rangeView IsNot Nothing Then
                        UpdateMarkerControls(rangeView.Marker1, rangeView.Marker1Visibility)
                    Else
                        UpdateMarkerControls(view.MarkerOptions, view.MarkerVisibility)
                    End If
                End If
            End If
        End Sub

        Protected Overrides Sub SetDataSources()
            chartArea.DataSource = DevAV.GetOutsideVendorCosts()
            chartStackedArea.DataSource = DevAV.GetSalesByLast10Years()
            chartFullStackedArea.DataSource = DevAV.GetBranchesSales()
            chartStepArea.DataSource = SourceOfEnergy.GetFuelPrices()
            chartSplineArea.DataSource = DevAV.GetOutsideVendorCosts()
            chartStackedSplineArea.DataSource = DevAV.GetSalesByLast10Years()
            chartFullStackedSplineArea.DataSource = DevAV.GetBranchesSales()
            chartRangeArea.DataSource = SourceOfEnergy.GetEuropeBrentPrices()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentArea)
        End Sub

        Protected Overrides Function SetRangeMarkerVisibility(ByVal view As SeriesViewBase, ByVal visibility As DefaultBoolean) As Boolean
            Dim rangeAreaView As RangeAreaSeriesView = TryCast(view, RangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1Visibility = visibility
            rangeAreaView.Marker2Visibility = visibility
            Return True
        End Function

        Protected Overrides Function SetRangeMarkerSize(ByVal view As SeriesViewBase, ByVal size As Integer) As Boolean
            Dim rangeAreaView As RangeAreaSeriesView = TryCast(view, RangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1.Size = size
            rangeAreaView.Marker2.Size = size
            Return True
        End Function

        Protected Overrides Function SetRangeMarkerKind(ByVal view As SeriesViewBase, ByVal kind As MarkerKind, ByVal starCount As Integer) As Boolean
            Dim rangeAreaView As RangeAreaSeriesView = TryCast(view, RangeAreaSeriesView)
            If rangeAreaView Is Nothing Then Return False
            rangeAreaView.Marker1.Kind = kind
            rangeAreaView.Marker1.StarPointCount = starCount
            rangeAreaView.Marker2.Kind = kind
            rangeAreaView.Marker2.StarPointCount = starCount
            Return True
        End Function
    End Class
End Namespace

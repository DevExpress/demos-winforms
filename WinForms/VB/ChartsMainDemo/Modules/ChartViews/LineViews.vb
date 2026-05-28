Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class LineViewsDemo
        Inherits ChartDemoModuleMarkerViews

        Private ReadOnly Property IsSplineChartActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is SplineSeriesView
            End Get
        End Property

        Private ReadOnly Property IsScatterLineChartActive As Boolean
            Get
                Return If(ActiveSeries Is Nothing, False, TypeOf ActiveSeries.View Is ScatterLineSeriesView)
            End Get
        End Property

        Private ReadOnly Property IsFullStackedChartActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is FullStackedLineSeriesView
            End Get
        End Property

        Private ReadOnly Property IsSplineOrStackedChartActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is StackedLineSeriesView OrElse IsSplineChartActive
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
                Return currentTabbedView
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartLine, chartStackedLine, chartFullStackedLine, chartStepLine, chartSpline, chartScatterLine}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
            If IsScatterLineChartActive Then ShowSeries(comboBoxEditFunction.SelectedIndex, ChartControl.Series)
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemAngle, layoutControlItemValueAsPercent)
        End Sub

        Private Sub checkEditMarkerVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetMarkerVisibility(layoutControlItemMarkerKind, layoutControlItemMarkerSize)
        End Sub

        Private Sub comboBoxSplineAlgorithm_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(Sub(view) CType(view, SplineSeriesView).SplineAlgorithm = CType(comboBoxEditSplineAlgorithm.SelectedIndex, SplineAlgorithm))
        End Sub

        Private Sub spinEditLineTension_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(Sub(view) CType(view, SplineSeriesView).LineTensionPercent = CInt(spinEditLineTension.Value))
        End Sub

        Private Sub comboBoxEditFunction_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowSeries(comboBoxEditFunction.SelectedIndex, ChartControl.Series)
            UpdateControlsCore()
        End Sub

        Private Sub UpdateCommonOptionsGroup()
            If IsSplineChartActive OrElse IsScatterLineChartActive Then
                layoutControlGroupGeneral.Visibility = LayoutVisibility.Always
                If IsScatterLineChartActive Then
                    layoutControlItemFunction.Visibility = LayoutVisibility.Always
                    layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Never
                    layoutControlItemLineTension.Visibility = LayoutVisibility.Never
                Else
                    layoutControlItemFunction.Visibility = LayoutVisibility.Never
                    layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Always
                    layoutControlItemLineTension.Visibility = LayoutVisibility.Always
                    Dim splineView As SplineSeriesView = TryCast(ActiveSeries.View, SplineSeriesView)
                    If splineView IsNot Nothing Then
                        comboBoxEditSplineAlgorithm.SelectedIndex = CInt(splineView.SplineAlgorithm)
                        spinEditLineTension.Value = splineView.LineTensionPercent
                    End If
                End If
            Else
                layoutControlGroupGeneral.Visibility = LayoutVisibility.Never
            End If
        End Sub

        Private Sub UpdateLabelAngelOptions()
            If IsSplineOrStackedChartActive Then
                layoutControlItemAngle.Visibility = LayoutVisibility.Always
                Dim pointLabel As PointSeriesLabel = TryCast(ActiveSeries.Label, PointSeriesLabel)
                If pointLabel IsNot Nothing Then spinEditLabelAngle.Value = pointLabel.Angle
            Else
                layoutControlItemAngle.Visibility = LayoutVisibility.Never
            End If
        End Sub

        Protected Overrides Sub SetDataSources()
            chartStackedLine.DataSource = DevAV.GetSalesByLast10Years()
            chartFullStackedLine.DataSource = DevAV.GetBranchesSales()
            chartStepLine.DataSource = SourceOfEnergy.GetFuelPrices()
            chartSpline.DataSource = PowerConsumption.GetData()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentLine)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            If ActiveSeries Is Nothing Then Return
            UpdateCommonOptionsGroup()
            UpdateLabelAngelOptions()
            layoutControlItemValueAsPercent.Visibility = If(IsFullStackedChartActive, LayoutVisibility.Always, LayoutVisibility.Never)
            Dim view As LineSeriesView = TryCast(ActiveSeries.View, LineSeriesView)
            If view IsNot Nothing Then
                UpdateMarkerControls(view.LineMarkerOptions, view.MarkerVisibility)
                checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            End If
        End Sub
    End Class
End Namespace

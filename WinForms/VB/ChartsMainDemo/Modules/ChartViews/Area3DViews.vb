Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class Area3DViewsDemo
        Inherits ChartDemoModule3DViews

        Private ReadOnly Property IsFullStackedArea3DSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is FullStackedArea3DSeriesView OrElse TypeOf view Is FullStackedSplineArea3DSeriesView
            End Get
        End Property

        Private ReadOnly Property IsStepArea3DSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is StepArea3DSeriesView
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsLayoutControl As LayoutControl
            Get
                Return layoutControl
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultAnglesButton As SimpleButton
            Get
                Return simpleButtonRestoreDefaultAngles
            End Get
        End Property

        Protected Overrides ReadOnly Property PerspectiveAngleComboBoxEdit As ComboBoxEdit
            Get
                Return comboBoxEditPerspectiveAngle
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

        Protected Overrides ReadOnly Property TabbedView As TabbedView
            Get
                Return currentTabbedView
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartStackedArea3D, chartRangeArea3D, chartStepArea3D, chartSplineArea3D, chartArea3D, chartStackedSplineArea3D, chartFullStackedArea3D, chartFullStackedSplineArea3D}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub documentManager_DocumentActivate(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemValueAsPercent)
        End Sub

        Private Sub spinEditTransparency_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf ApplyTransparency))
        End Sub

        Private Sub ApplyTransparency(ByVal view As SeriesViewBase)
            Dim areaView As Area3DSeriesView = TryCast(view, Area3DSeriesView)
            If areaView IsNot Nothing Then areaView.Transparency = CByte(spinEditTransparency.Value)
        End Sub

        Private Sub checkEditInvertedStep_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As StepArea3DSeriesView = TryCast(ActiveSeries.View, StepArea3DSeriesView)
            If view IsNot Nothing Then view.InvertedStep = checkEditInvertedStep.Checked
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            layoutControlItemInvertedStep.Visibility = If(IsStepArea3DSeriesActive, LayoutVisibility.Always, LayoutVisibility.Never)
            If IsFullStackedArea3DSeriesActive Then
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Always
                checkEditValueAsPercent.Checked = Equals(ActiveSeries.Label.TextPattern, PercentPattern)
            Else
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never
            End If

            Dim view As Area3DSeriesView = TryCast(ActiveSeries.View, Area3DSeriesView)
            If view IsNot Nothing Then spinEditTransparency.Value = view.Transparency
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentArea3D)
        End Sub

        Protected Overrides Sub SetDataSources()
            chartStackedArea3D.DataSource = DevAV.GetSalesByLast10Years()
            chartRangeArea3D.DataSource = SourceOfEnergy.GetOkWtiPrices()
            chartStepArea3D.DataSource = SourceOfEnergy.GetGasolinePrices()
            chartSplineArea3D.DataSource = DevAV.GetOutsideVendorCosts()
            chartArea3D.DataSource = DevAV.GetOutsideVendorCosts()
            chartStackedSplineArea3D.DataSource = DevAV.GetSalesByLast10Years()
            chartFullStackedArea3D.DataSource = DevAV.GetBranchesSales()
            chartFullStackedSplineArea3D.DataSource = DevAV.GetBranchesSales()
        End Sub
    End Class
End Namespace

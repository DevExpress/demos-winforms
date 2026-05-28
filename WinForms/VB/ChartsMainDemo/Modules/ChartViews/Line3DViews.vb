Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class Line3DViewsDemo
        Inherits ChartDemoModule3DViews

        Private ReadOnly Property IsStepLine3DSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is StepLine3DSeriesView
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

        Protected Overrides ReadOnly Property LabelVisibleCheckEdit As CheckEdit
            Get
                Return checkEditLabelVisible
            End Get
        End Property

        Protected Overrides ReadOnly Property ValueAsPercentCheckEdit As CheckEdit
            Get
                Return checkEditValueAsPercent
            End Get
        End Property

        Protected Overrides ReadOnly Property TabbedView As TabbedView
            Get
                Return currentTabbedView
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartLine3D, chartStepLine3D, chartSpline, chartStackedLine, chartFulStackedLine}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub SetCoalProductionDataSource(ByVal seriesCollection As SeriesCollection)
            For Each series As Series In seriesCollection
                series.DataSource = SourceOfEnergy.GetCoalProduction()
            Next
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(LayoutControlItemValueAsPercent)
        End Sub

        Private Sub checkEditInvertedStep_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsStepLine3DSeriesActive Then CType(ActiveSeries.View, StepLine3DSeriesView).InvertedStep = checkEditInvertedStep.Checked
        End Sub

        Protected Overrides Sub SetDataSources()
            SetCoalProductionDataSource(chartLine3D.Series)
            chartStepLine3D.Series(0).DataSource = SourceOfEnergy.GetGasolinePrices()
            SetCoalProductionDataSource(chartSpline.Series)
            chartStackedLine.DataSource = DevAV.GetSalesByLast10Years()
            chartFulStackedLine.DataSource = DevAV.GetBranchesSales()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentLine3D)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            layoutControlGroupGeneral.Visibility = If(IsStepLine3DSeriesActive, LayoutVisibility.Always, LayoutVisibility.Never)
            LayoutControlItemValueAsPercent.Visibility = If(TypeOf ActiveSeries.View Is FullStackedLine3DSeriesView, LayoutVisibility.Always, LayoutVisibility.Never)
        End Sub
    End Class
End Namespace

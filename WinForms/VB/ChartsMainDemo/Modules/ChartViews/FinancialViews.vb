Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class FinancialViewsDemo
        Inherits ChartDemoModuleLabelViews

        Private ReadOnly Property FinancialView As FinancialSeriesViewBase
            Get
                Return TryCast(ActiveSeries.View, FinancialSeriesViewBase)
            End Get
        End Property

        Private ReadOnly Property StockView As StockSeriesView
            Get
                Return TryCast(ActiveSeries.View, StockSeriesView)
            End Get
        End Property

        Private ReadOnly Property CandleStickView As CandleStickSeriesView
            Get
                Return TryCast(ActiveSeries.View, CandleStickSeriesView)
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsLayoutControl As LayoutControl
            Get
                Return layoutControl
            End Get
        End Property

        Protected Overrides ReadOnly Property LabelVisibleCheckEdit As CheckEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides ReadOnly Property TabbedView As TabbedView
            Get
                Return currentTabbedView
            End Get
        End Property

        Friend Overrides ReadOnly Property PaletteButtonEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartCandleStick, chartStock}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            CType(chartCandleStick.Diagram, XYDiagram).AxisX.VisualRange.SetMinMaxValues(New DateTime(2016, 4, 26), New DateTime(2016, 7, 25))
            CType(chartStock.Diagram, XYDiagram).AxisX.VisualRange.SetMinMaxValues(New DateTime(2016, 4, 26), New DateTime(2016, 7, 25))
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub comboBoxEditReductionLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ActiveSeries Is Nothing Then Return
            If FinancialView IsNot Nothing Then FinancialView.ReductionOptions.Level = CType(comboBoxEditReductionLevel.SelectedIndex, StockLevel)
        End Sub

        Private Sub checkEditWorkdaysOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As IXYDiagram2D = TryCast(ChartControl.Diagram, IXYDiagram2D)
            If diagram IsNot Nothing Then diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly = checkEditWorkDaysOnly.Checked
        End Sub

        Private Sub comboBoxEditStockType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ActiveSeries Is Nothing Then Return
            If StockView IsNot Nothing Then StockView.ShowOpenClose = CType(comboBoxEditStockType.SelectedIndex, StockType)
        End Sub

        Private Sub comboBoxEditReductionColorMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If FinancialView IsNot Nothing Then
                Dim colorMode As ReductionColorMode = CType(comboBoxEditReductionColorMode.SelectedIndex, ReductionColorMode)
                FinancialView.ReductionOptions.ColorMode = colorMode
                layoutControlItemReductionLevel.Enabled = colorMode.Equals(ReductionColorMode.PreviousToCurrentPoint)
            End If
        End Sub

        Private Sub colorPickEditReductionColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If FinancialView IsNot Nothing Then FinancialView.ReductionOptions.Color = CType(colorPickEditReductionColor.EditValue, Color)
        End Sub

        Private Sub colorPickEditBaseColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If FinancialView IsNot Nothing Then FinancialView.Color = CType(colorPickEditBaseColor.EditValue, Color)
        End Sub

        Private Sub comboBoxEditFillMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CandleStickView IsNot Nothing Then
                CandleStickView.ReductionOptions.FillMode = CType(comboBoxEditFillMode.SelectedIndex, CandleStickFillMode)
            End If
        End Sub

        Private Sub LoadSeriesData(ByVal series As Series)
            series.SetFinancialDataMembers("Date", "Low", "High", "Open", "Close")
            series.DataSource = MarketPricesReader.GetGoogleStockPrices()
        End Sub

        Protected Overrides Sub SetDataSources()
            LoadSeriesData(chartCandleStick.Series(0))
            LoadSeriesData(chartStock.Series(0))
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentCandleStick)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            layoutControlItemStockType.Visibility = If(StockView IsNot Nothing, LayoutVisibility.Always, LayoutVisibility.Never)
            layoutControlItemFillMode.Visibility = If(CandleStickView IsNot Nothing, LayoutVisibility.Always, LayoutVisibility.Never)
            If FinancialView IsNot Nothing Then
                Dim reductionStockOptions As ReductionStockOptions = FinancialView.ReductionOptions
                comboBoxEditReductionLevel.SelectedIndex = CInt(reductionStockOptions.Level)
                comboBoxEditReductionColorMode.SelectedIndex = CInt(reductionStockOptions.ColorMode)
                colorPickEditBaseColor.EditValue = FinancialView.Color
                colorPickEditReductionColor.EditValue = reductionStockOptions.Color
            End If

            Dim diagram As IXYDiagram2D = TryCast(ChartControl.Diagram, IXYDiagram2D)
            If diagram IsNot Nothing Then checkEditWorkDaysOnly.Checked = diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly
        End Sub
    End Class
End Namespace

Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class FinancialChartingDemo
        Inherits ChartDemoModule

        Const InitialPointCountOnScreen As Integer = 90

        Private ReadOnly dataGenerator As RealTimeFinancialDataGenerator

        Private ReadOnly selectedObject As Object = Nothing

        Private crosshairEnabled As DefaultBoolean

        Private ReadOnly Property XYDiagram As XYDiagram
            Get
                Return CType(chart.Diagram, XYDiagram)
            End Get
        End Property

        Private ReadOnly Property AxisY As AxisY
            Get
                Return XYDiagram.AxisY
            End Get
        End Property

        Private ReadOnly Property PriceSeries As Series
            Get
                Return chart.Series("Price")
            End Get
        End Property

        Private ReadOnly Property VolumeSeries As Series
            Get
                Return chart.Series("Volume")
            End Get
        End Property

        Private ReadOnly Property VolumeSeriesView As BarSeriesView
            Get
                Return CType(VolumeSeries.View, BarSeriesView)
            End Get
        End Property

        Private ReadOnly Property IsToolbarInteractionEnabled As Boolean
            Get
                Return trendLineBarCheckItem.Checked OrElse fibbArcBarCheckItem.Checked OrElse fibbFansBarCheckItem.Checked OrElse fibbRetrBarCheckItem.Checked OrElse removeBarCheckItem.Checked OrElse addTextAnnotationBarItem.Checked OrElse addImageAnnotationBarItem.Checked
            End Get
        End Property

        Friend Overrides ReadOnly Property PaletteButtonEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ExportedObject As Object
            Get
                Return Nothing
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AutoMergeRibbon = True
            ChartControl.BeginInit()
            dataGenerator = New RealTimeFinancialDataGenerator()
            dataGenerator.GenerateInitialData()
            InitChartControl()
            ChartControl.EndInit()
            dataGenerator.Start()
            timer.Enabled = True
        End Sub

        Private Sub InitChartControl()
            ChartControl.DataSource = dataGenerator.DataSource
            SetCustomLabelColor()
            selectAxisMeasureUnitBarItem1.EditValue = selectAxisMeasureUnitRepositoryItemComboBox1.Items(1)
            selectperiodBarItem1.EditValue = selectPeriodRepositoryItemComboBox1.Items(1)
            changeSeriesViewBarItem1.EditValue = changeSeriesViewRepositoryItemComboBox1.Items(1)
        End Sub

        Private Sub SetCustomLabelColor()
            AxisY.CustomLabels(0).BackColor = ChartControl.GetPaletteEntries(2)(1).Color
        End Sub

        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If dataGenerator IsNot Nothing Then dataGenerator.UpdateDataSource()
            Dim currentValueLabel As CustomAxisLabel = AxisY.CustomLabels(0)
            If PriceSeries.Points.Count > 0 Then
                Dim dataSource As FinancialDataCollection = dataGenerator.DataSource
                Dim currentClose As Double = dataSource(dataSource.Count - 1).Close
                currentValueLabel.AxisValue = currentClose
                currentValueLabel.Name = String.Format("{0:0.0000}", currentClose)
            End If
        End Sub

        Private Sub chart_Zoom(ByVal sender As Object, ByVal e As ChartZoomEventArgs)
            Dim rangeLengthInMeasureUnits As Double = e.NewXRange.Max - e.NewXRange.Min
            If rangeLengthInMeasureUnits > 1.2 * InitialPointCountOnScreen Then
                VolumeSeriesView.BarWidth = 1
            Else
                VolumeSeriesView.BarWidth = 0.6
            End If
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.SetObjectSelection(selectedObject)
            crosshairEnabled = ChartControl.CrosshairEnabled
        End Sub

        Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If IsToolbarInteractionEnabled Then ChartControl.CrosshairEnabled = crosshairEnabled
        End Sub

        Private Sub chartCommandBarCheckItem_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim isChecked As Boolean = IsToolbarInteractionEnabled
            timer.Enabled = Not isChecked
            ChartControl.CrosshairEnabled = If(IsToolbarInteractionEnabled, DefaultBoolean.False, crosshairEnabled)
        End Sub

        Private Sub BeforePopup(ByVal sender As Object, ByVal e As EventArgs)
            timer.Enabled = False
        End Sub

        Private Sub CloseUp(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsToolbarInteractionEnabled Then timer.Enabled = True
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            SetCustomLabelColor()
        End Sub

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.None, False)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing AndAlso dataGenerator IsNot Nothing Then
                dataGenerator.Stop()
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

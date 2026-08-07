Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class PointViewsDemo
        Inherits ChartDemoModuleMarkerViews

        Private ReadOnly Property BubbleSeriesView As BubbleSeriesView
            Get
                Return If(ActiveSeries IsNot Nothing, TryCast(ActiveSeries.View, BubbleSeriesView), Nothing)
            End Get
        End Property

        Private ReadOnly Property PointSeriesView As PointSeriesView
            Get
                Return If(ActiveSeries IsNot Nothing, TryCast(ActiveSeries.View, PointSeriesView), Nothing)
            End Get
        End Property

        Protected Overrides ReadOnly Property ToolTipEnabled As DefaultBoolean
            Get
                Return If(BubbleSeriesView IsNot Nothing, DefaultBoolean.True, DefaultBoolean.False)
            End Get
        End Property

        Protected Overrides ReadOnly Property CrosshairEnabled As DefaultBoolean
            Get
                Return DefaultBoolean.False
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

        Protected Overrides ReadOnly Property MarkerKindDefaultIndex As Integer
            Get
                Return 0
            End Get
        End Property

        Protected Overrides ReadOnly Property AnimationEnabled As Boolean
            Get
                Return BubbleSeriesView IsNot Nothing
            End Get
        End Property

        Protected Overrides ReadOnly Property TabbedView As TabbedView
            Get
                Return currentTabbedView
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartPoint, chartBubble}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            OnPaletteChanged()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub chartBubble_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            e.LegendText = CType(e.SeriesPoint.Tag, BubbleDataItem).Title
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(ActiveSeries, layoutControlItemPosition)
        End Sub

        Private Sub comboBoxEditLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditLabelPosition.SelectedIndex >= 0 AndAlso BubbleSeriesView IsNot Nothing Then
                Dim label As BubbleSeriesLabel = TryCast(ActiveSeries.Label, BubbleSeriesLabel)
                If label IsNot Nothing Then label.Position = CType(comboBoxEditLabelPosition.SelectedIndex, PointLabelPosition)
            End If
        End Sub

        Private Sub spinEditMaxBubbleSize_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
            If BubbleSeriesView IsNot Nothing Then
                If Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) <= BubbleSeriesView.MinSize Then e.Cancel = True
            End If
        End Sub

        Private Sub spinEditMinBubbleSize_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
            If BubbleSeriesView IsNot Nothing Then
                If Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) >= BubbleSeriesView.MaxSize Then e.Cancel = True
            End If
        End Sub

        Private Sub spinEditMinBubbleSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If BubbleSeriesView Is Nothing Then Return
            BubbleSeriesView.MinSize = Convert.ToDouble(spinEditMinBubbleSize.Value)
        End Sub

        Private Sub spinEditMaxBubbleSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If BubbleSeriesView Is Nothing Then Return
            BubbleSeriesView.MaxSize = Convert.ToDouble(spinEditMaxBubbleSize.Value)
        End Sub

        Private Sub spinEditTransparencyEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If BubbleSeriesView IsNot Nothing Then BubbleSeriesView.Transparency = Convert.ToByte(spinEditTransparency.Value)
        End Sub

        Private Sub tbcPointCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsHandleCreated Then Return
            BeginInvoke(CType((Sub() SetDataSources()), Action))
        End Sub

        Protected Overrides Sub SetDataSources()
            SeriesPointsInitializer.InitSeries(chartPoint, tbcPointCount.Value)
            chartBubble.Series(0).DataSource = GetData()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentPoint)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            Dim isBubbleSeriesView As Boolean = BubbleSeriesView IsNot Nothing
            Dim visibility As LayoutVisibility = If(isBubbleSeriesView, LayoutVisibility.Always, LayoutVisibility.Never)
            layoutControlGroupGeneral.Visibility = visibility
            layoutControlGroupLabel.Visibility = visibility
            visibility = If(isBubbleSeriesView, LayoutVisibility.Never, LayoutVisibility.Always)
            layoutControlGroupMarker.Visibility = visibility
            layoutControlGroupPointCount.Visibility = visibility
            If isBubbleSeriesView Then
                spinEditTransparency.Value = BubbleSeriesView.Transparency
                spinEditMinBubbleSize.EditValue = BubbleSeriesView.MinSize
                spinEditMaxBubbleSize.EditValue = BubbleSeriesView.MaxSize
            ElseIf PointSeriesView IsNot Nothing Then
                UpdateMarkerControls(PointSeriesView.PointMarkerOptions)
            End If
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            Dim entries As PaletteEntry() = chartPoint.GetPaletteEntries(chartPoint.Series.Count)
            For i As Integer = 0 To chartPoint.Series.Count - 1
                chartPoint.Series(i).View.Color = Color.FromArgb(50, entries(i).Color)
            Next
        End Sub

        Protected Friend Overrides Sub BeforeChartDesignerShown()
            If PointSeriesView IsNot Nothing Then
                Dim diagram As XYDiagram = TryCast(chartPoint.Diagram, XYDiagram)
                If diagram IsNot Nothing Then diagram.ResetZoom()
            End If
        End Sub
    End Class

    Public Class SeriesPointsInitializer

        Public Shared Sub InitSeries(ByVal chart As ChartControl, ByVal count As Integer)
            If chart.Series.Count > 2 AndAlso chart.Series(0).View.GetType().Equals(GetType(PointSeriesView)) Then
                chart.Series(0).DataSource = PointGenerator.GenerateCluster(TutorialConstants.Random, 140, 1280, 100, 1240, count)
                chart.Series(1).DataSource = PointGenerator.GenerateCluster(TutorialConstants.Random, 500, 1600, 1000, 2100, count)
                chart.Series(2).DataSource = PointGenerator.GenerateCluster(TutorialConstants.Random, 450, 950, 1550, 2050, count)
                chart.Series(3).DataSource = PointGenerator.GenerateCluster(TutorialConstants.Random, 800, 1700, 300, 1200, count)
                For Each series As Series In chart.Series
                    series.ArgumentDataMember = "Argument"
                    series.ValueDataMembers.AddRange("Value")
                Next
            End If
        End Sub
    End Class
End Namespace

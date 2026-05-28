Imports System
Imports DevExpress.Utils
Imports DevExpress.Utils.Design
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraCharts.Demos

    Public Class ChartDemoModuleLabelViews
        Inherits ChartDemoModuleWithOptions

        Protected Const PiePercentPattern As String = "{A}: {VP:P2}"

        Protected Const FunnelPercentPattern As String = "{A}: {VP:P0}"

        Protected Const PercentPattern As String = "{VP:P0}"

        Private activeChart As ChartControl = New ChartControl()

        Protected Overridable ReadOnly Property ActiveSeries As SeriesBase
            Get
                If ChartControl.Series.Count > 0 Then Return ChartControl.Series(0)
                Return ChartControl.SeriesTemplate
            End Get
        End Property

        Protected Overridable ReadOnly Property LabelAngleSpinEdit As SpinEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property ValueAsPercentCheckEdit As CheckEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property LabelVisibleCheckEdit As CheckEdit
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property OptionsLayoutControl As LayoutControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property CrosshairEnabled As DefaultBoolean
            Get
                Return DefaultBoolean.Default
            End Get
        End Property

        Protected Overridable ReadOnly Property ToolTipEnabled As DefaultBoolean
            Get
                Return DefaultBoolean.Default
            End Get
        End Property

        Protected Overridable ReadOnly Property AnimationEnabled As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overridable ReadOnly Property TabbedView As TabbedView
            Get
                Return Nothing
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return activeChart
            End Get
        End Property

        Public Sub New()
            AddHandler Load, AddressOf ChartDemoModuleLabelViews_Load
        End Sub

        Private Sub ChartDemoModuleLabelViews_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not DesignTimeTools.IsDesignMode Then InitControls()
        End Sub

        Private Function IsFullStackedBarView(ByVal view As SeriesViewBase) As Boolean
            Return TypeOf view Is FullStackedBarSeriesView OrElse TypeOf view Is FullStackedBar3DSeriesView
        End Function

        Private Function IsSideBySideFullStackedBarView(ByVal view As SeriesViewBase) As Boolean
            Return TypeOf view Is SideBySideFullStackedBarSeriesView OrElse TypeOf view Is SideBySideFullStackedBar3DSeriesView
        End Function

        Private Function IsFullStackedView(ByVal view As SeriesViewBase) As Boolean
            Return TypeOf view Is FullStackedAreaSeriesView OrElse TypeOf view Is FullStackedSplineAreaSeriesView OrElse TypeOf view Is FullStackedLineSeriesView OrElse TypeOf view Is FullStackedArea3DSeriesView OrElse TypeOf view Is FullStackedLine3DSeriesView
        End Function

        Private Function IsFunnelView(ByVal view As SeriesViewBase) As Boolean
            Return TypeOf view Is FunnelSeriesView OrElse TypeOf view Is Funnel3DSeriesView
        End Function

        Private Function IsPieView(ByVal view As SeriesViewBase) As Boolean
            Return TypeOf view Is PieSeriesView OrElse TypeOf view Is Pie3DSeriesView
        End Function

        Private Sub ValueAsPercentCheckedEditCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeries(New Action(Of SeriesBase)(AddressOf SetValueAsPercent))
        End Sub

        Private Sub LabelAngleSpinEditEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeries(New Action(Of SeriesBase)(AddressOf SetLabelAngle))
        End Sub

        Private Sub OnLabelVisibilityChanged(ByVal items As LayoutControlItem())
            Dim labelVisible As Boolean = LabelVisibleCheckEdit.Checked
            SetEnabledLayoutControlItems(labelVisible, items)
            ChartControl.CrosshairEnabled = If(labelVisible, DefaultBoolean.False, CrosshairEnabled)
            ChartControl.ToolTipEnabled = If(labelVisible, DefaultBoolean.False, ToolTipEnabled)
        End Sub

        Private Sub UpdateControls()
            If OptionsLayoutControl Is Nothing Then Return
            OptionsLayoutControl.BeginUpdate()
            UpdateControlsCore()
            OptionsLayoutControl.EndUpdate()
        End Sub

        Private Sub TabbedView_PopupMenuShowing(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.PopupMenuShowingEventArgs)
            e.Cancel = e.GetDocument() IsNot Nothing
        End Sub

        Protected Overridable Sub InitControls()
            If TabbedView IsNot Nothing Then AddHandler TabbedView.PopupMenuShowing, AddressOf TabbedView_PopupMenuShowing
            SetDataSources()
            If LabelAngleSpinEdit IsNot Nothing Then AddHandler LabelAngleSpinEdit.EditValueChanged, AddressOf LabelAngleSpinEditEditValueChanged
            If ValueAsPercentCheckEdit IsNot Nothing Then AddHandler ValueAsPercentCheckEdit.CheckedChanged, AddressOf ValueAsPercentCheckedEditCheckedChanged
        End Sub

        Protected Overridable Sub SetDataSources()
        End Sub

        Protected Overridable Sub UpdateControlsCore()
        End Sub

        Protected Overridable Sub OnDocumentActivatedCore(ByVal document As BaseDocument)
            UpdateControls()
            If AnimationEnabled Then activeChart.Animate()
        End Sub

        Protected Sub ApplySettingsToSeries(ByVal action As Action(Of SeriesBase))
            If String.IsNullOrEmpty(ChartControl.SeriesDataMember) AndAlso ChartControl.SeriesTemplate.DataAdapter Is Nothing Then
                For Each series As Series In ChartControl.Series
                    action(series)
                Next
            Else
                action(ChartControl.SeriesTemplate)
            End If
        End Sub

        Protected Sub ApplySettingsToSeriesView(ByVal viewAction As Action(Of SeriesViewBase))
            ApplySettingsToSeries(Sub(series) viewAction(series.View))
        End Sub

        Protected Sub SetEnabledLayoutControlItems(ByVal enabled As Boolean, ParamArray items As LayoutControlItem())
            For Each item As LayoutControlItem In items
                item.Enabled = enabled
            Next
        End Sub

        Protected Sub OnDocumentActivated(ByVal document As BaseDocument)
            If Not document.IsDockPanel Then Return
            activeChart = TryCast(CType(document.Control, DockPanel).ControlContainer.Controls(0), ChartControl)
            OnDocumentActivatedCore(document)
        End Sub

        Protected Sub SetLabelAngle(ByVal series As SeriesBase)
            Dim label As SeriesLabelBase = series.Label
            Dim labelAngle As Integer = CInt(LabelAngleSpinEdit.Value)
            Dim pointLabel As PointSeriesLabel = TryCast(label, PointSeriesLabel)
            If pointLabel IsNot Nothing Then
                pointLabel.Angle = labelAngle
                Return
            End If

            Dim rangeAreaLabel As RangeAreaSeriesLabel = TryCast(label, RangeAreaSeriesLabel)
            If rangeAreaLabel IsNot Nothing Then
                rangeAreaLabel.MinValueAngle = labelAngle
                rangeAreaLabel.MaxValueAngle = labelAngle
            End If
        End Sub

        Protected Sub SetLabelVisibility(ParamArray items As LayoutControlItem())
            OnLabelVisibilityChanged(items)
            Dim labelsVisibility As DefaultBoolean = CovertBoolToDefaultBoolean(LabelVisibleCheckEdit.Checked)
            ApplySettingsToSeries(Sub(series) series.LabelsVisibility = labelsVisibility)
        End Sub

        Protected Sub SetLabelVisibility(ByVal series As SeriesBase, ParamArray items As LayoutControlItem())
            OnLabelVisibilityChanged(items)
            series.LabelsVisibility = CovertBoolToDefaultBoolean(LabelVisibleCheckEdit.Checked)
        End Sub

        Protected Sub SetValueAsPercent(ByVal series As SeriesBase)
            Dim view As SeriesViewBase = series.View
            Dim valueAsPercent As Boolean = ValueAsPercentCheckEdit.Checked
            If TypeOf view Is FullStackedStepAreaSeriesView Then
                series.Label.TextPattern = If(valueAsPercent, PercentPattern, "{V:F0}")
            ElseIf IsPieView(view) Then
                series.Label.TextPattern = If(valueAsPercent, PiePercentPattern, "{A}: {V:F1}")
            ElseIf IsFunnelView(view) Then
                series.Label.TextPattern = If(valueAsPercent, FunnelPercentPattern, "{A}: {V:F0}")
            ElseIf IsSideBySideFullStackedBarView(view) Then
                series.Label.TextPattern = If(valueAsPercent, PercentPattern, "{V:0,,.0}M")
            ElseIf IsFullStackedBarView(view) Then
                series.Label.TextPattern = If(valueAsPercent, PercentPattern, "{V:F0}K")
            ElseIf IsFullStackedView(view) Then
                series.Label.TextPattern = If(valueAsPercent, PercentPattern, "${V}M")
            End If
        End Sub
    End Class
End Namespace

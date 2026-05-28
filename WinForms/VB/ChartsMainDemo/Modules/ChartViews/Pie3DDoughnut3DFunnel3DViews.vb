Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class Pie3DDoughnut3DFunnel3DViewsDemo
        Inherits ChartDemoModule3DViews

        Private ReadOnly pieLabelPosition As String() = New String() {"Inside", "Outside", "TwoColumns", "Radial"}

        Private ReadOnly funnelLabelPosition As String() = New String() {"LeftColumn", "Left", "Center", "Right", "RightColumn"}

        Private ReadOnly Property IsPieActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is Pie3DSeriesView
            End Get
        End Property

        Private ReadOnly Property IsDoughnutActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is Doughnut3DSeriesView
            End Get
        End Property

        Private ReadOnly Property IsFunnelSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is Funnel3DSeriesView
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultPerspective As Integer
            Get
                Return 20
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
                Return New List(Of ChartControl)() From {chartPie3D, chartDoughnut3D, chartFunnel3D}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemPosition, layoutControlItemValueAsPercent)
        End Sub

        Private Sub spinEditHoleRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf SetHoleRadius))
        End Sub

        Private Sub comboBoxEditExplodedPoints_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As Pie3DSeriesView = TryCast(ActiveSeries.View, Pie3DSeriesView)
            If view IsNot Nothing Then
                Dim mode As String = CStr(comboBoxEditExplodedPoints.SelectedItem)
                ApplyMode(view, mode)
                spinEditExplodedDistance.Enabled = Not Equals(mode, None)
                spinEditExplodedDistance.EditValue = CType(ChartControl.Series(0).View, Pie3DSeriesView).ExplodedDistancePercentage
            End If
        End Sub

        Private Sub comboBoxEditLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim pieLabel As PieSeriesLabel = TryCast(ActiveSeries.Label, PieSeriesLabel)
            If pieLabel IsNot Nothing Then
                pieLabel.Position = CType(comboBoxEditLabelPosition.SelectedIndex, PieSeriesLabelPosition)
                Return
            End If

            Dim funnelLabel As FunnelSeriesLabel = TryCast(ActiveSeries.Label, FunnelSeriesLabel)
            If funnelLabel IsNot Nothing Then funnelLabel.Position = CType(comboBoxEditLabelPosition.SelectedIndex, FunnelSeriesLabelPosition)
        End Sub

        Private Sub comboBoxEditHeightToWidthRatio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As Funnel3DSeriesView = TryCast(ActiveSeries.View, Funnel3DSeriesView)
            If view IsNot Nothing Then view.HeightToWidthRatio = Convert.ToDouble(comboBoxEditHeightToWidthRatio.SelectedItem)
        End Sub

        Private Sub spinEditPointDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As Funnel3DSeriesView = TryCast(ActiveSeries.View, Funnel3DSeriesView)
            If view IsNot Nothing Then view.PointDistance = Convert.ToInt32(spinEditPointDistance.Value)
        End Sub

        Private Sub spinEditExplodedDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChartControl.Series.Count = 0 Then Return
            Dim view As Pie3DSeriesView = TryCast(ChartControl.Series(0).View, Pie3DSeriesView)
            If view IsNot Nothing Then view.ExplodedDistancePercentage = Convert.ToDouble(spinEditExplodedDistance.EditValue)
        End Sub

        Private Sub spinEditFunnelHoleRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As Funnel3DSeriesView = TryCast(ActiveSeries.View, Funnel3DSeriesView)
            If view IsNot Nothing Then view.HoleRadiusPercent = Convert.ToInt32(spinEditFunnelHoleRadius.EditValue)
        End Sub

        Private Sub SetHoleRadius(ByVal view As SeriesViewBase)
            Dim doughnutView As Doughnut3DSeriesView = TryCast(view, Doughnut3DSeriesView)
            If doughnutView IsNot Nothing Then doughnutView.HoleRadiusPercent = Convert.ToInt32(spinEditHoleRadius.EditValue)
        End Sub

        Private Sub UpdatePieOptions()
            layoutControlItemExplodedPoints.Visibility = LayoutVisibility.Always
            UpdateExplodePointsComboBoxEdit()
            comboBoxEditLabelPosition.Properties.Items.AddRange(pieLabelPosition)
            Dim pieLabel As PieSeriesLabel = TryCast(ActiveSeries.Label, PieSeriesLabel)
            If pieLabel IsNot Nothing Then comboBoxEditLabelPosition.SelectedIndex = CInt(pieLabel.Position)
        End Sub

        Private Sub UpdateExplodePointsComboBoxEdit()
            Dim explodeSelectedIndex As Integer = -1
            Dim view As Pie3DSeriesView = CType(ActiveSeries.View, Pie3DSeriesView)
            Select Case view.ExplodeMode
                Case PieExplodeMode.Others, PieExplodeMode.UsePoints
                Case PieExplodeMode.UseFilters
                    Dim filterValue As Object = view.ExplodedPointsFilters(0).Value
                    explodeSelectedIndex = comboBoxEditExplodedPoints.Properties.Items.IndexOf(filterValue)
                Case Else
                    explodeSelectedIndex = CInt(view.ExplodeMode)
            End Select

            comboBoxEditExplodedPoints.SelectedIndex = explodeSelectedIndex
        End Sub

        Private Sub UpdateFunnelOptions()
            layoutControlGroupFunnelGeneral.Visibility = LayoutVisibility.Always
            layoutControlGroupPieDoughnutGeneral.Visibility = LayoutVisibility.Never
            comboBoxEditLabelPosition.Properties.Items.AddRange(funnelLabelPosition)
            Dim view As Funnel3DSeriesView = CType(ActiveSeries.View, Funnel3DSeriesView)
            comboBoxEditHeightToWidthRatio.EditValue = view.HeightToWidthRatio
            spinEditPointDistance.Value = view.PointDistance
            comboBoxEditLabelPosition.SelectedIndex = CInt(CType(ActiveSeries.Label, FunnelSeriesLabel).Position)
            spinEditFunnelHoleRadius.Value = view.HoleRadiusPercent
        End Sub

        Protected Overrides Sub InitControls()
            MyBase.InitControls()
            comboBoxEditLabelPosition.SelectedIndex = 2
            AddHandler comboBoxEditLabelPosition.SelectedIndexChanged, AddressOf comboBoxEditLabelPosition_SelectedIndexChanged
            comboBoxEditExplodedPoints.Properties.Items.AddRange(CreateModeList(chartPie3D.Series(0).Points, False))
            comboBoxEditExplodedPoints.SelectedIndex = 0
            AddHandler spinEditPointDistance.EditValueChanged, AddressOf spinEditPointDistance_EditValueChanged
            comboBoxEditHeightToWidthRatio.Properties.Items.AddRange(New Double() {0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10})
            spinEditHoleRadius.EditValue = CType(chartDoughnut3D.Series(0).View, Doughnut3DSeriesView).HoleRadiusPercent
            AddHandler spinEditHoleRadius.EditValueChanged, AddressOf spinEditHoleRadius_EditValueChanged
        End Sub

        Protected Overrides Sub SetDataSources()
            chartFunnel3D.DataSource = AgeStructureDataReader.GetPopulationAgeStructure()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentPie3D)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            layoutControl.BeginUpdate()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            Dim actualPattern As String = ActiveSeries.Label.TextPattern
            checkEditValueAsPercent.Checked = Equals(actualPattern, PiePercentPattern) OrElse Equals(actualPattern, FunnelPercentPattern)
            comboBoxEditLabelPosition.Properties.Items.Clear()
            If IsFunnelSeriesActive Then
                UpdateFunnelOptions()
            Else
                layoutControlGroupFunnelGeneral.Visibility = LayoutVisibility.Never
                layoutControlGroupPieDoughnutGeneral.Visibility = LayoutVisibility.Always
                layoutControlGroupExplodedDistance.Visibility = If(IsDoughnutActive, LayoutVisibility.Never, LayoutVisibility.Always)
                layoutControlItemDoughnutHoleRadius.Visibility = If(IsDoughnutActive, LayoutVisibility.Always, LayoutVisibility.Never)
                UpdatePieOptions()
            End If

            layoutControl.EndUpdate()
        End Sub

        Protected Overrides Sub UpdateRotationAngles(ByVal diagram As Diagram3D)
            diagram.RotationOrder = RotationOrder.ZXY
            If IsPieActive Then
                diagram.RotationAngleX = -35
                diagram.RotationAngleY = 0
                diagram.RotationAngleZ = 15
            Else
                diagram.RotationAngleX = 15
                diagram.RotationAngleY = 0
                diagram.RotationAngleZ = 0
            End If
        End Sub
    End Class
End Namespace

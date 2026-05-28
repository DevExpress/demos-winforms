Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class PieDoughnutFunnelViewsDemo
        Inherits ChartDemoModuleLabelViews

        Private ReadOnly pieLabelPosition As String() = New String() {"Inside", "Outside", "Two Columns", "Radial"}

        Private ReadOnly funnelLabelPosition As String() = New String() {"Left Column", "Left", "Center", "Right", "Right Column"}

        Private ReadOnly ageLegendItems As CustomLegendItem() = New CustomLegendItem(2) {}

        Private ReadOnly genderLegendItems As CustomLegendItem() = New CustomLegendItem(1) {}

        Private ReadOnly Property IsDoughnutActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is DoughnutSeriesView
            End Get
        End Property

        Private ReadOnly Property IsNestedDoughnutActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is NestedDoughnutSeriesView
            End Get
        End Property

        Private ReadOnly Property IsFunnelSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is FunnelSeriesView
            End Get
        End Property

        Protected Overrides ReadOnly Property ToolTipEnabled As DefaultBoolean
            Get
                Return DefaultBoolean.True
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsLayoutControl As LayoutControl
            Get
                Return layoutControl
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
                Return New List(Of ChartControl)() From {chartPie, chartDoughnut, chartNestedDoughnut, chartFunnel}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            UpdateNestedDonutLegendsBackColor()
            SplitNestedDonutLegendItems()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub chartNestedDoughnut_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chartNestedDoughnut.Series.Count > 0 Then
                chartNestedDoughnut.Series(0).ShowInLegend = True
                For Each series As Series In chartNestedDoughnut.Series
                    Dim nestedView As NestedDoughnutSeriesView = TryCast(series.View, NestedDoughnutSeriesView)
                    Dim population As AgePopulation = TryCast(series.Points(0).Tag, AgePopulation)
                    If population IsNot Nothing AndAlso nestedView IsNot Nothing Then
                        Dim name As String = population.Name
                        nestedView.Group = name
                        nestedView.Titles.Clear()
                        nestedView.Titles.Add(New SeriesTitle() With {.Text = name})
                    End If
                Next
            End If
        End Sub

        Private Sub OnChartPieSeriesPointExploded(ByVal sender As Object, ByVal e As PieSeriesPointExplodedEventArgs)
            If e.Dragged Then comboBoxEditExplodedPoints.Text = Custom
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemPosition, layoutControlItemValueAsPercent)
        End Sub

        Private Sub spinEditInnerIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As NestedDoughnutSeriesView = TryCast(ChartControl.SeriesTemplate.View, NestedDoughnutSeriesView)
            If view IsNot Nothing Then view.InnerIndent = Convert.ToDouble(spinEditInnerIndent.EditValue)
        End Sub

        Private Sub comboBoxEditExplodedPoints_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As PieSeriesView = TryCast(ActiveSeries.View, PieSeriesView)
            If view IsNot Nothing Then
                Dim mode As String = CStr(comboBoxEditExplodedPoints.SelectedItem)
                ApplyMode(view, mode)
            End If
        End Sub

        Private Sub comboBoxEditGroupSeriesBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.BeginInit()
            Try
                If comboBoxEditGroupSeriesBy.SelectedIndex = 0 Then
                    GroupByGender()
                Else
                    GroupByAge()
                End If
            Finally
                ChartControl.EndInit()
            End Try
        End Sub

        Private Sub comboBoxEditLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim pieLabel As PieSeriesLabel = TryCast(ActiveSeries.Label, PieSeriesLabel)
            If pieLabel IsNot Nothing Then
                pieLabel.Position = CType(comboBoxEditLabelPosition.SelectedIndex, PieSeriesLabelPosition)
                pieLabel.TextColor = If(pieLabel.Position.Equals(PieSeriesLabelPosition.Outside) OrElse pieLabel.Position.Equals(PieSeriesLabelPosition.TwoColumns), Color.Empty, Color.Black)
                Return
            End If

            Dim funnelLabel As FunnelSeriesLabel = TryCast(ActiveSeries.Label, FunnelSeriesLabel)
            If funnelLabel IsNot Nothing Then funnelLabel.Position = CType(comboBoxEditLabelPosition.SelectedIndex, FunnelSeriesLabelPosition)
        End Sub

        Private Sub spinEditTotalLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As PieSeriesView = TryCast(ActiveSeries.View, PieSeriesView)
            If view IsNot Nothing Then view.TotalLabel.Visible = checkEditTotalLabelVisible.Checked
        End Sub

        Private Sub checkEditAlignToCenter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As FunnelSeriesView = TryCast(ActiveSeries.View, FunnelSeriesView)
            If view IsNot Nothing Then view.AlignToCenter = checkEditAlignToCenter.Checked
        End Sub

        Private Sub checkEditAutoHeightToWidthRatio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As FunnelSeriesView = TryCast(ActiveSeries.View, FunnelSeriesView)
            If view IsNot Nothing Then
                view.HeightToWidthRatioAuto = checkEditAutoHeightToWidthRatio.Checked
                comboBoxEditHeightToWidthRatio.Enabled = Not checkEditAutoHeightToWidthRatio.Checked
            End If
        End Sub

        Private Sub comboBoxEditHeightToWidthRatio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As FunnelSeriesView = TryCast(ActiveSeries.View, FunnelSeriesView)
            If view IsNot Nothing Then view.HeightToWidthRatio = Convert.ToDouble(comboBoxEditHeightToWidthRatio.SelectedItem)
        End Sub

        Private Sub spinEditPointDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As FunnelSeriesView = TryCast(ActiveSeries.View, FunnelSeriesView)
            If view IsNot Nothing Then view.PointDistance = Convert.ToInt32(spinEditPointDistance.Value)
        End Sub

        Private Sub OnSpinEditHoleRadiusEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim spinEdit As SpinEdit = TryCast(sender, SpinEdit)
            If spinEdit Is Nothing Then Return
            Dim holeRadius As Integer = Convert.ToInt32(spinEdit.EditValue)
            ApplySettingsToSeriesView(Sub(view)
                Dim doughnutView As DoughnutSeriesView = TryCast(view, DoughnutSeriesView)
                If doughnutView IsNot Nothing Then doughnutView.HoleRadiusPercent = holeRadius
            End Sub)
        End Sub

        Private Sub GroupByAge()
            ChartControl.SeriesDataMember = "CountryAgeKey"
            Dim argumentDataMember As String = "Gender"
            ChartControl.Titles(0).Text = "Population: " & argumentDataMember & " Structure"
            ChartControl.SeriesTemplate.ToolTipHintDataMember = "Age"
            ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember
            UpdateNestedDonutLegendItems(ageLegendItems)
        End Sub

        Private Sub GroupByGender()
            ChartControl.SeriesDataMember = "CountryGenderKey"
            Dim argumentDataMember As String = "Age"
            ChartControl.Titles(0).Text = "Population: " & argumentDataMember & " Structure"
            ChartControl.SeriesTemplate.ToolTipHintDataMember = "Gender"
            ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember
            UpdateNestedDonutLegendItems(genderLegendItems)
        End Sub

        Private Sub UpdateNestedDonutLegendItems(ByVal items As CustomLegendItem())
            If chartNestedDoughnut.Legends.Count < 1 Then Return
            Dim collection As CustomLegendItemCollection = chartNestedDoughnut.Legends(0).CustomItems
            collection.Clear()
            collection.AddRange(items)
        End Sub

        Private Sub UpdatePieAndDoughnutOptions()
            layoutControlOptionsGroup.Visibility = LayoutVisibility.Always
            layoutControlItemExplodedPoints.Visibility = LayoutVisibility.Always
            UpdateExplodePointsCBE()
            comboBoxEditLabelPosition.Properties.Items.AddRange(pieLabelPosition)
            Dim pieLabel As PieSeriesLabel = TryCast(ActiveSeries.Label, PieSeriesLabel)
            If pieLabel IsNot Nothing Then comboBoxEditLabelPosition.SelectedIndex = CInt(pieLabel.Position)
            checkEditTotalLabelVisible.Checked = CType(ActiveSeries.View, PieSeriesView).TotalLabel.Visible
        End Sub

        Private Sub UpdateNestedDoughnutOptions()
            layoutControlOptionsGroup.Visibility = LayoutVisibility.Never
            layoutControlItemExplodedPoints.Visibility = LayoutVisibility.Never
            spinEditInnerIndent.EditValue = CType(ActiveSeries.View, NestedDoughnutSeriesView).InnerIndent
            comboBoxEditGroupSeriesBy.SelectedIndex = If(Equals(ChartControl.SeriesTemplate.ArgumentDataMember, "Age"), 0, 1)
            spinEditNestedDoughnutHoleRadius.EditValue = CType(ActiveSeries.View, DoughnutSeriesView).HoleRadiusPercent
        End Sub

        Private Sub UpdateExplodePointsCBE()
            Dim explodeSelectedIndex As Integer = -1
            Dim view As PieSeriesView = CType(ActiveSeries.View, PieSeriesView)
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
            layoutControlOptionsGroup.Visibility = LayoutVisibility.Always
            layoutControlGroupFunnelGeneral.Visibility = LayoutVisibility.Always
            layoutControlItemTotalLabelVisible.Visibility = LayoutVisibility.Never
            comboBoxEditLabelPosition.Properties.Items.AddRange(funnelLabelPosition)
            Dim view As FunnelSeriesView = CType(ActiveSeries.View, FunnelSeriesView)
            checkEditAutoHeightToWidthRatio.Checked = view.HeightToWidthRatioAuto
            comboBoxEditHeightToWidthRatio.EditValue = view.HeightToWidthRatio
            spinEditPointDistance.Value = view.PointDistance
            checkEditAlignToCenter.Checked = view.AlignToCenter
            comboBoxEditLabelPosition.SelectedIndex = CInt(CType(ActiveSeries.Label, FunnelSeriesLabel).Position)
        End Sub

        Private Sub UpdateNestedDonutLegendsBackColor()
            Dim chartBackColor As Color = GetChartBackground(ChartControl.LookAndFeel)
            chartNestedDoughnut.Legend.BackColor = chartBackColor
            If chartNestedDoughnut.Legends.Count > 0 Then chartNestedDoughnut.Legends(0).BackColor = chartBackColor
        End Sub

        Private Sub SplitNestedDonutLegendItems()
            Dim items As CustomLegendItemCollection = chartNestedDoughnut.Legends(0).CustomItems
            Dim ageItemsCount As Integer = ageLegendItems.Length
            For i As Integer = 0 To items.Count - 1
                If i < ageItemsCount Then
                    ageLegendItems(i) = items(i)
                Else
                    genderLegendItems(i - ageItemsCount) = items(i)
                End If
            Next

            UpdateNestedDonutLegendItems(genderLegendItems)
        End Sub

        Protected Overrides Sub InitControls()
            MyBase.InitControls()
            comboBoxEditLabelPosition.SelectedIndex = 2
            AddHandler comboBoxEditLabelPosition.SelectedIndexChanged, AddressOf comboBoxEditLabelPosition_SelectedIndexChanged
            comboBoxEditExplodedPoints.Properties.Items.AddRange(CreateModeList(chartPie.Series(0).Points, False))
            comboBoxEditExplodedPoints.SelectedIndex = 0
            AddHandler spinEditPointDistance.EditValueChanged, AddressOf spinEditPointDistance_EditValueChanged
            comboBoxEditHeightToWidthRatio.Properties.Items.AddRange(New Double() {0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10})
        End Sub

        Protected Overrides Sub SetDataSources()
            chartNestedDoughnut.DataSource = AgeStructureDataReader.GetPopulationAgeStructure()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentPie)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            Dim actualPattern As String = ActiveSeries.Label.TextPattern
            checkEditValueAsPercent.Checked = Equals(actualPattern, PiePercentPattern) OrElse Equals(actualPattern, FunnelPercentPattern)
            comboBoxEditLabelPosition.Properties.Items.Clear()
            comboBoxEditLabelPosition.SelectedIndex = -1
            Dim nestedDonutOptionsVisibility As LayoutVisibility = If(IsNestedDoughnutActive, LayoutVisibility.Always, LayoutVisibility.Never)
            layoutControlItemInnerIndent.Visibility = nestedDonutOptionsVisibility
            layoutControlItemGroupSeriesBy.Visibility = nestedDonutOptionsVisibility
            layoutControlItemNestedDoughnutHoleRadius.Visibility = nestedDonutOptionsVisibility
            layoutControlGroupPieDoughnutGeneral.Visibility = If(IsNestedDoughnutActive OrElse IsFunnelSeriesActive, LayoutVisibility.Never, LayoutVisibility.Always)
            If IsFunnelSeriesActive Then
                UpdateFunnelOptions()
            Else
                layoutControlGroupFunnelGeneral.Visibility = LayoutVisibility.Never
                layoutControlItemPieDoughnutHoleRadius.Visibility = If(IsDoughnutActive, LayoutVisibility.Always, LayoutVisibility.Never)
                If IsDoughnutActive Then spinEditDoughnutHoleRadius.EditValue = CType(ActiveSeries.View, DoughnutSeriesView).HoleRadiusPercent
                layoutControlGroupTotalLabel.Visibility = If(IsDoughnutActive AndAlso Not IsNestedDoughnutActive, LayoutVisibility.Always, LayoutVisibility.Never)
                If IsNestedDoughnutActive Then
                    UpdateNestedDoughnutOptions()
                Else
                    UpdatePieAndDoughnutOptions()
                End If
            End If
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateNestedDonutLegendsBackColor()
        End Sub
    End Class
End Namespace

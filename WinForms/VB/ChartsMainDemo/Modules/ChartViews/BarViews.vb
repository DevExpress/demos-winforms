Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class BarViewsDemo
        Inherits ChartDemoModuleLabelViews

        Private ReadOnly Property IsSideBySideStackedSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is SideBySideStackedBarSeriesView OrElse TypeOf view Is SideBySideFullStackedBarSeriesView
            End Get
        End Property

        Private ReadOnly Property IsFullStackedSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is FullStackedBarSeriesView OrElse TypeOf view Is SideBySideFullStackedBarSeriesView
            End Get
        End Property

        Private ReadOnly Property IsStackedOrFullStackedSeriesActive As Boolean
            Get
                Return IsSideBySideStackedSeriesActive OrElse IsFullStackedSeriesActive OrElse TypeOf ActiveSeries.View Is StackedBarSeriesView
            End Get
        End Property

        Private ReadOnly Property IsSideBySideBarSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is SideBySideBarSeriesView
            End Get
        End Property

        Private ReadOnly Property IsRangeBarSeriesActive As Boolean
            Get
                Return TypeOf ActiveSeries.View Is RangeBarSeriesView
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
                Return New List(Of ChartControl)() From {chartBar, chartStackedBar, chartFullStackedBar, chartFullStackedBarSideBySide, chartStackedBarSideBySide, chartRangeBar, chartRangeBarSideBySide}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub comboBoxEditGroupSeriesBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.RefreshData()
        End Sub

        Private Sub checkEditDiagramRotated_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As XYDiagram = TryCast(ChartControl.Diagram, XYDiagram)
            diagram.Rotated = checkEditDiagramRotated.Checked
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemValueAsPercent, layoutControlItemIndent, layoutControlItemOrientation, layoutControlItemPosition, layoutControlItemRangeBarLabelPosition)
            If IsRangeBarSeriesActive Then
                UpdateRangeBarLabelIndent(CType(ActiveSeries.Label, RangeBarSeriesLabel))
            Else
                UpdateLabelIndent(CType(ActiveSeries.Label, BarSeriesLabel))
            End If
        End Sub

        Private Sub comboBoxEditLabelPosition_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim label As BarSeriesLabel = TryCast(ChartControl.SeriesTemplate.Label, BarSeriesLabel)
            If label IsNot Nothing AndAlso comboBoxEditLabelPosition.SelectedItem IsNot Nothing Then
                Dim item As BarLabelPositionItem = TryCast(comboBoxEditLabelPosition.SelectedItem, BarLabelPositionItem)
                If item Is Nothing Then Return
                label.Position = item.Position
                UpdateLabelIndent(label)
            End If
        End Sub

        Private Sub comboBoxEditRangeBarLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim position As RangeBarLabelPosition = CType(comboBoxEditRangeBarLabelPosition.SelectedIndex, RangeBarLabelPosition)
            For Each series As Series In ChartControl.Series
                Dim label As RangeBarSeriesLabel = CType(series.Label, RangeBarSeriesLabel)
                label.Position = position
                UpdateRangeBarLabelIndent(label)
            Next
        End Sub

        Private Sub comboBoxEditLabelOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.SeriesTemplate.Label.TextOrientation = CType(comboBoxEditLabelOrientation.SelectedIndex, TextOrientation)
        End Sub

        Private Sub spinEditLabelIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim label As BarSeriesLabel = TryCast(ChartControl.SeriesTemplate.Label, BarSeriesLabel)
            If label IsNot Nothing Then
                label.Indent = CInt(spinEditLabelIndent.Value)
                Return
            End If

            If IsRangeBarSeriesActive Then
                For Each series As Series In ChartControl.Series
                    CType(series.Label, RangeBarSeriesLabel).Indent = CInt(spinEditLabelIndent.Value)
                Next
            End If
        End Sub

        Private Sub comboBoxEditTotalLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim xyDiagram As XYDiagram = TryCast(ChartControl.Diagram, XYDiagram)
            If xyDiagram IsNot Nothing Then
                Dim label As StackedBarTotalLabel = xyDiagram.DefaultPane.StackedBarTotalLabel
                label.Visible = comboBoxEditTotalLabelVisible.Checked
            End If
        End Sub

        Private Sub chartStackedBarSideBySide_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChartControl Is Nothing Then Return
            Dim labelVisibility As DefaultBoolean = If(checkEditLabelVisible.Checked, DefaultBoolean.True, DefaultBoolean.False)
            ApplyStackedGroup(ChartControl.Series, labelVisibility, comboBoxEditGroupSeriesBy.SelectedIndex, False)
        End Sub

        Private Sub chartFullStackedBarSideBySide_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChartControl Is Nothing Then Return
            Dim labelVisibility As DefaultBoolean = If(checkEditLabelVisible.Checked, DefaultBoolean.True, DefaultBoolean.False)
            ApplyStackedGroup(ChartControl.Series, labelVisibility, comboBoxEditGroupSeriesBy.SelectedIndex, True)
        End Sub

        Private Sub OnRangeBarCustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
            If e.CrosshairElementGroups.Count > 0 AndAlso e.CrosshairElementGroups(0).CrosshairElements.Count > 0 Then
                Dim chi As ChartHitInfo = ChartControl.CalcHitInfo(ChartControl.PointToClient(MousePosition))
                If chi.InSeries Then
                    For Each element As CrosshairElement In e.CrosshairElementGroups(0).CrosshairElements
                        element.Visible = chi.Series.Equals(element.Series)
                    Next
                Else
                    For Each element As CrosshairElement In e.CrosshairElementGroups(0).CrosshairElements
                        element.Visible = False
                    Next
                End If
            End If
        End Sub

        Private Function IsBottomOrTopInsidePosition(ByVal position As BarSeriesLabelPosition) As Boolean
            Return position.Equals(BarSeriesLabelPosition.TopInside) OrElse position.Equals(BarSeriesLabelPosition.BottomInside)
        End Function

        Private Sub UpdateGroupByOption()
            If IsSideBySideStackedSeriesActive Then
                layoutControlItemGroupSeriesBy.Visibility = LayoutVisibility.Always
                If TypeOf ActiveSeries.Tag Is GenderAgeInfo Then
                    Dim genderAge As GenderAgeInfo = CType(ActiveSeries.Tag, GenderAgeInfo)
                    comboBoxEditGroupSeriesBy.SelectedIndex = If(Equals(CType(ActiveSeries.View, ISupportStackedGroup).StackedGroup.ToString(), genderAge.Age), 1, 0)
                End If
            Else
                layoutControlItemGroupSeriesBy.Visibility = LayoutVisibility.Never
            End If
        End Sub

        Private Sub UpdateTotalLabelAndRotatedOptions()
            Dim xyDiagram As XYDiagram = TryCast(ChartControl.Diagram, XYDiagram)
            If xyDiagram IsNot Nothing Then
                checkEditDiagramRotated.Checked = xyDiagram.Rotated
                If IsStackedOrFullStackedSeriesActive Then
                    layoutControlGroupTotalLabels.Visibility = LayoutVisibility.Always
                    Dim totalLabel As StackedBarTotalLabel = xyDiagram.DefaultPane.StackedBarTotalLabel
                    comboBoxEditTotalLabelVisible.Checked = totalLabel.Visible
                Else
                    layoutControlGroupTotalLabels.Visibility = LayoutVisibility.Never
                End If
            End If
        End Sub

        Private Sub UpdateLabelOptions()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility.Equals(DefaultBoolean.True)
            If IsRangeBarSeriesActive Then
                layoutControlItemOrientation.Visibility = LayoutVisibility.Never
                layoutControlItemPosition.Visibility = LayoutVisibility.Never
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never
                layoutControlItemRangeBarLabelPosition.Visibility = LayoutVisibility.Always
                Dim rangeBarLabel As RangeBarSeriesLabel = CType(ActiveSeries.Label, RangeBarSeriesLabel)
                comboBoxEditRangeBarLabelPosition.SelectedIndex = CInt(rangeBarLabel.Position)
                UpdateRangeBarLabelIndent(rangeBarLabel)
            Else
                Dim label As BarSeriesLabel = TryCast(ActiveSeries.Label, BarSeriesLabel)
                If label IsNot Nothing Then
                    layoutControlItemOrientation.Visibility = LayoutVisibility.Always
                    layoutControlItemPosition.Visibility = LayoutVisibility.Always
                    layoutControlItemRangeBarLabelPosition.Visibility = LayoutVisibility.Never
                    layoutControlItemValueAsPercent.Visibility = If(IsFullStackedSeriesActive, LayoutVisibility.Always, LayoutVisibility.Never)
                    comboBoxEditLabelPosition.Properties.Items.Clear()
                    Dim items As List(Of BarLabelPositionItem) = If(IsSideBySideBarSeriesActive, BarLabelPositionItem.AllPositions, BarLabelPositionItem.StackedPositions)
                    comboBoxEditLabelPosition.Properties.Items.AddRange(items)
                    comboBoxEditLabelPosition.SelectedItem = BarLabelPositionItem.GetItemByPosition(label.Position)
                    UpdateLabelIndent(label)
                    comboBoxEditLabelOrientation.SelectedIndex = CInt(label.TextOrientation)
                    checkEditValueAsPercent.Checked = Equals(label.TextPattern, PercentPattern)
                End If
            End If
        End Sub

        Private Sub UpdateLabelIndent(ByVal label As BarSeriesLabel)
            Dim isBottomOrTopInsidePosition As Boolean = Me.IsBottomOrTopInsidePosition(label.Position)
            layoutControlItemIndent.Enabled = isBottomOrTopInsidePosition AndAlso checkEditLabelVisible.Checked
            If isBottomOrTopInsidePosition Then spinEditLabelIndent.Value = label.Indent
        End Sub

        Private Sub UpdateRangeBarLabelIndent(ByVal rangeBarSeriesLabel As RangeBarSeriesLabel)
            Dim isCenterPosition As Boolean = rangeBarSeriesLabel.Position.Equals(RangeBarLabelPosition.Center)
            layoutControlItemIndent.Enabled = Not isCenterPosition AndAlso checkEditLabelVisible.Checked
            If Not isCenterPosition Then spinEditLabelIndent.Value = rangeBarSeriesLabel.Indent
        End Sub

        Protected Overrides Sub SetDataSources()
            chartBar.DataSource = DevAV.GetSales()
            chartStackedBar.DataSource = AgeStructureDataReader.GetDataByMaleAge()
            chartFullStackedBar.DataSource = DevAV.GetSalesMixByRegion()
            chartFullStackedBarSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender()
            chartStackedBarSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender()
            chartRangeBar.Series(0).DataSource = SourceOfEnergy.GetEuropeBrentPrices()
            chartRangeBar.Series(1).DataSource = SourceOfEnergy.GetOkWtiPrices()
            chartRangeBarSideBySide.Series(0).DataSource = SourceOfEnergy.GetEuropeBrentPrices()
            chartRangeBarSideBySide.Series(1).DataSource = SourceOfEnergy.GetOkWtiPrices()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentBar)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            UpdateGroupByOption()
            UpdateTotalLabelAndRotatedOptions()
            UpdateLabelOptions()
            sidePanelOptions.Visible = True
        End Sub
    End Class

    Friend Class BarLabelPositionItem

        Private _Position As BarSeriesLabelPosition, _Name As String

        Private Shared ReadOnly topInsidePositionList As BarLabelPositionItem = New BarLabelPositionItem(BarSeriesLabelPosition.TopInside, "Top Inside")

        Private Shared ReadOnly centerPositionList As BarLabelPositionItem = New BarLabelPositionItem(BarSeriesLabelPosition.Center, "Center")

        Private Shared ReadOnly bottomInsidePositionList As BarLabelPositionItem = New BarLabelPositionItem(BarSeriesLabelPosition.BottomInside, "Bottom Inside")

        Private Shared ReadOnly stackedPositionsList As List(Of BarLabelPositionItem) = New List(Of BarLabelPositionItem)() From {topInsidePositionList, centerPositionList, bottomInsidePositionList}

        Private Shared ReadOnly allPositionsList As List(Of BarLabelPositionItem) = New List(Of BarLabelPositionItem)() From {New BarLabelPositionItem(BarSeriesLabelPosition.Auto, "Auto"), New BarLabelPositionItem(BarSeriesLabelPosition.Top, "Top"), topInsidePositionList, centerPositionList, bottomInsidePositionList}

        Public Shared ReadOnly Property StackedPositions As List(Of BarLabelPositionItem)
            Get
                Return stackedPositionsList
            End Get
        End Property

        Public Shared ReadOnly Property AllPositions As List(Of BarLabelPositionItem)
            Get
                Return allPositionsList
            End Get
        End Property

        Public Shared Function GetItemByPosition(ByVal position As BarSeriesLabelPosition) As BarLabelPositionItem
            For Each item As BarLabelPositionItem In AllPositions
                If item.Position.Equals(position) Then Return item
            Next

            Return Nothing
        End Function

        Public Property Position As BarSeriesLabelPosition
            Get
                Return _Position
            End Get

            Private Set(ByVal value As BarSeriesLabelPosition)
                _Position = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _Name
            End Get

            Private Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Sub New(ByVal labelPosition As BarSeriesLabelPosition, ByVal labelName As String)
            Position = labelPosition
            Name = labelName
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Namespace

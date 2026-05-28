Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class Bar3DViewsDemo
        Inherits ChartDemoModule3DViews

        Const DefaultBar3DModel As String = "Box"

        Private ReadOnly Property IsSideBySideStackSeriesActive As Boolean
            Get
                Dim view As SeriesViewBase = ActiveSeries.View
                Return TypeOf view Is SideBySideStackedBar3DSeriesView OrElse TypeOf view Is SideBySideFullStackedBar3DSeriesView
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
                Return New List(Of ChartControl)() From {chartBar3D, chartManhattanBar3D, chartStackedBar3D, chartStackedBar3DSideBySide, chartFullStackedBar3D, chartFullStackedBar3DSideBySide}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            OnDocumentActivated(e.Document)
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetLabelVisibility(layoutControlItemValueAsPercent)
        End Sub

        Private Sub checkEditShowFacet_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf ApplyShowFacet))
        End Sub

        Private Sub ApplyShowFacet(ByVal view As SeriesViewBase)
            Dim seriesView As Bar3DSeriesView = TryCast(view, Bar3DSeriesView)
            If seriesView IsNot Nothing Then seriesView.ShowFacet = checkEditShowFacet.Checked
        End Sub

        Private Sub comboBoxEdit3DModel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEdit3DModel.SelectedIndex = -1 Then Return
            ApplySettingsToSeriesView(New Action(Of SeriesViewBase)(AddressOf ApplyBarModel))
        End Sub

        Private Sub ApplyBarModel(ByVal view As SeriesViewBase)
            Dim barModel As Bar3DModel = CType(comboBoxEdit3DModel.SelectedIndex, Bar3DModel)
            Dim seriesView As Bar3DSeriesView = TryCast(view, Bar3DSeriesView)
            If seriesView IsNot Nothing Then seriesView.Model = barModel
            checkEditShowFacet.Enabled = IsFacetEnabled(barModel)
        End Sub

        Private Sub comboBoxEditGroupSeriesBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChartControl.RefreshData()
        End Sub

        Private Sub OnStackedSideBySideChartsBoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim labelVisibility As DefaultBoolean = If(checkEditLabelVisible.Checked, DefaultBoolean.True, DefaultBoolean.False)
            ApplyStackedGroup(ChartControl.Series, labelVisibility, comboBoxEditGroupSeriesBy.SelectedIndex, False)
        End Sub

        Private Sub UpdateGroupByOption()
            layoutControlGroupGroupSeriesBy.Visibility = LayoutVisibility.Always
            If TypeOf ActiveSeries.Tag Is GenderAgeInfo Then
                Dim genderAge As GenderAgeInfo = CType(ActiveSeries.Tag, GenderAgeInfo)
                comboBoxEditGroupSeriesBy.SelectedIndex = If(Equals(CType(ActiveSeries.View, ISupportStackedGroup).StackedGroup.ToString(), genderAge.Age), 1, 0)
            End If
        End Sub

        Private Sub UpdateLabelOptions()
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility = DefaultBoolean.True
            Dim fullStackedLabel As FullStackedBar3DSeriesLabel = TryCast(ActiveSeries.Label, FullStackedBar3DSeriesLabel)
            If fullStackedLabel IsNot Nothing Then
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Always
                checkEditValueAsPercent.Checked = Equals(fullStackedLabel.TextPattern, PercentPattern)
            Else
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never
            End If
        End Sub

        Private Sub UpdateBarModelFacetOption()
            layoutControlItem3DModel.Visibility = LayoutVisibility.Always
            layoutControlItemShowFacet.Visibility = LayoutVisibility.Always
            Dim seriesView As Bar3DSeriesView = TryCast(ActiveSeries.View, Bar3DSeriesView)
            If seriesView IsNot Nothing Then
                checkEditShowFacet.Checked = seriesView.ShowFacet
                comboBoxEdit3DModel.SelectedIndex = CInt(seriesView.Model)
            End If
        End Sub

        Private Function IsFacetEnabled(ByVal barModel As Bar3DModel) As Boolean
            Return barModel.Equals(Bar3DModel.Box) OrElse barModel.Equals(Bar3DModel.Cylinder)
        End Function

        Protected Overrides Sub InitControls()
            MyBase.InitControls()
            Dim bar3DModelArray As String() = New String() {DefaultBar3DModel, "Cylinder", "Cone", "Pyramid"}
            comboBoxEdit3DModel.Properties.Items.AddRange(bar3DModelArray)
            comboBoxEdit3DModel.Text = DefaultBar3DModel
            AddHandler comboBoxEdit3DModel.SelectedIndexChanged, AddressOf comboBoxEdit3DModel_SelectedIndexChanged
        End Sub

        Protected Overrides Sub SetDataSources()
            chartBar3D.DataSource = DevAV.GetSales()
            chartManhattanBar3D.DataSource = DevAV.GetSales()
            chartStackedBar3D.DataSource = AgeStructureDataReader.GetDataByFemaleAge()
            chartStackedBar3DSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender()
            AddHandler chartStackedBar3DSideBySide.BoundDataChanged, AddressOf OnStackedSideBySideChartsBoundDataChanged
            chartFullStackedBar3D.DataSource = DevAV.GetSalesMixByRegion()
            chartFullStackedBar3DSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender()
            AddHandler chartFullStackedBar3DSideBySide.BoundDataChanged, AddressOf OnStackedSideBySideChartsBoundDataChanged
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentBar3D)
        End Sub

        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            If IsSideBySideStackSeriesActive Then
                UpdateGroupByOption()
            Else
                layoutControlGroupGroupSeriesBy.Visibility = LayoutVisibility.Never
            End If

            UpdateLabelOptions()
            If Not IsSideBySideStackSeriesActive Then
                UpdateBarModelFacetOption()
            Else
                layoutControlItem3DModel.Visibility = LayoutVisibility.Never
                layoutControlItemShowFacet.Visibility = LayoutVisibility.Never
            End If
        End Sub
    End Class
End Namespace

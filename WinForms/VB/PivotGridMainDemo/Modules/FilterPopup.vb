Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class FilterPopup
        Inherits TutorialControl

        Private filterPopupHelper As FilterPopupHelper

        Private popupTimer As Timer

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            CreatePopupHelper()
            SetCheckBoxesVisibility()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return filterPopupHelper.ActivePivot
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return filterPopupHelper.ActivePivot
            End Get
        End Property

        Private Sub FilterPopup_Load(ByVal sender As Object, ByVal e As EventArgs)
            fieldProductName.DropDownFilterListSize = New Size(170, 240)
            pivotFilter.OptionsFilterPopup.ShowOnlyAvailableItems = True
            InitializePopupHelper()
            ApplyFilter()
        End Sub

        Private Sub FilterPopup_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Visible Then
                StartPopupTimer()
            Else
                StopPopupTimer()
            End If
        End Sub

        Private Sub CreatePopupHelper()
            filterPopupHelper = New FilterPopupHelper(pivotFilter, fieldProductName, pivotGroupFilter, fieldGroupYear)
        End Sub

        Private Sub InitializePopupHelper()
            filterPopupHelper.Init(GetNWindData("SalesPerson"))
        End Sub

        Private Sub ApplyFilter()
            ' Field Filter
            fieldCategoryName.FilterValues.ValuesIncluded = New Object() {"Beverages"}
            fieldProductName.FilterValues.ValuesIncluded = New Object() {"Chai", "Chang", "Vegie-spread"}
            fieldYear.FilterValues.ValuesIncluded = New Object() {2015}
            ' Group Filter
            Dim group As PivotGridGroup = fieldGroupYear.Group
            group.FilterValues.BeginUpdate()
            group.FilterValues.FilterType = PivotFilterType.Included
            group.FilterValues.Values.Add(2014).ChildValues.Add(3)
            group.FilterValues.Values(2014).ChildValues(3).ChildValues.Add(9)
            group.FilterValues.Values.Add(2015).ChildValues.Add(1)
            group.FilterValues.Values(2015).ChildValues.Add(4)
            group.FilterValues.EndUpdate()
        End Sub

        Private Sub OnPopupTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            StopPopupTimer()
            filterPopupHelper.ShowFilterPopup()
        End Sub

        Private Sub StartPopupTimer()
            StopPopupTimer()
            popupTimer = New Timer()
            popupTimer.Interval = 500
            AddHandler popupTimer.Tick, New EventHandler(AddressOf OnPopupTimerTick)
            popupTimer.Start()
        End Sub

        Private Sub StopPopupTimer()
            If popupTimer Is Nothing Then Return
            popupTimer.Stop()
            popupTimer.Dispose()
        End Sub

        '<chkAllowContextMenu>
        Private Sub allowContextMenu_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetAllowContextMenu(chkAllowContextMenu.Checked)
            filterPopupHelper.ShowFilterPopup()
        End Sub

        '</chkAllowContextMenu>
        '<chkAllowTree>
        Private Sub chkAllowTree_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetAllowTree(chkAllowTree.Checked)
            filterPopupHelper.ShowFilterPopup()
        End Sub

        '</chkAllowTree>
        Private Sub SetCheckBoxesVisibility()
            Dim isGroupFilter As Boolean = tcFilter.SelectedTabPageIndex <> 0
            lciAllowContextMenu.Visibility = If(isGroupFilter, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
            lciAllowTree.Visibility = If(isGroupFilter, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
            lciShowOnlyAvailable.Visibility = If(Not isGroupFilter, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
        End Sub

        Private Sub tcFilter_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraTab.TabPageChangedEventArgs)
            filterPopupHelper.ChangeActivePivot()
            SetCheckBoxesVisibility()
            StartPopupTimer()
        End Sub

        '<chkShowToolbar>
        Private Sub chkShowToolbar_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetToolbarVisibility(chkShowToolbar.Checked)
            StartPopupTimer()
        End Sub

        '</chkShowToolbar>
        '<chkShowOnlyAvailableItems>
        Private Sub chkShowOnlyAvailableItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.ShowOnlyAvailableItems, chkShowOnlyAvailableItems.Checked)
            StartPopupTimer()
        End Sub

        '</chkShowOnlyAvailableItems>
        '<chkShowNewValues>
        Private Sub chkFilterTypeExcluded_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.ShowNewValues, chkShowNewValues.Checked)
            StartPopupTimer()
        End Sub

        '</chkShowNewValues>
        '<chkIncrementalSearch>
        Private Sub chkIncrementalSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.IncrementalSearch, chkIncrementalSearch.Checked)
            StartPopupTimer()
        End Sub

        '</chkIncrementalSearch>
        '<chkMultiSelection>
        Private Sub chkMultiSelection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.MultiSelection, chkMultiSelection.Checked)
            StartPopupTimer()
        End Sub

        '</chkMultiSelection>
        '<chkRadioMode>
        Private Sub chkRadioMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.RadioMode, chkRadioMode.Checked)
            StartPopupTimer()
        End Sub

        '</chkRadioMode>
        '<chkInvertFilter>
        Private Sub chkInvertFilter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.InvertFilter, chkInvertFilter.Checked)
            StartPopupTimer()
        End Sub
    '</chkInvertFilter>
    End Class

    Public Class FilterPopupHelper

        Private fieldFilterRec, groupFilterRec, activeRec As FilterRec

        Public Sub New(ByVal pivotFieldFilter As PivotGridControl, ByVal fieldFilter As PivotGridField, ByVal pivotGroupFilter As PivotGridControl, ByVal fieldGroupFilter As PivotGridField)
            fieldFilterRec.Pivot = pivotFieldFilter
            fieldFilterRec.Field = fieldFilter
            groupFilterRec.Pivot = pivotGroupFilter
            groupFilterRec.Field = fieldGroupFilter
            activeRec = fieldFilterRec
        End Sub

        Public Sub Init(ByVal dataView As DataView)
            fieldFilterRec.Pivot.DataSource = dataView
            groupFilterRec.Pivot.DataSource = dataView
        End Sub

        Public Sub ChangeActivePivot()
            activeRec = If(activeRec.Pivot Is fieldFilterRec.Pivot, groupFilterRec, fieldFilterRec)
        End Sub

        Public Sub ShowFilterPopup()
            ActiveField.ShowFilterPopup()
        End Sub

        '<chkAllowContextMenu>
        Public Sub SetAllowContextMenu(ByVal allowContextMenu As Boolean)
            fieldFilterRec.Pivot.OptionsFilterPopup.AllowContextMenu = allowContextMenu
            groupFilterRec.Pivot.OptionsFilterPopup.AllowContextMenu = allowContextMenu
        End Sub

        '</chkAllowContextMenu>
        '<chkAllowTree>
        Public Sub SetAllowTree(ByVal allowTree As Boolean)
            groupFilterRec.Pivot.OptionsFilterPopup.GroupFilterMode = If(allowTree, PivotGroupFilterMode.Tree, PivotGroupFilterMode.List)
        End Sub

        '</chkAllowTree>
        '<chkShowToolbar>
        Public Sub SetToolbarVisibility(ByVal showToolbar As Boolean)
            fieldFilterRec.Pivot.OptionsFilterPopup.ShowToolbar = showToolbar
            groupFilterRec.Pivot.OptionsFilterPopup.ShowToolbar = showToolbar
        End Sub

        '</chkShowToolbar>
        '<chkShowOnlyAvailableItems>
        '<chkIncrementalSearch>
        '<chkRadioMode>
        '<chkShowNewValues>
        '<chkMultiSelection>
        '<chkInvertFilter>
        Public Sub SetFilterPopupButtonsVisibility(ByVal button As FilterPopupToolbarButtons, ByVal include As Boolean)
            If include Then
                fieldFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons = fieldFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons Or button
                groupFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons = groupFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons Or button
            Else
                fieldFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons = fieldFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons And Not button
                groupFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons = groupFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons And Not button
            End If
        End Sub

        '</chkInvertFilter>
        '</chkMultiSelection>
        '</chkShowNewValues>
        '</chkRadioMode>
        '</chkIncrementalSearch>
        '</chkShowOnlyAvailableItems>
        Public ReadOnly Property ActivePivot As PivotGridControl
            Get
                Return activeRec.Pivot
            End Get
        End Property

        Public ReadOnly Property ActiveField As PivotGridField
            Get
                Return activeRec.Field
            End Get
        End Property

        Friend Structure FilterRec

            Public Pivot As PivotGridControl

            Public Field As PivotGridField
        End Structure
    End Class
End Namespace

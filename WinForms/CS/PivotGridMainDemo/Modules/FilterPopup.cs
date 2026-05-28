using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class FilterPopup : TutorialControl {
        FilterPopupHelper filterPopupHelper;
        Timer popupTimer;
                
        public FilterPopup() {
            CreateWaitDialog();
            InitializeComponent();

            CreatePopupHelper();
            SetCheckBoxesVisibility();
        }
        public override PivotGridControl ViewOptionsControl { get { return filterPopupHelper.ActivePivot; } }
        public override PivotGridControl ExportControl { get { return filterPopupHelper.ActivePivot; } }
               
        void FilterPopup_Load(object sender, EventArgs e) {
            fieldProductName.DropDownFilterListSize = new Size(170, 240);
            pivotFilter.OptionsFilterPopup.ShowOnlyAvailableItems = true;
            InitializePopupHelper();
            ApplyFilter();
        }
        void FilterPopup_VisibleChanged(object sender, System.EventArgs e) {
            if(Visible)
                StartPopupTimer();
            else
                StopPopupTimer();
        }
        void CreatePopupHelper() {
            filterPopupHelper = new FilterPopupHelper(pivotFilter, fieldProductName, pivotGroupFilter, fieldGroupYear);
        }
        void InitializePopupHelper() {
            filterPopupHelper.Init(GetNWindData("SalesPerson"));
        }
        void ApplyFilter() {
            // Field Filter
            this.fieldCategoryName.FilterValues.ValuesIncluded = new object[] { "Beverages" };
            this.fieldProductName.FilterValues.ValuesIncluded = new object[] { "Chai", "Chang", "Vegie-spread" };
            this.fieldYear.FilterValues.ValuesIncluded = new object[] { 2015 };
            // Group Filter
            PivotGridGroup group = this.fieldGroupYear.Group;
            group.FilterValues.BeginUpdate();
            group.FilterValues.FilterType = PivotFilterType.Included;
            group.FilterValues.Values.Add(2014).ChildValues.Add(3);
            group.FilterValues.Values[2014].ChildValues[3].ChildValues.Add(9);
            group.FilterValues.Values.Add(2015).ChildValues.Add(1);
            group.FilterValues.Values[2015].ChildValues.Add(4);
            group.FilterValues.EndUpdate();
        }
        void OnPopupTimerTick(object sender, EventArgs e) {
            StopPopupTimer();
            filterPopupHelper.ShowFilterPopup();
        }
        void StartPopupTimer() {
            StopPopupTimer();
            popupTimer = new Timer();
            popupTimer.Interval = 500;
            popupTimer.Tick += new EventHandler(OnPopupTimerTick);
            popupTimer.Start();
        }
        void StopPopupTimer() {
            if(popupTimer == null)
                return;
            popupTimer.Stop();
            popupTimer.Dispose();
        }
        //<chkAllowContextMenu>
        void allowContextMenu_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetAllowContextMenu(chkAllowContextMenu.Checked);
            filterPopupHelper.ShowFilterPopup();
        }
        //</chkAllowContextMenu>
        //<chkAllowTree>
        void chkAllowTree_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetAllowTree(chkAllowTree.Checked);
            filterPopupHelper.ShowFilterPopup();
        }
        //</chkAllowTree>
        void SetCheckBoxesVisibility() {
            bool isGroupFilter = tcFilter.SelectedTabPageIndex != 0;
            lciAllowContextMenu.Visibility = isGroupFilter ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
            lciAllowTree.Visibility = isGroupFilter ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
            lciShowOnlyAvailable.Visibility = !isGroupFilter ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
        }
        void tcFilter_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            filterPopupHelper.ChangeActivePivot();
            SetCheckBoxesVisibility();
            StartPopupTimer();
        }
        //<chkShowToolbar>
        void chkShowToolbar_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetToolbarVisibility(chkShowToolbar.Checked);
            StartPopupTimer();
        }
        //</chkShowToolbar>
        //<chkShowOnlyAvailableItems>
        void chkShowOnlyAvailableItems_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.ShowOnlyAvailableItems, chkShowOnlyAvailableItems.Checked);
            StartPopupTimer();
        }
        //</chkShowOnlyAvailableItems>
        //<chkShowNewValues>
        void chkFilterTypeExcluded_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.ShowNewValues, chkShowNewValues.Checked);
            StartPopupTimer();
        }
        //</chkShowNewValues>
        //<chkIncrementalSearch>
        void chkIncrementalSearch_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.IncrementalSearch, chkIncrementalSearch.Checked);
            StartPopupTimer();
        }
        //</chkIncrementalSearch>
        //<chkMultiSelection>
        void chkMultiSelection_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.MultiSelection, chkMultiSelection.Checked);
            StartPopupTimer();
        }
        //</chkMultiSelection>
        //<chkRadioMode>
        void chkRadioMode_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.RadioMode, chkRadioMode.Checked);
            StartPopupTimer();
        }
        //</chkRadioMode>
        //<chkInvertFilter>
        void chkInvertFilter_CheckedChanged(object sender, EventArgs e) {
            filterPopupHelper.SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons.InvertFilter, chkInvertFilter.Checked);
            StartPopupTimer();
        }
        //</chkInvertFilter>
    }

    public class FilterPopupHelper {
        FilterRec fieldFilterRec, groupFilterRec, activeRec;
        public FilterPopupHelper(PivotGridControl pivotFieldFilter, PivotGridField fieldFilter,
                        PivotGridControl pivotGroupFilter, PivotGridField fieldGroupFilter) {
            this.fieldFilterRec.Pivot = pivotFieldFilter;
            this.fieldFilterRec.Field = fieldFilter;

            this.groupFilterRec.Pivot = pivotGroupFilter;
            this.groupFilterRec.Field = fieldGroupFilter;

            this.activeRec = this.fieldFilterRec;
        }
        public void Init(DataView dataView) {
            this.fieldFilterRec.Pivot.DataSource = dataView;
            this.groupFilterRec.Pivot.DataSource = dataView;
        }
        public void ChangeActivePivot() {
            activeRec = activeRec.Pivot == fieldFilterRec.Pivot ? groupFilterRec : fieldFilterRec;
        }
        public void ShowFilterPopup() {
            ActiveField.ShowFilterPopup();
        }
        //<chkAllowContextMenu>
        public void SetAllowContextMenu(bool allowContextMenu) {
            fieldFilterRec.Pivot.OptionsFilterPopup.AllowContextMenu = allowContextMenu;
            groupFilterRec.Pivot.OptionsFilterPopup.AllowContextMenu = allowContextMenu;
        }
        //</chkAllowContextMenu>
        //<chkAllowTree>
        public void SetAllowTree(bool allowTree) {
            groupFilterRec.Pivot.OptionsFilterPopup.GroupFilterMode = allowTree ? PivotGroupFilterMode.Tree : PivotGroupFilterMode.List;
        }
        //</chkAllowTree>
        //<chkShowToolbar>
        public void SetToolbarVisibility(bool showToolbar) {
            fieldFilterRec.Pivot.OptionsFilterPopup.ShowToolbar = showToolbar;
            groupFilterRec.Pivot.OptionsFilterPopup.ShowToolbar = showToolbar;
        }
        //</chkShowToolbar>
        //<chkShowOnlyAvailableItems>
        //<chkIncrementalSearch>
        //<chkRadioMode>
        //<chkShowNewValues>
        //<chkMultiSelection>
        //<chkInvertFilter>
        public void SetFilterPopupButtonsVisibility(FilterPopupToolbarButtons button, bool include) {
            if(include) {
                fieldFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons |= button;
                groupFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons |= button;
            } else {
                fieldFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons &= ~button;
                groupFilterRec.Pivot.OptionsFilterPopup.ToolbarButtons &= ~button;
            }
        }
        //</chkInvertFilter>
        //</chkMultiSelection>
        //</chkShowNewValues>
        //</chkRadioMode>
        //</chkIncrementalSearch>
        //</chkShowOnlyAvailableItems>
        public PivotGridControl ActivePivot { get { return activeRec.Pivot; } }
        public PivotGridField ActiveField { get { return activeRec.Field; } }
        struct FilterRec {
            public PivotGridControl Pivot;
            public PivotGridField Field;
        }
    }
}

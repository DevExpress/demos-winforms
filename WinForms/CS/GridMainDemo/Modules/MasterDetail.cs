using System;
using System.Data;
using System.Drawing;
using DevExpress.ActiveDemos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for MasterDetail.
    /// </summary>
    public partial class MasterDetail : TutorialControl {
        public MasterDetail() {
            CreateWaitDialog();
            InitializeComponent();
            gridControl1.ForceInitialize();
            InitNWindData();
            InitEditing();
            InitMasterDetailDemo();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "MasterDetail" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "MasterDetail"; }
        }
        #region Init
        GridView MainView {
            get { return advBandedGridView1; }
        }
        GridView ProductView {
            get { return gridView1; }
        }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            dsNWindSupplier1.ReadXml(dataFileName, XmlReadMode.InferSchema);
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1);
            return dsNWindSupplier1;
        }
        void InitMasterDetailDemo() {
            MainView.BeginUpdate();
            MainView.FocusedRowHandle = 0;
            MainView.SetMasterRowExpanded(MainView.FocusedRowHandle, true);
            GridView gv = MainView.GetVisibleDetailView(MainView.FocusedRowHandle) as GridView;
            if(gv != null) gv.SetMasterRowExpanded(0, true);
            MainView.SetMasterRowExpandedEx(1, 1, true);
            seVertIndent.Value = 4;
            MainView.EndUpdate();
            //<ceAllowFindInExpandedDetails>
            ProductView.OptionsFind.AllowFindInExpandedDetails = DefaultBoolean.False;
            //</ceAllowFindInExpandedDetails>
        }
        void InitEditing() {
            InitCheckButtons();
            SetZoom(imageComboBoxEdit1.SelectedIndex);
        }
        void InitCheckButtons() {
            icbDetailMode.Properties.Items.Add(DetailMode.Classic.ToString(), DetailMode.Classic, -1);
            icbDetailMode.Properties.Items.Add(DetailMode.Embedded.ToString(), DetailMode.Embedded, -1);
            icbDetailMode.EditValue = MainView.OptionsDetail.DetailMode;
            ceAllowFindInExpandedDetails.EditValue = MainView.OptionsFind.AllowFindInExpandedDetails == DefaultBoolean.False;
            ceShowEmbeddedDetailIndent.Checked = MainView.OptionsDetail.ShowEmbeddedDetailIndent != DefaultBoolean.False;
            ceTabs.Checked = MainView.OptionsDetail.ShowDetailTabs;
            ceToolTips.Checked = MainView.OptionsDetail.EnableDetailToolTip;
            ceMain.IsOn = MainView.OptionsDetail.EnableMasterViewMode;
        }
        //<ceDetailTabStyle>
        void advBandedGridView1_DetailTabStyle(object sender, DetailTabStyleEventArgs e) {
            if(ceDetailTabStyle.Checked) {
                if(e.Caption == "Products") {
                    e.ImageOptions.SvgImage = svgImageCollection1["product"];
                }
                if(e.Caption == "Category") {
                    e.Appearance.Header.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
                    e.ImageOptions.SvgImage = svgImageCollection1["category"];
                }
                if(e.IsSelected) {
                    e.Appearance.Header.FontStyleDelta = FontStyle.Underline;
                }
            }
        }
        //</ceDetailTabStyle>
        #endregion
        #region Editing
        //<imageComboBoxEdit1>
        void SetZoom(bool allow, bool auto) {
            MainView.OptionsDetail.AllowZoomDetail = allow;
            MainView.OptionsDetail.AutoZoomDetail = auto;
            ProductView.OptionsDetail.AllowZoomDetail = allow;
            ProductView.OptionsDetail.AutoZoomDetail = auto;
        }
        void SetZoom(int index) {
            switch(index) {
                case 0: //"Auto Zoom"
                    SetZoom(true, true);
                    break;
                case 1: //"Manual Zoom"
                    SetZoom(true, false);
                    break;
                case 2: //"No Zoom"
                    SetZoom(false, false);
                    break;
            }
            MainView.CollapseAllDetails();
        }
        void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            SetZoom(imageComboBoxEdit1.SelectedIndex);
        }
        //</imageComboBoxEdit1>
        //<ceAllowFindInExpandedDetails>
        void ceAllowFindInExpandedDetails_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            MainView.OptionsFind.AllowFindInExpandedDetails = ce.Checked ? DefaultBoolean.True : DefaultBoolean.Default;
            if(ce.Checked && !MainView.IsFindPanelVisible) {
                MainView.ShowFindPanel();
                MainView.FindFilterText = "cha";
            }
        }
        //</ceAllowFindInExpandedDetails>
        //<ceTabs>
        void ceTabs_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            MainView.OptionsDetail.ShowDetailTabs = ce.Checked;
            MainView.CollapseAllDetails();
            ProductView.BorderStyle = MainView.OptionsDetail.ShowDetailTabs ? BorderStyles.NoBorder : BorderStyles.Default;
        }
        //</ceTabs>
        //<ceToolTips>
        void ceToolTips_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            MainView.OptionsDetail.EnableDetailToolTip = ce.Checked;
        }
        //</ceToolTips>
        //<ceMain>
        void ceMain_CheckedChanged(object sender, EventArgs e) {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            MainView.OptionsDetail.EnableMasterViewMode = toggleSwitch.IsOn;
            MainView.OptionsView.ShowChildrenInGroupPanel = toggleSwitch.IsOn;
            //<skip>
            UpdateEnabledOptions();
            InitMasterDetailDemo();
            //</skip>
        }
        //</ceMain>
        void UpdateEnabledOptions() {
            icbDetailMode.Enabled = imageComboBoxEdit1.Enabled = ceTabs.Enabled = ceToolTips.Enabled = MainView.OptionsDetail.EnableMasterViewMode;
            ceShowEmbeddedDetailIndent.Enabled = MainView.OptionsDetail.DetailMode == DetailMode.Embedded && MainView.OptionsDetail.EnableMasterViewMode;
            seVertIndent.Enabled = ceMain.IsOn;
            lciDetailIndent.Enabled = lciZooming.Enabled = MainView.OptionsDetail.DetailMode != DetailMode.Embedded;
        }
        //<seVertIndent>
        void seVertIndent_EditValueChanged(object sender, EventArgs e) {
            foreach(DevExpress.XtraGrid.Views.Base.BaseView view in gridControl1.Views) {
                GridView gView = view as GridView;
                if(gView != null)
                    gView.DetailVerticalIndent = (int)seVertIndent.Value;
            }
        }
        //</seVertIndent>
        void icbDetailMode_SelectedIndexChanged(object sender, EventArgs e) {
            //<icbDetailMode>
            MainView.OptionsDetail.DetailMode = (DetailMode)icbDetailMode.EditValue;
            //</icbDetailMode>
            UpdateEnabledOptions();
            InitMasterDetailDemo();
            MainView.TopRowIndex = 0;
        }
        //<ceShowEmbeddedDetailIndent>
        void ceShowEmbeddedDetailIndent_CheckedChanged(object sender, EventArgs e) {
            MainView.OptionsDetail.ShowEmbeddedDetailIndent = ceShowEmbeddedDetailIndent.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowEmbeddedDetailIndent>
        void ceDetailTabStyle_CheckedChanged(object sender, EventArgs e) {
            MainView.CollapseAllDetails();
            InitMasterDetailDemo();
        }
        #endregion
        #region GenerateReport
        public override bool AllowGenerateReport {
            get { return false; }
        }
        public override Views.Base.BaseView ExportView {
            get { return advBandedGridView1; }
        }
        #endregion
        #region ActiveDemo
        public override bool HasActiveDemo {
            get { return true; }
        }
        protected override ActiveDemo CreateActiveDemo() {
            return new ActiveGridDemo(gridControl1);
        }
        protected override void RunGridActiveDemo(ActiveGridDemo activeDemo) {
            icbDetailMode.EditValue = DetailMode.Classic;
            this.advBandedGridView1.CollapseAllDetails();
            imageComboBoxEdit1.SelectedIndex = 1;
            ceTabs.Checked = true;
            ceMain.IsOn = true;

            activeDemo.ClickMasterRecordIcon(this.advBandedGridView1, 1);
            advBandedGridView1.TopRowIndex = 0;
            activeDemo.ClickMasterRecordIcon(this.advBandedGridView1, 0);
            GridView detailView = this.advBandedGridView1.GetVisibleDetailView(0) as GridView;
            activeDemo.ColumnBestFit(this.colCategoryID, detailView, Properties.Resources.ActiveGrid_BestFit);
            activeDemo.ColumnResize(this.colCategoryID, detailView, 100);
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_SynhronizedViews);
            activeDemo.ViewZoom(detailView, Properties.Resources.ActiveGrid_ViewZoom);
            activeDemo.ClickMasterRecordIcon(detailView, 1);
            activeDemo.ClickMasterRecordIcon(detailView, 0);
            if(activeDemo.Actions.Canceled) return;
            if(detailView == null) return;
            GridView subDetailView = detailView.GetVisibleDetailView(0) as GridView;
            ActiveActions.Delay(500);
            activeDemo.ViewZoom(subDetailView, Properties.Resources.ActiveGrid_ViewZoomSubDetail);
            if(activeDemo.Actions.Canceled) return;
            ActiveActions.Delay(500);
            activeDemo.ExpandCollapseRow(subDetailView, 1);
            activeDemo.MoveMouseFromPoint(200, 100);
            activeDemo.ExpandCollapseRow(subDetailView, 0);
            activeDemo.MoveMouseFromPoint(100, 200);
            activeDemo.ViewZoom(subDetailView, Properties.Resources.ActiveGrid_ViewUnzoom);
            activeDemo.MoveMouseFromPoint(200, 200);
            activeDemo.ViewZoom(detailView);
            if(activeDemo.Actions.Canceled) return;
            subDetailView.OptionsView.ShowGroupPanel = true;
            Rectangle r = activeDemo.GetGroupPanelRectangle(subDetailView);
            activeDemo.Actions.MoveMousePointTo(gridControl1, new Point(r.X + 50, r.Top + r.Height / 2));
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_JoinedGroupPanel);
            r = activeDemo.GetGroupPanelRectangle(this.advBandedGridView1);
            activeDemo.Actions.MoveMousePointTo(gridControl1, new Point(r.X + 50, r.Top + r.Height / 2));
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_JoinedGroupPanel2);
            if(activeDemo.Actions.Canceled) return;
            subDetailView.OptionsView.ShowGroupPanel = false;
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Prev);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Prev);
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_EmbeddedNavigator);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next);
        }
        #endregion
    }
}

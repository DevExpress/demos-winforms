using System;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraPivotGrid.Demos.Helpers;
using DevExpress.Utils.Menu;
using DevExpress.XtraPivotGrid.Localization;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.Utils.DPI;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class OLAP : DevExpress.XtraPivotGrid.Demos.TutorialControl {

        protected override bool HideCustFormWhenSwitchDemo {
            get { return false; }
        }
        public OLAP() {
            CreateWaitDialog();
            InitializeComponent();
        }
        OLAPConnectionHelper connectionHelper = new OLAPConnectionHelper();
        private void OLAP_Load(object sender, System.EventArgs e) {
            pivotGridControl.FieldsCustomization();
            if(ConnectToDefault())
                UpdateControls(true);
        }

        private bool ConnectToDefault() {
            bool success = OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, false);
            if(success)
                ConfigureLayout();
            panelError.Visible = !success;
            radioGroup1.Enabled = success;
            return success;
        }

        async void ConfigureLayout() {
            pivotGridControl.RetrieveFields(PivotArea.FilterArea, false);
            pivotGridControl.BeginUpdate();
            PivotGridField fieldFiscalYear = pivotGridControl.Fields["[Date].[Fiscal].[Fiscal Year]"];
            fieldFiscalYear.Area = PivotArea.ColumnArea;
            fieldFiscalYear.Visible = true;
            fieldFiscalYear.SortOrder = PivotSortOrder.Descending;
            PivotGridField fieldCategory = pivotGridControl.Fields["[Product].[Product Categories].[Category]"];
            fieldCategory.Area = PivotArea.RowArea;
            fieldCategory.Visible = true;
            PivotGridField fieldSalesAmount = pivotGridControl.Fields["[Measures].[Internet Sales Amount]"];
            fieldSalesAmount.Area = PivotArea.DataArea;
            fieldSalesAmount.Visible = true;
            fieldSalesAmount.Caption = "Sales";
            PivotGridField fieldRatio = pivotGridControl.Fields["[Measures].[Internet Ratio to All Products]"];
            fieldRatio.Area = PivotArea.DataArea;
            fieldRatio.Visible = true;
            fieldRatio.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldRatio.CellFormat.FormatString = "P";
            fieldRatio.Caption = "Ratio";
            PivotGridField fieldRevenueStatus = pivotGridControl.Fields["[Measures].[Internet Revenue Status]"];
            fieldRevenueStatus.Area = PivotArea.DataArea;
            fieldRevenueStatus.Visible = true;
            fieldRevenueStatus.Caption = "Status";
            PivotGridField fieldRevenueTrend = pivotGridControl.Fields["[Measures].[Internet Revenue Trend]"];
            fieldRevenueTrend.Area = PivotArea.DataArea;
            fieldRevenueTrend.Visible = true;
            fieldRevenueTrend.Caption = "Trend";
            await pivotGridControl.EndUpdateAsync();
            await fieldCategory.ExpandAllAsync();
            await pivotGridControl.ExpandValueAsync(true, new object[] { (short)2025 });
            await pivotGridControl.ExpandValueAsync(true, new object[] { (short)2025, "H1 FY 2025" });
            await pivotGridControl.ExpandValueAsync(true, new object[] { (short)2025, "H1 FY 2025", "Q1 FY 2025" });
            await pivotGridControl.ExpandValueAsync(true, new object[] { (short)2025, "H1 FY 2025", "Q1 FY 2025", "July 2025" });
            pivotGridControl.BestFitRowArea();
        }
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl; } }

        void pivotGridControl_FieldValueNotExpanded(object sender, PivotFieldValueEventArgs e) {
            XtraMessageBox.Show("Cannot show details for this item: it has no child items.", "OLAP Browser", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void pivotGridControl_ShowingCustomizationForm(object sender, CustomizationFormShowingEventArgs e) {
            e.ParentControl = sidePanel2;
            e.CustomizationForm.Dock = DockStyle.Fill;
            if(DpiAwarenessHelper.Default.IsPerMonitor()) {
                e.CustomizationForm.HandleCreated += (s, evArgs) => {
                    e.CustomizationForm.AutoScaleMode = AutoScaleMode.Inherit;
                };
            }
        }
        protected override void DoDpiChangeAfterParent() {
            base.DoDpiChangeAfterParent();
            sidePanel2.Width++;//Recalc docking control
            sidePanel2.Width--;
        }
        void pivotGridControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.MenuType == PivotGridMenuType.Header || e.MenuType == PivotGridMenuType.HeaderArea) {
                foreach(DXMenuItem item in e.Menu.Items) {
                    if(item.Caption == PivotGridLocalizer.GetString(PivotGridStringId.PopupMenuHideFieldList)) {
                        e.Menu.Items.Remove(item);
                        break;
                    }
                }
            }
        }
        void UpdateControls(bool configured) {
            cbeDatabase.Text = string.Empty;
            cbeCube.Text = string.Empty;
            bool isDefaultSample = radioGroup1.SelectedIndex == 0;
            if(isDefaultSample && !configured) {
                ConnectToDefault();
            }
            SetVisibility(!isDefaultSample);
        }

        void SetVisibility(bool val) {
            var visibility = val ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
            lciServer.Visibility = visibility;
            lciDataBase.Visibility = visibility;
            lciCube.Visibility = visibility;
            layoutControlItem6.Visibility = visibility;
        }

        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateControls(false);
        }       

        void sbConnect_Click(object sender, EventArgs e) {
            Connect();
        }

        private void Connect() {
            IOLAPConnectionInfo info = connectionHelper.GetOlapConnectionInfo(beServer.Text, cbeDatabase.Text, cbeCube.Text);
            if(info.IsError) {
                ProcessError(info);
            } else {
                pivotGridControl.Fields.Clear();
                string connectionString = ((OLAPConnectionStringInfo)info).ConnectionString;
                //<sbConnect>
                pivotGridControl.OLAPConnectionString = connectionString;
                //</sbConnect>
                if(radioGroup1.SelectedIndex == 2)
                    ConfigureLayout();
                else
                    OLAPConfigurator.RetrieveFields(pivotGridControl);
            }
        }

        void cbeDatabase_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e) {
            if(string.IsNullOrEmpty(beServer.Text)) {
                e.Cancel = true;
                return;
            }
            IOLAPConnectionInfo baseInfo = connectionHelper.GetCatalogList(beServer.Text);
            if(baseInfo == null) {
                e.Cancel = true;
                return;
            }
            if(baseInfo.IsError) {
                ProcessError(baseInfo);
                e.Cancel = true;
            } else {
                cbeDatabase.Properties.Items.Clear();
                cbeDatabase.Properties.Items.AddRange(((OLAPStringListConnectionInfo)baseInfo).StringList);
                e.Cancel = false;
            }
        }

        void cbeCube_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e) {
            if(string.IsNullOrEmpty(beServer.Text) || string.IsNullOrEmpty(cbeDatabase.Text)) {
                e.Cancel = true;
                return;
            }
            IOLAPConnectionInfo baseInfo = connectionHelper.GetCubeList(beServer.Text, cbeDatabase.Text);
            if(baseInfo.IsError) {
                ProcessError(baseInfo);
                e.Cancel = true;
            } else {
                cbeCube.Properties.Items.Clear();
                cbeCube.Properties.Items.AddRange(((OLAPStringListConnectionInfo)baseInfo).StringList);
                e.Cancel = false;
            }
        }

        void ProcessError(IOLAPConnectionInfo info) {
            OLAPConnectionInfoError error = (OLAPConnectionInfoError)info;
            Control control = error.Type == ConnectionErrorType.ServerName ? beServer
                                : error.Type == ConnectionErrorType.CatalogName ? cbeDatabase
                                : cbeCube;
            ShowBalloon(error.Message, control);
        }
        void ShowBalloon(string text, Control control) {
            ToolTipControllerShowEventArgs eShow = toolTipController1.CreateShowArgs();
            eShow.ToolTip = text;
            eShow.Title = "Error";
            eShow.IconType = ToolTipIconType.Error;
            eShow.IconSize = ToolTipIconSize.Small;
            toolTipController1.ShowHint(eShow, control);
        }
    }
}


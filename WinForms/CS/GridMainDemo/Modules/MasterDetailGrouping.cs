using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for MasterDetailGrouping.
    /// </summary>
    public partial class MasterDetailGrouping : TutorialControl {
        public MasterDetailGrouping() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            this.gridControl2.LevelTree.Nodes[0].RelationName = Properties.Resources.Orders;
            //<panelControl1>
            /* ~Specify the name of the child level whose grouping state is displayed in the joined group panel: */
            gridView1.ChildGridLevelName = Properties.Resources.Orders; /* ~Set ChildGridLevelName to "Orders" */
            //</panelControl1>
            InitNWindData();
            InitMasterDetailAppearance();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "MasterDetailGrouping" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "MasterDetailGrouping"; }
        }

        protected override PaintView[] PaintViews {
            get {
                return new PaintView[] {
										   new PaintView(gridView1, "Winter"), 
										   new PaintView(gridView2, "Spring")
									   };
            }
        }
        #region Init
        private void MasterDetailGrouping_Load(object sender, System.EventArgs e) {
            OnButtonChecked(chOwner);
        }
        private GridControl CurrentGrid { get { return gridControl2; } }
        private GridView CurrentView { get { return gridView1; } }
        //<panelControl1>
        string LevelName = Properties.Resources.Orders; /* ~Returns "Orders" */
        //</panelControl1>

        protected override DataSet InitNWindXMLData(string dataFileName) {
            SetWaitDialogCaption(Properties.Resources.LoadingCustomers);
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(dataFileName);

            LevelName = "CustomersOrders";
            this.gridControl2.LevelTree.Nodes[0].RelationName = LevelName;
            this.gridView1.ChildGridLevelName = LevelName;
            this.gridControl2.ShowOnlyPredefinedDetails = true;
            this.gridControl2.DataSource = dataSet.Tables["Customers"];
            return dataSet;
        }
        private void InitMasterDetailAppearance() {
            gridControl2.ForceInitialize();
            gridView1.BeginUpdate();
            gridView1.ExpandAllGroups();
            gridView1.FocusedRowHandle = 2;
            gridView1.SetMasterRowExpanded(gridView1.FocusedRowHandle, true);
            gridView1.EndUpdate();
        }
        #endregion
        #region Adjustment
        //<panelControl1>
        private void SetShowChildrenInGroupPanel(bool show) {
            CurrentView.BeginUpdate();
            CurrentView.OptionsView.ShowChildrenInGroupPanel = show;
            if(CurrentGrid.LevelTree.Nodes[LevelName] != null)
                ((GridView)CurrentGrid.LevelTree.Nodes[LevelName].LevelTemplate).OptionsView.ShowGroupPanel = !show;
            for(int i = 0; i < CurrentGrid.Views.Count; i++) {
                ((GridView)CurrentGrid.Views[i]).ExpandAllGroups();
            }
            CurrentView.EndUpdate();
        }
        //</panelControl1>

        #endregion
        #region Grid events
        private void gridControl2_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e) {
            ((DevExpress.XtraGrid.Views.Grid.GridView)e.View).ExpandAllGroups();
        }
        private void gridView_EndGrouping(object sender, System.EventArgs e) {
            GridView gv = sender as GridView;
            gv.ExpandAllGroups();
        }
        #endregion

        bool updateInfo = false;
        void ch_CheckedChanged(object sender, EventArgs e) {
            if(updateInfo) return;
            OnButtonChecked(sender as CheckButton);
        }
        void OnButtonChecked(CheckButton button) {
            if(button.Tag == null) return;
            updateInfo = true;
            chOwner.Checked = button == chOwner;
            chJoined.Checked = !chOwner.Checked;
            SetShowChildrenInGroupPanel(button == chJoined);
            CurrentGrid.Focus();
            updateInfo = false;
        }
    }
}

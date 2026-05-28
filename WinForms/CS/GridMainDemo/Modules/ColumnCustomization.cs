using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for ColumnCustomization.
    /// </summary>
    public partial class ColumnCustomization : TutorialControl {
        public ColumnCustomization() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            tmr.Tick += new EventHandler(tmr_Tick);
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        bool _show = false;
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return advBandedGridView1; } }
        private void ColumnCustomization_Load(object sender, System.EventArgs e) {
            InitVehiclesData();
            InitCustomization();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ColumnCustomization" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "ColumnCustomization"; }
        }

        Timer tmr = new Timer();
        protected override void DoShow() {
            base.DoShow();
            _show = true;
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e) {
            tmr.Stop();
            if(Visible)
                ShowColumnSelector();
        }
        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitXMLData(dataFileName, gridControl1);
            VehiclesData.InitColumnViewEditors(advBandedGridView1);
        }
        bool initData = false;
        private void InitCustomization() {
            initData = true;
            try {
                ccbSnapMode.Properties.SetFlags(typeof(DevExpress.Utils.Controls.SnapMode));
                for(int i = ccbSnapMode.Properties.Items.Count - 1; i >= 0; i--) {
                    if((int)ccbSnapMode.Properties.Items[i].Value < 0 || (int)ccbSnapMode.Properties.Items[i].Value > 8)
                        ccbSnapMode.Properties.Items.RemoveAt(i);
                }

                checkEdit1.Checked = advBandedGridView1.OptionsCustomization.AllowChangeColumnParent;
                checkEdit2.Checked = advBandedGridView1.OptionsCustomization.AllowChangeBandParent;
                checkEdit3.Checked = advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm;
                checkEdit4.Checked = advBandedGridView1.OptionsCustomization.CustomizationFormSearchBoxVisible;
                ccbSnapMode.EditValue = advBandedGridView1.OptionsCustomization.CustomizationFormSnapMode;
            } finally {
                initData = false;
            }
        }
        //<simpleButton1>
        private void simpleButton1_Click(object sender, System.EventArgs e) {
            _show = !_show;
            ShowColumnSelector();
        }
        
        private void ShowColumnSelector() { ShowColumnSelector(true); }
        private void ShowColumnSelector(bool showForm) {
            if(_show) {
                simpleButton1.Text = Properties.Resources.HideColumnsSelector;
                if(showForm) advBandedGridView1.ColumnsCustomization();
            }
            else {
                simpleButton1.Text = Properties.Resources.ShowColumnsSelector;
                if(showForm) advBandedGridView1.DestroyCustomization();
            }
        }
        //</simpleButton1>
        private void advBandedGridView1_ShowCustomizationForm(object sender, System.EventArgs e) {
            _show = true;
            ShowColumnSelector(false);
        }

        private void advBandedGridView1_HideCustomizationForm(object sender, System.EventArgs e) {
            _show = false;
            ShowColumnSelector(false);
        }
        //<checkEdit1>
        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit;
            advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = edit.Checked;
        }
        //</checkEdit1>
        //<checkEdit2>
        private void checkEdit2_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit;
            advBandedGridView1.OptionsCustomization.AllowChangeBandParent = edit.Checked;
        }
        //</checkEdit2>
        //<checkEdit3>
        private void checkEdit3_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit;
            advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = edit.Checked;
        }
        //</checkEdit3>
        private void checkEdit4_CheckedChanged(object sender, EventArgs e) {
            DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit;
            advBandedGridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = edit.Checked;
        }
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion

        private void ccbSnapMode_EditValueChanged(object sender, EventArgs e) {
            if(initData) return;
            DevExpress.XtraEditors.CheckedComboBoxEdit edit = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;
            if(!string.IsNullOrEmpty(edit.Text))
                advBandedGridView1.OptionsCustomization.CustomizationFormSnapMode = (DevExpress.Utils.Controls.SnapMode)edit.EditValue;
        }

        private void layoutControlItem6_CustomDraw(object sender, XtraLayout.ItemCustomDrawEventArgs e) {
            e.DefaultDraw();
            e.Cache.FillRectangle(Color.FromArgb(50, 127, 221, 134), e.Bounds);
            e.Handled = true;
        }
    }
}

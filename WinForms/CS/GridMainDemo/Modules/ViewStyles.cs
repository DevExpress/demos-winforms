using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using static DevExpress.XtraGrid.Demos.VehiclesData;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for ViewStyles.
    /// </summary>
    public partial class ViewStyles : TutorialControl {
        public ViewStyles() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            gridControl1.ForceInitialize();
            InitVehiclesData();
            rgViewType.SelectedIndex = 3;
            rgViewType.SelectedIndexChanged += OnSelectedIndexChanged;
            LicenseInfo.SetToolTipController(this, gridControl1);
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ViewStyles" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "ViewStyles"; }
        }
        #region Init

        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitXMLData(dataFileName, gridControl1);
            VehiclesData.InitColumnViewEditors(advBandedGridView1);
            VehiclesData.InitColumnViewEditors(bandedGridView1);
            VehiclesData.InitColumnViewEditors(gridView1);
            VehiclesData.InitColumnViewEditors(cardView1);
        }
        #endregion
        #region Change view
        public override BaseView ExportView { get { return gridControl1.MainView; } }
        public override bool AllowCellImagesExport { get { return true; } }
        //<rgViewType>
        private void ChangeView(string viewType) {
            switch(viewType) {
                case "GridView":
                    gridControl1.MainView = gridView1;
                    break;
                case "CardView":
                    gridControl1.MainView = cardView1;
                    break;
                case "Banded GridView":
                    gridControl1.MainView = bandedGridView1;
                    bandedGridView1.ExpandAllGroups();
                    break;
                case "Advanced Banded GridView":
                    gridControl1.MainView = advBandedGridView1;
                    break;
            }
        }
        //</rgViewType>
        #endregion
        #region GridView events
        private void gridView1_DragObjectOver(object sender, DevExpress.XtraGrid.Views.Base.DragObjectOverEventArgs e) {
            if(e.DragObject is GridColumn) {
                DevExpress.XtraGrid.Dragging.ColumnPositionInfo cpi = e.DropInfo as DevExpress.XtraGrid.Dragging.ColumnPositionInfo;
                if(e.DropInfo.Index == 0 && !cpi.InGroupPanel) e.DropInfo.Valid = false;
            }
        }
        #endregion

        bool updateInfo = false;
        //<rgViewType>
        void OnSelectedIndexChanged(object sender, EventArgs e) {
            if(updateInfo) return;
            updateInfo = true;
            string _caption = rgViewType.EditValue.ToString();
            ChangeView(_caption);
            updateInfo = false;
        }
        //</rgViewType>
        #region CardView events
        private void cardView1_CustomCardCaptionImage(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionImageEventArgs e) {
            VehiclesData.Model model = cardView1.GetRow(e.RowHandle) as VehiclesData.Model;
            e.Image = model.GetSmallTrademarkImage();
        }
        private void cardView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
            if(cardView1.FocusedColumn.FieldName == "Trademark")
                this.BeginInvoke(new MethodInvoker(delegate { cardView1.LayoutChanged(); }));
        }
        #endregion
    }
}

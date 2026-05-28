using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class GridEditForm : TutorialControl {
        RibbonPageGroup pgOptions = new RibbonPageGroup("Edit Form Options");
        public GridEditForm() {
            CreateWaitDialog();
            InitializeComponent();
            //<gridControl2>
            advBandedGridView1.OptionsEditForm.CustomEditFormLayout = new AdvancedEditForm();
            //</gridControl2>
            InitVehiclesData();
            if(!MainFormHelper.TakeScreens) CreateTimer();
            LicenseInfo.SetToolTipController(this, gridControl1);
            LicenseInfo.SetToolTipController(this, gridControl2);
            SetEditLicenseInfo(repositoryItemPictureEdit2, gridView1);
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "GridEditForm" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "GridEditForm"; }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CreateRibbonItems();
        }
        protected override void SetVisibleCore(bool value) {
            base.SetVisibleCore(value);
            pgOptions.Visible = value;
        }
        void CreateRibbonItems() {
            pgOptions.ShowCaptionButton = false;
            pgOptions.AllowTextClipping = false;
            ParentFormMain.MainPage.Groups.Insert(3, pgOptions);
            BarButtonItem bItem = new BarButtonItem(ParentFormMain.Ribbon.Manager, "Options");
            bItem.Hint = pgOptions.Text;
            bItem.ImageOptions.SvgImage = Properties.Resources.Settings;
            bItem.ImageOptions.SvgImageSize = new Size(32, 32);
            bItem.ItemClick += new ItemClickEventHandler(OptionsItemClick);
            pgOptions.ItemLinks.Add(bItem);
        }

        GridView CurrentGridView {
            get {
                if(gridControl1.Visible) return gridView1;
                return advBandedGridView1;
            }
        }
        void OptionsItemClick(object sender, ItemClickEventArgs e) {
            using(EditFormOptions frm = new EditFormOptions(CurrentGridView, GridRibbonMenuManager.Manager)) {
                CurrentGridView.CloseEditForm();
                DialogResult res = frm.ShowDialog(this.FindForm());
                if((CurrentGridView.OptionsBehavior.EditingMode == GridEditingMode.EditFormInplace || 
                    CurrentGridView.OptionsBehavior.EditingMode == GridEditingMode.EditFormInplaceHideCurrentRow) && res == DialogResult.OK)
                    CurrentGridView.ShowEditForm();
            }
        }
        protected override void OnTick() {
            if(DemosInfo.CurrentModule == this) {
                //<gridControl1>
                /*
                 ~Show the EditForm at startup:
                 */
                gridView1.ShowEditForm();
                //</gridControl1>

                gridControl2.ForceInitialize();
                advBandedGridView1.FocusedRowHandle = 0;
            }
        }
        protected override void InitXMLData(string dataFileName) {
            string tblModel = "Model", tblCategory = "Category", tblTrademark = "Trademark", tblBodyStyle = "BodyStyle";
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);

            SetGridDataSource(tblModel, ds, gridControl1);
            SetGridDataSource(tblModel, ds, gridControl2);

            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblCategory];
            repositoryItemLookUpEdit1.DropDownRows = ds.Tables[tblCategory].Rows.Count;
            repositoryItemLookUpEdit2.DataSource = ds.Tables[tblBodyStyle];
            repositoryItemLookUpEdit2.DropDownRows = ds.Tables[tblBodyStyle].Rows.Count;
            repositoryItemGridLookUpEdit1.DataSource = ds.Tables[tblTrademark];
            repositoryItemGridLookUpEdit1.GetImageByValueEvent += new DevExpress.XtraGrid.Demos.ImageByValueEventHandler(repositoryItemGridLookUpEdit1_GetImageByValue);

            ((AdvancedEditForm)advBandedGridView1.OptionsEditForm.CustomEditFormLayout).InitData(ds);
        }

        void SetGridDataSource(string table, DataSet ds, GridControl grid) {
            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[table]);
            grid.DataMember = null;
            grid.DataSource = dv;
        }

        private void repositoryItemGridLookUpEdit1_GetImageByValue(object sender, ImageByValueEventArgs e) {
            DataHelper.LogoGridLookupGetImageByValue(sender, e);
        }

        //<gridControl1>
        /*
         ~Use the MemoEdit in-place editor for the Description column in the EditForm instead of the MemoExEdit dropdown editor:
         */
        private void gridView1_CustomRowCellEditForEditing(object sender, Views.Grid.CustomRowCellEditEventArgs e) {
            if(e.Column == colDescription) 
                e.RepositoryItem = repositoryItemMemoEdit1;
        }
        //</gridControl1>

    }
}

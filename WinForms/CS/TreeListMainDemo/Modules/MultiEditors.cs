using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraTreeList.Demos {
    public partial class TreeListMultiEditors : TutorialControl {
        public override TreeList MainControl {
            get { return treeList1; }
        }
        protected override string BarName { get { return "MultiEditors"; } }
        protected override BarManager Manager { get { return barManager1; } }
        protected override void InitBarInfo() {
            this.BarInfos.Add(new BarInfo("Show Buttons", new ItemClickEventHandler(ShowButtonsClick), imageCollection1.Images[0], true, false, false));
            this.BarInfos.Add(new BarInfo("Tree View", new ItemClickEventHandler(TreeViewClick), imageCollection1.Images[1], true, true, false));
            this.BarInfos.Add(new BarInfo("Show Root", new ItemClickEventHandler(ShowRootClick), imageCollection1.Images[2], true, true, false));
            this.BarInfos.Add(new BarInfo("Can Resize Nodes", new ItemClickEventHandler(ResizeClick), imageCollection1.Images[3], true, true, false));
        }

        public TreeListMultiEditors() {
            InitializeComponent();
            InitData();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "MultiEditors" }; } }
        protected override string WhatsThisXMLFileName { get { return "MultiEditors"; } }

        void ShowButtonsClick(object sender, ItemClickEventArgs e) {
            treeList1.ShowButtonMode = GetBarItemPushed(0) ? ShowButtonModeEnum.ShowAlways : ShowButtonModeEnum.ShowForFocusedCell;
        }
        void TreeViewClick(object sender, ItemClickEventArgs e) {
            treeList1.ParentFieldName = GetBarItemPushed(1) ? "ParentID" : "~";
            treeList1.ClearSorting();
            treeList1.DataSource = null;
            InitData();
        }
        void ShowRootClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowRoot = GetBarItemPushed(2);
        }
        void ResizeClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsBehavior.ResizeNodes = GetBarItemPushed(3);
            treeList1.SetDefaultRowHeight();
        }

        //<treeList1>
        private void InitData() {
            Record[] records = new Record[11];
            records[0] = new Record("Product Name", "Chai", "Teatime Chocolate Biscuits", "Ipoh Coffee", 0);
            records[1] = new Record("Category", 1, 2, 1, 1);
            records[2] = new Record("Supplier", "Exotic Liquids", "Specialty Biscuits, Ltd.", "Leka Trading", 2);
            records[3] = new Record("Quantity Per Unit", "10 boxes x 20 bags", "10 boxes x 12 pieces", "16 - 500 g tins", 3, 0);
            records[4] = new Record("Unit Price", 18.00, 9.20, 46.00, 4, 0);
            records[5] = new Record("Units in Stock", 39, 25, 17, 5, 0);
            records[6] = new Record("Discontinued", true, false, true, 6, 0);
            records[7] = new Record("Last Order", new DateTime(2010, 12, 14), new DateTime(2010, 7, 20), new DateTime(2010, 1, 7), 7);
            records[8] = new Record("Relevance", 70, 90, 50, 8);
            records[9] = new Record("Contact Name", "Shelley Burke", "Robb Merchant", "Sven Petersen", 9, 2);
            records[10] = new Record("Phone", "(100) 555-4822", "(111) 555-1222", "(120) 555-1154", 10, 2);

            treeList1.DataSource = records;
            treeList1.ExpandAll();
        }

        private void treeList1_GetCustomNodeCellEdit(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e) {
            if(e.Column.FieldName != "Category") {
                object obj = e.Node.GetValue(0);
                if(obj != null) {
                    switch(obj.ToString()) {
                        case "Category":
                            e.RepositoryItem = repositoryImageComboBox1;
                            break;
                        case "Supplier":
                            e.RepositoryItem = repositoryItemComboBox1;
                            break;
                        case "Unit Price":
                            e.RepositoryItem = repositoryItemCalcEdit1;
                            break;
                        case "Units in Stock":
                            e.RepositoryItem = repositoryItemSpinEdit1;
                            break;
                        case "Discontinued":
                            e.RepositoryItem = repositoryItemCheckEdit1;
                            break;
                        case "Last Order":
                            e.RepositoryItem = repositoryItemDateEdit1;
                            break;
                        case "Relevance":
                            e.RepositoryItem = repositoryItemProgressBar1;
                            break;
                        case "Phone":
                            e.RepositoryItem = repositoryItemTextEdit1;
                            break;
                    }
                }
            }
        }
        //</treeList1>

        bool IsAlphaBlending {
            get { return GetBarItemPushed(4); }
        }

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e) {
            if(e.Column.AbsoluteIndex == 0 || e.Node == treeList1.FocusedNode) return;
            if(e.Node.ParentNode != null && e.Node.ParentNode.Id == 2) {
                e.Appearance.BackColor = Color.FromArgb(IsAlphaBlending ? 150 : 255, 166, 227, 251);
                e.Appearance.ForeColor = Color.Black;
            }
            if((e.Node.Id == 4 || e.Node.Id == 5) && e.Column.AbsoluteIndex != 0)
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
        }


        //<treeList1>
        /*
         ~Process key strokes within the in-place ProgressBar editor:
         */
        private void repositoryItemProgressBar1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            int i = 0;
            if(treeList1.ActiveEditor == null) return;

            if(e.KeyCode == Keys.Add) {
                i = (int)treeList1.ActiveEditor.EditValue;
                if(i < 100)
                    treeList1.ActiveEditor.EditValue = i + 1;
            }
            if(e.KeyCode == Keys.Subtract) {
                i = (int)treeList1.ActiveEditor.EditValue;
                if(i > 0)
                    treeList1.ActiveEditor.EditValue = i - 1;
            }
        }
        //</treeList1>

    }
}

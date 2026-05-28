using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeList.Demos {
    public partial class TreeListPictures : TutorialControl {
        protected override object Options {
            get { return treeList1.OptionsView; }
        }
        protected override string OptionsName {
            get { return "View\n Options"; }
        }
        public override TreeList MainControl {
            get { return treeList1; }
        }
        public override bool AllowPrintOptions {
            get { return true; }
        }
        protected override string BarName { get { return "Pictures"; } }
        protected override BarManager Manager { get { return barManager1; } }
        protected override void InitBarInfo() {
            this.BarInfos.Add(new BarInfo("Print Preview", new ItemClickEventHandler(PrintPreviewClick), imageCollection1.Images[0], false, false, false));
            this.BarInfos.Add(new BarInfo("Print Designer", new ItemClickEventHandler(PrintDesignerClick), imageCollection1.Images[1], false, false, false));
        }

        public TreeListPictures() {
            InitializeComponent();
            InitData();
            InitHeaderPanelColor();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "Pictures" }; } }
        protected override string WhatsThisXMLFileName { get { return "Pictures"; } }

        protected override void OnSwitchStyle() {
            InitHeaderPanelColor();
        }

        //<treeList1>
        void PrintPreviewClick(object sender, ItemClickEventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            treeList1.ShowPrintPreview();
            Cursor.Current = currentCursor;
        }

        void PrintDesignerClick(object sender, ItemClickEventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            DevExpress.XtraEditors.XtraForm frm = new DevExpress.XtraEditors.XtraForm();
            frm.Text = "Print Designer";
            DevExpress.XtraTreeList.Frames.TreeListPrinting _print = new DevExpress.XtraTreeList.Frames.TreeListPrinting();
            _print.InitFrame(treeList1, "PrintingReport management", (Bitmap)imageCollection1.Images[0]);
            _print.Dock = DockStyle.Fill;
            frm.Controls.Add(_print);
            frm.Size = _print.UserControlSize;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Cursor.Current = currentCursor;
        }
        //</treeList1>

        private void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("BioLife.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }

        void InitHeaderPanelColor() {
            bool isDefault = UserLookAndFeel.Default.UseWindowsXPTheme || UserLookAndFeel.Default.Style == LookAndFeelStyle.Skin || UserLookAndFeel.Default.Style == LookAndFeelStyle.Office2003;
            treeList1.Appearance.HeaderPanel.ForeColor = isDefault ? /*SystemColors.WindowText*/Color.Empty : Color.White;
        }
    }
}

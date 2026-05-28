using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Internal;

namespace DevExpress.XtraTreeList.Demos {
    public partial class Bands : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        protected override object Options {
            get { return MainControl.OptionsView; }
        }
        protected override string OptionsName {
            get { return "View Options"; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "TreeListMainDemo\\Modules\\Bands", "TreeListMainDemo\\Options\\ucBandOptions" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "Bands"; }
        }
        public override TreeList MainControl {
            get { return treeList1; }
        }
        public Bands() {
            InitializeComponent();
            InitSpaceObjectsData();
            ucBandOptions1.InitData(MainControl);
        }
        DataTable spaceObjectsTable;
        void InitSpaceObjectsData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("SpaceObjects.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                spaceObjectsTable = dataSet.Tables[0];
                spaceObjectsTable.PrimaryKey = new DataColumn[] { spaceObjectsTable.Columns["ObjectId"] };
                treeList1.DataSource = spaceObjectsTable;
                treeList1.KeyFieldName = "ObjectId";
                treeList1.ParentFieldName = "ParentId";
                treeList1.ExpandAll();
            }
        }
    }
}

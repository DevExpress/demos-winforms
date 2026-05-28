using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.Internal;
using DevExpress.XtraLayout.Demos.Modules;

namespace DevExpress.XtraLayout.Demos {
    public partial class LayoutPrinting : DragDropLayoutControl {
        public LayoutPrinting() {
            InitializeComponent();
        }
        void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(DBFileName != "")
                dsCategories.ReadXml(DBFileName, XmlReadMode.InferSchema);
        }
        void LayoutPrinting_Load(object sender, EventArgs e) {
            if(!DesignMode) InitData();
        }
    }
}

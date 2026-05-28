using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos {
    public partial class UnboundExpression : TutorialControl {
        public UnboundExpression() {
            InitializeComponent();
            //<gridControl1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.

            ~Discount Amount column:
            gridColumn7.OptionsColumn.AllowEdit = false;
            gridColumn7.ShowUnboundExpressionMenu = true;
            gridColumn7.UnboundExpression = "[UnitPrice] * [Quantity] - [Total]";
            gridColumn7.UnboundDataType = typeof(decimal);

            ~Total column:
            gridColumn6.OptionsColumn.AllowEdit = false;
            gridColumn6.ShowUnboundExpressionMenu = true;
            gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])";
            gridColumn6.UnboundDataType = typeof(decimal);
            */
            //</gridControl1>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "UnboundExpression" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "UnboundExpression"; }
        }

        private void UnboundExpression_Load(object sender, EventArgs e) {
            InitNWindData();
            InitCombo();
            gridView1.ExpandAllGroups();
        }

        private void InitCombo() {
            foreach(GridColumn column in gridView1.Columns)
                if(column.ShowUnboundExpressionMenu)
                    imageListBoxControl1.Items.Add(new ImageListBoxItem(column, column.GetTextCaption(), column.ImageIndex));
            imageListBoxControl1.SelectedIndex = 0;
        }

        string tblGrid = "Order Details";
        string tblLookUp = "Products";
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            return ds;
        }
        public override BaseView ExportView { get { return gridControl1.MainView; } }
        //<simpleButton1>
        private void simpleButton1_Click(object sender, EventArgs e) {
            GridColumn column = imageListBoxControl1.SelectedValue as GridColumn;
            if(column == null) return;
            gridView1.ShowUnboundExpressionEditor(column);
        }
        //</simpleButton1>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}

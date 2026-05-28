using System.Collections.Generic;
using System.Data;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class FindFilter : TutorialControl {
        public FindFilter() {
            CreateWaitDialog();
            InitializeComponent();
            InitNWindData();
            ucFindOptions1.InitData(gridView1, GetColumn(gridView1.VisibleColumns));
            gridView1.FindFilterText = "ana tr";
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "FindFilter", "ucFindOptions" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "FindFilter"; }
        }

        List<ImageComboBoxItem> GetColumn(DevExpress.XtraGrid.Columns.GridColumnReadOnlyCollection gridColumnReadOnlyCollection) {
            List<ImageComboBoxItem> ret = new List<ImageComboBoxItem>();
            ret.Add(new ImageComboBoxItem("*", "*"));
            for(int i = 0; i < gridColumnReadOnlyCollection.Count; i++) {
                string columns = gridColumnReadOnlyCollection[i].GetCaption();
                string fields = gridColumnReadOnlyCollection[i].FieldName;
                for(int j = i; j < gridColumnReadOnlyCollection.Count; j++) {
                    if(j != i) {
                        columns += string.Format(";{0}", gridColumnReadOnlyCollection[j].GetCaption());
                        fields += string.Format(";{0}", gridColumnReadOnlyCollection[j].FieldName);
                    }
                    ret.Add(new ImageComboBoxItem(columns, fields, -1));
                }
            }
            return ret;
        }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet dataSet = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingCustomers);
            dataSet.ReadXml(dataFileName);
            gridControl1.DataSource = dataSet.Tables["Customers"];
            return dataSet;
        }
        void gridView1_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e) {
            e.FilterControl.MaxOperandsCount = 5;
        }
    }
}

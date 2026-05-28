using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Text;
using DevExpress.Tutorials;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleLookUpEdit : TutorialControl  {
        public ModuleLookUpEdit() {
            InitializeComponent();
            InitData();
            InitArrayData();
            InitLookUp();
            InitValues();
            tabPane1.SelectedPageChanged += SelectedPageChanged;
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            tabPane1.SelectedPageChanged -= SelectedPageChanged;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleLookUpEdit", "LookUpProperties" }; } }
        protected override string WhatsThisXMLFileName { get { return "lookupedit"; } }

        protected override bool AllowCenterControls { get { return false; } }

        private void ModuleLookUpEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(lookUpEdit1);
            ControlUtils.CenterControlInParent(lookUpEdit2);
            ControlUtils.CenterControlInParent(lookUpEdit3);
            ControlUtils.CenterControlInParent(lookUpEdit4);
            notePanel1.Text = "This sample demonstrates how to use a DataView as a data source for a Lookup editor.";
            notePanel2.Text = "This sample demonstrates how to bind a class inherited from Collection Base within a Lookup edit.";
            notePanel3.Text = "This sample demonstrates how to use an ArrayList-based object as a data source within a Lookup editor.";
            notePanel4.Text = "This sample illustrates how to use the Properties.GetNotInListValue event of the Lookup Edit. Use it to display virtual data within an unbound column of your control.";
            notePanel1.Visible = true;
        }

        LookUpEdit CurrentEdit {
            get {
                switch(tabPane1.SelectedPageIndex) {
                    case 1: return lookUpEdit2;
                    case 2: return lookUpEdit3;
                    case 3: return lookUpEdit4;
                }
                return lookUpEdit1;
            }
        }


        void InitValues() {
            properties.InitLookUp(CurrentEdit);
        }

        //<lookUpEdit1>
        //<dataNavigator1>
        DataView dvMain, dvProducts;
        void InitData() {
            DataViewManager dvm = new DataViewManager(NWindDataSet);
            dvMain = dvm.CreateDataView(NWindDataSet.Tables["Order Details"]);
            dvProducts = dvm.CreateDataView(NWindDataSet.Tables["Products"]);
        }
        //</dataNavigator1>
        // </lookUpEdit1>

        // <lookUpEdit3>
        Record[] records = null;
        private void InitArrayData() {
            records = new Record[TutorialHelper.Countries.Length];
            for(int i = 0; i < TutorialHelper.Countries.Length; i++)
                records[i] = new Record(StringPainter.Default.RemoveFormat(TutorialHelper.Countries[i]));
        }
        // </lookUpEdit3>

        private void InitLookUp() {
            //data binding
            // <lookUpEdit1>
            if(dvMain != null)
                lookUpEdit1.DataBindings.Add("EditValue", dvMain, "ProductID");
            lookUpEdit1.Properties.DataSource = dvProducts;
            // </lookUpEdit1>
            //<dataNavigator1>
            dataNavigator1.DataSource = dvMain;
            //</dataNavigator1>
            //simple binding
            // <lookUpEdit2>
            lookUpEdit2.Properties.DataSource = ContactList.GetContacts();
            lookUpEdit2.EditValue = "2";
            // </lookUpEdit2>
            //array list
            // <lookUpEdit3>
            lookUpEdit3.Properties.ValueMember = "Country";
            lookUpEdit3.Properties.DisplayMember = "Country";
            lookUpEdit3.Properties.DataSource = records;
            lookUpEdit3.Properties.PopulateColumns();
            lookUpEdit3.EditValue = records[0].Country;
            // </lookUpEdit3>
            //not in list
            // <lookUpEdit4>
            lookUpEdit4.Properties.DataSource = records;
            lookUpEdit4.EditValue = records[0].Country;
            lookUpEdit4.Properties.GetNotInListValue += new DevExpress.XtraEditors.Controls.GetNotInListValueEventHandler(GetNotInListValue);
            // </lookUpEdit4>
        }

        // <lookUpEdit4>
        private void GetNotInListValue(object sender, DevExpress.XtraEditors.Controls.GetNotInListValueEventArgs e) {
            e.Value = (e.RecordIndex + 1).ToString() + ".";
        }
        // </lookUpEdit4>

        private void SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            InitValues();
        }
    }
}


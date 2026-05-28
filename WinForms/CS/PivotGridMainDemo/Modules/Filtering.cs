using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using System.Globalization;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class Filtering : TutorialControl {
        bool initialized;

		public Filtering() {
			CreateWaitDialog();
			InitializeComponent();

			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            initialized = true;
            ApplyFilter();
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        //<dateEdit1>
        //<dateEdit2>
		private void dateEdit_EditValueChanged(object sender, EventArgs e) {
            if(initialized)
			    ApplyFilter();
		}

		void ApplyFilter() {
			string str1 = GetCriteria(dateEdit1.DateTime, true),
				str2 = GetCriteria(dateEdit2.DateTime, false);

			if(!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(str2))
				pivotGridControl1.ActiveFilterCriteria = CriteriaOperator.Parse(str1 + " And " + str2);
			else
				pivotGridControl1.ActiveFilterCriteria = CriteriaOperator.Parse(str1 + str2);
		}        
		string GetCriteria(DateTime date, bool isGreater) {
			if(date.Ticks == 0) return "";
			return string.Format("{0} {1} #{2}#", fieldOrderDate.FilterColumnName, isGreater ? ">=" : "<=", 
                Convert.ToString(date, CultureInfo.InvariantCulture));
		}
        //</dateEdit2>
        //</dateEdit1>
	}
}

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.PivotGrid.Utils;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class GroupInterval : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        DataSourceColumnBinding fieldOrderDateBinding;

        public GroupInterval() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();
            fieldOrderDateBinding = (DataSourceColumnBinding)fieldOrderDate.DataBinding;
        }
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void GroupInterval_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			InitComboBox();
			ceProductInterval.Checked = true;
			pivotGridControl1.HeaderImages = HeadersImageList;
			fieldExtendedPrice.ImageIndex = 3;
        }

        void InitComboBox() {
            PopulateItems(GroupIntervalHelper.BasicDiscreteDateTimeGroupIntervals);
            PopulateItems(GroupIntervalHelper.BasicContinuousDateTimeGroupIntervals);
            PopulateItems(GroupIntervalHelper.AdditionalDiscreteDateTimeGroupIntervals);
            PopulateItems(GroupIntervalHelper.AdditionalContinuousDateTimeGroupIntervals);
            icbGroupInterval.SelectedIndex = 7;
		}
        private void PopulateItems(IEnumerable<PivotGroupInterval> intervals) {
            foreach(PivotGroupInterval interval in intervals) {
                string intervalCaption = GroupIntervalHelper.GetDateTimeGroupIntervalCaption(interval);
                icbGroupInterval.Properties.Items.Add(new ImageComboBoxItem(intervalCaption, interval, -1));
            }
        }
        //<icbGroupInterval>
		private void icbGroupInterval_SelectedIndexChanged(object sender, System.EventArgs e) {
            fieldOrderDate.FilterValues.Clear();
            fieldOrderDateBinding.GroupInterval = (PivotGroupInterval)icbGroupInterval.EditValue;
		}
        //</icbGroupInterval>
        //<ceProductInterval>
		private void ceProductInterval_CheckedChanged(object sender, System.EventArgs e) {
			fieldProductAlphabetical.Visible = ceProductInterval.Checked;
		}
        //</ceProductInterval>

		private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e) {
			if(e.Field == fieldOrderDate) {
				if(fieldOrderDateBinding.GroupInterval == PivotGroupInterval.DateQuarter) {
					e.DisplayText = string.Format("Qtr {0}", e.Value);
					if(e.ValueType == PivotGridValueType.Total) 
						e.DisplayText += " Total";
				}
				if(fieldOrderDateBinding.GroupInterval == PivotGroupInterval.DateWeekYear) {
					DateTime date = (DateTime)e.Value;
					CultureInfo culture = Thread.CurrentThread.CurrentUICulture;
					int weekNumber = culture.Calendar.GetWeekOfYear(date, culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek);
					e.DisplayText = string.Format("Week {0} of {1}", weekNumber, date.Year);
					if(e.ValueType == PivotGridValueType.Total)
						e.DisplayText += " Total";
				}
			}
		}

        private void pivotGridControl1_MenuItemClick(object sender, PivotGridMenuItemClickEventArgs e) {
            if(e.Field == fieldOrderDate) {
                if(e.Item.Tag is PivotGroupInterval){
                    BeginInvoke(new Action(() => icbGroupInterval.EditValue = e.Item.Tag));
                }
            }
        }
	}
}


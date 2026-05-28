using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.Utils;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class DrillDownForm : DevExpress.XtraEditors.XtraForm {
        PivotDrillDownDataSource dataSource;

        public DrillDownForm(PivotDrillDownDataSource dataSource) {
            this.dataSource = dataSource;
            InitializeComponent();
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", typeof(DrillDownForm).Assembly);
            gridControl1.DataSource = dataSource;
            ((GridView)gridControl1.MainView).OptionsView.ShowGroupPanel = false;
        }

        public new void ShowDialog() {
            if(dataSource.RowCount == 0) {
                XtraMessageBox.Show("DrillDown doesn't contains results");
            } else
                base.ShowDialog();
        }
    }
}


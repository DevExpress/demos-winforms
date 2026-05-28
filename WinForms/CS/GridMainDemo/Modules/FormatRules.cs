using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;

namespace DevExpress.XtraGrid.Demos {
    public partial class FormatRules : TutorialControl {
        DXPopupMenu formatRulesMenu = new DXPopupMenu();
        public override BaseView ExportView { get { return gridView1; } }
        public FormatRules() {
            InitializeComponent();
            gridControl1.DataSource = SaleOverviewDataGenerator.GenerateSales();
        }
        private void gridView1_RowCellClick(object sender, Views.Grid.RowCellClickEventArgs e) {
            if(e.Button == System.Windows.Forms.MouseButtons.Right) {
                GridFormatRuleMenuItems items = new GridFormatRuleMenuItems(gridView1, e.Column, formatRulesMenu.Items);
                if(items.Count > 0)
                    MenuManagerHelper.ShowMenu(formatRulesMenu, gridControl1.LookAndFeel, gridControl1.MenuManager, gridControl1, new Point(e.X, e.Y));
            }
        }
        #region GenerateReport

        public override bool AllowGenerateReport { get { return false; } }

        #endregion
    }
}

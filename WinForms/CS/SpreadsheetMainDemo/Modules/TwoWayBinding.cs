using System;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    public class TwoWayBindingModule : SpreadSheetTutorialControlBase {
        private SidePanel sidePanel1;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraGrid.Columns.GridColumn gridColumn1;
        private XtraGrid.Columns.GridColumn gridColumn2;
        private XtraGrid.Columns.GridColumn gridColumn3;
        private XtraGrid.Columns.GridColumn gridColumn4;
        private XtraGrid.Columns.GridColumn gridColumn5;
        private XtraGrid.Columns.GridColumn gridColumn6;
        private SpreadsheetControl spreadsheet;

        public TwoWayBindingModule() {
            InitializeComponent();
            spreadsheet.LoadDocument(DemoUtils.GetRelativePath("Expenses_template.xlsx"));
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheet.Focus();
        }

        private void Spreadsheet_DocumentLoaded(object sender, EventArgs e) {
            Worksheet sheet = spreadsheet.Document.Worksheets[0];
            Table table = sheet.Tables[0];
            RangeDataSourceOptions options = new RangeDataSourceOptions { PreserveFormulas = true, SkipHiddenRows = true };
            gridControl1.DataSource = table.DataRange.GetDataSource(options);
        }

        private void TwoWayBindingModule_Resize(object sender, EventArgs e) {
            sidePanel1.Height = Height / 2;
        }

        #region InitializeComponent
        private void InitializeComponent() {
            sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            spreadsheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(gridView1)).BeginInit();
            SuspendLayout();
            // 
            // sidePanel1
            // 
            sidePanel1.Controls.Add(spreadsheet);
            sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel1.Location = new System.Drawing.Point(0, 0);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new System.Drawing.Size(1228, 368);
            sidePanel1.TabIndex = 1;
            sidePanel1.Text = "sidePanel1";
            // 
            // spreadsheet
            // 
            spreadsheet.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            spreadsheet.Location = new System.Drawing.Point(0, 0);
            spreadsheet.Name = "spreadsheet";
            spreadsheet.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            spreadsheet.Options.View.ShowPrintArea = false;
            spreadsheet.Size = new System.Drawing.Size(1228, 367);
            spreadsheet.TabIndex = 8;
            spreadsheet.DocumentLoaded += new System.EventHandler(Spreadsheet_DocumentLoaded);
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 368);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1228, 326);
            gridControl1.TabIndex = 2;
            gridControl1.UseEmbeddedNavigator = true;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            gridView1});
            // 
            // gridView1
            // 
            gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            gridColumn1,
            gridColumn2,
            gridColumn3,
            gridColumn4,
            gridColumn5,
            gridColumn6});
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Operation Expenses";
            gridColumn1.FieldName = "Column 0";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.FixedWidth = true;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 215;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Q1";
            gridColumn2.DisplayFormat.FormatString = "$ {0:n2}";
            gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn2.FieldName = "Column 1";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.OptionsColumn.FixedWidth = true;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 117;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Q2";
            gridColumn3.DisplayFormat.FormatString = "$ {0:n2}";
            gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn3.FieldName = "Column 2";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.OptionsColumn.FixedWidth = true;
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 117;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Q3";
            gridColumn4.DisplayFormat.FormatString = "$ {0:n2}";
            gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn4.FieldName = "Column 3";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.OptionsColumn.FixedWidth = true;
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 117;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Q4";
            gridColumn5.DisplayFormat.FormatString = "$ {0:n2}";
            gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn5.FieldName = "Column 4";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.OptionsColumn.FixedWidth = true;
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 117;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Yearly Total";
            gridColumn6.DisplayFormat.FormatString = "$ {0:n2}";
            gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridColumn6.FieldName = "Column 5";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.OptionsColumn.AllowEdit = false;
            gridColumn6.OptionsColumn.FixedWidth = true;
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 145;
            // 
            // TwoWayBindingModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(sidePanel1);
            Name = "TwoWayBindingModule";
            Size = new System.Drawing.Size(1228, 694);
            Resize += new System.EventHandler(TwoWayBindingModule_Resize);
            sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(gridView1)).EndInit();
            ResumeLayout(false);

        }
        #endregion
    }
}

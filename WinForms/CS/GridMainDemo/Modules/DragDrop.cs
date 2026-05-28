using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.DragDrop;
using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    public partial class DragDrop : TutorialControl {
        public DragDrop() {
            InitializeComponent();
            Init();

        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "DragDrop" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "DragDrop"; }
        }
        //<gridControl1>
        void InitializeGridControl1DragDrop() {
            behaviorManager1.Attach<DragDropBehavior>(gridView1, behavior => {
                behavior.DragDrop += Behavior_DragDropToGrid1;
            });
        }
        void Behavior_DragDropToGrid1(object sender, DragDropEventArgs e) {

        }
        //</gridControl1>

        //<gridControl2>
        void InitializeGridControl2DragDrop() {
            behaviorManager1.Attach<DragDropBehavior>(gridView2, behavior => {
                behavior.DragDrop += Behavior_DragDropToGrid2;
            });
        }
        void Behavior_DragDropToGrid2(object sender, DragDropEventArgs e) {

        }
        //</gridControl2>
        void Init() {
            SaleOverviewData[] generateSales = SaleOverviewDataGenerator.GenerateSales();
            int count = 0;
            var list = generateSales.TakeWhile(e => count++ < generateSales.Count() / 2).ToList();
            InitializeOptions(icbSelectMode1, imageComboBoxEdit1, ceMultiSelect1, gridView1, gridControl1, new BindingList<SaleOverviewData>(list));
            count = 0;
            list = generateSales.SkipWhile(e => count++ < generateSales.Count() / 2).ToList();
            InitializeOptions(icbSelectMode2, imageComboBoxEdit2, ceMultiSelect2, gridView2, gridControl2, new BindingList<SaleOverviewData>(list));
            InitializeGridControl1DragDrop();
            InitializeGridControl2DragDrop();
        }

        static void InitializeOptions(ImageComboBoxEdit imageComboBoxMultiSelectMode, ImageComboBoxEdit imageComboBoxPasteMode, CheckEdit checkEdit, GridView gridView, GridControl gridControl, object dataSource) {
            gridControl.DataSource = dataSource;
            imageComboBoxMultiSelectMode.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.RowSelect, GridMultiSelectMode.RowSelect, -1));
            imageComboBoxMultiSelectMode.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.CellSelect, GridMultiSelectMode.CellSelect, -1));
            imageComboBoxMultiSelectMode.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.CheckBoxRowSelect, GridMultiSelectMode.CheckBoxRowSelect, -1));
            imageComboBoxMultiSelectMode.DataBindings.Add("EditValue", gridView.OptionsSelection, "MultiSelectMode", true, DataSourceUpdateMode.OnPropertyChanged);
            checkEdit.DataBindings.Add("EditValue", gridView.OptionsSelection, "MultiSelect", true, DataSourceUpdateMode.OnPropertyChanged);
            imageComboBoxPasteMode.Properties.Items.Add(new ImageComboBoxItem(PasteMode.Default, -1));
            imageComboBoxPasteMode.Properties.Items.Add(new ImageComboBoxItem(PasteMode.Append, -1));
            imageComboBoxPasteMode.Properties.Items.Add(new ImageComboBoxItem(PasteMode.None, -1));
            imageComboBoxPasteMode.Properties.Items.Add(new ImageComboBoxItem(PasteMode.Update, -1));
            imageComboBoxPasteMode.DataBindings.Add("EditValue", gridView.OptionsClipboard, "PasteMode", true, DataSourceUpdateMode.OnPropertyChanged);
            gridView.BestFitColumns();
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e) {
            e.Cancel = true;
        }
    }
}

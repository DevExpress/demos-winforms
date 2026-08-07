using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.MailClient.Win;
using DevExpress.MailDemo.Win;
using DevExpress.ProductsDemo.Win.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class Contacts : BaseModule {
        public override string ModuleName { get { return Properties.Resources.ContactsName; } }
        public Contacts() {
            InitializeComponent();
            EditorHelper.InitPersonComboBox(repositoryItemImageComboBox1);
            gridControl1.DataSource = DataHelper.Contacts;
            gridView1.ShowFindPanel();
            InitIndex(DataHelper.Contacts);
        }
        protected override DevExpress.XtraGrid.GridControl Grid { get { return gridControl1; } }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            gridControl1.Focus();
            UpdateActionButtons();
            if(firstShow) {
                ButtonClick(TagResources.ContactCard);
                gridControl1.ForceInitialize();
                GridHelper.SetFindControlImages(gridControl1);
                if(DataHelper.Contacts.Count == 0) UpdateCurrentContact();
            }
        }
        void UpdateActionButtons() {
            OwnerForm.EnableLayoutButtons(gridControl1.MainView != layoutView1);
            OwnerForm.EnableZoomControl(gridControl1.MainView != layoutView1);
        }
        Contact CurrentContact {
            get { return gridView1.GetRow(gridView1.FocusedRowHandle) as Contact; }
        }
        private void gridView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateCurrentContact();
        }
        private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
            if(e.FocusedRowHandle == GridControl.AutoFilterRowHandle)
                gridView1.FocusedColumn = colName;
            else if(e.FocusedRowHandle >= 0)
                gridView1.FocusedColumn = null;
            UpdateCurrentContact();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
        }

        void UpdateCurrentContact() {
            ucContactInfo1.Init(CurrentContact, null);
            gridView1.MakeRowVisible(gridView1.FocusedRowHandle);
            OwnerForm.EnableEditContact(CurrentContact != null);
        }
        protected internal override void ButtonClick(string tag) {
            switch(tag) {
                case TagResources.ContactList:
                    UpdateMainView(gridView1);
                    ClearSortingAndGrouping();
                    break;
                case TagResources.ContactAlphabetical:
                    UpdateMainView(gridView1);
                    ClearSortingAndGrouping();
                    colName.Group();
                    break;
                case TagResources.ContactByState:
                    UpdateMainView(gridView1);
                    ClearSortingAndGrouping();
                    colState.Group();
                    colCity.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    break;
                case TagResources.ContactCard:
                    UpdateMainView(layoutView1);
                    break;
                case TagResources.FlipLayout:
                    layoutControl1.Root.FlipLayout();
                    break;
                case TagResources.ContactDelete:
                    if(CurrentContact == null) return;
                    int index = gridView1.FocusedRowHandle;
                    gridControl1.MainView.BeginDataUpdate();
                    try {
                        DataHelper.Contacts.Remove(CurrentContact);
                    }
                    finally {
                        gridControl1.MainView.EndDataUpdate();
                    }
                    if(index > gridView1.DataRowCount - 1) index--;
                    gridView1.FocusedRowHandle = index;
                    ShowInfo(gridView1);
                    break;
                case TagResources.ContactNew:
                    Contact contact = new Contact();
                    if(EditContact(contact) == DialogResult.OK) {
                        gridControl1.MainView.BeginDataUpdate();
                        try {
                            DataHelper.Contacts.Add(contact);
                        }
                        finally {
                            gridControl1.MainView.EndDataUpdate();
                        }
                        ColumnView view = gridControl1.MainView as ColumnView;
                        if(view != null) {
                            GridHelper.GridViewFocusObject(view, contact);
                            ShowInfo(view);
                        }
                    }
                    break;
                case TagResources.ContactEdit:
                    EditContact(CurrentContact);
                    break;
            }
            UpdateCurrentContact();
            UpdateInfo();
        }
        void UpdateMainView(ColumnView view) {
            bool isGrid = view is GridView;
            gridControl1.MainView = view;
            splitterItem1.Visibility = isGrid ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem2.Visibility = isGrid ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            GridHelper.SetFindControlImages(gridControl1);
            UpdateActionButtons();
        }
        private void ClearSortingAndGrouping() {
            gridView1.ClearGrouping();
            gridView1.ClearSorting();
        }
        protected override bool AllowZoomControl { get { return true; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override float ZoomFactor {
            get { return ucContactInfo1.ZoomFactor; }
            set {
                ucContactInfo1.ZoomFactor = value;
                SetZoomCaption();
            }
        }
        protected override void SetZoomCaption() {
            base.SetZoomCaption();
            if(ZoomFactor == 1)
                OwnerForm.ZoomManager.SetZoomCaption(Properties.Resources.Picture100Zoom);
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e) {
            if(e.Button == MouseButtons.Left && e.RowHandle >= 0 && e.Clicks == 2)
                EditContact(CurrentContact);
        }

        private void layoutView1_MouseDown(object sender, MouseEventArgs e) {
            if(e.Clicks == 2 && e.Button == MouseButtons.Left) {
                LayoutViewHitInfo info = layoutView1.CalcHitInfo(e.Location);
                if(info.InCard) {
                    Contact current = layoutView1.GetRow(info.RowHandle) as Contact;
                    if(current != null) {
                        EditContact(current);
                        layoutView1.UpdateCurrentRow();
                    }
                }
            }
        }
        DialogResult EditContact(Contact contact) {
            if(contact == null) return DialogResult.Ignore;
            DialogResult ret = DialogResult.Cancel;
            Cursor.Current = Cursors.WaitCursor;
            using(frmEditContact frm = new frmEditContact(contact, OwnerForm.Ribbon)) {
                ret = frm.ShowDialog(OwnerForm);
            }
            UpdateCurrentContact();
            Cursor.Current = Cursors.Default;
            return ret;
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter && gridView1.FocusedRowHandle >= 0)
                EditContact(CurrentContact);
        }
        void UpdateInfo() {
            ShowInfo(gridControl1.MainView as ColumnView);
        }
        private void layoutView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateInfo();
        }

        private void repositoryItemHyperLinkEdit1_OpenLink(object sender, OpenLinkEventArgs e) {
            if(e.EditValue != null) e.EditValue = "mailto:" + e.EditValue.ToString();
        }
        protected void InitIndex(List<Contact> list) {
            this.extractName = (s) => {
                string name = ((Contact)s).LastName;
                if(string.IsNullOrEmpty(name)) return null; //todo?
                return AlphaIndex.Group(name.Substring(0, 1));
            };
            List<AlphaIndex> dict = Generate(list, extractName);
            SetupGrid(dict, indexGridControl);
        }
        public void SetupGrid(List<AlphaIndex> list, GridControl grid) {
            GridView view = grid.MainView as GridView;
            view.Columns.AddVisible("Index");
            grid.DataSource = list;
            view.FocusedRowChanged += view_FocusedRowChanged;

        }
        Timer alphaChange = null;
        void view_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            if(alphaChange != null) alphaChange.Dispose();
            alphaChange = new Timer();
            alphaChange.Interval = 200;
            alphaChange.Tick += (s, ee) => {
                gridControl1.DataSource = ApplyFilter(DataHelper.Contacts, ((GridView)sender).GetFocusedRow() as AlphaIndex);
                ((Timer)s).Dispose();
                this.alphaChange = null;
                UpdateInfo();
            };
            alphaChange.Start();
        }
        GetAlphaMehtod extractName;
        IList ApplyFilter(List<Contact> list, AlphaIndex alpha) {
            if(alpha == null || alpha == AlphaIndex.All) return list;
            var res = from q in list
                      where alpha.Match(extractName(q))
                      select q;
            return res.ToList();

        }
        public List<AlphaIndex> Generate(List<Contact> values, GetAlphaMehtod extractName) {
            var data = from q in values
                       where extractName(q) != null
                       group q by extractName(q) into g
                       orderby g.Key
                       select new AlphaIndex() { Index = g.Key, Count = g.Count() };
            var res = data.ToList();
            res.Insert(0, AlphaIndex.All);
            return res;

        }



    }
    public class AlphaIndex {
        public string Index { get; set; }
        public int Count { get; set; }
        public override string ToString() {
            return string.Format("{0}: {1}", Index, Count);
        }
        public bool Match(string text) {
            if(Group(text) == Index) return true;
            return false;
        }
        public static string Group(string text) {
            if(text.Length == 1) {
                char ch = text[0];
                if(Char.IsNumber(ch)) return "0-9";
            }
            return text.ToUpper();
        }
        static AlphaIndex _all, _alphaNumber;
        public static AlphaIndex All {
            get {
                if(_all == null) _all = new AlphaIndex() { Count = 0, Index = "All" };
                return _all;
            }
        }
        public static AlphaIndex AlphaNumber {
            get {
                if(_alphaNumber == null) _alphaNumber = new AlphaIndex() { Count = 0, Index = "0-9" };
                return _alphaNumber;
            }
        }
    }
    public delegate string GetAlphaMehtod(object target);
}

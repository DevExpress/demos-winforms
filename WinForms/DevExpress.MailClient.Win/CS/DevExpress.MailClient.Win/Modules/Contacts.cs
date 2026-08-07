using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MailClient.Win {
    public partial class Contacts : BaseModule {
        public override string ModuleName {
            get { return Properties.Resources.ContactsName; }
        }
        //
        public Contacts() {
            InitializeComponent();
            EditorHelper.InitTitleComboBox(repositoryItemImageComboBox1);
            gridControl1.DataSource = DataHelper.Contacts;
            gridView1.ShowFindPanel();
            InitIndex(DataHelper.Contacts);
        }
        protected override DevExpress.XtraGrid.GridControl Grid {
            get { return gridControl1; }
        }
        protected override bool AllowZoomControl {
            get { return true; }
        }
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
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            gridControl1.Focus();
            UpdateActionButtons();
            if(firstShow) {
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
            get { return ((ColumnView)gridControl1.MainView).GetFocusedRow() as Contact; }
        }
        void gridView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateCurrentContact();
        }
        void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
            if(e.FocusedRowHandle == GridControl.AutoFilterRowHandle)
                gridView1.FocusedColumn = colName;
            else if(e.FocusedRowHandle >= 0)
                gridView1.FocusedColumn = null;
            UpdateCurrentContact();
        }
        void UpdateCurrentContact() {
            ucContactInfo1.Init(CurrentContact, null);
            if(gridControl1.MainView == gridView1)
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
        void ClearSortingAndGrouping() {
            gridView1.ClearGrouping();
            gridView1.ClearSorting();
        }
        void gridView1_RowCellClick(object sender, RowCellClickEventArgs e) {
            if(e.Button == MouseButtons.Left && e.RowHandle >= 0 && e.Clicks == 2)
                EditContact(CurrentContact);
        }
        void gridView1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter && gridView1.FocusedRowHandle >= 0)
                EditContact(CurrentContact);
        }
        void layoutView1_CardClick(object sender, XtraGrid.Views.Layout.Events.CardClickEventArgs e) {
            if(e.Button == MouseButtons.Left && e.RowHandle >= 0 && e.Clicks == 2) {
                EditContact(CurrentContact);
                layoutView1.UpdateCurrentRow();
            }
        }
        DialogResult EditContact(Contact contact) {
            if(contact == null)
                return DialogResult.Ignore;
            DialogResult result = DialogResult.Cancel;
            Cursor.Current = Cursors.WaitCursor;
            using(frmEditContact frm = new frmEditContact(contact, OwnerForm.Ribbon))
                result = frm.ShowDialog(OwnerForm);
            UpdateCurrentContact();
            Cursor.Current = Cursors.Default;
            return result;
        }
        void UpdateInfo() {
            ShowInfo(gridControl1.MainView as ColumnView);
        }
        void layoutView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateInfo();
        }
        void repositoryItemHyperLinkEdit1_OpenLink(object sender, OpenLinkEventArgs e) {
            if(e.EditValue != null) e.EditValue = "mailto:" + e.EditValue.ToString();
        }
        protected void InitIndex(List<Contact> list) {
            SetupGrid(Generate(list, c => AlphaIndex.Group(c.LastName)), indexGridControl);
        }
        public void SetupGrid(List<AlphaIndex> list, GridControl grid) {
            GridView view = grid.MainView as GridView;
            view.Columns.AddVisible("Index");
            grid.DataSource = list;
            view.FocusedRowChanged += view_FocusedRowChanged;
        }
        Timer alphaChange = null;
        void view_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            if(alphaChange != null)
                alphaChange.Dispose();
            alphaChange = new Timer();
            alphaChange.Interval = 200;
            alphaChange.Tick += (s, ea) => {
                ((Timer)s).Stop();
                var focusedIndex = ((GridView)sender).GetFocusedRow() as AlphaIndex;
                gridControl1.DataSource = ApplyFilter(DataHelper.Contacts, focusedIndex);
                ((Timer)s).Dispose();
                this.alphaChange = null;
                UpdateInfo();
            };
            alphaChange.Start();
        }
        IList ApplyFilter(List<Contact> list, AlphaIndex alpha) {
            if(alpha == AlphaIndex.All || alpha == null)
                return list;
            return list.Where(c => alpha.Match(AlphaIndex.Group(c.LastName))).ToList();
        }
        public List<AlphaIndex> Generate(List<Contact> values, Func<Contact, string> extractName) {
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
            return Group(text) == Index;
        }
        public static string Group(string text) {
            if(string.IsNullOrEmpty(text))
                return null;
            if(text.Length > 1)
                text = text.Substring(0, 1);
            if(text.Length == 1)
                if(Char.IsNumber(text[0])) return "0-9";
            return text.ToUpper();
        }
        static AlphaIndex all;
        public static AlphaIndex All {
            get {
                if(all == null)
                    all = new AlphaIndex() { Count = 0, Index = "All" };
                return all;
            }
        }
        static AlphaIndex alphaNumber;
        public static AlphaIndex AlphaNumber {
            get {
                if(alphaNumber == null)
                    alphaNumber = new AlphaIndex() { Count = 0, Index = "0-9" };
                return alphaNumber;
            }
        }
    }
}

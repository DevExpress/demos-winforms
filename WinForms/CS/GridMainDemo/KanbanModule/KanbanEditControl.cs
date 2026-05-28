using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    public partial class KanbanEditControl : EditFormUserControl {
        DevExpress.XtraGrid.Views.Tile.TileView OwnerView;
        GridControl OwnerGrid {
            get { return OwnerView.GridControl; }
        }
        DataTable Employees { get; set; }
        DataTable Members { get; set; }
        DataTable Checklist { get; set; }
        //
        public KanbanEditControl(DevExpress.XtraGrid.Views.Tile.TileView ownerView,
            DataTable employees, DataTable members, DataTable checkList) {
            InitializeComponent();
            this.OwnerView = ownerView;
            this.comboBoxEdit1.Properties.Items.AddRange(typeof(TaskLabel).GetEnumValues());
            this.Employees = employees;
            this.Members = members;
            this.Checklist = checkList;
            this.gridControl1.DataSource = Checklist;
            this.memberTiles.AnimateArrival = false;
            this.memberTiles.ItemClick += tileControl1_ItemClick;
            this.VisibleChanged += (s, e) => { if(Visible) ControlShown(); };
            this.gridChecklist.CellValueChanged += gridView1_CellValueChanged;
            this.gridChecklist.RowCountChanged += (s, e) => { UpdateProgressBar(); };
        }
        Guid FocusedTaskId {
            get { return (OwnerView.GetRow(OwnerView.FocusedRowHandle) as TaskRecord).Id; }
        }
        void ControlShown() {
            this.layoutControl1.MenuManager = OwnerGrid.MenuManager;
            PopulateMembers();
            UpdateProgressBar();
        }
        void PopulateMembers() {
            tileGroup.Items.Clear();
            addMemberItem.Visible = true;
            tileGroup.Items.Add(addMemberItem);

            List<int> memberIDs = GetMemberIDs();
            foreach(int memberId in memberIDs) {
                var bytes = Employees.Rows.Find(memberId)["Photo"];
                var item = new TileItem();
                item.Image = ByteImageConverter.FromByteArray(bytes as byte[]);
                item.ImageAlignment = TileItemContentAlignment.MiddleCenter;
                var superTip = new SuperToolTip();
                superTip.Items.AddTitle(GetEmployeeFullName(memberId));
                item.SuperTip = superTip;
                item.Tag = memberId;
                tileGroup.Items.Insert(0, item);
                addMemberItem.Visible = (tileGroup.Items.Count == 5) ? false : true;
            }
        }
        void OnAddMemberMenuClick(object sender, EventArgs e) {
            int newId = (int)(sender as DXMenuItem).Tag;
            DataRow newRow = Members.NewRow();
            newRow["TaskID"] = FocusedTaskId;
            newRow["MemberID"] = newId;
            Members.Rows.Add(newRow);
            PopulateMembers();
        }
        void addMemberItem_ItemClick(object sender, TileItemEventArgs e) {
            List<int> memberIDs = GetMemberIDs();
            DXPopupMenu menu = new DXPopupMenu();
            menu.MenuViewType = MenuViewType.Menu;
            for(int i = 0; i < Employees.Rows.Count; i++) {
                DataRow row = Employees.Rows[i];
                int id = row.Field<int>("EmployeeID");
                if(memberIDs.Contains(id))
                    continue;
                string fullName = GetEmployeeFullName(id);
                DXMenuItem memberMenuItem = new DXMenuItem(fullName,
                    new EventHandler(OnAddMemberMenuClick)) { Tag = id };
                menu.Items.Add(memberMenuItem);
            }
            ShowPopup(menu);
        }
        void tileControl1_ItemClick(object sender, TileItemEventArgs e) {
            if(e.Item == addMemberItem)
                return;
            DXPopupMenu menu = new DXPopupMenu();
            menu.MenuViewType = MenuViewType.Menu;
            DXMenuItem removeItem = new DXMenuItem("Remove from card",
                new EventHandler(OnRemoveItemClick)) { Tag = e.Item.Tag };
            menu.Items.Add(removeItem);
            ShowPopup(menu);
        }
        void OnRemoveItemClick(object sender, EventArgs e) {
            int memberId = (int)(sender as DXMenuItem).Tag;
            Guid taskId = FocusedTaskId;
            List<DataRow> rowsToRemove = Members.AsEnumerable()
                .Where(row => row.Field<Guid>("TaskID") == taskId && row.Field<int>("MemberID") == memberId)
                .ToList();
            foreach(DataRow row in rowsToRemove)
                Members.Rows.Remove(row);
            PopulateMembers();
        }
        void ShowPopup(DXPopupMenu menu) {
            Control parentControl = memberTiles;
            Point pt = parentControl.PointToClient(Control.MousePosition);
            ((IDXDropDownControl)menu).Show(OwnerGrid.MenuManager, parentControl, pt);
        }
        string GetEmployeeFullName(int employeeId) {
            var row = Employees.Rows.Find(employeeId);
            return string.Format("{0} {1}", row["FirstName"], row["LastName"]);
        }
        List<int> GetMemberIDs() {
            Guid taskId = FocusedTaskId;
            return Members.AsEnumerable()
                .Where(row => row.Field<Guid>("TaskID") == FocusedTaskId)
                .Select(row => row.Field<int>("MemberID"))
                .ToList();
        }
        void gridView1_CustomRowFilter(object sender, Views.Base.RowFilterEventArgs e) {
            GridView view = sender as GridView;
            DataView dataView = view.DataSource as DataView;
            Guid taskID = (Guid)dataView[e.ListSourceRow]["TaskID"];
            e.Visible = (taskID == FocusedTaskId);
            e.Handled = true;
        }
        void gridView1_InitNewRow(object sender, InitNewRowEventArgs e) {
            gridChecklist.SetRowCellValue(e.RowHandle, gridChecklist.Columns["TaskID"], FocusedTaskId);
            gridChecklist.SetRowCellValue(e.RowHandle, gridChecklist.Columns["Caption"], "New item");
            gridChecklist.SetRowCellValue(e.RowHandle, gridChecklist.Columns["Checked"], false);
        }
        void gridView1_CellValueChanged(object sender, Views.Base.CellValueChangedEventArgs e) {
            gridChecklist.UpdateCurrentRow();
            UpdateProgressBar();
        }
        void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e) {
            gridChecklist.PostEditor();
        }
        void UpdateProgressBar() {
            Guid taskId = FocusedTaskId;
            List<DataRow> filtered = Checklist.AsEnumerable()
                .Where(row => row.Field<Guid>("TaskID") == taskId)
                .ToList();
            int totalCount = filtered.Count;
            int checkedCount = filtered.Where(row => row.Field<bool>("Checked") == true).ToList().Count;
            progressBarControl1.Properties.Maximum = (totalCount == 0 ? 1 : totalCount);
            progressBarControl1.Position = checkedCount;
        }
    }
}

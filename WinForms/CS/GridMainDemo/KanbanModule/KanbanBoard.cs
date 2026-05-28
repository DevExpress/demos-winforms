using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.XtraGrid.Demos {
    public partial class KanbanBoard : TutorialControl {
        BindingList<TaskRecord> tasksData;
        DataTable employeesData;
        DataTable membersData;
        DataTable checklistData;

        public KanbanBoard() {
            InitializeComponent();
            InitKanban();
            InitData();
            tileView.OptionsEditForm.CustomEditFormLayout = new KanbanEditControl(tileView, employeesData, membersData, checklistData);
            if(MainFormHelper.TakeScreens) tileView.AnimateArrival = false;
        }
        void InitKanban() {
            tileView.OptionsKanban.ShowGroupBackground = DefaultBoolean.True;
            tileView.OptionsKanban.Groups.Add(new KanbanGroup() { GroupValue = TaskStatus.ToDo });
            tileView.OptionsKanban.Groups.Add(new KanbanGroup() { GroupValue = TaskStatus.Planned });
            tileView.OptionsKanban.Groups.Add(new KanbanGroup() { GroupValue = TaskStatus.Doing });
            tileView.OptionsKanban.Groups.Add(new KanbanGroup() { GroupValue = TaskStatus.Testing });
            tileView.OptionsKanban.Groups.Add(new KanbanGroup() { GroupValue = TaskStatus.Done });
            tileView.OptionsKanban.Groups[4].FooterButton.Visible = DefaultBoolean.False;
            tileView.OptionsKanban.GroupFooterButton.Visible = DefaultBoolean.True;
            tileView.OptionsKanban.GroupFooterButton.Text = "Add a new card";

            tileView.GroupFooterButtonClick += TileView_GroupFooterButtonClick;
            tileView.GroupHeaderContextButtonClick += TileView_GroupHeaderContextButtonClick;
            tileView.CustomColumnDisplayText += TileView_CustomColumnDisplayText;
        }
        void TileView_CustomColumnDisplayText(object sender, Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.IsForGroupRow) {
                var kanbanGroup = tileView.GetKanbanGroupByValue(e.Value);
                int count = tileView.GetChildRowCount(kanbanGroup);
                string cards = count == 1 ? " card" : " cards";
                e.DisplayText += "<br><size=-2><r>" + count.ToString() + cards;
            }
        }
        void InitData() {
            tasksData = KanbanHelper.LoadTasks();
            employeesData = KanbanHelper.LoadEmployees();
            membersData = KanbanHelper.LoadMembers();
            checklistData = KanbanHelper.LoadChecklist();
            KanbanHelper.UpdateMembersGlyph(employeesData, LookAndFeel, ScaleHelper.ScaleVertical(30));
            gridControl.DataSource = tasksData;
        }
        void tileView_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e) {
            var task = tileView.GetRow(e.RowHandle) as TaskRecord;
            if(task == null)
                return;
            e.Item["Label"].Appearance.Normal.BackColor = GetLabelColor(task.Label);

            var elAttach = e.Item.GetElementByName("Attachment");
            elAttach.ImageVisible = task.AttachedImage != null;

            var elDescription = e.Item.GetElementByName("Description");
            elDescription.ImageVisible = !string.IsNullOrEmpty(task.Description);

            var elProgress = e.Item.GetElementByName("Progress");
            Guid id = task.Id;
            int count = checklistData.AsEnumerable()
                .Count(row => row.Field<Guid>("TaskID") == id);
            int doneCount = checklistData.AsEnumerable()
                .Count(row => row.Field<Guid>("TaskID") == id && row.Field<bool>("Checked"));
            if(count == 0) {
                elProgress.Text = "";
                elProgress.ImageVisible = false;
            }
            else {
                elProgress.AnchorIndent = elDescription.ImageVisible ? elProgress.AnchorIndent : 0;
                elProgress.Text = string.Format("{0}/{1}", doneCount, count);
            }
            var elements = GetMembersElements(id);
            if(elements.Count == 0) return;
            TileViewItemElement prev = null;
            foreach(var element in elements) {
                e.Item.Elements.Add(element);
                if(prev != null) {
                    element.AnchorElement = prev;
                    element.AnchorAlignment = AnchorAlignment.Left;
                    element.AnchorIndent = 4;
                }
                else {
                    element.RowIndex = 4;
                    element.ImageAlignment = TileItemContentAlignment.BottomRight;
                }
                prev = element;
            }
        }
        List<TileViewItemElement> GetMembersElements(Guid id) {
            List<DataRow> memberRows = membersData.AsEnumerable()
                .Where(row => row.Field<Guid>("TaskID") == id)
                .ToList();
            var result = new List<TileViewItemElement>();
            foreach(var memberRow in memberRows) {
                var photoBytes = employeesData.Rows.Find(memberRow["MemberID"])["Photo"];
                var element = new TileViewItemElement();
                element.Image = ByteImageConverter.FromByteArray(photoBytes as byte[]);
                result.Add(element);
            }
            return result;
        }
        Color GetLabelColor(TaskLabel label) {
            switch(label) {
                case TaskLabel.Red: return ColorTranslator.FromHtml("#f06562");
                case TaskLabel.Green: return ColorTranslator.FromHtml("#1fb876");
                case TaskLabel.Yellow: return ColorTranslator.FromHtml("#fca90a");
                default: return ColorTranslator.FromHtml("#969696");
            }
        }
        void AddNewCard(TaskStatus status) {
            string newCaption = XtraInputBox.Show("", "Add a new card", "New Task");
            if(String.IsNullOrEmpty(newCaption)) return;
            var newRow = KanbanHelper.CreateNewTask();
            newRow.Id = Guid.NewGuid();
            newRow.Status = status;
            newRow.Caption = newCaption;

            tasksData.Add(newRow);
            tileView.FocusedRowHandle = tileView.GetRowHandle(tasksData.IndexOf(newRow));
            tileView.RefreshData();
            tileView.MakeRowVisible(tileView.FocusedRowHandle);
        }
        void TileView_GroupFooterButtonClick(object sender, GroupFooterButtonClickEventArgs e) {
            var status = (TaskStatus)e.GroupValue;
            AddNewCard(status);
        }
        void TileView_GroupHeaderContextButtonClick(object sender, GroupHeaderContextButtonClickEventArgs e) {
            var status = (TaskStatus)e.GroupValue;
            AddNewCard(status);
        }
        protected override void DoDpiChange(int deviceDpiOld, int deviceDpiNew) {
            base.DoDpiChange(deviceDpiOld, deviceDpiNew);
            KanbanHelper.UpdateMembersGlyph(employeesData, LookAndFeel, ScaleDPI.ScaleVertical(30));
            tileView.RefreshData();
        }
    }
}

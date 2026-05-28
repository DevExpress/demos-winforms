using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Menu;
using DevExpress.Data.Filtering;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System;
using DevExpress.Data;
using DevExpress.Utils.Colors;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class Office365UI : TutorialControl {
        Color UnreadTextColor;
        public Office365UI() {
            InitializeComponent();
            gridControl1.DataSource = DataHelper.Messages;
            this.colDate.SortOrder = Data.ColumnSortOrder.Descending;
            tileView1.FocusedRowHandle = 2;
            

            this.biSortDate.Tag = "Date";
            this.biSortFrom.Tag = "From";
            this.biSortRead.Tag = "Read";
            this.biSortSubject.Tag = "SubjectDisplayText";
            this.biSortImportance.Tag = "Priority";

            this.gridControl1.SizeChanged += (s, e) => { CompactTemplate = gridControl1.Width <= 300; };
            if(MainFormHelper.TakeScreens) tileView1.AnimateArrival = false;
            UpdateColors();
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            UpdateColors();
        }

        void UpdateColors() {
            UnreadTextColor = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Primary, LookAndFeel);
            this.tileView1.Appearance.GroupText.ForeColor = UnreadTextColor;
            this.tileView1.Appearance.ItemFocused.BackColor = Color.FromArgb(40, UnreadTextColor);
            this.tileView1.Appearance.ItemHovered.BackColor = Color.FromArgb(40, UnreadTextColor);

            this.labelControl1.Appearance.ForeColor =
                this.labelControl1.AppearanceHovered.ForeColor =
                this.labelControl1.AppearancePressed.ForeColor =
                this.labelControl1.AppearanceDropDown.ForeColor =
                this.labelControl1.AppearanceDropDownHovered.ForeColor =
                this.labelControl1.AppearanceDropDownPressed.ForeColor = UnreadTextColor;
        }
        
        bool compact_Template = false;
        bool CompactTemplate {
            get { return compact_Template; }
            set {
                if(compact_Template == value) return;
                compact_Template = value;
                tileView1.RefreshData();
            }
        }
        private void tileView1_ItemCustomize(object sender, Views.Tile.TileViewItemCustomizeEventArgs e) {
            Message msg = tileView1.GetRow(e.RowHandle) as Message;
            if(msg != null) {
                if(msg.Read != 1) {
                    e.Item["Read"].Appearance.Normal.BackColor = UnreadTextColor;
                    e.Item["Date"].Appearance.Normal.ForeColor = UnreadTextColor;
                    e.Item["SubjectDisplayText"].Appearance.Normal.ForeColor = UnreadTextColor;
                    e.Item["SubjectDisplayText"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                }
            }
        }

        private void tileView1_ContextButtonCustomize(object sender, Views.Tile.TileViewContextButtonCustomizeEventArgs e) {
            Message msg = tileView1.GetRow(e.RowHandle) as Message;
            if(msg != null) {
                if(e.Item.Name == "cbExclamation") {
                    e.Item.AllowGlyphSkinning = DefaultBoolean.False;
                    e.Item.Visibility = msg.Priority == 2 ? ContextItemVisibility.Visible : ContextItemVisibility.Hidden;
                } else {
                    e.Item.AllowGlyphSkinning = DefaultBoolean.True;
                    e.Item.AppearanceHover.ForeColor = e.Item.AppearanceNormal.ForeColor = ((ITileControl)tileView1.GetViewInfo()).ViewInfo.AppearanceText.ForeColor;
                }
            } else {
                e.Item.Visibility = ContextItemVisibility.Hidden;
            }
        }

        private void tileView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            if(tileView1.FocusedRowHandle >= 0)
                CurrentMessage = tileView1.GetFocusedRow() as Message;
            else {
                CurrentMessage = null;
            }
        }
        Message current_Message;
        Message CurrentMessage {
            get { return current_Message; }
            set {
                if(current_Message == value) return;
                current_Message = value;
                office365MailViewer.ShowMessage(CurrentMessage);
            }
        }

        private void OnFilterItemCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if(!((BarCheckItem)e.Item).Checked)
                return;
            ((ITileControl)this.tileView1.GetViewInfo()).AnimateArrival = true;
            if(e.Item == this.bcFilterAll) {
                this.tileView1.ClearColumnsFilter();
            }
            else if(e.Item == this.bcFilterUnread) {
                this.tileView1.ActiveFilterCriteria = new BinaryOperator("Read", 0, BinaryOperatorType.Equal);
            }
            else if(e.Item == this.bcFilterToday) {
                this.tileView1.ActiveFilterCriteria = new BetweenOperator("Date", TutorialConstants.Today.Date, DateTime.Today.Date.AddHours(24));
            }
            else if(e.Item == this.bcFilterYesterday) {
                this.tileView1.ActiveFilterCriteria = new BetweenOperator("Date", TutorialConstants.Today.Date.AddHours(-24), DateTime.Today.Date);
            }
            else if(e.Item == this.bcFilterImportance) {
                this.tileView1.ActiveFilterCriteria = new BinaryOperator("Priority", 2, BinaryOperatorType.Equal);
            }
  
        }

        private void SortBy(string fieldName, ColumnSortOrder sort) {
            ((ITileControl)this.tileView1.GetViewInfo()).AnimateArrival = true;
            this.tileView1.SortInfo.Clear();
            this.tileView1.SortInfo.Add(new Columns.GridColumnSortInfo(this.tileView1.Columns[fieldName], sort));
        }

        private void OnSortItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            this.popupMenu1.BeginUpdate();
            try {
                if(e.Item.ImageIndex == -1) {
                    this.biSortDate.ImageIndex = -1;
                    this.biSortFrom.ImageIndex = -1;
                    this.biSortRead.ImageIndex = -1;
                    this.biSortSubject.ImageIndex = -1;
                    this.biSortImportance.ImageIndex = -1;
                    e.Item.ImageIndex = 0;
                }
                else {
                    e.Item.ImageIndex = e.Item.ImageIndex == 1 ? 0 : 1;
                }
                SortBy((string)e.Item.Tag, e.Item.ImageIndex == 1? ColumnSortOrder.Ascending: ColumnSortOrder.Descending);
            }
            finally {
                this.popupMenu1.EndUpdate();
            }
        }

        private void tileView1_CustomItemTemplate(object sender, Views.Tile.TileViewCustomItemTemplateEventArgs e) {
            if(CompactTemplate)
                e.Template = e.Templates["smallsize"];
        }

        private void toggleAutoHeight_Toggled(object sender, EventArgs e) {
            var elementPlainText = tileView1.TileTemplate[2];
            if(toggleAutoHeight.IsOn) {
                tileView1.TileRows[0].AutoHeight = true;
                tileView1.TileRows[1].AutoHeight = true;
                tileView1.TileRows[2].AutoHeight = true;
                elementPlainText.Appearance.Normal.TextOptions.WordWrap = WordWrap.Wrap;
            } else {
                tileView1.TileRows[0].AutoHeight = false;
                tileView1.TileRows[1].AutoHeight = false;
                tileView1.TileRows[2].AutoHeight = false;
                elementPlainText.Appearance.Normal.TextOptions.WordWrap = WordWrap.NoWrap;
            }
        }
    }
}

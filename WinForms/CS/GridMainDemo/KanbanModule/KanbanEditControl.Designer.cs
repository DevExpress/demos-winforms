namespace DevExpress.XtraGrid.Demos {
    partial class KanbanEditControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanbanEditControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridChecklist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTaskId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.memberTiles = new DevExpress.XtraEditors.TileControl();
            this.tileGroup = new DevExpress.XtraEditors.TileGroup();
            this.addMemberItem = new DevExpress.XtraEditors.TileItem();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChecklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.SetBoundPropertyName(this.layoutControl1, "");
            this.layoutControl1.Controls.Add(this.progressBarControl1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.memberTiles);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Controls.Add(this.memoEdit1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1162, 193, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(500, 464);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // progressBarControl1
            // 
            this.SetBoundPropertyName(this.progressBarControl1, "");
            this.progressBarControl1.Location = new System.Drawing.Point(12, 351);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(476, 16);
            this.progressBarControl1.StyleController = this.layoutControl1;
            this.progressBarControl1.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.SetBoundPropertyName(this.gridControl1, "");
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.gridControl1.Location = new System.Drawing.Point(12, 206);
            this.gridControl1.MainView = this.gridChecklist;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(476, 141);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridChecklist});
            // 
            // gridChecklist
            // 
            this.gridChecklist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTaskId,
            this.colCaption,
            this.colChecked});
            this.gridChecklist.GridControl = this.gridControl1;
            this.gridChecklist.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridChecklist.Name = "gridChecklist";
            this.gridChecklist.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridChecklist.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridChecklist.OptionsView.ShowColumnHeaders = false;
            this.gridChecklist.OptionsView.ShowGroupPanel = false;
            this.gridChecklist.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridChecklist.OptionsView.ShowIndicator = false;
            this.gridChecklist.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridChecklist.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridChecklist.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridChecklist.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridView1_CustomRowFilter);
            // 
            // colTaskId
            // 
            this.colTaskId.Caption = "gridColumn1";
            this.colTaskId.FieldName = "TaskID";
            this.colTaskId.Name = "colTaskId";
            // 
            // colCaption
            // 
            this.colCaption.Caption = "gridColumn1";
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 1;
            this.colCaption.Width = 442;
            // 
            // colChecked
            // 
            this.colChecked.Caption = "gridColumn1";
            this.colChecked.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.OptionsColumn.FixedWidth = true;
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 32;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckedChanged);
            // 
            // memberTiles
            // 
            this.memberTiles.AllowDrag = false;
            this.memberTiles.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.memberTiles.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.memberTiles.AppearanceItem.Normal.Options.UseBackColor = true;
            this.memberTiles.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.SetBoundPropertyName(this.memberTiles, "");
            this.memberTiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.memberTiles.Groups.Add(this.tileGroup);
            this.memberTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.memberTiles.IndentBetweenItems = 3;
            this.memberTiles.ItemSize = 30;
            this.memberTiles.Location = new System.Drawing.Point(12, 377);
            this.memberTiles.MaxId = 1;
            this.memberTiles.Name = "memberTiles";
            this.memberTiles.Padding = new System.Windows.Forms.Padding(0);
            this.memberTiles.RowCount = 1;
            this.memberTiles.Size = new System.Drawing.Size(476, 75);
            this.memberTiles.TabIndex = 7;
            this.memberTiles.Text = "tileControl1";
            this.memberTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileGroup
            // 
            this.tileGroup.Items.Add(this.addMemberItem);
            this.tileGroup.Name = "tileGroup";
            // 
            // addMemberItem
            // 
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            tileItemElement1.Text = "";
            this.addMemberItem.Elements.Add(tileItemElement1);
            this.addMemberItem.Id = 0;
            this.addMemberItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.addMemberItem.Name = "addMemberItem";
            this.addMemberItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.addMemberItem_ItemClick);
            // 
            // comboBoxEdit1
            // 
            this.SetBoundFieldName(this.comboBoxEdit1, "Label");
            this.SetBoundPropertyName(this.comboBoxEdit1, "EditValue");
            this.comboBoxEdit1.Location = new System.Drawing.Point(12, 66);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(476, 20);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 6;
            // 
            // memoEdit1
            // 
            this.SetBoundFieldName(this.memoEdit1, "Description");
            this.SetBoundPropertyName(this.memoEdit1, "EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(12, 112);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(476, 68);
            this.memoEdit1.StyleController = this.layoutControl1;
            this.memoEdit1.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.SetBoundFieldName(this.textEdit1, "Caption");
            this.SetBoundPropertyName(this.textEdit1, "EditValue");
            this.textEdit1.Location = new System.Drawing.Point(12, 20);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(476, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Gray;
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 464);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(480, 46);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem1.Text = "Title";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.memoEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 94);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(57, 94);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(480, 94);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem2.Text = "Description";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBoxEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(480, 46);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem3.Text = "Label";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.memberTiles;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 373);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 79);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(104, 79);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(480, 79);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Members";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(480, 161);
            this.layoutControlItem5.Text = "Checklist";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.progressBarControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 347);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(480, 26);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem6.TextVisible = false;
            // 
            // KanbanEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "KanbanEditControl";
            this.Size = new System.Drawing.Size(500, 464);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChecklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TileControl memberTiles;
        private DevExpress.XtraEditors.TileGroup tileGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TileItem addMemberItem;
        private GridControl gridControl1;
        private Views.Grid.GridView gridChecklist;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private Columns.GridColumn colTaskId;
        private Columns.GridColumn colCaption;
        private Columns.GridColumn colChecked;
        private XtraEditors.ProgressBarControl progressBarControl1;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;

    }
}

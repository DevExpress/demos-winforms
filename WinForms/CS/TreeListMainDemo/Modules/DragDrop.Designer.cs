using DevExpress.XtraEditors;
namespace DevExpress.XtraTreeList.Demos {
    partial class TreeListDragDrop {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            this.listBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBirthDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colHireDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPhone = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCity = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEmailAddress = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colJobTitle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colGroupName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPhoto = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.dragDropEvents2 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxControl
            // 
            this.behaviorManager1.SetBehaviors(this.listBoxControl, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraEditors.DragDropBehaviorSourceForListBox), true, true, true, true, this.dragDropEvents1)))});
            this.listBoxControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.listBoxControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl.ItemHeight = 80;
            this.listBoxControl.Location = new System.Drawing.Point(1, 0);
            this.listBoxControl.Name = "listBoxControl";
            this.listBoxControl.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxControl.Size = new System.Drawing.Size(220, 441);
            this.listBoxControl.TabIndex = 0;
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition1.Length.Value = 68D;
            tableColumnDefinition2.Length.Value = 164D;
            tableColumnDefinition2.PaddingLeft = 10;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            templatedItemElement1.FieldName = "Photo";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Text = "Photo";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.Appearance.Normal.FontSizeDelta = 1;
            templatedItemElement2.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            templatedItemElement2.Appearance.Normal.Options.UseFont = true;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = "FullName";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "FullName";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            templatedItemElement3.ColumnIndex = 1;
            templatedItemElement3.FieldName = "JobTitle";
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement3.RowIndex = 1;
            templatedItemElement3.Text = "JobTitle";
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Elements.Add(templatedItemElement3);
            itemTemplateBase1.Name = "CustomTemplate";
            tableRowDefinition1.PaddingBottom = 3;
            tableRowDefinition2.PaddingTop = 3;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            tableSpan1.RowSpan = 2;
            itemTemplateBase1.Spans.Add(tableSpan1);
            this.listBoxControl.Templates.Add(itemTemplateBase1);
            // 
            // treeList1
            // 
            this.behaviorManager1.SetBehaviors(this.treeList1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraTreeList.TreeListDragDropSource), true, true, true, true, this.dragDropEvents2)))});
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colFullName,
            this.colBirthDate,
            this.colHireDate,
            this.colPhone,
            this.colCity,
            this.colEmailAddress,
            this.colJobTitle,
            this.colGroupName,
            this.colPhoto});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsSelection.MultiSelect = true;
            this.treeList1.OptionsSelection.UseIndicatorForSelection = true;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.ParentFieldName = "ParentId";
            this.treeList1.RowHeight = 40;
            this.treeList1.Size = new System.Drawing.Size(392, 441);
            this.treeList1.TabIndex = 1;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 60;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 70;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.MaxWidth = 150;
            this.colBirthDate.MinWidth = 40;
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 5;
            this.colBirthDate.Width = 57;
            // 
            // colHireDate
            // 
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.MaxWidth = 150;
            this.colHireDate.MinWidth = 40;
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Visible = true;
            this.colHireDate.VisibleIndex = 4;
            this.colHireDate.Width = 65;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MaxWidth = 200;
            this.colPhone.MinWidth = 40;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 49;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Width = 48;
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.FieldName = "EmailAddress";
            this.colEmailAddress.MaxWidth = 300;
            this.colEmailAddress.MinWidth = 40;
            this.colEmailAddress.Name = "colEmailAddress";
            this.colEmailAddress.Visible = true;
            this.colEmailAddress.VisibleIndex = 2;
            this.colEmailAddress.Width = 58;
            // 
            // colJobTitle
            // 
            this.colJobTitle.FieldName = "JobTitle";
            this.colJobTitle.MinWidth = 40;
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.Visible = true;
            this.colJobTitle.VisibleIndex = 1;
            this.colJobTitle.Width = 83;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.MaxWidth = 60;
            this.colPhoto.MinWidth = 60;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 6;
            this.colPhoto.Width = 60;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.listBoxControl);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(392, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(221, 441);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // TreeListDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TreeListDragDrop";
            this.Size = new System.Drawing.Size(613, 441);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl listBoxControl;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBirthDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colHireDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPhone;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCity;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmailAddress;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colJobTitle;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGroupName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPhoto;
        private SidePanel sidePanel1;
        private Utils.DragDrop.DragDropEvents dragDropEvents1;
        private Utils.DragDrop.DragDropEvents dragDropEvents2;
    }
}

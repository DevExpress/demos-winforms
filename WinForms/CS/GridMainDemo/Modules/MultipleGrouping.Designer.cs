using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    partial class MultipleGrouping {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleGrouping));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colComplete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentComplete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.colTask = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbGroup = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // colComplete
            // 
            resources.ApplyResources(this.colComplete, "colComplete");
            this.colComplete.FieldName = "Complete";
            this.colComplete.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colComplete.ImageOptions.Alignment")));
            this.colComplete.ImageOptions.ImageIndex = ((int)(resources.GetObject("colComplete.ImageOptions.ImageIndex")));
            this.colComplete.Name = "colComplete";
            this.colComplete.OptionsColumn.AllowSize = false;
            this.colComplete.OptionsColumn.FixedWidth = true;
            this.colComplete.OptionsColumn.ShowCaption = false;
            this.colComplete.OptionsFilter.AllowFilter = false;
            // 
            // colPercentComplete
            // 
            resources.ApplyResources(this.colPercentComplete, "colPercentComplete");
            this.colPercentComplete.ColumnEdit = this.repositoryItemTextEdit1;
            this.colPercentComplete.FieldName = "PercentComplete";
            this.colPercentComplete.Name = "colPercentComplete";
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask");
            this.repositoryItemTextEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")));
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colTask,
            this.colCategory,
            this.colDueDate,
            this.colComplete,
            this.colPercentComplete,
            this.colNote});
            styleFormatCondition1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Gray;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colComplete;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colPercentComplete;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition2.Value1 = 0;
            styleFormatCondition2.Value2 = 100;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
            this.gridView1.Images = this.imageCollection1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            // 
            // colImage
            // 
            resources.ApplyResources(this.colImage, "colImage");
            this.colImage.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colImage.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colImage.ImageOptions.Alignment")));
            this.colImage.ImageOptions.ImageIndex = ((int)(resources.GetObject("colImage.ImageOptions.ImageIndex")));
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.AllowEdit = false;
            this.colImage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colImage.OptionsColumn.AllowIncrementalSearch = false;
            this.colImage.OptionsColumn.AllowMove = false;
            this.colImage.OptionsColumn.AllowSize = false;
            this.colImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colImage.OptionsColumn.FixedWidth = true;
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.OptionsColumn.ShowCaption = false;
            this.colImage.OptionsFilter.AllowFilter = false;
            this.colImage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colImage.Summary"))))});
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection1;
            // 
            // imageCollection1
            // 
            resources.ApplyResources(this.imageCollection1, "imageCollection1");
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "order.png");
            this.imageCollection1.Images.SetKeyName(1, "doc.png");
            this.imageCollection1.Images.SetKeyName(2, "check.png");
            // 
            // colTask
            // 
            resources.ApplyResources(this.colTask, "colTask");
            this.colTask.FieldName = "TaskName";
            this.colTask.Name = "colTask";
            // 
            // colCategory
            // 
            resources.ApplyResources(this.colCategory, "colCategory");
            this.colCategory.FieldName = "CategoryName";
            this.colCategory.Name = "colCategory";
            // 
            // colDueDate
            // 
            resources.ApplyResources(this.colDueDate, "colDueDate");
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colDueDate.Name = "colDueDate";
            // 
            // colNote
            // 
            resources.ApplyResources(this.colNote, "colNote");
            this.colNote.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemMemoExEdit1
            // 
            resources.ApplyResources(this.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1");
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemMemoExEdit1.Buttons"))))});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.sbGroup);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // sbGroup
            // 
            resources.ApplyResources(this.sbGroup, "sbGroup");
            this.sbGroup.Name = "sbGroup";
            this.sbGroup.Click += new System.EventHandler(this.sbGroup_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            // 
            // MultipleGrouping
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "MultipleGrouping";
            this.Load += new System.EventHandler(this.MultipleGrouping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTask;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colComplete;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentComplete;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbGroup;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Utils.ImageCollection imageCollection1;
    }
}

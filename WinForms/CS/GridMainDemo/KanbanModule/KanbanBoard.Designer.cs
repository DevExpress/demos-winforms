namespace DevExpress.XtraGrid.Demos {
    partial class KanbanBoard {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanbanBoard));
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colLabel = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCaption = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAttachedImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colProgress = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colStatus = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colMembers = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).BeginInit();
            this.SuspendLayout();
            // 
            // colLabel
            // 
            this.colLabel.Caption = "Label";
            this.colLabel.FieldName = "Label";
            this.colLabel.Name = "colLabel";
            this.colLabel.Visible = true;
            this.colLabel.VisibleIndex = 3;
            // 
            // colCaption
            // 
            this.colCaption.Caption = "Caption";
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 1;
            // 
            // colAttachedImage
            // 
            this.colAttachedImage.Caption = "AttachedImage";
            this.colAttachedImage.FieldName = "AttachedImage";
            this.colAttachedImage.Name = "colAttachedImage";
            this.colAttachedImage.Visible = true;
            this.colAttachedImage.VisibleIndex = 6;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colProgress
            // 
            this.colProgress.Caption = "Progress";
            this.colProgress.FieldName = "Progress";
            this.colProgress.Name = "colProgress";
            this.colProgress.Visible = true;
            this.colProgress.VisibleIndex = 5;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.tileView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 432);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView});
            // 
            // tileView
            // 
            this.tileView.Appearance.Group.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileView.Appearance.Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.tileView.Appearance.Group.Options.UseFont = true;
            this.tileView.Appearance.Group.Options.UseForeColor = true;
            this.tileView.Appearance.ItemNormal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileView.Appearance.ItemNormal.Options.UseFont = true;
            this.tileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStatus,
            this.colCaption,
            this.colMembers,
            this.colLabel,
            this.colDescription,
            this.colProgress,
            this.colAttachedImage});
            this.tileView.ColumnSet.GroupColumn = this.colStatus;
            this.tileView.GridControl = this.gridControl;
            this.tileView.Name = "tileView";
            this.tileView.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Tile.TileViewEditingMode.EditForm;
            this.tileView.OptionsDragDrop.AllowDrag = true;
            this.tileView.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.tileView.OptionsEditForm.PopupEditFormWidth = 500;
            this.tileView.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.tileView.OptionsFind.AllowFindPanel = false;
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton1.Id = new System.Guid("cb2e2e03-435e-4146-921e-8679c0fc7372");
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(16, 16);
            simpleContextButton1.Name = "btnAdd";
            simpleContextButton1.ToolTip = "Add a new card";
            simpleContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            this.tileView.OptionsKanban.GroupHeaderContextButtons.Add(simpleContextButton1);
            this.tileView.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.tileView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.Content;
            this.tileView.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileView.OptionsTiles.IndentBetweenGroups = 20;
            this.tileView.OptionsTiles.IndentBetweenItems = 5;
            this.tileView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(10);
            this.tileView.OptionsTiles.ItemSize = new System.Drawing.Size(290, 182);
            this.tileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tileView.OptionsTiles.Padding = new System.Windows.Forms.Padding(20, 30, 20, 15);
            this.tileView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStatus, DevExpress.Data.ColumnSortOrder.Ascending)});
            tableRowDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableRowDefinition1.Length.Value = 8D;
            tableRowDefinition2.AutoHeight = true;
            tableRowDefinition2.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableRowDefinition2.Length.Value = 40D;
            tableRowDefinition2.PaddingBottom = 10;
            tableRowDefinition3.AutoHeight = true;
            tableRowDefinition3.Length.Value = 41D;
            tableRowDefinition3.PaddingBottom = 10;
            tableRowDefinition4.AutoHeight = true;
            tableRowDefinition4.Length.Value = 41D;
            this.tileView.TileRows.Add(tableRowDefinition1);
            this.tileView.TileRows.Add(tableRowDefinition2);
            this.tileView.TileRows.Add(tableRowDefinition3);
            this.tileView.TileRows.Add(tableRowDefinition4);
            tileViewItemElement1.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            tileViewItemElement1.Appearance.Normal.Options.UseBackColor = true;
            tileViewItemElement1.Column = this.colLabel;
            tileViewItemElement1.Height = 4;
            tileViewItemElement1.Text = "colLabel";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement1.TextVisible = false;
            tileViewItemElement1.Width = 40;
            tileViewItemElement2.Column = this.colCaption;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colCaption";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement3.Column = this.colAttachedImage;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.SingleBorder;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "colAttachedImage";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.TextVisible = false;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            tileViewItemElement4.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            tileViewItemElement4.Name = "Attachment";
            tileViewItemElement4.RowIndex = 3;
            tileViewItemElement4.Text = "Attachment";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.TextVisible = false;
            tileViewItemElement5.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right;
            tileViewItemElement5.AnchorElementIndex = 3;
            tileViewItemElement5.AnchorIndent = 0;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            tileViewItemElement5.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            tileViewItemElement5.Name = "Description";
            tileViewItemElement5.RowIndex = 3;
            tileViewItemElement5.Text = "Description";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement5.TextVisible = false;
            tileViewItemElement6.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right;
            tileViewItemElement6.AnchorElementIndex = 4;
            tileViewItemElement6.Appearance.Normal.FontSizeDelta = 1;
            tileViewItemElement6.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileViewItemElement6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
            tileViewItemElement6.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            tileViewItemElement6.Name = "Progress";
            tileViewItemElement6.RowIndex = 3;
            tileViewItemElement6.Text = "10/10";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileView.TileTemplate.Add(tileViewItemElement1);
            this.tileView.TileTemplate.Add(tileViewItemElement2);
            this.tileView.TileTemplate.Add(tileViewItemElement3);
            this.tileView.TileTemplate.Add(tileViewItemElement4);
            this.tileView.TileTemplate.Add(tileViewItemElement5);
            this.tileView.TileTemplate.Add(tileViewItemElement6);
            this.tileView.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.tileView_ItemCustomize);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 0;
            // 
            // colMembers
            // 
            this.colMembers.Caption = "Members";
            this.colMembers.FieldName = "Members";
            this.colMembers.Name = "colMembers";
            this.colMembers.Visible = true;
            this.colMembers.VisibleIndex = 2;
            // 
            // KanbanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Name = "KanbanBoard";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl gridControl;
        private Views.Tile.TileView tileView;
        private Columns.TileViewColumn colStatus;
        private Columns.TileViewColumn colCaption;
        private Columns.TileViewColumn colMembers;
        private Columns.TileViewColumn colLabel;
        private Columns.TileViewColumn colDescription;
        private Columns.TileViewColumn colProgress;
        private Columns.TileViewColumn colAttachedImage;
    }
}

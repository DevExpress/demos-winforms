namespace DevExpress.HTML.Demos {
    partial class TileViewModule {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileViewModule));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tileViewTemplateCodeViewer1 = new DevExpress.HTML.Demos.TileViewTemplateCodeViewer();
            this.colDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSubjectDisplayText = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFrom = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colRead = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPlainText = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colInitials = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFlag = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colIsUnread = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colHasPhoto = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIsImportant = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.popupReply = new DevExpress.XtraEditors.HtmlContentPopup(this.components);
            this.popupDelete = new DevExpress.XtraEditors.HtmlContentPopup(this.components);
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupReply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tileViewTemplateCodeViewer1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(407, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(468, 432);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tileViewTemplateCodeViewer1
            // 
            this.tileViewTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileViewTemplateCodeViewer1.Location = new System.Drawing.Point(1, 0);
            this.tileViewTemplateCodeViewer1.Name = "tileViewTemplateCodeViewer1";
            this.tileViewTemplateCodeViewer1.Size = new System.Drawing.Size(467, 432);
            this.tileViewTemplateCodeViewer1.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "colDate";
            this.colDate.FieldName = "Date";
            this.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colSubjectDisplayText
            // 
            this.colSubjectDisplayText.Caption = "colSubjectDisplayText";
            this.colSubjectDisplayText.FieldName = "SubjectDisplayText";
            this.colSubjectDisplayText.Name = "colSubjectDisplayText";
            this.colSubjectDisplayText.Visible = true;
            this.colSubjectDisplayText.VisibleIndex = 4;
            // 
            // colFrom
            // 
            this.colFrom.Caption = "colFrom";
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 1;
            // 
            // colRead
            // 
            this.colRead.Caption = "colRead";
            this.colRead.FieldName = "Read";
            this.colRead.Name = "colRead";
            this.colRead.Visible = true;
            this.colRead.VisibleIndex = 5;
            // 
            // colPlainText
            // 
            this.colPlainText.Caption = "colPlainText";
            this.colPlainText.FieldName = "PlainText";
            this.colPlainText.Name = "colPlainText";
            this.colPlainText.Visible = true;
            this.colPlainText.VisibleIndex = 3;
            // 
            // colPriority
            // 
            this.colPriority.Caption = "colPriority";
            this.colPriority.FieldName = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.Visible = true;
            this.colPriority.VisibleIndex = 6;
            // 
            // colSubject
            // 
            this.colSubject.Caption = "colSubject";
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 2;
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = "colPhoto";
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 7;
            // 
            // colInitials
            // 
            this.colInitials.Caption = "colInitials";
            this.colInitials.FieldName = "FromInitials";
            this.colInitials.Name = "colInitials";
            this.colInitials.Visible = true;
            this.colInitials.VisibleIndex = 8;
            // 
            // colFlag
            // 
            this.colFlag.Caption = "colFlag";
            this.colFlag.FieldName = "Flagged";
            this.colFlag.Name = "colFlag";
            this.colFlag.Visible = true;
            this.colFlag.VisibleIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(407, 432);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Appearance.Group.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileView1.Appearance.Group.Options.UseFont = true;
            this.tileView1.Appearance.ItemNormal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileView1.Appearance.ItemNormal.Options.UseFont = true;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colFrom,
            this.colSubject,
            this.colPlainText,
            this.colSubjectDisplayText,
            this.colRead,
            this.colPriority,
            this.colPhoto,
            this.colInitials,
            this.colFlag,
            this.colIsUnread,
            this.colHasPhoto,
            this.colIsImportant});
            this.tileView1.ColumnSet.GroupColumn = this.colDate;
            this.tileView1.FocusBorderColor = System.Drawing.Color.Transparent;
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.HtmlImages = this.svgImageCollection1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView1.OptionsTiles.AllowPressAnimation = false;
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.tileView1.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0, 8, 12, 8);
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(560, 84);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar;
            this.tileView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tileView1.TileHtmlTemplate.Styles = resources.GetString("tileView1.TileHtmlTemplate.Styles");
            this.tileView1.TileHtmlTemplate.Tag = "Tile Template";
            this.tileView1.TileHtmlTemplate.Template = resources.GetString("tileView1.TileHtmlTemplate.Template");
            // 
            // colIsUnread
            // 
            this.colIsUnread.Caption = "IsUnread";
            this.colIsUnread.FieldName = "IsUnread";
            this.colIsUnread.Name = "colIsUnread";
            this.colIsUnread.Visible = true;
            this.colIsUnread.VisibleIndex = 10;
            // 
            // colHasPhoto
            // 
            this.colHasPhoto.Caption = "HasPhoto";
            this.colHasPhoto.FieldName = "HasPhoto";
            this.colHasPhoto.Name = "colHasPhoto";
            this.colHasPhoto.Visible = true;
            this.colHasPhoto.VisibleIndex = 11;
            // 
            // colIsImportant
            // 
            this.colIsImportant.Caption = "IsImportant";
            this.colIsImportant.FieldName = "IsImportant";
            this.colIsImportant.Name = "colIsImportant";
            this.colIsImportant.Visible = true;
            this.colIsImportant.VisibleIndex = 12;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("important", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.important"))));
            this.svgImageCollection1.Add("flag", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.flag"))));
            this.svgImageCollection1.Add("delete", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.delete"))));
            this.svgImageCollection1.Add("reply", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.reply"))));
            // 
            // popupReply
            // 
            this.popupReply.HtmlTemplate.Styles = resources.GetString("popupReply.HtmlTemplate.Styles");
            this.popupReply.HtmlTemplate.Template = "<div class=\"container\">\r\n    <div class=\"shadow\">$Reply to message from {From}</d" +
    "iv>\r\n</div>";
            // 
            // popupDelete
            // 
            this.popupDelete.HtmlTemplate.Styles = resources.GetString("popupDelete.HtmlTemplate.Styles");
            this.popupDelete.HtmlTemplate.Template = "<div class=\"container\">\r\n    <div class=\"shadow\">$Delete message from {From}</div" +
    ">\r\n</div>";
            // 
            // TileViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TileViewModule";
            this.Size = new System.Drawing.Size(875, 432);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupReply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TileViewTemplateCodeViewer tileViewTemplateCodeViewer1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Tile.TileView tileView1;

        private XtraGrid.Columns.TileViewColumn colDate;
        private XtraGrid.Columns.TileViewColumn colFrom;
        private XtraGrid.Columns.TileViewColumn colSubject;
        private XtraGrid.Columns.TileViewColumn colPlainText;
        private XtraGrid.Columns.TileViewColumn colSubjectDisplayText;
        private XtraGrid.Columns.TileViewColumn colRead;
        private XtraGrid.Columns.TileViewColumn colPriority;
        private XtraGrid.Columns.TileViewColumn colPhoto;
        private XtraGrid.Columns.TileViewColumn colInitials;
        private XtraGrid.Columns.TileViewColumn colFlag;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraEditors.HtmlContentPopup popupReply;
        private XtraEditors.HtmlContentPopup popupDelete;
        private XtraGrid.Columns.TileViewColumn colIsUnread;
        private XtraGrid.Columns.TileViewColumn colHasPhoto;
        private XtraGrid.Columns.TileViewColumn colIsImportant;
    }
}

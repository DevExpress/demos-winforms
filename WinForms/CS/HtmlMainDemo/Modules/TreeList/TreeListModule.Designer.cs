namespace DevExpress.HTML.Demos {
    partial class TreeListModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeListModule));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.treeListTemplateCodeViewer1 = new DevExpress.HTML.Demos.TreeListTemplateCodeViewer();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.dateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.isMyCommentColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.editingTextColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.hasLikesColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.editingCommentTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.replyingCommentTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.commentTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.typingBox = new DevExpress.XtraEditors.HtmlContentControl();
            this.messageEdit = new DevExpress.XtraEditors.MemoEdit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingBox)).BeginInit();
            this.typingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.treeListTemplateCodeViewer1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(513, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(468, 432);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // treeListTemplateCodeViewer1
            // 
            this.treeListTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListTemplateCodeViewer1.Location = new System.Drawing.Point(1, 0);
            this.treeListTemplateCodeViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeListTemplateCodeViewer1.Name = "treeListTemplateCodeViewer1";
            this.treeListTemplateCodeViewer1.Size = new System.Drawing.Size(467, 432);
            this.treeListTemplateCodeViewer1.TabIndex = 0;
            // 
            // treeList1
            // 
            this.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
            this.treeList1.Appearance.Empty.Options.UseBackColor = true;
            this.treeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.Silver;
            this.treeList1.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList1.ChildListFieldName = "Replies";
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.dateColumn,
            this.isMyCommentColumn,
            this.editingTextColumn,
            this.hasLikesColumn});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.EnableDynamicLoading = false;
            this.treeList1.HtmlImages = this.svgImageCollection1;
            this.treeList1.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.editingCommentTemplate,
            this.replyingCommentTemplate});
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.NodeHtmlTemplate.Styles = resources.GetString("treeList1.NodeHtmlTemplate.Styles");
            this.treeList1.NodeHtmlTemplate.Tag = "Node Template";
            this.treeList1.NodeHtmlTemplate.Template = resources.GetString("treeList1.NodeHtmlTemplate.Template");
            this.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsView.ShowButtons = false;
            this.treeList1.OptionsView.ShowRoot = false;
            this.treeList1.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.commentTextEdit});
            this.treeList1.Size = new System.Drawing.Size(513, 389);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeLevelWidth = 24;
            this.treeList1.QueryNodeTemplate += new DevExpress.XtraTreeList.QueryNodeHtmlTemplateEventHandler(this.treeList1_QueryNodeTemplate);
            this.treeList1.CustomUnboundColumnData += new DevExpress.XtraTreeList.CustomColumnDataEventHandler(this.treeList1_CustomUnboundColumnData);
            // 
            // dateColumn
            // 
            this.dateColumn.Caption = "Date";
            this.dateColumn.FieldName = "Date";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.dateColumn.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.dateColumn.Visible = true;
            this.dateColumn.VisibleIndex = 0;
            // 
            // isMyCommentColumn
            // 
            this.isMyCommentColumn.FieldName = "IsMyComment";
            this.isMyCommentColumn.Name = "isMyCommentColumn";
            this.isMyCommentColumn.UnboundDataType = typeof(bool);
            // 
            // editingTextColumn
            // 
            this.editingTextColumn.FieldName = "EditingText";
            this.editingTextColumn.Name = "editingTextColumn";
            this.editingTextColumn.UnboundDataType = typeof(string);
            // 
            // hasLikesColumn
            // 
            this.hasLikesColumn.FieldName = "HasLikes";
            this.hasLikesColumn.MinWidth = 16;
            this.hasLikesColumn.Name = "hasLikesColumn";
            this.hasLikesColumn.UnboundDataType = typeof(bool);
            this.hasLikesColumn.Visible = true;
            this.hasLikesColumn.VisibleIndex = 1;
            this.hasLikesColumn.Width = 50;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("likeIcon", "image://svgimages/icon builder/shopping_favorites.svg");
            this.svgImageCollection1.Add("replyIcon", "image://svgimages/icon builder/actions_arrow5downright.svg");
            this.svgImageCollection1.Add("editIcon", "image://svgimages/icon builder/actions_edit.svg");
            this.svgImageCollection1.Add("applyIcon", "image://svgimages/icon builder/actions_check.svg");
            this.svgImageCollection1.Add("cancelIcon", "image://svgimages/diagramicons/del.svg");
            this.svgImageCollection1.Add("reply2Icon", "image://svgimages/dashboards/drilldown.svg");
            this.svgImageCollection1.Add("sendIcon", "image://svgimages/icon builder/actions_arrow4right.svg");
            this.svgImageCollection1.Add("rightIcon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.rightIcon"))));
            this.svgImageCollection1.Add("downIcon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.downIcon"))));
            // 
            // editingCommentTemplate
            // 
            this.editingCommentTemplate.Name = "editingCommentTemplate";
            this.editingCommentTemplate.Styles = resources.GetString("editingCommentTemplate.Styles");
            this.editingCommentTemplate.Tag = "Editing State Template";
            this.editingCommentTemplate.Template = resources.GetString("editingCommentTemplate.Template");
            // 
            // replyingCommentTemplate
            // 
            this.replyingCommentTemplate.Name = "replyingCommentTemplate";
            this.replyingCommentTemplate.Styles = resources.GetString("replyingCommentTemplate.Styles");
            this.replyingCommentTemplate.Tag = "Replying State Template";
            this.replyingCommentTemplate.Template = resources.GetString("replyingCommentTemplate.Template");
            // 
            // commentTextEdit
            // 
            this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.commentTextEdit.Name = "commentTextEdit";
            this.commentTextEdit.NullText = "Type a new message";
            // 
            // typingBox
            // 
            this.typingBox.AutoScroll = false;
            this.typingBox.Controls.Add(this.messageEdit);
            this.typingBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.typingBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.typingBox.HtmlImages = this.svgImageCollection1;
            this.typingBox.HtmlTemplate.Styles = resources.GetString("typingBox.HtmlTemplate.Styles");
            this.typingBox.HtmlTemplate.Template = "<div class=\'typingbox\'>\r\n    <input name=\"messageEdit\" class=\"message\" />\r\n    <d" +
    "iv class=\'separator\'></div>\r\n    <img id=\"btnSend\" src=\'sendIcon\' class=\'button\'" +
    " onclick=\"SendClick\" />\r\n</div>";
            this.typingBox.Location = new System.Drawing.Point(0, 389);
            this.typingBox.Name = "typingBox";
            this.typingBox.Size = new System.Drawing.Size(513, 43);
            this.typingBox.TabIndex = 2;
            // 
            // messageEdit
            // 
            this.messageEdit.Location = new System.Drawing.Point(12, 15);
            this.messageEdit.Name = "messageEdit";
            this.messageEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.messageEdit.Properties.NullValuePrompt = "Type your message here...";
            this.messageEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageEdit.Size = new System.Drawing.Size(441, 14);
            this.messageEdit.TabIndex = 1;
            // 
            // TreeListModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.typingBox);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TreeListModule";
            this.Size = new System.Drawing.Size(981, 432);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingBox)).EndInit();
            this.typingBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeListTemplateCodeViewer treeListTemplateCodeViewer1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraTreeList.TreeList treeList1;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraTreeList.Columns.TreeListColumn isMyCommentColumn;
        private XtraTreeList.Columns.TreeListColumn dateColumn;
        private XtraTreeList.Columns.TreeListColumn editingTextColumn;
        private Utils.Html.HtmlTemplate editingCommentTemplate;
        private XtraEditors.Repository.RepositoryItemMemoEdit commentTextEdit;
        private Utils.Html.HtmlTemplate replyingCommentTemplate;
        private XtraTreeList.Columns.TreeListColumn hasLikesColumn;
        private XtraEditors.HtmlContentControl typingBox;
        private XtraEditors.MemoEdit messageEdit;
    }
}

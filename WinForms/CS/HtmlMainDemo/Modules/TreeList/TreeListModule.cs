using System;
using System.ComponentModel;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers.Data;
using DevExpress.HTML.Demos.Modules.TreeList;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.HTML.Demos {
    public partial class TreeListModule : TutorialControlBase {
        EditingComment editingComment;
        BindingList<Comment> dataSource;

        public TreeListModule() {
            InitializeComponent();
            treeListTemplateCodeViewer1.Fill(treeList1);
            dataSource = TreeListData.GenerateCommentsData();
            treeList1.DataSource = dataSource;
            
            var autoHeightEdit = messageEdit as IAutoHeightControlEx;
            autoHeightEdit.AutoHeightEnabled = true;
            autoHeightEdit.HeightChanged += OnMessageHeightChanged;
        }
        protected override int TakeScreenDelay => 300;
        void ExpandCollapseClick(object sender, DxHtmlElementMouseEventArgs e) {
            var node = e.SourceItem as TreeListNode;
            if(node.Expanded)
                node.Collapse(true);
            else
                node.Expand(true);
        }

        void EditClick(object sender, DxHtmlElementMouseEventArgs e) {
            var node = e.SourceItem as TreeListNode;
            StartCommentEditor(node, CommentEditingMode.Editing);
        }

        void ReplyClick(object sender, DxHtmlElementMouseEventArgs e) {
            var node = e.SourceItem as TreeListNode;
            StartCommentEditor(node, CommentEditingMode.Replying);
        }

        void CancelClick(object sender, DxHtmlElementMouseEventArgs e) {
            EndCommentEditor(false);
        }

        void ApplyClick(object sender, DxHtmlElementMouseEventArgs e) {
            EndCommentEditor(true);
        }

        void LikeClick(object sender, DxHtmlElementMouseEventArgs e) {
            var node = e.SourceItem as TreeListNode;
            var comment = treeList1.GetRow(node.Id) as Comment;
            comment.ToggleLike();
        }

        void SendClick(object sender, DxHtmlElementMouseEventArgs e) {
            var comment = TreeListData.CurrentUser.CreateComment(messageEdit.Text);
            dataSource.Add(comment);            
            messageEdit.Clear();
            TreeListData.MakeCommentNodeVisible(comment, treeList1.Nodes);
        }

        void StartCommentEditor(TreeListNode node, CommentEditingMode editingMode) {
            EndCommentEditor(false);
            var comment = treeList1.GetRow(node.Id) as Comment;
            editingComment = new EditingComment(node, comment, editingMode);
            treeList1.RefreshNode(node);
            if(node.NextVisibleNode == null)
                treeList1.MakeNodeVisible(node);
            treeList1.ShowEditor("EditingText");
        }

        void EndCommentEditor(bool applyChanges) {
            if(editingComment != null) {
                treeList1.BeginUpdate();
                var editedComment = editingComment;
                editingComment = null;
                treeList1.RefreshNode(editedComment.Node);
                if(applyChanges)
                    editedComment.Apply();                
                treeList1.EndUpdate();
            }
        }

        void OnMessageHeightChanged(object sender, EventArgs e) {
            var contentSize = typingBox.GetContentSize();
            typingBox.Height = Math.Max(30, contentSize.Height);
        }

        private void treeList1_CustomUnboundColumnData(object sender, TreeListCustomColumnDataEventArgs e) {
            if(e.Column.FieldName == "IsMyComment") {
                Comment comment = e.Row as Comment;
                e.Value = comment.Author == TreeListData.CurrentUser.Name;
            }
            else if(e.Column.FieldName == "HasLikes") {
                Comment comment = e.Row as Comment;
                e.Value = comment.Likes > 0;
            }
            else if(e.Column.FieldName == "EditingText") {
                if(editingComment != null) {
                    if(e.IsGetData)
                        e.Value = editingComment.Text;
                    else {
                        editingComment.Text = Convert.ToString(e.Value);
                    }
                }
            }
        }

        private void treeList1_QueryNodeTemplate(object sender, QueryNodeTemplateEventArgs e) {
            var comment = treeList1.GetRow(e.Node.Id);
            if(editingComment != null && editingComment.Comment == comment) {
                if(editingComment.Mode == CommentEditingMode.Editing)
                    e.Template.Assign(editingCommentTemplate);
                else
                    e.Template.Assign(replyingCommentTemplate);
            }
        }
    }
}

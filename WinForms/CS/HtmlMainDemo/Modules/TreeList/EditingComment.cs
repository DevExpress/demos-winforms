using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers.Data;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.HTML.Demos.Modules.TreeList {
    public enum CommentEditingMode {
        Editing,
        Replying
    }

    public class EditingComment {
        public TreeListNode Node { get; }
        public Comment Comment { get; }
        public CommentEditingMode Mode { get; }
        public string Text { get; set; }

        public EditingComment(TreeListNode node, Comment comment, CommentEditingMode mode) {
            Node = node;
            Comment = comment;
            Mode = mode;
            if(mode == CommentEditingMode.Editing)
                Text = comment.Text;
        }

        public void Apply() {
            if(Mode == CommentEditingMode.Editing) {
                Comment.UpdateText(Text);
            }
            else {
                if(!string.IsNullOrEmpty(Text)) {
                    var reply = new Comment(TreeListData.CurrentUser.Name, TreeListData.CurrentUser.Photo, Text, TutorialConstants.Now);
                    Comment.AddReply(reply);
                    TreeListData.MakeCommentNodeVisible(reply, Node.Nodes);
                }
            }

        }
    }
}

namespace DevExpress.ChatClient.Views {
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.ChatClient.ViewModels;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraGrid.Views.Items;

    public partial class MessagesView : XtraUserControl {
        public MessagesView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeStyles();
                InitializeBindings();
                InitializeMessageEdit();
            }
        }
        void InitializeStyles() {
            Styles.Toolbar.Apply(toolbarPanel);
            Styles.TypingBox.Apply(typingBox);
            Styles.NoMessages.Apply(messagesItemsView.EmptyViewHtmlTemplate);
            messagesItemsView.HtmlImages = ChatClient.SvgImages;
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<MessagesViewModel>();
            
            fluent.SetBinding(gridControl, gc => gc.DataSource, x => x.Messages);
            fluent.SetBinding(toolbarPanel, tp => tp.DataContext, x => x.Contact);
            fluent.SetBinding(messagesItemsView, mv => mv.FocusedRowObject, x => x.SelectedMessage);
            fluent.SetBinding(messagesItemsView, mv => mv.SelectedText, x => x.SelectedText);
            fluent.KeyToCommand(messagesItemsView, Keys.Control | Keys.C, x => x.CopySelectedText);
            
            fluent.SetTrigger(x => x.Messages, contacts => messagesItemsView.RefreshData());
            fluent.SetTrigger(x => x.UpdatedMessageIndices, indices => messagesItemsView.RefreshData(indices));
            fluent.SetTrigger(x => x.Contact, contact => messagesItemsView.MoveLast());
            
            fluent.WithEvent(this, nameof(HandleCreated))
                .EventToCommand(x => x.OnCreate);
            fluent.WithEvent(this, nameof(HandleDestroyed))
                .EventToCommand(x => x.OnDestroy);
            
            fluent.BindCommandToElement(toolbarPanel, "btnPhoneCall", x => x.PhoneCall);
            fluent.BindCommandToElement(toolbarPanel, "btnVideoCall", x => x.VideoCall);
            fluent.BindCommandToElement(toolbarPanel, "btnContact", x => x.ShowContact);
            fluent.BindCommandToElement(toolbarPanel, "btnUser", x => x.ShowUser);
            
            fluent.BindCommandToElement(typingBox, "btnSend", x => x.SendMessage);
            fluent.WithKey(messageEdit, Keys.Control | Keys.Enter)
                .KeyToCommand(x => x.SendMessage);
            
            fluent.SetObjectDataSourceBinding(messageBindingSource, x => x.Update);
            
            fluent.BindCommandToElement(messageMenuPopup, "miLike", x => x.LikeMessage);
            fluent.BindCommandToElement(messageMenuPopup, "miCopy", x => x.CopyMessage);
            fluent.BindCommandToElement(messageMenuPopup, "miDelete", x => x.DeleteMessage);
            fluent.BindCommandToElement(messageMenuPopup, "miCopyText", x => x.CopyMessageText);
            fluent.BindCommandToElement(messageMenuPopup, "miCopySelectedText", x => x.CopySelectedText);
            
            messagesItemsView.ElementMouseClick += OnMessagesViewElementMouseClick;
            messagesItemsView.TopRowPixelChanged += OnMessagesTopRowPixelChanged;
            messageMenuPopup.Hidden += OnMessageMenuPopupHidden;
        }
        Utils.Html.CssStyle activeMoreStyle;
        void OnMessagesViewElementMouseClick(object sender, ItemsViewHtmlElementMouseEventArgs e) {
            if(e.ElementId == "btnMore") {
                activeMoreStyle = e.Element.Style;
                activeMoreRowHandle = e.RowHandle;
                activeMoreStyle.SetProperty("opacity", "1");
            }
            if(e.ElementId == "btnMore" || e.ElementId == "btnLike") {
                ShowMenu(e);
            }
            else if(e.Button == MouseButtons.Right) {
                if(!string.IsNullOrEmpty(messagesItemsView.SelectedText))
                    ShowContextMenu(e);
            }
        }
        void ShowMenu(ItemsViewHtmlElementMouseEventArgs e) {
            Styles.Menu.Apply(messageMenuPopup);
            var size = ScaleDPI.ScaleSize(new Size(212, 180));
            var location = new Point(
                e.Bounds.X - (size.Width - e.Bounds.Width) / 2,
                e.Bounds.Y - size.Height + ScaleDPI.ScaleVertical(8));
            messageMenuPopup.Show(gridControl, gridControl.RectangleToScreen(new Rectangle(location, size)));
        }
        void ShowContextMenu(ItemsViewHtmlElementMouseEventArgs e) {
            Styles.ContextMenu.Apply(messageMenuPopup);
            var size = ScaleDPI.ScaleSize(new Size(212, 100));
            var location = new Point(e.X - size.Width / 2, e.Y - size.Height + ScaleDPI.ScaleVertical(8));
            Rectangle screenRect = gridControl.RectangleToScreen(new Rectangle(location, size));
            messageMenuPopup.Show(gridControl, screenRect);
        }
        void OnMessagesTopRowPixelChanged(object sender, EventArgs e) {
            messageMenuPopup.Hide();
        }
        int? activeMoreRowHandle;
        void OnMessageMenuPopupHidden(object sender, EventArgs e) {
            activeMoreStyle = null;
            if(activeMoreRowHandle.HasValue)
                messagesItemsView.RefreshRow(activeMoreRowHandle.Value);
            activeMoreRowHandle = null;
        }
        void InitializeMessageEdit() {
            var autoHeightEdit = messageEdit as IAutoHeightControlEx;
            autoHeightEdit.AutoHeightEnabled = true;
            autoHeightEdit.HeightChanged += OnMessageHeightChanged;
        }
        void OnMessageHeightChanged(object sender, EventArgs e) {
            var contentSize = typingBox.GetContentSize();
            typingBox.Height = contentSize.Height;
        }
        void OnQueryItemTemplate(object sender, QueryItemTemplateEventArgs e) {
            var message = e.Row as DevAV.Chat.Model.Message;
            if(message == null)
                return;
            if(message.IsOwnMessage)
                Styles.MyMessage.Apply(e.Template);
            else
                Styles.Message.Apply(e.Template);
            var fluent = mvvmContext.OfType<MessagesViewModel>();
            fluent.ViewModel.OnMessageRead(message);
        }
        void OnCustomizeItem(object sender, CustomizeItemArgs e) {
            var message = e.Row as DevAV.Chat.Model.Message;
            if(message == null)
                return;
            if(message.IsLiked) {
                var btnLike = e.Element.FindElementById("btnLike");
                var btnMore = e.Element.FindElementById("btnMore");
                if(btnLike != null && btnMore != null) {
                    btnLike.Hidden = false;
                    btnMore.Hidden = true;
                }
            }
            if(message.IsFirstMessageOfBlock)
                return;
            if(!message.IsOwnMessage) {
                var avatar = e.Element.FindElementById("avatar");
                if(avatar != null)
                    avatar.Style.SetVisibility(Utils.Html.Internal.CssVisibility.Hidden);
            }
            var name = e.Element.FindElementById("name");
            if(name != null)
                name.Hidden = true;
            if(!message.IsFirstMessageOfReply) {
                var sent = e.Element.FindElementById("sent");
                if(sent != null)
                    sent.Hidden = true;
            }
        }
        sealed class Styles {
            public static Style Toolbar = new ToolbarStyle();
            public static Style Message = new MessageStyle();
            public static Style MyMessage = new MyMessageStyle();
            public static Style NoMessages = new NoMessagesStyle();
            public static Style Menu = new MenuStyle();
            public static Style ContextMenu = new ContextMenuStyle();
            public static Style TypingBox = new TypingBoxStyle();
            
            sealed class ToolbarStyle : Style { }
            sealed class MessageStyle : Style { }
            sealed class MyMessageStyle : Style { }
            sealed class MenuStyle : Style { }
            sealed class ContextMenuStyle: Style { }
            sealed class TypingBoxStyle : Style { }
            sealed class NoMessagesStyle : Style { }
        }
    }
}

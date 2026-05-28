using System;
using DevExpress.Data.Filtering;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.WindowsMailClient.Win.Data;
using DevExpress.WindowsMailClient.Win.Model;
using DevExpress.WindowsMailClient.Win.Modules;
using DevExpress.WindowsMailClient.Win.Properties;
using DevExpress.WindowsMailClient.Win.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.WindowsMailClient.Win.ViewModels {
    public class MailViewerViewModel {
        public event EventHandler MessageDeleted;
        public event EventHandler MessageChanged;
        public event EventHandler FilterChanged;
        public event EventHandler SortInfoChanged;
        public event EventHandler MessageFlagged;
        public virtual LayoutVisibility LayoutHeaderVisibility { get; set; }
        public virtual LayoutVisibility FocusedItemVisibility { get; set; }
        public virtual LayoutVisibility OtherItemVisibility { get; set; }
        public virtual GridColumnSortInfo SortInfo { get; set; }
        protected void OnSortInfoChanged() {
            AnimateArrival = true;
            if(SortInfoChanged != null)
                SortInfoChanged(this, EventArgs.Empty);
        }
        public virtual string LabelText { get; set; }
        public virtual MailType CurrentMailType { get; set; }
        protected void OnCurrentMailTypeChanging(MailType currentMailType) {
            switch(currentMailType) {
                case MailType.Outbox:
                    ChangeSettings("Outbox",currentMailType);
                    break;
                case MailType.Archive:
                    ChangeSettings("Archive", currentMailType);
                    break;
                case MailType.Archive1:
                    ChangeSettings("Archive1", currentMailType);
                    break;
                case MailType.Clutter:
                    ChangeSettings("Clutter", currentMailType);
                    break;
                case MailType.Sent:
                    ChangeSettings("Sent Items", currentMailType);
                    break;
                case MailType.Draft:
                    ChangeSettings("Drafts", currentMailType);
                    break;
                case MailType.Deleted:
                    ChangeSettings("Deleted", currentMailType);
                    break;
                default:
                    RefreshFilter(CurrentFilterType);
                    LabelText = "Inbox";
                    UpdateLabelsVisibility();
                    break;
            }
        }
        void UpdateLabelsVisibility() {
            LayoutHeaderVisibility = ShowFocusedOtherFilter ? LayoutVisibility.Never : LayoutVisibility.Always;
            FocusedItemVisibility = ShowFocusedOtherFilter ? LayoutVisibility.Always : LayoutVisibility.Never;
            OtherItemVisibility = ShowFocusedOtherFilter ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
        void ChangeSettings(string text, MailType currentMailType) {
            LabelText = text;
            LayoutHeaderVisibility = LayoutVisibility.Always;
            FocusedItemVisibility = LayoutVisibility.Never;
            OtherItemVisibility = LayoutVisibility.Never;
            ActiveFilter = new BinaryOperator("MailType", currentMailType, BinaryOperatorType.Equal);
            if(FilterChanged != null)
                FilterChanged(this, EventArgs.Empty);
        }
        public virtual CriteriaOperator ActiveFilter { get; set; }
        public virtual FilterType CurrentFilterType { get; set; }
        protected void OnCurrentFilterTypeChanging(FilterType currentFilterType) {
            RefreshFilter(currentFilterType);
        }
        void RefreshFilter(FilterType currentFilterType) {
            var inboxOperator = new BinaryOperator("MailType", MailType.Inbox, BinaryOperatorType.Equal);
            if(currentFilterType == FilterType.Other)
                ActiveFilter = new BinaryOperator(new BinaryOperator("Priority", 1, BinaryOperatorType.Equal), inboxOperator, BinaryOperatorType.BitwiseAnd);
            else if(currentFilterType == FilterType.Focused)
                ActiveFilter = new BinaryOperator(new BinaryOperator("Priority", 2, BinaryOperatorType.Equal), inboxOperator, BinaryOperatorType.BitwiseAnd);
            else ActiveFilter = new BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal);
            if(FilterChanged != null)
                FilterChanged(this, EventArgs.Empty);
        }
        public virtual bool AnimateArrival { get; set; }
        public virtual Message CurrentMessage {
            get;
            set;
        }
        protected void OnCurrentMessageChanged() {
            if(MessageChanged != null)
                MessageChanged(this, EventArgs.Empty);
        }
        #region Commands

        [Command]
        public void Sort(SortInfo info) {
            SortInfo = new GridColumnSortInfo(info.Column, info.Order);
        }
        [Command]
        public void SetFilterImportance() {
            AnimateArrival = true;
            if(!ReferenceEquals(ActiveFilter, null))
                ActiveFilter = new BinaryOperator(new BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), new BinaryOperator("Priority", 2, BinaryOperatorType.Equal), BinaryOperatorType.BitwiseAnd);
            else ActiveFilter = new BinaryOperator("Priority", 2, BinaryOperatorType.Equal);
        }
        [Command]
        public void SetFilterType(FilterType type) {
            CurrentFilterType = type;
        }
        [Command]
        public void SetFilterYesterday() {
            AnimateArrival = true;
            if(!ReferenceEquals(ActiveFilter, null))
                ActiveFilter = new BinaryOperator(new BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), new BetweenOperator("Date", DateTime.Today.Date.AddHours(-24), DateTime.Today.Date), BinaryOperatorType.BitwiseAnd);
            else ActiveFilter = new BetweenOperator("Date", DateTime.Today.Date.AddHours(-24), DateTime.Today.Date);
        }
        [Command]
        public void SetFilterToday() {
            AnimateArrival = true;
            if(!ReferenceEquals(ActiveFilter, null))
                ActiveFilter = new BinaryOperator(new BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), new BetweenOperator("Date", DateTime.Today.Date, DateTime.Today.Date.AddHours(24)), BinaryOperatorType.BitwiseAnd);
            else ActiveFilter = new BetweenOperator("Date", DateTime.Today.Date, DateTime.Today.Date.AddHours(24));
        }
        [Command]
        public void SetFilterUnread() {
            AnimateArrival = true;
            if(!ReferenceEquals(ActiveFilter, null))
                ActiveFilter = new BinaryOperator(new BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), new BinaryOperator("Read", 0, BinaryOperatorType.Equal), BinaryOperatorType.BitwiseAnd);
            else ActiveFilter = new BinaryOperator("Read", 0, BinaryOperatorType.Equal);
        }
        [Command]
        public void SetFilterAll() {
            AnimateArrival = true;
            if(CurrentMailType == MailType.Inbox)
                RefreshFilter(CurrentFilterType);
            else ActiveFilter = new BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal);
        }
        [Command]
        public void SendMessage(Message message) {
            Messenger.Default.Send<Message>(message);
        }
        [Command]
        public void DeleteMessage(Message selectedMessage) {
            if(selectedMessage == null) return;
            if(selectedMessage.MailType == MailType.Deleted) {
                selectedMessage.Deleted = true;
            }
            else {
                if(selectedMessage.MailType == MailType.Draft) {
                    selectedMessage.MailType = MailType.Deleted;
                    SendMessage(selectedMessage);
                }
                selectedMessage.MailType = MailType.Deleted;
            }
            if(MessageDeleted != null)
                MessageDeleted(this, EventArgs.Empty);
        }
        [Command]
        public void SetMessageFlaged(Message selectedMessage) {
            selectedMessage.Flagged++;
            if(MessageFlagged != null)
                MessageFlagged(this, EventArgs.Empty);
        }
        [Command]
        public void EditMessage(Message selectedMessage) {
            if(selectedMessage == null) return;
            if(selectedMessage.MailType != MailType.Deleted && !selectedMessage.Deleted) {
                Message message = new Message();
                message.MailType = MailType.Draft;
                message.Subject = selectedMessage.Subject;
                message.Email = Utils.Utils.MessageFrom;
                message.From = selectedMessage.Email;
                message.Text = selectedMessage.Text;
                SendMessage(message);
            }
        }
        [Command]
        public void ReplyMessage(Message selectedMessage) {
            if(selectedMessage == null) return;
            if(selectedMessage.MailType != MailType.Deleted && !selectedMessage.Deleted) {
                Message message = CreateReplyMessage(selectedMessage);
                SendMessage(message);
            }
        }

        #endregion
        public void RegisterAsRecipient() {
            Messenger.Default.Register<bool>(this, OnBoolMessage);
        }
        public event EventHandler ShowFocusedOtherChanged;
        bool _showFocusedOtherFilter = true;
        public bool ShowFocusedOtherFilter { get { return _showFocusedOtherFilter; } }
        void OnBoolMessage(bool showFocusedOther) {
            this._showFocusedOtherFilter = showFocusedOther;
            if(showFocusedOther) CurrentFilterType = FilterType.Other;
            else CurrentFilterType = (FilterType) 3;
            UpdateLabelsVisibility();
            if(ShowFocusedOtherChanged != null && CurrentMailType == MailType.Inbox)
                ShowFocusedOtherChanged(this, EventArgs.Empty);
        }
        public Message CreateReplyMessage(Message selectedMessage) {
            Message message = new Message();
            message.MailType = MailType.Draft;
            message.From = string.IsNullOrEmpty(selectedMessage.From) ? Utils.Utils.MessageFrom : selectedMessage.From;
            message.Email = selectedMessage.Email;
            message.Subject = selectedMessage.Subject;
            message.Text = CreateReplyMessageText(selectedMessage.Text, message.From, selectedMessage.Date);
            return message;
        }
        string CreateReplyMessageText(string text, string to, DateTime originalMessageDate) {
            using(RichEditDocumentServer server = new RichEditDocumentServer()) {
                server.MhtText = text;
                QuoteReplyMessage(server, to, originalMessageDate);
                return server.MhtText;
            }
        }
        void QuoteReplyMessage(RichEditDocumentServer server, string to, DateTime originalMessageDate) {
            QuoteMessage(server);
            Document document = server.Document;
            string replyHeader = String.Format(Resources.ReplyText, to, originalMessageDate);
            document.InsertText(document.Range.Start, replyHeader);
        }
        void QuoteMessage(RichEditDocumentServer server) {
            Document document = server.Document;
            ParagraphCollection paragraphs = document.Paragraphs;
            foreach(Paragraph paragraph in paragraphs) {
                DocumentRange range = paragraph.Range;
                if(document.Tables.GetTableCell(range.Start) == null && !paragraph.IsInList) {
                    document.InsertText(range.Start, ">> ");
                }
            }
        }
        public void SetCurrentMessage(Message message) {
            CurrentMessage = message;
        }
        MailClientDataModel model;
        public MailViewerViewModel() {
            model = new MailClientDataModel();
            RegisterAsRecipient();
        }
    }
}

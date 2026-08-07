using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.DXperience.Demos;
using DevExpress.WindowsMailClient.Win.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;

namespace DevExpress.WindowsMailClient.Win.Data {
    [Flags]
    public enum MailFolder {
        All = 0,
        Announcements = 1,
        General = 2,
        Management = 4,
        IT = 8,
        Sales = 16,
        Support = 32,
        Engineering = 64,
        Deleted = 128,
        Custom = 1024
    };
    public enum MailCategories {
        General = 1,
        Management = 2,
        IT = 3,
        Sales = 4,
        Support = 5,
        Engineering = 6,
        HR = 7,
        Design = 8
    };
    public enum MailType {
        Unknown,
        Inbox,
        Deleted,
        Sent,
        Draft,
        Clutter,
        Outbox,
        Archive,
        Archive1
    };
    public class MailData {
        DataRow _row;
        public MailData(DataRow row) {
            this._row = row;
        }
        public DataRow Row { get { return _row; } }
        public int Priority {
            get { return (int)_row["Priority"]; }
            set { _row["Priority"] = value; }
        }
        public int Attachment { get { return (int)_row["Attachment"]; } }
        public int Read {
            get { return (int)_row["Read"]; }
            set { _row["Read"] = value; }
        }
        public int Flag {
            get { return (int)_row["Flag"]; }
            set { _row["Flag"] = value; }
        }
        public string Subject { get { return string.Format("{0}", _row["Subject"]); } }
        public string From { get { return string.Format("{0}", _row["From"]); } }
    }
    public class Message {
        DataRow _row;
        DateTime _date;
        bool _read, _deleted, _hasAttachment;
        int _priority = 1;
        MailType _mailType;
        int _mailFolder;
        string _from = String.Empty, _subject = String.Empty, _text = String.Empty, _plainText = string.Empty, _email = String.Empty;
        
        public Message() {
            _date = TutorialConstants.Now;
        }
        public Message(DataRow row) {
            this._row = row;
            _date = TutorialConstants.Now.AddDays((int)row["Day"]).AddSeconds(-TutorialConstants.Random.Next(10000));
            _email = string.Format("{0}", row["From"]);
            _from = MailClientDataModel.GetNameByEmail(_email);
            _subject = string.Format("{0}", row["Subject"]);
            _read = Delay > TimeSpan.FromHours(48);
            _text = string.Format("{0}", row["Text"]);
            _deleted = false;
            _mailType = MailType.Inbox;
            _mailFolder = (int)GetFolder(row);
            _plainText = GetPlainText();
            DataTweaking();
        }
        public string FullName {
            get {
                if(string.IsNullOrEmpty(_email))
                    return _from;
                return string.Format("{0} ({1})", _from, _email);
            }
        }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public string From { get { return _from; } set { _from = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Subject { get { return _subject; } set { _subject = value; } }
        public string SubjectDisplayText { get { return Subject; } }
        public int Attachment { get { return _hasAttachment ? 1 : 0; } }
        public int Read { get { return _read ? 1 : 0; } }
        public int Priority { get { return _priority; } set { _priority = value; } }
        public bool IsUnread { get { return !_read; } }
        public int Flagged { get; set; }
        internal string Folder { get { return string.Format("{0}", _mailFolder); } }
        public string Text { get { return _text; } set { _text = value; } }
        public string PlainText { get { return GetPlainText(); } }

        string GetPlainText() {
            if(string.IsNullOrEmpty(_plainText)) {
                _plainText = ObjectHelper.GetPlainTextFromMHT(_text).Replace("\r\n", " ");
            }
            return _plainText;
        }
        public MailType MailType { get { return _mailType; } set { _mailType = value; } }
        public int MailFolder {
            get { return _mailFolder; }
            set {
                if(MailFolder == value) return;
                _mailFolder = value;
            }
        }
        public bool Deleted {
            get { return _deleted; }
            set { _deleted = value; }
        }
        internal TimeSpan Delay {
            get { return TutorialConstants.Now - _date; }
        }
        public void ToggleRead() {
            _read = !_read;
        }
        void DataTweaking() {
            if(Delay > TimeSpan.FromHours(50) && Delay < TimeSpan.FromHours(100)) _read = false;
            if(_subject.IndexOf("RE:") >= 0 || _subject.IndexOf("FW:") >= 0) _read = false;
            _hasAttachment = _text.Length > 20000;
            if(_subject.IndexOf("Review") >= 0 || _subject.IndexOf("Important") >= 0) _priority = 2;
            if(_subject.IndexOf("FW:") >= 0 && Delay > TimeSpan.FromHours(48)) _priority = 0;
            if(_subject.IndexOf("New") >= 0 || _subject.IndexOf("Meeting") >= 0)
                _mailFolder += 1;
        }
        MailFolder GetFolder(DataRow row) {
            object category = row["CategoryID"];
            string ret = string.Format("{0}", (MailCategories)(category == DBNull.Value ? 1 : (int)category));
            if(string.IsNullOrEmpty(ret)) return Data.MailFolder.All;
            return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
        }
        public void SetPlainText(string text) { _plainText = text; }
    }
    public class ObjectHelper {
        static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainTextFromMHT(string mhtText) {
            rich.MhtText = mhtText;
            return rich.Text.TrimStart();
        }
        public static void GetChildDataRowHandles(GridView view, int rowHandle, List<Message> list) {
            for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
                int row = view.GetChildRowHandle(rowHandle, i);
                if(row >= 0)
                    list.Add(view.GetRow(row) as Message);
                else
                    GetChildDataRowHandles(view, row, list);
            }
        }
    }
}

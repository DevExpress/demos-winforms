using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    [DeferredDeletion(false)]
    public class ServerSideLookUpTest : XPObject {
        public ServerSideLookUpTest(Session session) : base(session) { }
        public string AssignTo;
        public ServerSideGridTest Issue;
        public DateTime DueDate;
        public int PercentComplete;
    }
    [DeferredDeletion(false)]
    public class ServerSideGridTest : XPObject {
		public ServerSideGridTest(Session session) : base(session) { }
		[Indexed]
		public string Subject;
		[Indexed]
		public string From;
		[Indexed]
		public DateTime Sent;
		[Indexed]
		public Int64 Size;
        [Indexed]
		public bool HasAttachment;
        [Indexed]
        public int Priority;
	}
    public class MemoWriter : TextWriter {
		public MemoEdit Memo;
		public MemoWriter() {
		}
		readonly Encoding enc = new UnicodeEncoding(false, false);
		public override Encoding Encoding {
			get {
				return enc;
			}
		}
		public override void Write(char value) {
			Write(value.ToString());
		}
		public override void Write(string value) {
            if(Memo == null)
                return;
			Memo.Text += value;
			Memo.SelectionStart = int.MaxValue;
		}
	}
    public class WaitCursorWrapper : IDataStore {
		public readonly IDataStore Nested;
		public WaitCursorWrapper(IDataStore nested) {
			this.Nested = nested;
		}
		public AutoCreateOption AutoCreateOption {
			get { return Nested.AutoCreateOption; }
		}
		public ModificationResult ModifyData(params ModificationStatement[] dmlStatements) {
            try {
                Cursor.Current = Cursors.WaitCursor;
                return Nested.ModifyData(dmlStatements);
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }
		public SelectedData SelectData(params SelectStatement[] selects) {
			try {
				Cursor.Current = Cursors.WaitCursor;
				return Nested.SelectData(selects);
			} finally {
				Cursor.Current = Cursors.Default;
			}
		}
		public UpdateSchemaResult UpdateSchema(bool dontCreateIfFirstTableNotExist, params DBTable[] tables) {
			try {
				Cursor.Current = Cursors.WaitCursor;
				return Nested.UpdateSchema(dontCreateIfFirstTableNotExist, tables);
			} finally {
				Cursor.Current = Cursors.Default;
			}
		}
	}
    public class ServerModeStrings {
        public static string SQLConnectionString = string.Empty;
        public static string dataAdding = Properties.Resources.DataAdding;
        public static string recordCount = Properties.Resources.CurrentRecordCount;
    }
}

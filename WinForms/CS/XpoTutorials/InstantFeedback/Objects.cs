using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;

namespace DevExpress.Xpo.Demos {
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
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }
        public UpdateSchemaResult UpdateSchema(bool dontCreateIfFirstTableNotExist, params DBTable[] tables) {
            try {
                Cursor.Current = Cursors.WaitCursor;
                return Nested.UpdateSchema(dontCreateIfFirstTableNotExist, tables);
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }
    }
    public class ServerModeStrings {
        public static string SQLConnectionString = string.Empty;
        public static string dataAdding = "Adding next portion of data...";
        public static string recordCount = "Current record count = {0}";
        public static string descriptionSQLConnection =
            "This demo shows a grid control's capabilities when it's bound to a large amount of data. In this example, the grid control needs to be connected to a data table on an MS SQL server. Please use this Configuration Window to configure data and connection settings.\r\n" +
            "On the first run:\r\n" +
            "1) Specify the name of an existing SQL Server which will contain the target database;\r\n" +
            "2) Specify the amount of records in the target table and click the Generate Table and Start Demo button. A new table will be generated and the demo will start with the grid control bound to the generated recordset.\r\n" +
            "On subsequent runs, you can add more records to the database or just start the demo without generating additional data.";
        public static string descriptionServerSide =
            "This application demonstrates the XtraGrid control functioning in server mode, which is specifically designed to handle large volumes of data. Data is supplied to the grid control in small portions when required; it is never loaded into memory in its entirety. In addition, all data-aware operations are performed on the server side. All of this guarantees rapid data display and processing.\r\n" +
            "Practice with scrolling records, sorting, grouping and filtering against columns, and calculating summaries. Specific operations that you execute may take some time. In server mode, performance is wholly dependent on the data transfer speed, and the performance of the data server which carries out requested operations.\r\n" +
            "All operations performed on data are logged, and can be seen in the Tracing pane. To slightly improve performance, you can disable tracing by clearing the Enable Tracing checkbox.";
        public static string descriptionLookUpServerSide =
            "This application demonstrates the GridLookUpEdit control functioning in server mode. Data is supplied to the control in small portions when required; it's never loaded into memory in its entirety. In addition, all data-aware operations are performed on the server side. All of this guarantees rapid data display and processing.\r\n" +
            "Open an in-place GridLookUpEdit editor (by clicking on the Issue column's cell) and practice with scrolling records, sorting, grouping and filtering against columns, and calculating summaries. Specific operations that you execute may take some time. In server mode, performance is wholly dependent on the data transfer speed, and the performance of the data server which carries out requested operations.\r\n" +
            "All operations performed on data are logged, and can be seen in the Tracing pane. To slightly improve performance, you can disable tracing by clearing the Enable Tracing checkbox.";

    }

}

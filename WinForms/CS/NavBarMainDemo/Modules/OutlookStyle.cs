using System;
using System.Drawing;
using System.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.DXperience.Demos;
using System.ComponentModel;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for OutlookStyle.
	/// </summary>
	public partial class OutlookStyle : DevExpress.XtraEditors.XtraUserControl {
		public OutlookStyle() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

        MailFilter mFilter = MailFilter.Draft;
        [DefaultValue(MailFilter.Draft)]
		public MailFilter MailFilter {
			get { return mFilter; }
			set {
				mFilter = value;
				if(mFilter == MailFilter.Inbox || mFilter == MailFilter.Sent || mFilter == MailFilter.Deleted) {
					gridControl1.DataSource = OutlookData.CreateDataTable();
					gridView1.SetRowExpanded(-1, true);
					gridView1.SetRowExpanded(-2, true);
				} else {
					gridControl1.DataSource = null;
				}
				if(mFilter == MailFilter.Inbox || mFilter == MailFilter.Deleted) {
					gridColumn5.Caption = "From";
					gridColumn6.Caption = "Received";
				} else {
					gridColumn5.Caption = "To";
					gridColumn6.Caption = "Sent";
				}
				gridColumn2.Visible = mFilter == MailFilter.Inbox;
			}
		}

		private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
			GridGroupRowInfo info = e.Info as GridGroupRowInfo;
			if(info == null) return;
			info.GroupText = info.GroupText.Replace("1 items", "1 item");
		}

		private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
			if(mFilter == MailFilter.Inbox) {
				DataRow row = gridView1.GetDataRow(e.RowHandle);
				if(row["Read"].Equals(0))
					e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
			}
			if(mFilter == MailFilter.Deleted) {
				e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
				e.Appearance.ForeColor = Color.Gray;
			}
		}
	}
	public class OutlookData {
		readonly static string[] users = new string[] {"Peter Dolan", "Ryan Fischer", "Richard Fisher",
												 "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain",
												 "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman",
												 "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"};
		readonly static string[] subject = new string[] {
												   "Implementing DevExpress MasterView control into Accounting System.",
												   "Web Edition: Data Entry Page. The issue with date validation.",
												   "Payables Due Calculator. It is ready for testing.",
												   "Web Edition: Search Page. It is ready for testing.",
												   "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.",
												   "Receivables Calculator. Where can I found the complete specs",
												   "Ledger: Inconsistency. Please fix it.",
												   "Receivables Printing. It is ready for testing.",
												   "Screen Redraw. Somebody has to look at it.",
												   "Email System. What library we are going to use?",
												   "Adding New Vendors Fails. This module doesn't work completely!",
												   "History. Will we track the sales history in our system?",
												   "Main Menu: Add a File menu. File menu is missed!!!",
												   "Currency Mask. The current currency mask in completely inconvinience.",
												   "Drag & Drop. In the schedule module drag & drop is not available.",
												   "Data Import. What competitors databases will we support?",
												   "Reports. The list of incomplete reports.",
												   "Data Archiving. This features is still missed in our application",
												   "Email Attachments. How to add the multiple attachment? I did not find a way to do it.",
												   "Check Register. We are using different paths for different modules.",
												   "Data Export. Our customers asked for export into Excel"};

		static bool GetBoolean() {
			int ret = TutorialConstants.Random.Next(7);
			return ret > 4;
		}

		static int GetImportance() {
			int ret = TutorialConstants.Random.Next(7);
			if(ret > 2) ret = 1;
			return ret;
		}

		static int GetIcon() {
			int ret = TutorialConstants.Random.Next(10);
			ret = ret > 2 ? 1 : 0;
			return ret;
		}

		static DateTime GetSent() {
			DateTime ret = TutorialConstants.Now;
			int r = TutorialConstants.Random.Next(12);
			if(r > 1) ret = ret.AddDays(-TutorialConstants.Random.Next(50));
			ret = ret.AddMinutes(-TutorialConstants.Random.Next(ret.Minute + ret.Hour * 60 + 360));
			return ret;
		}

		static DateTime GetReceived(DateTime sent) {
			return sent.AddMinutes(10 + TutorialConstants.Random.Next(120));
		}

		static string GetSubject() {
			return subject[TutorialConstants.Random.Next(subject.Length - 1)];
		}

		static string GetFrom() {
			return users[TutorialConstants.Random.Next(users.Length - 2)];
		}

		static string GetTo() {
			return users[users.Length - 1];
		}

		public static DataTable CreateDataTable() {
			DataTable tbl = new DataTable("Outlook");
			tbl.Columns.Add("Priority", typeof(int));
			tbl.Columns.Add("Attachment", typeof(int));
			tbl.Columns.Add("Read", typeof(int));
			tbl.Columns.Add("Subject", typeof(string));
			tbl.Columns.Add("From", typeof(string));
			tbl.Columns.Add("To", typeof(string));
			tbl.Columns.Add("Sent", typeof(DateTime));
			tbl.Columns.Add("Received", typeof(DateTime));
			for(int i = 0; i < 80; i++) {
				DateTime sent = GetSent();
				tbl.Rows.Add(new object[] {GetImportance(), GetIcon(), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent, GetReceived(sent)});
			}
			return tbl;
		}
		public static DataTable CreateTaskTable() {
			DataTable tbl = new DataTable("Task");
			tbl.Columns.Add("Image", typeof(int));
			tbl.Columns.Add("Check", typeof(bool));
			tbl.Columns.Add("Subject", typeof(string));
			tbl.Columns.Add("Date", typeof(DateTime));
			for(int i = 0; i < 10; i++)
				tbl.Rows.Add(new object[] {0, GetBoolean(), GetSubject(), GetSent()});
			return tbl;
		}
		public static DataTable CreateNotesTable() {
			DataTable tbl = new DataTable("Notes");
			tbl.Columns.Add("Name", typeof(string));
			tbl.Columns.Add("Description", typeof(string));
			for(int i = 0; i < 10; i++)
				tbl.Rows.Add(new object[] {GetFrom(), GetSubject()});
			return tbl;
		}
		public static DataTable CreateJournalTable() {
			DataTable tbl = new DataTable("Journal");
			tbl.Columns.Add("Date", typeof(DateTime));
			tbl.Columns.Add("Time", typeof(DateTime));
			tbl.Columns.Add("Description", typeof(string));
			for(int i = 0; i < 10; i++) {
				DateTime sent = GetSent();
				tbl.Rows.Add(new object[] {sent, sent, GetSubject()});
			}
			return tbl;
		}
	}
	public enum MailFilter {Inbox, Outbox, Deleted, Sent, Draft};
}

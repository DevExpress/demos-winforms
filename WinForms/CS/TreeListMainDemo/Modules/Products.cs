using System;

namespace DevExpress.XtraTreeList.Demos {
	public class Record {
		private string fCategory;
		private object fProduct1;
		private object fProduct2;
		private object fProduct3;
		private int fId;
		private int fParentID;
		
		public Record(string category, object product1, object product2, object product3, int id) : this(category, product1, product2, product3, id, -1) {}
		public Record(string category, object product1, object product2, object product3, int id, int parentID) {
			this.fCategory = category;
			this.fProduct1 = product1;
			this.fProduct2 = product2;
			this.fProduct3 = product3;
			this.fId = id;
			this.fParentID = parentID;
		}

		public int ID {
			get { return fId; }
		}

		public int ParentID {
			get { return fParentID; }
		}

		public string Category {
			get { return fCategory; }
		}

		public object Product1 {
			get { return fProduct1; }
			set { fProduct1 = value; }
		}

		public object Product2 {
			get { return fProduct2; }
			set { fProduct2 = value; }
		}

		public object Product3 {
			get { return fProduct3; }
			set { fProduct3 = value; }
		}
	}
}

using System;
namespace DevExpress.XtraEditors.Demos {
	public class RecordOrder {
		private string fcategory;
		private object fproduct1;
		private object fproduct2;
		private object fproduct3;
		
		public RecordOrder(string fcategory, object fproduct1, object fproduct2, object fproduct3) {
			this.fcategory = fcategory;
			this.fproduct1 = fproduct1;
			this.fproduct2 = fproduct2;
			this.fproduct3 = fproduct3;
		}

		public string Category {
			get { return fcategory; }
		}

		public object Product1 {
			get { return fproduct1; }
			set { fproduct1 = value; }
		}

		public object Product2 {
			get { return fproduct2; }
			set { fproduct2 = value; }
		}

		public object Product3 {
			get { return fproduct3; }
			set { fproduct3 = value; }
		}
	}
}

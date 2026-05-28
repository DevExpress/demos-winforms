using System;

namespace DevExpress.XtraTreeList.Demos {
    //<imageListBoxControl1>
	public class DragObject {
		private string[] taskNames = new string[] {"Project", "Subtask", "Task"};
		private int index;
		public DragObject(int index) {
			this.index = index;
		}
		public object DragData { get { return new object[] { taskNames[index], DateTime.Now, DateTime.Now, 0} ; } }
		public int ImageIndex { get { return index; }}
	}
    //</imageListBoxControl1>
}

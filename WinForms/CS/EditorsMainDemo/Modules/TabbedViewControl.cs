using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;

namespace DevExpress.XtraEditors.Demos {
    public partial class TabbedViewControl : XtraUserControl {
        public TabbedViewControl() {
            InitializeComponent();
            DocumentControls = new DocumentList(this);
        }
        DocumentGroup Group { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DocumentList DocumentControls { get; set; }
        protected internal void AddPanel(DocumentControlInfo controlInfo) {
            var control = controlInfo.Control;
            if(control == null)
                return;
            var container = new XtraUserControl();
            container.Controls.Add(control);
            this.tabbedView1.AddDocument(container, controlInfo.Caption);
        }
    }
    public class DocumentControlInfo {
        public Control Control { get; set; }
        public string Caption { get; set; }
    }
    public class DocumentList : CollectionBase, IList<DocumentControlInfo> {
        public DocumentList(TabbedViewControl owner) {
            Owner = owner;
        }

        public DocumentControlInfo this[int index] {
            get { return (DocumentControlInfo)List[index]; }
            set { List[index] = value; }
        }
        public bool IsReadOnly { get { return List.IsReadOnly; } }
        TabbedViewControl Owner { get; set; }
        public void Add(DocumentControlInfo item) {
            List.Add(item);
        }
        public bool Contains(DocumentControlInfo item) {
            return List.Contains(item);
        }
        public void CopyTo(DocumentControlInfo[] array, int arrayIndex) {
            List.CopyTo(array, arrayIndex);
        }
        public int IndexOf(DocumentControlInfo item) {
            return List.IndexOf(item);
        }
        public void Insert(int index, DocumentControlInfo item) {
            List.Insert(index, item);
        }
        public bool Remove(DocumentControlInfo item) {
            if(List.Contains(item)) {
                List.Remove(item);
                return true;
            }
            return false;
        }
        protected override void OnInsertComplete(int index, object value) {
            base.OnInsertComplete(index, value);
            if(value is DocumentControlInfo)
                Owner.AddPanel((DocumentControlInfo)value);
        }
        IEnumerator<DocumentControlInfo> IEnumerable<DocumentControlInfo>.GetEnumerator() {
            return (IEnumerator<DocumentControlInfo>)List.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() {
            return List.GetEnumerator();
        }
        void IList<DocumentControlInfo>.RemoveAt(int index) {
            List.RemoveAt(index);
        }
        void ICollection<DocumentControlInfo>.Clear() {
            List.Clear();
        }
        int ICollection<DocumentControlInfo>.Count {
            get { return List.Count; }
        }
    }
}

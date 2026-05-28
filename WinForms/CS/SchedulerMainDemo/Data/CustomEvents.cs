using System;
using System.Collections;
using System.ComponentModel;

namespace DevExpress.XtraScheduler.Demos {
    public class CustomEvent : IEditableObject {
        CustomEventList events;
        bool committed = false;
        public CustomEvent(CustomEventList events) {
            this.events = events;
        }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public object OwnerId { get; set; }

        public void BeginEdit() { }
        public void CancelEdit() {
            if (!committed) 
                ((IList)events).Remove(this);
        }
        public void EndEdit() {
            committed = true;
        }
    }

    public class CustomEventList : CollectionBase, IBindingList {
        public CustomEvent this[int idx] {
            get { return (CustomEvent)base.List[idx]; }
        }
        public void Add(CustomEvent appointment) {
            base.List.Add(appointment);
        }
        public int IndexOf(CustomEvent appointment) {
            return List.IndexOf(appointment);
        }
        public object AddNew() {
            CustomEvent app = new CustomEvent(this);
            List.Add(app);
            return app;
        }
        public bool AllowEdit { get { return true; } }
        public bool AllowNew { get { return true; } }
        public bool AllowRemove { get { return true; } }

        event  ListChangedEventHandler listChangedHandler;
        public event ListChangedEventHandler ListChanged {
            add { listChangedHandler += value; }
            remove { listChangedHandler -= value; }
        }
        internal void OnListChanged(ListChangedEventArgs args) {
            if(listChangedHandler != null) listChangedHandler(this, args);
        }
        protected override void OnRemoveComplete(int index, object value) {
            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
        }
        protected override void OnInsertComplete(int index, object value) {
            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
        }
        public void AddIndex(PropertyDescriptor pd) { throw new NotSupportedException(); }
        public void ApplySort(PropertyDescriptor pd, ListSortDirection dir) { throw new NotSupportedException(); }
        public int Find(PropertyDescriptor property, object key) { throw new NotSupportedException(); }
        public bool IsSorted { get { return false; } }
        public void RemoveIndex(PropertyDescriptor pd) { throw new NotSupportedException(); }
        public void RemoveSort() { throw new NotSupportedException(); }
        public ListSortDirection SortDirection { get { throw new NotSupportedException(); } }
        public PropertyDescriptor SortProperty { get { throw new NotSupportedException(); } }
        public bool SupportsChangeNotification { get { return true; } }
        public bool SupportsSearching { get { return false; } }
        public bool SupportsSorting { get { return false; } }
    }
}

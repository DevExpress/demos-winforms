using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DevExpress.XtraCharts.Demos {

    class FinancialDataCollection : ObservableCollection<FinancialDataPoint> {
        public void AddRange(List<FinancialDataPoint> list) {
            for(int i = 0; i < list.Count; i++)
                Items.Add(list[i]);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, list, Items.Count - list.Count));
        }
        public void RemoveRangeAt(int startingIndex, int count) {
            List<FinancialDataPoint> removedItems = new List<FinancialDataPoint>(count);
            for(int i = 0; i < count; i++) {
                removedItems.Add(Items[startingIndex]);
                Items.RemoveAt(startingIndex);
            }
            if(count > 0)
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removedItems, startingIndex));
        }
    }


    class DataCollection : ObservableCollection<SensorIndicationItem> {
        internal void AddRange(List<SensorIndicationItem> items) {
            foreach(SensorIndicationItem item in items)
                Items.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, items, Items.Count - items.Count));
        }
        internal void RemoveRangeAt(int startingIndex, int count) {
            List<SensorIndicationItem> removedItems = new List<SensorIndicationItem>(count);
            for(int i = 0; i < count; i++) {
                removedItems.Add(Items[startingIndex]);
                Items.RemoveAt(startingIndex);
            }
            if(count > 0)
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removedItems, startingIndex));
        }
    }

}

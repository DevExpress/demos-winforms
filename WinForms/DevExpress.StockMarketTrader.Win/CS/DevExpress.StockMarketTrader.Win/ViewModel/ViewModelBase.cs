using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DevExpress.StockMarketTrader.ViewModel {
    public class LockableCollection<T> : ObservableCollection<T> {
        bool hasChanges;
        int updateLockCount;
        public bool IsUpdateLocked {
            get { return updateLockCount > 0; }
        }
        protected override void SetItem(int index, T item) {
            if(!this[index].Equals(item))
                base.SetItem(index, item);
        }
        public void BeginUpdate() {
            if(0 == updateLockCount++)
                hasChanges = false;
        }
        public void EndUpdate() {
            if(--updateLockCount == 0 && hasChanges)
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {
            if(IsUpdateLocked)
                hasChanges = true;
            else base.OnCollectionChanged(e);
        }
    }
    public abstract class ViewModelBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) {
            if(PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

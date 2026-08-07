using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraMap;

namespace DevExpress.DevAV.ViewModels {
    public class MapViewModel {
        public virtual List<MapItemModel> MapItems { get; set; }
        public virtual GeoPoint StoreCenterPoint { get; set; }
        public virtual MapItemModel SelectedStoreMapItem { get; set; }

        public static MapViewModel Create() {
            return ViewModelSource.Create(() => new MapViewModel());
        }

        protected MapViewModel() {
        }

        protected void OnMapItemsChanged() {
            if(MapItems == null)
                return;
            if(MapItems.Count > 0) {
                MapItemModel last = MapItems.Last();
                StoreCenterPoint = new GeoPoint(last.Latitude, last.Longitude);
                SelectedStoreMapItem = last;
            }
        }

        public void Update(List<MapItemModel> mapItems) {
            MapItems = mapItems;
        }
    }
}

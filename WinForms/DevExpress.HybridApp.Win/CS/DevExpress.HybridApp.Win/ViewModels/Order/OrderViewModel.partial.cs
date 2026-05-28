using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    public partial class OrderViewModel : SingleObjectViewModel<Order, long, IDevAVDbUnitOfWork> {
        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            ZoomFactor = 1f;
        }
        public virtual float ZoomFactor {
            get;
            set;
        }
        public void ZoomIn(float delta) {
            ZoomFactor += delta;
        }
        public void ZoomOut(float delta) {
            ZoomFactor -= delta;
        }
        protected void OnZoomFactorChanged() {
            this.RaiseCanExecuteChanged(x => x.ZoomIn(0));
            this.RaiseCanExecuteChanged(x => x.ZoomOut(0));
        }
        protected bool CanZoomIn(float delta) {
            return ZoomFactor + delta < 2f;
        }
        protected bool CanZoomOut(float delta) {
            return ZoomFactor - delta > 0f;
        }
    }
}

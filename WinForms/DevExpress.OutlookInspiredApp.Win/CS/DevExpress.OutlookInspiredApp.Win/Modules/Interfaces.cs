namespace DevExpress.DevAV.Modules {
    using System;
    using DevExpress.XtraBars.Ribbon;

    public interface IRibbonModule {
        RibbonControl Ribbon { get; }
    }
    public interface ISupportViewModel {
        object ViewModel { get; }
        void ParentViewModelAttached();
    }
    public interface ISupportFiltersVisibilityChangedEvent {
        event EventHandler FiltersVisibilityChanged;
        void RaiseFiltersVisibilityChanged(object sender, EventArgs e);
    }
}

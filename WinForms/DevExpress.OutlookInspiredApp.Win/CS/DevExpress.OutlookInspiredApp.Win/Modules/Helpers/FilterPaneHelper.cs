using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Modules.Helpers {
    public static class FilterPaneHelper {
        public static void SetupFiltersPane(
            MainViewModel parentViewModel,
            object viewModel,
            ModuleType filterPaneType,
            ModuleType collapsedFilterPaneType,
            RoundedSkinPanel navigationPanel,
            Size defaultNavigationSize,
            Action<object, EventArgs> filtersVisibilityChangedCore) {

            Control filterPane = parentViewModel.GetNavigationModule(filterPaneType);
            Control collapsedFilterPane = parentViewModel.GetNavigationModule(collapsedFilterPaneType);

            ViewModelHelper.EnsureModuleViewModel(filterPane, viewModel);
            ViewModelHelper.EnsureModuleViewModel(collapsedFilterPane, viewModel);

            filterPane.Dock = DockStyle.Fill;
            collapsedFilterPane.Dock = DockStyle.Left;
            collapsedFilterPane.Visible = false;
            navigationPanel.Size = defaultNavigationSize;
            navigationPanel.Controls.Add(filterPane);
            navigationPanel.Controls.Add(collapsedFilterPane);
            filtersVisibilityChangedCore?.Invoke(navigationPanel, EventArgs.Empty);
        }

        public static void SwitchFiltersVisibility(MainViewModel mainViewModel, RoundedSkinPanel navigationPanel, Size defaultPaneSize, Size defaultCollapsedPaneSize) {
            if(DXperience.Demos.MainFormHelper.TakeScreens) {
                navigationPanel.Visible = false;
                return;
            }
            switch(mainViewModel.FiltersVisibility) {
                case CollectionViewFiltersVisibility.Visible:
                    navigationPanel.Visible = true;
                    navigationPanel.Size = defaultPaneSize;
                    navigationPanel.Controls[0].Visible = true;
                    navigationPanel.Controls[1].Visible = false;
                    break;
                case CollectionViewFiltersVisibility.Minimized:
                    navigationPanel.Visible = true;
                    navigationPanel.Size = defaultCollapsedPaneSize;
                    navigationPanel.Controls[0].Visible = false;
                    navigationPanel.Controls[1].Visible = true;
                    break;
                case CollectionViewFiltersVisibility.Hidden:
                    navigationPanel.Visible = false;
                    break;
            }
        }
    }
}

using DevExpress.Mvvm;
using DevExpress.WindowsMailClient.Win.Modules;

namespace DevExpress.WindowsMailClient.Win.Utils {
    public static class ViewModelUtils {
        public static TViewModel GetParentViewModel<TViewModel>(object viewModel) {
            ISupportParentViewModel parentViewModelSupport = viewModel as ISupportParentViewModel;
            if(parentViewModelSupport != null)
                return (TViewModel) parentViewModelSupport.ParentViewModel;
            return default(TViewModel);
        }
        public static void CheckModuleViewModel(object module, object parentViewModel, object parameter = null) {
            ISupportViewModel vm = module as ISupportViewModel;
            if(vm != null) {
                object oldParentViewModel = null;
                ISupportParentViewModel parentViewModelSupport = vm.ViewModel as ISupportParentViewModel;
                if(parentViewModelSupport != null)
                    oldParentViewModel = parentViewModelSupport.ParentViewModel;
                CheckViewModel(vm.ViewModel, parentViewModel, parameter);
                if(oldParentViewModel != parentViewModel)
                    vm.ParentViewModelAttached();
            }
        }
        public static void CheckViewModel(object viewModel, object parentViewModel, object parameter = null) {
            ISupportParentViewModel parentViewModelSupport = viewModel as ISupportParentViewModel;
            if(parentViewModelSupport != null)
                parentViewModelSupport.ParentViewModel = parentViewModel;
            ISupportParameter parameterSupport = viewModel as ISupportParameter;
            if(parameterSupport != null && parameter != null)
                parameterSupport.Parameter = parameter;
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DevExpress.DentalClinic.ViewModels;

namespace DevExpress.DentalClinic.Views.Settings {
    public partial class ChangePasswordView : DevExpress.XtraEditors.XtraUserControl, IErrorProviderService {
        public ChangePasswordView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            // Register the IErrorProviderService service
            mvvmContext.RegisterService(this);
            // Initializing Fluent API
            var fluent = mvvmContext.OfType<ChangePasswordViewModel>();
            fluent.SetObjectDataSourceBinding(passwordDataBindingSource, x => x.PasswordData, x => x.ValidatePassword);
            fluent.BindCommand(sbSave, x => x.SavePassword);
        }
        void IErrorProviderService.Update(IReadOnlyCollection<ValidationResult> errors) {
            dxErrorProvider.ClearErrors();
            foreach(var item in errors) {
                if(item.MemberNames.Contains(nameof(PasswordData.OldPassword)))
                    dxErrorProvider.SetError(currentPasswordTextEdit, item.ErrorMessage);
                if(item.MemberNames.Contains(nameof(PasswordData.NewPassword)))
                    dxErrorProvider.SetError(newPasswordTextEdit1, item.ErrorMessage);
                if(item.MemberNames.Contains(nameof(PasswordData.RepeatPassword)))
                    dxErrorProvider.SetError(confirmPasswordTextEdit2, item.ErrorMessage);
                if(!item.MemberNames.Any())
                    dxErrorProvider.SetError(confirmPasswordTextEdit2, item.ErrorMessage);
            }
        }
    }
}

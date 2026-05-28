using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace DevExpress.DentalClinic {
    public static class XtraMessageBoxServiceHelper {
        public static void RegisterXtraMessageBoxService() {
            var xtraMsgService = MessageBoxService.CreateXtraMessageBoxService();
            xtraMsgService.MessageBoxFormStyle = (form) => {
                var msgFrm = form as XtraMessageBoxForm;
                msgFrm.Text = string.IsNullOrEmpty(msgFrm.Text) ? DentalClinicStringId.ApplicationName : msgFrm.Text;
                msgFrm.MessageBoxArgs.TextPadding = ScaleUtils.ScalePadding(new Padding(20, 20, 140, 20));
                msgFrm.MessageBoxArgs.ButtonAlignment = DevExpress.Utils.HorzAlignment.Far;
            };
            // register global service
            DevExpress.Mvvm.ServiceContainer.Default.RegisterService(xtraMsgService);
        }
    }
}

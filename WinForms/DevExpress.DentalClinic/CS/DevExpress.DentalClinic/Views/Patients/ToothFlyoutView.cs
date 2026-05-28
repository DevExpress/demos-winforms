using DevExpress.Utils;
using System.Windows.Forms;

namespace DevExpress.DentalClinic.Views.Patients {
    public partial class ToothFlyoutView : UserControl {
        public ToothFlyoutView() {
            InitializeComponent();
        }
        public void SetToothInfo(ToothInfo toothInfo) {
            dataLayoutControl1.BeginUpdate();
            titleLabel.Control.Text = toothInfo.Title;
            if(string.IsNullOrEmpty(toothInfo.OpenedProcedures)) {
                openedProceduresLabel.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                openedProceduresHeaderLabel.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
                openedProceduresLabel.Control.Text = toothInfo.OpenedProcedures;
            if(string.IsNullOrEmpty(toothInfo.CompletedProcedures)) {
                completedProceduresLabel.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                completedProceduresHeaderLabel.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
                completedProceduresLabel.Control.Text = toothInfo.CompletedProcedures;
            if(string.IsNullOrEmpty(toothInfo.OpenedProcedures) && string.IsNullOrEmpty(toothInfo.CompletedProcedures)) {
                simpleSeparator1.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                var padding = titleLabel.Padding;
                padding.Right = ScaleUtils.ScaleHorizontal(padding.Right + 3, Skins.DpiProvider.Default.DpiScaleFactor);
                titleLabel.Padding = padding;
            }
            dataLayoutControl1.EndUpdate();
            Size = dataLayoutControl1.Size;
        }
    }
    public class ToothInfo {
        public string Title { get; set; }
        public string OpenedProcedures { get; set; }
        public string CompletedProcedures { get; set; }
    }
}

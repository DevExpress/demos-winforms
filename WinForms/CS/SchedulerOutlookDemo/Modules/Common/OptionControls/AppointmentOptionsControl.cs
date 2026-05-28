using System;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class AppointmentOptionsControl : UserControl {
        public AppointmentOptionsControl() {
            InitializeComponent();
            //this.cbAppointmentFontSize.
            for (float i = 5; i < 20; i++) 
                this.cbAppointmentFontSize.Properties.Items.Add(i);
        }

        public void LoadOptions(CommonOptions options) {
            this.cbAppointmentFontSize.EditValue = options.FontSize;
            this.cbAppointmentFontSize.Properties.OwnerEdit.Properties.Mask.MaskType = XtraEditors.Mask.MaskType.Numeric;
            this.feAppointment.EditValue = options.FontFamilyName;
            this.chkAppointmentShowReminder.Checked = options.ShowAppointmentReminder;
            this.chkAppointmentShowRecurrence.Checked = options.ShowAppointmentRecurrence;
        }

        public void SaveOptions(CommonOptions options) {
            options.FontSize = (float)this.cbAppointmentFontSize.EditValue;
            options.FontFamilyName = (string)this.feAppointment.EditValue;
            options.ShowAppointmentReminder = this.chkAppointmentShowReminder.Checked;
            options.ShowAppointmentRecurrence = this.chkAppointmentShowRecurrence.Checked;
        }
    }
}

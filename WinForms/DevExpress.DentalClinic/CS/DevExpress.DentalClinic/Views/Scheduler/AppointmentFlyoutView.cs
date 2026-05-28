using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DentalClinic.Model;

namespace DevExpress.DentalClinic.Views.Scheduler {
    public partial class AppointmentFlyoutView : UserControl {
        public AppointmentFlyoutView() {
            InitializeComponent();
        }
        public Appointment Appointment {
            get { return xpBindingSource1.DataSource as Appointment; }
            set { xpBindingSource1.DataSource = value; }
        }
    }
}

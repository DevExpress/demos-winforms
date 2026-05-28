using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.DashboardCommon;

namespace DevExpress.DentalClinic.View {
    public partial class InfoDashboard : Dashboard {
        public InfoDashboard() {
            InitializeComponent();
            var sqLiteConnectionParameters = new DataAccess.ConnectionParameters.SQLiteConnectionParameters();
            sqLiteConnectionParameters.FileName = DBPathHelper.EnsureWriteable(Application.StartupPath, "DentalCabinet.db");
            dashboardSqlDataSource1.ConnectionParameters = sqLiteConnectionParameters;
        }
        public InfoDashboard(IContainer container) {
            if(container != null)
                container.Add(this);
            InitializeComponent();
        }
    }
}

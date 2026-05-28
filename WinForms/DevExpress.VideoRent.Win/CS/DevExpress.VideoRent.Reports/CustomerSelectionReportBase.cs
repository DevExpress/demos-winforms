using System.Collections.Generic;
using DevExpress.XtraReports.Parameters;

namespace DevExpress.VideoRent.Reports {
    public partial class CustomerSelectionReportBase : ReportBase {
        bool isParameterInitialized = false;
        const string customerListParameterName = "customerListParameter";
        const int customerLimit = 5;

        public CustomerSelectionReportBase() {
            InitializeComponent();
            Parameter customerListParameter = new Parameter();
            customerListParameter.Name = customerListParameterName;
            customerListParameter.Type = typeof(string);
            customerListParameter.Description = Properties.Resources.CustomersCaption;
            customerListParameter.MultiValue = true;
            DynamicListLookUpSettings settings = new DynamicListLookUpSettings() {
                DataSource = xpCollectionCustomers,
                DisplayMember = "FullNameLastSorting",
                ValueMember = "FullNameLastSorting"
            };
            customerListParameter.LookUpSettings = settings;

            Parameters.Add(customerListParameter);
            FilterString = "[FullNameLastSorting] In (?" + customerListParameterName + ")";
        }

        protected override void OnParametersRequestBeforeShow(ParametersRequestEventArgs e) {
            base.OnParametersRequestBeforeShow(e);

            if(!isParameterInitialized && xpCollectionCustomers.Session != null) {
                int customerCount = 0;
                List<string> customers = new List<string>();

                foreach(Customer customer in xpCollectionCustomers) {
                    customers.Add(customer.FullNameLastSorting);
                    if(++customerCount == customerLimit)
                        break;
                }

                Parameters[customerListParameterName].Value = customers.ToArray();
                isParameterInitialized = true;
            }
        }
        void xpCollectionCustomers_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e) {
            e.Session = Session;
        }
    }
}

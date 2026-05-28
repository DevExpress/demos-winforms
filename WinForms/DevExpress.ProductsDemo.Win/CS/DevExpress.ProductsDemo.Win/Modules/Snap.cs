using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using System.IO;
using DevExpress.DataAccess;
using DevExpress.DataAccess.ConnectionParameters;
using System.Data.OleDb;
using DevExpress.ProductsDemo.Win.nwindDataSetTableAdapters;
#if !NET
using DevExpress.Internal;
using DevExpress.Snap.Core.API;
using DevExpress.Snap.Core.Options;
using DevExpress.Snap;
#endif

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class SnapModule : BaseModule {
#if !NET
        public SnapModule() {
            InitializeComponent();
            LoadDocument();
            SetDataSource();
            SubscribeEvents();
        }
        void LoadDocument() {
            string path = DemoUtils.GetRelativePath("MailMergeReports.snx");
            if (File.Exists(path))
                this.snapControl.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new MailMergeReportsDataProvider().GetDataSource();
            this.snapControl.DataSource = dataSource;
        }
        void SubscribeEvents() {
            this.snapControl.MailMergeExportFormShowing += OnMailMergeExportFormShowing;
        }

        void OnMailMergeExportFormShowing(object sender, MailMergeExportFormShowingEventArgs e) {
            e.Options.HeaderFooterLinkToPrevious = false;
            e.Options.RecordSeparator = RecordSeparator.SectionNextPage;
        }

        protected override bool AutoMergeRibbon { get { return true; } }
    }
    public interface ISnapDataProvider {
        object GetDataSource();
    }
    public abstract class NorthwindDataProvider : ISnapDataProvider {
        protected virtual string DataMember { get { return string.Empty; } }
        public object GetDataSource() {
            string path = DataDirectoryHelper.GetDataFile("nwind.mdb");
            var dataSource = new nwindDataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", path);

            FillDataSource(connection, dataSource);

            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            bindingSource.DataMember = DataMember;
            return bindingSource;
        }
        protected abstract void FillDataSource(OleDbConnection connection, nwindDataSet dataSource);
    }
    public class MailMergeReportsDataProvider : NorthwindDataProvider {
        protected override string DataMember { get { return "CustomerOrders"; } }
        protected override void FillDataSource(OleDbConnection connection, nwindDataSet dataSource) {
            var customerOrdersTableAdapter = new CustomerOrdersTableAdapter();
            customerOrdersTableAdapter.Connection = connection;
            customerOrdersTableAdapter.Fill(dataSource.CustomerOrders);

            var orderReportsTableAdapter = new OrderReportsTableAdapter();
            orderReportsTableAdapter.Connection = connection;
            orderReportsTableAdapter.Fill(dataSource.OrderReports);
        }
#endif
    }
}


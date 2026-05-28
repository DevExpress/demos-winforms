using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;
using System.Globalization;
using DevExpress.Internal;
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class Functions : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }

        UnitOfWork session2 = new UnitOfWork(new SimpleDataLayer(new InMemoryDataStore()));
        bool[] firstShow = new bool[] { true, true, true, true };

        UnitOfWork sessionInMemory;
        UnitOfWork sessionDataBase;

        IDbConnection dbConnection;

        string DBFileName;

        public Functions() {
            //<gclCustomQuery>
            //<gclCustomInMemory>
            CriteriaOperator.RegisterCustomFunction(new CustomTanIntegralFormattable());
            //</gclCustomInMemory>
            //</gclCustomQuery>
            InitializeComponent();
            CreateConnectionString();
        }

        void CreateConnectionString() {
            DBFileName = DataDirectoryHelper.GetDataFile("nwind.mdb");
            if (!string.IsNullOrEmpty(DBFileName))
                session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
            // A session will not automatically create the database or update database schema.
            session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
        }
        void CreateSessionInMemory() {
            //CustomTanIntegral customTanIntegral = new CustomTanIntegral();
            InMemoryDataStore inMemory = new InMemoryDataStore();
            sessionInMemory = new UnitOfWork(new SimpleDataLayer(inMemory));

            //inMemory.RegisterCustomFunctionOperator(customTanIntegral);
            //sessionInMemory.Dictionary.CustomFunctionOperators.Add(customTanIntegral);
        }

        void CreateSessionDatabase() {
            //CustomTanIntegralFormattable customTanIntegral = new CustomTanIntegralFormattable();
            AccessConnectionProvider provider = (AccessConnectionProvider)AccessConnectionProvider.CreateProviderFromConnection(dbConnection, AutoCreateOption.None);
            sessionDataBase = new UnitOfWork(new SimpleDataLayer(provider));

            //provider.RegisterCustomFunctionOperator(customTanIntegral);
            //sessionDataBase.Dictionary.CustomFunctionOperators.Add(customTanIntegral);
        }

        void CopyDataFromDbToInMemory() {
            //sessionInMemory.DataLayer.UpdateSchema(false,
            //    sessionInMemory.DataLayer.Dictionary.GetClassInfo(typeof(XPObjectType)),
            //    sessionInMemory.DataLayer.Dictionary.GetClassInfo(typeof(CustomOrderDetails)));

            XPCollection<OrderDetails> ordersInDB = new XPCollection<OrderDetails>(sessionDataBase);
            foreach (OrderDetails order in ordersInDB) {
                CustomOrderDetails orderInMemory = new CustomOrderDetails(sessionInMemory);
                orderInMemory.Discount = order.Discount;
                orderInMemory.Quantity = order.Quantity;
                orderInMemory.UnitPrice = order.UnitPrice;
                orderInMemory.Save();
            }
            sessionInMemory.CommitChanges();
        }


        void PrepareCustomDataSource() {
            XPView viewInMemory = new XPView(sessionInMemory, typeof(CustomOrderDetails));
            viewInMemory.AddProperty("X", "UnitPrice", true, true, SortDirection.Ascending);
            viewInMemory.AddProperty("C", "Quantity", true, true, SortDirection.Ascending);
            viewInMemory.AddProperty("CustomTanIntegral(UnitPrice, Quantity)", "CustomTanIntegral(UnitPrice, Quantity)");
            gclCustomInMemory.DataSource = viewInMemory;

            XPView viewDataBase = new XPView(sessionDataBase, typeof(OrderDetails));
            viewDataBase.AddProperty("X", "UnitPrice", true, true, SortDirection.Ascending);
            viewDataBase.AddProperty("C", "Quantity", true, true, SortDirection.Ascending);
            viewDataBase.AddProperty("CustomTanIntegral(UnitPrice, Quantity)", "CustomTanIntegral(UnitPrice, Quantity)");
            gclCustomQuery.DataSource = viewDataBase;
        }

        //<gclGetYearGroup>
        [OptimisticLocking(false)]
        public class Employees : XPBaseObject {
            public string Address;
            public DateTime BirthDate;
            public string City;
            public string Country;
            [Key]
            public int EmployeeID;
            public string Extension;
            public string FirstName;
            public DateTime HireDate;
            public string HomePhone;
            public string LastName;
            public string Notes;
            public byte[] Photo;
            public string PostalCode;
            public string Region;
            public int ReportsTo;
            public string Title;
            public string TitleOfCourtesy;
            public Employees(Session session)
                : base(session) {
            }
            [PersistentAlias("GetYear(" + nameof(BirthDate) + ")")]
            public int BirthYear {
                get {
                    return Convert.ToInt32(EvaluateAlias(nameof(BirthYear)));
                }
            }
        }
        //</gclGetYearGroup>


        public class CustomOrderDetails : XPBaseObject {
            public CustomOrderDetails(Session session)
                : base(session) {
            }
            [Key(true)]
            public int Oid;
            public System.Single Discount;
            public short Quantity;
            public decimal UnitPrice;
        }


        //<gclMathematic>
        public class MathematicData : XPBaseObject {
            [Key(true)]
            public int Oid;
            public double X;
            public double Y;
            public double Z;
            public MathematicData(Session session)
                : base(session) {
            }
        }
        //</gclMathematic>

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            if (firstShow[xtraTabControl1.SelectedTabPageIndex]) {
                firstShow[xtraTabControl1.SelectedTabPageIndex] = false;
                switch (xtraTabControl1.SelectedTabPageIndex) {
                    case 1:
                        PrepareMathData();
                        PrepareMathDataSource();
                        break;
                    case 2:
                        PrepareStringDataSource();
                        break;
                    case 3:
                        dbConnection = session1.Connection;
                        CreateSessionInMemory();
                        CreateSessionDatabase();
                        CopyDataFromDbToInMemory();
                        PrepareCustomDataSource();
                        break;
                    default:
                        break;
                }
            }
        }

        void PrepareMathData() {
            for (int i = 0; i < 30; i++) {
                MathematicData data = new MathematicData(session2);
                data.X = (i + 1) / 30.0;
                data.Y = i * 30.7 - 450.0;
                data.Z = (30 - i) * 40.2;
                data.Save();
            }
            session2.CommitChanges();
        }

        //<gclMathematic>
        void PrepareMathDataSource() {
            XPView view = new XPView(session2, typeof(MathematicData));
            view.AddProperty("X", "X");
            view.AddProperty("Cos(X)", "Cos(X)");
            view.AddProperty("ACos(X)", "Acos(X)");
            view.AddProperty("Tan(X)", "Tan(X)");
            view.AddProperty("Y", "Y");
            view.AddProperty("Round(Y)", "Round(Y)");
            view.AddProperty("Floor(Y)", "Floor(Y)");
            view.AddProperty("Sign(Y)", "Sign(Y)");
            view.AddProperty("Z", "Z");
            view.AddProperty("Power(Abs(Y), Z / 500)", "Power(Abs(Y), Z / 500)");
            view.AddProperty("Sqr(Z)", "Sqr(Z)");
            gclMathematic.DataSource = view;
        }
        //</gclMathematic>

        //<gclStrings>
        void PrepareStringDataSource() {
            XPView view = new XPView(session1, typeof(Customers));
            view.AddProperty("CompanyName", "CompanyName");
            view.AddProperty("Substring(CompanyName, 2, 5)", "Substring(CompanyName, 2, 5)");
            view.AddProperty("Insert(CompanyName, 2, '#TestString#')", "Insert(CompanyName, 2, '#TestString#')");
            view.AddProperty("Country", "Country");
            view.AddProperty("Concat('#', Padleft(Country, 20))", "Concat('#', Padleft(Country, 20))");
            gclStrings.DataSource = view;
        }
        //</gclStrings>

        private void splitContainerControl1_Resize(object sender, EventArgs e) {
            splitContainerControl1.SplitterPosition = xtpCustom.Width / 2;
        }

        bool inScroll = false;
        private void gridView4_TopRowChanged(object sender, EventArgs e) {
            if (inScroll) return;
            inScroll = true;
            try {
                gvlCustomQuery.TopRowIndex = gvlCustomInMemory.TopRowIndex;
            } finally {
                inScroll = false;
            }
        }

        private void gridView5_TopRowChanged(object sender, EventArgs e) {
            if (inScroll) return;
            inScroll = true;
            try {
                gvlCustomInMemory.TopRowIndex = gvlCustomQuery.TopRowIndex;
            } finally {
                inScroll = false;
            }
        }

    }

    //<gclCustomQuery>
    //<gclCustomInMemory>
    public class CustomTanIntegral : ICustomFunctionOperator {
        public object Evaluate(params object[] operands) {
            double x = Convert.ToDouble(operands[0]);
            double c = Convert.ToDouble(operands[1]);
            return -Math.Log(Math.Abs(Math.Cos(x))) + c;
        }
        public string Name {
            get { return "CustomTanIntegral"; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(double);
        }
    }

    public class CustomTanIntegralFormattable : CustomTanIntegral, ICustomFunctionOperatorFormattable {
        public string Format(Type providerType, params string[] operands) {
            if (providerType.Name == "AccessConnectionProvider") {
                return string.Format(CultureInfo.InvariantCulture, "-Log(Abs(Cos({0}))) + {1}", operands[0], operands[1]);
            }
            throw new NotImplementedException(providerType.Name);
        }
    }
    //</gclCustomInMemory>
    //</gclCustomQuery>

}


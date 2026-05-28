using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Management;
using DevExpress.Internal;
using DevExpress.Skins;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.RealtorWorld.Win {
    public enum PropertyType {
        [Description("Single Family Home")]
        SingleFamilyHome,
        [Description("Condo/Townhouse")]
        Townhome,
        [Description("Multi-Family Home")]
        MultiFamilyHome
    };

    public enum PropertyStatus {
        [Description("New Construction")]
        NewConstruction,
        [Description("Foreclosures")]
        Foreclosures,
        [Description("Recently Sold")]
        RecentlySold
    };

    public class Home {
        DataRow row;
        Image photo, plan;
        List<Image> photos;
        string features;
        public Home(DataRow row) {
            this.row = row;
            features = DataHelper.GetFeaturesFormat(string.Format("{0}", row["Features"]));
            if(!(row["Photo"] is DBNull))
                photo = ByteImageConverter.FromByteArray((byte[])row["Photo"]);
        }
        public int ID { get { return (int)row["ID"]; } }
        public string Address { get { return string.Format("{0}", row["Address"]); } }
        public string BathsString { get { return string.Format("{0}", row["Baths"]); } }
        public string BedsString { get { return string.Format("{0}", row["Beds"]); } }
        public string HouseSizeString { get { return string.Format("{0:n0} Sq Ft", row["HouseSize"]); } }
        public short Baths { get { return (short)row["Baths"]; } }
        public short Beds { get { return (short)row["Beds"]; } }
        public double HouseSize { get { return Convert.ToDouble(row["HouseSize"]); } }
        public string LotSize { get { return string.Format("{0} Acres", row["LotSize"]); } }
        public decimal Price { get { return Convert.ToDecimal(row["Price"]); } }
        public string PriceString { get { return string.Format("{0:c0}", Price); } }
        public string YearBuilt { get { return string.Format("{0}", row["YearBuilt"]); } }
        public Image Photo { get { return photo; } }
        public Image Plan {
            get {
                if(plan == null)
                    plan = DataHelper.GetLayoutByID(ID);
                return plan;
            }
        }
        public string Features { get { return features; } }
        public string FeaturesString { get { return string.Format("{0}", row["Features"]); } }
        public string Type { get { return DevExpress.Utils.EnumExtensions.GetEnumItemDisplayText((PropertyType)row["Type"]); } }
        public string Status { get { return DevExpress.Utils.EnumExtensions.GetEnumItemDisplayText((PropertyStatus)row["Status"]); } }
        public List<Image> Photos {
            get {
                if(photos == null)
                    photos = DataHelper.GetPhotos(this);
                return photos;
            }
        }
    }

    public class Agent {
        DataRow person;
        Image photo;
        public Agent(DataRow person) {
            this.person = person;
            if(!(person["Photo"] is DBNull))
                photo = ByteImageConverter.FromByteArray((byte[])person["Photo"]);
        }
        public string FirstName { get { return string.Format("{0}", person["FirstName"]); } }
        public string LastName { get { return string.Format("{0}", person["LastName"]); } }
        public string Phone { get { return string.Format("{0}", person["Phone"]); } }
        public Image Photo { get { return photo; } }
        public string Email { get { return string.Format("{0}", person["Email"]); } }
        public int ID { get { return (int)person["ID"]; } }
    }

    public class MortgageRate {
        DataRow mortgageRate;

        public DateTime Date { get { return (DateTime)mortgageRate["Date"]; } }
        public double FRM30 { get { return (double)mortgageRate["FRM30"]; } }
        public double FRM15 { get { return (double)mortgageRate["FRM15"]; } }
        public double ARM1 { get { return (double)mortgageRate["ARM1"]; } }

        public MortgageRate(DataRow mortgageRate) {
            this.mortgageRate = mortgageRate;
        }
    }

    public class LoanPayment {
        int monthNumber;
        double balance, interest, principal;
        DateTime month;
        public LoanPayment(double balance, double monthlyPayment, int month, double interestRate, DateTime startMonth) {
            this.monthNumber = month;
            this.month = startMonth.AddMonths(month - 1);
            this.interest = Trunc2(balance * interestRate);
            this.principal = Trunc2(monthlyPayment - this.interest);
            this.balance = Trunc2(balance - this.principal);
        }
        public void UpdateBalance() {
            if(this.balance < 0) this.principal += this.balance;
            this.balance = 0;
        }

        public DateTime Month { get { return month; } }
        public int MonthNumber { get { return monthNumber; } }
        public double MonthlyPayment { get { return Interest + Principal; } }
        public double Balance { get { return balance; } }
        public double Interest { get { return interest; } }
        public double Principal { get { return principal; } }
        public string MonthString { get { return string.Format("{0}<size=-2> ({1:MMMM, yyyy})", MonthNumber, Month); } }
        public static double Trunc2(double val) {
            return Convert.ToDouble(Convert.ToInt64(val * 100)) / 100;
        }
        public static List<LoanPayment> Calculate(double loanAmount, double interestRate, double months, DateTime startMonth, out double payment) {
            payment = (loanAmount * interestRate) / (1 - Math.Exp((-months) * Math.Log(1 + interestRate)));
            payment = LoanPayment.Trunc2(payment);
            List<LoanPayment> payments = new List<LoanPayment>();
            double balance = loanAmount;
            for(int i = 1; i <= Convert.ToInt32(months); i++) {
                LoanPayment lp = new LoanPayment(balance, payment, i, interestRate, startMonth);
                balance = lp.Balance;
                payments.Add(lp);
                if(lp.Balance <= 0) break;
            }
            payments[payments.Count - 1].UpdateBalance();
            return payments;
        }
        public static void InitStartMonth(ImageComboBoxEdit edit) {
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            for(int i = 1; i < 7; i++)
                edit.Properties.Items.Add(new ImageComboBoxItem(string.Format("{0:MMMM, yyyy}", start.AddMonths(i)), start.AddMonths(i), -1));
            edit.SelectedIndex = 0;
        }
        public static void InitTermOfLoan(ImageComboBoxEdit edit) {
            int[] terms = new int[] { 1, 5, 10, 15, 20, 25, 30 };
            foreach(int term in terms)
                edit.Properties.Items.Add(new ImageComboBoxItem(string.Format("{0} year{1}", term, term == 1 ? string.Empty : "s"), term, -1));
            edit.SelectedIndex = 3;
        }
        public static void InitInterestRateData(ImageComboBoxEdit edit) {
            for(double i = 2.5; i < 15; i += 0.125)
                edit.Properties.Items.Add(new ImageComboBoxItem(string.Format("{0:n3} %", i), i, -1));
            edit.SelectedIndex = 25;
        }
        public static string GetMonthString(int month, List<LoanPayment> data) {
            foreach(LoanPayment payment in data)
                if(payment.MonthNumber.Equals(month)) return StringPainter.Default.RemoveFormat(payment.MonthString);
            return string.Empty;
        }
    }

    public class PaymentTypeSum {
        double interestSum = 0;
        double principalSum = 0;
        public PaymentTypeSum() {
            interestSum = 0;
            principalSum = 0;
        }
        public double InterestSum { get { return interestSum; } }
        public double PrincipalSum { get { return principalSum; } }
        public void AddToSum(double value1, double value2) {
            interestSum += value1;
            principalSum += value2;
        }
    }

    public class AppConst {
        public const int TileSize = 170;
        public static string HtmlInformationColor {
            get {
                Color color = CommonColors.GetInformationColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
                return GetRGBColor(color);
            }
        }
        public static string HtmlHighlightTextColor {
            get {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HighlightText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlTextColor {
            get {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
                return GetRGBColorHighlight(color);
            }
        }
        public static string HtmlWindowTextColor {
            get {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
                return GetRGBColor(color);
            }
        }
        static string GetRGBColor(Color color) {
            return string.Format("{0},{1},{2}", color.R, color.G, color.B);
        }
        static string GetRGBColorHighlight(Color color) {
            return string.Format("{0},{1},{2}", GetHighlight(color.R), GetHighlight(color.G), GetHighlight(color.B));
        }

        private static byte GetHighlight(byte p) {
            int ret = p - 50;
            if(ret < 0) ret = 0;
            return (byte)ret;
        }
    }

    public class DataHelper {
        static BackgroundWorker worker = new BackgroundWorker();
        static WMIService wmiService;
        static DataTable photos;
        static DataTable housesSales;
        static List<Home> homes = null;
        static List<Agent> agents = null;
        static List<MortgageRate> mortgageRates = null;
        static DataTable PhotosTable {
            get {
                if(photos == null) {
                    DataSet temp = new DataSet();
                    temp.ReadXml(DataDirectoryHelper.GetDataFile("HomePhotos.xml"));
                    photos = temp.Tables[0];
                }
                return photos;
            }
        }
        static DataTable GetMortgageRatesTable() {
            DataSet temp = new DataSet();
            temp.ReadXml(DataDirectoryHelper.GetDataFile("Mortgage.xml"));
            return temp.Tables[0];
        }
        public static DataTable GetHousesSalesTable() {
            if(housesSales == null) {
                DataSet temp = new DataSet();
                temp.ReadXml(DataDirectoryHelper.GetDataFile("HousesSales.xml"));
                housesSales = temp.Tables[0];
            }
            return housesSales;
        }
        public static List<Home> Homes {
            get {
                if(homes == null)
                    homes = GetHomes();
                return homes;
            }
        }
        public static List<Agent> Agents {
            get {
                if(agents == null)
                    agents = GetAgents();
                return agents;
            }
        }
        public static List<MortgageRate> MortgageRates {
            get {
                if(mortgageRates == null)
                    mortgageRates = GetMortgageRates();
                return mortgageRates;
            }
        }
        internal static List<Image> GetPhotos(Home home) {
            List<Image> ret = new List<Image>();
            ret.Add(home.Photo);
            foreach(DataRow row in PhotosTable.Rows) {
                int id = home.ID % 7 + 1;
                if(id.Equals(row["ParentID"]))
                    ret.Add(ByteImageConverter.FromByteArray((byte[])row["Photo"]));
            }
            return ret;
        }
        public static Image GetLayoutByID(int ID) {
            string imageName = DataDirectoryHelper.GetDataFile(Path.Combine("Images", $"HomePlan{ID % 5 + 1}.jpg"));
            return imageName != string.Empty ? Image.FromFile(imageName) : null;
        }
        static List<Home> GetHomes() {
            List<Home> ret = new List<Home>();
            DataSet temp = new DataSet();
            string dbName = DataDirectoryHelper.GetDataFile("Homes.xml");
            if(string.IsNullOrEmpty(dbName)) return ret;
            temp.ReadXml(dbName);
            foreach(DataRow row in temp.Tables["Homes"].Rows)
                ret.Add(new Home(row));
            return ret;
        }
        static List<Agent> GetAgents() {
            List<Agent> ret = new List<Agent>();
            DataSet temp = new DataSet();
            string dbName = DataDirectoryHelper.GetDataFile("Homes.xml");
            if(string.IsNullOrEmpty(dbName)) return ret;
            temp.ReadXml(dbName);
            foreach(DataRow row in temp.Tables["Agents"].Rows)
                ret.Add(new Agent(row));
            return ret;
        }
        static List<MortgageRate> GetMortgageRates() {
            DataTable table = GetMortgageRatesTable();
            List<MortgageRate> rates = new List<MortgageRate>();
            foreach(DataRow row in table.Rows)
                rates.Add(new MortgageRate(row));
            return rates;
        }
        public static string GetFeaturesFormat(string text) {
            string[] features = text.Split(',');
            string ret = string.Empty;
            foreach(string feature in features)
                ret += string.Format("• {0}\r\n", feature.Trim());
            return ret;
        }
        public static void InitListingsTile(ITileItem tile) {
            bool animateText = true;
            foreach(Home home in DataHelper.Homes) {
                animateText = true;
                foreach(Image photo in home.Photos) {
                    TileItemFrame info = new TileItemFrame();
                    info.AnimateBackgroundImage = true;
                    info.UseBackgroundImage = true;
                    info.BackgroundImage = photo;
                    info.AnimateText = animateText;
                    info.UseText = true;
                    info.Text2 = string.Format("<backcolor=108,189,69> {0} Beds   <br> {1} Baths  ", home.BedsString, home.BathsString);
                    info.Text3 = string.Format("<backcolor=108,189,69><size=+3> {0} ", home.PriceString);
                    info.Tag = home;
                    animateText = false;
                    tile.Frames.Add(info);
                }
            }
        }
        public static void InitAgentsTile(ITileItem tile, int size) {
            tile.Properties.FrameAnimationInterval = 5100;
            tile.Properties.BackgroundImageAlignment = TileItemContentAlignment.MiddleRight;
            tile.Properties.BackgroundImageScaleMode = TileItemImageScaleMode.NoScale;

            foreach(Agent agent in DataHelper.Agents) {
                TileItemFrame info = new TileItemFrame();
                info.AnimateBackgroundImage = true;
                info.UseBackgroundImage = true;
                info.BackgroundImage = GetScaleImage(agent.Photo, 90);

                info.AnimateText = true;
                info.UseText = true;
                info.Text = string.Format("<size=+4>{0} {1}</size><br>{2}", agent.FirstName, agent.LastName, agent.Phone);
                info.Tag = agent;
                tile.Frames.Add(info);
            }
        }
        public static Bitmap GetScaleImage(Image image, int percent) {
            return new Bitmap(image, image.Width * percent / 100, image.Height * percent / 100);
        }
        public static void InitZillowTile(ITileItem tile) {
            TileItemFrame info = new TileItemFrame();
            info.AnimateImage = true;
            info.AnimateText = true;
            info.UseImage = true;
            info.UseText = true;
            info.Image = global::DevExpress.RealtorWorld.Win.Properties.Resources.zillow_logo;
            info.Text = string.Empty;
            tile.Frames.Add(info);
            info = new TileItemFrame();
            info.AnimateText = true;
            info.AnimateImage = true;
            info.Image = null;
            info.Text = "<size=+2>Your <b>Edge</b> in <b>Real Estate</b>";
            info.UseImage = true;
            info.UseText = true;
            tile.Frames.Add(info);
        }
        public static List<Home> GetHomesByAgent(Agent agent) {
            List<Home> ret = new List<Home>();
            foreach(Home home in Homes)
                if((home.ID % Agents.Count + 1) == agent.ID) ret.Add(home);
            return ret;
        }
        public static Agent GetAgentByHome(Home home) {
            foreach(Agent agent in Agents)
                if((home.ID % Agents.Count + 1) == agent.ID) return agent;
            return null;
        }
        public static WMIService WmiService {
            get {
                CreateWmiService();
                return wmiService;
            }
        }
        internal static void CreateWmiService() {
            if(wmiService == null) {
                worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                worker.RunWorkerAsync();
            }
        }

        static void worker_DoWork(object sender, DoWorkEventArgs e) {
            wmiService = WMIService.GetInstance(null);
        }
        public static void SetTileSelectedItem(object current, TileControl control) {
            foreach(TileItem item in control.Groups[0].Items)
                if(current.Equals(item.Tag)) {
                    control.SelectedItem = item;
                    break;
                }
        }
    }
    public sealed class WMIService : IDisposable {
        public static WMIService GetInstance(string path) {
            return new WMIService(string.IsNullOrEmpty(path) ? "//./root/cimv2" : path);
        }
        bool connectedCore = false;
        ManagementScope scopeCore;
        Dictionary<string, ManagementObjectCollection> queryCacheCore;
        Dictionary<string, ManagementObjectCollection> QueryCache {
            get { return queryCacheCore; }
        }
        public bool Connected { get { return connectedCore; } }
        public ManagementScope Scope { get { return scopeCore; } }

        WMIService(string path) {
            queryCacheCore = new Dictionary<string, ManagementObjectCollection>();
            ConnectionOptions options = new ConnectionOptions();
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.Authentication = AuthenticationLevel.Packet;
            this.scopeCore = new ManagementScope(path, options);
            try {
                Scope.Connect();
                connectedCore = Scope.IsConnected;
            }
            catch { connectedCore = false; }
        }
        ManagementObjectCollection GetManagementObjectCollection(string queryString) {
            ManagementObjectCollection result = null;
            ObjectQuery query = new ObjectQuery(queryString);
            using(ManagementObjectSearcher searcher = new ManagementObjectSearcher(Scope, query))
                result = searcher.Get();
            return result;
        }
        public void Dispose() {
            connectedCore = false;
            if(queryCacheCore != null) {
                foreach(KeyValuePair<string, ManagementObjectCollection> pair in queryCacheCore) {
                    if(pair.Value != null) pair.Value.Dispose();
                }
                queryCacheCore.Clear();
                queryCacheCore = null;
            }
            scopeCore = null;
        }
        public ManagementObjectCollection GetObjectCollection(string queryString, bool allowQueryCaching) {
            ManagementObjectCollection result = null;
            if(allowQueryCaching) QueryCache.TryGetValue(queryString, out result);
            if(result == null) {
                result = GetManagementObjectCollection(queryString);
                if(allowQueryCaching) {
#pragma warning disable CA1864
                    if(QueryCache.ContainsKey(queryString)) QueryCache[queryString] = result;
                    else QueryCache.Add(queryString, result);
#pragma warning restore CA1864
                }
            }
            return result;
        }
        public ManagementObject[] GetObjects(string queryString, bool allowQueryCaching) {
            ManagementObject[] result = new ManagementObject[0];
            ManagementObjectCollection collection = GetObjectCollection(queryString, allowQueryCaching);
            if(collection != null && collection.Count > 0) {
                result = new ManagementObject[collection.Count];
                collection.CopyTo(result, 0);
            }
            return result;
        }
    }
}

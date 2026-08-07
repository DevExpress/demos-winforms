using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {

    class TemperatureData {
        const int PointsCount = 250;

        readonly TemperaturePoint maxTemperaturePoint = new TemperaturePoint(TimeSpan.Zero, double.MinValue);
        readonly TemperaturePoint minTemperaturePoint = new TemperaturePoint(TimeSpan.MaxValue, double.MaxValue);
        readonly List<TemperaturePoint> data = new List<TemperaturePoint>(PointsCount);

        internal TemperaturePoint MaxTemperaturePoint {
            get { return maxTemperaturePoint; }
        }
        internal TemperaturePoint MinTemperaturePoint {
            get { return minTemperaturePoint; }
        }
        internal double OptimalTemperature {
            get { return 53; }
        }
        internal List<TemperaturePoint> Data {
            get { return data; }
        }

        internal TemperatureData() {
            NonCryptographicRandom random = new NonCryptographicRandom(9);
            double preTemperature = 50;
            for(int i = 0; i < PointsCount; i++) {
                TimeSpan time = TimeSpan.FromSeconds(i);
                double temperature = preTemperature + (random.NextDouble() - 0.5) * 10;
                if(temperature > 90)
                    temperature -= 20;
                if(temperature < 20)
                    temperature += 10;
                TemperaturePoint temperaturePoint = new TemperaturePoint(time, temperature);
                if(temperature < minTemperaturePoint.Temperature)
                    minTemperaturePoint = temperaturePoint;
                if(temperature > maxTemperaturePoint.Temperature)
                    maxTemperaturePoint = temperaturePoint;
                data.Add(temperaturePoint);
                preTemperature = temperature;
            }
        }
    }


    static class MovieData {
        public static List<BubbleDataItem> GetData() {
            return new List<BubbleDataItem>() {
                new BubbleDataItem(new DateTime(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean: At World's End"),
                new BubbleDataItem(new DateTime(2008, 1, 1), 185, 1.004, "The Dark Knight"),
                new BubbleDataItem(new DateTime(2009, 1, 1), 237, 2.788, "Avatar"),
                new BubbleDataItem(new DateTime(2010, 1, 1), 200, 1.067, "Toy Story 3"),
                new BubbleDataItem(new DateTime(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows Part 2"),
                new BubbleDataItem(new DateTime(2012, 1, 1), 220, 1.519, "Marvel's The Avengers"),
                new BubbleDataItem(new DateTime(2013, 1, 1), 150, 1.276, "Frozen"),
                new BubbleDataItem(new DateTime(2014, 1, 1), 210, 1.104, "Transformers: Age of Extinction"),
                new BubbleDataItem(new DateTime(2015, 1, 1), 245, 2.068, "Star Wars: The Force Awakens"),
                new BubbleDataItem(new DateTime(2016, 1, 1), 250, 1.153, "Captain America: Civil War"),
            };
        }
    }


    class DevAV {
        internal static int GetLastYear() {
            return TutorialConstants.Now.Year - 1;
        }
        internal static DataTable GetSales() {
            int prevYear = TutorialConstants.Now.Year - 1;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(int)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

            table.Rows.Add(prevYear - 2, "Asia", 4.2372D);
            table.Rows.Add(prevYear - 2, "Australia", 1.7871D);
            table.Rows.Add(prevYear - 2, "Europe", 3.0884D);
            table.Rows.Add(prevYear - 2, "North America", 3.4855D);
            table.Rows.Add(prevYear - 2, "South America", 1.6027D);

            table.Rows.Add(prevYear - 1, "Asia", 4.7685D);
            table.Rows.Add(prevYear - 1, "Australia", 1.9576D);
            table.Rows.Add(prevYear - 1, "Europe", 3.3579D);
            table.Rows.Add(prevYear - 1, "North America", 3.7477D);
            table.Rows.Add(prevYear - 1, "South America", 1.8237D);

            table.Rows.Add(prevYear, "Asia", 5.2890D);
            table.Rows.Add(prevYear, "Australia", 2.2727D);
            table.Rows.Add(prevYear, "Europe", 3.7257D);
            table.Rows.Add(prevYear, "North America", 4.1825D);
            table.Rows.Add(prevYear, "South America", 2.1172D);

            return table;
        }
        internal static DataTable GetSalesMixByRegion() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("ProductCategory", typeof(string)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

            table.Rows.Add("Video players", "Asia", 853D);
            table.Rows.Add("Video players", "Australia", 321D);
            table.Rows.Add("Video players", "Europe", 655D);
            table.Rows.Add("Video players", "North America", 1325D);
            table.Rows.Add("Video players", "South America", 653D);

            table.Rows.Add("Automation", "Asia", 172D);
            table.Rows.Add("Automation", "Australia", 255D);
            table.Rows.Add("Automation", "Europe", 981D);
            table.Rows.Add("Automation", "North America", 963D);
            table.Rows.Add("Automation", "South America", 123D);

            table.Rows.Add("Monitors", "Asia", 1011D);
            table.Rows.Add("Monitors", "Australia", 359D);
            table.Rows.Add("Monitors", "Europe", 721D);
            table.Rows.Add("Monitors", "North America", 565D);
            table.Rows.Add("Monitors", "South America", 532D);

            table.Rows.Add("Projectors", "Asia", 998D);
            table.Rows.Add("Projectors", "Australia", 222D);
            table.Rows.Add("Projectors", "Europe", 865D);
            table.Rows.Add("Projectors", "North America", 787D);
            table.Rows.Add("Projectors", "South America", 332D);

            table.Rows.Add("Televisions", "Asia", 1356D);
            table.Rows.Add("Televisions", "Australia", 232D);
            table.Rows.Add("Televisions", "Europe", 1323D);
            table.Rows.Add("Televisions", "North America", 1125D);
            table.Rows.Add("Televisions", "South America", 865D);

            return table;
        }
        internal static DataTable GetBranchesSales() {
            int lastYear = TutorialConstants.Now.Year - 1;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("Year", typeof(DateTime)),
                new DataColumn("Company", typeof(string)),
                new DataColumn("Sales", typeof(decimal)),
                new DataColumn("Charges", typeof(decimal)),
                new DataColumn("Penalties", typeof(decimal)),
            });

            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010, 0.430, 0);
            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV Central", 3.032, 0.412, 0);
            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31, 0.312, 0);

            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512, 0.351, 0.0012);
            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV Central", 3.050, 0.411, 0);
            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34, 0.333, 0);

            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723, 0.431, 0.0027);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005, 0.215, 0.00021);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV Central", 3.054, 0.315, 0.001);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30, 0.410, 0);

            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31, 0.412, 0);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001, 0.321, 0);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV Central", 2.975, 0.327, 0);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283, 0.412, 0);

            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41, 0.323, 0);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612, 0.411, 0);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV Central", 2.066, 0.442, 0);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88, 0.398, 0);

            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95, 0398, 0);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666, 0.389, 0.012);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV Central", 2.078, 0.421, 0.124);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09, 0.401, 0);

            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53, 0.435, 0);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665, 0.444, 0);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV Central", 3.888, 0.381, 0);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01, 0.412, 0);

            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV East", 0.003, 0.332, 0);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75, 0.412, 0);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555, 0.229, 0.0012);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV Central", 3.008, 0.431, 0);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11, 0.223, 0.0012);

            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32, 0.450, 0);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31, 0.413, 0);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485, 0.426, 0);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV Central", 3.088, 0.385, 0);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12, 0.338, 0);

            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51, 0.325, 0);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31, 0.421, 0);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747, 0.324, 0);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV Central", 3.357, 0.441, 0);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12, 0.524, 0);

            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV East", 1.71, 0.998, 0);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV West", 1.22, 0.324, 0);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV North", 4.182, 0.325, 0);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV Central", 3.725, 0.341, 0);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV South", 1.111, 0.439, 0);

            return table;
        }
        internal static DataTable GetSalesByLast10Years() {
            int lastYear = TutorialConstants.Now.Year - 1;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "North America", 3.010M);
            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "Europe", 3.032M);
            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "Australia", 1.31M);

            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "North America", 3.212M);
            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "Europe", 3.050M);
            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "Australia", 1.64M);

            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "North America", 3.223M);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "Europe", 3.054M);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "Australia", 1.70M);

            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "North America", 3.001M);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "Europe", 2.775M);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "Australia", 1.083M);

            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "North America", 2.612M);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "Europe", 2.066M);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "Australia", 0.88M);

            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "North America", 2.666M);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "Europe", 2.078M);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "Australia", 1.09M);

            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "North America", 3.665M);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "Europe", 3.888M);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "Australia", 2.01M);

            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "North America", 3.555M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "Europe", 3.008M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "Australia", 1.85M);

            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "North America", 3.485M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "Europe", 3.088M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "Australia", 1.78M);

            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "North America", 3.747M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "Europe", 3.357M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "Australia", 1.957M);

            table.Rows.Add(new DateTime(lastYear, 12, 31), "North America", 4.182M);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "Europe", 3.725M);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "Australia", 2.272M);

            return table;
        }
        internal static DataTable GetOutsideVendorCosts() {
            int lastYear = TutorialConstants.Now.Year - 1;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Company", typeof(string)), new DataColumn("Costs", typeof(decimal)) });

            table.Rows.Add(new DateTime(lastYear - 6, 1, 1), "DevAV North", 362.5M);
            table.Rows.Add(new DateTime(lastYear - 5, 1, 1), "DevAV North", 348.4M);
            table.Rows.Add(new DateTime(lastYear - 4, 1, 1), "DevAV North", 279.0M);
            table.Rows.Add(new DateTime(lastYear - 3, 1, 1), "DevAV North", 230.9M);
            table.Rows.Add(new DateTime(lastYear - 2, 1, 1), "DevAV North", 203.5M);
            table.Rows.Add(new DateTime(lastYear - 1, 1, 1), "DevAV North", 197.1M);

            table.Rows.Add(new DateTime(lastYear - 6, 1, 1), "DevAV South", 277.0M);
            table.Rows.Add(new DateTime(lastYear - 5, 1, 1), "DevAV South", 328.5M);
            table.Rows.Add(new DateTime(lastYear - 4, 1, 1), "DevAV South", 297.0M);
            table.Rows.Add(new DateTime(lastYear - 3, 1, 1), "DevAV South", 255.3M);
            table.Rows.Add(new DateTime(lastYear - 2, 1, 1), "DevAV South", 173.5M);
            table.Rows.Add(new DateTime(lastYear - 1, 1, 1), "DevAV South", 131.8M);

            return table;
        }
        internal static List<DevAVDataItem> GetBranchesSalesList() {
            int lastYear = GetLastYear();

            List<DevAVDataItem> list = new List<DevAVDataItem>(46);

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010M, 0.430M, 0.0112M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 10, 12, 31), "DevAV Central", 3.032M, 0.412M, 0.0012M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31M, 0.312M, 0.301M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512M, 0.351M, 0.0012M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 9, 12, 31), "DevAV Central", 3.050M, 0.411M, 0.286M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34M, 0.333M, 0.11M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723M, 0.431M, 0.27M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005M, 0.215M, 0.0021M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 8, 12, 31), "DevAV Central", 3.054M, 0.315M, 0.101M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30M, 0.410M, 0.075M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31M, 0.412M, 0.03M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001M, 0.321M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 7, 12, 31), "DevAV Central", 2.975M, 0.327M, 0.0045M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283M, 0.412M, 0.205M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41M, 0.323M, 0.001M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612M, 0.411M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 6, 12, 31), "DevAV Central", 2.066M, 0.442M, 0.34M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88M, 0.398M, 0.206M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95M, 0.398M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666M, 0.389M, 0.012M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 5, 12, 31), "DevAV Central", 2.078M, 0.421M, 0.124M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09M, 0.401M, 0M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53M, 0.435M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665M, 0.444M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 4, 12, 31), "DevAV Central", 3.888M, 0.381M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01M, 0.412M, 0M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 3, 12, 31), "DevAV East", 0.003M, 0.332M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75M, 0.412M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555M, 0.229M, 0.0012M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 3, 12, 31), "DevAV Central", 3.008M, 0.431M, 0M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11M, 0.223M, 0.0012M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32M, 0.450M, 0.25M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31M, 0.413M, 0.01M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485M, 0.426M, 0.056M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 2, 12, 31), "DevAV Central", 3.088M, 0.385M, 0.113M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12M, 0.338M, 0.36M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51M, 0.325M, 0.055M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31M, 0.421M, 0.3205M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747M, 0.324M, 0.148M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 1, 12, 31), "DevAV Central", 3.357M, 0.441M, 0.086M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12M, 0.524M, 0.201M));

            list.Add(CreateByDateCompanySales(new DateTime(lastYear, 12, 31), "DevAV East", 1.71M, 0.298M, 0.105M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear, 12, 31), "DevAV West", 1.22M, 0.324M, 0.0356M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear, 12, 31), "DevAV North", 4.182M, 0.325M, 0.217M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear, 12, 31), "DevAV Central", 3.725M, 0.341M, 0.118M));
            list.Add(CreateByDateCompanySales(new DateTime(lastYear, 12, 31), "DevAV South", 1.111M, 0.439M, 0.0397M));

            return list;
        }
        static DevAVDataItem CreateByDateCompanySales(DateTime date, string company, decimal sales, decimal charges, decimal penalties) {
            DevAVDataItem item = new DevAVDataItem();
            item.Company = company;
            item.SaleDate = date;
            item.Sales = sales;
            item.Year = date.Year;
            item.Charges = charges;
            item.Penalties = penalties;
            return item;
        }
        static string[] GetCompainyNames() {
            return new string[] {
                "DevAV East",
                "DevAV West",
                "DevAV North",
                "DevAV Central",
                "DevAV South",
            };
        }
        internal static void InitializeCompanyImages(ImageCollection images, Func<string, Color> getColor) {
            string[] companyNames = GetCompainyNames();
            for(int i = 0; i < companyNames.Length; i++)
                images.AddImage(GetCompanyImage(getColor(companyNames[i]), images.ImageSize), companyNames[i]);
        }
        internal static void UpdateCompanyImages(ImageCollection images, Func<string, Color> getColor) {
            string[] companyNames = GetCompainyNames();
            for(int i = 0; i < companyNames.Length; i++)
                images.Images[companyNames[i]] = GetCompanyImage(getColor(companyNames[i]), images.ImageSize);
        }
        static Image GetCompanyImage(Color color, Size imageSize) {
            Bitmap img = new Bitmap(imageSize.Width, imageSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using(Graphics g = Graphics.FromImage(img))
                g.Clear(color);
            return img;
        }
    }


    class SourceOfEnergy {
        internal static DataTable GetEuropeBrentPrices() {
            DataTable table = new DataTable("Europe Brent");
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Min", typeof(float)), new DataColumn("Max", typeof(float)) });
            table.Rows.Add(new DateTime(2015, 01, 1), 45.13, 55.38);
            table.Rows.Add(new DateTime(2015, 02, 1), 51.74, 61.89);
            table.Rows.Add(new DateTime(2015, 03, 1), 52.00, 61.18);
            table.Rows.Add(new DateTime(2015, 04, 1), 55.73, 63.97);
            table.Rows.Add(new DateTime(2015, 05, 1), 60.12, 66.33);
            table.Rows.Add(new DateTime(2015, 06, 1), 59.03, 64.68);
            table.Rows.Add(new DateTime(2015, 07, 1), 53.29, 61.73);
            table.Rows.Add(new DateTime(2015, 08, 1), 41.59, 49.49);
            table.Rows.Add(new DateTime(2015, 09, 1), 45.87, 50.41);
            table.Rows.Add(new DateTime(2015, 10, 1), 45.54, 52.13);
            table.Rows.Add(new DateTime(2015, 11, 1), 40.28, 48.00);
            table.Rows.Add(new DateTime(2015, 12, 1), 35.26, 42.97);
            return table;
        }
        internal static DataTable GetOkWtiPrices() {
            DataTable table = new DataTable("OK WTI");
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Min", typeof(float)), new DataColumn("Max", typeof(float)) });
            table.Rows.Add(new DateTime(2015, 01, 1), 44.08, 52.72);
            table.Rows.Add(new DateTime(2015, 02, 1), 47.65, 49.84);
            table.Rows.Add(new DateTime(2015, 03, 1), 43.39, 51.53);
            table.Rows.Add(new DateTime(2015, 04, 1), 49.13, 59.62);
            table.Rows.Add(new DateTime(2015, 05, 1), 57.29, 60.93);
            table.Rows.Add(new DateTime(2015, 06, 1), 58.00, 61.36);
            table.Rows.Add(new DateTime(2015, 07, 1), 47.11, 56.94);
            table.Rows.Add(new DateTime(2015, 08, 1), 38.22, 49.20);
            table.Rows.Add(new DateTime(2015, 09, 1), 44.07, 47.12);
            table.Rows.Add(new DateTime(2015, 10, 1), 43.19, 49.67);
            table.Rows.Add(new DateTime(2015, 11, 1), 39.27, 47.88);
            table.Rows.Add(new DateTime(2015, 12, 1), 34.55, 41.08);
            return table;
        }
        internal static DataTable GetGasolinePrices() {
            DataTable table = new DataTable("Gasoline");
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Price", typeof(float)) });
            table.Rows.Add(new DateTime(2015, 01, 1), 2.208);
            table.Rows.Add(new DateTime(2015, 02, 1), 2.301);
            table.Rows.Add(new DateTime(2015, 03, 1), 2.546);
            table.Rows.Add(new DateTime(2015, 04, 1), 2.555);
            table.Rows.Add(new DateTime(2015, 05, 1), 2.802);
            table.Rows.Add(new DateTime(2015, 06, 1), 2.885);
            table.Rows.Add(new DateTime(2015, 07, 1), 2.880);
            table.Rows.Add(new DateTime(2015, 08, 1), 2.726);
            table.Rows.Add(new DateTime(2015, 09, 1), 2.462);
            table.Rows.Add(new DateTime(2015, 10, 1), 2.387);
            table.Rows.Add(new DateTime(2015, 11, 1), 2.260);
            table.Rows.Add(new DateTime(2015, 12, 1), 2.144);
            return table;
        }
        internal static DataTable GetFuelPrices() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Price", typeof(decimal)) });
            table.Rows.Add(new DateTime(2016, 1, 1, 0, 0, 0), 2.143M);
            table.Rows.Add(new DateTime(2016, 2, 1, 0, 0, 0), 1.998M);
            table.Rows.Add(new DateTime(2016, 3, 1, 0, 0, 0), 2.090M);
            table.Rows.Add(new DateTime(2016, 4, 1, 0, 0, 0), 2.152M);
            table.Rows.Add(new DateTime(2016, 5, 1, 0, 0, 0), 2.315M);
            table.Rows.Add(new DateTime(2016, 6, 1, 0, 0, 0), 2.423M);
            table.Rows.Add(new DateTime(2016, 7, 1, 0, 0, 0), 2.405M);
            table.Rows.Add(new DateTime(2016, 8, 1, 0, 0, 0), 2.351M);
            table.Rows.Add(new DateTime(2016, 9, 1, 0, 0, 0), 2.394M);
            table.Rows.Add(new DateTime(2016, 10, 1, 0, 0, 0), 2.454M);
            table.Rows.Add(new DateTime(2016, 11, 1, 0, 0, 0), 2.439M);
            table.Rows.Add(new DateTime(2016, 12, 1, 0, 0, 0), 2.510M);
            return table;
        }
        internal static DataTable GetCoalProduction() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("South Africa", typeof(decimal)), new DataColumn("Poland", typeof(decimal)) });
            table.Rows.Add(new DateTime(2015, 12, 31, 0, 0, 0), 252.099, 135.523);
            table.Rows.Add(new DateTime(2014, 12, 31, 0, 0, 0), 261.523, 137.148);
            table.Rows.Add(new DateTime(2013, 12, 31, 0, 0, 0), 256.562, 142.906);
            table.Rows.Add(new DateTime(2012, 12, 31, 0, 0, 0), 258.575, 144.093);
            table.Rows.Add(new DateTime(2011, 12, 31, 0, 0, 0), 252.756, 139.289);
            table.Rows.Add(new DateTime(2010, 12, 31, 0, 0, 0), 254.521, 133.238);
            table.Rows.Add(new DateTime(2009, 12, 31, 0, 0, 0), 247.820, 135.172);
            table.Rows.Add(new DateTime(2008, 12, 31, 0, 0, 0), 252.213, 144.013);
            table.Rows.Add(new DateTime(2007, 12, 31, 0, 0, 0), 247.666, 145.850);
            table.Rows.Add(new DateTime(2006, 12, 31, 0, 0, 0), 244.774, 156.065);
            table.Rows.Add(new DateTime(2005, 12, 31, 0, 0, 0), 244.985, 159.540);
            table.Rows.Add(new DateTime(2004, 12, 31, 0, 0, 0), 242.821, 161.284);
            table.Rows.Add(new DateTime(2003, 12, 31, 0, 0, 0), 238.751, 163.790);
            table.Rows.Add(new DateTime(2002, 12, 31, 0, 0, 0), 220.212, 161.920);
            table.Rows.Add(new DateTime(2001, 12, 31, 0, 0, 0), 223.560, 163.540);
            table.Rows.Add(new DateTime(2000, 12, 31, 0, 0, 0), 224.199, 162.820);
            table.Rows.Add(new DateTime(1999, 12, 31, 0, 0, 0), 223.514, 172.730);
            table.Rows.Add(new DateTime(1998, 12, 31, 0, 0, 0), 222.976, 178.550);
            table.Rows.Add(new DateTime(1997, 12, 31, 0, 0, 0), 220.072, 200.930);
            table.Rows.Add(new DateTime(1996, 12, 31, 0, 0, 0), 206.362, 201.720);
            table.Rows.Add(new DateTime(1995, 12, 31, 0, 0, 0), 206.210, 200.720);
            table.Rows.Add(new DateTime(1994, 12, 31, 0, 0, 0), 195.805, 200.700);
            table.Rows.Add(new DateTime(1993, 12, 31, 0, 0, 0), 188.214, 198.580);
            table.Rows.Add(new DateTime(1992, 12, 31, 0, 0, 0), 184.045, 198.380);
            table.Rows.Add(new DateTime(1991, 12, 31, 0, 0, 0), 178.390, 209.790);
            table.Rows.Add(new DateTime(1990, 12, 31, 0, 0, 0), 174.780, 215.320);
            return table;
        }
    }

    class PowerConsumption {
        internal static DataTable GetData() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Branch", typeof(string)), new DataColumn("Time", typeof(DateTime)), new DataColumn("Power", typeof(double)) });

            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 7, 0, 0), 429);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 8, 0, 0), 432);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 9, 0, 0), 301);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 10, 0, 0), 307);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 11, 0, 0), 310);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 12, 0, 0), 380);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 13, 0, 0), 384);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 14, 0, 0), 398);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 15, 0, 0), 379);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 16, 0, 0), 220);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 17, 0, 0), 321);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 18, 0, 0), 341);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 19, 0, 0), 368);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 20, 0, 0), 557);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 21, 0, 0), 523);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 22, 0, 0), 501);
            table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 23, 0, 0), 443);

            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 7, 0, 0), 260);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 8, 0, 0), 287);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 9, 0, 0), 285);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 10, 0, 0), 281);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 11, 0, 0), 294);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 12, 0, 0), 303);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 13, 0, 0), 325);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 14, 0, 0), 336);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 15, 0, 0), 325);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 16, 0, 0), 186);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 17, 0, 0), 420);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 18, 0, 0), 455);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 19, 0, 0), 481);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 20, 0, 0), 487);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 21, 0, 0), 490);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 22, 0, 0), 467);
            table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 23, 0, 0), 409);

            return table;
        }
    }


    class PerformanceDataSource : List<PerformanceDataItem> {
        public PerformanceDataSource() {
            Add(new PerformanceDataItem(1, 0.21, 0.22, 0.21, 5, 5, 5));
            Add(new PerformanceDataItem(2, 0.31, 0.11, 0.02, 7, 7, 20));
            Add(new PerformanceDataItem(3, 0.11, 0.21, 0.35, 2, 12, 18));
            Add(new PerformanceDataItem(4, 0.13, 0.25, 0.29, 7, 25, 21));
            Add(new PerformanceDataItem(5, 0.02, 0.10, 0.15, 25, 25, 19));
            Add(new PerformanceDataItem(6, 0.05, 0.11, 0.21, 27, 20, 10));
            Add(new PerformanceDataItem(7, 0.11, 0.15, 0.23, 44, 17, 8));
            Add(new PerformanceDataItem(8, 0.15, 0.20, 0.30, 45, 24, 15));
            Add(new PerformanceDataItem(9, 0.18, 0.25, 0.36, 50, 29, 17));
            Add(new PerformanceDataItem(10, 0.23, 0.12, 0.38, 52, 25, 12));
            Add(new PerformanceDataItem(11, 0.21, 0.08, 0.36, 52, 28, 40));
            Add(new PerformanceDataItem(12, 0.16, 0.08, 0.37, 55, 29, 47));
            Add(new PerformanceDataItem(13, 0.22, 0.27, 0.33, 53, 25, 50));
            Add(new PerformanceDataItem(14, 0.25, 0.29, 0.22, 51, 28, 45));
            Add(new PerformanceDataItem(15, 0.22, 0.31, 0.19, 49, 30, 50));
            Add(new PerformanceDataItem(16, 0.23, 0.34, 0.15, 45, 42, 51));
            Add(new PerformanceDataItem(17, 0.25, 0.40, 0.03, 46, 45, 48));
            Add(new PerformanceDataItem(18, 0.32, 0.54, 0.04, 42, 40, 43));
            Add(new PerformanceDataItem(19, 0.30, 0.51, 0.03, 45, 20, 15));
            Add(new PerformanceDataItem(20, 0.31, 0.45, 0.07, 48, 21, 19));
            Add(new PerformanceDataItem(21, 0.25, 0.40, 0.05, 48, 35, 25));
            Add(new PerformanceDataItem(22, 0.10, 0.43, 0.07, 49, 33, 27));
            Add(new PerformanceDataItem(23, 0.05, 0.45, 0.15, 49, 35, 30));
            Add(new PerformanceDataItem(24, 0.03, 0.44, 0.21, 51, 37, 32));
            Add(new PerformanceDataItem(25, 0.01, 0.42, 0.23, 55, 40, 37));
            Add(new PerformanceDataItem(26, 0.01, 0.45, 0.21, 57, 43, 39));
            Add(new PerformanceDataItem(27, 0.01, 0.43, 0.22, 59, 50, 43));
            Add(new PerformanceDataItem(28, 0.01, 0.39, 0.25, 62, 51, 42));
            Add(new PerformanceDataItem(29, 0.03, 0.27, 0.20, 42, 31, 23));
            Add(new PerformanceDataItem(30, 0.07, 0.25, 0.14, 25, 20, 17));
            Add(new PerformanceDataItem(31, 0.05, 0.12, 0.09, 35, 25, 20));
            Add(new PerformanceDataItem(32, 0.03, 0.10, 0.05, 41, 29, 24));
            Add(new PerformanceDataItem(33, 0.05, 0.08, 0.06, 48, 32, 26));
            Add(new PerformanceDataItem(34, 0.02, 0.09, 0.06, 55, 37, 28));
            Add(new PerformanceDataItem(35, 0.05, 0.11, 0.07, 59, 38, 28));
            Add(new PerformanceDataItem(36, 0.03, 0.13, 0.05, 63, 39, 30));
            Add(new PerformanceDataItem(37, 0.02, 0.15, 0.03, 67, 43, 31));
            Add(new PerformanceDataItem(38, 0.05, 0.12, 0.07, 71, 50, 32));
            Add(new PerformanceDataItem(39, 0.07, 0.16, 0.12, 65, 43, 31));
            Add(new PerformanceDataItem(40, 0.09, 0.25, 0.18, 61, 39, 30));
            Add(new PerformanceDataItem(41, 0.09, 0.23, 0.19, 60, 38, 30));
            Add(new PerformanceDataItem(42, 0.10, 0.25, 0.20, 63, 37, 31));
            Add(new PerformanceDataItem(43, 0.11, 0.22, 0.18, 64, 35, 32));
            Add(new PerformanceDataItem(44, 0.13, 0.31, 0.19, 60, 36, 30));
            Add(new PerformanceDataItem(45, 0.17, 0.33, 0.22, 58, 35, 31));
            Add(new PerformanceDataItem(46, 0.23, 0.30, 0.27, 63, 32, 33));
            Add(new PerformanceDataItem(47, 0.20, 0.25, 0.30, 58, 29, 31));
            Add(new PerformanceDataItem(48, 0.17, 0.23, 0.35, 62, 28, 32));
            Add(new PerformanceDataItem(49, 0.15, 0.25, 0.37, 60, 26, 30));
            Add(new PerformanceDataItem(50, 0.12, 0.22, 0.40, 55, 23, 27));
            Add(new PerformanceDataItem(51, 0.11, 0.20, 0.42, 57, 21, 31));
            Add(new PerformanceDataItem(52, 0.09, 0.18, 0.45, 60, 20, 35));
            Add(new PerformanceDataItem(53, 0.08, 0.17, 0.46, 65, 19, 45));
            Add(new PerformanceDataItem(54, 0.05, 0.10, 0.52, 77, 17, 43));
            Add(new PerformanceDataItem(55, 0.03, 0.12, 0.55, 81, 18, 40));
            Add(new PerformanceDataItem(56, 0.05, 0.09, 0.53, 75, 17, 15));
            Add(new PerformanceDataItem(57, 0.07, 0.12, 0.47, 67, 18, 16));
            Add(new PerformanceDataItem(58, 0.03, 0.09, 0.35, 60, 19, 12));
            Add(new PerformanceDataItem(59, 0.05, 0.12, 0.23, 41, 10, 5));
            Add(new PerformanceDataItem(60, 0.03, 0.07, 0.10, 33, 5, 3));
        }
    }

}

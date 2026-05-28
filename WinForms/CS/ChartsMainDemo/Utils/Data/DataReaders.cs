using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {

    class HeadphoneComparisonDataReader {
        const string FileName = "HeadphoneComparison.dat";

        static internal List<HeadphoneComparisonPoint> ReadDataFromFile() {
            List<HeadphoneComparisonPoint> dataSource = new List<HeadphoneComparisonPoint>();
            Stream stream = AssemblyHelper.GetEmbeddedResourceStream(typeof(HeadphoneComparisonDataReader).Assembly, FileName, false);
            StreamReader reader;
            try {
                reader = new StreamReader(stream);
                while(!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    if(line.Length == 0 || line.StartsWith("//"))
                        continue;
                    string[] cells = line.Split(new string[] { "," }, StringSplitOptions.None);

                    string name = cells[0];
                    double frequency = double.Parse(cells[1], CultureInfo.InvariantCulture);
                    double spl90Db = double.Parse(cells[2], CultureInfo.InvariantCulture);
                    double spl100Db = double.Parse(cells[3], CultureInfo.InvariantCulture);
                    dataSource.Add(new HeadphoneComparisonPoint(name, frequency, spl90Db, spl100Db));
                }
            }
            catch {
                throw new Exception("It's impossible to load " + FileName);
            }
            return dataSource;
        }
    }


    static class SeaIceAreaDataReader {
        const string FileName = "nsidc_global_nt_final_and_nrt.dat";

        static internal List<SeaIceAreaDataPoint> ReadDataFromFile() {
            List<SeaIceAreaDataPoint> dataSource = new List<SeaIceAreaDataPoint>();
            Stream stream = AssemblyHelper.GetEmbeddedResourceStream(typeof(SeaIceAreaDataReader).Assembly, FileName, false);
            StreamReader reader;
            try {
                reader = new StreamReader(stream);
                while(!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    if(line[0] != '1' && line[0] != '2')
                        continue;
                    string[] cells = line.Split(new string[] { ", " }, StringSplitOptions.None);
                    if(cells[3].Trim() == "nan")
                        continue;
                    string year = cells[0].Split('-')[0];
                    double dayOfYear = double.Parse(cells[1], CultureInfo.InvariantCulture);
                    double area = double.Parse(cells[3], CultureInfo.InvariantCulture);
                    dataSource.Add(new SeaIceAreaDataPoint(Convert.ToDateTime(cells[0], CultureInfo.InvariantCulture), year, dayOfYear, area));
                }
            }
            catch {
                throw new Exception("It's impossible to load " + FileName);
            }
            return dataSource;
        }
    }

    class HpiDataReader {
        internal static DataTable GetData() {
            return Utils.LoadDataTableFromXml("HPI.xml", "CountryStatistics");
        }
    }

    class AgeStructureDataReader {
        static DataTable ageStructureTable;
        static DataTable AgeStructureTable {
            get {
                if(ageStructureTable == null)
                    ageStructureTable = LoadPopulationAgeStructure();
                return ageStructureTable;
            }
        }

        static DataTable LoadPopulationAgeStructure() {  // data for end of 2016
            return Utils.LoadDataTableFromXml("Population.xml", "Population");
        }
        internal static IList GetDataByAgeAndGender() {
            return AgeStructureTable.AsEnumerable()
                .Select(row => new {
                    GenderAge = new GenderAgeInfo(row.Field<string>("Gender"), row.Field<string>("Age")),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        internal static IList GetDataByMaleAge() {
            return AgeStructureTable.AsEnumerable()
                .Where(row => row.Field<string>("Gender") == "Male")
                .Select(row => new {
                    Age = row.Field<string>("Age"),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        internal static IList GetDataByFemaleAge() {
            return AgeStructureTable.AsEnumerable()
                .Where(row => row.Field<string>("Gender") == "Female")
                .Select(row => new {
                    Age = row.Field<string>("Age"),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        internal static IList GetPopulationAgeStructure() {
            return AgeStructureTable.AsEnumerable()
                .Select(row => new AgePopulation(row.Field<string>("Country"), row.Field<string>("Age"), row.Field<string>("Gender"), row.Field<long>("Population"))).ToList();
        }
        internal static IList GetGenderAgeItemsWithPopulation() {
            return AgeStructureTable.AsEnumerable()
                .Select(row => new {
                    GenderAge = new GenderAgeInfo(row.Field<string>("Gender"), row.Field<string>("Age")),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population"),
                    PopulationString = row.Field<long>("Population").ToString("0,,.00")
                }).ToList();
        }
    }


    class MarketPricesReader {
        public static DataTable GetGoogleStockPrices() {
            return Utils.LoadDataTableFromXml("GoogleStock.xml", "StockPrice");
        }
        public static DataTable GetAppleStockPrices() {
            return Utils.LoadDataTableFromXml("AppleStock.xml", "StockPrice");
        }
    }


    static class CsvReader {
        internal static List<FinancialDataPoint> ReadFinancialData(string fileName) {
            string longFileName = string.Empty;
            StreamReader reader;
            List<FinancialDataPoint> dataSource = new List<FinancialDataPoint>();
            Stream stream = AssemblyHelper.GetEmbeddedResourceStream(typeof(CsvReader).Assembly, fileName, false);
            try {
                reader = new StreamReader(stream);
                while(!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    FinancialDataPoint point = new FinancialDataPoint();
                    point.DateTimeStamp = DateTime.ParseExact(values[0], "yyyy.MM.dd", null);
                    point.Open = double.Parse(values[1], CultureInfo.InvariantCulture);
                    point.High = double.Parse(values[2], CultureInfo.InvariantCulture);
                    point.Low = double.Parse(values[3], CultureInfo.InvariantCulture);
                    point.Close = double.Parse(values[4], CultureInfo.InvariantCulture);
                    dataSource.Add(point);
                }
            }
            catch {
                throw new Exception("It's impossible to load " + fileName);
            }
            return dataSource;
        }
        internal static List<CarbonContributionDataPoint> ReadCarbonData(string fileName) {
            string longFileName = string.Empty;
            StreamReader reader;
            List<CarbonContributionDataPoint> dataSource = new List<CarbonContributionDataPoint>();
            Stream stream = AssemblyHelper.GetEmbeddedResourceStream(typeof(CsvReader).Assembly, fileName, false);
            try {
                reader = new StreamReader(stream);
                while(!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');
                    CarbonContributionDataPoint point = new CarbonContributionDataPoint();
                    point.Year = values[0];
                    point.Contribution = double.Parse(values[1], CultureInfo.InvariantCulture);
                    point.Factor = values[2];
                    dataSource.Add(point);
                }
            }
            catch {
                throw new Exception("It's impossible to load " + fileName);
            }
            return dataSource;
        }
    }


    [XmlRoot("CountriesInfo")]
    public class CountriesInfo : List<CountryStatisticInfo> {
        static List<CountryStatisticInfo> dataSource = null;
        public static List<CountryStatisticInfo> DataSource {
            get {
                if(dataSource == null) {
                    using(Stream stream = AssemblyHelper.GetEmbeddedResourceStream(typeof(ChartDemoModule).Assembly, "Top10LargestCountriesInfo.xml", false))
                        dataSource = SafeXml.Deserialize<CountriesInfo>(stream);
                }
                return dataSource;
            }
        }
    }
}

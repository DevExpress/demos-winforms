using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml.Linq;
using DevExpress.Internal;
using DevExpress.Utils;

namespace DevExpress.XtraTreeList.Demos {
    public class ContinentInfo : CountryInfo {
        readonly List<CountryInfo> countriesInfoCore;
        public ContinentInfo(string name, List<GDPStatisticByYear> totalStatistic, List<CountryInfo> countriesInfo)
            : base(name, totalStatistic) {
            this.countriesInfoCore = countriesInfo;
        }
        public List<CountryInfo> CountriesInfo {
            get { return countriesInfoCore; }
        }
    }
    public class CountryInfo {
        readonly StatisticInfo statisticCore;
        public CountryInfo(string name, List<GDPStatisticByYear> statistic) {
            this.statisticCore = new StatisticInfo(name, statistic);
        }
        public StatisticInfo Statistic {
            get { return statisticCore; }
        }
    }
    public class StatisticInfo {
        readonly string nameCore;
        readonly List<GDPStatisticByYear> statisticCore;
        public StatisticInfo(string name, List<GDPStatisticByYear> statistic) {
            this.nameCore = name;
            this.statisticCore = statistic;
        }
        public string Name {
            get { return nameCore; }
        }
        internal List<GDPStatisticByYear> Statistic {
            get { return statisticCore; }
        }
        #region Years
        public double? GDPBy2004 {
            get { return statisticCore[0].GDP; }
        }
        public double? GDPBy2005 {
            get { return statisticCore[1].GDP; }
        }
        public double? GDPBy2006 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[2].GDP;
            }
        }
        public double? GDPBy2007 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[3].GDP;
            }
        }
        public double? GDPBy2008 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[4].GDP;
            }
        }
        public double? GDPBy2009 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[5].GDP;
            }
        }
        public double? GDPBy2010 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[6].GDP;
            }
        }
        public double? GDPBy2011 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[7].GDP;
            }
        }
        public double? GDPBy2012 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[8].GDP;
            }
        }
        public double? GDPBy2013 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[9].GDP;
            }
        }
        public double? GDPBy2014 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[10].GDP;
            }
        }
        public double? GDPBy2015 {
            get {
                if(statisticCore == null)
                    return null;
                return statisticCore[11].GDP;
            }
        }
        #endregion
    }
    public class HierarchicalStatisticInfo : StatisticInfo {
        public HierarchicalStatisticInfo(string name, List<GDPStatisticByYear> statistic)
            : base(name, statistic) {
        }
        public int ParentID { get; internal set; }
        public int ID { get; internal set; }
    }
    //
    public class GDPStatisticByYear {
        readonly int yearCore;
        readonly double? gdpCore;
        public GDPStatisticByYear(int year, double? gdp) {
            this.yearCore = year;
            this.gdpCore = gdp;
        }
        public int Year { get { return yearCore; } }
        public double? GDP { get { return gdpCore; } }
    }
    //
    static class DataReader {
        public static List<ContinentInfo> Load() {
            List<ContinentInfo> data = new List<ContinentInfo>();
            try {
                string path = Tutorials.FilePathUtils.FindFilePath("GDPStatistic.xml");
                XDocument Continents_xml = SafeXml.CreateXDocument(File.ReadAllText(path));
                foreach(XElement continent in Continents_xml.Root.Elements("ContinentInfo")) {
                    string name = continent.Element("ContinentName").Value;
                    List<GDPStatisticByYear> statistic = LoadStatistic(continent.Element("Statistic"));
                    List<CountryInfo> countries = LoadCountries(continent.Element("Countries"));
                    ContinentInfo continentInfo = new ContinentInfo(name, statistic, countries);
                    data.Add(continentInfo);
                }
            }
            catch { }
            return data;
        }
        public static List<HierarchicalStatisticInfo> LoadHierarchical() {
            List<HierarchicalStatisticInfo> data = new List<HierarchicalStatisticInfo>();
            var continents = Load();
            int parentID = 0;
            int id = 1;
            foreach(ContinentInfo continent in continents) {
                var statistic = continent.Statistic;
                var _item = new HierarchicalStatisticInfo(statistic.Name, statistic.Statistic);
                _item.ParentID = parentID;
                _item.ID = id++;
                data.Add(_item);
                foreach(CountryInfo country in continent.CountriesInfo) {
                    var statisticCountry = country.Statistic;
                    var childItem = new HierarchicalStatisticInfo(statisticCountry.Name, statisticCountry.Statistic);
                    childItem.ParentID = _item.ID;
                    childItem.ID = id++;
                    data.Add(childItem);
                }
                parentID = id;
            }
            return data;
        }
        //
        static List<CountryInfo> LoadCountries(XElement countries) {
            List<CountryInfo> countriesInfo = new List<CountryInfo>();
            foreach(XElement country in countries.Elements("CountryInfo")) {
                string name = country.Element("Name").Value;
                List<GDPStatisticByYear> statistic = LoadStatistic(country.Element("Statistic"));
                CountryInfo countryInfo = new CountryInfo(name, statistic);
                countriesInfo.Add(countryInfo);
            }
            return countriesInfo;
        }
        static List<GDPStatisticByYear> LoadStatistic(XElement statistics) {
            List<GDPStatisticByYear> statisticsByYear = new List<GDPStatisticByYear>();
            foreach(XElement statisticItem in statistics.Elements("GDPByYear")) {
                int year = int.Parse(statisticItem.Element("Year").Value);
                double? gdp = GetGDP(statisticItem);
                GDPStatisticByYear statisticByYearItem = new GDPStatisticByYear(year, gdp);
                statisticsByYear.Add(statisticByYearItem);
            }
            return statisticsByYear;
        }
        static double? GetGDP(XElement statisticItem) {
            string value = statisticItem.Element("GDP").Value;
            if(string.IsNullOrEmpty(value))
                return null;
            return double.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using DevExpress.Utils.Filtering;

namespace DevExpress.XtraCharts.Demos {

    public class DataPoint {
        public string Series { get; set; }
        public double Argument { get; set; }
        public double Value { get; set; }
        public double Value2 { get; set; }
        public double Weight { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Min { get; set; }
        public double Quartile1 { get; set; }
        public double Median { get; set; }
        public double Quartile3 { get; set; }
        public double Max { get; set; }
        public double Mean { get; set; }
        public double[] Outliers { get; set; }
    }


    public class FinancialDataPoint {
        public DateTime DateTimeStamp { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public bool IsEmpty { get { return DateTimeStamp.Equals(new DateTime()); } }

        public FinancialDataPoint() { }
        public FinancialDataPoint(DateTime date, double open, double high, double low, double close, double volume) {
            DateTimeStamp = date;
            Low = low;
            High = high;
            Open = open;
            Close = close;
            Volume = volume;
        }
    }

    public class CarbonContributionDataPoint {
        public string Year { get; set; }
        public double Contribution { get; set; }
        public string Factor { get; set; }

        public CarbonContributionDataPoint() { }
        public CarbonContributionDataPoint(string year, double contribution, string factor) {
            Year = year;
            Contribution = contribution;
            Factor = factor;
        }
    }


    public class SimpleDataPoint {
        public double Argument { get; private set; }
        public double Value { get; private set; }

        public SimpleDataPoint(double arg, double val) {
            Argument = arg;
            Value = val;
        }
    }


    public class HeadphoneComparisonPoint {
        public string HeadphonesName { get; private set; }
        public double Frequency { get; private set; }
        public double Spl90Db { get; private set; }
        public double Spl100Db { get; private set; }

        public HeadphoneComparisonPoint(string headphoneName, double frequency, double spl90Db, double spl100Db) {
            HeadphonesName = headphoneName;
            Frequency = frequency;
            Spl90Db = spl90Db;
            Spl100Db = spl100Db;
        }
    }


    public class SensorIndicationItem {
        public DateTime TimeStamp { get; private set; }
        public double SensorIndication1 { get; private set; }
        public double SensorIndication2 { get; private set; }
        public double SensorIndication3 { get; private set; }
        public double SensorIndication4 { get; private set; }
        public double SensorIndication5 { get; private set; }
        public double SensorIndication6 { get; private set; }
        public double SensorIndication7 { get; private set; }
        public double SensorIndication8 { get; private set; }

        internal SensorIndicationItem(DateTime timeStamp, double sensorIndication1,
                                                        double sensorIndication2,
                                                        double sensorIndication3,
                                                        double sensorIndication4,
                                                        double sensorIndication5,
                                                        double sensorIndication6,
                                                        double sensorIndication7,
                                                        double sensorIndication8) {
            TimeStamp = timeStamp;
            SensorIndication1 = sensorIndication1;
            SensorIndication2 = sensorIndication2;
            SensorIndication3 = sensorIndication3;
            SensorIndication4 = sensorIndication4;
            SensorIndication5 = sensorIndication5;
            SensorIndication6 = sensorIndication6;
            SensorIndication7 = sensorIndication7;
            SensorIndication8 = sensorIndication8;
        }
    }





    public class SeaIceAreaDataPoint {
        public DateTime FullDate { get; private set; }
        public string Year { get; private set; }
        public double DayOfYear { get; private set; }
        public double IceArea { get; private set; }

        internal SeaIceAreaDataPoint(DateTime fullDateP, string yearP, double dayOfYearP, double iceAreaP) { //P - parameter (for correct VB conversion)
            FullDate = fullDateP;
            Year = yearP;
            DayOfYear = dayOfYearP;
            IceArea = iceAreaP;
        }
    }


    public class TemperaturePoint {
        public TimeSpan TimeStamp { get; private set; }
        public double Temperature { get; private set; }

        internal TemperaturePoint(TimeSpan time, double temperature) {
            TimeStamp = time;
            Temperature = temperature;
        }
    }


    public class BubbleDataItem {
        public DateTime Year { get; private set; }
        public double Budget { get; private set; }
        public double Grosses { get; private set; }
        public string Title { get; private set; }

        public BubbleDataItem(DateTime year, double budget, double grosses, string title) {
            Year = year;
            Budget = budget;
            Grosses = grosses;
            Title = title;
        }
    }


    public class GDP {
        public int Year { get; private set; }
        public decimal Product { get; private set; }

        public GDP(int year, decimal product) {
            Year = year;
            Product = product;
        }
    }


    public class G7Member {
        public decimal GDPin2015 { get { return GDPs.First((gdp) => gdp.Year == 2015).Product; } }
        public string CountryName { get; private set; }
        public List<GDP> GDPs { get; private set; }
        public int ColorNumberInPalette { get; private set; }

        public G7Member(string country, int colorNumberInPalette) {
            CountryName = country;
            GDPs = new List<GDP>();
            ColorNumberInPalette = colorNumberInPalette;
        }
    }


    public class AgePopulation {
        public string Name { get; private set; }
        public string Age { get; private set; }
        public string Gender { get; private set; }
        public string GenderAgeKey { get { return Gender.ToString() + ": " + Age; } }
        public string CountryAgeKey { get { return Name + ": " + Age; } }
        public string CountryGenderKey { get { return Name + ": " + Gender.ToString(); } }
        public double Population { get; private set; }

        public AgePopulation(string name, string age, string gender, double population) {
            Name = name;
            Age = age;
            Gender = gender;
            Population = population;
        }
    }


    public struct GenderAgeInfo {
        readonly string gender;
        readonly string age;

        public string Gender { get { return gender; } }
        public string Age { get { return age; } }

        public GenderAgeInfo(string gender, string age) {
            this.gender = gender;
            this.age = age;
        }
        public override string ToString() {
            return Gender + ": " + Age;
        }
    }


    public class DevAVDataItem {
        [FilterRange(EditorType = RangeUIEditorType.Range)]
        [Display(Order = 1)]
        public int Year { get; set; }
        [Display(AutoGenerateFilter = false)]
        public string Region { get; set; }
        [Display(Name = "Sales, millions of USD", Order = 3)]
        public decimal Sales { get; set; }
        [Display(AutoGenerateFilter = false)]
        public decimal Cost { get; set; }
        [Display(AutoGenerateFilter = false)]
        public string ProductCategory { get; set; }
        [FilterLookup(UseBlanks = false, UseSelectAll = false)]
        [Display(Order = 2)]
        public string Company { get; set; }
        [Display(AutoGenerateFilter = false)]
        public DateTime SaleDate { get; set; }
        [Display(Name = "Charges, millions of USD", Order = 4)]
        public decimal Charges { get; set; }
        [Display(AutoGenerateFilter = false)]
        public decimal Penalties { get; set; }
    }


    public class PerformanceDataItem {
        public TimeSpan Time { get; private set; }
        public double Process1CpuUsage { get; private set; }
        public double Process2CpuUsage { get; private set; }
        public double Process3CpuUsage { get; private set; }
        public double Process1Memory { get; private set; }
        public double Process2Memory { get; private set; }
        public double Process3Memory { get; private set; }

        public PerformanceDataItem(int second, double process1CpuUsage, double process2CpuUsage, double process3CpuUsage,
                                               double process1Memory, double process2Memory, double process3Memory) {
            Time = TimeSpan.FromSeconds(second);
            Process1CpuUsage = process1CpuUsage;
            Process2CpuUsage = process2CpuUsage;
            Process3CpuUsage = process3CpuUsage;
            Process1Memory = process1Memory;
            Process2Memory = process2Memory;
            Process3Memory = process3Memory;
        }
    }

    [XmlType("CountryInfo")]
    public class CountryStatisticInfo {
        public string Name {
            get;
            set;
        }
        [XmlArray("Statistic")]
        [XmlArrayItem("PopulationStatisticByYear")]
        public List<PopulationStatisticByYear> PopulationDynamic {
            get;
            set;
        }
        public double AreaSqrKilometers {
            get;
            set;
        }
        public double AreaMSqrKilometers {
            get { return AreaSqrKilometers / 1000000; }
        }
    }


    public class PopulationStatisticByYear {
        public int Year {
            get;
            set;
        }
        public double Population {
            get;
            set;
        }
        public double UrbanPercent {
            get;
            set;
        }
        public double PopulationMillionsOfPeople {
            get { return Population / 1000000; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Win.Gauges.Circular;

namespace DevExpress.XtraGauges.Demos {
    public partial class StateImageIndicatorWeatherStation : TutorialControl {
        DateTime date = new DateTime(1900, 1, 1);
        string[] seasons = new string[] { "Winter", "Spring", "Summer", "Autumn" };
        Timer updateTimer = new Timer();
        public StateImageIndicatorWeatherStation() {
            InitializeComponent();
            scHumidityLA.EnableAnimation = true;
            scHumidityLA.EasingMode = Core.Model.EasingMode.EaseInOut;
            scHumidityLA.EasingFunction = new CubicEase();
            scTempLA.EnableAnimation = true;
            scTempLA.EasingMode = Core.Model.EasingMode.EaseInOut;
            scTempLA.EasingFunction = new CubicEase();
            scHumidityLn.EnableAnimation = true;
            scHumidityLn.EasingMode = Core.Model.EasingMode.EaseInOut;
            scHumidityLn.EasingFunction = new CubicEase();
            scTempLn.EnableAnimation = true;
            scTempLn.EasingMode = Core.Model.EasingMode.EaseInOut;
            scTempLn.EasingFunction = new CubicEase();
            scHumidityMs.EnableAnimation = true;
            scHumidityMs.EasingMode = Core.Model.EasingMode.EaseInOut;
            scHumidityMs.EasingFunction = new CubicEase();
            scTempMs.EnableAnimation = true;
            scTempMs.EasingMode = Core.Model.EasingMode.EaseInOut;
            scTempMs.EasingFunction = new CubicEase();
            LookAndFeel.StyleChanged += OnStyleChanged;
            updateTimer.Interval = 2000;
            updateTimer.Tick += OnTimerTick;
            UpdateColor();
            UpdateWeatherLA();
            UpdateWeatherLN();
            UpdateWeatherMS();
            updateTimer.Start();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            updateTimer.Stop();
            base.Dispose(disposing);
        }
        #region StateImageIndicator
        readonly static DevExpress.Data.Utils.NonCryptographicRandom r = DevExpress.Data.Utils.NonCryptographicRandom.Default;
        public Color HotColor {
            get { return SkinColorHelper.GetColor(LookAndFeel, "Critical"); }
        }
        public Color ColdColor {
            get { return SkinColorHelper.GetColor(LookAndFeel, "Question"); }
        }
        public Color RangeColor {
            get { return SkinColorHelper.GetColor(LookAndFeel, "DisabledText"); }
        }
        public Color TextColor {
            get { return SkinColorHelper.GetColor(LookAndFeel, "DisabledText"); }
        }
        void OnStyleChanged(object sender, EventArgs e) {
            updateTimer.Stop();
            UpdateColor();
            UpdateWeatherLA();
            UpdateWeatherLN();
            UpdateWeatherMS();

            updateTimer.Start();
        }
        void UpdateColor() {
            rbLnHumidity.AppearanceRangeBar.ContentBrush = new SolidBrushObject(RangeColor);
            rbLAHumidity.AppearanceRangeBar.ContentBrush = new SolidBrushObject(RangeColor);
            rbMsHumidity.AppearanceRangeBar.ContentBrush = new SolidBrushObject(RangeColor);
            gaugeControl4.ColorScheme.Color = HotColor;
            gaugeControl3.ColorScheme.Color = HotColor;
            gaugeControl5.ColorScheme.Color = HotColor;
            scTempLA.AppearanceTickmarkText.TextBrush = new SolidBrushObject(TextColor);
            scTempLn.AppearanceTickmarkText.TextBrush = new SolidBrushObject(TextColor);
            scTempMs.AppearanceTickmarkText.TextBrush = new SolidBrushObject(TextColor);
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(date.Year > 2050)
                date = new DateTime(1900, 1, 1);
            date = date.AddDays(r.Next(0, 30));
            UpdateDate();
            UpdateWeatherLA();
            UpdateWeatherLN();
            UpdateWeatherMS();
        }
        void UpdateDate() {
            string[] s = date.ToString("dd MMMM").Split(' ');
            lcDay.Text = s[0];
            lcMonth.Text = s[1].ToUpper();
            if(date.Month == 12 || (date.Month >= 1 && date.Month <= 2)) {
                lcSeason.Text = seasons[0].ToUpper();
            }
            if(date.Month >= 3 && date.Month <= 5) {
                lcSeason.Text = seasons[1].ToUpper();
            }
            if(date.Month >= 6 && date.Month <= 8) {
                lcSeason.Text = seasons[2].ToUpper();
            }
            if(date.Month >= 9 && date.Month <= 11) {
                lcSeason.Text = seasons[3].ToUpper();
            }
        }
        void UpdateWeatherLN() {
            double temp = 10 * Math.Sin(((date.DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(-5, 2) + 13;
            int humidity = r.Next(65, 100);
            UpdateCityWeather(scTempLn, scHumidityLn, siiLn, lcLn, rbLnTemp, temp, humidity);
        }
        void UpdateWeatherLA() {
            double temp = 7.5 * Math.Sin(((date.DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(-2, 2) + 20.5;
            int humidity = r.Next(40, 92);
            UpdateCityWeather(scTempLA, scHumidityLA, siiLA, lcLA, rbLATemp, temp, humidity);
        }
        void UpdateWeatherMS() {
            double temp = 28 * Math.Sin(((date.DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(0, 2);
            int humidity = r.Next(60, 100);
            UpdateCityWeather(scTempMs, scHumidityMs, siiMs, lcMs, rbMsTemp, temp, humidity);
        }
        void UpdateCityWeather(ArcScaleComponent tempScale, ArcScaleComponent humidityScale, StateImageIndicatorComponent imageIndicator, LabelComponent label, ArcScaleRangeBar rangeBar, double temp, int humidity, string weather = "") {
            if(tempScale == null || humidityScale == null || imageIndicator == null || label == null || rangeBar == null) 
                return;
            tempScale.Value = (float)temp;
            if(temp < 0) {
                rangeBar.Appearance.ContentBrush = new SolidBrushObject(ColdColor);
                imageIndicator.Color = ColdColor;
            }
            else {
                rangeBar.Appearance.ContentBrush = new SolidBrushObject(HotColor);
                imageIndicator.Color = HotColor;
            }
            humidityScale.Value = humidity;
            string color = string.Format("{0},{1},{2}", RangeColor.R, RangeColor.G, RangeColor.B);
            string color2 = temp < 0 ? 
                string.Format("{0},{1},{2}", ColdColor.R, ColdColor.G, ColdColor.B) : 
                string.Format("{0},{1},{2}", HotColor.R, HotColor.G, HotColor.B);
            string temperature = temp <= 0 ? ((int)temp).ToString() : "+" + ((int)temp).ToString();
            label.Text = string.Format("<color={0}>t: {1}C    <br><color={2}>h: {3}%   ", color2, temperature, color, humidity);
            if(string.IsNullOrEmpty(weather)) {
                if(humidity > 85) {
                    if(temp >= 0)
                        imageIndicator.StateIndex = 2;
                    else
                        imageIndicator.StateIndex = 3;
                }
                else if(humidity > 70) {
                    imageIndicator.StateIndex = 1;
                }
                else {
                    imageIndicator.StateIndex = 0;
                }
            }
            else {
                switch(weather) {
                    case "Rain":
                        imageIndicator.StateIndex = 2;
                        break;
                    case "Clear":
                        imageIndicator.StateIndex = 0;
                        break;
                    case "Snow":
                        imageIndicator.StateIndex = 3;
                        break;
                    default:
                        imageIndicator.StateIndex = 1;
                        break;
                }
            }
        }
        #endregion
    }

    internal static class SkinColorHelper {
        public static Color GetColor(ISkinProvider provider, string name) {
            return CommonSkins.GetSkin(provider).Colors.GetColor(name);
        }
    }
}

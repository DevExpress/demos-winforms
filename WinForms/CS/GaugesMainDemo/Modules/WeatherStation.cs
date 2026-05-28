using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGauges.Demos.net.webservicex.www;

namespace DevExpress.XtraGauges.Demos {
    public partial class WeatherStation : TutorialControl {
        BindingList<DemoWeatherData> data;
        public WeatherStation() {
            InitializeComponent();
            UpdateWeather("London(Offline data)");
        }
        void simpleButton1_Click(object sender, System.EventArgs e) {
            UpdateWeather(comboBoxEdit1.EditValue.ToString());
        }
        protected void UpdateWeather(string place) {
            WeatherForecasts wfc = GetWeatherByPlaceNameSafe(place);
            if(wfc == null) return;
            InitDataSource(wfc);
            InitCharts();
            InitGauge();
        }
        protected WeatherForecasts GetWeatherByPlaceNameSafe(string place) {
            Cursor = Cursors.WaitCursor;
            WeatherForecasts wfc = null;
            try {
                using(WaitDialogForm dlg = new WaitDialogForm("Loading weather at " + place)) {
                    if(place.Contains("Offline")) {
                        var stream = ResourceImageHelperCore.FindStream("DevExpress.XtraGauges.Demos.Data.weather.xml", 
                            typeof(WeatherStation).Assembly);
                        wfc = SafeXml.Deserialize<WeatherForecasts>(stream);
                    }
                    else {
#if !NET
                        WeatherForecast service = new WeatherForecast();
                        wfc = service.GetWeatherByPlaceName(place);
#endif
                    }
                }
            }
            catch {
                DevExpress.XtraEditors.XtraMessageBox.Show("could not retrieve weather data for " + place);
                Cursor = Cursors.Arrow;
                return null;
            }
            if(wfc.Details == null) {
                DevExpress.XtraEditors.XtraMessageBox.Show("could not retrieve weather data for " + place);
                Cursor = Cursors.Arrow;
                return null;
            }
            Cursor = Cursors.Arrow;
            return wfc;
        }
        protected void InitDataSource(WeatherForecasts wfc) {
            try {
                try {
                    if(data == null) data = new BindingList<DemoWeatherData>();
                    else data.Clear();
                }
                catch { }
                int counter = 0;
                bool isCelsius = comboBoxEdit2.Text.StartsWith("C");

                foreach(WeatherData wd in wfc.Details) {
                    int minF, maxF, minC, maxC, f, c;
                    int.TryParse(wd.MinTemperatureF, out minF);
                    int.TryParse(wd.MaxTemperatureF, out maxF);
                    int.TryParse(wd.MinTemperatureC, out minC);
                    int.TryParse(wd.MaxTemperatureC, out maxC);
                    f = (minF + maxF) / 2; c = (minC + maxC) / 2;
                    int minT = isCelsius? minC : minF;
                    int maxT = isCelsius? maxC : maxF;
                    DemoWeatherData item = new DemoWeatherData(minT, maxT, c, f, counter);
                    counter++;
                    data.Add(item);
                }
            }
            catch { }
        }
        protected void InitGauge() {
            bool isCelsius = comboBoxEdit2.Text.StartsWith("C");
            if(currentTempScale.DataBindings.Count == 0) {
                currentTempScale.DataBindings.Add("Value", data, "CurrentTemperature" + (isCelsius ? "C" : "F"));
            }
        }
        protected void InitCharts() {
            if(chartControl1.DataSource != data) {
                chartControl1.DataSource = data;
                chartControl1.Series[0].ArgumentDataMember = "Day";
                chartControl1.Series[0].ValueDataMembers[0] = "MinTemperature";

                chartControl1.Series[1].ArgumentDataMember = "Day";
                chartControl1.Series[1].ValueDataMembers[0] = "MaxTemperature";
            }
            else {
                chartControl1.Invalidate();
            }
        }
    }
    public class DemoWeatherData {
        int minTemperatureCore;
        int maxTemperatureCore;
        int dayCore;
        int currentTemperatureCCore;
        int currentTemperatureFCore;

        public int MinTemperature {
            get { return minTemperatureCore; }
            set { minTemperatureCore = value; }
        }
        public int MaxTemperature {
            get { return maxTemperatureCore; }
            set { maxTemperatureCore = value; }
        }
        public int Day {
            get { return dayCore; }
            set { dayCore = value; }
        }
        public int CurrentTemperatureF {
            get { return currentTemperatureCCore; }
            set { currentTemperatureCCore = value; }
        }
        public int CurrentTemperatureC {
            get { return currentTemperatureFCore; }
            set { currentTemperatureFCore = value; }
        }
        public DemoWeatherData(int minT, int maxT, int currentTemperatureC, int currentTemperatureF, int day) {
            Day = day;
            MinTemperature = minT;
            MaxTemperature = maxT;
            CurrentTemperatureC = currentTemperatureC;
            CurrentTemperatureF = currentTemperatureF;
        }
    }
}

#if NET
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevExpress.AI.Demos.Models {
    public class WeatherWidgetData {
        public string CityName { get; set; }
        public string Country { get; set; }
        public double Temperature { get; set; }
        public double FeelsLike { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public int Pressure { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public List<DailyForecast> FiveDayForecast { get; set; } = new();
    }

    public class DailyForecast {
        public DateTime Date { get; set; }
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Humidity { get; set; }
    }

    public class WeatherData {
        [JsonPropertyName("coord")]
        public Coordinates Coordinates { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherInfo> Weather { get; set; }

        [JsonPropertyName("main")]
        public MainWeatherData Main { get; set; }

        [JsonPropertyName("wind")]
        public WindData Wind { get; set; }

        [JsonPropertyName("clouds")]
        public CloudsData Clouds { get; set; }

        [JsonPropertyName("dt")]
        public long Timestamp { get; set; }

        [JsonPropertyName("sys")]
        public SysData Sys { get; set; }

        [JsonPropertyName("timezone")]
        public int Timezone { get; set; }

        [JsonPropertyName("name")]
        public string CityName { get; set; }
    }

    public class Coordinates {
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
    }

    public class WeatherInfo {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public class MainWeatherData {
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("temp_min")]
        public double MinTemperature { get; set; }

        [JsonPropertyName("temp_max")]
        public double MaxTemperature { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class WindData {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("deg")]
        public int Degree { get; set; }
    }

    public class CloudsData {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }

    public class SysData {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("sunrise")]
        public long Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public long Sunset { get; set; }
    }

    public class ForecastData {
        [JsonPropertyName("list")]
        public List<ForecastItem> List { get; set; }

        [JsonPropertyName("city")]
        public CityData City { get; set; }
    }

    public class ForecastItem {
        [JsonPropertyName("dt")]
        public long Timestamp { get; set; }

        [JsonPropertyName("main")]
        public MainWeatherData Main { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherInfo> Weather { get; set; }

        [JsonPropertyName("clouds")]
        public CloudsData Clouds { get; set; }

        [JsonPropertyName("wind")]
        public WindData Wind { get; set; }

        [JsonPropertyName("dt_txt")]
        public string DateTimeText { get; set; }
    }

    public class CityData {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("timezone")]
        public int Timezone { get; set; }

        [JsonPropertyName("sunrise")]
        public long Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public long Sunset { get; set; }
    }
}
#endif

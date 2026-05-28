using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    static class Utils {
        static IEnumerable<Type> GetNonAbstractSubclasses(Type baseType) {
            Assembly xtraChartsAssembly = Assembly.GetAssembly(typeof(Legend));
            return xtraChartsAssembly.GetTypes().Where(type => !type.IsAbstract && type.IsSubclassOf(baseType) && type.IsPublic);
        }

        internal static string GetRelativePath(string name) {
            name = "Data\\" + name;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            for(int i = 0; i <= 10; i++) {
                string filePath = Path.Combine(dir.FullName, name);
                if(File.Exists(filePath))
                    return filePath;
                dir = Directory.GetParent(dir.FullName);
            }
            return string.Empty;
        }
        internal static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
            oleDbConnection.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
        }
        internal static List<Type> GetSeriesAnimationTypes(ViewType viewType) {
            Series fakeSeries = new Series("Fake Series", viewType);
            Type seriesViewType = fakeSeries.View.GetType();
            IEnumerable<PropertyInfo> seriesAnimationProperties = seriesViewType.GetProperties().Where(propertyInfo => propertyInfo.Name == "SeriesAnimation" || propertyInfo.Name == "MeanLineAnimation"); //"property" is a keyword in VB 
            if(seriesAnimationProperties != null && seriesAnimationProperties.Count() == 1) {
                Type baseSeriesAnimationType = seriesAnimationProperties.First().PropertyType;
                return new List<Type>(GetNonAbstractSubclasses(baseSeriesAnimationType));
            }
            return new List<Type>();
        }
        internal static List<Type> GetPointAnimationTypes(ViewType viewType) {
            Series fakeSeries = new Series("Fake Series", viewType);
            Type seriesViewType = fakeSeries.View.GetType();
            PropertyInfo pointAnimationProperty = seriesViewType.GetProperty("SeriesPointAnimation");
            if(pointAnimationProperty == null)
                pointAnimationProperty = seriesViewType.GetProperty("Animation");
            if(pointAnimationProperty != null && pointAnimationProperty.GetCustomAttribute(typeof(BrowsableAttribute)) == null) {
                Type basePointAnimationType = pointAnimationProperty.PropertyType;
                return new List<Type>(GetNonAbstractSubclasses(basePointAnimationType));
            }
            return new List<Type>();
        }
        internal static DataTable LoadDataTableFromXml(string fileName, string tableName) {
            Stream xmlStream = DevExpress.Utils.AssemblyHelper.GetEmbeddedResourceStream(typeof(Utils).Assembly, fileName, false);
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(xmlStream);
            xmlStream.Close();
            return xmlDataSet.Tables[tableName];
        }
        internal static string SplitByWords(string title) {
            Regex regex = new Regex(@"(?<=\p{Lu})(?=\p{Lu}\P{Lu})|(?<=[\P{Lu}-[\s]])(?=\p{Lu})|(?<=[\w-[\d]])(?=[\W\d-[\s]])");
            return regex.Replace(title, " ");
        }
        internal static DefaultBoolean CovertBoolToDefaultBoolean(bool value) {
            return value ? DefaultBoolean.True : DefaultBoolean.False;
        }
        internal static Bitmap ResizeImage(Image image, int width, int height) {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using(Graphics g = Graphics.FromImage(destImage)) {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using(ImageAttributes wrap = new ImageAttributes()) {
                    wrap.SetWrapMode(WrapMode.TileFlipXY);
                    g.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrap);
                }
            }
            return destImage;
        }
        internal static double ConvertCelsiusToFahrenheit(double value) {
            return value * 1.8 + 32;
        }
    }

    static class PieExplodingHelper {
        static SeriesPointFilter CreateFilter(string mode) {
            return new SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.Equal, mode);
        }
        static void ApplyFilterMode(PieSeriesViewBase view, string mode) {
            view.ExplodedPointsFilters.Clear();
            view.ExplodedPointsFilters.Add(CreateFilter(mode));
            view.ExplodeMode = PieExplodeMode.UseFilters;
        }

        internal const string None = "None";
        internal const string All = "All";
        internal const string MinValue = "Min Value";
        internal const string MaxValue = "Max Value";
        internal const string Custom = "Custom";

        internal static List<string> CreateModeList(SeriesPointCollection points, bool supportCustom) {
            List<string> list = new List<string>();
            list.Add(None);
            list.Add(All);
            list.Add(MinValue);
            list.Add(MaxValue);
            foreach(SeriesPoint point in points)
                list.Add(point.Argument);
            if(supportCustom)
                list.Add(Custom);
            return list;
        }
        internal static void ApplyMode(PieSeriesViewBase view, string mode) {
            switch(mode) {
                case Custom:
                    break;
                case None:
                    view.ExplodeMode = PieExplodeMode.None;
                    break;
                case All:
                    view.ExplodeMode = PieExplodeMode.All;
                    break;
                case MinValue:
                    view.ExplodeMode = PieExplodeMode.MinValue;
                    break;
                case MaxValue:
                    view.ExplodeMode = PieExplodeMode.MaxValue;
                    break;
                default:
                    ApplyFilterMode(view, mode);
                    break;
            }
        }
    }

    static class ColorUtils {
        #region class ColorHSL
        class ColorHSL {
            const float minLuminance = 0.0f;
            const float maxLuminance = 1.0f;

            readonly float _hue;
            readonly float _saturation;
            float _luminance;

            public float Luminance { get { return _luminance; } set { _luminance = value; } }

            public float MinLuminance { get { return Math.Min(minLuminance, Luminance * 0.9f); } }
            public float MaxLuminance { get { return Math.Max(maxLuminance, Luminance + (1.0f - Luminance) * 0.15f); } }

            public ColorHSL(float hue, float saturation, float luminance) {
                _hue = hue;
                _saturation = saturation;
                _luminance = luminance;
            }
            byte GetComponent(float q, float p, float t) {
                const float oneDivSix = 1.0f / 6.0f;
                const float twoDivThree = 2.0f / 3.0f;
                while(t < 0.0f)
                    t += 1.0f;
                while(t > 1.0f)
                    t -= 1.0f;
                float result;
                if(t < oneDivSix)
                    result = p + ((q - p) * 6.0f * t);
                else if(t < 0.5f)
                    result = q;
                else if(t < twoDivThree)
                    result = p + ((q - p) * (twoDivThree - t) * 6.0f);
                else
                    result = p;
                return (byte)Math.Round(result * 255.0f);
            }
            internal Color ToColor() {
                const float oneDivThree = 1.0f / 3.0f;
                float q = _luminance < 0.5f ? (Luminance * (1.0f + _saturation)) : _luminance + _saturation - (_luminance * _saturation);
                float p = 2.0f * Luminance - q;
                float hueScaled = _hue / 360.0f;
                return Color.FromArgb(255, GetComponent(q, p, hueScaled + oneDivThree),
                    GetComponent(q, p, hueScaled), GetComponent(q, p, hueScaled - oneDivThree));
            }
        }
        #endregion

        static readonly string[] darSkinNames = new string[] { "DevExpress Dark Style", "Office 2016 Black", "Visual Studio 2013 Dark", "Darkroom" };

        static ColorHSL ToColorHSL(Color color) {
            return new ColorHSL(color.GetHue(), color.GetSaturation(), color.GetBrightness());
        }
        static byte MixChannel(byte fromValue, byte toValue, double ratio) {
            return (byte)(fromValue * (1.0 - ratio) + toValue * ratio);
        }
        static Color MakeColorDarker(Color color, float ratio) {
            ColorHSL colorHSL = ToColorHSL(color);
            colorHSL.Luminance = Math.Min(0.95f, ratio);
            return colorHSL.ToColor();
        }

        internal static Color ConvertColor(Color color, int cycleIndex, int cycleCount) {
            const float minPercent = 0.35f;
            const float maxPercent = 0.22f;
            ColorHSL colorHSL = ToColorHSL(color);
            float diapason = (float)(cycleCount - 1) / cycleCount;
            float minLuminance = colorHSL.Luminance - diapason * minPercent;
            if(minLuminance < colorHSL.MinLuminance)
                minLuminance = colorHSL.MinLuminance;
            float maxLuminance = colorHSL.Luminance + diapason * maxPercent;
            if(maxLuminance > colorHSL.MaxLuminance)
                maxLuminance = colorHSL.MaxLuminance;
            float cycleMiddle = (cycleCount - 1) / 2.0f;
            float cycleDiff = cycleIndex - cycleMiddle;
            if(cycleDiff < 0.0f)
                colorHSL.Luminance = colorHSL.Luminance - (minLuminance - colorHSL.Luminance) * (cycleDiff / cycleMiddle);
            else
                colorHSL.Luminance = colorHSL.Luminance + (maxLuminance - colorHSL.Luminance) * (cycleDiff / cycleMiddle);
            return colorHSL.ToColor();
        }
        internal static Color MixColors(Color c1, Color c2) {
            double a = c1.A / 255.0;
            int r = (int)(a * c1.R + (1 - a) * c2.R);
            int g = (int)(a * c1.G + (1 - a) * c2.G);
            int b = (int)(a * c1.B + (1 - a) * c2.B);
            return Color.FromArgb(r, g, b);
        }
        internal static Color InterpolateColors(Color fromUnit, Color toUnit, double ratio) {
            return Color.FromArgb(MixChannel(fromUnit.A, toUnit.A, ratio),
                                  MixChannel(fromUnit.R, toUnit.R, ratio),
                                  MixChannel(fromUnit.G, toUnit.G, ratio),
                                  MixChannel(fromUnit.B, toUnit.B, ratio));
        }
        internal static Color ColorizerSeaIceSeries(Color color, int seriesIndex, string skin) {
            float ratio;
            int hundredth = seriesIndex / 100;
            if(!darSkinNames.Contains(skin))
                ratio = seriesIndex <= 10 ? 0.2f + (float)Math.Ceiling(seriesIndex / 2.0) * 0.09f : 0.7f + hundredth;
            else
                ratio = seriesIndex <= 10 ? 1.0f - (float)Math.Ceiling(seriesIndex / 2.0) * 0.09f : 0.5f - hundredth;
            return MakeColorDarker(color, ratio);
        }
        internal static Color GetChartBackground(UserLookAndFeel lf) {
            return ChartSkins.GetSkin(lf)["Background"].Color.GetBackColor();
        }
    }

    static class FastFourierTransformation {
        public static void Transform(double[] real, double[] imaginary) {
            double powerOf2Double = Math.Log(real.Length, 2);
            Debug.Assert(powerOf2Double == Math.Floor(powerOf2Double));
            int powerOf2 = (int)powerOf2Double;
            int frameLength = real.Length;
            int j = 0;
            for(int i = 0; i < frameLength - 1; i++) {
                if(i < j) {
                    double tempReal = real[i];
                    double tempImaginary = imaginary[i];
                    real[i] = real[j];
                    imaginary[i] = imaginary[j];
                    real[j] = tempReal;
                    imaginary[j] = tempImaginary;
                }
                int k = frameLength / 2;
                while(k <= j) {
                    j -= k;
                    k = k / 2;
                }
                j += k;
            }
            double c1 = -1d;
            double c2 = 0d;
            int currentPowerOf2 = 1;
            for(int l = 0; l < powerOf2; l++) {
                int previousPowerOf2 = currentPowerOf2;
                currentPowerOf2 *= 2;
                double u1 = 1.0;
                double u2 = 0.0;
                for(j = 0; j < previousPowerOf2; j++) {
                    for(int i = j; i < frameLength; i += currentPowerOf2) {
                        int i1 = i + previousPowerOf2;
                        double t1 = u1 * real[i1] - u2 * imaginary[i1];
                        double t2 = u1 * imaginary[i1] + u2 * real[i1];
                        real[i1] = real[i] - t1;
                        imaginary[i1] = imaginary[i] - t2;
                        real[i] += t1;
                        imaginary[i] += t2;
                    }
                    double z = u1 * c1 - u2 * c2;
                    u2 = u1 * c2 + u2 * c1;
                    u1 = z;
                }
                c2 = -Math.Sqrt((1d - c1) / 2d);
                c1 = Math.Sqrt((1d + c1) / 2d);
            }
            for(int i = 0; i < frameLength; i++) {
                real[i] /= frameLength;
                imaginary[i] /= frameLength;
            }
        }
    }

    public static class StackGroupHelper {
        public static void ApplyStackedGroup(SeriesCollection seriesCollection, DefaultBoolean labelVisibility, int groupSelectedIndex, bool isFullStackedView) {
            foreach(SeriesBase series in seriesCollection) {
                series.LabelsVisibility = labelVisibility;
                ISupportStackedGroup view = series.View as ISupportStackedGroup;
                if(view != null) {
                    GenderAgeInfo genderAge = (GenderAgeInfo)series.Tag;
                    view.StackedGroup = groupSelectedIndex == 0 ? genderAge.Gender : genderAge.Age;
                    if(isFullStackedView && ((string)view.StackedGroup) == "65 years and older")
                        view.StackedGroup = "65+ years";
                }
            }
        }
    }
}

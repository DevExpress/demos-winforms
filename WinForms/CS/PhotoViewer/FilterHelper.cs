using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using DevExpress.Utils;
using System.Reflection;

namespace PhotoViewer {
    public static class FilterHelper {
        public delegate Image ApplyFilterDelegate(Image img, params object[] filterParams);

        static Image FilterImage(Image source, ColorMatrix filterMatrix) {
            if(source == null) return null;
            Image res = new Bitmap(source.Width, source.Height);
            using(Graphics g = Graphics.FromImage(res)) {
                ImageAttributes attrib = new ImageAttributes();
                attrib.SetColorMatrix(filterMatrix);
                g.Clear(Color.Transparent);
                g.DrawImage(source, new Rectangle(Point.Empty, res.Size), 0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attrib); 
            }
            return res;
        }
        static ColorMatrix GetRedChannelColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetGreenChannelColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetBlueChannelColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 1.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetRGB2BGRColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 0.0f, 0.0f, 1.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetInvertColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { -1.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, -1.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, -1.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 1.0f, 1.0f, 1.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetSepiaColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 0.393f, 0.349f, 0.272f, 0.0f, 0.0f },
                    new float[] { 0.769f, 0.686f, 0.534f, 0.0f, 0.0f },
                    new float[] { 0.189f, 0.168f, 0.131f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetBWColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 1.5f, 1.5f, 1.5f, 0.0f, 0.0f },
                    new float[] { 1.5f, 1.5f, 1.5f, 0.0f, 0.0f },
                    new float[] { 1.5f, 1.5f, 1.5f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { -1.0f, -1.0f, -1.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetWhite2AlphaColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 1.0f, 0.0f, 0.0f, -1.0f, 0.0f },
                    new float[] { 0.0f, 1.0f, 0.0f, -1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 1.0f, -1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetPolaroidColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 1.438f, -0.062f, -0.062f, 0.0f, 0.0f },
                    new float[] { -0.122f, 1.378f, -0.122f, 0.0f, 0.0f },
                    new float[] { -0.016f, -0.016f, 1.483f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { -0.03f, 0.05f, -0.02f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetGrayscaleColorMatrix() {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 0.33f, 0.33f, 0.33f, 0.0f, 0.0f },
                    new float[] { 0.59f, 0.59f, 0.59f, 0.0f, 0.0f },
                    new float[] { 0.11f, 0.11f, 0.11f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetContrastColorMatrix(float c) {
            float t = (1.0f - c) / 2.0f;
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { c, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, c, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, c, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { t, t, t, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetBrightnessColorMatrix(float b) {
            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 1.0f, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { b, b, b, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static ColorMatrix GetSaturationColorMatrix(float s) {
            float lumR = 0.3086f;
            float lumG = 0.6094f;
            float lumB = 0.0820f;

            float sr = (1 - s) * lumR;
            float sg = (1 - s) * lumG;
            float sb = (1 - s) * lumB;

            ColorMatrix m = new ColorMatrix(
                new float[][] { 
                    new float[] { s + sr, sr, sr, 0.0f, 0.0f },
                    new float[] { sg, s + sg, sg, 0.0f, 0.0f },
                    new float[] { sb, sb, s + sb, 0.0f, 0.0f },
                    new float[] { 0.0f, 0.0f, 0.0f, 1.0f, 0.0f },
                    new float[] { 0.0f, 0,0f, 0.0f, 0.0f, 1.0f }
                }
            );
            return m;
        }
        static Image ApplyRedChannelFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetRedChannelColorMatrix());
        }
        static Image ApplyGreenChannelFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetGreenChannelColorMatrix());
        }
        static Image ApplyBlueChannelFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetBlueChannelColorMatrix());
        }
        static Image ApplyInvertFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetInvertColorMatrix());
        }
        static Image ApplyRGB2BGRFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetRGB2BGRColorMatrix());
        }
        static Image ApplySepiaFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetSepiaColorMatrix());
        }
        static Image ApplyBWFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetBWColorMatrix());
        }
        static Image ApplyPolaroidFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetPolaroidColorMatrix());
        }
        static Image ApplyGrayscaleFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetGrayscaleColorMatrix());
        }
        static Image ApplyWhite2AlphaFilter(Image img, params object[] filterParams) {
            return FilterImage(img, GetWhite2AlphaColorMatrix());
        }
        static Image ApplyContrastFilter(Image img, params object[] filterParams) { 
            float param = filterParams == null || filterParams.Length == 0? 2.0f: (float)filterParams[0];
            return FilterImage(img, GetContrastColorMatrix(param));
        }
        static Image ApplyBrightnessFilter(Image img, params object[] filterParams) { 
            float param = filterParams == null || filterParams.Length == 0? 0.3f: (float)filterParams[0];
            return FilterImage(img, GetBrightnessColorMatrix(param));
        }
        static Image ApplySaturationFilter(Image img, params object[] filterParams) {
            float param = filterParams == null || filterParams.Length == 0 ? 0.3f : (float)filterParams[0];
            return FilterImage(img, GetSaturationColorMatrix(param));
        }
        static FilterInfo GetFilterByName(string name) {
            foreach(FilterInfo info in Filters) {
                if(info.Name == name)
                    return info;
            }
            return null;
        }
        public static Image ApplyFilter(string name, Image img, params object[] filterParams) {
            FilterInfo info = GetFilterByName(name);
            if(info != null && img != null)
                return (Image)info.FilterMethod.DynamicInvoke(img, filterParams);
            return img;
        }
        static List<FilterInfo> filtersCore;
        public static List<FilterInfo> Filters {
            get {
                if(filtersCore == null) {
                    filtersCore = new List<FilterInfo>();
                    InitializeFilters(filtersCore);
                }
                return filtersCore;
            }
        }
        static void InitializeFilters(List<FilterInfo> filters) {
            filters.Add(new FilterInfo("Invert", new ApplyFilterDelegate(ApplyInvertFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("RGB->BGR", new ApplyFilterDelegate(ApplyRGB2BGRFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("Sepia", new ApplyFilterDelegate(ApplySepiaFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("Contrast", new ApplyFilterDelegate(ApplyContrastFilter), typeof(ContrastFilterParams)));
            filters.Add(new FilterInfo("Brightness", new ApplyFilterDelegate(ApplyBrightnessFilter), typeof(BrightnessFilterParams)));
            filters.Add(new FilterInfo("Saturation", new ApplyFilterDelegate(ApplySaturationFilter), typeof(SaturationFilterParams)));
            filters.Add(new FilterInfo("Black & White", new ApplyFilterDelegate(ApplyBWFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("Polaroid", new ApplyFilterDelegate(ApplyPolaroidFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("White -> Alpha", new ApplyFilterDelegate(ApplyWhite2AlphaFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("Grayscale", new ApplyFilterDelegate(ApplyGrayscaleFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("Red Channel", new ApplyFilterDelegate(ApplyRedChannelFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("Green Channel", new ApplyFilterDelegate(ApplyGreenChannelFilter), typeof(SimpleFilterParams)));
            filters.Add(new FilterInfo("Blue Channel", new ApplyFilterDelegate(ApplyBlueChannelFilter), typeof(SimpleFilterParams)));
        }
        public static string[] GetFiltersName() {
            string[] fname = new string[Filters.Count];
            int nameIndex = 0;
            foreach(FilterInfo info in Filters) {
                fname[nameIndex] = info.Name;
                nameIndex++;
            }
            return fname;
        }
        public static ImageCollection GetFiltersSamples(Image sampleImage) {
            ImageCollection coll = new ImageCollection();
            coll.ImageSize = sampleImage.Size;
            foreach(FilterInfo info in Filters) {
                coll.Images.Add((Image)info.FilterMethod.DynamicInvoke(sampleImage, null));
            }
            return coll;
        }
    }

    public class FilterInfo {
        string nameCore;
        Delegate filterMethodCore;
        Type paramsControlType;

        public FilterInfo(string name, Delegate filterMethod, Type paramsControlType) {
            this.nameCore = name;
            this.filterMethodCore = filterMethod;
            this.paramsControlType = paramsControlType;
        }

        public string Name { get { return nameCore; } }
        public Delegate FilterMethod { get { return filterMethodCore; } }
        public SimpleFilterParams CreateParamsControl() {
            ConstructorInfo ci = paramsControlType.GetConstructor(new Type[] { });
            SimpleFilterParams pc = (SimpleFilterParams)ci.Invoke(new object[] { });
            pc.Filter = this;
            return pc;
        }
    }
}

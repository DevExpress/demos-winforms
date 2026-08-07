using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using DevExpress.Data;
using DevExpress.Skins;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.WindowsMailClient.Win.Utils {
    public class SortInfo {
        public GridColumn Column { get; set; }
        public ColumnSortOrder Order { get; set; }
    }
    public static class Utils {
        public static string MessageFrom = "maildemo@dx-mail.com";
        static string _startMhtText = null;
        static string DefaultTextResourceName = "StartMhtText.txt";
        public static string StartMhtText {
            get {
                if(string.IsNullOrEmpty(_startMhtText)) {
                    var assembly = Assembly.GetExecutingAssembly();
                    using(Stream stream = assembly.GetManifestResourceStream(Assembly.GetExecutingAssembly().GetName().Name + ".Data." + DefaultTextResourceName)) {
                        using(StreamReader sr = new StreamReader(stream)) {
                            _startMhtText = sr.ReadToEnd();
                        }
                    }
                }
                return _startMhtText;
            }
            set { _startMhtText = value; }
        }
        static bool _useAsEmailSignature = true;
        public static bool UseAsEmailSignature { get { return _useAsEmailSignature; } set { _useAsEmailSignature = value; } }
        static bool _showNotifications = true;
        public static bool ShowNotifications { get { return _showNotifications; } set { _showNotifications = value; } }
    }
    static class ColorProvider {
        public static Color GetControlColor(LookAndFeel.UserLookAndFeel provider) {
            return DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(provider, SystemColors.Control);
        }
        public static Color TextColor {
            get { return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.ControlText); }
        }
        public static Color WindowColor {
            get { return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.Window); }
        }
        public static Color WindowTextColor {
            get { return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.WindowText); }
        }
        public static Color DisabledTextColor {
            get { return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.DisabledText); }
        }
        public static Color CriticalColor {
            get { return CommonColors.GetCriticalColor(LookAndFeel.UserLookAndFeel.Default); }
        }
        public static Color WarningColor {
            get { return CommonColors.GetWarningColor(LookAndFeel.UserLookAndFeel.Default); }
        }
        public static Color QuestionColor {
            get {
                return CommonColors.GetQuestionColor(LookAndFeel.UserLookAndFeel.Default);
            }
        }
        public static Color InformationColor {
            get { return CommonColors.GetInformationColor(LookAndFeel.UserLookAndFeel.Default); }
        }
    }
    static class FontProvider {
        static IDictionary<string, Font> cache;
        static FontProvider() {
            cache = new Dictionary<string, Font>();
        }
        public static Font GetSegoeUIFont(FontStyle fontStyle) {
            float defaultSize = DevExpress.Utils.AppearanceObject.DefaultFont.Size;
            return GetFont("Segoe UI", defaultSize, fontStyle);
        }
        public static Font GetSegoeUIFont(float sizeGrow = 0) {
            float defaultSize = DevExpress.Utils.AppearanceObject.DefaultFont.Size;
            return GetFont("Segoe UI", defaultSize + sizeGrow);
        }
        public static Font GetSegoeUILightFont(float sizeGrow = 0) {
            float defaultSize = DevExpress.Utils.AppearanceObject.DefaultFont.Size;
            return GetFont("Segoe UI Light", defaultSize + sizeGrow);
        }
        public static Font GetFont(string familyName, float size, FontStyle style = FontStyle.Regular) {
            string key = familyName + "#" + size;
            if(style != FontStyle.Regular)
                key += "#" + style;
            Font result = null;
            if(!cache.TryGetValue(key, out result)) {
                try {
                    var family = FindFontFamily(familyName);
                    result = new Font(family ?? FontFamily.GenericSansSerif, size, style);
                }
                catch(ArgumentException) { result = DevExpress.Utils.AppearanceObject.DefaultFont; }
                cache.Add(key, result);
            }
            return result;
        }
        static FontFamily FindFontFamily(string familyName) {
            return Array.Find(FontFamily.Families, (f) => f.Name == familyName);
        }
    }
}

using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    public class SpreadSheetTutorialControlBase : DevExpress.DXperience.Demos.TutorialControlBase {
        readonly CultureInfo _defaultCulture = new CultureInfo("en-US");

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoMergeRibbon { get { return true; } set { } }
        public CultureInfo DefaultCulture { get { return _defaultCulture; } }

        public virtual bool ShowWithPaddings { get { return false; } }
    }

    public class DemoUtils {
        public static string GetRelativePath(string name) {
            string path = Path.Combine("Data", name);
            return Tutorials.FilePathUtils.FindFilePath(path, false);
        }
        public static Bitmap LoadImageByName(string name) {
            string root = "DevExpress.XtraSpreadsheet.Demos.";
            System.Reflection.Assembly assembly = typeof(frmMain).Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{root}Resources.{name}");
            if(stream == null)
                stream = assembly.GetManifestResourceStream($"{root}{name}");
            if(stream != null)
                return ImageTool.ImageFromStream(stream) as Bitmap;
            return null;
        }

        public static void SetDatabasePath() {
            const string dbName = "nwind.mdb";
            const string pathToDbTag = "|pathToDb|";
            string path = GetRelativePath(dbName);
            if(string.IsNullOrEmpty(path))
                return;
            string connectionString = global::DevExpress.XtraSpreadsheet.Demos.Properties.Settings.Default["nwindConnectionString"] as string;
            if(string.IsNullOrEmpty(connectionString))
                return;
            connectionString = connectionString.Replace(pathToDbTag, path);
            global::DevExpress.XtraSpreadsheet.Demos.Properties.Settings.Default["nwindConnectionString"] = connectionString;
        }

        public static string GetLanguageString() {
            string result = DemoHelper.GetLanguageString(typeof(frmMain).Assembly);
            if(result == "CS")
                result = "C#";
            return result;
        }
    }

    public class DemoMenuManager {
        public static void SetMenuManager(Control.ControlCollection controls, IDXMenuManager menuManager) {
            int count = controls.Count;
            for(int i = 0; i < count; i++) {
                Control control = controls[i];
                BaseEdit baseEdit = control as BaseEdit;
                if(baseEdit != null)
                    baseEdit.MenuManager = menuManager;

                SetMenuManager(control.Controls, menuManager);
            }
        }
    }

    public class DemoColors {
        public static Color ApplyTint(Color color, float tint) {
            float red = color.R;
            float green = color.G;
            float blue = color.B;

            if(tint < 0) {
                red *= 1 + tint;
                green *= 1 + tint;
                blue *= 1 + tint;
            }
            else {
                red += (0xff - red) * tint;
                green += (0xff - green) * tint;
                blue += (0xff - blue) * tint;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }
    }

    class DemoMruItem {
        public ModuleInfo Module { get; set; }
        public Control TutorialControl { get; set; }
    }
}

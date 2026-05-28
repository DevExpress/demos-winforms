using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DemoData.Model;
using DevExpress.Images;
using DevExpress.LookAndFeel;
using DevExpress.MailClient.Win;
using DevExpress.MailDemo.Win;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.DPI;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraMap;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using DevExpress.XtraScheduler;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.ProductsDemo.Win {
    public static class AppHelper {
        public static void WarmUp() {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(BaseReallifeDemo).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(ImagesAssemblyType).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(AppearanceObject).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(BaseEdit).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(GridControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(RichEditControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(SpreadsheetControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(MapControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(ChartControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(XtraCharts.Wizard.DataPageTab).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(GaugeControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(SchedulerControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(PivotGridControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(XtraReport).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(Pdf.Drawing.PdfDocumentRenderer).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(PdfViewer).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(DataAccess.Sql.SqlDataSource).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(DataAccess.UI.FilterEditorControl).TypeHandle);
        }
    }
    public class GridHelper {
        public static void GridViewFocusObject(ColumnView cView, object obj) {
            if(obj == null) return;
            int oldFocusedRowHandle = cView.FocusedRowHandle;
            for(int i = 0; i < cView.DataRowCount; ++i) {
                object rowObj = cView.GetRow(i) as object;
                if(rowObj == null) continue;
                if(ReferenceEquals(obj, rowObj)) {
                    if(i == oldFocusedRowHandle)
                        cView.FocusedRowHandle = GridControl.InvalidRowHandle;
                    cView.FocusedRowHandle = i;
                    break;
                }
            }
        }
        public static void SetFindControlImages(GridControl grid) {
            FindControl fControl = null;
            foreach(Control ctrl in grid.Controls) {
                fControl = ctrl as FindControl;
                if(fControl != null) break;
            }
            if(fControl != null) {
                fControl.FindButton.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Search1;
                fControl.FindButton.ImageOptions.SvgImageSize = new Size(16, 16);
                fControl.ClearButton.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Delete;
                fControl.ClearButton.ImageOptions.SvgImageSize = new Size(16, 16);
                fControl.CalcButtonsBestFit();
            }
        }
    }
    public class ImageHelper {
        public static Bitmap GetScaleImage(Image image, Size size) {
            return new Bitmap(image, size.Width, size.Height);
        }
    }
    public class ColorHelper {
        public static void UpdateColor(ImageList list, UserLookAndFeel lf) {
            for(int i = 0; i < list.Images.Count; i++)
                list.Images[i] = SetColor(list.Images[i] as Bitmap, GetHeaderForeColor(lf));
        }
        public static Color GetHeaderForeColor(UserLookAndFeel lf) {
            Color ret = SystemColors.ControlText;
            if(lf.ActiveStyle != ActiveLookAndFeelStyle.Skin) return ret;
            return GridSkins.GetSkin(lf)[GridSkins.SkinHeader].Color.GetForeColor();
        }
        static Bitmap SetColor(Bitmap bmp, Color color) {
            for(int i = 0; i < bmp.Width; i++)
                for(int j = 0; j < bmp.Height; j++)
                    if(bmp.GetPixel(i, j).Name != "0")
                        bmp.SetPixel(i, j, color);
            return bmp;
        }
        public static Color DisabledTextColor {
            get {
                return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("DisabledText");
            }
        }
        public static Color CriticalColor {
            get {
                return CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            }
        }
        public static Color WarningColor {
            get {
                return CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            }
        }
        static string GetRGBColor(Color color) {
            return string.Format("{0},{1},{2}", color.R, color.G, color.B);
        }
    }
    public class ObjectHelper {
        public static void StartProcess(string processName) {
            if(Data.Utils.SafeProcess.Start(processName) == null)
                XtraMessageBox.Show("", Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    public class ValidationRulesHelper {
        static ConditionValidationRule _ruleIsNotBlank = null;
        public static ConditionValidationRule RuleIsNotBlank {
            get {
                if(_ruleIsNotBlank == null) {
                    _ruleIsNotBlank = new ConditionValidationRule();
                    _ruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank;
                    _ruleIsNotBlank.ErrorText = Properties.Resources.RuleIsNotBlankWarning;
                    _ruleIsNotBlank.ErrorType = ErrorType.Critical;
                }
                return _ruleIsNotBlank;
            }
        }
    }
    public class EditorHelper {
        public static RepositoryItemImageComboBox CreateTaskStatusImageComboBox(RepositoryItemImageComboBox edit) {
            Array arr = Enum.GetValues(typeof(TaskStatus));
            edit.Items.Clear();
            foreach(TaskStatus status in arr)
                edit.Items.Add(new ImageComboBoxItem(GetStringByTaskStatus(status), status, (int)status));
            return edit;
        }
        static string GetStringByTaskStatus(TaskStatus status) {
            switch(status) {
                case TaskStatus.Completed: return Properties.Resources.TaskStatusCompleted;
                case TaskStatus.Deferred: return Properties.Resources.TaskStatusDeferred;
                case TaskStatus.InProgress: return Properties.Resources.TaskStatusInProgress;
                case TaskStatus.WaitingOnSomeoneElse: return Properties.Resources.TaskStatusWaitingOnSomeoneElse;
            }
            return Properties.Resources.TaskStatusNotStarted;
        }
        public static RepositoryItemImageComboBox CreateTaskCategoryImageComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryHouseChores, TaskCategory.HouseChores, 0));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryShopping, TaskCategory.Shopping, 1));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryOffice, TaskCategory.Office, 2));
            return edit;
        }
        public static RepositoryItemImageComboBox CreateFlagStatusImageComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.SmallImages = CreateFlagStatusImageCollection();
            edit.GlyphAlignment = HorzAlignment.Center;
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Today, FlagStatus.Today, (int)FlagStatus.Today));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Tomorrow, FlagStatus.Tomorrow, (int)FlagStatus.Tomorrow));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.ThisWeek, FlagStatus.ThisWeek, (int)FlagStatus.ThisWeek));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NextWeek, FlagStatus.NextWeek, (int)FlagStatus.NextWeek));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NoDate, FlagStatus.NoDate, (int)FlagStatus.NoDate));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Custom, FlagStatus.Custom, (int)FlagStatus.Custom));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Completed, FlagStatus.Completed, (int)FlagStatus.Completed));
            return edit;
        }
        public static void InitPersonComboBox(RepositoryItemImageComboBox edit) {
            SvgImageCollection iCollection = new SvgImageCollection();
            iCollection.Add(Properties.Resources.Mr1);
            iCollection.Add(Properties.Resources.Ms1);
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Male, ContactGender.Male, 0));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Female, ContactGender.Female, 1));
            edit.SmallImages = iCollection;
        }
        public static void InitTitleComboBox(RepositoryItemImageComboBox edit) {
            SvgImageCollection iCollection = new SvgImageCollection();
            iCollection.Add(Properties.Resources.Doctor1);
            iCollection.Add(Properties.Resources.Miss1);
            iCollection.Add(Properties.Resources.Mr1);
            iCollection.Add(Properties.Resources.Mrs1);
            iCollection.Add(Properties.Resources.Ms1);
            iCollection.Add(Properties.Resources.Professor1);
            edit.Items.Add(new ImageComboBoxItem(string.Empty, ContactTitle.None, -1));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Dr), ContactTitle.Dr, 0));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Miss), ContactTitle.Miss, 1));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Mr), ContactTitle.Mr, 2));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Mrs), ContactTitle.Mrs, 3));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Ms), ContactTitle.Ms, 4));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Prof), ContactTitle.Prof, 5));
            edit.SmallImages = iCollection;
        }
        public static void InitPriorityComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityLow, 0, 0),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityMedium, 1, -1),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityHigh, 2, 1)});
        }
        public static string GetTitleNameByContactTitle(ContactTitle title) {
            switch(title) {
                case ContactTitle.Dr: return Properties.Resources.ContactTitleDr;
                case ContactTitle.Miss: return Properties.Resources.ContactTitleMiss;
                case ContactTitle.Mr: return Properties.Resources.ContactTitleMr;
                case ContactTitle.Mrs: return Properties.Resources.ContactTitleMrs;
                case ContactTitle.Ms: return Properties.Resources.ContactTitleMs;
                case ContactTitle.Prof: return Properties.Resources.ContactTitleProf;
            }
            return string.Empty;
        }
        static SvgImageCollection CreateFlagStatusImageCollection() {
            SvgImageCollection ret = new SvgImageCollection();
            ret.Add(Properties.Resources.Today_Flag1);
            ret.Add(Properties.Resources.Tomorrow_Flag1);
            ret.Add(Properties.Resources.ThisWeek_Flag1);
            ret.Add(Properties.Resources.NextWeek_Flag1);
            ret.Add(Properties.Resources.NoDate_Flag1);
            ret.Add(Properties.Resources.Custom_Flag1);
            ret.Add(Properties.Resources.Completed__2_);
            return ret;
        }

        internal static List<string> GetCities() {
            IEnumerable cities = (from contact in DataHelper.Contacts select contact.City).OrderBy(s => s).Distinct();
            return cities.Cast<string>().ToList();
        }
        internal static List<string> GetStates() {
            IEnumerable states = (from contact in DataHelper.Contacts select contact.State).OrderBy(s => s).Distinct();
            return states.Cast<string>().ToList();
        }
    }
    public class MapUtils {
        static string key = "CDOhtwNBSsbmBiN3rUEjmBJGHW2tRMbp5XVwu4J55VBZg8PdRe9MJQQJ99BEACYeBjFllM6LAAAgAZMP1cA4";
        public static string DevExpressAzureKey { get { return key; } }

        public static AzureMapDataProvider CreateAzureDataProvider(AzureTileset tileset) {
            return new AzureMapDataProvider() { AzureKey = DevExpressAzureKey, Tileset = tileset };
        }
        public static Image ScaleImage(Image source, ScaleHelper scaleHelper) {
            Size sourceSize = source.Size;
            Size deviceImageSize = scaleHelper.ScaleSize(sourceSize);
            if(sourceSize == deviceImageSize)
                return source;
            Bitmap bitmap = new Bitmap(deviceImageSize.Width, deviceImageSize.Height, PixelFormat.Format24bppRgb);
            using(Graphics graphics = Graphics.FromImage(bitmap)) {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                RectangleF srcRect = new RectangleF(0f, 0f, (float)source.Size.Width, (float)source.Size.Height);
                RectangleF destRect = new RectangleF(0f, 0f, (float)deviceImageSize.Width, (float)deviceImageSize.Height);
                srcRect.Offset(-0.5f, -0.5f);
                graphics.DrawImage(source, destRect, srcRect, GraphicsUnit.Pixel);
            }
            return bitmap;
        }
    }
}

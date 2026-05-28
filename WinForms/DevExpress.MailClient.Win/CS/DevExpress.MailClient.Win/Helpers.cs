using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.DevAV;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraRichEdit;

namespace DevExpress.MailClient.Win {
    public class MyGridView : GridView {
        protected override bool IsAllowPixelScrollingPreview {
            get {
                return true;
            }
        }
    }
    public class GridHelper {
        public static void GetChildDataRowHandles(GridView view, int rowHandle, List<Message> list) {
            for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
                int row = view.GetChildRowHandle(rowHandle, i);
                if(row >= 0)
                    list.Add(view.GetRow(row) as Message);
                else
                    GetChildDataRowHandles(view, row, list);
            }
        }
        public static void SetFindControlImages(GridControl grid) {
            FindControl fControl = null;
            foreach(Control ctrl in grid.Controls) {
                fControl = ctrl as FindControl;
                if(fControl != null) break;
            }
            if(fControl != null) {
                fControl.FindButton.ImageOptions.SvgImage = Properties.Resources.Search1;
                fControl.FindButton.ImageOptions.SvgImageSize = new Size(16, 16);
                fControl.ClearButton.ImageOptions.SvgImage = Properties.Resources.Delete;
                fControl.ClearButton.ImageOptions.SvgImageSize = new Size(16, 16);
                fControl.CalcButtonsBestFit();
            }
        }
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
    }
    public class ImageHelper {
        static Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
        public static Bitmap GetScaleImage(Image image, Size size) {
            return new Bitmap(image, size.Width, size.Height);
        }
        public static string GetFaviconIconPath(string link) {
            link = ObjectHelper.GetCorrectUrl(link);
            string[] links = link.Split('/');
            if(links.Length > 1)
#pragma warning disable DX0025 // should be safe (host name)
                return string.Format("http://{0}/favicon.ico", links[2]);
#pragma warning restore DX0025
            return null;
        }
        public static Bitmap CreateSenderImage(string sender, Size size, DevExpress.LookAndFeel.UserLookAndFeel ulf) {
            Bitmap image = null;
            if(images.TryGetValue(sender, out image))
                return image;
            Size imageSize = new Size(size.Width, size.Height);
            string[] parsedText = sender.Split(' ');
            string result = string.Empty;
            int count = 0;
            for(int i = 0; i < parsedText.Length; i++) {
                if(parsedText[i].Length > 0) {
                    result += parsedText[i][0];
                    count++;
                    if(count == 2) break;
                }
            }
            image = GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result);
            images.Add(sender, image);
            return image;
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
        public static string HtmlHyperLinkTextColor {
            get {
                Color color = EditorsSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("HyperLinkTextColor");
                return GetRGBColor(color);
            }
        }
        public static string HtmlHighlightTextColor {
            get {
                Color color = CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("HighlightText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlControlTextColor {
            get {
                Color color = CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("ControlText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlControlTextColor2 {
            get {
                Color color = CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("WindowText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlQuestionColor {
            get {
                Color color = CommonColors.GetQuestionColor(UserLookAndFeel.Default);
                return GetRGBColor(color);
            }
        }
        public static string HtmlWarningColor {
            get {
                Color color = CommonColors.GetWarningColor(UserLookAndFeel.Default);
                return GetRGBColor(color);
            }
        }
        public static Color DisabledTextColor {
            get {
                return CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor("DisabledText");
            }
        }
        public static Color CriticalColor {
            get {
                return CommonColors.GetCriticalColor(UserLookAndFeel.Default);
            }
        }
        public static Color WarningColor {
            get {
                return CommonColors.GetWarningColor(UserLookAndFeel.Default);
            }
        }
        static string GetRGBColor(Color color) {
            return string.Format("{0},{1},{2}", color.R, color.G, color.B);
        }
    }
    public class ObjectHelper {
        static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainTextFromMHT(string mhtText) {
            rich.MhtText = mhtText;
            return rich.Text.TrimStart();
        }
        public static string GetMHTTextFromHTML(string htmlText) {
            rich.HtmlText = htmlText;
            return rich.MhtText;
        }
        public static void ShowWebSite(string url) {
            if(url == null)
                return;
            string processName = GetCorrectUrl(url);
            if(processName.Length == 0) return;
            StartProcess(processName);
        }
        public static string GetCorrectUrl(string url) {
            string result = url.Replace(" ", string.Empty);
            if(result.Length == 0)
                return string.Empty;
            const string http = "http://";
            const string https = "https://";
            if(!result.StartsWith(http, StringComparison.OrdinalIgnoreCase) &&
                !result.StartsWith(https, StringComparison.OrdinalIgnoreCase))
                result = http + result;
            return result;
        }
        public static void StartProcess(string processName) {
            if(Data.Utils.SafeProcess.Start(processName) == null)
                XtraMessageBox.Show("", Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public class NavBarHelper {
        public static void DeleteEmptyGroup(NavBarControl nb) {
            for(int i = nb.Groups.Count - 1; i >= 0; i--)
                if(nb.Groups[i].ItemLinks.Count == 0)
                    nb.Groups.RemoveAt(i);
        }
        public static NavBarItemLink GetFirstItem(NavBarControl nb) {
            foreach(NavBarGroup group in nb.Groups)
                foreach(NavBarItemLink link in group.ItemLinks)
                    return link;
            return null;
        }
        public static NavBarGroup GetGroupByName(string groupName, NavBarControl navBar) {
            NavBarGroup group = null;
            foreach(NavBarGroup fGroup in navBar.Groups)
                if(fGroup.Name.Equals(groupName))
                    group = fGroup;
            if(group == null) {
                group = new NavBarGroup(groupName);
                group.Name = groupName;
                navBar.Groups.Add(group);
            }
            return group;
        }
        public static void SetNavBarItemImage(NavBarItem item, string link) {
            PictureEdit pe = new PictureEdit();
            pe.LoadAsync(ImageHelper.GetFaviconIconPath(link));
            pe.Tag = item;
            pe.LoadCompleted += new EventHandler(pe_LoadCompleted);
        }
        static void pe_LoadCompleted(object sender, EventArgs e) {
            RepositoryItemPictureEdit pe = sender as RepositoryItemPictureEdit;
            NavBarItem item = pe.OwnerEdit.Tag as NavBarItem;
            item.SmallImage = ImageHelper.GetScaleImage(((PictureEdit)pe.OwnerEdit).Image, new Size(16, 16));
            pe.OwnerEdit.Dispose();
            pe.Dispose();
        }
        public static object[] GetGroupNames(NavBarControl navBar) {
            List<string> ret = new List<string>();
            foreach(NavBarGroup group in navBar.Groups)
                ret.Add(group.Caption);
            return ret.ToArray();
        }
        public static List<string> GetItemNames(NavBarControl navBar) {
            List<string> ret = new List<string>();
            foreach(NavBarItem item in navBar.Items)
                ret.Add(item.Caption);
            return ret;
        }
        public static string GetUniqueItemName(string name, NavBarControl navBar) {
            List<string> names = GetItemNames(navBar);
            for(int i = 1; i < 9999; i++) {
                string ret = string.Format("{0}{1}", name, i);
                if(!names.Contains(ret)) return ret;
            }
            return string.Empty;
        }
    }
    public class UniqueNameValidationRule : ValidationRule {
        List<string> values;
        public UniqueNameValidationRule(List<string> values) {
            this.values = values;
        }
        public override bool Validate(Control control, object value) {
            string str = (string)value;
            foreach(string val in values)
                if(!ValidationHelper.Validate(str, ConditionOperator.NotEquals, val, null, null, false))
                    return false;
            return true;
        }
    }
    public class ValidationRulesHelper {
        static ConditionValidationRule ruleIsNotBlank = null;
        public static ConditionValidationRule RuleIsNotBlank {
            get {
                if(ruleIsNotBlank == null) {
                    ruleIsNotBlank = new ConditionValidationRule();
                    ruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank;
                    ruleIsNotBlank.ErrorText = Properties.Resources.RuleIsNotBlankWarning;
                    ruleIsNotBlank.ErrorType = ErrorType.Critical;
                }
                return ruleIsNotBlank;
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
            edit.SmallImages = CreateFlagStatusSvgImageCollection();
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
        public static void InitPriorityComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityLow, 0, 0),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityMedium, 1, -1),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityHigh, 2, 1)});
        }
        public static void InitTitleComboBox(RepositoryItemImageComboBox edit) {
            var iCollection = new SvgImageCollection();
            iCollection.Add(Properties.Resources.Doctor1);
            iCollection.Add(Properties.Resources.Miss1);
            iCollection.Add(Properties.Resources.Mr1);
            iCollection.Add(Properties.Resources.Mrs1);
            iCollection.Add(Properties.Resources.Ms1);
            iCollection.Add(Properties.Resources.Professor1);
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Dr), PersonPrefix.Dr, 0));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Miss), PersonPrefix.Miss, 1));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mr), PersonPrefix.Mr, 2));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mrs), PersonPrefix.Mrs, 3));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Ms), PersonPrefix.Ms, 4));
            edit.SmallImages = iCollection;
        }
        public static string GetTitleNameByContactTitle(PersonPrefix title) {
            switch(title) {
                case PersonPrefix.Dr: return Properties.Resources.ContactTitleDr;
                case PersonPrefix.Miss: return Properties.Resources.ContactTitleMiss;
                case PersonPrefix.Mr: return Properties.Resources.ContactTitleMr;
                case PersonPrefix.Mrs: return Properties.Resources.ContactTitleMrs;
                case PersonPrefix.Ms: return Properties.Resources.ContactTitleMs;
            }
            return string.Empty;
        }
        static SvgImageCollection CreateFlagStatusSvgImageCollection() {
            var collection = new SvgImageCollection();
            collection.Add(Properties.Resources.Today1);
            collection.Add(Properties.Resources.Tomorrow1);
            collection.Add(Properties.Resources.ThisWeek1);
            collection.Add(Properties.Resources.NextWeek1);
            collection.Add(Properties.Resources.NoDate1);
            collection.Add(Properties.Resources.Custom1);
            collection.Add(Properties.Resources.Completed1);
            return collection;
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
    public class TokenEditHelper {
        public static void Initialize(TokenEdit tokenEdit) {
            foreach(Contact contact in DataHelper.Contacts.OrderBy(p => p.EmployeeName)) {
                TokenEditToken item = new TokenEditToken(contact.EmployeeName, contact);
                tokenEdit.Properties.Tokens.Add(item);
            }
        }
        public static IList<Contact> ParseFromField(string fromField) {
            BindingList<Contact> contactList = new BindingList<Contact>();
            if(string.IsNullOrEmpty(fromField)) return contactList;
            foreach(string from in SplitFromField(fromField)) {
                Contact contact = DataHelper.FindByName(from);
                if(contact == null)
                    contact = new UnknownContact(FormatEmail(from));
                contactList.Add(contact);
            }
            return contactList;
        }
        public static string FormatContactList(IList<Contact> contactList) {
            return string.Join(", ", contactList);
        }
        public static bool ValidateEmail(string email) {
            return EmailRegex.IsMatch(email);
        }
        static IEnumerable<string> SplitFromField(string fromField) {
            string[] parts = fromField.Split(PossibleSeparators);
            for(int n = 0; n < parts.Length; n++) {
                yield return parts[n].Trim();
            }
        }
        static readonly char[] PossibleSeparators = new char[] { ',' };
        static string FormatEmail(string from) {
            if(ValidateEmail(from)) return from;
            return FormatEmailCore(from);
        }
        static string FormatEmailCore(string value) {
            StringBuilder builder = new StringBuilder(value);
            builder.Replace(" (", "_");
            builder.Replace(')', '_');
            builder.Replace(' ', '_');
            builder.Replace('-', '_');
            builder.Append("@dxmail.net");
            return builder.ToString();
        }
        static Regex EmailRegex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled);
    }
}

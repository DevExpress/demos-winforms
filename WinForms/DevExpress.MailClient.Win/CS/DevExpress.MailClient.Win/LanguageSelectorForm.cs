using System;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Localizer;
using DevExpress.Utils.Localization;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraNavBar;
using DevExpress.XtraScheduler.Localization;

namespace DevExpress.MailClient.Win {
    public partial class LanguageSelectorForm : XtraForm {
        public LanguageSelectorForm() {
            InitializeComponent();
        }

        private void englishSimpleButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void arabicSimpleButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            SetCulture("ar");
            Close();
        }

        private void farsiSimpleButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            SetCulture("fa");   //TODO
            Close();
        }

        private void hebrewSimpleButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            SetCulture("he");
            Close();
        }
        private static void SetCulture(string name) {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(name);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(name);
            Properties.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;   //TODO
            GridLocalizer.Active = GetActiveGridLocalizer(name);
            XtraEditors.Controls.Localizer.Active = GetActiveEditorLocalizer(name);
            SchedulerLocalizer.Active = GetActiveSchedulerLocalizer(name);
            SchedulerExtensionsLocalizer.Active = GetActiveSchedulerExtensionsLocalizer(name);
            BarLocalizer.Active = GetActiveBarLocalizer(name);
            NavBarLocalizer.Active = GetActiveNavBarLocalizer(name);
        }

        private static XtraLocalizer<SchedulerExtensionsStringId> GetActiveSchedulerExtensionsLocalizer(string name) {
            switch(name) {
                case "fa":
                    return new FarsiSchedulerExtensionsLocalizer();
                case "ar":
                    return new ArabicSchedulerExtensionsLocalizer();
                case "he":
                    return new HebrewSchedulerExtensionsLocalizer();
                default:
                    return SchedulerExtensionsLocalizer.Active;
            }
        }

        private static XtraLocalizer<NavBarStringId> GetActiveNavBarLocalizer(string name) {
            switch(name) {
                case "fa":
                    return new FarsiNavBarLocalizer();
                case "ar":
                    return new ArabicNavBarLocalizer();
                case "he":
                    return new HebrewNavBarLocalizer();
                default:
                    return NavBarLocalizer.Active;
            }
        }

        private static XtraLocalizer<BarString> GetActiveBarLocalizer(string name) {
            switch(name) {
                case "fa":
                    return new FarsiBarLocalizer();
                case "ar":
                    return new ArabicBarLocalizer();
                case "he":
                    return new HebrewBarLocalizer();
                default:
                    return BarLocalizer.Active;
            }
        }

        private static XtraLocalizer<SchedulerStringId> GetActiveSchedulerLocalizer(string name) {
            switch(name) {
                case "fa":
                    return new FarsiSchedulerLocalizer();
                case "ar":
                    return new ArabicSchedulerLocalizer();
                case "he":
                    return new HebrewSchedulerLocalizer();
                default:
                    return SchedulerLocalizer.Active;
            }
        }

        private static XtraLocalizer<StringId> GetActiveEditorLocalizer(string name) {
            switch(name) {
                case "fa":
                    return new FarsiEditorLocalizer();
                case "ar":
                    return new ArabicEditorLocalizer();
                case "he":
                    return new HebrewEditorLocalizer();
                default:
                    return XtraEditors.Controls.Localizer.Active;
            }
        }

        private static XtraLocalizer<GridStringId> GetActiveGridLocalizer(string name) {
            switch(name) {
                case "fa":
                    return new FarsiGridLocalizer();
                case "ar":
                    return new ArabicGridLocalizer();
                case "he":
                    return new HebrewGridLocalizer();
                default:
                    return GridLocalizer.Active;
            }
        }
    }


}

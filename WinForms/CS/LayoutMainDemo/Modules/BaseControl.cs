using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraLayout.Demos {
    public partial class BaseTutorialControl : DevExpress.XtraLayout.Demos.TutorialControl {
        string defaultJSONName = "Default.json";
        bool fCustomization = false;
        public BaseTutorialControl() {
            InitializeComponent();
            Customization = false;
        }

        public override LayoutControl ExportControl { get { return BaseLayout; } }
        public virtual LayoutControl BaseLayout { get { return null; } }
        protected virtual string FileMask { get { return "xtra"; } }
        bool isInitializingPanels = true;
        void cbFiles_EditValueChanged(object sender, System.EventArgs e) {
            if(!isInitializingPanels) Restore();
        }
        protected void InitPanels() {
            navigationPage1.Visible = BaseLayout != null;
            if(BaseLayout != null) {
                var jsonFileNames = FindingJsonFiles(@"Data\FormLayouts", FileMask);
                if(jsonFileNames.Count == 0) navigationPage1.Visible = false;
                cbFiles.Properties.Items.Clear();
                foreach(JSONFileName _name in jsonFileNames) {
                    cbFiles.Properties.Items.Add(new RadioGroupItem(_name, _name.Name));
                    if(_name.Name == defaultJSONName) {
                        cbFiles.SelectedIndex = cbFiles.Properties.Items.Count - 1;
                    }
                }
                BaseLayout.ShowCustomization += new EventHandler(ShowCustomization);
                BaseLayout.HideCustomization += new EventHandler(HideCustomization);
                BaseLayout.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
                BaseLayout.OptionsView.AllowItemSkinning = true;
                BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = true;
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All;
            }
            isInitializingPanels = false;
        }
        [DefaultValue(false)]
        public bool Customization {
            get { return fCustomization; }
            set {
                fCustomization = value;
                sbCustomize.Text = (fCustomization) ? "Hide Customization Form" : "Show Customization Form";
            }
        }
        void ShowCustomization(object sender, EventArgs e) {
            Customization = true;
        }
        void HideCustomization(object sender, EventArgs e) {
            Customization = false;
        }
        //<cbFiles>
        string CurrentJsonFileName {
            get {
                JSONFileName file = cbFiles.EditValue as JSONFileName;
                if(file == null) return "";
                return file.FullName;
            }
        }
        void Restore() {
            if(BaseLayout == null || string.IsNullOrEmpty(CurrentJsonFileName))
                return;
            using(var jsonStream = File.OpenRead(CurrentJsonFileName))
                BaseLayout.RestoreLayoutFromJson(jsonStream);
            //</cbFiles>
            BaseLayout.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            BaseLayout.Root.GroupBordersVisible = false;
            tabTransitionAnimation_CheckedChanged(null, null);
            highlightGroupBordersCheckEdit_CheckedChanged(null, null);
            highlightTabHeadersCheckEdit_CheckedChanged(null, null);
            defaultJSONName = "";
            //<cbFiles>
        }
        //</cbFiles>
        #region Finding Xml Files
        internal static List<JSONFileName> FindingJsonFiles(string folder, string mask) {
            string rootFullPath = Path.GetFullPath(Application.StartupPath);
            List<JSONFileName> jsonFiles = new List<JSONFileName>();
            for(int i = 0; i <= 10; i++) {
                string fullPath = Path.GetFullPath(Path.Combine(rootFullPath, folder));
                if(Directory.Exists(fullPath)) {
#pragma warning disable DX0025 // no path traversal
                    string[] names = Directory.GetFiles(fullPath, mask + "*.json");
#pragma warning restore DX0025
                    foreach(string _name in names) {
                        FileInfo fInfo = new FileInfo(_name);
                        string fName = fInfo.Name;
                        fName = fName.Replace(mask, "");
                        jsonFiles.Add(new JSONFileName(fName, fInfo.FullName));
                    }
                    return jsonFiles;
                }
                else rootFullPath += "\\..";
            }
            return jsonFiles;
        }
        internal class JSONFileName {
            readonly string fName, fFullName;
            public JSONFileName(string name, string fullName) {
                this.fName = name;
                this.fFullName = fullName;
            }
            public string Name { get { return fName; } }
            public string FullName { get { return fFullName; } }
            public override string ToString() {
                return Name;
            }
        }
        #endregion
        protected override void DoHide() {
            if(BaseLayout != null) BaseLayout.HideCustomizationForm();
            lcTitle.HideCustomizationForm();
        }
        //<sbCustomize>
        void sbCustomize_Click(object sender, System.EventArgs e) {
            if(BaseLayout == null)
                return;
            if(Customization)
                BaseLayout.HideCustomizationForm();
            else
                BaseLayout.ShowCustomizationForm();
        }
        //</sbCustomize>
        //<highlightFocusedItemCheckEdit>
        void highlightFocusedItemCheckEdit_CheckedChanged(object sender, System.EventArgs e) {
            if(BaseLayout == null)
                return;
            BaseLayout.OptionsView.HighlightFocusedItem = highlightFocusedItemCheckEdit.Checked;
        }
        //</highlightFocusedItemCheckEdit>
        //<quickCustomizationCheckEdit>
        void quickCustomizationCheckEdit_CheckedChanged(object sender, EventArgs e) {
            if(BaseLayout == null)
                return;
            if(quickCustomizationCheckEdit.Checked == true) {
                BaseLayout.CustomizationMode = CustomizationModes.Quick;
            }
            else BaseLayout.CustomizationMode = CustomizationModes.Default;
        }
        //</quickCustomizationCheckEdit>
        //<showAdornerLayerCheckEdit>
        void showAdornerLayerCheckEdit_CheckedChanged(object sender, EventArgs e) {
            BaseLayout.OptionsView.DrawAdornerLayer = showAdornerLayerCheckEdit.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
        //</showAdornerLayerCheckEdit>
        //<allowExpandAnimationCheckEdit>
        void allowExpandAnimationCheckEdit_CheckedChanged(object sender, EventArgs e) {
            BaseLayout.OptionsView.AllowExpandAnimation = allowExpandAnimationCheckEdit.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
        //</allowExpandAnimationCheckEdit>
        //<showPropertyGridCheckEdit>
        void showPropertyGridCheckEdit_CheckedChanged(object sender, EventArgs e) {
            BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = showPropertyGridCheckEdit.Checked;
        }
        //</showPropertyGridCheckEdit>
        //<snapModeCheckEdit>
        void snapModeCheckEdit_CheckedChanged(object sender, EventArgs e) {
            if(snapModeCheckEdit.Checked)
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All;
            else
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.None;
        }
        //</snapModeCheckEdit>
        //<tabTransitionAnimationCheckEdit>
        void tabTransitionAnimation_CheckedChanged(object sender, EventArgs e) {
            SetTransition(tabTransitionAnimationCheckEdit.Checked);
        }
        void SetTransition(bool value) {
            foreach(var item in BaseLayout.Items) {
                TabbedControlGroup tcg = item as TabbedControlGroup;
                if(tcg == null) continue;
                tcg.Transition.AllowTransition = value ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            }
        }
        //</tabTransitionAnimationCheckEdit>
        void snapModeLCI_CustomDraw(object sender, ItemCustomDrawEventArgs e) {
            e.DefaultDraw();
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(55, 127, 221, 134)), e.Bounds);
            e.Handled = true;
        }
        //<highlightGroupBordersCheckEdit> //<highlightTabHeadersCheckEdit>
        List<Color> skinColors = new List<Color>() { DXSkinColors.FillColors.Danger, DXSkinColors.FillColors.Primary, DXSkinColors.FillColors.Question, DXSkinColors.FillColors.Success, DXSkinColors.FillColors.Warning };
        //</highlightTabHeadersCheckEdit>
        void highlightGroupBordersCheckEdit_CheckedChanged(object sender, EventArgs e) {
            int iterator = 0;
            foreach(var item in BaseLayout.Items) {
                LayoutControlGroup lcg = item as LayoutControlGroup;
                if(lcg == null || lcg == BaseLayout.Root) continue;
                lcg.AppearanceGroup.BorderColor = highlightGroupBordersCheckEdit.Checked ? skinColors[iterator++ % skinColors.Count] : Color.Empty;

            }
        }
        //</highlightGroupBordersCheckEdit>
        //<highlightTabHeadersCheckEdit>
        private void highlightTabHeadersCheckEdit_CheckedChanged(object sender, EventArgs e) {
            int iterator = 0;
            foreach(var item in BaseLayout.Items) {
                LayoutControlGroup lcg = item as LayoutControlGroup;
                if(lcg == null || lcg == BaseLayout.Root) continue;
                lcg.AppearanceTabPage.Header.BackColor = highlightTabHeadersCheckEdit.Checked ? skinColors[iterator++ % skinColors.Count] : Color.Empty;

            }
        }
        //</highlightTabHeadersCheckEdit>
    }
}

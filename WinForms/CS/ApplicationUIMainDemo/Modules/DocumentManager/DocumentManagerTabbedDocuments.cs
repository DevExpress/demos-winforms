using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerTabbedDocuments : TabbedViewTutorialControl {
        public DocumentManagerTabbedDocuments() {
            AutoMergeRibbon = true;
            InitializeComponent();
            InitOptions();
            tabbedView.OrientationChanged += tabbedView_OrientationChanged;
        }
        void InitOptions() {
            repositoryItemImageComboBox1.Items.AddEnum(typeof(TabHeaderLocation));
            repositoryItemImageComboBox2.Items.AddEnum(typeof(TabOrientation));
            repositoryItemImageComboBox3.Items.AddEnum(typeof(Orientation));
            repositoryItemImageComboBox4.Items.AddEnum(typeof(ClosePageButtonShowMode));
            repositoryItemImageComboBox5.Items.AddEnum(typeof(PinPageButtonShowMode));
            beiHeadeLocation.EditValue = tabbedView.DocumentGroupProperties.HeaderLocation;
            beiHeaderOrientation.EditValue = tabbedView.DocumentGroupProperties.HeaderOrientation;
            beiClosePageButton.EditValue = tabbedView.DocumentGroupProperties.ClosePageButtonShowMode;
            beiOrientation.EditValue = tabbedView.Orientation;
            beiShowPinTab.EditValue = tabbedView.DocumentGroupProperties.PinPageButtonShowMode;
        }
        void tabbedView_OrientationChanged(object sender, EventArgs e) {
            beiOrientation.EditValue = tabbedView.Orientation;
        }
        void Form1_Load(object sender, EventArgs e) {
            AddDocument();
            AddDocument();
            AddDocument();
            AddDocument();
            AddDocument();
            tabbedView.Controller.CreateNewDocumentGroup(tabbedView.Documents[3] as Document);
            tabbedView.Controller.MoveToDocumentGroup(tabbedView.Documents[4] as Document, true);
        }
        void biAddDocumentClick(object sender, ItemClickEventArgs e) {
            AddDocument();
        }
        int i = 0;
        void AddDocument() {
            XtraUserControl child = new XtraUserControl();
            DocumentSettings settings = new DocumentSettings();
            settings.Caption = "Document" + (i++).ToString();
            settings.Image = svgImageCollection1.GetImage(i % (svgImageCollection1.Count - 1));
            DocumentSettings.Attach(child, settings);
            child.Padding = new Padding(16);
            LabelControl label = new LabelControl();
            label.Text = DemosInfo.GetLoremIpsumText(i);
            label.AutoSizeMode = LabelAutoSizeMode.Vertical;
            label.Parent = child;
            label.Dock = DockStyle.Fill;
            tabbedView.AddDocument(child);
            EnableColoredTabs();
        }
        void EnableColoredTabs() {
            if(bciColoredTabs.Checked)
                ((Document)tabbedView.Documents[tabbedView.Documents.Count - 1]).Appearance.Header.BackColor = TabColors[(i - 1) % 6];
        }
        void headerLocationChanged(object sender, System.EventArgs e) {
            tabbedView.DocumentGroupProperties.HeaderLocation = (TabHeaderLocation)beiHeadeLocation.EditValue;
        }
        void headerOrientationChanged(object sender, System.EventArgs e) {
            tabbedView.DocumentGroupProperties.HeaderOrientation = (TabOrientation)beiHeaderOrientation.EditValue;
        }
        void viewOrientationChanged(object sender, EventArgs e) {
            tabbedView.Orientation = (Orientation)beiOrientation.EditValue;
        }
        void closePageButtonModeChanged(object sender, EventArgs e) {
            tabbedView.DocumentGroupProperties.ClosePageButtonShowMode = (ClosePageButtonShowMode)beiClosePageButton.EditValue;
        }
        void showPinTabChanged(object sender, EventArgs e) {
            tabbedView.DocumentGroupProperties.PinPageButtonShowMode = (PinPageButtonShowMode)beiShowPinTab.EditValue;
        }
        Color[] TabColors = new Color[]{
            Color.FromArgb(35,83,194),
            Color.FromArgb(64,168,19),
            Color.FromArgb(245,121,10),
            Color.FromArgb(141,62,168),
            Color.FromArgb(70,155,183),
            Color.FromArgb(196,19,19)
        };
        void bciColoredTabs_CheckedChanged(object sender, ItemClickEventArgs e) {
            bool isChecked = ((BarCheckItem)sender).Checked;
            int j = 0;
            foreach(Document document in tabbedView.Documents) {
                Color tabColor = Color.Empty;
                if(isChecked)
                    tabColor = TabColors[j % 6];
                document.Appearance.Header.BackColor = tabColor;
                j++;
            }
        }
        void bciDockGuides_CheckedChanged(object sender, ItemClickEventArgs e) {
            bool isChecked = ((BarCheckItem)sender).Checked;
            tabbedView.ShowDockGuidesOnPressingShift = isChecked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
    }
}

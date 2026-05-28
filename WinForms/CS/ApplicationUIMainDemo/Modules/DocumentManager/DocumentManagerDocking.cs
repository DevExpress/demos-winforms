using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerDocking : TutorialControlBase {
        public DocumentManagerDocking() {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {
            AddDocument();
            AddDocument();
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
        }
    }
}

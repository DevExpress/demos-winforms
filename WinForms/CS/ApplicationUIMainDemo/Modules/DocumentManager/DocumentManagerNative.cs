using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerNative : TutorialControlBase {
        public DocumentManagerNative() {
            AutoMergeRibbon = true;
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {
            AddDocument();
            AddDocument();
            AddDocument();
            AddDocument();
            AddDocument();
            nativeView.Controller.Cascade();
        }
        void biAddDocumentClick(object sender, ItemClickEventArgs e) {
            AddDocument();
        }
        int i = 0;
        void AddDocument() {
            XtraUserControl child = new XtraUserControl();
            BaseDocumentSettings settings = new BaseDocumentSettings();
            settings.Caption = "Document" + (i++).ToString();
            settings.Image = imageCollection1.Images[i % (imageCollection1.Images.Count - 1)];
            BaseDocumentSettings.Attach(child, settings);
            child.Padding = new Padding(16);
            LabelControl label = new LabelControl();
            label.Text = DemosInfo.GetLoremIpsumText(i);
            label.AutoSizeMode = LabelAutoSizeMode.Vertical;
            label.Parent = child;
            label.Dock = DockStyle.Fill;
            nativeView.AddDocument(child);            
        }
    }
}

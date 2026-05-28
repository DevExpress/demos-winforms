using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerWindowsUISearchPanel : TutorialControl {
        public DocumentManagerWindowsUISearchPanel() {
            InitializeComponent();            
            ucDocumentManagerWindowsUISearchPanel ucDocumentManagerWindowsUI = new ucDocumentManagerWindowsUISearchPanel();
            ucDocumentManagerWindowsUI.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucDocumentManagerWindowsUI);
        }   
    }    
}

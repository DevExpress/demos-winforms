using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.UI;
using DevExpress.DevAV.ViewModels;
using DevExpress.DevAV.Services;
using DevExpress.XtraPrinting;
using DevExpress.Mvvm;
using DevExpress.XtraBars.Docking2010;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.PrintableControlPrintPreviewDocumentType)]
    public partial class PrintableControlPrintPreview : BaseViewWithWinUIButtons {
        public PrintableControlPrintPreview() {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode) {
                InitBinding();
            }
        }

        private void InitBinding() {
            var fluentAPI = mvvmContext1.OfType<PrintableControlPreviewViewModel>();
            fluentAPI.SetBinding(documentViewer, dv => dv.DocumentSource, x => x.PrintModel.PrintingSystem.PrintingSystem);

            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).ImageUri = ToolbarExtension.GetImageUri("ZoomIn");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Click += (s, e) => documentViewer.ExecCommand(PrintingSystemCommand.ZoomIn);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).ImageUri = ToolbarExtension.GetImageUri("ZoomOut");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Click += (s, e) => documentViewer.ExecCommand(PrintingSystemCommand.ZoomOut); 

            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).ImageUri = ToolbarExtension.GetImageUri("Print");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).Click += (s, e) => documentViewer.ExecCommand(PrintingSystemCommand.PrintDirect);

            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[5], x => x.Close(), "Cancel");
        }

        private void documentViewer_ZoomChanged(object sender, EventArgs e) {
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Enabled = documentViewer.Zoom < documentViewer.MaxZoom;
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Enabled = documentViewer.Zoom > documentViewer.MinZoom;
        }
    }
}

using System;
using System.ComponentModel;
using DevExpress.DevAV.ViewModels;
using DevExpress.Printing;
using DevExpress.Utils.MVVM.UI;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Preview;
using DevExpress.XtraPrinting;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.EmployeeReportViewDocumentType)]
    public partial class EmployeeReportView : BaseViewWithWinUIButtons {
        public EmployeeReportView() {
            InitializeComponent();
            imagesContainer = new PrinterImagesContainer();
            CreatePrintItemContainer();
            if(!mvvmContext.IsDesignMode) 
                InitBinding();
        }
        void CreatePrintItemContainer() {
            try {
                printerItemContainer = new PrinterItemContainer();
            }
            catch { }
        }
        void InitBinding() {
            var fluentAPI = mvvmContext.OfType<ReportPreviewViewModel>();
            fluentAPI.SetBinding(documentViewer, dv => dv.DocumentSource, x => x.Report);
            fluentAPI.WithEvent(this, "Load")
                .EventToCommand(x => x.Load());

            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).ImageUri = ToolbarExtension.GetImageUri("ZoomIn");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Click += (s, e) => documentViewer.ExecCommand(PrintingSystemCommand.ZoomIn);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).ImageUri = ToolbarExtension.GetImageUri("ZoomOut");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Click += (s, e) => documentViewer.ExecCommand(PrintingSystemCommand.ZoomOut);

            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).ImageUri = ToolbarExtension.GetImageUri("Print");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).Click += (s, e) => Print();
            btnPrint.Click += (s, e) => Print();

            ((WindowsUIButton)windowsUIButtonPanel.Buttons[5]).ImageUri = ToolbarExtension.GetImageUri("Settings");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[5]).Click += ShowHideSettings;

            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[6], x => x.Close(), "Cancel");

            fluentAPI.BindCommand(btnIncudeEvaluations, x => x.ShowEvaluations(true), x => true);
            fluentAPI.BindCommand(btnExcludeEvaluations, x => x.ShowEvaluations(true), x => false);

            cbPrinters.Properties.SmallImages = imagesContainer.SmallImages;
            cbPrinters.Properties.LargeImages = imagesContainer.LargeImages;

            if(printerItemContainer != null) {
                foreach(PrinterItem printerItem in printerItemContainer.Items)
                    cbPrinters.Properties.Items.Add(CreateItemForPrinter(printerItem));
                SelectedPrinter = printerItemContainer.DefaultPrinterName;
            } else {
                DisablePrintButtons();
            }

            btnOptions.Click += (s, e) => documentViewer.ExecCommand(PrintingSystemCommand.Print);
            fluentAPI.SetTrigger(x => x.ReportType, type => {
                layoutControlGroupSettings.Visibility = type == EmployeeReportType.Profile ? 
                    XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
            });
        }
        PrinterItemContainer printerItemContainer;
        PrinterImagesContainer imagesContainer;
        ImageComboBoxItem CreateItemForPrinter(PrinterItem item) {
            return new ImageComboBoxItem(item.DisplayName, item.FullName, imagesContainer.GetImageIndex(item));
        }
        void DisablePrintButtons() {
            cbPrinters.Enabled = false;
            btnOptions.Enabled = false;
            btnPrint.Enabled = false;
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).Enabled = false;
        }
        void ShowHideSettings(object sender, System.EventArgs e) {
            layoutControl.Visible = !layoutControl.Visible;
        }
        void documentViewer_ZoomChanged(object sender, System.EventArgs e) {
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Enabled = documentViewer.Zoom < documentViewer.MaxZoom;
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Enabled = documentViewer.Zoom > documentViewer.MinZoom;
        }
        public string SelectedPrinter {
            get { return (string)cbPrinters.EditValue; }
            set { cbPrinters.EditValue = value; }
        }
        void Print() {
            var fluentAPI = mvvmContext.OfType<ReportPreviewViewModel>();
            using(var tool = new PrintTool(fluentAPI.ViewModel.Report.PrintingSystem)) {
                try {
                    tool.Print(SelectedPrinter);
                } catch(Win32Exception) {
                    
                } catch(Exception e) {
                    NotificationService.ShowException<PrintingSystemBase>(LookAndFeel, ParentForm, e);
                }
            }
        }
    }
}

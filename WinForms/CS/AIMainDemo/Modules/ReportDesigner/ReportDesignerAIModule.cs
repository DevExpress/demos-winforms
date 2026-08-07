using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.AI.Demos.Properties;
using DevExpress.DXperience.Demos;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;

namespace DevExpress.AI.Demos {
    public partial class ReportDesignerAIModule : AITutorialControl {
        public ReportDesignerAIModule() {
            InitializeComponent();
            UpdatePaddings();
        }

        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            gallery.InitializeGallery(GetFeatureInfos());
        }
        IEnumerable<FeatureTileInfo> GetFeatureInfos() {
            return new[] {
                new FeatureTileInfo() {
                    Caption = "Localization",
                    Description = @"Use AI-powered localization to translate report content to a different language with a single click.
<href=https://docs.devexpress.com/XtraReports/405435>Learn More</href>",
                    Image = Resources.ai_reports_localizationThumb
                },
                new FeatureTileInfo() {
                    Caption = "Report Creation",
                    Description = @"Run the Report Wizard to generate a new report layout based on a natural language prompt.
<href=https://docs.devexpress.com/XtraReports/405460>Learn More</href>",
                    Image = Resources.ai_reports_wizardThumb
                },
                new FeatureTileInfo() {
                    Caption = "Report Modification",
                    Description = @"Chat with an AI Assistant to make adjustments to your report layout (available for .NET 8+).
<href=https://docs.devexpress.com/XtraReports/405498>Learn More</href>",
                    Image = Resources.ai_reports_chatThumb
                },
                new FeatureTileInfo() {
                    Caption = "Test Data Preview",
                    Description = @"Preview your report with AI-generated test data before connecting to a live source.
<href=https://docs.devexpress.com/XtraReports/405566>Learn More</href>",
                    Image = Resources.ai_reports_test_dataThumb
                },
                new FeatureTileInfo() {
                    Caption = "Prompt-to-Expression",
                    Description = @"Generate a data binding expression or a filter condition based on a natural language prompt.
<href=https://docs.devexpress.com/XtraReports/405646>Learn More</href>",
                    Image = Resources.ai_expression_Thumb
                },
            };
        }

        void runDesignerBtn_Click(object sender, EventArgs e) {
            var size = new Size();
            using(var form = new DemoWaitForm()) {
                size = form.Size;
            }
            Point waitFormLocation = tableLayoutPanel.PointToScreen(new Point((this.Width - size.Width) / 2, (this.Height - size.Height) / 2));
            SplashScreenManager.ShowForm(this, typeof(DemoWaitForm), true, false, SplashFormStartPosition.Manual, waitFormLocation);
            using(XtraReport report = CreateReport())
            using(ReportDesignerForm form = new ReportDesignerForm()) {
                form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                form.OpenReport(report);
                form.Load += (s, args) => SplashScreenManager.CloseForm(false);
                form.ShowDialog();
            }
        }

        protected virtual XtraReport CreateReport() {
            return new XtraReportsDemos.NorthwindTraders.InvoiceReport();
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdatePaddings();
        }
        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }

        void OnResize(object sender, EventArgs e) {
            int availableHeight = tableLayoutPanel.ClientSize.Height;
            int reservedHeight = lblTitle.Height + btnRunDesigner.Height + lblTitle.Margin.Vertical + btnRunDesigner.Margin.Vertical;
            int maxGalleryHeight = availableHeight - reservedHeight;
            galleryContainerPanel.MaximumSize = new Size(0, maxGalleryHeight);
            galleryContainerPanel.MinimumSize = new Size(0, 0);
        }
    }
}

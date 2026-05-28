using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using DevExpress.AI.Demos.Properties;
using DevExpress.AIIntegration.WinForms.Reporting.Internal;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace DevExpress.AI.Demos {
    public partial class ReportDesignerForm : RibbonForm {
        readonly GuideController guideController;

        public ReportDesignerForm() {
            InitializeComponent();
            guideController = new GuideController(this, GetGuides());

#if NET
            behaviorManager1.Attach<DevExpress.AIIntegration.WinForms.Reporting.ReportModifyBehavior>(reportDesigner1);
#endif
        }
        public XRDesignPanel ActiveXRDesignPanel { get { return reportDesigner1.ActiveDesignPanel; } }

        public void OpenReport(XtraReport report) {
            reportDesigner1.OpenReport(report);
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            guideController.ShowGuides();            
        }

        object FindTestDataItem() {
            return ribbonControl1.PageHeaderItemLinks.FirstOrDefault(a => a.Item is TestDataSourceBarButtonItem);
        }

        GuideInfo[] GetGuides() {
            List<GuideInfo> guides = new List<GuideInfo> {
                new GuideInfo() {
                    Image = Resources.ai_reports_localizationGuide,
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = FindSmartTagControl
                },
                new GuideInfo() {
                    Image = Resources.ai_reports_wizardGuide,
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = () => commandBarItem6
                },
                new GuideInfo() {
                    Image = Resources.ai_reports_expressionGuide,
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = FindSmartTagControl
                },
                new GuideInfo() {
                    Image = Resources.ai_reports_test_dataGuide,
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = FindTestDataItem
                }
            };
#if NET
            guides.Add(new GuideInfo() {
                Image = Resources.ai_reports_chatGuide,
                Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Left,
                GetTarget = FindAIAssistantPanel
            });
#endif
            return guides.ToArray();
        }

        object FindSmartTagControl() {
            var designer = reportDesigner1.ActiveDesignPanel.GetService<IDesignerHost>()
                .GetDesigner(reportDesigner1.ActiveDesignPanel.Report) as ReportDesignerBase;
            return designer.ReportFrame.CollectControls(x => x.GetType().Name.Contains("CornerPanel")).FirstOrDefault();
        }
#if NET
        object FindAIAssistantPanel() {
            var aiAssistant = xrDesignDockManager1.Panels.Union(xrDesignDockManager1.RootPanels).FirstOrDefault(x => x.Text == "AI Assistant");
            xrDesignDockManager1.ActivePanel = aiAssistant;
            return aiAssistant;
        }
#endif
    }
}

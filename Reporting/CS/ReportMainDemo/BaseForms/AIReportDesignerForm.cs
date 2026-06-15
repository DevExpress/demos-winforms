using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using DevExpress.AIIntegration.WinForms.Reporting;
using DevExpress.AIIntegration.WinForms.Reporting.Internal;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.Design;
using RibbonReportDesigner;

namespace XtraReportsDemos {
    public class AIReportDesignerForm : OfficeInspiredMainForm {
        #region fields
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.ComponentModel.IContainer components;
        readonly GuideController guideController;
        #endregion

        #region WinForms designer auto-generated code
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIReportDesignerForm));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportDesigner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            //
            // reportDesigner1
            //
            this.behaviorManager1.SetBehaviors(this.reportDesigner1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.Reporting.ReportPromptToReportBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.Reporting.XRDesignMdiControllerGenerationBehaviorSource), 3, true, 0F))),
            ((DevExpress.Utils.Behaviors.Behavior)(((DevExpress.AIIntegration.WinForms.Reporting.ReportLocalizationBehavior)(DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.Reporting.ReportLocalizationBehavior), typeof(DevExpress.AIIntegration.WinForms.Reporting.XRDesignMdiControllerLocalizationBehaviorSource), new object[] {
                        ((object)(3)),
                        ((object)(false)),
                        ((object)(0F))}))))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.Reporting.ReportTestDataSourceBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.Reporting.XRDesignMdiControllerTestDataSourceBehaviorSource), 10, null))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.Reporting.ReportPromptToExpressionBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.Reporting.XRDesignMdiControllerPromptToReportExpressionBehaviorSource))))});
            // 
            // AIReportDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1830, 972);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AIReportDesignerForm.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AIReportDesignerForm";
            ((System.ComponentModel.ISupportInitialize)(this.reportDesigner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public AIReportDesignerForm() {
            InitializeComponent();
            guideController = new GuideController(this, GetGuides());

#if NET
            behaviorManager1.Attach<ReportModifyBehavior>(reportDesigner1);
#endif
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            ShowGuides();
        }

        void ShowGuides() {
            guideController.ShowGuides();
        }

        object FindTestDataItem() {
            return Ribbon.PageHeaderItemLinks.FirstOrDefault(a => a.Item is TestDataSourceBarButtonItem);
        }

        GuideInfo[] GetGuides() {
            List<GuideInfo> guides = new List<GuideInfo> {
                new GuideInfo() {
                    Image = GetImage("LocalizationGuide"),
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = FindSmartTagControl
                },
                new GuideInfo() {
                    Image = GetImage("WizardGuide"),
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = () => commandBarItem6
                },
                new GuideInfo() {
                    Image = GetImage("AIExpressionGuide"),
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = FindSmartTagControl
                },
                new GuideInfo() {
                    Image = GetImage("TestDataGuide"),
                    Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Right,
                    GetTarget = FindTestDataItem
                }
            };
#if NET
            guides.Add(new GuideInfo() {
                Image = GetImage("ChatGuide"),
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
        static Image GetImage(string name) {
            return ResourceImageHelper.CreateImageFromResources(string.Format("XtraReportsDemos.Resources.AI.{0}.png", name), typeof(AIReportDesignerForm).Assembly);
        }
    }
}

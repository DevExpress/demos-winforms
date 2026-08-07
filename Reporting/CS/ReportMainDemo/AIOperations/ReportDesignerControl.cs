using System.Collections.Generic;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using RibbonReportDesigner;

namespace XtraReportsDemos.AIOperations {
    public class AIReportDesignerControl : ReportDesignerModuleBase {
        #region fields

        private ucDisclaimerPanel ucDisclaimerPanel1;

        #endregion

        protected override string Title => "AI-powered Report Designer";

        public AIReportDesignerControl() {
            InitializeComponent();
            UpdateBottomSpacings();
        }

        protected override IEnumerable<FeatureTileInfo> GetFeatureInfos() {
            return new[] {
                new FeatureTileInfo() {
                    Caption = "Localization",
                    Description = @"Use AI-powered localization to translate report content to a different language with a single click.
<href=https://docs.devexpress.com/XtraReports/405435>Learn More</href>",
                    Image = GetImage("LocalizationThumb")
                },
                new FeatureTileInfo() {
                    Caption = "Report Creation",
                    Description = @"Run the Report Wizard to generate a new report layout based on a natural language prompt.
<href=https://docs.devexpress.com/XtraReports/405460>Learn More</href>",
                    Image = GetImage("WizardThumb")
                },
                new FeatureTileInfo() {
                    Caption = "Report Modification",
                    Description = @"Chat with an AI Assistant to make adjustments to your report layout (available for .NET 8+).
<href=https://docs.devexpress.com/XtraReports/405498>Learn More</href>",
                    Image = GetImage("ChatThumb")
                },
                new FeatureTileInfo() {
                    Caption = "Test Data Preview",
                    Description = @"Preview your report with AI-generated test data before connecting to a live source.
<href=https://docs.devexpress.com/XtraReports/405566>Learn More</href>",
                    Image = GetImage("FakeDataThumb")
                },
                new FeatureTileInfo() {
                    Caption = "Prompt-to-Expression",
                    Description = @"Generate a data binding expression or a filter condition based on a natural language prompt.
<href=https://docs.devexpress.com/XtraReports/405646>Learn More</href>",
                    Image = GetImage("ExpressionsThumb")
                },
            };
        }

        protected override MainFormBase CreateDesignerForm() {
            AIServicesRegistration.RegisterIfNeeded();
            return new AIReportDesignerForm();
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateBottomSpacings();
        }
        protected override void DoDpiChangeAfterParent() {
            base.DoDpiChangeAfterParent();
            UpdateBottomSpacings();
        }

        void UpdateBottomSpacings() {
            lciHeader.Spacing = new DevExpress.XtraLayout.Utils.Padding(
                            lciHeader.Spacing.Left,
                            lciHeader.Spacing.Right,
                            lciHeader.Spacing.Top,
                            -ucDisclaimerPanel1.RoundedPanelOffset / 2
                            );
        }

        static Image GetImage(string name) {
            return ResourceImageHelper.CreateImageFromResources(string.Format("XtraReportsDemos.Resources.AI.{0}.png", name), typeof(AIReportDesignerForm).Assembly);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.ucDisclaimerPanel1 = new XtraReportsDemos.AIOperations.ucDisclaimerPanel();
            ((System.ComponentModel.ISupportInitialize)(this.lcc)).BeginInit();
            this.lcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).BeginInit();
            this.SuspendLayout();
            //
            // lcc
            //
            this.lcc.Controls.Add(this.ucDisclaimerPanel1);
            this.lcc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1698, 338, 1687, 1183);
            this.lcc.Controls.SetChildIndex(this.ucDisclaimerPanel1, 0);
            //
            // lciHeader
            //
            this.lciHeader.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lciHeader.AppearanceItemCaption.Options.UseBackColor = true;
            this.lciHeader.Control = this.ucDisclaimerPanel1;
            //
            // ucDisclaimerPanel1
            //
            this.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1";
            this.ucDisclaimerPanel1.Size = new System.Drawing.Size(1568, 220);
            this.ucDisclaimerPanel1.TabIndex = 5;
            //
            // AIReportDesignerControl
            //
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Name = "AIReportDesignerControl";
            ((System.ComponentModel.ISupportInitialize)(this.lcc)).EndInit();
            this.lcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

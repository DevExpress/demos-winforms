using DevExpress.AIIntegration.WinForms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.AI.Demos {
    public partial class SmartSearchAIModule : AITutorialControl {
        XtraRichEdit.RichEditControl richEditControl1 = new XtraRichEdit.RichEditControl();
        SmartSearchBehavior behavior;
        public SmartSearchAIModule() {
            InitializeComponent();
            AutoMergeRibbon = true;
            pictureEdit1.BackColor = tablePanel1.BackColor;

            RibbonControl ribbonControl = richEditControl1.CreateRibbon();
            Controls.Add(ribbonControl);
            ribbonControl.Merge += RibbonControl_Merge;
            ribbonControl.UnMerge += RibbonControl_UnMerge;

            behavior = SmartSearchBehavior.Create(typeof(SmartSearchRibbonBehaviorSource));
            behavior.Properties.Events.OperationFailed += OnOperationFailed;
            behaviorManager1.SetBehaviors(ribbonControl, new DevExpress.Utils.Behaviors.Behavior[] { behavior });

            UpdatePaddings();
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            pictureEdit1.BackColor = tablePanel1.BackColor;
        }
        protected override void UpdatePaddings() {
            UpdateBottomSpacings(layoutControlItem2, ucDisclaimerPanel1.RoundedPanelOffset);
        }

        private void RibbonControl_UnMerge(object sender, RibbonMergeEventArgs e) {
            if(behaviorManager1.GetBehavior<SmartSearchBehavior>(e.MergeOwner) != null)
                behaviorManager1.Detach<SmartSearchBehavior>(e.MergeOwner);
            e.MergeOwner.OptionsSearchMenu.SearchItemPosition = SearchItemPosition.Default;
            e.MergeOwner.RibbonCaptionAlignment = RibbonCaptionAlignment.Default;
            e.MergeOwner.CustomSearchItemPosition -= CustomSearchItemPosition;
        }

        private void RibbonControl_Merge(object sender, RibbonMergeEventArgs e) {
            if(behaviorManager1.GetBehavior<SmartSearchBehavior>(e.MergeOwner) == null)
                behaviorManager1.SetBehaviors(e.MergeOwner, new DevExpress.Utils.Behaviors.Behavior[] { behavior });
            e.MergeOwner.OptionsSearchMenu.SearchItemPosition = SearchItemPosition.Caption;
            e.MergeOwner.RibbonCaptionAlignment = RibbonCaptionAlignment.Center;
            e.MergeOwner.CustomSearchItemPosition += CustomSearchItemPosition;
        }

        private void CustomSearchItemPosition(object sender, RibbonCustomSearchItemPositionArgs e) {
            if(e.IsCollapsed)
                return;
            int searchItemWidth = (int)(e.Bounds.Width * 0.3f);
            e.SearchItemBounds = e.SearchItemBounds.WithWidth(searchItemWidth).WithX(e.Bounds.Width - searchItemWidth);

        }
    }
}

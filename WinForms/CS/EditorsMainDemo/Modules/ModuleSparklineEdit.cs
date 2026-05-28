using System;
using DevExpress.Sparkline;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleSparklineEdit : TutorialControl {
        public ModuleSparklineEdit() {
            InitializeComponent();
            CalcControlsBestSize();
            TutorialInfo.AboutFile = null;
            TutorialInfo.Description = "";
            TutorialInfo.TutorialName = "Sparkline Edit Tutorial";
            InitializeViewCombobox();
            UpdateElements();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleSparklineEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "SparklineEdit"; } }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            CalcControlsBestSize();
        }
        void CalcControlsBestSize() {
            this.layoutControl1.BeginUpdate();
            try {
                CalcTrackBarBestSize(this.trbArea);
            }
            finally { this.layoutControl1.EndUpdate(); }
        }
        void InitializeViewCombobox() {
            foreach (SparklineViewType view in Enum.GetValues(typeof(SparklineViewType)))
                cbeView.Properties.Items.Add(view);
            cbeView.SelectedItem = sparklineEdit.Properties.View.Type;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        void UpdateElements() {
            ceMax.Color = sparklineEdit.Properties.View.ActualMaxPointColor;
            ceMin.Color = sparklineEdit.Properties.View.ActualMinPointColor;
            ceStart.Color = sparklineEdit.Properties.View.ActualStartPointColor;
            ceEnd.Color = sparklineEdit.Properties.View.ActualEndPointColor;
            ceColor.Color = sparklineEdit.Properties.View.ActualColor;
            ceNegative.Color = sparklineEdit.Properties.View.ActualNegativePointColor;

            cheHighlightMaxPoint.Checked = sparklineEdit.Properties.View.HighlightMaxPoint;
            cheHighlightMinPoint.Checked = sparklineEdit.Properties.View.HighlightMinPoint;
            cheHighlightStartPoint.Checked = sparklineEdit.Properties.View.HighlightStartPoint;
            cheHighlightEndPoint.Checked = sparklineEdit.Properties.View.HighlightEndPoint;

            LineSparklineView lineView = sparklineEdit.Properties.View as LineSparklineView;
            cheShowMarkers.Enabled = ceMarkers.Enabled = lineView != null;
            if (lineView != null) {
                ceMarkers.Color = lineView.ActualMarkerColor;
                cheHighlightNegativePoints.Checked = lineView.HighlightNegativePoints;
                cheShowMarkers.Checked = lineView.ShowMarkers;
            }

            AreaSparklineView areaView = sparklineEdit.Properties.View as AreaSparklineView;
            trbArea.Enabled = areaView != null;
            if (areaView != null)
                trbArea.Value = areaView.AreaOpacity;

            cheHighlightNegativePoints.Enabled = !(sparklineEdit.Properties.View is WinLossSparklineView);
            if (sparklineEdit.Properties.View is BarSparklineView)
                cheHighlightNegativePoints.Checked = ((BarSparklineView)sparklineEdit.Properties.View).HighlightNegativePoints;

            ceMax.Enabled = cheHighlightMaxPoint.Checked;
            ceMin.Enabled = cheHighlightMinPoint.Checked;
            ceStart.Enabled = cheHighlightStartPoint.Checked;
            ceEnd.Enabled = cheHighlightEndPoint.Checked;
            ceMarkers.Enabled = cheShowMarkers.Checked && cheShowMarkers.Enabled;
            ceNegative.Enabled = cheHighlightNegativePoints.Checked && cheHighlightNegativePoints.Enabled || !cheHighlightNegativePoints.Enabled;
        }
        // <cbeView>
        void cbeView_SelectedIndexChanged(object sender, EventArgs e) {
            if (sparklineEdit.Properties.View.Type != (SparklineViewType)cbeView.SelectedItem)
                sparklineEdit.Properties.View = SparklineViewBase.CreateView((SparklineViewType)cbeView.SelectedItem);
            UpdateElements();
        }
        // </cbeView>
        // <ceColor>
        void ceColor_EditValueChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.Color = ceColor.Color;
        }
        // </ceColor>
        // <trbArea>
        void trbArea_EditValueChanged(object sender, EventArgs e) {
            AreaSparklineView areaView = sparklineEdit.Properties.View as AreaSparklineView;
            if (areaView != null)
                areaView.AreaOpacity = (byte)trbArea.Value;
        }
        // </trbArea>
        // <ceStart>
        void ceStart_EditValueChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.StartPointColor = ceStart.Color;
        }
        // </ceStart>
        // <ceMin>
        void ceMin_EditValueChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.MinPointColor = ceMin.Color;
        }
        // </ceMin>
        // <ceEnd>
        void ceEnd_EditValueChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.EndPointColor = ceEnd.Color;
        }
        // </ceEnd>
        // <ceMax>
        void ceMax_EditValueChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.MaxPointColor = ceMax.Color;
        }
        // </ceMax>
        // <ceNegative>
        void ceNegative_EditValueChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.NegativePointColor = ceNegative.Color;
        }
        // </ceNegative>
        // <ceMarkers>
        void ceMarkers_EditValueChanged(object sender, EventArgs e) {
            if (sparklineEdit.Properties.View is LineSparklineView)
                ((LineSparklineView)sparklineEdit.Properties.View).MarkerColor = ceMarkers.Color;
        }
        // </ceMarkers>
        // <cheHighlightStartPoint>
        void cheHighlightStartPoint_CheckedChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.HighlightStartPoint = cheHighlightStartPoint.Checked;
            ceStart.Enabled = cheHighlightStartPoint.Checked;
        }
        // </cheHighlightStartPoint>
        // <cheHighlightMinPoint>
        void cheHighlightMinPoint_CheckedChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.HighlightMinPoint = cheHighlightMinPoint.Checked;
            ceMin.Enabled = cheHighlightMinPoint.Checked;
        }
        // </cheHighlightMinPoint>
        // <cheHighlightEndPoint>
        void cheHighlightEndPoint_CheckedChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.HighlightEndPoint = cheHighlightEndPoint.Checked;
            ceEnd.Enabled = cheHighlightEndPoint.Checked;
        }
        // </cheHighlightEndPoint>
        // <cheHighlightMaxPoint>
        void cheHighlightMaxPoint_CheckedChanged(object sender, EventArgs e) {
            sparklineEdit.Properties.View.HighlightMaxPoint = cheHighlightMaxPoint.Checked;
            ceMax.Enabled = cheHighlightMaxPoint.Checked;
        }
        // </cheHighlightMaxPoint>
        // <cheHighlightNegativePoints>
        void cheHighlightNegativePoints_CheckedChanged(object sender, EventArgs e) {
            if (sparklineEdit.Properties.View is LineSparklineView)
                ((LineSparklineView)sparklineEdit.Properties.View).HighlightNegativePoints = cheHighlightNegativePoints.Checked;
            else if (sparklineEdit.Properties.View is BarSparklineView)
                ((BarSparklineView)sparklineEdit.Properties.View).HighlightNegativePoints = cheHighlightNegativePoints.Checked;
            ceNegative.Enabled = cheHighlightNegativePoints.Checked;
        }
        // </cheHighlightNegativePoints>
        // <cheShowMarkers>
        void cheShowMarkers_CheckedChanged(object sender, EventArgs e) {
            LineSparklineView lineView = sparklineEdit.Properties.View as LineSparklineView;
            if (lineView != null)
                lineView.ShowMarkers = cheShowMarkers.Checked;
            ceMarkers.Enabled = cheShowMarkers.Checked;
        }
        // </cheShowMarkers>
    }
}

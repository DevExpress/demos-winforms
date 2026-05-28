using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.Sparkline;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    public partial class Sparklines : TutorialControl {
        const int januaryIndex = 3;
        const int decemberIndex = 14;
        public override BaseView ExportView { get { return gridControl.MainView; } }
        public Sparklines() {
            InitializeComponent();
            cheHighlightMaxPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint;
            cheHighlightMinPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint;
            cheHighlightStartPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint;
            cheHighlightEndPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint;
            UpdateColors();
            UpdateMaxColorEnabled();
            UpdateMinColorEnabled();
            UpdateStartColorEnabled();
            UpdateEndColorEnabled();
            InitCustomersPaymentData(dsContacts1);
            InitializeViewCombobox();
            repositoryItemSparklineEdit1.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "Sparklines" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "Sparklines"; }
        }
        void InitializeViewCombobox() {
            foreach (SparklineViewType view in Enum.GetValues(typeof(SparklineViewType)))
                cbeView.Properties.Items.Add(view);
            cbeView.SelectedItem = repositoryItemSparklineEdit1.View.Type;
        }
        void Sparklines_Load(object sender, System.EventArgs e) {
            gridControl.ForceInitialize();
            gridView.ExpandAllGroups();
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            UpdateColors();
        }
        //<cbeView>
        void cbeView_SelectedIndexChanged(object sender, EventArgs e) {
            if (repositoryItemSparklineEdit1.View.Type != (SparklineViewType)cbeView.SelectedItem)
                repositoryItemSparklineEdit1.View = SparklineViewBase.CreateView((SparklineViewType)cbeView.SelectedItem);
            UpdateColors();
            repositoryItemSparklineEdit1.View.HighlightMaxPoint = cheHighlightMaxPoint.Checked;
            repositoryItemSparklineEdit1.View.HighlightMinPoint = cheHighlightMinPoint.Checked;
            repositoryItemSparklineEdit1.View.HighlightStartPoint = cheHighlightStartPoint.Checked;
            repositoryItemSparklineEdit1.View.HighlightEndPoint = cheHighlightEndPoint.Checked;
        }
        //</cbeView>
        //<cheHighlightMaxPoint>
        void cheHighlightMaxPoint_CheckedChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.HighlightMaxPoint = cheHighlightMaxPoint.Checked;
            UpdateMaxColorEnabled();
        }
        //</cheHighlightMaxPoint>
        //<cheHighlightMinPoint>
        void cheHighlightMinPoint_CheckedChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.HighlightMinPoint = cheHighlightMinPoint.Checked;
            UpdateMinColorEnabled();
        }
        //</cheHighlightMinPoint>
        //<cheHighlightStartPoint>
        void cheHighlightStartPoint_CheckedChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.HighlightStartPoint = cheHighlightStartPoint.Checked;
            UpdateStartColorEnabled();
        }
        //</cheHighlightStartPoint>
        //<cheHighlightEndPoint>
        void cheHighlightEndPoint_CheckedChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.HighlightEndPoint = cheHighlightEndPoint.Checked;
            UpdateEndColorEnabled();
        }
        //</cheHighlightEndPoint>
        void UpdateMaxColorEnabled() {
            ceMax.Enabled = cheHighlightMaxPoint.Checked;
        }
        void UpdateMinColorEnabled() {
            ceMin.Enabled = cheHighlightMinPoint.Checked;
        }
        void UpdateStartColorEnabled() {
            ceStart.Enabled = cheHighlightStartPoint.Checked;
        }
        void UpdateEndColorEnabled() {
            ceEnd.Enabled = cheHighlightEndPoint.Checked;
        }
        //<ceStart>
        void ceStart_EditValueChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.StartPointColor = CalculateColor(ceStart);
        }
        //</ceStart>
        //<ceMin>
        void ceMin_EditValueChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.MinPointColor = CalculateColor(ceMin);
        }
        //</ceMin>
        //<ceEnd>
        void ceEnd_EditValueChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.EndPointColor = CalculateColor(ceEnd);
        }
        //</ceEnd>
        //<ceMax>
        void ceMax_EditValueChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.MaxPointColor = CalculateColor(ceMax);
        }
        //</ceMax>
        //<ceColor>
        void ceColor_EditValueChanged(object sender, EventArgs e) {
            repositoryItemSparklineEdit1.View.Color = CalculateColor(ceColor);
        }
        //</ceColor>
        void UpdateColors() {
            Color maxPointColor = repositoryItemSparklineEdit1.View.MaxPointColor;
            repositoryItemSparklineEdit1.View.MaxPointColor = Color.Empty;
            ceMax.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualMaxPointColor;
            repositoryItemSparklineEdit1.View.MaxPointColor = maxPointColor;
            ceMax.Color = repositoryItemSparklineEdit1.View.ActualMaxPointColor;

            Color minPointColor = repositoryItemSparklineEdit1.View.MinPointColor;
            repositoryItemSparklineEdit1.View.MinPointColor = Color.Empty;
            ceMin.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualMinPointColor;
            repositoryItemSparklineEdit1.View.MinPointColor = minPointColor;
            ceMin.Color = repositoryItemSparklineEdit1.View.ActualMinPointColor;

            Color startPointColor = repositoryItemSparklineEdit1.View.StartPointColor;
            repositoryItemSparklineEdit1.View.StartPointColor = Color.Empty;
            ceStart.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualStartPointColor;
            repositoryItemSparklineEdit1.View.StartPointColor = startPointColor;
            ceStart.Color = repositoryItemSparklineEdit1.View.ActualStartPointColor;

            Color endPointColor = repositoryItemSparklineEdit1.View.EndPointColor;
            repositoryItemSparklineEdit1.View.EndPointColor = Color.Empty;
            ceEnd.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualEndPointColor;
            repositoryItemSparklineEdit1.View.EndPointColor = endPointColor;
            ceEnd.Color = repositoryItemSparklineEdit1.View.ActualEndPointColor;

            Color _color = repositoryItemSparklineEdit1.View.Color;
            repositoryItemSparklineEdit1.View.Color = Color.Empty;
            ceColor.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualColor;
            repositoryItemSparklineEdit1.View.Color = _color;
            ceColor.Color = repositoryItemSparklineEdit1.View.ActualColor;
        }
        Color CalculateColor(ColorPickEdit colorPick) {
            return (colorPick.Color == colorPick.Properties.AutomaticColor) ? Color.Empty : colorPick.Color;
        }
        //<gridControl>
        void gridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            if (e.IsGetData) {
                List<double> values = new List<double>();
                DataRowView row = (DataRowView)e.Row;
                for (int i = januaryIndex; i <= decemberIndex; i++)
                    values.Add((double)row.Row.ItemArray[i]);
                e.Value = values;
            }
        }
        //</gridControl>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}

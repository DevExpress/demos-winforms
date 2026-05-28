using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit.API.Layout;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class HitTestingModule : TutorialControl {
        readonly Dictionary<LayoutType, RichEditPen> _highlightOptions = new Dictionary<LayoutType, RichEditPen>();

        public HitTestingModule() {
            InitializeComponent();
            LoadDocument("HitTest.docx");
            RibbonControl ribbonControl = richEditControl.CreateRibbon();
            Controls.Add(ribbonControl);
            cbScope.Properties.Items.AddEnum<ScopeType>();
            cbScope.SelectedIndex = 0;
            SpecifyHighlightOptions();
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }
        int CurrentPageIndex { get; set; }
        RichEditHitTestResult HitTestResult { get; set; }
        Dictionary<LayoutType, RichEditPen> HighlightOptions { get { return _highlightOptions; } }

        void RichEditControl_BeforePagePaint(object sender, BeforePagePaintEventArgs e) {
            if(e.CanvasOwnerType == CanvasOwnerType.Control && e.Page.Index == CurrentPageIndex && HitTestResult != null) {
                RichEditPen defaultHighlightingPen = highlightOther.Checked ? new RichEditPen(otherHigtlightColor.Color, 3) : null;
                e.Painter = new HitTestPagePainter(RichEditHitTestResult.Reverse(HitTestResult), HighlightOptions, defaultHighlightingPen);
            }
        }
        void HitTest(Point point) {
            PageLayoutPosition pageLayoutPosition = RichEdit.ActiveView.GetDocumentLayoutPosition(point);
            if(pageLayoutPosition == null) {
                HitTestResult = null;
                return;
            }

            CurrentPageIndex = pageLayoutPosition.PageIndex;
            Point position = pageLayoutPosition.Position;
            LayoutPage page = RichEdit.DocumentLayout.GetPage(CurrentPageIndex);
            HitTestManager hitTestManager = new HitTestManager(RichEdit.DocumentLayout);
            HitTestSearchOption searchOption = rgSearchOptions.SelectedIndex == 0 ? HitTestSearchOption.Exact : HitTestSearchOption.Nearest;

            switch((ScopeType)cbScope.EditValue) {
                case ScopeType.Page:
                    HitTestResult = hitTestManager.HitTest(page, position, searchOption);
                    break;
                case ScopeType.MainPageArea:
                    HitTestResult = hitTestManager.HitTest(page.PageAreas[0], position, searchOption);
                    break;
                case ScopeType.HeaderPageArea:
                    if(page.Header != null)
                        HitTestResult = hitTestManager.HitTest(page.Header, position, searchOption);
                    break;
                case ScopeType.FooterPageArea:
                    if(page.Footer != null)
                        HitTestResult = hitTestManager.HitTest(page.Footer, position, searchOption);
                    break;
            }
        }
        void OnHighlightOptionsChanged(object sender, EventArgs e) {
            SpecifyHighlightOptions();
        }
        void SpecifyHighlightOptions() {
            HighlightOptions.Clear();
            HighlightOptions.Add(LayoutType.Page, highlightPage.Checked ? new RichEditPen(pageHigtlightColor.Color, 3) : null);
            HighlightOptions.Add(LayoutType.PageArea, highlightPageArea.Checked ? new RichEditPen(pageAreaHigtlightColor.Color, 3) : null);
            HighlightOptions.Add(LayoutType.Column, highlightColumn.Checked ? new RichEditPen(columnHigtlightColor.Color, 3) : null);
            HighlightOptions.Add(LayoutType.Row, highlightRow.Checked ? new RichEditPen(rowHigtlightColor.Color, 3) : null);
            HighlightOptions.Add(LayoutType.PlainTextBox, highlightBox.Checked ? new RichEditPen(boxHigtlightColor.Color, 3) : null);
            HighlightOptions.Add(LayoutType.CharacterBox, highlightCharacterBox.Checked ? new RichEditPen(characterBoxHigtlightColor.Color, 3) : null);
        }
        void RichEditControl_MouseMove(object sender, MouseEventArgs e) {
            HitTest(e.Location);
            RichEdit.Invalidate();
        }
        void RichEditControl_MouseClick(object sender, MouseEventArgs e) {
            lbResult.Items.Clear();
            RichEditHitTestResult reversedResult = RichEditHitTestResult.Reverse(HitTestResult);
            int i = 0;
            while(reversedResult != null) {
                string item = String.Format("{0}- {1}", Concat(' ', i * 2), reversedResult.LayoutElement.Type);
                lbResult.Items.Add(item);
                reversedResult = reversedResult.Next;
                i++;
            }
        }
        string Concat(char c, int count) {
            StringBuilder builder = new StringBuilder(count);
            builder.Append(c, count);
            return builder.ToString();
        }
    }
}

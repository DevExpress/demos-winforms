using DevExpress.Utils.Drawing;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using System.ComponentModel;

namespace DevExpress.HTML.Demos {
    public partial class Lab : TutorialControl {

        readonly string htmlStartText = string.Empty;
        readonly string cssStartText = string.Empty;
        public Lab() {
            InitializeComponent();
            htmlCodeViewer.Template = htmlContentControl.HtmlTemplate.Template;
            cssCodeViewer.Styles = htmlContentControl.HtmlTemplate.Styles;
            htmlStartText = htmlCodeViewer.Template;
            cssStartText = cssCodeViewer.Styles;
            htmlCodeViewer.ReadOnly = false;
            cssCodeViewer.ReadOnly = false;

            htmlCodeViewer.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            cssCodeViewer.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;

            htmlCodeViewer.CodeChanged += OnHtmlCodeViewerCodeChanged;
            cssCodeViewer.CodeChanged += OnCssCodeViewerCodeChanged;

            htmlContentControl.IsTemplateEditing = true;
            htmlContentControl.MouseMove += HtmlContentControl_MouseMove;
            htmlContentControl.MouseLeave += HtmlContentControl_MouseLeave;
            htmlContentControl.MouseDoubleClick += HtmlContentControl_MouseDoubleClick;
            htmlContentControl.PaintEx += HtmlContentControl_PaintEx;

            htmlCodeViewer.AllowCodeFolding = DefaultBoolean.True;
            htmlCodeViewer.ShowIndentGuides = DefaultBoolean.True;
            htmlCodeViewer.ShowLineNumbers = DefaultBoolean.True;

            cssCodeViewer.AllowCodeFolding = DefaultBoolean.True;
            cssCodeViewer.ShowIndentGuides = DefaultBoolean.True;
            cssCodeViewer.ShowLineNumbers = DefaultBoolean.True;

            delayTimer.Interval = 100;
            delayTimer.Tick += delayTimer_Tick;
        }
        public void FocusHtml() {
            htmlCodeViewer.Focus();
        }

        bool htmlChanged = false;
        bool cssChanged = false;

        void delayTimer_Tick(object sender, EventArgs e) {
            delayTimer.Stop();
            if(htmlChanged) htmlContentControl.HtmlTemplate.Template = htmlCodeViewer.Template;
            if(cssChanged) {
                htmlContentControl.HtmlTemplate.Styles = cssCodeViewer.Styles;
                customParser.Parse(cssCodeViewer.Styles);
                cssCodeViewer.SetErrors(customParser.Exceptions);
            }
            htmlChanged = false;
            cssChanged = false;
        }
        CssParser customParser = new CssParser();
        void RestartUpdateDelay() {
            delayTimer.Stop();
            delayTimer.Start();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Template {
            get { return htmlCodeViewer.Template; }
            set { htmlCodeViewer.Template = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Styles {
            get { return cssCodeViewer.Styles; }
            set { cssCodeViewer.Styles = value; }
        }
        void OnCssCodeViewerCodeChanged(object sender, EventArgs e) {
            cssChanged = true;
            RestartUpdateDelay();

            var classes = cssCodeViewer.GetClasses();
            htmlCodeViewer.SetAvailableStyles(classes.Keys);
        }
        void OnHtmlCodeViewerCodeChanged(object sender, EventArgs e) {
            htmlChanged = true;
            RestartUpdateDelay();
        }

        void HtmlContentControl_MouseDoubleClick(object sender, MouseEventArgs e) {
            var hitInfo = htmlContentControl.CalcHitInfo(e.Location);
            if(hitInfo != null && hitInfo.Element != null)
                htmlCodeViewer.NavigateToPosition(hitInfo.Element.PositionInCode);
        }
        void HtmlContentControl_MouseMove(object sender, MouseEventArgs e) {
            var hotInfo = htmlContentControl.CalcHitInfo(e.Location);
            if(string.Equals(hotInfo.Element?.Id, "container"))
                hotInfo = null;
            HotInfo = hotInfo;
        }
        void HtmlContentControl_MouseLeave(object sender, EventArgs e) {
            HotInfo = null;
        }

        DxHtmlHitInfo hotInfo;
        DxHtmlHitInfo HotInfo {
            get { return hotInfo; }
            set {
                if(hotInfo == value)
                    return;
                hotInfo = value;
                OnHotInfoChanged();
            }
        }

        void OnHotInfoChanged() {
            if(HotInfo != null && HotInfo.Element != null) {
                htmlContentControl.Invalidate();
                htmlCodeViewer.SetHotTrackPosition(HotInfo.Element.PositionInCode);
            } else {
                htmlCodeViewer.SetHotTrackPosition(-1);
            }
        }

        void HtmlContentControl_PaintEx(object sender, XtraGrid.PaintExEventArgs e) {
            if(HotInfo != null && HotInfo.Element != null) {
                if(HotInfo.IsContainer) {
                    for(int n = 0; n < HotInfo.ContainerElementBounds.Length; n++) {
                        SelectionPainter.Default.Draw(e.Cache, this.LookAndFeel, HotInfo.ContainerElementBounds[n]);
                    }
                } else {
                    SelectionPainter.Default.Draw(e.Cache, this.LookAndFeel, HotInfo.Bounds);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e) {
             htmlCodeViewer.Template = htmlStartText;
             cssCodeViewer.Styles = cssStartText;
        }
    }
    class CustomHtmlControl : HtmlContentControl {
        Exception exception;
        protected override void OnPaint(PaintEventArgs e) {
            if(DrawException(e))
                return;
            try {
                base.OnPaint(e);
            }
            catch(Exception ex) {
                exception = ex;
                DrawException(e);
            }
        }
        bool DrawException(PaintEventArgs e) {
            if(exception == null)
                return false;
            e.Graphics.Clear(Color.White);
            using(Pen pen = new Pen(Brushes.Red, 2)) {
                Rectangle clientRectangle = ClientRectangle;
                Rectangle rectangle = clientRectangle;
                rectangle.X++;
                rectangle.Y++;
                rectangle.Width--;
                rectangle.Height--;
                e.Graphics.DrawRectangle(pen, new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height));
                e.Graphics.DrawLine(pen, new Point(clientRectangle.Left, clientRectangle.Top), new Point(clientRectangle.Right, clientRectangle.Bottom));
                e.Graphics.DrawLine(pen, new Point(clientRectangle.Left, clientRectangle.Bottom), new Point(clientRectangle.Right, clientRectangle.Top));
            }
            e.Graphics.DrawString(exception.ToString(), Font, Brushes.Black, 0, 0);
            return true;
        }
    }
}

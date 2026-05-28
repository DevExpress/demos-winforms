using DevExpress.Utils.Design;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.XtraNavBar.Demos {
    public partial class Office365MailViewer : XtraUserControl {
        public Office365MailViewer() {
            InitializeComponent();
            this.statusPanelItem.Visibility = LayoutVisibility.Never;
            if(!DesignTimeTools.IsDesignMode) {
                LookAndFeel.ActiveLookAndFeel.StyleChanged += OnLookAndFeelStyleChanged;
                this.timer = CreateTimer();
            }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignTimeTools.IsDesignMode)
                UpdateChildControlsAppearances();
        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(!DesignTimeTools.IsDesignMode)
                    LookAndFeel.ActiveLookAndFeel.StyleChanged -= OnLookAndFeelStyleChanged;
                if(this.timer != null) {
                    this.timer.Stop();
                    this.timer.Dispose();
                    this.timer = null;
                }
            }
            base.Dispose(disposing);
        }
        void OnLookAndFeelStyleChanged(object sender, EventArgs e) {
            UpdateChildControlsAppearances();
        }
        protected void UpdateChildControlsAppearances() {
            richEdit.Appearance.Text.ForeColor = ForeColor;
            richEdit.Document.SetPageBackground(BackColor);
            mailStatusPanel1.SetColors(BackColor, ForeColor);
        }
        DevExpress.XtraNavBar.Demos.Message message;
        Timer timer;
        Timer CreateTimer() {
            Timer tmr = new Timer();
            tmr.Interval = 100;
            tmr.Tick += OnTimerTick;
            return tmr;
        }

        void OnTimerTick(object sender, EventArgs e) {
            this.timer.Stop();
            ShowMessageCore();
        }
        protected internal virtual void ShowMessage(DevExpress.XtraNavBar.Demos.Message message) {
            if(this.message == message)
                return;
            this.message = message;
            if(this.timer != null) {
                this.timer.Stop();
                this.timer.Start();
            }
        }
        void ShowMessageCore() {
            if(this.message == null)
                return;
            try {
                layoutControl1.BeginUpdate();
                this.labelSubject.Text = message.Subject;
                this.labelFrom.Text = message.From;
                this.labelDate.Text = message.Date.ToString();
                bool isHighPriority = message.Priority == 2;
                this.statusPanelItem.Visibility = isHighPriority ? LayoutVisibility.Always : LayoutVisibility.Never;
                Image photo = DevExpress.XtraNavBar.Demos.DataHelper.GetPhotoByEmail(message.Email);
                layoutPictureItem.Spacing = new XtraLayout.Utils.Padding(photo == null ? 12 : 0);

                if(photo == null)
                    pePhoto.Image = DevExpress.XtraNavBar.Demos.ImageHelper.CreateSenderImage(message.From, pePhoto.Size, pePhoto.LookAndFeel.ActiveLookAndFeel);
                else this.pePhoto.Image = photo;
                this.richEdit.MhtText = message.Text;
                UpdateChildControlsAppearances();
            }
            finally {
                layoutControl1.EndUpdate();
            }
        }
    }
    public class MailStatusPanel : Control {
        public MailStatusPanel() {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.label = new LabelControl();
            this.label.Text = Message;
            this.label.BackColor = Color.Transparent;
            this.label.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25f);
            Controls.Add(label);
            OnLayoutChanged();
        }
        LabelControl label;
        int horzPadding = 20;
        int panelSize = 5;
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);
            panelSize = (int)(factor.Width * panelSize);
            horzPadding = (int)(factor.Width * horzPadding);
            OnLayoutChanged();
        }
        const string Message = "This message was sent with high importance.";
        Color _backColor = Color.Empty;
        Color _foreColor = Color.Black;
        Color _lineColor = Color.Empty;
        public void SetColors(Color backColor, Color foreColor) {
            this._backColor = MixColors(backColor, foreColor, 0.9);
            this.label.ForeColor = MixColors(backColor, foreColor, 0.25);
            this._lineColor = MixColors(backColor, foreColor, 0.65);
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            OnLayoutChanged();
            Invalidate();
        }

        private void OnLayoutChanged() {
            this.label.Location = new Point(horzPadding, (Height - label.Height) / 2);
        }
        protected Color MixColors(Color backColor, Color foreColor, double value) {
            int r = (int)(value * backColor.R + foreColor.R * (1.0 - value));
            int g = (int)(value * backColor.G + foreColor.G * (1.0 - value));
            int b = (int)(value * backColor.B + foreColor.B * (1.0 - value));
            return Color.FromArgb(r, g, b);
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using(GraphicsCache cache = new GraphicsCache(e)) {
                e.Graphics.Clear(_backColor);
                cache.FillRectangle(_lineColor, new Rectangle(0, 0, panelSize, Height));
            }
        }
    }
}

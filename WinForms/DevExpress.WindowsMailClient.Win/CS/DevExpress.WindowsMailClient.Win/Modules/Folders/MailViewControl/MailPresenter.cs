using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Design;
using DevExpress.Utils.Drawing;
using DevExpress.WindowsMailClient.Win.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.WindowsMailClient.Win.Modules {
    public partial class MailPresenter : XtraUserControl {
        public MailPresenter() {
            InitializeComponent();
            this.statusPanelItem.Visibility = LayoutVisibility.Never;
            LookAndFeel.ActiveLookAndFeel.StyleChanged += OnLookAndFeelStyleChanged;
            this.timer = CreateTimer();
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
        Data.Message message;
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
        protected internal virtual void ShowMessage(Data.Message message) {
            if(this.message == message)
                return;
            this.message = message;
            if(this.timer != null) {
                this.timer.Stop();
                this.timer.Start();
            }
        }
        void ShowMessageCore() {
            if(this.message == null) {
                ResetPresenterUI();
                return;
            }
            this.transitionManager1.StartTransition(this);
            try {
                labelSubject.Visibility = LayoutVisibility.Always;
                labelFrom.Visibility = LayoutVisibility.Always;
                labelDate.Visibility = LayoutVisibility.Always;

                this.labelSubject.Text = message.Subject;
                this.labelFrom.Text = message.From;
                this.labelDate.Text = message.Date.ToString();
                bool isHighPriority = message.Priority == 2;
                this.statusPanelItem.Visibility = isHighPriority ? LayoutVisibility.Always : LayoutVisibility.Never;
                Image photo = MailClientDataModel.GetPhotoByEmail(message.Email);
                

                if(photo == null)
                    pePhoto.Image = MailClientDataModel.CreateSenderImage(message.From, pePhoto.Size, pePhoto.LookAndFeel.ActiveLookAndFeel);
                else this.pePhoto.Image = photo;
                this.richEdit.MhtText = message.Text;
                UpdateChildControlsAppearances();
            }
            finally {
                this.transitionManager1.EndTransition();
            }
        }
        void ResetPresenterUI() {
            this.labelSubject.Text = null;
            this.labelFrom.Text = null;
            this.labelDate.Text = null;
            labelSubject.Visibility = LayoutVisibility.Never;
            labelFrom.Visibility = LayoutVisibility.Never;
            labelDate.Visibility = LayoutVisibility.Never;
            this.statusPanelItem.Visibility = LayoutVisibility.Never;
            pePhoto.Image = null;
            this.richEdit.MhtText = null;
            UpdateChildControlsAppearances();
        }
    }
    public class MailStatusPanel : Control {
        public MailStatusPanel() {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.label = new LabelControl();
            this.label.Text = message;
            this.label.BackColor = Color.Transparent;
            this.label.Appearance.Font = new Font("Segoe UI", 8.25f);
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
        const string message = "This message was sent with high importance.";
        Color _backColor = Color.Empty;
        Color _foreColor = Color.Black;
        Color lineColor = Color.Empty;
        public void SetColors(Color backColor, Color foreColor) {
            this._backColor = MixColors(backColor, foreColor, 0.9);
            this.label.ForeColor = MixColors(backColor, foreColor, 0.25);
            this.lineColor = MixColors(backColor, foreColor, 0.65);
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            OnLayoutChanged();
            Invalidate();
        }

        void OnLayoutChanged() {
            this.label.Location = new Point(horzPadding, (Height - label.Height) / 2);
        }
        protected Color MixColors(Color backColor, Color foreColor, double value) {
            int r = (int)(value * (backColor.R - foreColor.R) + foreColor.R);
            int g = (int)(value * (backColor.G - foreColor.G) + foreColor.G);
            int b = (int)(value * (backColor.B - foreColor.B) + foreColor.B);
            return Color.FromArgb(r, g, b);
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using(GraphicsCache cache = new GraphicsCache(e)) {
                e.Graphics.Clear(_backColor);
                cache.FillRectangle(lineColor, new Rectangle(0, 0, panelSize, Height));
            }
        }
    }
}

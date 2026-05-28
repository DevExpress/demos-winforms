using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevExpress.XtraDiagram.Demos {
    public class OptionsPanelGroupControl : GroupControl {
        protected static readonly int OptionsPagePadding = 12;
        public OptionsPanelGroupControl() {
            Dock = DockStyle.Top;
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            Padding = ScalePadding(Padding, ScaleDPI.ScaleFactor.Width);
            UpdateGroupHeight();
        }
        protected virtual void UpdateGroupHeight() {
            Size = new Size(Size.Width, (int)(Size.Height * ScaleDPI.ScaleFactor.Width));
        }
        Padding ScalePadding(Padding padding, double value) {
            return new Padding((int)(padding.Left * value), (int)(padding.Top * value), (int)(padding.Right * value), (int)(padding.Bottom * value));
        }
    }
    public class OptionsPanelTitleGroupControl : OptionsPanelGroupControl {
        public OptionsPanelTitleGroupControl() {
            CaptionLocation = Locations.Top;
            GroupStyle = GroupStyle.Title;
            Padding = new Padding(OptionsPagePadding);
        }
        protected override void UpdateGroupHeight() {
            Size = new Size(Size.Width, ViewInfo.CaptionBounds.Height + GetClientHeight() + Padding.Vertical);
        }
        protected virtual int GetClientHeight() { return 0; }
    }
    public class GroupControlWithRadioGroup : OptionsPanelTitleGroupControl {
        public GroupControlWithRadioGroup() {
            RadioGroup = new RadioGroup();
            RadioGroup.Properties.Appearance.BackColor = Color.Transparent;
            RadioGroup.Properties.Appearance.Options.UseBackColor = true;
            RadioGroup.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            RadioGroup.Properties.Columns = 1;
            RadioGroup.AutoSize = true;
            RadioGroup.Dock = DockStyle.Top;
            RadioGroup.Properties.Padding = new Padding(0);
            RadioGroup.SizeChanged += RadioGroup_SizeChanged;
            Controls.Add(RadioGroup);
        }
        protected override int GetClientHeight() {
            return RadioGroup.Size.Height;
        }
        private void RadioGroup_SizeChanged(object sender, EventArgs e) {
            UpdateGroupHeight();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RadioGroup RadioGroup { get; private set; }
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
            if(RadioGroup != null)
                RadioGroup.SizeChanged -= RadioGroup_SizeChanged;
        }
    }
    public class GroupControlWithTrackBar : OptionsPanelTitleGroupControl {
        public GroupControlWithTrackBar() {
            trackBar = new OptionsPanelTrackBar();
            trackBar.Dock = DockStyle.Fill;
            Controls.Add(trackBar);
            trackBar.OnInitialized += TrackBar_OnInitialized;
        }
        public override void EndInit() {
            base.EndInit();
            trackBar.ApplySettings(TrackBarSettings, InvokeTrackBarValueChanged);
        }
        void InvokeTrackBarValueChanged(object sender, EventArgs e) {
            if(TrackBarValueChanged != null)
                TrackBarValueChanged(sender, e);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TrackBarSettings TrackBarSettings {
            get {
                if(trackBarSettings == null)
                    trackBarSettings = new TrackBarSettings();
                return trackBarSettings;
            }
        }
        public event EventHandler TrackBarValueChanged;
        protected override int GetClientHeight() {
            return (int)(trackBar.GetBestHeight() * trackBarInGroupHeightCoef);
        }
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
            if(trackBar != null)
                trackBar.OnInitialized -= TrackBar_OnInitialized;
        }
        static readonly double trackBarInGroupHeightCoef = 0.8;
        TrackBarSettings trackBarSettings;
        OptionsPanelTrackBar trackBar;
        void TrackBar_OnInitialized(object sender, EventArgs e) {
            UpdateGroupHeight();
        }
    }
    public class GroupControlWithTrackBars : OptionsPanelTitleGroupControl {
        public GroupControlWithTrackBars() {
            TrackBarsSettings = new List<TrackBarSettings>();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<TrackBarSettings> TrackBarsSettings { get; private set; }
        public override void EndInit() {
            base.EndInit();
            AddTrackBars(TrackBarsSettings);
        }
        public event EventHandler TrackBarsValueChanged;
        protected override int GetClientHeight() {
            return clientHeight;
        }
        int clientHeight;
        TrackBarControl[] trackBars;
        string trackBarCaptionSuffix = ":";
        void AddTrackBars(List<TrackBarSettings> trackBarsSettings) {
            LayoutControl layoutControl = new LayoutControl();
            LayoutControlGroup layoutControlGroup = new LayoutControlGroup();

            layoutControl.Root = layoutControlGroup;
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Margin = new Padding(0);

            layoutControlGroup.GroupBordersVisible = false;
            layoutControlGroup.Padding = new XtraLayout.Utils.Padding(0);

            trackBars = new TrackBarControl[trackBarsSettings.Count];
            int trackBarCaptionWidth = trackBarsSettings.Select(x => CalcTextWidth(x.Caption)).Max();

            for(int i = 0; i < trackBarsSettings.Count; i++) {
                var group = new LayoutGroupWithTrackBar(trackBarsSettings[i], trackBarCaptionWidth, trackBarCaptionSuffix, InvokeTrackBarValueChanged);
                trackBars[i] = group.TrackBar;
                layoutControlGroup.Items.AddRange(new[] { group });
            }
            int trackBarHeight = (layoutControlGroup.Items[0] as LayoutGroupWithTrackBar).TrackBarBestHeight;
            clientHeight = trackBarHeight * trackBarsSettings.Count;
            UpdateGroupHeight();
            layoutControl.Controls.AddRange(trackBars);
            Controls.Add(layoutControl);
        }
        int CalcTextWidth(string text) {
            LabelControl label = new LabelControl();
            label.Text = text + trackBarCaptionSuffix + " ";
            return label.CalcBestSize().Width;
        }
        void InvokeTrackBarValueChanged(object sender, EventArgs e) {
            if(TrackBarsValueChanged != null)
                TrackBarsValueChanged(sender, e);
        }
    }
    public class GroupControlWithSpinEdit : OptionsPanelTitleGroupControl {
        public GroupControlWithSpinEdit() {
            SpinEdit = new SpinEdit();
            SpinEdit.Dock = DockStyle.Fill;
            SpinEdit.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            UpdateGroupHeight();
            Controls.Add(SpinEdit);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SpinEdit SpinEdit { get; private set; }
        protected override int GetClientHeight() {
            return SpinEdit.Size.Height;
        }
    }
    public class TrackBarSettings {
        public TrackBarSettings() { }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Caption { get; set; }
        public Binding Binding { get; set; }
        public int SmallChange { get; set; }
        public int LargeChange { get; set; }
    }
    class OptionsPanelTrackBar : TrackBarControl {
        public OptionsPanelTrackBar() {
            this.Properties.ShowValueToolTip = true;
            this.Properties.ShowLabels = true;
            this.Margin = new Padding(0);
        }
        public int GetBestHeight() {
            return (int)(CalcMinHeight() * bestHeightCoef);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MinValue {
            get { return min.HasValue ? min.Value : 0; }
            set {
                min = value;
                if(max.HasValue)
                    Initialize();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MaxValue {
            get { return max.HasValue ? max.Value : 0; }
            set {
                max = value;
                if(min.HasValue)
                    Initialize();
            }
        }
        public event EventHandler OnInitialized;
        public void ApplySettings(TrackBarSettings settings, EventHandler valueChanged) {
            MinValue = settings.Min;
            MaxValue = settings.Max;
            DataBindings.Add(settings.Binding);
            Properties.SmallChange = settings.SmallChange;
            Properties.LargeChange = settings.LargeChange;
            ValueChanged += valueChanged;
        }
        int? min, max;
        void Initialize() {
            Properties.Maximum = max.Value;
            Properties.Minimum = min.Value;
            Properties.TickFrequency = (max.Value - min.Value) / 2;
            Properties.Labels.AddRange(new[] { min.Value, (min.Value + max.Value) / 2, max.Value }.Select(x => new XtraEditors.Repository.TrackBarLabel(x.ToString(), x)).ToArray());
            if(OnInitialized != null)
                OnInitialized(this, new EventArgs());
        }
        static readonly double bestHeightCoef = 0.76;
    }
    class LayoutGroupWithTrackBar : LayoutControlGroup {
        public LayoutGroupWithTrackBar(TrackBarSettings settings, int captionWidth, string captionSuffix, EventHandler trackBarValueChanged) {
            this.GroupBordersVisible = false;
            this.Padding = new XtraLayout.Utils.Padding(0);

            LabelControl label = new LabelControl();
            label.Text = settings.Caption + captionSuffix;
            label.MinimumSize = new Size(captionWidth, 0);

            trackBar = new OptionsPanelTrackBar();
            trackBar.ApplySettings(settings, trackBarValueChanged);
            TrackBarBestHeight = trackBar.GetBestHeight();
            trackBar.MaximumSize = new Size(int.MaxValue, TrackBarBestHeight);

            LayoutControlItem labelLayoutItem = new LayoutControlItem();
            labelLayoutItem.Control = label;
            labelLayoutItem.TextVisible = false;
            labelLayoutItem.Padding = new XtraLayout.Utils.Padding(0, 0, 2, 0);

            LayoutControlItem trackLayoutBarItem = new LayoutControlItem();
            trackLayoutBarItem.Control = trackBar;
            trackLayoutBarItem.SizeConstraintsType = SizeConstraintsType.Custom;
            trackLayoutBarItem.MaxSize = new Size(int.MaxValue, TrackBarBestHeight);
            trackLayoutBarItem.MinSize = new Size(0, TrackBarBestHeight);
            trackLayoutBarItem.TextVisible = false;
            trackLayoutBarItem.Padding = new XtraLayout.Utils.Padding(0);
            trackLayoutBarItem.Location = new Point(captionWidth, 0);

            this.Items.AddRange(new[] { labelLayoutItem, trackLayoutBarItem });
        }
        OptionsPanelTrackBar trackBar;
        public TrackBarControl TrackBar { get { return trackBar; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TrackBarBestHeight { get; private set; }
    }
}

using System;
using System.Data;
using System.Drawing;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleRangeControlClients : TutorialControl {
        private RangeControl rangeControl1;
        private DateTimeRangeControlClient dateTimeRangeControlClient1;
        const string seriesColumn = "Series";

        public ModuleRangeControlClients() {
            InitializeComponent();
            TutorialInfo.AboutFile = null;
            TutorialInfo.Description = "";
            TutorialInfo.TutorialName = "Chart Range Control Clients Tutorial";
        }
        //protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleRangeControlClients" }; } }
        //protected override string WhatsThisXMLFileName { get { return "rangeControlClients"; } }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
        }

        private void InitializeComponent() {
            DevExpress.XtraEditors.DateTimeRangeClientRuler dateTimeRangeClientRuler1 = new DevExpress.XtraEditors.DateTimeRangeClientRuler();
            DevExpress.XtraEditors.DateTimeRangeClientRuler dateTimeRangeClientRuler2 = new DevExpress.XtraEditors.DateTimeRangeClientRuler();
            DevExpress.XtraEditors.DateTimeRangeClientRuler dateTimeRangeClientRuler3 = new DevExpress.XtraEditors.DateTimeRangeClientRuler();
            DevExpress.XtraEditors.DateTimeRangeClientRuler dateTimeRangeClientRuler4 = new DevExpress.XtraEditors.DateTimeRangeClientRuler();
            this.rangeControl1 = new DevExpress.XtraEditors.RangeControl();
            this.dateTimeRangeControlClient1 = new DevExpress.XtraEditors.DateTimeRangeControlClient();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rangeControl2 = new DevExpress.XtraEditors.RangeControl();
            this.dateTimeRangeControlClient2 = new DevExpress.XtraEditors.DateTimeRangeControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // rangeControl1
            // 
            this.rangeControl1.Client = this.dateTimeRangeControlClient1;
            this.rangeControl1.ContentPadding = new System.Windows.Forms.Padding(16);
            this.rangeControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangeControl1.FadeUnselectedArea = false;
            this.rangeControl1.Location = new System.Drawing.Point(17, 17);
            this.rangeControl1.Name = "rangeControl1";
            this.rangeControl1.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.Flag;
            this.rangeControl1.Size = new System.Drawing.Size(896, 150);
            this.rangeControl1.TabIndex = 0;
            this.rangeControl1.Text = "rangeControl1";
            // 
            // dateTimeRangeControlClient1
            // 
            this.dateTimeRangeControlClient1.FlagFormatString = "{0:d}";
            this.dateTimeRangeControlClient1.Maximum = new System.DateTime(2021, 1, 1, 10, 22, 25, 0);
            this.dateTimeRangeControlClient1.Minimum = new System.DateTime(2019, 1, 1, 10, 22, 25, 0);
            this.dateTimeRangeControlClient1.RangeControl = this.rangeControl1;
            dateTimeRangeClientRuler1.MainRuler = true;
            dateTimeRangeClientRuler1.MinGridDelta = 25;
            dateTimeRangeClientRuler1.ShowInContentArea = true;
            dateTimeRangeClientRuler2.AllowAdaptiveTicks = true;
            dateTimeRangeClientRuler2.DrawSeparator = DevExpress.Utils.DefaultBoolean.False;
            dateTimeRangeClientRuler2.DrawTicks = DevExpress.Utils.DefaultBoolean.False;
            dateTimeRangeClientRuler2.LabelAlignment = DevExpress.XtraEditors.Alignment.Near;
            dateTimeRangeClientRuler2.LabelPadding = new System.Windows.Forms.Padding(2, 8, 8, 8);
            dateTimeRangeClientRuler2.LabelVerticalAlignment = DevExpress.XtraEditors.DateTimeRangeClientLabelVerticalAlignment.Bottom;
            dateTimeRangeClientRuler2.ShowInContentArea = true;
            dateTimeRangeClientRuler2.Type = DevExpress.XtraEditors.DateTimeRangeClientMeasureType.Month;
            this.dateTimeRangeControlClient1.Rulers.Add(dateTimeRangeClientRuler1);
            this.dateTimeRangeControlClient1.Rulers.Add(dateTimeRangeClientRuler2);
            this.dateTimeRangeControlClient1.CustomDrawLabel += new DevExpress.XtraEditors.DateTimeRangeClientCustomDrawLabelEventHandler(this.dateTimeRangeControlClient1_CustomDrawLabel);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(17, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 34);
            this.panel1.TabIndex = 1;
            // 
            // rangeControl2
            // 
            this.rangeControl2.Client = this.dateTimeRangeControlClient2;
            this.rangeControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangeControl2.Location = new System.Drawing.Point(17, 201);
            this.rangeControl2.Name = "rangeControl2";
            this.rangeControl2.Size = new System.Drawing.Size(896, 100);
            this.rangeControl2.TabIndex = 2;
            this.rangeControl2.Text = "rangeControl2";
            // 
            // dateTimeRangeControlClient2
            // 
            this.dateTimeRangeControlClient2.Maximum = new System.DateTime(2021, 1, 1, 11, 2, 39, 0);
            this.dateTimeRangeControlClient2.Minimum = new System.DateTime(2019, 1, 1, 11, 2, 31, 0);
            this.dateTimeRangeControlClient2.RangeControl = this.rangeControl2;
            dateTimeRangeClientRuler4.Type = DevExpress.XtraEditors.DateTimeRangeClientMeasureType.Month;
            this.dateTimeRangeControlClient2.Rulers.Add(dateTimeRangeClientRuler3);
            this.dateTimeRangeControlClient2.Rulers.Add(dateTimeRangeClientRuler4);
            // 
            // ModuleRangeControlClients
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rangeControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rangeControl1);
            this.Name = "ModuleRangeControlClients";
            this.Padding = new System.Windows.Forms.Padding(17);
            this.Size = new System.Drawing.Size(930, 364);
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl2)).EndInit();
            this.ResumeLayout(false);

        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            this.rangeControl1.SelectedRange = new RangeControlRange(new DateTime(2019, 8, 1), new DateTime(2020, 4, 1));
            this.rangeControl2.SelectedRange = new RangeControlRange(new DateTime(2019, 8, 1), new DateTime(2020, 4, 1));
        }

        private void dateTimeRangeControlClient1_CustomDrawLabel(object sender, DateTimeRangeClientCustomDrawLabelEventArgs e) {
            if(e.Ruler.Type == DateTimeRangeClientMeasureType.Month && 
                (e.PrevValue == null || e.PrevValue.Value.Year != e.Value.Year)) {
                e.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
                Size sz = e.Cache.CalcTextSize(e.Text, e.Appearance.Font).ToSize();
                e.Bounds = new System.Drawing.Rectangle(e.Bounds.Location, sz);
            }
        }
    }
}

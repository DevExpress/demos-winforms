using System;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    public partial class StartupMDIDemos : TutorialControl {
        public StartupMDIDemos() {
            InitializeComponent();
            Sample = null;
        }
        Form fSample = null;
        Form Sample {
            get { return fSample; }
            set {
                fSample = value;
                sbStart.Enabled = fSample == null;
                sbClose.Enabled = fSample != null;
            }
        }
        protected virtual Form CreateSample() {
            return null;
        }
        void sbStart_Click(object sender, System.EventArgs e) {
            Sample = CreateSample();
            if(Sample == null) 
                return;
            Sample.Closed += new EventHandler(Sample_Close);
            Sample.Show();
        }
        void Sample_Close(object sender, EventArgs e) {
            Sample.Closed -= new EventHandler(Sample_Close);
            Sample.Dispose();
            Sample = null;
        }
        void CloseSample() {
            if(Sample != null) Sample.Close();
        }
        void sbClose_Click(object sender, System.EventArgs e) {
            CloseSample();
        }
        protected override void DoVisibleChanged(bool visible) {
            base.DoVisibleChanged(visible);
            CloseSample();
        }
    }
    public class TabbedMDIStart : StartupMDIDemos {
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            UpdateCenteredControls(this);
        }
        protected override Form CreateSample() {
            return new frmTabbedMDI();
        }
        protected override bool? AllowBorderRounding {
            get { return true; }
        }
    }
}

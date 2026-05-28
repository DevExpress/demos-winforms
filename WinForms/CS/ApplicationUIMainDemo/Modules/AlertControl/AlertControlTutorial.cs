using System;
using System.Drawing;

namespace DevExpress.ApplicationUI.Demos {
    public partial class AlertControlTutorial : TutorialControl {
        public AlertControlTutorial() {
            InitializeComponent();
            alertInfoProperties1.InitValues("Andrew Miller", "Email Attachments. Is it possible to add multiple attachments? I haven't found a way to do this.",
                "<b>Jeffrey <i>W</i>  McClain", 
                "<size=8><b>Email System. </b>What <size=12>library<size=8> are we going to use?",
                "<u><size=8><b>Email System. </b><color=Blue>What <size=12>library<size=8> are we going to use?"); 
            alertControlProperties1.InitValues(alertControl1);
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            UpdateCenteredControls(this);
        }
        protected override void OnScaleControl() {
            base.OnScaleControl();
            ceWidth.Value = ScaleHelper.ScaleHorizontal((int)ceWidth.Value);
            ceHeight.Value = ScaleHelper.ScaleHorizontal((int)ceHeight.Value);
        }
        //<button1>
        private void button1_Click(object sender, EventArgs e) {
            //<groupControl2>
            alertControl1.Show(
                this.FindForm(), 
                alertInfoProperties1.Caption, 
                alertInfoProperties1.TextInfo, 
                alertInfoProperties1.HotTrackedText,
                alertInfoProperties1.Image, null, alertControlProperties1.AutoCloseFormOnClick);
            //</groupControl2>
            UpdatePostponedFormCount();
        }
        void UpdatePostponedFormCount() {
            sePostponedFormCount.Value = alertControl1.PostponedFormList.Count;
        }
        //</button1>

        void alertControlProperties1_AllowHtmlTextChanged(object sender, EventArgs e) {
            alertInfoProperties1.UpdateInfo(alertControl1.AllowHtmlText);
        }

        //<ceHeight>
        //<ceWidth>
        void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e) {
            e.AlertForm.Size = new Size(Convert.ToInt32(ceWidth.Value), 
                alertControl1.AutoHeight ? 100 : Convert.ToInt32(ceHeight.Value));
        }
        //</ceWidth>
        //</ceHeight>
        void alertControl1_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e) {
            UpdatePostponedFormCount();
        }
        protected override bool? AllowBorderRounding { get { return true; } }
    }
}

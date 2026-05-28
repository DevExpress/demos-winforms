using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraWizard;

namespace DevExpress.XtraWizard.Demos {
    public partial class frmMain : XtraForm {
        Timer progressTimer = null;
        Int32 ltTimer = 0;
        bool finish = false;

        public frmMain() : this(true, WizardStyle.Wizard97) { 
        }

        public frmMain(bool allowAnimation, WizardStyle style) {
            InitializeComponent();
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraWizard.Demos.AppIcon.ico", typeof(frmMain).Assembly);
            wizardControl1.AllowTransitionAnimation = allowAnimation;
            wizardControl1.WizardStyle = style;
            memoEdit1.Text = Info.LongText;
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e) {
            if(e.Page == wpLongText) {
                e.Page.AllowNext = ceLongText.Checked;
                CreateLongTextTimer();
            }
            if(e.PrevPage == wpQuestion && e.Direction == Direction.Forward) 
                if(ceYesAnswer.Checked) e.Page = wpProgress;
            if(e.PrevPage == wpProgress && e.Direction == Direction.Backward)
                e.Page = wpQuestion;
            if(e.Page == wpProgress)
                CreateProgressTimer();
            if(e.PrevPage == wpProgress) {
                progressTimer.Tick -= new EventHandler(progressTimer_Tick);
                progressTimer.Dispose();
                progressTimer = null;
                progressBarControl1.Position = 0;
                lbProgress.Visible = false;
            }
            if(e.Page == completionWizardPage1) {
                if(teRobotTest.Text.ToLower() == "devexpress123") {
                    completionWizardPage1.Text = "Congratulations – You've Passed All the Way Through!";
                    completionWizardPage1.FinishText = lbcPlay.SelectedIndex > -1 ?
                        string.Format("Thank you for completing this XtraWizard feature tour! We can now conclusively state that you are very patient, definitely not a robot, a quick reader, and a fan of {0} just like we are.", GetArtistName(lbcPlay.SelectedValue)) : 
                        "Thank you for completing this XtraWizard feature tour! We can now conclusively state that you are very patient, a quick reader and definitely not a robot.";
                }
                else {
                    completionWizardPage1.Text = "Sorry, No Robots Allowed";
                    completionWizardPage1.FinishText = "We are very sorry, but no robots are allowed to continue this wizard. Please click Finish to exit.";
                }
            }
        }

        string GetArtistName(object value) {
            if(value == null) return string.Empty;
            return value.ToString().Substring(0, value.ToString().IndexOf("-") - 1);
        }

        private void wizardControl1_SelectedPageChanged(object sender, WizardPageChangedEventArgs e) {
            if(e.Page == wpRobotTest)
                teRobotTest.Focus();
            if(e.Page == wpNoAnswer)
                lbcCancel.Top = e.Page.Height - 29;
        }

        Int32 GetLongTextTime() {
            return (System.Environment.TickCount - ltTimer) / 1000;
        }

        void CreateLongTextTimer() {
            if(ltTimer == 0)
                ltTimer = System.Environment.TickCount;
        }

        void CreateProgressTimer() {
            if(progressTimer != null) return;
            wpProgress.AllowNext = false;
            progressTimer = new Timer();
            progressTimer.Interval = 40;
            progressTimer.Tick += new EventHandler(progressTimer_Tick);
            progressTimer.Start();
        }

        void progressTimer_Tick(object sender, EventArgs e) {
            progressBarControl1.Position++;
            if(progressBarControl1.Position >= 100) {
                progressTimer.Stop();
                lbProgress.Visible = true;
                wpProgress.AllowNext = true;
            }
        }

        private void ceLongText_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            wpLongText.AllowNext = ce.Checked;
        }

        private void wizardControl1_NextClick(object sender, WizardCommandButtonClickEventArgs e) {
            if(e.Page == wpLongText && GetLongTextTime() < 60) {
                if(XtraMessageBox.Show(this, string.Format("Are you sure that {0} seconds was enough time for you to read all that text?", GetLongTextTime()),
                    "Long Text Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) 
                    ltTimer = -1;
                else 
                    e.Handled = true;
            }
        }

        private void sbPlay_Click(object sender, EventArgs e) {
            XtraMessageBox.Show(this, string.Format("Sorry, but we don’t have that song in our library...\r\nBut we agree with you that \"{0}\" is an excellent choice.", lbcPlay.SelectedValue), 
                "XtraWizard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wizardControl1.SelectedPage = wpLongText;
        }

        private void lbcPlay_SelectedIndexChanged(object sender, EventArgs e) {
            sbPlay.Enabled = lbcPlay.SelectedIndex > -1; 
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e) {
            finish = true;
            this.Close();
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e) {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if(finish) return;
            if(XtraMessageBox.Show(this, "Do you want to exit the XtraWizard feature tour?", "XtraWizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}

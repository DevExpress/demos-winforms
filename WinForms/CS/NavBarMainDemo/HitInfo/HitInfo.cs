using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraNavBar.Demos {
    /// <summary>
    /// Summary description for HitInfo.
    /// </summary>
    public partial class HitInfo : TutorialControl {
        public HitInfo() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            ShowHitInfo(null, Point.Empty);
            lbClick.Text = "None";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void ShowHitInfo(DevExpress.XtraNavBar.NavBarHitInfo hi, Point p) {
            string s = "None";
            if(hi == null)
                lbHitTest.Text = lbGroup.Text = lbLink.Text = s;
            else {
                lbHitTest.Text = hi.HitTest.ToString();
                lbGroup.Text = hi.Group != null ? hi.Group.Caption : s;
                lbLink.Text = hi.Link != null ? hi.Link.Caption : s;
            }
            if(!p.Equals(Point.Empty))
                lbPoint.Text = "X = " + p.X.ToString() + "; Y = " + p.Y.ToString();
            else lbPoint.Text = "";
        }

        private void navBarControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            Point p = new Point(e.X, e.Y);
            ShowHitInfo(navBarControl1.CalcHitInfo(p), p);
        }

        private void navBarControl1_MouseLeave(object sender, System.EventArgs e) {
            ShowHitInfo(null, Point.Empty);
        }

        private void navBarControl1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            lbClick.Text = "Group (" + e.Link.Group.Caption + ")\r\nItem (" + e.Link.Caption + ")";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace DevExpress.XtraLayout.Demos {
    public partial class TechnoLayout : TutorialControl {
        public TechnoLayout() {
            InitializeComponent();
            ((ILayoutControl)facesUserControl1.layoutControl1).EnableCustomizationMode = true;
            rgFlowDirection.Properties.Items.AddEnum(typeof(FlowDirection));
            rgFlowDirection.SelectedIndex = 0;
        }
        protected override string WhatsThisXMLFileName { get { return "TechnoLayout"; } }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "TechnoLayout" }; } }
        //<ztbcSize>
        void ztbcSize_EditValueChanged(object sender, EventArgs e) {
            facesUserControl1.layoutControl1.BeginUpdate();
            try {
                foreach(LayoutControlItem item in facesUserControl1.lcgFaces.Items)
                    item.Size = new Size((int)Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor), (int)Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor));
            } 
            finally {
                facesUserControl1.layoutControl1.EndUpdate();
            }
        }
        //</ztbcSize>
        //<ztbcSpacing>
        void ztbcSpacing_EditValueChanged(object sender, EventArgs e) {
            facesUserControl1.layoutControl1.BeginUpdate();
            try {
                foreach(LayoutControlItem item in facesUserControl1.lcgFaces.Items)
                    item.Spacing = new Utils.Padding((int)Math.Round(ztbcSpacing.Value * Skins.DpiProvider.Default.DpiScaleFactor));
            } finally {
                facesUserControl1.layoutControl1.EndUpdate();
            }
        }
        //</ztbcSpacing>

        void cheCustomizationMode_CheckedChanged(object sender, EventArgs e) {
            ((ILayoutControl)facesUserControl1.layoutControl1).EnableCustomizationMode = cheCustomizationMode.Checked;
        }
        //<rgFlowDirection>
        void rgFlowDirection_SelectedIndexChanged(object sender, EventArgs e) {
            facesUserControl1.lcgFaces.FlowDirection = (FlowDirection)rgFlowDirection.Properties.Items[rgFlowDirection.SelectedIndex].Value;
        }
        //</rgFlowDirection>
    }
}

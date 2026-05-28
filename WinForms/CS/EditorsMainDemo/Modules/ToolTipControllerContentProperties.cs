using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace EditorsTutorials.Modules {
    public partial class ToolTipControllerContentProperties : XtraUserControl {
        public ToolTipControllerContentProperties() {
            InitializeComponent();
        }

        ToolTipController controller = null;
        Control control = null;
        bool isManual = false;

        public void Init(ToolTipController controller, Control control, string toolTipText, string titleText, bool isManual) {
            this.isManual = isManual;
            this.controller = controller;
            this.control = control;
            InitComboBoxes();
            meToolTipText.Text = toolTipText;
            teTitleText.Text = titleText;
            if(isManual)
                icbIconSize.EditValue = ToolTipIconSize.Large;
            else icbIconSize.EditValue = controller.IconSize;
            controller.ImageList = svgImageCollection1;
        }

        void InitComboBoxes() {
            icbIconType.Properties.Items.AddEnum(typeof(ToolTipIconType));
            icbIconType.SelectedIndex = isManual ? icbIconType.Properties.Items.Count - 1 : 3;
            icbIconSize.Properties.Items.AddEnum(typeof(ToolTipIconSize));
        }

        void meToolTipText_TextChanged(object sender, System.EventArgs e) {
            if(isManual || controller == null) return;
            controller.SetToolTip(control, meToolTipText.Text);
        }

        void teTitleText_TextChanged(object sender, System.EventArgs e) {
            if(isManual || controller == null) return;
            controller.SetTitle(control, teTitleText.Text);
        }

        void icbIconType_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(isManual || controller == null) return;
            controller.SetToolTipIconType(control, (ToolTipIconType)icbIconType.EditValue);
        }

        void icbIconSize_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(isManual || controller == null) return;
            controller.IconSize = (ToolTipIconSize)icbIconSize.EditValue;
        }

        void icbCustomImage_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(isManual || controller == null) return;
            controller.ImageIndex = icbCustomImage.SelectedIndex - 1;
        }

        public ToolTipControllerShowEventArgs CreateShowArgs() {
            ToolTipControllerShowEventArgs args = controller.CreateShowArgs();
            args.ToolTip = meToolTipText.Text;
            args.Title = teTitleText.Text;
            args.IconType = (ToolTipIconType)icbIconType.EditValue;
            args.IconSize = (ToolTipIconSize)icbIconSize.EditValue;
            args.ImageIndex = icbCustomImage.SelectedIndex - 1;
            return args;
        }
    }
}

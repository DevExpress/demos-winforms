using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.ApplicationUI.Demos {
    public partial class RadialMenu : TutorialControlBase {
        public RadialMenu() {
            AutoMergeRibbon = true;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            Initialize();
        }
        void Initialize() {
            iSetRadialMenuRadius.EditValue = radialMenu1.MenuRadius;
            ((RepositoryItemSpinEdit)iSetRadialMenuInnerRadius.Edit).MaxValue = 120;
            iSetBackColor.EditValue = radialMenu1.BackColor;
            iSetBorderColor.EditValue = radialMenu1.BorderColor;
            iSetMenuColor.EditValue = radialMenu1.MenuColor;
            iSetMenuHoverColor.EditValue = radialMenu1.SubMenuHoverColor;
            iCloseOnOuterMouseClick.EditValue = radialMenu1.CloseOnOuterMouseClick;
            iCollapseOnOuterMouseClick.EditValue = radialMenu1.CollapseOnOuterMouseClick;
            iSetRadialMenuInnerRadius.EditValue = radialMenu1.InnerRadius;
        }
        #region Handlers
        void labelControl1_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right)
                radialMenu1.ShowPopup(Cursor.Position);
        }
        void iSetMenuColor_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.MenuColor = (Color)iSetMenuColor.EditValue;
        }
        void iSetMenuHoverColor_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.SubMenuHoverColor = (Color)iSetMenuHoverColor.EditValue;
        }
        void iSetBackColor_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.BackColor = (Color)iSetBackColor.EditValue;
        }
        void iSetBorderColor_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.BorderColor = (Color)iSetBorderColor.EditValue;
        }
        void iSetRadialMenuRadius_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.MenuRadius = Convert.ToInt32(iSetRadialMenuRadius.EditValue);
        }
        void iSetRadialMenuInnerRadius_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.InnerRadius = Convert.ToInt32(iSetRadialMenuInnerRadius.EditValue);
        }
        void iCloseOnOuterMouseClick_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.CloseOnOuterMouseClick = (bool)iCloseOnOuterMouseClick.EditValue;
        }
        void iCollapseOnOuterMouseClick_EditValueChanged(object sender, EventArgs e) {
            radialMenu1.CollapseOnOuterMouseClick = (bool)iCollapseOnOuterMouseClick.EditValue;
        }
        #endregion
    }
}

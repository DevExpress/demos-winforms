using System;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers;

namespace DevExpress.HTML.Demos {
    public partial class ComboBoxModule : TutorialControlBase {
        public ComboBoxModule() {
            InitializeComponent();
            comboBoxTemplateViewer1.Fill(comboBoxEdit1);
            comboBoxEdit1.Properties.Items.AddRange(DataHelper.Employees);
            comboBoxEdit1.SelectedIndex = 2;
        }
        protected override int TakeScreenDelay => 300;
        protected override void DoShow() {
            base.DoShow();
            BeginInvoke(new Action(() => {
                if(!comboBoxEdit1.IsPopupOpen)
                    comboBoxEdit1.ShowPopup();
            }));
        }
        protected override void DoHide() {
            base.DoHide();
            comboBoxEdit1.ClosePopup();
        }
    }
}

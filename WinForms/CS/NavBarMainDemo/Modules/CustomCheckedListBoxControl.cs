using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NavBarMainDemo.Modules {
    public class CustomCheckedListBoxControl : CheckedListBoxControl {
        public CustomCheckedListBoxControl() : base() {
            LookAndFeel.StyleChanged += OnLookAndFeelStyleChanged;
        }
        protected void OnLookAndFeelStyleChanged(object sender, EventArgs e) {
            UpdateAppearance();
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            UpdateAppearance();
        }
        protected void UpdateAppearance() {
            if(Parent != null) {
                ForeColor = Parent.ForeColor == Color.Transparent ? SystemColors.ControlText : Parent.ForeColor;
                BackColor = Parent.BackColor == Color.Transparent ? SystemColors.Control : Parent.BackColor;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraLayout.Demos.Controls {
    interface ICustomControl {
    }


    class CustomSimpleButton : SimpleButton, ICustomControl {
        public CustomSimpleButton() {
            Text = "SimpleButton";
            Name = "CustomSimpleButton";
        }
    }

    class CustomLabelControl : LabelControl, ICustomControl {
        public CustomLabelControl() {
            SetStyle(ControlStyles.Selectable, true);
            Text = "LabelControl";
            Name = "CustomLabelControl";
        }
    }

    class CustomCheckEdit : CheckEdit, ICustomControl {
        public CustomCheckEdit() {
            Text = "CheckEdit";
            Name = "CustomCheckEdit";
        }
    }

    class CustomTextEdit : TextEdit, ICustomControl {
        public CustomTextEdit() {
            Text = "TextEdit";
            Name = "CustomTextEdit";
        }
    }


    static class CustomControlFactory {
        public static Control CreateControl(Type controlType) {
            if(controlType == typeof(SimpleButton)) return new CustomSimpleButton();
            else if(controlType == typeof(CheckEdit)) return new CustomCheckEdit();
            else if(controlType == typeof(TextEdit)) return new CustomTextEdit();
            else if(controlType == typeof(LabelControl)) return new CustomLabelControl();
            else throw new ArgumentException("controlType");
        }
    }
}

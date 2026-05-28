using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos {
    public partial class Css : CodeTutorialControl {
        public Css() {
            InitializeComponent();
        }
        protected override void CustomizeCodeExample(CodeExample codeExample) {
            base.CustomizeCodeExample(codeExample);
            codeExample.ShowExampleCode = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucDraft : BaseModule {
        public override string ModuleCaption { get { return "User management"; } }
        public override bool AllowWaitDialog { get { return false; } }
        public ucDraft() {
            InitializeComponent();
        }
    }
}

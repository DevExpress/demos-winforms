using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace DevExpress.AI.Demos.Modules.SemanticSearch {
    public partial class SemanticSearchWaitForm : WaitForm {
        public SemanticSearchWaitForm() {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption) {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description) {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }

        #endregion
    }
}

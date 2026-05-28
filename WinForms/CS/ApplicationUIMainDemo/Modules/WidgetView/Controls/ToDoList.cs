using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ToDoList : XtraEditors.XtraUserControl {
        static Font RegularFont = new System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        static Font StrikeoutFont = new System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
        public ToDoList() {
            InitializeComponent();
        }
        void OnCheckedChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (sender as CheckEdit);
            if(checkEdit.Checked)
                checkEdit.Font = StrikeoutFont;
            else
                checkEdit.Font = RegularFont;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeList.Demos.Options {
    public partial class ucDefault : XtraUserControl {
        TreeList treeListCore;
        int isInitializingCore = 0;
        public ucDefault() {
            InitializeComponent();
        }
        public void InitData(TreeList treeList) {
            isInitializingCore++;
            this.treeListCore = treeList;
            InitDataCore();
            isInitializingCore--;
        }
        protected TreeList TreeList {
            get { return treeListCore; }
        }
        protected virtual void InitDataCore() { }
        protected bool IsInitializing {
            get { return isInitializingCore > 0; }
        }
    }
}

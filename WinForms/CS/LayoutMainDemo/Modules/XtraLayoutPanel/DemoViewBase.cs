using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraLayout.Demos.Controls;

namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel {
    public class XtraLayoutPanelDemoViewBase : XtraForm {
        static object controlSelectRequestEventKey = new object();
        static object controlDeleteRequestEventKey = new object();

        public XtraLayoutPanelDemoViewBase() {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if(e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
            base.OnFormClosing(e);
        }
        public void Initialize() {
            InitializeControls();
            LayoutPanel.ForEachChildControlIncludeItself(x => {
                if(x is MaskBox) return;
                x.Click += OnChildControlMouseClick;
            });
            LayoutPanel.ControlAdded += OnChildControlAdded;
            LayoutPanel.ControlRemoved += OnChildControlRemoved;
        }
        public virtual void ResetLayout() {
            LayoutPanel.SuspendLayout();
            try {
                Control.ControlCollection controlsCollection = LayoutPanel.Controls;
                for(int n = controlsCollection.Count - 1; n >= 0; n--) {
                    if(controlsCollection[n] is ICustomControl) controlsCollection[n].Dispose();
                }
            }
            finally {
                LayoutPanel.ResumeLayout();
            }
        }
        protected virtual void InitializeControls() {
        }
        protected override bool ShouldCheckDpiScaleFactorBeforeFormShown {
            get {
                return false;
            }
        }

        static readonly IntPtr DeleteKeyWParam = new IntPtr(0x2E);
        static readonly IntPtr SysCommandMaximizeWParam = new IntPtr(0xF032);

        protected override bool ProcessKeyPreview(ref Message msg) {
            const int WM_KEYUP = 257;
            if(msg.Msg == WM_KEYUP && msg.WParam == DeleteKeyWParam) {
                OnControlDeleteRequest(new ControlEventArgs(null));
            }
            return base.ProcessKeyPreview(ref msg);
        }
        protected override void WndProc(ref Message msg) {
            const int WM_SYSCOMMAND = 274;
            if(msg.Msg == WM_SYSCOMMAND) {
                if(msg.WParam == SysCommandMaximizeWParam) return;
            }
            base.WndProc(ref msg);
        }

        #region Event Handlers

        void OnChildControlAdded(object sender, ControlEventArgs e) {
            e.Control.Click += OnChildControlMouseClick;
        }
        void OnChildControlRemoved(object sender, ControlEventArgs e) {
            e.Control.Click -= OnChildControlMouseClick;
        }

        #endregion

        void OnChildControlMouseClick(object sender, EventArgs e) {
            MouseEventArgs ee = e as MouseEventArgs;
            if(ee != null && ee.Button != MouseButtons.Left) return;
            OnControlSelectRequest(new ControlEventArgs((Control)sender));
        }

        #region Events

        public event EventHandler<ControlEventArgs> ControlSelectRequest {
            add { Events.AddHandler(controlSelectRequestEventKey, value); }
            remove { Events.RemoveHandler(controlSelectRequestEventKey, value); }
        }
        public event EventHandler<ControlEventArgs> ControlDeleteRequest {
            add { Events.AddHandler(controlDeleteRequestEventKey, value); }
            remove { Events.RemoveHandler(controlDeleteRequestEventKey, value); }
        }

        private void OnControlSelectRequest(ControlEventArgs e) {
            EventHandler<ControlEventArgs> handler = (EventHandler<ControlEventArgs>)Events[controlSelectRequestEventKey];
            if(handler != null) handler(this, e);
        }
        private void OnControlDeleteRequest(ControlEventArgs e) {
            EventHandler<ControlEventArgs> handler = (EventHandler<ControlEventArgs>)Events[controlDeleteRequestEventKey];
            if(handler != null) handler(this, e);
        }

        #endregion

        public virtual XtraLayoutPanelBase LayoutPanel { get { return null; } }
    }
}

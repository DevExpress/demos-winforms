using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using static DevExpress.XtraNavBar.Demos.VehiclesData;

namespace DevExpress.XtraNavBar.Demos {
    public class TutorialControl : TutorialControlBase {
        protected PanelControl contentPanel1;
        public TutorialControl() {
            this.contentPanel1 = CreateContentPanel();
            OnAddContentPanel();
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UpdateContentLocation();
            SizeChanged += (sender, ee) => UpdateContentLocation();
        }
        protected virtual void OnAddContentPanel() {
            Controls.Add(ContentPanel);
            ContentPanel.Dock = DockStyle.Fill;
            if(!AllowContentBorders) 
                ContentPanel.BorderStyle = BorderStyles.NoBorder;
        }
        void UpdateContentLocation() {
            if(DesignMode) 
                return;
            Rectangle outerBounds = CalcOuterBounds();
            if(outerBounds.IsEmpty)
                return;
            int xoffset = (ContentPanel.Width / 2 - outerBounds.Left - outerBounds.Width / 2);
            int yoffset = (ContentPanel.Height / 2 - outerBounds.Top - outerBounds.Height / 2);

            foreach(Control control in GetContentControls()) {
                Point pt = control.Location;
                pt.Offset(xoffset, yoffset);
                control.Location = pt;
            }
        }
        Rectangle CalcOuterBounds() {
            var _controls = GetContentControls();
            if(_controls.Count() == 0)
                return Rectangle.Empty;
            int _left = int.MaxValue, _right = 0, _top = int.MaxValue, _bottom = 0;
            foreach(Control control in _controls) {
                if(control.Left < _left)
                    _left = control.Left;
                if(control.Right > _right)
                    _right = control.Right;
                if(control.Top < _top)
                    _top = control.Top;
                if(control.Bottom > _bottom)
                    _bottom = control.Bottom;
            }
            return Rectangle.FromLTRB(_left, _top, _right, _bottom);
        }
        IEnumerable<Control> GetContentControls() {
            List<Control> list = new List<Control>();
            foreach(Control control in ContentPanel.Controls) {
                if(control is BarDockControl) continue;
                list.Add(control);
            }
            return list;
        }
        protected virtual bool AllowContentBorders { 
            get { return false; } 
        }
        protected virtual PanelControl CreateContentPanel() {
            return new PanelControl();
        }
        protected PanelControl ContentPanel {
            get { return contentPanel1; }
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
        }
        public override bool AllowPrintOptions {
            get { return false; }
        }
    }
    public static class LicenseInfo {
        public static void SetToolTipController(TutorialControl module, GridControl grid) {
            grid.ToolTipController = module.LicenseToolTipController;
            module.LicenseToolTipController.OnLicenseChanged += (s, e) =>
                e.Info = GetLicenseInfo(e.Row);
        }
        static string GetLicenseInfo(object obj) {
            var model = obj as Model;
            if(model != null)
                return model.LicenseInfo;
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace DevExpress.ApplicationUI.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                CodeTutorialControlBase ctc = item.TModule as CodeTutorialControlBase;
                if(ctc != null) ctc.SelectExampleByName(item.CodeExampleName);

                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
        public static string GetLoremIpsumText(int seed) {
            return string.Format("{0} {1}", texts[seed % texts.Length], texts[(seed + 2) % texts.Length]);
        }
        static string[] texts = new string[]{
            "Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.",
            "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.",
            "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
            "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."
        };
    }
    //
    public class TutorialControl : TutorialControlBase {
        public TutorialControl() {
            this.Padding = Padding.Empty;
            this.SizeChanged += (s, e) => UpdatePosition();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            foreach(Control ctrl in this.Controls) {
                XtraTabControl tabControl = ctrl as XtraTabControl;
                if(tabControl != null) UpdateTabControlPosition(tabControl);
            }
            UpdatePosition();
        }
        List<Panel> centerControls = new List<Panel>();
        void UpdatePosition() {
            foreach(Panel pnl in centerControls)
                pnl.Location = new Point((pnl.Parent.Width - pnl.Width) / 2, (pnl.Parent.Height - pnl.Height) / 2);
        }
        void UpdateTabControlPosition(XtraTabControl tabControl) {
            tabControl.SelectedPageChanged += (s, e) => UpdatePosition();
            foreach(XtraTabPage page in tabControl.TabPages) {
                if(page != null) UpdateCenteredControls(page);
            }
        }
        protected void UpdateCenteredControls(Control page) {
            Panel pnl = new Panel();
            int _left = 100, _right = 0, _top = 100, _bottom = 0;
            for(int i = page.Controls.Count - 1; i >= 0; i--) {
                Control ctrl = page.Controls[i];
                if(ctrl is DevExpress.XtraBars.BarDockControl) continue;
                if(ctrl is DevExpress.Utils.FlyoutPanel) continue;
                if(ctrl is PopupContainerControl || ctrl is PopupControlContainer) continue;
                if(_left > ctrl.Left) _left = ctrl.Left;
                if(_right < ctrl.Right) _right = ctrl.Right;
                if(_top > ctrl.Top) _top = ctrl.Top;
                if(_bottom < ctrl.Bottom) _bottom = ctrl.Bottom;
                ctrl.Parent = pnl;
            }
            pnl.Parent = page;
            pnl.Size = new Size(_right + _left, _bottom + _top);
            centerControls.Add(pnl);
        }
    }
    public class TabbedViewTutorialControl : TutorialControlBase {
        public TabbedViewTutorialControl() {
            Padding = Padding.Empty;
        }
        XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateTabbedViewPadding();
        }
        protected override void DoShow() {
            base.DoShow();
            UpdateTabbedViewPadding();
        }
        void UpdateTabbedViewPadding() {
            if(tabbedView == null) {
                var manager = XtraBars.Docking2010.DocumentManager.FromControl(this);
                if(manager != null && manager.View is XtraBars.Docking2010.Views.Tabbed.TabbedView) 
                    tabbedView = manager.View as XtraBars.Docking2010.Views.Tabbed.TabbedView;
            }
            if(tabbedView != null) {
                bool isWXI = (LookAndFeel.ActiveSkinName == DevExpress.LookAndFeel.SkinStyle.WXI);
                tabbedView.Padding = isWXI ? new Padding?(Padding.Empty) : null;
            }
        }
    }
    public class WidgetViewTutorialControl: TutorialControlBase {
        public WidgetViewTutorialControl() {
            Padding = Padding.Empty;
        }
        XtraBars.Docking2010.Views.Widget.WidgetView widgetView;
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateWidgetViewPadding();
        }
        protected override void DoShow() {
            base.DoShow();
            UpdateWidgetViewPadding();
        }
        void UpdateWidgetViewPadding() {
            if(widgetView == null) {
                var manager = XtraBars.Docking2010.DocumentManager.FromControl(this);
                if(manager != null && manager.View is XtraBars.Docking2010.Views.Widget.WidgetView)
                    widgetView = manager.View as XtraBars.Docking2010.Views.Widget.WidgetView;
            }
            if(widgetView != null) {
                bool isWXI = (LookAndFeel != null && LookAndFeel.ActiveSkinName == DevExpress.LookAndFeel.SkinStyle.WXI);
                widgetView.Padding = isWXI ? (Padding?)new Padding(-widgetView.DocumentSpacing) : null;
            }
        }
    }
}

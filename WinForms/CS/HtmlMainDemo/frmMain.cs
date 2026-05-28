using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;
using System;
using System.Drawing;

namespace DevExpress.HTML.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm  {
        readonly Size wxiSkinExtraSize = new Size(30, 75);
        //
        bool defaultWidthChanged;
        bool defaultHeightChanged;
        bool extraWidthAdded;
        bool extraHeightAdded;
        Size lastSize;
        SizeF lastScale;
        string lastActiveSkinName;
        public frmMain()
            : base() {
            Helpers.DataHelper.LoadMessagesAsync();
            lastActiveSkinName = LookAndFeel.ActiveSkinName;

            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(GridControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(TreeList).TypeHandle);
        }
        protected override void SetFormParam() {
            Icon = Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.HTML.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void OnResizeBegin(EventArgs e) {
            base.OnResizeBegin(e);
            lastSize = Size;
            lastScale = ScaleDPI.ScaleFactor;
        }
        protected override void OnResizeEnd(EventArgs e) {
            base.OnResizeEnd(e);
            if(lastSize.Width != Width && lastScale.Width == ScaleDPI.ScaleFactor.Width)
                defaultWidthChanged = true;
            if(lastSize.Height != Height && lastScale.Height == ScaleDPI.ScaleFactor.Height)
                defaultHeightChanged = true;
        }
        protected override void OnLookAndFeelChangedCore() {
            base.OnLookAndFeelChangedCore();
            AdjustSizeIfNecessary();
        }
        void AdjustSizeIfNecessary() {
            if(lastActiveSkinName != LookAndFeel.ActiveSkinName) {
                if(LookAndFeel.ActiveSkinName == "WXI") {
                    if(!defaultWidthChanged && !extraWidthAdded) {
                        Width += ScaleDPI.ScaleHorizontal(wxiSkinExtraSize.Width);
                        extraWidthAdded = true;
                    }
                    if(!defaultHeightChanged && !extraHeightAdded) {
                        Height += ScaleDPI.ScaleVertical(wxiSkinExtraSize.Height);
                        extraHeightAdded = true;
                    }
                }
                else {
                    if(!defaultWidthChanged && extraWidthAdded) {
                        Width -= ScaleDPI.ScaleHorizontal(wxiSkinExtraSize.Width);
                        extraWidthAdded = false;
                    }
                    if(!defaultHeightChanged && extraHeightAdded) {
                        Height -= ScaleDPI.ScaleVertical(wxiSkinExtraSize.Height);
                        extraHeightAdded = false;
                    }
                }
            }
            lastActiveSkinName = LookAndFeel.ActiveSkinName;
        }
        protected override string ProductName {
            get { return "HTML"; }
        }
        protected override string DemoName {
            get { return "WinForms HTML & CSS Templates"; }
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl group, LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, true, XtraNavBar.NavBarImage.Large);
        }
        protected override bool CanUseEmptyRootPadding(string name) {
            return true;
        }
        protected override void ShowAbout() {
            BaseEdit.About();
        }
        protected override bool AllowHtmlDebugger => true;
    }
}

using DevExpress.Dialogs.Core.Items;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using static DevExpress.XtraDialogs.Demos.Helpers.Data.VehiclesData;

namespace DevExpress.XtraDialogs.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                CodeTutorialControlBase ctcb = item.TModule as CodeTutorialControlBase;
                if(ctcb != null)
                    ctcb.SelectExampleByName(item.CodeExampleName);
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
    }
    public static class LicenseInfo {
        public static void SetToolTipController(TutorialControl module, GridControl grid) {
            grid.ToolTipController = module.LicenseToolTipController;
            module.LicenseToolTipController.OnLicenseChanged += (s, e) =>
                e.Info = GetLicenseInfo(e.Row);
        }
        static string GetLicenseInfo(object obj) {
            var item = obj as ShellItemLink;
            if(item != null) {
                var model = item.Tag as Model;
                if(model != null) 
                    return model.LicenseInfo;
            }
            return null;
        }
    }
}

using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraGrid;
using static DevExpress.XtraLayout.Demos.VehiclesDataSet;

namespace DevExpress.XtraLayout.Demos {
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
                if(ctc != null) 
                    ctc.SelectExampleByName(item.CodeExampleName);

                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                TutorialControl tc = tutorial as TutorialControl;
                if(tc != null)
                    manager.AllowExport(tc.ExportControl);
                else manager.AllowExport(null);
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;

                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            catch { }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
        public static class LicenseInfo {
            public static void SetToolTipController(TutorialControl module, GridControl grid) {
                grid.ToolTipController = module.LicenseToolTipController;
                module.LicenseToolTipController.OnLicenseChanged += (s, e) =>
                    e.Info = GetLicenseInfo(e.Row);
                module.LicenseToolTipController.UpdateMaskOptions(grid);
            }
            static string GetLicenseInfo(object obj) {
                var dRow = obj as DataRowView;
                if(dRow != null) {
                    ModelRow row = dRow.Row as ModelRow;
                    if(row != null) 
                        return $"{row.License_Name}|{row.Author}|{row.Source}|{row.Edits}";
                }
                return null;
            }
        }
    }
}

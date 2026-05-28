using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public class DemosInfo : ModulesInfo {
        const int MaxMruCount = 3;
        static readonly Padding DefaultPadding = new Padding(8);
        static readonly List<DemoMruItem> mruList = new List<DemoMruItem>();
        public static void DoShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, SpreadsheetRibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                SpreadSheetTutorialControlBase tutorial = item.TModule as SpreadSheetTutorialControlBase;
                groupControl.Padding = tutorial.ShowWithPaddings ? DefaultPadding : Padding.Empty;

                ModuleInfo oldModule = null;
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    oldModule = Instance.CurrentModuleBase;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }

                tutorial.Bounds = groupControl.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                groupControl.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                AddToMru(item, tutorial);

                if(oldTutorial != null) {
                    oldTutorial.Visible = false;
                    groupControl.Controls.Remove(oldTutorial);
                }

                PurgeMru();
            }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }

        static void AddToMru(ModuleInfo module, Control tutorial) {
            for(int i = 0; i < mruList.Count; i++) {
                DemoMruItem item = mruList[i];
                if(object.ReferenceEquals(item.Module, module)) {
                    if(i > 0) {
                        mruList.RemoveAt(i);
                        mruList.Insert(0, item);
                    }
                    return;
                }
            }
            mruList.Insert(0, new DemoMruItem() { Module = module, TutorialControl = tutorial });
        }

        static void PurgeMru() {
            while(mruList.Count > MaxMruCount) {
                DemoMruItem item = mruList[mruList.Count - 1];
                item.TutorialControl.Dispose();
                item.Module.ResetModule();
                mruList.RemoveAt(mruList.Count - 1);
            }
        }
    }
}

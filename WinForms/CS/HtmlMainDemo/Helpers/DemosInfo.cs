using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
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
}

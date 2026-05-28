using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;

namespace DevExpress.XtraDiagram.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowDiagramModule(string name, GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                Instance.CurrentModuleBase = item;
                CodeTutorialControlBase ctcb = item.TModule as CodeTutorialControlBase;
                if(ctcb != null) 
                    ctcb.SelectExampleByName(item.CodeExampleName);

                TutorialControlBase tutorialBase = item.TModule as TutorialControlBase;
                tutorialBase.Bounds = group.DisplayRectangle;
                tutorialBase.Visible = false;
                group.Controls.Add(tutorialBase);
                tutorialBase.Dock = DockStyle.Fill;
                tutorialBase.RibbonMenuManager = manager;
                tutorialBase.TutorialName = name;
                tutorialBase.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null) 
                    oldTutorial.Visible = false;
            }
            catch { }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}

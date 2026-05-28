using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.Xpo.Demos {
    public class TutorialsInfo : ModulesInfo {
        public static void ShowModule(string name, GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = TutorialsInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                TutorialControl tc = item.TModule as TutorialControl;
                if(tc != null && tc.SetNewWhatsThisPadding) {
                    manager.ShowReservGroup1(true);
                    tc.SetUpWhatsThis();
                }
                else { 
                    manager.ShowReservGroup1(false); 
                }
                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}

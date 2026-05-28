using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraScheduler.Demos {
    public class DemosInfo : ModulesInfo {
        static void UpdateOptions(Control control) {
            if(control == null)
                return;
            foreach(Control ctrl in control.Controls)
                UpdateOptions(ctrl);
            SchedulerControl scheduler = control as SchedulerControl;
            if(scheduler != null && MainFormHelper.TakeScreens)
                scheduler.OptionsBehavior.UseAsyncMode = false;
        }
        public static void DoShowModule(string name, XtraEditors.GroupControl groupControl, SchedulerRibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }

                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = groupControl.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                groupControl.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                TutorialControl tc = item.TModule as TutorialControl;
                UpdateOptions(tc);
                if(tc != null) {
                    SchedulerControl printingSchedulerControl = tc.PrintingSchedulerControl;
                    manager.AllowExport(printingSchedulerControl);
                    manager.SchedulerControl = printingSchedulerControl;
                }
                else {
                    manager.AllowExport(null);
                }
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                manager.SchedulerReport = tc as IDemoSchedulerReport;
                if(oldTutorial != null) 
                    oldTutorial.Visible = false;
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}

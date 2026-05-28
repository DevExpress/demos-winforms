using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraScheduler.Demos {
    public class DemosInfo : ModulesInfo {
        public static SchedulerControl CurrentScheduler {
            get { return ((TutorialControl)Instance.CurrentModuleBase.TModule).Scheduler; }
        }
        public static void DoShowModule(string name, DevExpress.XtraEditors.GroupControl contentPlaceholder, DateNavigator dateNavigator, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Control oldTutorial = null;
            if(Instance.CurrentModuleBase != null) {
                if(Instance.CurrentModuleBase.Name == name)
                    return;
                oldTutorial = Instance.CurrentModuleBase.TModule;
                ZoomBehaviour.Detach(((TutorialControl)oldTutorial).Scheduler);
            }
            TutorialControl tutorial = item.TModule as TutorialControl;
            tutorial.Bounds = contentPlaceholder.DisplayRectangle;
            Instance.CurrentModuleBase = item;
            tutorial.Visible = false;
            contentPlaceholder.Controls.Add(tutorial);
            tutorial.Dock = DockStyle.Fill;
            SchedulerControl scheduler = tutorial.Scheduler;
            if(scheduler != null) {
                CommonOptions.Instance.Apply(tutorial);
                dateNavigator.SchedulerControl = scheduler;
                dateNavigator.Refresh();
                ZoomBehaviour.Attach(scheduler);
            }
            tutorial.RibbonMenuManager = manager;
            tutorial.TutorialName = name;
            tutorial.Visible = true;
            item.WasShown = true;
            if(oldTutorial != null)
                oldTutorial.Visible = false;
        }
        public static void DoShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, SchedulerRibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                    ZoomBehaviour.Detach(((TutorialControl)oldTutorial).Scheduler);
                }
                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = groupControl.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                groupControl.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                TutorialControl tc = item.TModule as TutorialControl;
                if(tc != null) {
                    SchedulerControl scheduler = tc.Scheduler;
                    manager.AllowExport(scheduler);
                    manager.SchedulerControl = scheduler;
                    ZoomBehaviour.Attach(scheduler);
                }
                else {
                    manager.AllowExport(null);
                }
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                manager.SchedulerReport = tc as IDemoSchedulerReport;
                if(oldTutorial != null) {
                    oldTutorial.Visible = false;
                }
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}

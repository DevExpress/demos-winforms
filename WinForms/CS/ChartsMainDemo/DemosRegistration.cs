using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraCharts.Designer;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos {
    class DemosInfo : ModulesInfo {
        static NavigationPaneState optionsPanelState = NavigationPaneState.Expanded;

        internal static ChartDemoModule DoShowModule(string name, GroupControl group, ChartRibbonMenuManager manager) {
            if(Instance.CurrentModuleBase != null && Instance.CurrentModuleBase.Name == name)
                return null;
            if(Instance.CurrentModuleBase != null) {
                ChartDemoModuleWithOptions oldModuleWithOptions = Instance.CurrentModuleBase.TModule as ChartDemoModuleWithOptions;
                if(oldModuleWithOptions != null)
                    optionsPanelState = oldModuleWithOptions.OptionsPanelState;
            }
            ModuleInfo newModuleInfo = GetItem(name);
            ChartDemoModule oldModule = CurrentModule as ChartDemoModule;
            if(oldModule != null) {
                oldModule.Visible = false;
                ModuleInfo moduleInfo = GetItem(oldModule.TutorialName);
                group.Controls.Remove(oldModule);
                moduleInfo.ResetModule();
                Instance.CurrentModuleBase = null;
                oldModule.Dispose();
            }
            ChartDemoModule newModule = newModuleInfo.TModule as ChartDemoModule; //Module should be created in property getter
            newModule.Bounds = group.DisplayRectangle;
            newModule.Visible = false;
            newModule.Dock = DockStyle.Fill;
            newModule.RibbonMenuManager = manager;
            newModule.TutorialName = name;
            ChartDemoModuleWithOptions newModuleWithOptions = newModule as ChartDemoModuleWithOptions;
            if(newModuleWithOptions != null)
                newModuleWithOptions.OptionsPanelState = optionsPanelState;
            group.Controls.Add(newModule);
            newModule.Visible = true;
            Instance.CurrentModuleBase = newModuleInfo;
            manager.AllowExport(newModule.ExportedObject);
            manager.ShowReservGroup1(true);
            newModuleInfo.WasShown = true;
            RaiseModuleChanged();
            return newModule;
        }
        internal static void SetPaletteName(string paletteName) {
            if(Instance.CurrentModuleBase != null) {
                ChartDemoModule chartDemoModule = Instance.CurrentModuleBase.TModule as ChartDemoModule;
                if(chartDemoModule != null) {
                    chartDemoModule.PaletteName = paletteName;
                    return;
                }
            }
            return;
        }
        internal static DialogResult RunChartDesigner() {
            if(Instance.CurrentModuleBase != null) {
                ChartDemoModule demoModule = Instance.CurrentModuleBase.TModule as ChartDemoModule;
                if(demoModule != null) {
                    ChartDesigner chartDesigner = new ChartDesigner(demoModule.ChartControl);
                    return chartDesigner.ShowDialog();
                }
            }
            return DialogResult.Cancel;
        }
    }
}

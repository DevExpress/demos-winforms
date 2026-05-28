using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.XtraBars;

namespace DevExpress.XtraNavBar.Demos {
	public class TutorialsInfo : DevExpress.DXperience.Demos.ModulesInfo {
		const string languageDir = "CS\\";
        static void SetBarManager(Control ctrl, BarManager manager) {
            foreach(Control element in ctrl.Controls) {
                NavBarControl nc = element as NavBarControl;
                if(nc != null) nc.MenuManager = manager;
                SetBarManager(element, manager);
            }
        }
		public static DevExpress.Tutorials.ModuleBase ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.DXperience.Demos.LookAndFeelMenu menu, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel) {
			ModuleInfo item = TutorialsInfo.GetItem(name);
			Cursor currentCursor = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			group.Parent.SuspendLayout();
			group.SuspendLayout();
			try {
				Control oldTutorial = null;
				if(Instance.CurrentModuleBase != null)
					oldTutorial = Instance.CurrentModuleBase.TModule;

				TutorialControl tutorial = item.TModule as TutorialControl;
				tutorial.Bounds = group.DisplayRectangle;
				Instance.CurrentModuleBase = item;
				tutorial.Visible = false;
				group.Controls.Add(tutorial);
				tutorial.Dock = DockStyle.Fill;
                SetBarManager(tutorial, menu.MainMenu.Manager);
				tutorial.Visible = true;
				if(oldTutorial != null) oldTutorial.Visible = false;
			}
			finally {
				group.ResumeLayout(true);
				group.Parent.ResumeLayout(true);
				Cursor.Current = currentCursor;
			}
			RaiseModuleChanged();
			DevExpress.Tutorials.ModuleBase module = Instance.CurrentModuleBase.TModule as DevExpress.Tutorials.ModuleBase;
			if(module != null) {
				module.TutorialInfo.Description = Instance.CurrentModuleBase.Description;
				module.TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name;
				module.TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile;
				module.TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile;

				string xmlFile = DataDirectoryHelper.GetDataFile(module.TutorialInfo.WhatsThisXMLFile);
				string codeFile = DataDirectoryHelper.GetDataFile(module.TutorialInfo.WhatsThisCodeFile);
				if(xmlFile == "") module.TutorialInfo.WhatsThisXMLFile = languageDir + module.TutorialInfo.WhatsThisXMLFile;
				if(codeFile == "") module.TutorialInfo.WhatsThisCodeFile = languageDir + module.TutorialInfo.WhatsThisCodeFile;
			}
			return module;
		}
	}

}

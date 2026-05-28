using System;
using System.Collections.Generic;
using DevExpress.Tutorials;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.Xpo.Demos {
    class WhatsThis {
        private WhatsThisController whatsThisController;
        private bool whatsThisEnabled;
        private ModuleWhatsThis whatsThisModule;
        private bool disableWhatsThisOnMove;
        private frmMain form;
        private UserControl module;
        public bool WhatsThisEnabled { get { return whatsThisEnabled; } }

        public WhatsThis(frmMain Form, string demoName) {
            Control ctrl;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 0;
            toolTip1.InitialDelay = 0;
            form = Form;
            module = ((IWhatsThisProvider)form).CurrentModule;

            TutorialRegistration moduleInfo = TutorialRegistration.GetInfo(demoName);
            if(moduleInfo == null)
                throw new Exception("Tutorial not registered!");
            whatsThisController = new WhatsThisController(form);
            whatsThisController.UpdateWhatsThisInfo(moduleInfo.XmlInfoFile, moduleInfo.CodeInfoFile);
            foreach(WhatsThisControlEntry item in whatsThisController.Collection) {
                ctrl = GetAllTypedControls(module, item.ControlName);
                if(ctrl != null)
                    toolTip1.SetToolTip(ctrl, item.PopupInfo.Caption);
            }

            whatsThisModule = new ModuleWhatsThis(whatsThisController);
            whatsThisEnabled = false;
            disableWhatsThisOnMove = true;            
            whatsThisModule.Parent = module.Parent;
            whatsThisModule.Dock = DockStyle.Fill;
            whatsThisModule.Visible = false;
        }

        Control GetAllTypedControls(Control ctrl, string name) {
            Control retCtrl;
            if(ctrl.Name == name)
                return ctrl;
            foreach(Control ctrlChild in ctrl.Controls) {
                retCtrl = GetAllTypedControls(ctrlChild, name);
                if(retCtrl != null)
                    return retCtrl;
            }
            return null;
        }

        protected void NotifyModuleWhatsThisStateChange(bool whatsThisStarted) {
            if(ModulesInfo.Instance.CurrentModuleBase.TModule == null)
                return;
            if(whatsThisStarted) {
                module.Padding = new Padding(8);
                module.Refresh();
            } else {
                module.Padding = new Padding(0);
            }
            form.EnableService(!whatsThisStarted);
        }

        public void ClickWhatsThis() {
            whatsThisEnabled = !whatsThisEnabled;
            NotifyModuleWhatsThisStateChange(whatsThisEnabled);
            disableWhatsThisOnMove = whatsThisEnabled;
            whatsThisController.UpdateRegisteredVisibleControls();
            if(whatsThisEnabled) {
                whatsThisController.UpdateWhatsThisBitmaps();
                module.Hide();
                whatsThisModule.Show();
            } else {
                whatsThisModule.Visible = false;
                module.Show();
            }
        }

        public void DisableWhatsThis() {
            if(!whatsThisEnabled)
                return;
            NotifyModuleWhatsThisStateChange(false);
            whatsThisEnabled = false;
            HideWhatsThisModule();
            form.EnableService(!whatsThisEnabled);
        }

        private void HideWhatsThisModule() {
            whatsThisModule.Visible = false;
            module.Show();
        }

    }
}

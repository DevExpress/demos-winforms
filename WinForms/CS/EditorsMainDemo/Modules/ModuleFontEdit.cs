using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <ceShowCustomButtons>
using DevExpress.XtraEditors.Controls;
// </ceShowCustomButtons>
using System.Windows.Forms;
using DevExpress.Tutorials;


namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleFontEdit : TutorialControl  {
        public ModuleFontEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleFontEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "fontEdit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleCalcEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(fontEditSample);
            InitValues();
            fontEditSample.EditValue = this.Font.FontFamily.GetName(0);
            cbFontSize.EditValue = fontEditSample.Properties.AppearanceDropDown.Font.Size.ToString(); 
        }

        void InitValues() {
            updateValues = true;
            seRUItemCount.Value = fontEditSample.Properties.RecentlyUsedItemCount;
            ceShowSymbolPreview.Checked = fontEditSample.Properties.ShowSymbolFontPreview;
            updateValues = false;
        }

        //<seRUItemCount>
        private void seRUItemCount_EditValueChanged(object sender, EventArgs e) {
            if(updateValues) return;
            fontEditSample.Properties.RecentlyUsedItemCount = Convert.ToInt32(seRUItemCount.Value);
        }
        //</seRUItemCount>

        //<ceShowSymbolPreview>
        private void ceShowSymbolPreview_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            fontEditSample.Properties.ShowSymbolFontPreview = ceShowSymbolPreview.Checked;
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            fontEditSample.Properties.AppearanceDropDown.Font = new Font(DefaultFont.Name, Convert.ToInt32(cbFontSize.EditValue));  
        }
        //</ceShowSymbolPreview>
    }
}


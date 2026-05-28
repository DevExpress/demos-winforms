using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraGrid.Demos {
    public partial class EditFormOptions : XtraForm {
        GridView view;
        public EditFormOptions(GridView view, IDXMenuManager menuManager) {
            InitializeComponent();
            this.view = view;
            InitEditors(menuManager);
            InitData();
        }
        public EditFormOptions() {
            InitializeComponent();
        }

        void InitData() {
            icbEditingMode.EditValue = view.OptionsBehavior.EditingMode;
            icbActionOnModifiedRowChange.EditValue = view.OptionsEditForm.ActionOnModifiedRowChange;
            icbBindingMode.EditValue = view.OptionsEditForm.BindingMode;
            icbShowOnDoubleClick.EditValue = view.OptionsEditForm.ShowOnDoubleClick;
            icbShowOnEnterKey.EditValue = view.OptionsEditForm.ShowOnEnterKey;
            icbShowOnF2Key.EditValue = view.OptionsEditForm.ShowOnF2Key;
            icbShowUpdateCancelPanel.EditValue = view.OptionsEditForm.ShowUpdateCancelPanel;
            teFormCaptionFormat.Text = view.OptionsEditForm.FormCaptionFormat;
            sePopupEditFormWidth.Value = view.OptionsEditForm.PopupEditFormWidth;
        }

        void InitEditors(IDXMenuManager menuManager) {
            foreach(DefaultBoolean val in Enum.GetValues(typeof(DefaultBoolean))) {
                icbShowOnDoubleClick.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
                icbShowOnEnterKey.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
                icbShowOnF2Key.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
                icbShowUpdateCancelPanel.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
            }
            foreach(GridEditingMode mode in Enum.GetValues(typeof(GridEditingMode))) {
                if(mode != GridEditingMode.Default && mode != GridEditingMode.Inplace)
                    icbEditingMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<GridEditingMode>.GetTitle(mode), mode, -1));
            }
            foreach(EditFormModifiedAction action in Enum.GetValues(typeof(EditFormModifiedAction)))
                icbActionOnModifiedRowChange.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper < EditFormModifiedAction>.GetTitle(action), action, -1));
            foreach(EditFormBindingMode mode in Enum.GetValues(typeof(EditFormBindingMode)))
                icbBindingMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<EditFormBindingMode>.GetTitle(mode), mode, -1));
            foreach(Control ctrl in layoutControl1.Controls) {
                BaseEdit edit = ctrl as BaseEdit;
                if(edit != null) edit.MenuManager = menuManager;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            view.OptionsBehavior.EditingMode = (GridEditingMode)icbEditingMode.EditValue;
            view.OptionsEditForm.ActionOnModifiedRowChange = (EditFormModifiedAction)icbActionOnModifiedRowChange.EditValue;
            view.OptionsEditForm.BindingMode = (EditFormBindingMode)icbBindingMode.EditValue;
            view.OptionsEditForm.ShowOnDoubleClick = (DefaultBoolean)icbShowOnDoubleClick.EditValue;
            view.OptionsEditForm.ShowOnEnterKey = (DefaultBoolean)icbShowOnEnterKey.EditValue;
            view.OptionsEditForm.ShowOnF2Key = (DefaultBoolean)icbShowOnF2Key.EditValue;
            view.OptionsEditForm.ShowUpdateCancelPanel = (DefaultBoolean)icbShowUpdateCancelPanel.EditValue;
            view.OptionsEditForm.FormCaptionFormat = teFormCaptionFormat.Text;
            view.OptionsEditForm.PopupEditFormWidth = (int)sePopupEditFormWidth.Value;
        }
    }
}

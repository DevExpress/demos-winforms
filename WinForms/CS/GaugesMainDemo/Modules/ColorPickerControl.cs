using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;

namespace DevExpress.XtraGauges.Demos {
    public partial class ColorPickerControl : XtraUserControl {
        RepositoryItemColorPickEdit item;
        public ColorPickerControl() {
            item = new RepositoryItemColorPickEdit();
            InitializeComponent();
            colorPickControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            TabStop = false;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitColorPicker();
            IniWebList();
            IniSystemList();
        }
        void InitColorPicker() {
            colorPickControl.Selectable = false;
            colorPickControl.ThemeColors.AddColorRange(item.ThemeColors.ToList());
            colorPickControl.StandardColors.AddColorRange(item.StandardColors.ToList());
        }
        void IniSystemList() {
            systemColorListControl.Selectable = false;
            systemColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.SystemColors);
        }
        void IniWebList() {
            webColorListControl.Selectable = false;
            webColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.WebColors);
        }
        
        void OnSelectedColorChanged(object sender, InnerColorPickControlSelectedColorChangedEventArgs e) {
            if(ResultColorChanged != null) ResultColorChanged(this, e);
        }
        Color color = Color.Empty;
        public void SetColor(Color color) {
            this.color = color;
        }
        public event EventHandler<InnerColorPickControlSelectedColorChangedEventArgs> ResultColorChanged;
    }

    [ToolboxItem(false)]
    public class NonFocusableTabControl : XtraTabControl {
        protected override bool AllowTabFocus { get { return false; } }
    }
}

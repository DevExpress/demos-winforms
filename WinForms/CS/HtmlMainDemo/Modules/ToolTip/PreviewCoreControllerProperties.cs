using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;

namespace DevExpress.HTML.Demos {
    public partial class PreviewCoreControllerProperties : XtraUserControl {
        ToolTipController controller;
        public PreviewCoreControllerProperties() {
            InitializeComponent();
        }
        public void SetVisibleProperties(bool autoPopDelay, bool initialDelay, bool iconSize, bool location, bool type) {
            liAutoPopDelay.Visibility = autoPopDelay ? LayoutVisibility.Always : LayoutVisibility.Never;
            liInitialDelay.Visibility = initialDelay ? LayoutVisibility.Always : LayoutVisibility.Never;
            liIconSize.Visibility = iconSize ? LayoutVisibility.Always : LayoutVisibility.Never;
            liLocation.Visibility = location ? LayoutVisibility.Always : LayoutVisibility.Never;
            liType.Visibility = type ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
        public void Initialize(ToolTipController controller, ToolTipType type) {
            this.controller = controller;
            ttIconSize.Properties.Items.AddRange(Enum.GetValues(typeof(ToolTipIconSize)));
            ttLocation.Properties.Items.AddRange(Enum.GetValues(typeof(ToolTipLocation)));
            ttType.Properties.Items.AddRange(new ToolTipType[] { ToolTipType.Default, ToolTipType.Html, type });
            UpdateValues();
            SubscribeEvents();
        }
        public void UpdateValues() {
            ttAutoPopDelay.EditValue = controller.AutoPopDelay;
            ttInitialDelay.EditValue = controller.InitialDelay;
            ttIconSize.EditValue = controller.IconSize;
            ttLocation.EditValue = controller.ToolTipLocation;
            ttType.EditValue = controller.ToolTipType;
        }
        void SubscribeEvents() {
            ttAutoPopDelay.EditValueChanged += delegate { controller.AutoPopDelay = Convert.ToInt16(ttAutoPopDelay.EditValue); PropertyChanged?.Invoke(this, EventArgs.Empty); };
            ttInitialDelay.EditValueChanged += delegate { controller.InitialDelay = Convert.ToInt16(ttInitialDelay.EditValue); PropertyChanged?.Invoke(this, EventArgs.Empty); };
            ttIconSize.EditValueChanged += delegate { controller.IconSize = (ToolTipIconSize)ttIconSize.EditValue; PropertyChanged?.Invoke(this, EventArgs.Empty); };
            ttLocation.EditValueChanged += delegate { controller.ToolTipLocation = (ToolTipLocation)ttLocation.EditValue; PropertyChanged?.Invoke(this, EventArgs.Empty); };
            ttType.EditValueChanged += delegate { controller.ToolTipType = (ToolTipType)ttType.EditValue; PropertyChanged?.Invoke(this, EventArgs.Empty); };
        }
        public event EventHandler PropertyChanged;
    }
}

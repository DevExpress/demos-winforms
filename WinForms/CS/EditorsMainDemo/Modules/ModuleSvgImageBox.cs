using System;
using System.Drawing;
using System.Linq;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleSvgImageBox : TutorialControl {
        public ModuleSvgImageBox() {
            InitializeComponent();
            InitializeComboBoxes();
            DoPreselectSeats();
            AutoMergeRibbon = true;
        }
        void InitializeComboBoxes() {
            imgAlignmentComboBox.Properties.Items.AddRange(Enum.GetValues(typeof(ContentAlignment)));
            imgAlignmentComboBox.SelectedItem = svgImageBox.ImageAlignment;
            sizeModeComboBox.Properties.Items.AddRange(Enum.GetValues(typeof(SvgImageSizeMode)));
            sizeModeComboBox.SelectedItem = svgImageBox.SizeMode;
            hitTestTypeComboBox.Properties.Items.AddRange(Enum.GetValues(typeof(ItemHitTestType)));
            hitTestTypeComboBox.SelectedItem = svgImageBox.ItemHitTestType;
            selectionModeComboBox.Properties.Items.AddRange(Enum.GetValues(typeof(SvgImageItemSelectionMode)));
            selectionModeComboBox.SelectedItem = svgImageBox.OptionsSelection.SelectionMode;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RibbonMenuManager.MergeOptions.PlacePagesInDemoCategory = false;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleSvgImageBox" }; } }
        protected override string WhatsThisXMLFileName { get { return "svgImageBox"; } }
        void DoPreselectSeats() {
            var selectedSeatItems = svgImageBox.RootItems.Where(i => CheckSeatId(i)).Skip(47).Take(4).ToArray();
            svgImageBox.Selection.AddRange(selectedSeatItems);
        }
        // <svgImageBox>
        void OnSvgImageBoxQueryHoveredItem(object sender, SvgImageQueryHoveredItemEventArgs e) {
            if(e.HoveredItem != null && !CheckSeatId(e.HoveredItem))
                e.HoveredItem = e.HoveredItem.FindAncestors(a => CheckSeatId(a)).FirstOrDefault();
        }
        bool CheckSeatId(SvgImageItem svgImageItem) {
            return svgImageItem.Id != null && svgImageItem.Id.StartsWith("seat");
        }
        // </svgImageBox>
        //<selectedItemsListBox>
        void OnSvgImageBoxSelectionChanging(object sender, SvgImageSelectionChangingEventArgs e) {
            if(e.Action == SvgImageSelectionChangeAction.Clear && svgImageBox.HoveredItem == null && !isManualClear)
                e.Cancel = true;
        }
        void OnSvgImageBoxSelectionChanged(object sender, EventArgs e) {
            selectedItemsListBox.BeginUpdate();
            selectedItemsListBox.Items.Clear();
            foreach(var item in svgImageBox.Selection) {
                string itemDisplayName = string.Format("Seat number: {0}", ((string)item.Tag).ToUpper()); 
                selectedItemsListBox.Items.Add(itemDisplayName);
            }
            selectedItemsListBox.EndUpdate();
        }
        bool isManualClear;
        void OnClearSelectionButtonClick(object sender, EventArgs e) {
            isManualClear = true;
            svgImageBox.Selection.Clear();
            isManualClear = false;
        }
        //</selectedItemsListBox>
        void OnImageAlignmentComboBoxSelectedIndexChanged(object sender, EventArgs e) {
            svgImageBox.ImageAlignment = (ContentAlignment)imgAlignmentComboBox.SelectedItem;
        }
        //<useCtrlToMultiSelectToggleSwitch>
        void OnCtrlToMultiSelectSwitchToggled(object sender, EventArgs e) {
            svgImageBox.OptionsSelection.UseCtrlToMultiSelect = useCtrlToMultiSelectToggleSwitch.IsOn ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
        }
        //</useCtrlToMultiSelectToggleSwitch>
        //<sizeModeComboBox>
        void OnSizeModeComboBoxSelectedIndexChanged(object sender, EventArgs e) {
            svgImageBox.SizeMode = (SvgImageSizeMode)sizeModeComboBox.SelectedItem;
        }
        //</sizeModeComboBox>
        //<hitTestTypeComboBox>
        void OnHitTestTypeComboBoxSelectedIndexChanged(object sender, EventArgs e) {
            svgImageBox.ItemHitTestType = (ItemHitTestType)hitTestTypeComboBox.SelectedItem;
        }
        //</hitTestTypeComboBox>
        //<selectionModeComboBox>
        void OnSelectionModeComboBoxSelectedIndexChanged(object sender, EventArgs e) {
            svgImageBox.OptionsSelection.SelectionMode = (SvgImageItemSelectionMode)selectionModeComboBox.SelectedItem;
        }
        //</selectionModeComboBox>
        void OnBeforeShowToolTip(object sender, Utils.ToolTipControllerShowEventArgs e) {
            var svgImageItem = e.SelectedObject as SvgImageItem;
            if(svgImageItem == null) return;
            e.ToolTip = string.Format(e.ToolTip,(svgImageItem.Tag as string).ToUpper(), svgImageItem.Selected ? "Reserved" : "Free");
        }
        string[] disabledSeats = { "a7", "a5", "a3", "a1", "b9", "b7", "b5", "b3", "b1", "c10", "c8", "c6", "c4", "c2", "d9", "d7", "d5", "d3", "d1", "e10", "e8", "e6", "e4", "e2", "f9", "f7", "f5", "f3", "f1", "g11", "g9", "g7", "g5", "g3", "g1", "h12", "h10", "h8", "h6", "h4", "h2" };
        void OnLayoutModeToggled(object sender, EventArgs e) {
            svgImageBox.BeginUpdate();
            var seatItems = svgImageBox.RootItems.Where(i => CheckSeatId(i)).ToList();
            if(layoutModeSwitch.IsOn)
                seatItems.ForEach(i => i.Enabled = !disabledSeats.Contains(i.Tag as string));
            else
                seatItems.ForEach(i => i.Enabled = true);
            svgImageBox.EndUpdate();
        }
        void OnExportBarButtonItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            ExportToSVG();
        }
        protected override void ExportToSVG() {
            ExportTo("svg", "SVG document (*.svg)|*.svg");
        }
        protected override void ExportToCore(string filename, string ext) {
            svgImageBox.ExportSvgImage(filename);
        }
    }
}

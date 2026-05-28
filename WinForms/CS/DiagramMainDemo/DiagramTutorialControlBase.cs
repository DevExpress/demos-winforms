using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDiagram.Docking;
using DevExpress.XtraDiagram.Utils;

namespace DevExpress.XtraDiagram.Demos {
    public partial class DiagramTutorialControlBase : TutorialControlBase {
        #region Static
        public static string GetDataFileName(string fileName) {
            return DataDirectoryHelper.GetDataFile(Path.Combine("Diagram", fileName));
        }
        static void SubscribeRibbonEvents(RibbonControl ribbon) {
            if(ribbon != null) {
                ribbon.Merge += Ribbon_Merge;
                ribbon.UnMerge += Ribbon_UnMerge;
            }
        }
        static void UnsubscribeRibbonEvents(RibbonControl ribbon) {
            if(ribbon != null) {
                ribbon.Merge -= Ribbon_Merge;
                ribbon.UnMerge -= Ribbon_UnMerge;
            }
        }
        static void Ribbon_Merge(object sender, RibbonMergeEventArgs e) {
            e.MergeOwner.ApplicationButtonDropDownControl = e.MergedChild.ApplicationButtonDropDownControl;
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Default;
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.Default;
        }
        static void Ribbon_UnMerge(object sender, RibbonMergeEventArgs e) {
            e.MergeOwner.ApplicationButtonDropDownControl = null;
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.False;
        }
        #endregion
        bool showOptionsPanelCore = false;
        bool needOptionsPageCore = true;
        bool isPanAndZoomVisible;
        bool isModuleLoaded;
        bool canUpdateVisibility;
        [DefaultValue(false)]
        public bool ShowOptionsPanel {
            get { return this.showOptionsPanelCore; }
            set {
                if(showOptionsPanelCore == value)
                    return;
                showOptionsPanelCore = value;
                UpdateOptionsPanelVisibility();
            }
        }
        [DefaultValue(true)]
        public bool NeedOptionsPage {
            get { return this.needOptionsPageCore; }
            set {
                if(needOptionsPageCore == value)
                    return;
                needOptionsPageCore = value;
                IncludeOptionsPageIfNeeded();
            }
        }
        public void PlaceOptionsPanelControlsWithoutTabPane() {
            sidePanel.Controls.Remove(tabPane);
            sidePanel.Controls.AddRange(optionsPage.Controls.Cast<Control>().ToArray());
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoMergeRibbon {
            get { return true; }
            set { }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<Control> OptionsPageControls {
            get {
                if(optionsPageControls == null) {
                    optionsPageControls = new ObservableCollection<Control>();
                    optionsPageControls.CollectionChanged += OptionsPageControls_CollectionChanged;
                }
                return optionsPageControls;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<NavigationPageBase> OptionsTabPanePages {
            get {
                if(optionsTabPanePages == null) {
                    optionsTabPanePages = new ObservableCollection<NavigationPageBase>();
                    optionsTabPanePages.CollectionChanged += OptionsTabPanePages_CollectionChanged;
                }
                return optionsTabPanePages;
            }
        }
        [DefaultValue(200)]
        public int OptionsSidePanelWidth {
            get { return sidePanel.Size.Width; }
            set { sidePanel.Size = new Size(value, sidePanel.Height); }
        }
        protected Control OptionsSidePanel {
            get { return this.sidePanel; }
        }
        protected DiagramControl Diagram {
            get { return this.diagramControl; }
        }
        protected virtual RibbonControl Ribbon {
            get { return null; }
        }
        protected virtual bool PanAndZoomVisibleOnInitialized {
            get { return false; }
        }
        public DiagramTutorialControlBase() {
            isPanAndZoomVisible = PanAndZoomVisibleOnInitialized;
            InitializeComponent();
            IncludeOptionsPageIfNeeded();
            if(isPanAndZoomVisible)
                CreateDockingWithPanAndZoom();
        }
        protected virtual void CreateDockingWithPanAndZoom() {
            Diagram.CreateDocking(DockingMode.PanZoom);
            SubscribePanAndZoomEvents();
            this.BorderStyle = BorderStyle.None;
        }
        protected void SubscribePanAndZoomEvents() {
            DoPanAndZoomPanelAction(panel => panel.VisibilityChanged += OnPanAndZoomPanelVisibilityChanged);
        }
        protected void UnsubscribePanAndZoomEvents() {
            DoPanAndZoomPanelAction(panel => panel.VisibilityChanged -= OnPanAndZoomPanelVisibilityChanged);
        }
        protected override void Dispose(bool disposing) {
            UnsubscribeRibbonEvents(Ribbon);
            UnsubscribePanAndZoomEvents();
            UnsubscribeOptionsPanelEvents();
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            UpdateOptionsPanelVisibility();
            if(Ribbon != null)
                BarUtils.ForEachRibbonPageGroup(Ribbon, group => group.Visible = group.ItemLinks.Any(x => x.CanVisible));
            SubscribeRibbonEvents(Ribbon);
            Diagram.OptionsView.ShowPanAndZoomPanel = isPanAndZoomVisible;
            isModuleLoaded = true;
        }
        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if(!isModuleLoaded)
                return;
            canUpdateVisibility = false;
            diagramControl.OptionsView.ShowPanAndZoomPanel = Visible ? isPanAndZoomVisible : false;
            canUpdateVisibility = true;
        }
        void OnPanAndZoomPanelVisibilityChanged(object sender, VisibilityChangedEventArgs e) {
            if(!isModuleLoaded)
                return;
            if(canUpdateVisibility)
                isPanAndZoomVisible = e.Visibility == DockVisibility.Visible;
        }
        void UpdateOptionsPanelVisibility() {
            this.sidePanel.Visible = ShowOptionsPanel;
        }
        void IncludeOptionsPageIfNeeded() {
            if(NeedOptionsPage) {
                if(!tabPane.Controls.Contains(optionsPage)) {
                    this.tabPane.Controls.Add(this.optionsPage);
                    this.tabPane.Pages.AddRange(new NavigationPageBase[] { this.optionsPage });
                }
            }
            else if(tabPane.Controls.Contains(optionsPage)) {
                this.tabPane.Controls.Remove(optionsPage);
                this.tabPane.Pages.Remove(optionsPage);
            }
        }
        protected void LoadDocument(string fileName) {
            string filePath = GetDataFileName(fileName);
            Diagram.LoadDocument(filePath);
        }
        void DoPanAndZoomPanelAction(Action<PanAndZoomDockPanel> action) {
            if(Diagram == null)
                return;
            var panel = Diagram.PanAndZoom as PanAndZoomDockPanel;
            if(panel != null)
                action(panel);
        }
        ObservableCollection<Control> optionsPageControls;
        ObservableCollection<NavigationPageBase> optionsTabPanePages;
        void OptionsPageControls_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                optionsPage.Controls.AddRange(e.NewItems.Cast<Control>().ToArray());
        }
        void OptionsTabPanePages_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                tabPane.Pages.AddRange(e.NewItems.Cast<NavigationPageBase>().ToArray());
        }
        void UnsubscribeOptionsPanelEvents() {
            if(optionsPageControls != null)
                optionsPageControls.CollectionChanged -= OptionsPageControls_CollectionChanged;
            if(optionsTabPanePages != null)
                optionsTabPanePages.CollectionChanged -= OptionsTabPanePages_CollectionChanged;
        }
    }
}

using DevExpress.Skins.XtraForm;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using System;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class PreviewCore : XtraUserControl {
        public PreviewCore() {
            InitializeComponent();
            HtmlImages.Add("logo", DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages["logo"]);
            HintControl.ToolTipController = htmlContentControl1.ToolTipController = Controller;
            InitializeProperties();
            SubscribeEvents();
        }
        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            if(!DesignMode)
                ToolTipPresentationHelper.CenterParent(hostToolTip, Preview);
        }
        HtmlToolTipWindowBase preview;
        protected HtmlToolTipWindowBase Preview {
            get { return preview ?? (preview = new HtmlToolTipWindowBase(Controller)); }
        }
        ToolTipController controller;
        protected ToolTipController Controller {
            get { return controller ?? (controller = CreateToolTipControllerPreview()); }
        }
        protected SvgImageCollection HtmlImages {
            get { return htmlImageCollection; }
        }
        protected ToolTipTemplateViewer TemplateViewer {
            get { return templateViewer; }
        }
        protected XtraUserControl HostToolTip {
            get { return hostToolTip; }
        }
        protected LabelControl HintControl {
            get { return labelControl1; }
        }
        PreviewCoreContentProperties contentProperties;
        protected PreviewCoreContentProperties ContentProperties {
            get {
                if(contentProperties == null) {
                    contentProperties = CreateContentProperties();
                    contentProperties.Dock = DockStyle.Fill;
                    contentProperties.Properties.SelectedObject = HintControl;
                    contentProperties.Properties.CellValueChanged += delegate { RefreshPreview(); };
                }
                return contentProperties;
            }
        }
        protected PreviewCoreControllerProperties ControllerProperties {
            get { return previewCoreProperties1; }
        }
        protected virtual PreviewCoreContentProperties CreateContentProperties() { 
            return new PreviewCoreContentProperties(); 
        }
        protected virtual ToolTipController CreateToolTipControllerPreview() { 
            return new ToolTipController(); 
        }
        protected virtual void InitContent(object tag) {
            ContentProperties.Properties.InvalidateData();
            ControllerProperties.UpdateValues();
        }
        protected virtual ToolTipControlInfo GetToolTipControlInfo() {
            return null;
        }
        void OnControllerGetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) { 
            if(Equals(htmlContentControl1, e.SelectedControl))
                e.Info = GetToolTipControlInfo();
        }
        void InitializeProperties() {
            propertiesPanel.Controls.Add(ContentProperties);
            propertiesPanel.SetColumn(ContentProperties, 0);
            propertiesPanel.SetRow(ContentProperties, 0);
        }
        void SubscribeEvents() {
            TemplateViewer.ActiveTemplateChanged += OnActiveTemplateChanged;
            Preview.HtmlTemplate.PropertyChanged += OnHtmlTemplatePropertyChanged;
            ControllerProperties.PropertyChanged += delegate { RefreshPreview(); };
            Controller.GetActiveObjectInfo += OnControllerGetActiveObjectInfo;
        }
        void OnActiveTemplateChanged(object sender, EventArgs e) {
            InitContent(TemplateViewer.ActiveTemplate.Tag);
            RefreshPreview();
        }
        void OnHtmlTemplatePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            Controller.HtmlTemplate.Assign(TemplateViewer.ActiveTemplate);
        }
        void RefreshPreview() {
            Preview.HtmlTemplate.Assign(TemplateViewer.ActiveTemplate);
            ToolTipPresentationHelper.UpdateViewBounds(HostToolTip, Preview);
            Preview.Invalidate();
        }
    }
}

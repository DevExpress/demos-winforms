using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Rows;

namespace DevExpress.HTML.Demos {
    public partial class PreviewSuperTip : PreviewCore {
        public PreviewSuperTip() {
            InitializeComponent();
            TemplateViewer.Init(Preview, htmlTemplateCollection1);
        }
        protected override PreviewCoreContentProperties CreateContentProperties() {
            return new PreviewSuperTipProperties();
        }
        protected override ToolTipControlInfo GetToolTipControlInfo() {
            var info = new ToolTipControlInfo();
            info.Object = HashCodeHelper.CalculateGeneric<string, string>(Controller.HtmlTemplate.Template, Controller.HtmlTemplate.Styles);
            info.SuperTip = HintControl.SuperTip;
            return info;
        }
        protected override ToolTipController CreateToolTipControllerPreview() {
            var controller = new SuperToolTipControllerPreview(HintControl);
            controller.HtmlImages = HtmlImages;
            ControllerProperties.Initialize(controller, ToolTipType.SuperTip);
            return controller;
        }
        protected override void InitContent(object tag) {
            if(Equals(tag, htmlSimple.Tag)) {
                HintControl.SuperTip = SuperTipTemplate1;
                ControllerProperties.SetVisibleProperties(true, true, false, true, true);
                
            }
            else if(Equals(tag, templateStandardSuperTip.Tag)) {
                HintControl.SuperTip = SuperTipTemplate3;
                ControllerProperties.SetVisibleProperties(true, true, false, true, true);
            }
            base.InitContent(tag);
        }

        SuperToolTip supertipSimple;
        SuperToolTip SuperTipTemplate1 {
            get { 
                if(supertipSimple == null) {
                    supertipSimple = new SuperToolTip();
                    ToolTipTitleItem title = new ToolTipTitleItem();
                    title.Text = "SuperTip";
                    title.Appearance.TextOptions.VAlignment = VertAlignment.Center;
                    title.ImageOptions.SvgImage = HtmlImages["logo"];
                    title.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
                    supertipSimple.Items.Add(title);
                    supertipSimple.Items.AddSeparator();
                    supertipSimple.Items.Add("This is a custom template for Super Tooltips");
                }
                return supertipSimple;
            }
        }

        SuperToolTip supertipStandard;
        SuperToolTip SuperTipTemplate3 {
            get {
                if(supertipStandard == null) {
                    supertipStandard = new SuperToolTip();
                    ToolTipTitleItem title = new ToolTipTitleItem();
                    title.Text = "Standard SuperTip";
                    title.ImageOptions.SvgImage = HtmlImages["logo"];
                    title.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
                    supertipStandard.Items.Add(title);
                    supertipStandard.Items.AddSeparator();
                    supertipStandard.Items.Add("Painted as Standard SuperTip");
                }
                return supertipStandard;
            }
        }
    }

    class SuperToolTipControllerPreview : ToolTipControllerHtmlServiceProvider.ToolTipControllerPreview {
        BaseControl _active;
        public SuperToolTipControllerPreview(BaseControl active) : base(active) {
            this._active = active;
        }
        protected override SuperToolTip GetCurrentSuperToolTip() {
            return _active.SuperTip;
        }
    }

    class PreviewSuperTipProperties : PreviewCoreContentProperties {
        public PreviewSuperTipProperties() {
            Properties.Rows.Add(SuperTipProperty);
        }
        PGridButtonEditorRow SuperTipProperty {
            get {
                PGridButtonEditorRow row = new PGridButtonEditorRow();
                row.Properties.Caption = "SuperTip Items: ";
                row.Properties.FieldName = "SuperTip";
                return row;
            }
        }
    }
}

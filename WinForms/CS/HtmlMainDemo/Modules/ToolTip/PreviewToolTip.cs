using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Rows;
using System;

namespace DevExpress.HTML.Demos {
    public partial class PreviewToolTip : PreviewCore {
        public PreviewToolTip() {
            InitializeComponent();
            TemplateViewer.Init(Preview, htmlTemplateCollection1);
        }
        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            ContentProperties.BestFitHeight();
        }
        protected override PreviewCoreContentProperties CreateContentProperties() {
            return new PreviewToolTipProperties();
        }
        protected override ToolTipControlInfo GetToolTipControlInfo() {
            int hash = HashCodeHelper.CalculateGeneric<string, string>(Controller.HtmlTemplate.Template, Controller.HtmlTemplate.Styles);
            return new ToolTipControlInfo(hash, HintControl.ToolTip, HintControl.ToolTipTitle, HintControl.ToolTipIconType);
        }
        protected override ToolTipController CreateToolTipControllerPreview() {
            var controller = new SimpleToolTipControllerPreview(HintControl);
            controller.HtmlImages = HtmlImages;
            ControllerProperties.Initialize(controller, ToolTipType.Standard);
            return controller;
        }
        new PreviewToolTipProperties ContentProperties {
            get { return ((PreviewToolTipProperties)base.ContentProperties); }
        }
        protected override void InitContent(object tag) {
            if(Equals(tag, templateSimpleToolTip.Tag)) {
                HintControl.ToolTipIconType = ToolTipIconType.None;
                HintControl.ToolTipTitle = "Simple ToolTip";
                HintControl.ToolTip = "This is a regular tooltip (hint)";
                Controller.IconSize = ToolTipIconSize.Small;
                ControllerProperties.SetVisibleProperties(true, true, false, true, true);
                ContentProperties.SetVisibleProperties(false, true, true);
            }
            else if(Equals(tag, templateSimpleToolTipWithButton.Tag)) {
                HintControl.ToolTipIconType = ToolTipIconType.None;
                HintControl.ToolTipTitle = "Modern Design Tooltips";
                HintControl.ToolTip = "Our HTML&CSS Templates allow you to create modern-looking\r\nhints in a matter of minutes.";
                Controller.IconSize = ToolTipIconSize.Large;
                ControllerProperties.SetVisibleProperties(true, true, true, true, true);
                ContentProperties.SetVisibleProperties(false, true, true);
            }
            else if(Equals(tag, templateStandardToolTip.Tag)) {
                HintControl.ToolTipIconType = ToolTipIconType.Information;
                HintControl.ToolTipTitle = "Standard ToolTip";
                HintControl.ToolTip = "Painted as Standard ToolTip";
                Controller.IconSize = ToolTipIconSize.Small;
                ControllerProperties.SetVisibleProperties(true, true, true, true, true);
                ContentProperties.SetVisibleProperties(true, true, true);
            }
            base.InitContent(tag);
        }
    }

    class SimpleToolTipControllerPreview : ToolTipControllerHtmlServiceProvider.ToolTipControllerPreview {
        BaseControl _active;
        public SimpleToolTipControllerPreview(BaseControl active) : base(active) {
            this._active = active;
        }
        protected override string CurrentToolTipTitle => _active.ToolTipTitle;
        protected override string CurrentToolTipText => _active.ToolTip;
        protected override ToolTipIconType CurrentToolTipIconType => _active.ToolTipIconType;
    }

    class PreviewToolTipProperties : PreviewCoreContentProperties {
        public PreviewToolTipProperties() {
            Properties.Rows.Add(ToolTipIconProperty);
            Properties.Rows.Add(ToolTipTitleProperty);
            Properties.Rows.Add(ToolTipTextProperty);
        }
        public void SetVisibleProperties(bool icon, bool title, bool text) {
            ToolTipIconProperty.Visible = icon;
            ToolTipTitleProperty.Visible = title;
            ToolTipTextProperty.Visible = text;
            BestFitHeight();
        }
        public override void BestFitHeight() {
            if(ToolTipTextProperty.Grid == null)
                return;
            ToolTipTextProperty.Height = Properties.ViewInfo.GetVisibleRowHeight(ToolTipTitleProperty) * 3;
        }
        PGridTextEditorRow rowIcon;
        PGridTextEditorRow ToolTipIconProperty {
            get {
                if(rowIcon == null) {
                    rowIcon = new PGridTextEditorRow();
                    rowIcon.Properties.Caption = "ToolTip Icon: ";
                    rowIcon.Properties.FieldName = "ToolTipIconType";
                }
                return rowIcon;
            }
        }

        PGridTextEditorRow rowTitle;
        PGridTextEditorRow ToolTipTitleProperty {
            get {
                if(rowTitle == null) {
                    rowTitle = new PGridTextEditorRow();
                    rowTitle.Properties.Caption = "ToolTip Title: ";
                    rowTitle.Properties.FieldName = "ToolTipTitle";
                }
                return rowTitle;
            }
        }

        PGridTextEditorRow rowText;
        PGridTextEditorRow ToolTipTextProperty {
            get {
                if(rowText == null) {
                    rowText = new PGridTextEditorRow();
                    rowText.Properties.Caption = "ToolTip: ";
                    rowText.Properties.FieldName = "ToolTip";
                    RepositoryItemMemoEdit repo = new RepositoryItemMemoEdit();
                    repo.ScrollBars = System.Windows.Forms.ScrollBars.None;
                    rowText.Properties.RowEdit = repo;
                }
                return rowText;
            }
        }
    }
}

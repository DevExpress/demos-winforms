using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.Utils.Html.ViewInfo;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.WinExplorer;

namespace DevExpress.HTML.Demos {
    public partial class AlertControlModule : TutorialControlBase {
        string previewTemplate;
        string previewStyles;
        public AlertControlModule() {
            InitializeComponent();
            templateViewer.ActiveTemplateChanged += TemplateViewer_ActiveTemplateChanged;
            templateViewer.Init(this.alertControl1);
            alertControlProperties.Init(alertControl1);
            alertControl1.HtmlElementMouseClick += AlertControl1_HtmlElementMouseClick;
            alertControl1.BeforeFormShow += AlertControl1_BeforeFormShow;
            UpdatePreview();
            Timer previewTimer = new Timer();
            previewTimer.Interval = 200;
            previewTimer.Tick += (s, e) => { UpdatePreview(); };
            previewTimer.Start();
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdatePropertiesHeight();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            UpdatePropertiesHeight();
        }

        void UpdatePropertiesHeight() {
            mainPanel.Rows[4].Height = Math.Min(alertControlProperties.GetBestHeight(), mainPanel.Height / 2) / ScaleUtils.ScaleFactor.Height;
        }

        void UpdatePreview() {
            htmlPreview.HtmlImages = alertControl1.HtmlImages;
            AlertInfo newContext = GetCurrentAlertInfo();
            if(htmlPreview.DataContext is AlertInfo)
                UpdateAlertinfo((AlertInfo)htmlPreview.DataContext);
            else htmlPreview.DataContext = GetCurrentAlertInfo();
            HtmlTemplate currentTemlpate = GetCurrentTemplate();
            if(currentTemlpate.Styles != previewStyles || currentTemlpate.Template != previewTemplate) {
                previewStyles = currentTemlpate.Styles;
                previewTemplate = currentTemlpate.Template;
                htmlPreview.HtmlTemplate.Set($"<div class=\"preview-h-container\"><div class=\"preview-v-container\" id=\"previewRoot\">{previewTemplate}</div></div>",
                    $".preview-h-container{{display:flex;flex-direction:row;align-items:center;justify-content: center;height: 100%;}}.preview-v-container{{display:flex;flex-direction:column;}}{previewStyles}");
            }
        }

        private void TemplateViewer_ActiveTemplateChanged(object sender, EventArgs e) {
            InitAlertInfo(templateViewer.ActiveTemplate);
        }

        void InitAlertInfo(HtmlTemplate currentTemplate) {
            if(currentTemplate == glowTemplate)
                alertInfoProperties.Init("Sample Alert", "The color of a glowing effect around this alert box changes depending on the color of the \"Image\" icon", true);
            else if(currentTemplate == toastTemplate)
                alertInfoProperties.Init("Windows 11 Inspired Toast", "Use the selector at the top right corner to change a template. Click the \"Show an Alert\" button to display a notification.", false);
            else if(currentTemplate == simpleTemplate)
                alertInfoProperties.Init("Sample Alert", "Use the selector at the top right corner to change a template. Click the \"Show an Alert\" button to display a notification.", true);
            else if(currentTemplate == darkTemplate)
                alertInfoProperties.Init(null, "Use the selector at the top right corner to change a template. Click the \"Show an Alert\" button to display a notification.", false);
        }

        private void AlertControl1_HtmlElementMouseClick(object sender, AlertHtmlElementMouseEventArgs e) {
            if(e.ElementId == "closeButton" || e.ParentHasId("closeButton") ||
                e.ElementId == "okButton" || e.ParentHasId("okButton"))
                e.HtmlPopup.Close();
            else
                e.HtmlPopup.Pinned = !e.HtmlPopup.Pinned;
        }

        private void AlertControl1_BeforeFormShow(object sender, AlertFormEventArgs e) {
            e.HtmlPopup.HtmlTemplate.Assign(GetCurrentTemplate());
        }

        string GetCurrentSvgImageColor() {
            SvgImage image = alertInfoProperties.SvgImage;
            if(alertInfoProperties.SvgImage == null)
                return null;
            return GetCurrentSvgImageColor(image.Root);
        }
        string GetCurrentSvgImageColor(SvgElement element) {
            if(!String.IsNullOrEmpty(element.Fill))
                return element.StyleName;
            foreach(SvgElement child in element.Elements) {
                string color = GetCurrentSvgImageColor(child);
                if(color != null)
                    return color;
            }
            return null;
        }

        HtmlTemplate GetPatchedGlowTemplate(HtmlTemplate template) {
            string colorName = GetCurrentSvgImageColor();
            if(string.IsNullOrEmpty(colorName))
                return template;
            string styles = template.Styles.Replace("@Black", "@" + colorName);
            return new HtmlTemplate(template.Template, styles);
        }

        HtmlTemplate GetPatchedTemplate(HtmlTemplate template) {
            if(template.Name == glowTemplate.Name)
                return GetPatchedGlowTemplate(template);
            else return template;
        }

        HtmlTemplate GetCurrentTemplate() {
            return GetPatchedTemplate(templateViewer.ActiveTemplate);
        }
        AlertInfo GetCurrentAlertInfo() {
            AlertInfo info = new AlertInfo(null, null);
            alertInfoProperties.UpdateAlertInfo(info);
            return info;
        }

        void UpdateAlertinfo(AlertInfo info) {
            alertInfoProperties.UpdateAlertInfo(info);
        }

        private void ShowAlertButton_Click(object sender, EventArgs e) {
            alertControl1.Show(this.FindForm(), GetCurrentAlertInfo());
        }
    }
}

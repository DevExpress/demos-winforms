using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGantt;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraTreeList;

namespace DevExpress.HTML.Demos {
    public partial class TemplateCodeViewer : XtraUserControl {
        HtmlTemplate currentTemplate = new HtmlTemplate();
        public TemplateCodeViewer() {
            InitializeComponent();
            this.htmlViewer.ReadOnly = false;
            this.htmlViewer.BorderStyle = BorderStyles.NoBorder;
            this.htmlViewer.ScrollBars = ScrollBars.Both;
            this.htmlViewer.AllowCodeFolding = DefaultBoolean.True;
            this.htmlViewer.ShowIndentGuides = DefaultBoolean.True;
            this.htmlViewer.ShowLineNumbers = DefaultBoolean.True;
            this.cssViewer.ReadOnly = false;
            this.cssViewer.BorderStyle = BorderStyles.NoBorder;
            this.cssViewer.ScrollBars = ScrollBars.Both;
            this.cssViewer.AllowCodeFolding = DefaultBoolean.True;
            this.cssViewer.ShowIndentGuides = DefaultBoolean.True;
            this.cssViewer.ShowLineNumbers = DefaultBoolean.True;
        }
        protected void FillEditors(HtmlTemplate template) {
            htmlViewer.Template = template.Template;
            cssViewer.Styles = template.Styles;
        }
        void htmlViewer_CodeChanged(object sender, EventArgs e) {
            UpdateTemplate();
            LayoutChanged();
        }
        protected virtual void UpdateTemplate(int templateIndex, string htmlTemplate, string cssStyles) {
            Templates[templateIndex].Set(htmlTemplate, cssStyles);
        }
        void UpdateTemplate() {
            UpdateTemplate(this.iceTemplates.SelectedIndex, htmlViewer.Template, cssViewer.Styles);
        }
        void cssViewer_CodeChanged(object sender, EventArgs e) {
            UpdateTemplate();
            LayoutChanged();
        }
        void iceTemplates_SelectedIndexChanged(object sender, EventArgs e) {
            currentTemplate.Assign((HtmlTemplate)iceTemplates.EditValue);
            FillEditors(currentTemplate);
        }
        void resetButton_Click(object sender, EventArgs e) {
            switch(this.tabControl.SelectedTabPageIndex) {
                case 0:
                    UpdateHtmlTemplate(this.iceTemplates.SelectedIndex, currentTemplate.Template);
                    htmlViewer.Template = currentTemplate.Template;
                    break;
                case 1:
                    UpdateCssStyle(this.iceTemplates.SelectedIndex, currentTemplate.Styles);
                    cssViewer.Styles = currentTemplate.Styles;
                    break;
            }
            LayoutChanged();
        }
        protected virtual void UpdateHtmlTemplate(int templateIndex, string htmlTemplate) {
            Templates[templateIndex].Template = htmlTemplate;
        }
        protected virtual void UpdateCssStyle(int templateIndex, string cssStyle) {
            Templates[templateIndex].Styles = cssStyle;
        }
        protected virtual void LayoutChanged() {
        }
        protected void AddTemplate(HtmlTemplate template) {
            this.iceTemplates.Properties.Items.Add(new ImageComboBoxItem((string)template.Tag, template, -1));
        }
        protected List<HtmlTemplate> Templates { get; set; }
        protected void FillTemplates(IEnumerable<HtmlTemplate> templates) {
            Templates = new List<HtmlTemplate>();
            foreach(HtmlTemplate template in templates) {
                Templates.Add(template);
                AddTemplate(template);
            }
            if(this.iceTemplates.Properties.Items.Count > 0) {
                this.iceTemplates.EditValue = (HtmlTemplate)this.iceTemplates.Properties.Items[0].Value;
                this.currentTemplate.Assign((HtmlTemplate)this.iceTemplates.EditValue);
                FillEditors(this.currentTemplate);
            }
        }
    }

    public class GanttTemplateCodeViewer : TemplateCodeViewer {
        GanttControl owner;
        public void Fill(GanttControl owner) {
            this.owner = owner;
            FillTemplates(owner.HtmlTemplates);
        }
        protected override void LayoutChanged() {
            this.owner.LayoutChanged();
        }
    }
    public class WinExplorerViewTemplateCodeViewer : TemplateCodeViewer {
        WinExplorerView view;
        public void Fill(WinExplorerView view) {
            this.view = view;
            List<HtmlTemplate> templates = new List<HtmlTemplate>();
            templates.Add(view.OptionsViewStyles.ExtraLarge.HtmlTemplate);
            templates.AddRange(view.HtmlTemplates);
            FillTemplates(templates);
        }
        protected override void LayoutChanged() {
            this.view.LayoutChanged();
        }
    }
    public class AccordionControlTemplateCodeViewer : TemplateCodeViewer {
        AccordionControl accordion;
        public void Fill(AccordionControl accordion, HtmlTemplateCollection collection) {
            this.accordion = accordion;
            List<HtmlTemplate> templates = new List<HtmlTemplate>();
            var props = accordion.HtmlTemplates.GetType().GetProperties();
            foreach(var prop in props) {
                if(prop.PropertyType == typeof(HtmlTemplate)) {
                    HtmlTemplate temp = (HtmlTemplate)prop.GetValue(accordion.HtmlTemplates);
                    if(string.IsNullOrEmpty(temp.Template))
                        continue;
                    temp.Name = prop.Name;
                    temp.Tag = prop.Name;
                    templates.Add(temp);
                }
            }
            if(collection != null)
                templates.AddRange(collection);
            FillTemplates(templates);
        }
        protected override void LayoutChanged() {
            
        }
    }
    public class TileViewTemplateCodeViewer : TemplateCodeViewer {
        TileView view;
        public void Fill(TileView view) {
            this.view = view;
            List<HtmlTemplate> templates = new List<HtmlTemplate>();
            templates.Add(view.TileHtmlTemplate);
            FillTemplates(templates);
        }
        protected override void LayoutChanged() {
            this.view.LayoutChanged();
        }
    }
    public class ListBoxTemplateCodeViewer : TemplateCodeViewer {
        ListBoxControl listBox;
        public void Fill(ListBoxControl listBox, HtmlContentPopup popup) {
            this.listBox = listBox;
            FillTemplates(listBox.HtmlTemplates.Concat(new[] { popup.HtmlTemplate }));
        }
    }
    public class HtmlContentControlCodeViewer : TemplateCodeViewer {
        HtmlContentControl htmlContentControl;
        public HtmlContentControlCodeViewer() : base() {
            lciTemplate.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }
        public void Fill(HtmlContentControl htmlContentControl) {
            this.htmlContentControl = htmlContentControl;
            FillTemplates(new List<HtmlTemplate>() { htmlContentControl.HtmlTemplate });
        }
        public void UpdateHtmlTemplate() {
            UpdateHtmlTemplate(0, htmlContentControl.HtmlTemplate.Template);
            FillEditors(htmlContentControl.HtmlTemplate);
        }
    }
    public class TreeListTemplateCodeViewer : TemplateCodeViewer {
        TreeList treeList;
        public void Fill(TreeList treeList) {
            this.treeList = treeList;
            var templates = new List<HtmlTemplate>();
            templates.Add(treeList.NodeHtmlTemplate);
            templates.AddRange(treeList.HtmlTemplates);
            FillTemplates(templates);
        }
        protected override void LayoutChanged() {
            this.treeList.LayoutChanged();
        }
    }
}

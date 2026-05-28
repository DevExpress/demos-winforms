using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.Diagram.Demos;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTreeList;

namespace DevExpress.XtraDiagram.Demos {
    public partial class OrgChartModule : DiagramTutorialControlBase {
        OrgChartTemplateInfo selectedTemplate;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OrgChartTemplateInfo SelectedTemplate {
            get { return selectedTemplate; }
            set {
                if(value != selectedTemplate) {
                    selectedTemplate = value;
                    diagramOrgChartController1.Refresh();
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OrgChartTemplateInfo[] Templates { get; private set; }
        protected override RibbonControl Ribbon {
            get { return ribbonControl1; }
        }
        public OrgChartModule() {
            InitializeComponent();
            PlaceOptionsPanelControlsWithoutTabPane();
            KeepProportionsOfPanels();
            Diagram.SelectionChanged += DiagramControlSelectionChanged;
            Templates = GetOrgChartTemplates();
            SelectedTemplate = Templates.FirstOrDefault();
            InitTemplatesGallery();
            diagramOrgChartController1.ItemsGenerated += (_o, _e) => FitToItems();
            Load += (_d, _e) => FitToItems();
            employeeBindingSource.DataSource = EmployeesData.FilteredEmployees;
            treeListControl1.ExpandAll();
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            KeepProportionsOfPanels();
        }
        void KeepProportionsOfPanels() {
            if(OptionsSidePanel != null)
                OptionsSidePanel.Size = new Size(Width / 3, OptionsSidePanel.Height);
        }
        void FitToItems() {
            var items = diagramControl.Items
                .OfType<DiagramContainer>()
                .GroupBy(x => x.Y)
                .OrderBy(x => x.Key)
                .Take(3)
                .SelectMany(x => x)
                .ToArray();
            diagramControl.FitToItems(items);
        }
        void GenerateOrgChartItem(object sender, DiagramGenerateItemEventArgs e) {
            if(SelectedTemplate != null)
                e.Item = e.CreateItemFromTemplate(SelectedTemplate.Name);
        }
        #region Galleries
        void InitTemplatesGallery() {
            var group = new GalleryItemGroup();
            foreach(var template in Templates) {
                var item = new GalleryItem();
                item.Caption = template.Name;
                item.Value = template;
                item.Image = template.Image;
                group.Items.Add(item);
            }
            ribbonGalleryBarItem1.Gallery.Groups.Add(group);
        }
        OrgChartTemplateInfo[] GetOrgChartTemplates() {
            var templateNames = diagramOrgChartController1.TemplateDiagram.Items
                .OfType<DiagramContainer>()
                .Select(x => x.TemplateName)
                .ToArray();
#pragma warning disable DX0025 // no path traversal
            var templateImages = templateNames
                .Select(x => string.Format("images/orgchart/{0}.png", x.Replace(" ", string.Empty).ToLower()))
                .Select(x => DiagramDemoFileHelper.GetImageResource(x));
#pragma warning restore DX0025
            return templateNames.Zip(templateImages, (name, image) => new OrgChartTemplateInfo(name, image)).ToArray();
        }
        void TemplatesGalleryItemClick(object sender, GalleryItemClickEventArgs e) {
            SelectedTemplate = (OrgChartTemplateInfo)e.Item.Value;
        }
        void TemplatesGalleryInitDropDownGallery(object sender, InplaceGalleryEventArgs e) {
            e.PopupGallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
        }
        #endregion
        #region Selection
        bool isSelectionLocked = false;
        void TreeListControlFocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            DoLockedSelectionAction(() => {
                Employee selectedEmployee = treeListControl1.GetDataRecordByNode(e.Node) as Employee;
                DiagramItem diagramItem = null;
                if(selectedEmployee != null)
                    diagramItem = diagramControl.Items.FirstOrDefault(x => x.DataContext == selectedEmployee);
                if(diagramItem != null) {
                    diagramControl.SelectItem(diagramItem);
                    diagramControl.BringItemsIntoView(new[] { diagramItem });
                }
                else {
                    diagramControl.ClearSelection();
                }
            });
        }
        void DiagramControlSelectionChanged(object sender, DiagramSelectionChangedEventArgs e) {
            DoLockedSelectionAction(() => {
                Employee selectedEmployee = null;
                if(diagramControl.PrimarySelection != null && diagramControl.PrimarySelection.DataContext is Employee)
                    selectedEmployee = (Employee)diagramControl.PrimarySelection.DataContext;
                if(selectedEmployee != null)
                    treeListControl1.FocusedNode = treeListControl1.FindNodeByKeyID(selectedEmployee.Id);
                else
                    treeListControl1.FocusedNode = null;
            });
        }
        void DoLockedSelectionAction(Action action) {
            if(isSelectionLocked)
                return;
            isSelectionLocked = true;
            action();
            isSelectionLocked = false;
        }
        #endregion
    }
    public class OrgChartTemplateInfo {
        public string Name { get; private set; }
        public Image Image { get; private set; }
        public OrgChartTemplateInfo(string name, Image image) {
            this.Name = name;
            this.Image = image;
        }
    }
}

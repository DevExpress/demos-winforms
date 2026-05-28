using System.ComponentModel;
using System.Drawing;
using DevExpress.Diagram.Core;
using DevExpress.Diagram.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Serializing;

namespace DevExpress.XtraDiagram.Demos {
    public partial class CustomShapesModule : DocumentModuleBase {
        public CustomShapesModule() {
            InitializeComponent();
            diagramControl.CustomGetEditableItemProperties += DiagramControl_CustomGetEditableItemProperties;
            diagramControl.CustomDrawItem += this.DiagramControl_CustomDrawItem;
            InitializeStencils();
        }
        protected override string DocumentName {
            get { return "CustomShapesDocument_Win.xml"; }
        }
        DiagramStencil svgStencil;
        DiagramStencil customShapesStencil;
        DiagramStencil customDrawShapesStencil;

        void InitializeStencils() {
            this.customShapesStencil = DemoHelper.CreateStencilFromFile(GetDataFileName("CustomShapes.xml"), "CustomShapes", "Custom Shapes");
            this.svgStencil = DemoHelper.CreatePredefinedSvgStencil("SvgShapes", "Svg Shapes");
            this.customDrawShapesStencil = CreateCustomDrawShapesStencil();
            diagramControl.OptionsBehavior.Stencils = DemoHelper.CreateExtendedStencilCollection(svgStencil, customShapesStencil, customDrawShapesStencil);
        }
        DiagramStencil CreateCustomDrawShapesStencil() {
            var stencilId = "CustomDrawShapes";
            DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
            var stencil = new DiagramStencil(stencilId, "Custom Draw Shapes", false);
            var shapeSize = new System.Windows.Size(150, 100);
            stencil.RegisterTool(new FactoryItemTool("activeTaskShape", () => "Active Task", diagram => new DiagramShapeEx { Content = "Active Task", Status = Status.Active }, shapeSize));
            stencil.RegisterTool(new FactoryItemTool("inactiveTaskShape", () => "Inactive Task", diagram => new DiagramShapeEx { Content = "Inactive Task", Status = Status.Inactive }, shapeSize));
            return stencil;
        }
        void DiagramControlItemInitializing(object sender, DiagramItemInitializingEventArgs e) {
            DemoHelper.InitializeSvgShape(svgStencil, e.Item as IDiagramShape);
        }
        void DiagramControl_CustomGetEditableItemProperties(object sender, DiagramCustomGetEditableItemPropertiesEventArgs e) {
            if(e.Item is DiagramShapeEx)
                e.Properties.Add(TypeDescriptor.GetProperties(typeof(DiagramShapeEx))["Status"]);
        }
        void ToolTipController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.SelectedControl != diagramControl)
                return;
            ToolTipControlInfo toolTipInfo = null;
            var item = diagramControl.CalcHitItem(e.ControlMousePosition);
            if(item != null && item.Tag != null)
                toolTipInfo = new ToolTipControlInfo(item, item.Tag.ToString());
            if(toolTipInfo != null)
                e.Info = toolTipInfo;
        }
        void DiagramControl_CustomDrawItem(object sender, CustomDrawItemEventArgs e) {
            var shape = e.Item as DiagramShapeEx;
            if(shape == null)
                return;
            e.DefaultDraw();
            var imagePath = shape.Status == Status.Active ? "images/actions/apply_16x16.png" : "images/actions/cancel_16x16.png";
            var image = DevExpress.Images.ImageResourceCache.Default.GetImage(imagePath);
            var margin = 3f;
            e.GraphicsCache.DrawImage(image, new RectangleF(shape.Width - image.Width - margin, shape.Height - image.Height - margin, image.Width, image.Height));
            e.Handled = true;
        }
    }
    public class DiagramShapeEx : DiagramShape {
        [XtraSerializableProperty, Category("Info")]
        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;
    }
    public enum Status { Active, Inactive }
}

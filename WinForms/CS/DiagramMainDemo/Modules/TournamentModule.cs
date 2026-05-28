using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Routing;
using DevExpress.Diagram.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.XtraDiagram.Demos {
    public partial class TournamentModule : DiagramTutorialControl {
        readonly Brush backgroundBrush = new SolidBrush(Color.FromArgb(0x27, 0x50, 0x83));

        public TournamentModule() : base(false, false) {
            var viewModel = new TournamentViewModel();
            InitializeComponent();
            SubscribeDiagramEvents();
            (diagramControl as IDiagramControl).Controller.RegisterRoutingStrategy(ConnectorType.RightAngle, new RightAngleRoutingStrategy() { ItemMargin = (int)this.diagramControl.OptionsTreeLayout.HorizontalSpacing / 2 });
            diagramDataBindingController1.BeginInit();
            tournamentsBindingSource.DataSource = viewModel.Games;
            relationshipInfoBindingSource.DataSource = viewModel.Relationships;
            diagramDataBindingController1.EndInit();
            diagramControl.FitToDrawing();
        }
        void SubscribeDiagramEvents() {
            this.diagramControl.ItemContentChanged += DiagramControl_ItemContentChanged;
            this.diagramControl.MouseDoubleClick += DiagramControl_MouseDoubleClick;
            this.diagramControl.CustomDrawBackground += DiagramControl_CustomDrawBackground;
        }
        void DiagramControl_CustomDrawBackground(object sender, CustomDrawBackgroundEventArgs e) {
            e.GraphicsCache.FillRectangle(backgroundBrush, e.TotalBounds);
        }

        void DiagramControl_MouseDoubleClick(object sender, MouseEventArgs e) {
            var clickedItem = diagramControl.CalcHitItem(e.Location) as DiagramItem;
            if(clickedItem == null)
                return;

            var commandContainer = clickedItem.ParentItem as DiagramContainer;
            if(commandContainer != null) {
                var resultShape = commandContainer.Items.OfType<DiagramShape>().LastOrDefault();
                if(resultShape != null) {
                    diagramControl.SelectItem(resultShape);
                    diagramControl.Commands.Execute(DiagramCommandsBase.EditCommand);
                }
            }
        }
        void DiagramControl_ItemContentChanged(object sender, DiagramItemContentChangedEventArgs e) {
            int newValue = 0;
            if(!int.TryParse(e.NewValue, out newValue)) {
                XtraMessageBox.Show("The value should be a number.", "Invalid value");
                var shape = e.Item as DiagramShape;
                if(shape != null)
                    shape.Content = e.OldValue;
            }
        }
    }
}

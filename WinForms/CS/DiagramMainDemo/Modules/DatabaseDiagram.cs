using DevExpress.Data.Filtering;
using DevExpress.Diagram.Core;
using DevExpress.Diagram.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace DevExpress.XtraDiagram.Demos {
    public partial class DatabaseDiagram : DiagramTutorialControlBase {
        DatabaseDefinition Database { get; set; }
        TableRelationEvaluationOperator evaluationOperator;
        readonly SvgBitmap PropertyImage;
        readonly SvgBitmap IdImage;

        protected override bool PanAndZoomVisibleOnInitialized { get { return true; } }

        public DatabaseDiagram() {
            evaluationOperator = new TableRelationEvaluationOperator();
            CriteriaOperator.RegisterCustomFunction(evaluationOperator);
            Database = DatabaseData.GetDatabaseDefinition();
            IdImage = LoadSvgImage("Images/DatabaseDiagram/id.svg");
            PropertyImage = LoadSvgImage("Images/DatabaseDiagram/property.svg");
            InitializeComponent();
            diagramControl.OptionsView.FitToDrawingMargin = new System.Windows.Forms.Padding(50);
            diagramControl.CustomDrawItem += this.diagramControl_CustomDrawItem;
            InitializeDataBindingController();
        }
        ~DatabaseDiagram() {
            CriteriaOperator.UnregisterCustomFunction(evaluationOperator);
        }

        void InitializeDataBindingController() {
            diagramDataBindingController1.ConnectorToMember = "To";
            diagramDataBindingController1.ConnectorFromMember = "From";
            diagramDataBindingController1.KeySelector = new DatabaseDefinitionKeySelector();
            diagramDataBindingController1.ItemsPath = "Columns";
            diagramDataBindingController1.DataSource = Database.Tables;
            diagramDataBindingController1.ConnectorsSource = Database.Connections;
        }

        void diagramControl_CustomDrawItem(object sender, CustomDrawItemEventArgs e) {
            var column = e.Item.DataContext as ColumnDefinition;
            if(column == null || e.Item.Tag == null)
                return;
            var image = column.IsPrimaryKey ? IdImage : PropertyImage;
            var state = e.GraphicsCache.Paint.SaveCacheState(e.GraphicsCache);
            try {
                e.GraphicsCache.SmoothingMode = SmoothingMode.AntiAlias;
                var imageSize = image.GetBounds().Size;
                e.GraphicsCache.ScaleTransform((float)e.Item.Width / imageSize.Width, (float)e.Item.Height / imageSize.Height);
                using(var svgCache = new GraphicsCacheSvgWrapper(e.GraphicsCache)) {
                   image.RenderToSvgGraphics(svgCache);
                }
            } finally {
                e.GraphicsCache.Paint.RestoreCacheState(e.GraphicsCache, state);
            }
        }
        void diagramDataBindingController1_GenerateItem(object sender, DiagramGenerateItemEventArgs e) {
            if(e.DataObject is TableDefinition)
                e.Item = CreateTableItem();
            else
                e.Item = CreateColumnItem();
        }
        void diagramDataBindingController1_GenerateConnector(object sender, DiagramGenerateConnectorEventArgs e) {
            e.Connector = CreateConnectionItem();
        }
        void diagramDataBindingController1_ItemsGenerated(object sender, DiagramItemsGeneratedEventArgs e) {
            diagramControl.FitToDrawing();
            diagramControl.OptionsView.ZoomFactor = 1.0f;
            diagramControl.OptionsProtection.IsReadOnly = true;
            diagramControl.OptionsBehavior.SelectionMode = SelectionMode.None;
        }

        static DiagramList CreateTableItem() {
            var stack = new DiagramList {
                ShowHeader = true, Width = 200,
                DragMode = ContainerDragMode.ByAnyPoint,
                Shape = StandardContainers.Classic,
                AffectedByLayoutAlgorithms = false,
                CanCollapse = true,
            };

            stack.Bindings.Add(new DiagramBinding("Header", "Name"));
            stack.Bindings.Add(new DiagramBinding("X", "PositionX"));
            stack.Bindings.Add(new DiagramBinding("Y", "PositionY"));

            stack.Appearance.BorderSize = 2;
            stack.Appearance.Font = new Font(stack.Appearance.Font.FontFamily, 16);
            return stack;
        }
        static DiagramItem CreateColumnItem() {
            var imageItem = new DiagramShape { X = 4, Y = 2, Width = 21, Height = 21, Tag = true, CanSnapToThisItem = false };
            imageItem.Appearance.BorderSize = 0;
            imageItem.Appearance.BackColor = Color.Transparent;

            var contentItem = new DiagramShape {
                X = 27,
                Width = 173, Height = 25,
                CanSnapToThisItem = false,
            };
            contentItem.Appearance.BorderSize = 0;
            contentItem.Appearance.BackColor = Color.Transparent;
            contentItem.Appearance.ForeColor = Color.Black;
            contentItem.Appearance.Font = new Font(contentItem.Appearance.Font.FontFamily, 14);
            contentItem.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            contentItem.Bindings.Add(new DiagramBinding("Content", "Name"));

            var connectionPoints = new List<PointFloat> {
                new PointFloat(0, 0.5f),
                new PointFloat(1, 0.5f)
            };
            var columnItem = new DiagramContainer {
                Height = 30,
                ConnectionPoints = new PointCollection(connectionPoints),
                CanSnapToThisItem = false,
            };
            columnItem.Items.Add(imageItem);
            columnItem.Items.Add(contentItem);
            columnItem.Appearance.BorderSize = 0;
            return columnItem;
        }
        static DiagramConnector CreateConnectionItem() {
            var connector = new DiagramConnector {
                CanEdit = false,
                CanDragBeginPoint = false,
                CanChangeRoute = false,
                CanDragEndPoint = false,
                Type = ConnectorType.RightAngle,
                BeginLabelArrowOffset = 4,
            };

            connector.Bindings.Add(new DiagramBinding("BeginLeftLabel", "TableRelation([FromRelation])"));
            connector.Bindings.Add(new DiagramBinding("EndLeftLabel", "TableRelation([ToRelation])"));
            connector.Appearance.BorderSize = 2;
            connector.Appearance.Font = new Font(connector.Appearance.Font.FontFamily, 13);
            return connector;
        }
        SvgBitmap LoadSvgImage(string svgPath) {
            return new SvgBitmap(DiagramDemoFileHelper.GetSvgImageResource(svgPath));
        }
    }
}

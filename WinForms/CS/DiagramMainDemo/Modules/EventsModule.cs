using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Diagram.Core;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.XtraDiagram.Demos {
    public partial class EventsModule : DocumentModuleBase {
        public EventsModule() {
            SetUpOptionsPanel();
            InitializeComponent();
            diagramControl.DocumentLoaded += OnDiagramControlDocumentLoaded;
        }
        void OnDiagramControlDocumentLoaded(object sender, DiagramDocumentLoadedEventArgs e) {
            diagramControl.DocumentLoaded -= OnDiagramControlDocumentLoaded;
            trackedEvents.DataSource = new DiagramEventsInfo(diagramControl, AddToLog).Initialize();
            trackedEvents.ExpandAll();
        }
        void SetUpOptionsPanel() {
            ShowOptionsPanel = true;
            NeedOptionsPage = false;
        }
        protected override string DocumentName { get { return "Events.xml"; } }

        readonly List<LogEntry> log = new List<LogEntry>();
        readonly List<LogEntry> lines = new List<LogEntry>();
        const int LogEntriesMaxCount = 100;

        void AddToLog(string eventName, string argsFormat, params object[] args) {
            var logEntry = new LogEntry(eventName, string.Format(argsFormat, args));
            log.Add(logEntry);
            lines.Add(logEntry);
            lines.AddRange(Enumerable.Range(0, GetLinesCount(logEntry) - 1).Select(x => (LogEntry)null));
            if(log.Count > LogEntriesMaxCount) {
                lines.RemoveRange(0, GetLinesCount(log[0]));
                log.RemoveAt(0);
            }
            UpdateLog();
            eventsLogPanel.AutoScrollPosition = new Point(0, eventsLogPanel.VerticalScroll.Maximum);
        }
        void UpdateLog() {
            eventsLog.Text = string.Join("\r\n", log.Select(x => GetText(x)).ToArray());
        }
        static int GetLinesCount(LogEntry e) { return string.IsNullOrEmpty(e.EventArgs) ? 1 : 2; }
        string GetText(LogEntry e) {
            var highlight = e == highlighedEntry;
            var href1 = highlight ? "<href>" : "";
            var href2 = highlight ? "</href>" : "";
            return href1 + "<b>" + e.EventName + "</b>" + href2 + (string.IsNullOrEmpty(e.EventArgs) ? "" : "\r\n      " + e.EventArgs);
        }
        void OnTrackedEventsVirtualTreeGetChildNodes(object sender, VirtualTreeGetChildNodesInfo e) {
            e.Children = ((DiagramEventNode)e.Node).Children;
        }
        void OnTrackedEventsVirtualTreeGetCellValue(object sender, VirtualTreeGetCellValueInfo e) {
            var node = (DiagramEventNode)e.Node;
            if(e.IsCheckState)
                e.CellData = node.IsChecked;
            else if(e.Column == colTitle)
                e.CellData = node.Title;
        }
        void OnTrackedEventsVirtualTreeSetCellValue(object sender, VirtualTreeSetCellValueInfo e) {
            if(e.IsCheckState)
                ((DiagramEventNode)e.Node).IsChecked = (bool?)e.NewCellData;
        }
        void OnClearLogButtonClick(object sender, EventArgs e) {
            log.Clear();
            lines.Clear();
            eventsLog.Text = string.Empty;
        }
        void OnTrackedEventsNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e) {
            if(e.Node == highlightedNode) {
                e.Appearance.FontStyleDelta = FontStyle.Underline;
                e.Appearance.ForeColor = Color.FromArgb(14, 112, 192);
                return;
            }
            var data = (DiagramEventNode)trackedEvents.GetDataRecordByNode(e.Node);
            if(data.Kind == DiagramEventNodeKind.Group)
                e.Appearance.FontStyleDelta = FontStyle.Bold;
        }
        TreeListNode highlightedNode;
        void HighlightNode(TreeListNode newHighlightedNode) {
            if(newHighlightedNode != highlightedNode) {
                var oldHighlightedNode = highlightedNode;
                highlightedNode = newHighlightedNode;
                if(oldHighlightedNode != null)
                    trackedEvents.RefreshNode(oldHighlightedNode);
                if(newHighlightedNode != null)
                    trackedEvents.RefreshNode(newHighlightedNode);
                trackedEvents.Cursor = newHighlightedNode == null ? Cursors.Default : Cursors.Hand;
            }
        }
        void OnTrackedEventsMouseMove(object sender, MouseEventArgs e) {
            HighlightNode(CalcHitNode(e));
        }
        TreeListNode CalcHitNode(MouseEventArgs e) {
            var hitInfo = trackedEvents.CalcHitInfo(e.Location);
            if(hitInfo.HitInfoType != HitInfoType.Cell) return null;
            var data = (DiagramEventNode)trackedEvents.GetDataRecordByNode(hitInfo.Node);
            if(data.Kind != DiagramEventNodeKind.EventNode) return null;
            var rect = hitInfo.HitTest.CellInfo.CellValueRect;
            rect.Width = MeasureText(hitInfo.Node.GetDisplayText(hitInfo.Column), hitInfo.Column.AppearanceCell.Font, hitInfo.Column.AppearanceCell.GetStringFormat(), rect.Width, trackedEvents.ViewInfo.GInfo);
            if(!rect.Contains(e.Location)) return null;
            return hitInfo.Node;
        }
        static int MeasureText(string text, Font font, StringFormat stringFormat, int width, GraphicsInfo gInfo) {
            gInfo.AddGraphics(null);
            try {
                return (int)(gInfo.Cache.CalcTextSize(text, font, stringFormat, width).Width + font.SizeInPoints / 2f);
            } finally {
                gInfo.ReleaseGraphics();
            }
        }

        void OnTrackedEventsMouseLeave(object sender, EventArgs e) {
            HighlightNode(null);
        }
        void OnTrackedEventsClick(object sender, EventArgs e) {
            if(highlightedNode == null) return;
            var data = (DiagramEventNode)trackedEvents.GetDataRecordByNode(highlightedNode);
            DevExpress.Data.Utils.SafeProcess.Start("https://documentation.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl." + data.Title + ".event");
        }
        LogEntry highlighedEntry;
        void HighlightEntry(LogEntry newHighlihnedEntry) {
            if(newHighlihnedEntry != highlighedEntry) {
                highlighedEntry = newHighlihnedEntry;
                UpdateLog();
                eventsLog.Cursor = newHighlihnedEntry == null ? Cursors.Default : Cursors.Hand;
            }
        }
        LogEntry CalcHitEntry(MouseEventArgs e) {
            var highlighedLine = e.Y * lines.Count / eventsLog.Height;
            if(highlighedLine < 0 || highlighedLine >= lines.Count)
                return null;
            var line = lines[highlighedLine];
            if(line == null) return null;
            var lineWidth = MeasureText(line.EventName, new Font(eventsLog.Appearance.GetFont(), FontStyle.Bold), eventsLog.Appearance.GetStringFormat(), eventsLog.Width, Diagram.DiagramViewInfo.GInfo);
            return e.Location.X < eventsLog.Padding.Left || e.Location.X > lineWidth ? null : line;
        }
        void OnEventsLogMouseMove(object sender, MouseEventArgs e) {
            HighlightEntry(CalcHitEntry(e));
        }
        void OnEventsLogMouseLeave(object sender, EventArgs e) {
            HighlightEntry(null);
        }
        void OnEventsLogHyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e) {
            Data.Utils.SafeProcess.Start("https://documentation.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl." + e.Text + ".event");
        }
    }
    public sealed class LogEntry {
        public LogEntry(string eventName, string eventArgs) {
            EventName = eventName;
            EventArgs = eventArgs;
        }
        public readonly string EventName;
        public readonly string EventArgs;
    }
    public enum DiagramEventNodeKind {
        Root,
        Group,
        EventNode,
        Parameter
    }
    public sealed class DiagramEventNode {
        public DiagramEventNode(string title, bool? isChecked, DiagramEventNodeKind kind) {
            this.title = title;
            this.kind = kind;
            IsChecked = isChecked;
        }
        readonly string title;
        public string Title { get { return title; } }
        readonly DiagramEventNodeKind kind;
        public DiagramEventNodeKind Kind { get { return kind; } }
        public bool? IsChecked { get; set; }
        public bool ActualIsChecked { get { return IsChecked.HasValue && IsChecked.Value; } }
        public DiagramEventNode Parent { get; private set; }
        readonly List<DiagramEventNode> children = new List<DiagramEventNode>();
        public List<DiagramEventNode> Children { get { return children; } }
        public void AddChild(DiagramEventNode child) {
            child.Parent = this;
            children.Add(child);
        }
    }
    public sealed class DiagramEventsInfo {
        static readonly EventArgInfo<ItemsActionKind> EAction = new EventArgInfo<ItemsActionKind>(
            "Action",
            EnumArgValues(new[] { ItemsActionKind.Move, ItemsActionKind.MoveCopy, ItemsActionKind.Resize, ItemsActionKind.Rotate, ItemsActionKind.Copy, ItemsActionKind.Delete }, x => false)
        );
        static readonly EventArgInfo<DiagramActionStage> EStage = new EventArgInfo<DiagramActionStage>(
            "Stage",
            EnumArgValues(new[] { DiagramActionStage.Start, DiagramActionStage.Continue, DiagramActionStage.Finished, DiagramActionStage.Canceled }, x => x != DiagramActionStage.Continue)
        );
        static readonly EventArgInfo<ConnectorPointType> EConnectorPointType = new EventArgInfo<ConnectorPointType>(
            "ConnectorPointType",
            EnumArgValues(new[] { ConnectorPointType.Begin, ConnectorPointType.End }, x => x == ConnectorPointType.End)
        );
        static readonly EventArgInfo<DiagramConnector> EConnector = new EventArgInfo<DiagramConnector>(
            "Connector",
            new[] { new EventArgValueInfo<DiagramConnector>(x => "e.Connector.GetDiagram() is null", null, x => x.GetDiagram() == null), new EventArgValueInfo<DiagramConnector>(x => "e.Connector.GetDiagram() is not null", true, x => x.GetDiagram() != null) }
        );
        static readonly EventArgInfo<ItemUsage> EItemUsage = new EventArgInfo<ItemUsage>(
            "ItemUsage",
            EnumArgValues(new[] { ItemUsage.Diagram, ItemUsage.ToolboxPreview }, x => x == ItemUsage.Diagram)
        );

        DiagramControl eventsOwner;
        Action<string, string, object[]> addToLog;

        public DiagramEventsInfo(DiagramControl eventsOwner, Action<string, string, object[]> addToLog) {
            this.eventsOwner = eventsOwner;
            this.addToLog = addToLog;
        }
        public DiagramEventNode Initialize() {
            var groups = new DiagramEventNode("", true, DiagramEventNodeKind.Root);
            var behaviorGroup = new DiagramEventNode("Behavior", null, DiagramEventNodeKind.Group);
            groups.AddChild(behaviorGroup);
            behaviorGroup.AddChild(Initialize<DiagramCustomCursorEventArgs>("CustomCursor", false, ""));
            behaviorGroup.AddChild(Initialize<DiagramCustomItemDragEventArgs>("CustomItemDrag", true, ""));
            behaviorGroup.AddChild(Initialize<DiagramCustomItemDragResultEventArgs>("CustomItemDragResult", true, "Result = {0}", e => e.Result));
            behaviorGroup.AddChild(Initialize<DiagramCustomItemGiveFeedbackEventArgs>("CustomItemGiveFeedback", false, ""));
            behaviorGroup.AddChild(Initialize<DiagramCustomItemQueryContinueDragEventArgs>("CustomItemQueryContinueDrag", false, ""));
            behaviorGroup.AddChild(Initialize<DiagramActiveToolChangedEventArgs>("ActiveToolChanged", true, "OldTool = {0}, NewTool = {1}", e => e.OldTool, e => e.NewTool));
            var diagramGroup = new DiagramEventNode("Diagram Document", null, DiagramEventNodeKind.Group);
            groups.AddChild(diagramGroup);
            diagramGroup.AddChild(Initialize<DiagramCanvasBoundsChangedEventArgs>("CanvasBoundsChanged", false, "OldBounds = {{ {0} }}, NewBounds = {{ {1} }}", e => e.OldBounds, e => e.NewBounds));
            diagramGroup.AddChild(Initialize<DiagramCustomLoadDocumentEventArgs>("CustomLoadDocument", true, ""));
            diagramGroup.AddChild(Initialize<DiagramCustomSaveDocumentEventArgs>("CustomSaveDocument", true, ""));
            diagramGroup.AddChild(Initialize<DiagramDocumentLoadedEventArgs>("DocumentLoaded", true, ""));
            diagramGroup.AddChild(Initialize<DiagramShowingOpenDialogEventArgs>("ShowingOpenDialog", true, ""));
            diagramGroup.AddChild(Initialize<DiagramShowingSaveDialogEventArgs>("ShowingSaveDialog", true, ""));
            var itemsGroup = new DiagramEventNode("Diagram Items", null, DiagramEventNodeKind.Group);
            groups.AddChild(itemsGroup);
            itemsGroup.AddChild(Initialize<DiagramAddingNewItemEventArgs>("AddingNewItem", true, "Item is {0}, Parent is {1}", e => e.Item.GetType().Name, e => e.Parent.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramBeforeItemsMovingEventArgs>("BeforeItemsMoving", true, "ActionSource = {0}", e => e.ActionSource));
            itemsGroup.AddChild(Initialize<DiagramBeforeItemsResizingEventArgs>("BeforeItemsResizing", true, "ActionSource = {0}", e => e.ActionSource));
            itemsGroup.AddChild(Initialize<DiagramBeforeItemsRotatingEventArgs>("BeforeItemsRotating", true, "ActionSource = {0}", e => e.ActionSource));
            itemsGroup.AddChild(Initialize<DiagramClosedEditorEventArgs>("ClosedEditor", true, "Item is {0}", e => e.Item.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramConnectionChangingEventArgs>("ConnectionChanging", true, "PointType = {0}", e => e.ConnectorPointType));
            itemsGroup.AddChild(Initialize<DiagramConnectionChangedEventArgs>("ConnectionChanged", true, "PointType = {0}", e => e.ConnectorPointType));
            itemsGroup.AddChild(Initialize<DiagramCustomGetEditableItemPropertiesEventArgs>("CustomGetEditableItemProperties", true, "Item is {0}", e => e.Item.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramCustomGetEditableItemPropertiesCacheKeyEventArgs>("CustomGetEditableItemPropertiesCacheKey", false, "Item is {0}", e => e.Item.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramCustomGetSerializableItemPropertiesEventArgs>("CustomGetSerializableItemProperties", true, "ItemType = {0}", e => e.ItemType.Name));
            itemsGroup.AddChild(Initialize<DiagramCustomLoadImageEventArgs>("CustomLoadImage", true, ""));
            itemsGroup.AddChild(Initialize<DiagramItemBoundsChangedEventArgs>("ItemBoundsChanged", false, ""));
            itemsGroup.AddChild(Initialize<DiagramItemContentChangedEventArgs>("ItemContentChanged", true, "OldValue = {0}, NewValue = {1}", e => e.OldValue, e => e.NewValue));
            itemsGroup.AddChild(Initialize<DiagramItemCreatingEventArgs, ItemUsage>("ItemCreating", null, EItemUsage, "ItemType = {0}, ItemUsage = {1}", e => e.ItemType.Name, e => e.ItemUsage));
            itemsGroup.AddChild(Initialize<DiagramItemDrawingEventArgs, DiagramActionStage>("ItemDrawing", null, EStage, "Tool = {0}, Stage = {1}", e => e.Tool.ToolName, e => e.Stage));
            itemsGroup.AddChild(Initialize<DiagramItemInitializingEventArgs, ItemUsage>("ItemInitializing", null, EItemUsage, "Item is {0}, ItemUsage = {1}", e => e.Item.GetType().Name, e => e.ItemUsage));
            itemsGroup.AddChild(Initialize<DiagramItemsChangedEventArgs>("ItemsChanged", true, "Action = {0}", e => e.Action));
            itemsGroup.AddChild(Initialize<DiagramItemsDeletingEventArgs>("ItemsDeleting", true, ""));
            itemsGroup.AddChild(Initialize<DiagramItemsMovingEventArgs, DiagramActionStage>("ItemsMoving", null, EStage, "Stage = {0}, ActionSource = {1}", e => e.Stage, e => e.ActionSource));
            itemsGroup.AddChild(Initialize<DiagramItemsPastingEventArgs>("ItemsPasting", true, ""));
            itemsGroup.AddChild(Initialize<DiagramItemsResizingEventArgs, DiagramActionStage>("ItemsResizing", null, EStage, "Stage = {0}, ActionSource = {1}", e => e.Stage, e => e.ActionSource));
            itemsGroup.AddChild(Initialize<DiagramItemsRotatingEventArgs, DiagramActionStage>("ItemsRotating", null, EStage, "Stage = {0}, ActionSource = {1}", e => e.Stage, e => e.ActionSource));
            itemsGroup.AddChild(Initialize<DiagramQueryConnectionPointsEventArgs, ConnectorPointType, DiagramConnector>("QueryConnectionPoints", null, EConnectorPointType, EConnector, "ConnectorPointType = {0}, HoveredItem is {1}", e => e.ConnectorPointType, e => e.HoveredItem.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramQueryItemDrawActionEventArgs>("QueryItemDrawAction", false, "Tool = {0}", e => e.Tool.ToolName));
            itemsGroup.AddChild(Initialize<DiagramQueryItemEditActionEventArgs>("QueryItemEditAction", true, "Item is {0}", e => e.Item.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramQueryItemSnappingEventArgs>("QueryItemSnapping", false, "Item is {0}, SnapTo is {1}", e => e.Item.GetType().Name, e => e.SnapTo.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramQueryItemsActionEventArgs, ItemsActionKind>("QueryItemsAction", false, EAction, "Action = {0}", e => e.Action));
            itemsGroup.AddChild(Initialize<DiagramShowingEditorEventArgs>("ShowingEditor", true, "Item is {0}", e => e.Item.GetType().Name));
            itemsGroup.AddChild(Initialize<DiagramShowingOpenImageDialogEventArgs>("ShowingOpenImageDialog", true, ""));
            var propertiesGroup = new DiagramEventNode("Diagram Property Changed", null, DiagramEventNodeKind.Group);
            groups.AddChild(propertiesGroup);
            propertiesGroup.AddChild(Initialize<DiagramSelectionChangedEventArgs>("SelectionChanged", true, ""));
            propertiesGroup.AddChild(Initialize<DiagramZoomFactorChangedEventArgs>("ZoomFactorChanged", false, "OldValue = {0:0 %}, NewValue = {1:0 %}", e => e.OldValue, e => e.NewValue));
            var subordinatesGroup = new DiagramEventNode("Expand And Collapse", true, DiagramEventNodeKind.Group);
            groups.AddChild(subordinatesGroup);
            subordinatesGroup.AddChild(Initialize<DiagramSubordinatesHiddenEventArgs>("SubordinatesHidden", true, ""));
            subordinatesGroup.AddChild(Initialize<DiagramSubordinatesHidingEventArgs>("SubordinatesHiding", true, ""));
            subordinatesGroup.AddChild(Initialize<DiagramSubordinatesShowingEventArgs>("SubordinatesShowing", true, ""));
            subordinatesGroup.AddChild(Initialize<DiagramSubordinatesShownEventArgs>("SubordinatesShown", true, ""));
            var layoutGroup = new DiagramEventNode("Layout", true, DiagramEventNodeKind.Group);
            groups.AddChild(layoutGroup);
            layoutGroup.AddChild(Initialize<DiagramRelayoutItemsCompletedEventArgs>("RelayoutItemsCompleted", true, ""));
            return groups;
        }

        static IEnumerable<EventArgValueInfo<TArg>> EnumArgValues<TArg>(IEnumerable<TArg> values, Func<TArg, bool> isChecked) {
            return values.Select(value => new EventArgValueInfo<TArg>(x => "e." + x + " = " + value.ToString(), isChecked(value), x => Equals(x, value))).ToArray();
        }
        sealed class EventArgValueInfo<TArg> {
            public EventArgValueInfo(Func<string, string> title, bool? isChecked, Func<TArg, bool> isValue) {
                Title = title;
                IsValue = isValue;
                IsChecked = isChecked;
            }
            public readonly Func<string, string> Title;
            public Func<TArg, bool> IsValue;
            public readonly bool? IsChecked;
        }
        sealed class EventArgInfo<TArg> {
            public EventArgInfo(string title, IEnumerable<EventArgValueInfo<TArg>> values) {
                Title = title;
                Values = values;
            }
            public readonly string Title;
            public IEnumerable<EventArgValueInfo<TArg>> Values;
        }
        DiagramEventNode Initialize<TEventArgs>(string title, bool isChecked, string format, params Func<TEventArgs, object>[] formatArgs) where TEventArgs : EventArgs {
            var node = new DiagramEventNode(title, isChecked, DiagramEventNodeKind.EventNode);
            eventsOwner.GetType().GetEvent(title).AddEventHandler(eventsOwner, new EventHandler<TEventArgs>((sender, e) => {
                if(node.ActualIsChecked)
                    addToLog(title, format, formatArgs.Select(x => x(e)).ToArray());
            }));
            return node;
        }
        DiagramEventNode Initialize<TEventArgs, TArg1>(string title, bool? isChecked, EventArgInfo<TArg1> arg1, string format, params Func<TEventArgs, object>[] formatArgs) where TEventArgs : EventArgs {
            var node = new DiagramEventNode(title, isChecked, DiagramEventNodeKind.EventNode);
            var children = new List<Tuple<Func<TArg1, bool>, DiagramEventNode>>();
            foreach(var value1 in arg1.Values) {
                var child = new DiagramEventNode(value1.Title(arg1.Title), value1.IsChecked, DiagramEventNodeKind.Parameter);
                children.Add(new Tuple<Func<TArg1, bool>, DiagramEventNode>(x => value1.IsValue(x), child));
                node.AddChild(child);
            }
            eventsOwner.GetType().GetEvent(title).AddEventHandler(eventsOwner, new EventHandler<TEventArgs>((sender, e) => {
                var v1 = (TArg1)e.GetType().GetProperty(arg1.Title).GetValue(e, null);
                var child = children.FirstOrDefault(x => x.Item1(v1));
                if(child != null && child.Item2.ActualIsChecked)
                    addToLog(title, format, formatArgs.Select(x => x(e)).ToArray());
            }));
            return node;
        }
        DiagramEventNode Initialize<TEventArgs, TArg1, TArg2>(string title, bool? isChecked, EventArgInfo<TArg1> arg1, EventArgInfo<TArg2> arg2, string format, params Func<TEventArgs, object>[] formatArgs) where TEventArgs : EventArgs {
            var node = new DiagramEventNode(title, isChecked, DiagramEventNodeKind.EventNode);
            var children = new List<Tuple<Func<TArg1, TArg2, bool>, DiagramEventNode>>();
            foreach(var value2 in arg2.Values) {
                var child2 = new DiagramEventNode(value2.Title(arg2.Title), value2.IsChecked, DiagramEventNodeKind.Parameter);
                foreach(var value1 in arg1.Values) {
                    var child1 = new DiagramEventNode(value1.Title(arg1.Title), value2.IsChecked.HasValue ? value2.IsChecked : value1.IsChecked, DiagramEventNodeKind.Parameter);
                    children.Add(new Tuple<Func<TArg1, TArg2, bool>, DiagramEventNode>((x1, x2) => value1.IsValue(x1) && value2.IsValue(x2), child1));
                    child2.Children.Add(child1);
                }
                node.AddChild(child2);
            }
            eventsOwner.GetType().GetEvent(title).AddEventHandler(eventsOwner, new EventHandler<TEventArgs>((sender, e) => {
                var v1 = (TArg1)e.GetType().GetProperty(arg1.Title).GetValue(e, null);
                var v2 = (TArg2)e.GetType().GetProperty(arg2.Title).GetValue(e, null);
                if(children.First(x => x.Item1(v1, v2)).Item2.ActualIsChecked)
                    addToLog(title, format, formatArgs.Select(x => x(e)).ToArray());
            }));
            return node;
        }
    }
    public class EvensTreeList : TreeList {
        protected override IFindPanel CreateFindPanelCore() {
            return new EventsFindControl(this, null);
        }
        class EventsFindControl : FindControl {
            public EventsFindControl(TreeList client, object properties) : base(client, properties) {
                ((MRUEdit)lciFind.Control).Properties.Buttons[0].Visible = false;
            }
        }
    }
}

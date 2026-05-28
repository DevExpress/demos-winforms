Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class EventsModule
        Inherits DocumentModuleBase

        Public Sub New()
            SetUpOptionsPanel()
            InitializeComponent()
            AddHandler diagramControl.DocumentLoaded, AddressOf OnDiagramControlDocumentLoaded
        End Sub

        Private Sub OnDiagramControlDocumentLoaded(ByVal sender As Object, ByVal e As DiagramDocumentLoadedEventArgs)
            RemoveHandler diagramControl.DocumentLoaded, AddressOf OnDiagramControlDocumentLoaded
            trackedEvents.DataSource = New DiagramEventsInfo(diagramControl, AddressOf AddToLog).Initialize()
            trackedEvents.ExpandAll()
        End Sub

        Private Sub SetUpOptionsPanel()
            ShowOptionsPanel = True
            NeedOptionsPage = False
        End Sub

        Protected Overrides ReadOnly Property DocumentName As String
            Get
                Return "Events.xml"
            End Get
        End Property

        Private ReadOnly log As List(Of LogEntry) = New List(Of LogEntry)()

        Private ReadOnly lines As List(Of LogEntry) = New List(Of LogEntry)()

        Const LogEntriesMaxCount As Integer = 100

        Private Sub AddToLog(ByVal eventName As String, ByVal argsFormat As String, ParamArray args As Object())
            Dim logEntry = New LogEntry(eventName, String.Format(argsFormat, args))
            log.Add(logEntry)
            lines.Add(logEntry)
            lines.AddRange(Enumerable.Range(0, GetLinesCount(logEntry) - 1).[Select](Function(x) CType(Nothing, LogEntry)))
            If log.Count > LogEntriesMaxCount Then
                lines.RemoveRange(0, GetLinesCount(log(0)))
                log.RemoveAt(0)
            End If

            UpdateLog()
            eventsLogPanel.AutoScrollPosition = New Point(0, eventsLogPanel.VerticalScroll.Maximum)
        End Sub

        Private Sub UpdateLog()
            eventsLog.Text = String.Join(Microsoft.VisualBasic.Constants.vbCrLf, log.[Select](Function(x) GetText(x)).ToArray())
        End Sub

        Private Shared Function GetLinesCount(ByVal e As LogEntry) As Integer
            Return If(String.IsNullOrEmpty(e.EventArgs), 1, 2)
        End Function

        Private Function GetText(ByVal e As LogEntry) As String
            Dim highlight = e Is highlighedEntry
            Dim href1 = If(highlight, "<href>", "")
            Dim href2 = If(highlight, "</href>", "")
            Return href1 & "<b>" & e.EventName & "</b>" & href2 & If(String.IsNullOrEmpty(e.EventArgs), "", Microsoft.VisualBasic.Constants.vbCrLf & "      " & e.EventArgs)
        End Function

        Private Sub OnTrackedEventsVirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As VirtualTreeGetChildNodesInfo)
            e.Children = CType(e.Node, DiagramEventNode).Children
        End Sub

        Private Sub OnTrackedEventsVirtualTreeGetCellValue(ByVal sender As Object, ByVal e As VirtualTreeGetCellValueInfo)
            Dim node = CType(e.Node, DiagramEventNode)
            If e.IsCheckState Then
                e.CellData = node.IsChecked
            ElseIf e.Column Is colTitle Then
                e.CellData = node.Title
            End If
        End Sub

        Private Sub OnTrackedEventsVirtualTreeSetCellValue(ByVal sender As Object, ByVal e As VirtualTreeSetCellValueInfo)
            If e.IsCheckState Then CType(e.Node, DiagramEventNode).IsChecked = CType(e.NewCellData, Boolean?)
        End Sub

        Private Sub OnClearLogButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            log.Clear()
            lines.Clear()
            eventsLog.Text = String.Empty
        End Sub

        Private Sub OnTrackedEventsNodeCellStyle(ByVal sender As Object, ByVal e As GetCustomNodeCellStyleEventArgs)
            If e.Node Is highlightedNode Then
                e.Appearance.FontStyleDelta = FontStyle.Underline
                e.Appearance.ForeColor = Color.FromArgb(14, 112, 192)
                Return
            End If

            Dim data = CType(trackedEvents.GetDataRecordByNode(e.Node), DiagramEventNode)
            If data.Kind = DiagramEventNodeKind.Group Then e.Appearance.FontStyleDelta = FontStyle.Bold
        End Sub

        Private highlightedNode As TreeListNode

        Private Sub HighlightNode(ByVal newHighlightedNode As TreeListNode)
            If newHighlightedNode IsNot highlightedNode Then
                Dim oldHighlightedNode = highlightedNode
                highlightedNode = newHighlightedNode
                If oldHighlightedNode IsNot Nothing Then trackedEvents.RefreshNode(oldHighlightedNode)
                If newHighlightedNode IsNot Nothing Then trackedEvents.RefreshNode(newHighlightedNode)
                trackedEvents.Cursor = If(newHighlightedNode Is Nothing, Cursors.Default, Cursors.Hand)
            End If
        End Sub

        Private Sub OnTrackedEventsMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            HighlightNode(CalcHitNode(e))
        End Sub

        Private Function CalcHitNode(ByVal e As MouseEventArgs) As TreeListNode
            Dim hitInfo = trackedEvents.CalcHitInfo(e.Location)
            If hitInfo.HitInfoType <> HitInfoType.Cell Then Return Nothing
            Dim data = CType(trackedEvents.GetDataRecordByNode(hitInfo.Node), DiagramEventNode)
            If data.Kind <> DiagramEventNodeKind.EventNode Then Return Nothing
            Dim rect = hitInfo.HitTest.CellInfo.CellValueRect
            rect.Width = MeasureText(hitInfo.Node.GetDisplayText(hitInfo.Column), hitInfo.Column.AppearanceCell.Font, hitInfo.Column.AppearanceCell.GetStringFormat(), rect.Width, trackedEvents.ViewInfo.GInfo)
            If Not rect.Contains(e.Location) Then Return Nothing
            Return hitInfo.Node
        End Function

        Private Shared Function MeasureText(ByVal text As String, ByVal font As Font, ByVal stringFormat As StringFormat, ByVal width As Integer, ByVal gInfo As GraphicsInfo) As Integer
            gInfo.AddGraphics(Nothing)
            Try
                Return CInt((gInfo.Cache.CalcTextSize(text, font, stringFormat, width).Width + font.SizeInPoints / 2F))
            Finally
                gInfo.ReleaseGraphics()
            End Try
        End Function

        Private Sub OnTrackedEventsMouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            HighlightNode(Nothing)
        End Sub

        Private Sub OnTrackedEventsClick(ByVal sender As Object, ByVal e As EventArgs)
            If highlightedNode Is Nothing Then Return
            Dim data = CType(trackedEvents.GetDataRecordByNode(highlightedNode), DiagramEventNode)
            DevExpress.Data.Utils.SafeProcess.Start("https://documentation.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl." & data.Title & ".event")
        End Sub

        Private highlighedEntry As LogEntry

        Private Sub HighlightEntry(ByVal newHighlihnedEntry As LogEntry)
            If newHighlihnedEntry IsNot highlighedEntry Then
                highlighedEntry = newHighlihnedEntry
                UpdateLog()
                eventsLog.Cursor = If(newHighlihnedEntry Is Nothing, Cursors.Default, Cursors.Hand)
            End If
        End Sub

        Private Function CalcHitEntry(ByVal e As MouseEventArgs) As LogEntry
            Dim highlighedLine = e.Y * lines.Count \ eventsLog.Height
            If highlighedLine < 0 OrElse highlighedLine >= lines.Count Then Return Nothing
            Dim line = lines(highlighedLine)
            If line Is Nothing Then Return Nothing
            Dim lineWidth = MeasureText(line.EventName, New Font(eventsLog.Appearance.GetFont(), FontStyle.Bold), eventsLog.Appearance.GetStringFormat(), eventsLog.Width, Diagram.DiagramViewInfo.GInfo)
            Return If(e.Location.X < eventsLog.Padding.Left OrElse e.Location.X > lineWidth, Nothing, line)
        End Function

        Private Sub OnEventsLogMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            HighlightEntry(CalcHitEntry(e))
        End Sub

        Private Sub OnEventsLogMouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            HighlightEntry(Nothing)
        End Sub

        Private Sub OnEventsLogHyperlinkClick(ByVal sender As Object, ByVal e As HyperlinkClickEventArgs)
            Data.Utils.SafeProcess.Start("https://documentation.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl." & e.Text & ".event")
        End Sub
    End Class

    Public NotInheritable Class LogEntry

        Public Sub New(ByVal eventName As String, ByVal eventArgs As String)
            Me.EventName = eventName
            Me.EventArgs = eventArgs
        End Sub

        Public ReadOnly EventName As String

        Public ReadOnly EventArgs As String
    End Class

    Public Enum DiagramEventNodeKind
        Root
        Group
        EventNode
        Parameter
    End Enum

    Public NotInheritable Class DiagramEventNode

        Private _Parent As DiagramEventNode

        Public Sub New(ByVal title As String, ByVal isChecked As Boolean?, ByVal kind As DiagramEventNodeKind)
            titleField = title
            kindField = kind
            Me.IsChecked = isChecked
        End Sub

        Private ReadOnly titleField As String

        Public ReadOnly Property Title As String
            Get
                Return titleField
            End Get
        End Property

        Private ReadOnly kindField As DiagramEventNodeKind

        Public ReadOnly Property Kind As DiagramEventNodeKind
            Get
                Return kindField
            End Get
        End Property

        Public Property IsChecked As Boolean?

        Public ReadOnly Property ActualIsChecked As Boolean
            Get
                Return IsChecked.HasValue AndAlso IsChecked.Value
            End Get
        End Property

        Public Property Parent As DiagramEventNode
            Get
                Return _Parent
            End Get

            Private Set(ByVal value As DiagramEventNode)
                _Parent = value
            End Set
        End Property

        Private ReadOnly childrenField As List(Of DiagramEventNode) = New List(Of DiagramEventNode)()

        Public ReadOnly Property Children As List(Of DiagramEventNode)
            Get
                Return childrenField
            End Get
        End Property

        Public Sub AddChild(ByVal child As DiagramEventNode)
            child.Parent = Me
            childrenField.Add(child)
        End Sub
    End Class

    Public NotInheritable Class DiagramEventsInfo

        Private Shared ReadOnly EAction As EventArgInfo(Of ItemsActionKind) = New EventArgInfo(Of ItemsActionKind)("Action", EnumArgValues({ItemsActionKind.Move, ItemsActionKind.MoveCopy, ItemsActionKind.Resize, ItemsActionKind.Rotate, ItemsActionKind.Copy, ItemsActionKind.Delete}, Function(x) False))

        Private Shared ReadOnly EStage As EventArgInfo(Of DiagramActionStage) = New EventArgInfo(Of DiagramActionStage)("Stage", EnumArgValues({DiagramActionStage.Start, DiagramActionStage.Continue, DiagramActionStage.Finished, DiagramActionStage.Canceled}, Function(x) x <> DiagramActionStage.Continue))

        Private Shared ReadOnly EConnectorPointType As EventArgInfo(Of ConnectorPointType) = New EventArgInfo(Of ConnectorPointType)("ConnectorPointType", EnumArgValues({ConnectorPointType.Begin, ConnectorPointType.End}, Function(x) x = ConnectorPointType.End))

        Private Shared ReadOnly EConnector As EventArgInfo(Of DiagramConnector) = New EventArgInfo(Of DiagramConnector)("Connector", {New EventArgValueInfo(Of DiagramConnector)(Function(x) "e.Connector.GetDiagram() is null", Nothing, Function(x) x.GetDiagram() Is Nothing), New EventArgValueInfo(Of DiagramConnector)(Function(x) "e.Connector.GetDiagram() is not null", True, Function(x) x.GetDiagram() IsNot Nothing)})

        Private Shared ReadOnly EItemUsage As EventArgInfo(Of ItemUsage) = New EventArgInfo(Of ItemUsage)("ItemUsage", EnumArgValues({ItemUsage.Diagram, ItemUsage.ToolboxPreview}, Function(x) x = ItemUsage.Diagram))

        Private eventsOwner As DiagramControl

        Private addToLog As Action(Of String, String, Object())

        Public Sub New(ByVal eventsOwner As DiagramControl, ByVal addToLog As Action(Of String, String, Object()))
            Me.eventsOwner = eventsOwner
            Me.addToLog = addToLog
        End Sub

        Public Function Initialize() As DiagramEventNode
            Dim groups = New DiagramEventNode("", True, DiagramEventNodeKind.Root)
            Dim behaviorGroup = New DiagramEventNode("Behavior", Nothing, DiagramEventNodeKind.Group)
            groups.AddChild(behaviorGroup)
            behaviorGroup.AddChild(Initialize(Of DiagramCustomCursorEventArgs)("CustomCursor", False, ""))
            behaviorGroup.AddChild(Initialize(Of DiagramCustomItemDragEventArgs)("CustomItemDrag", True, ""))
            behaviorGroup.AddChild(Initialize(Of DiagramCustomItemDragResultEventArgs)("CustomItemDragResult", True, "Result = {0}", Function(e) e.Result))
            behaviorGroup.AddChild(Initialize(Of DiagramCustomItemGiveFeedbackEventArgs)("CustomItemGiveFeedback", False, ""))
            behaviorGroup.AddChild(Initialize(Of DiagramCustomItemQueryContinueDragEventArgs)("CustomItemQueryContinueDrag", False, ""))
            behaviorGroup.AddChild(Initialize(Of DiagramActiveToolChangedEventArgs)("ActiveToolChanged", True, "OldTool = {0}, NewTool = {1}", Function(e) e.OldTool, Function(e) e.NewTool))
            Dim diagramGroup = New DiagramEventNode("Diagram Document", Nothing, DiagramEventNodeKind.Group)
            groups.AddChild(diagramGroup)
            diagramGroup.AddChild(Initialize(Of DiagramCanvasBoundsChangedEventArgs)("CanvasBoundsChanged", False, "OldBounds = {{ {0} }}, NewBounds = {{ {1} }}", Function(e) e.OldBounds, Function(e) e.NewBounds))
            diagramGroup.AddChild(Initialize(Of DiagramCustomLoadDocumentEventArgs)("CustomLoadDocument", True, ""))
            diagramGroup.AddChild(Initialize(Of DiagramCustomSaveDocumentEventArgs)("CustomSaveDocument", True, ""))
            diagramGroup.AddChild(Initialize(Of DiagramDocumentLoadedEventArgs)("DocumentLoaded", True, ""))
            diagramGroup.AddChild(Initialize(Of DiagramShowingOpenDialogEventArgs)("ShowingOpenDialog", True, ""))
            diagramGroup.AddChild(Initialize(Of DiagramShowingSaveDialogEventArgs)("ShowingSaveDialog", True, ""))
            Dim itemsGroup = New DiagramEventNode("Diagram Items", Nothing, DiagramEventNodeKind.Group)
            groups.AddChild(itemsGroup)
            itemsGroup.AddChild(Initialize(Of DiagramAddingNewItemEventArgs)("AddingNewItem", True, "Item is {0}, Parent is {1}", Function(e) e.Item.GetType().Name, Function(e) e.Parent.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramBeforeItemsMovingEventArgs)("BeforeItemsMoving", True, "ActionSource = {0}", Function(e) e.ActionSource))
            itemsGroup.AddChild(Initialize(Of DiagramBeforeItemsResizingEventArgs)("BeforeItemsResizing", True, "ActionSource = {0}", Function(e) e.ActionSource))
            itemsGroup.AddChild(Initialize(Of DiagramBeforeItemsRotatingEventArgs)("BeforeItemsRotating", True, "ActionSource = {0}", Function(e) e.ActionSource))
            itemsGroup.AddChild(Initialize(Of DiagramClosedEditorEventArgs)("ClosedEditor", True, "Item is {0}", Function(e) e.Item.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramConnectionChangingEventArgs)("ConnectionChanging", True, "PointType = {0}", Function(e) e.ConnectorPointType))
            itemsGroup.AddChild(Initialize(Of DiagramConnectionChangedEventArgs)("ConnectionChanged", True, "PointType = {0}", Function(e) e.ConnectorPointType))
            itemsGroup.AddChild(Initialize(Of DiagramCustomGetEditableItemPropertiesEventArgs)("CustomGetEditableItemProperties", True, "Item is {0}", Function(e) e.Item.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramCustomGetEditableItemPropertiesCacheKeyEventArgs)("CustomGetEditableItemPropertiesCacheKey", False, "Item is {0}", Function(e) e.Item.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramCustomGetSerializableItemPropertiesEventArgs)("CustomGetSerializableItemProperties", True, "ItemType = {0}", Function(e) e.ItemType.Name))
            itemsGroup.AddChild(Initialize(Of DiagramCustomLoadImageEventArgs)("CustomLoadImage", True, ""))
            itemsGroup.AddChild(Initialize(Of DiagramItemBoundsChangedEventArgs)("ItemBoundsChanged", False, ""))
            itemsGroup.AddChild(Initialize(Of DiagramItemContentChangedEventArgs)("ItemContentChanged", True, "OldValue = {0}, NewValue = {1}", Function(e) e.OldValue, Function(e) e.NewValue))
            itemsGroup.AddChild(Initialize(Of DiagramItemCreatingEventArgs, ItemUsage)("ItemCreating", Nothing, EItemUsage, "ItemType = {0}, ItemUsage = {1}", Function(e) e.ItemType.Name, Function(e) e.ItemUsage))
            itemsGroup.AddChild(Initialize(Of DiagramItemDrawingEventArgs, DiagramActionStage)("ItemDrawing", Nothing, EStage, "Tool = {0}, Stage = {1}", Function(e) e.Tool.ToolName, Function(e) e.Stage))
            itemsGroup.AddChild(Initialize(Of DiagramItemInitializingEventArgs, ItemUsage)("ItemInitializing", Nothing, EItemUsage, "Item is {0}, ItemUsage = {1}", Function(e) e.Item.GetType().Name, Function(e) e.ItemUsage))
            itemsGroup.AddChild(Initialize(Of DiagramItemsChangedEventArgs)("ItemsChanged", True, "Action = {0}", Function(e) e.Action))
            itemsGroup.AddChild(Initialize(Of DiagramItemsDeletingEventArgs)("ItemsDeleting", True, ""))
            itemsGroup.AddChild(Initialize(Of DiagramItemsMovingEventArgs, DiagramActionStage)("ItemsMoving", Nothing, EStage, "Stage = {0}, ActionSource = {1}", Function(e) e.Stage, Function(e) e.ActionSource))
            itemsGroup.AddChild(Initialize(Of DiagramItemsPastingEventArgs)("ItemsPasting", True, ""))
            itemsGroup.AddChild(Initialize(Of DiagramItemsResizingEventArgs, DiagramActionStage)("ItemsResizing", Nothing, EStage, "Stage = {0}, ActionSource = {1}", Function(e) e.Stage, Function(e) e.ActionSource))
            itemsGroup.AddChild(Initialize(Of DiagramItemsRotatingEventArgs, DiagramActionStage)("ItemsRotating", Nothing, EStage, "Stage = {0}, ActionSource = {1}", Function(e) e.Stage, Function(e) e.ActionSource))
            itemsGroup.AddChild(Initialize(Of DiagramQueryConnectionPointsEventArgs, ConnectorPointType, DiagramConnector)("QueryConnectionPoints", Nothing, EConnectorPointType, EConnector, "ConnectorPointType = {0}, HoveredItem is {1}", Function(e) e.ConnectorPointType, Function(e) e.HoveredItem.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramQueryItemDrawActionEventArgs)("QueryItemDrawAction", False, "Tool = {0}", Function(e) e.Tool.ToolName))
            itemsGroup.AddChild(Initialize(Of DiagramQueryItemEditActionEventArgs)("QueryItemEditAction", True, "Item is {0}", Function(e) e.Item.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramQueryItemSnappingEventArgs)("QueryItemSnapping", False, "Item is {0}, SnapTo is {1}", Function(e) e.Item.GetType().Name, Function(e) e.SnapTo.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramQueryItemsActionEventArgs, ItemsActionKind)("QueryItemsAction", False, EAction, "Action = {0}", Function(e) e.Action))
            itemsGroup.AddChild(Initialize(Of DiagramShowingEditorEventArgs)("ShowingEditor", True, "Item is {0}", Function(e) e.Item.GetType().Name))
            itemsGroup.AddChild(Initialize(Of DiagramShowingOpenImageDialogEventArgs)("ShowingOpenImageDialog", True, ""))
            Dim propertiesGroup = New DiagramEventNode("Diagram Property Changed", Nothing, DiagramEventNodeKind.Group)
            groups.AddChild(propertiesGroup)
            propertiesGroup.AddChild(Initialize(Of DiagramSelectionChangedEventArgs)("SelectionChanged", True, ""))
            propertiesGroup.AddChild(Initialize(Of DiagramZoomFactorChangedEventArgs)("ZoomFactorChanged", False, "OldValue = {0:0 %}, NewValue = {1:0 %}", Function(e) e.OldValue, Function(e) e.NewValue))
            Dim subordinatesGroup = New DiagramEventNode("Expand And Collapse", True, DiagramEventNodeKind.Group)
            groups.AddChild(subordinatesGroup)
            subordinatesGroup.AddChild(Initialize(Of DiagramSubordinatesHiddenEventArgs)("SubordinatesHidden", True, ""))
            subordinatesGroup.AddChild(Initialize(Of DiagramSubordinatesHidingEventArgs)("SubordinatesHiding", True, ""))
            subordinatesGroup.AddChild(Initialize(Of DiagramSubordinatesShowingEventArgs)("SubordinatesShowing", True, ""))
            subordinatesGroup.AddChild(Initialize(Of DiagramSubordinatesShownEventArgs)("SubordinatesShown", True, ""))
            Dim layoutGroup = New DiagramEventNode("Layout", True, DiagramEventNodeKind.Group)
            groups.AddChild(layoutGroup)
            layoutGroup.AddChild(Initialize(Of DiagramRelayoutItemsCompletedEventArgs)("RelayoutItemsCompleted", True, ""))
            Return groups
        End Function

        Private Shared Function EnumArgValues(Of TArg)(ByVal values As IEnumerable(Of TArg), ByVal isChecked As Func(Of TArg, Boolean)) As IEnumerable(Of EventArgValueInfo(Of TArg))
            Return values.[Select](Function(value) New EventArgValueInfo(Of TArg)(Function(x) "e." & x & " = " & value.ToString(), isChecked(value), Function(x) Equals(x, value))).ToArray()
        End Function

        Private NotInheritable Class EventArgValueInfo(Of TArg)

            Public Sub New(ByVal title As Func(Of String, String), ByVal isChecked As Boolean?, ByVal isValue As Func(Of TArg, Boolean))
                Me.Title = title
                Me.IsValue = isValue
                Me.IsChecked = isChecked
            End Sub

            Public ReadOnly Title As Func(Of String, String)

            Public IsValue As Func(Of TArg, Boolean)

            Public ReadOnly IsChecked As Boolean?
        End Class

        Private NotInheritable Class EventArgInfo(Of TArg)

            Public Sub New(ByVal title As String, ByVal values As IEnumerable(Of EventArgValueInfo(Of TArg)))
                Me.Title = title
                Me.Values = values
            End Sub

            Public ReadOnly Title As String

            Public Values As IEnumerable(Of EventArgValueInfo(Of TArg))
        End Class

        Private Function Initialize(Of TEventArgs As EventArgs)(ByVal title As String, ByVal isChecked As Boolean, ByVal format As String, ParamArray formatArgs As Func(Of TEventArgs, Object)()) As DiagramEventNode
            Dim node = New DiagramEventNode(title, isChecked, DiagramEventNodeKind.EventNode)
            eventsOwner.GetType().GetEvent(title).AddEventHandler(eventsOwner, New EventHandler(Of TEventArgs)(Sub(sender, e)
                If node.ActualIsChecked Then addToLog(title, format, formatArgs.[Select](Function(x) x(e)).ToArray())
            End Sub))
            Return node
        End Function

        Private Function Initialize(Of TEventArgs As EventArgs, TArg1)(ByVal title As String, ByVal isChecked As Boolean?, ByVal arg1 As EventArgInfo(Of TArg1), ByVal format As String, ParamArray formatArgs As Func(Of TEventArgs, Object)()) As DiagramEventNode
            Dim node = New DiagramEventNode(title, isChecked, DiagramEventNodeKind.EventNode)
            Dim children = New List(Of Tuple(Of Func(Of TArg1, Boolean), DiagramEventNode))()
            For Each value1 In arg1.Values
                Dim child = New DiagramEventNode(value1.Title(arg1.Title), value1.IsChecked, DiagramEventNodeKind.Parameter)
                children.Add(New Tuple(Of Func(Of TArg1, Boolean), DiagramEventNode)(Function(x) value1.IsValue(x), child))
                node.AddChild(child)
            Next

            eventsOwner.GetType().GetEvent(title).AddEventHandler(eventsOwner, New EventHandler(Of TEventArgs)(Sub(sender, e)
                Dim v1 = CType(e.GetType().GetProperty(arg1.Title).GetValue(e, Nothing), TArg1)
                Dim child = children.FirstOrDefault(Function(x) x.Item1(v1))
                If child IsNot Nothing AndAlso child.Item2.ActualIsChecked Then addToLog(title, format, formatArgs.[Select](Function(x) x(e)).ToArray())
            End Sub))
            Return node
        End Function

        Private Function Initialize(Of TEventArgs As EventArgs, TArg1, TArg2)(ByVal title As String, ByVal isChecked As Boolean?, ByVal arg1 As EventArgInfo(Of TArg1), ByVal arg2 As EventArgInfo(Of TArg2), ByVal format As String, ParamArray formatArgs As Func(Of TEventArgs, Object)()) As DiagramEventNode
            Dim node = New DiagramEventNode(title, isChecked, DiagramEventNodeKind.EventNode)
            Dim children = New List(Of Tuple(Of Func(Of TArg1, TArg2, Boolean), DiagramEventNode))()
            For Each value2 In arg2.Values
                Dim child2 = New DiagramEventNode(value2.Title(arg2.Title), value2.IsChecked, DiagramEventNodeKind.Parameter)
                For Each value1 In arg1.Values
                    Dim child1 = New DiagramEventNode(value1.Title(arg1.Title), If(value2.IsChecked.HasValue, value2.IsChecked, value1.IsChecked), DiagramEventNodeKind.Parameter)
                    children.Add(New Tuple(Of Func(Of TArg1, TArg2, Boolean), DiagramEventNode)(Function(x1, x2) value1.IsValue(x1) AndAlso value2.IsValue(x2), child1))
                    child2.Children.Add(child1)
                Next

                node.AddChild(child2)
            Next

            eventsOwner.GetType().GetEvent(CStr(title)).AddEventHandler(eventsOwner, New EventHandler(Of TEventArgs)(Sub(sender, e)
                Dim v1 = CType(e.GetType().GetProperty(CStr(arg1.Title)).GetValue(e, Nothing), TArg1)
                Dim v2 = CType(e.GetType().GetProperty(CStr(arg2.Title)).GetValue(e, Nothing), TArg2)
                If Enumerable.First(Of Tuple(Of Global.System.Func(Of TArg1, TArg2, Global.System.[Boolean]), Global.DevExpress.XtraDiagram.Demos.DiagramEventNode))(children, CType(Function(x) CBool(x.Item1(CType(v1, TArg1), CType(v2, TArg2))), Func(Of Tuple(Of Func(Of TArg1, TArg2, Boolean), DiagramEventNode), Boolean))).Item2.ActualIsChecked Then addToLog(title, format, formatArgs.[Select](Function(x) x(e)).ToArray())
            End Sub))
            Return node
        End Function
    End Class

    Public Class EvensTreeList
        Inherits TreeList

        Protected Overrides Function CreateFindPanelCore() As IFindPanel
            Return New EventsFindControl(Me, Nothing)
        End Function

        Private Class EventsFindControl
            Inherits FindControl

            Public Sub New(ByVal client As TreeList, ByVal properties As Object)
                MyBase.New(client, properties)
                CType(lciFind.Control, MRUEdit).Properties.Buttons(0).Visible = False
            End Sub
        End Class
    End Class
End Namespace

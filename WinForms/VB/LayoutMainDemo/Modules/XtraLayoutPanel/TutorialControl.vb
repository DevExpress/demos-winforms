Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraToolbox
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Layout
Imports DevExpress.XtraLayout.Demos.Controls
Imports DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class XtraLayoutPanelTutorialControl
        Inherits TutorialControl

        Private ReadOnly coreView As XtraLayoutPanelDemoViewBase

        Private ReadOnly dragController As DragDropControllerBase

        Private selectedControl As Control

        Public Sub New()
            InitializeComponent()
            coreView = CreateView()
            selectedControl = Nothing
            dragController = CreateDragController()
            If coreView IsNot Nothing Then AddView()
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            coreView?.Show()
        End Sub

        Private shouldUpdateViewProperties As Boolean = True

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            If shouldUpdateViewProperties AndAlso coreView IsNot Nothing Then
                coreView.Location = CalculateViewLocation()
                coreView.MinimumSize = coreView.Size
                shouldUpdateViewProperties = False
            End If
        End Sub

        Private Sub AddView()
            OnInitialize()
            SubscriveViewEvents(coreView)
            contentPanel.Controls.Add(coreView)
        End Sub

        Private Sub OnInitialize()
            coreView.Initialize()
            tiSimpleButton.Tag = GetType(SimpleButton)
            tiTextEdit.Tag = GetType(TextEdit)
            tiLabel.Tag = GetType(LabelControl)
            tiCheckEdit.Tag = GetType(CheckEdit)
            SelectDefaultControl()
        End Sub

#Region "Event Handlers"
        Private Sub OnViewControlSelectRequest(ByVal sender As Object, ByVal e As ControlEventArgs)
            SelectControl(e.Control)
        End Sub

        Private Sub OnViewControlDeleteRequest(ByVal sender As Object, ByVal e As ControlEventArgs)
            If TypeOf selectedControl Is ICustomControl Then
                selectedControl.Dispose()
                SelectDefaultControl()
            End If
        End Sub

        Private Sub OnResetLayoutClick(ByVal sender As Object, ByVal e As EventArgs)
            View.ResetLayout()
        End Sub

#End Region
#Region "Drag & Drop"
        Private Sub OnToolboxDragItemStart(ByVal sender As Object, ByVal e As ToolboxDragItemStartEventArgs)
            dragController.StartDragDrop()
            e.Image = CType(e.Item, ToolboxItem).CreateToolboxItemImage(View.ForeColor)
            e.Handled = True
        End Sub

        Private Sub OnToolboxDragItemMove(ByVal sender As Object, ByVal e As ToolboxDragItemMoveEventArgs)
            e.DragDropEffects = If(dragController.AllowDragDrop(e.Location), DragDropEffects.Link, DragDropEffects.None)
            dragController.OnMouseOver(e.Location)
        End Sub

        Private Sub OnToolboxDragItemCancel(ByVal sender As Object, ByVal e As ToolboxDragItemCancelEventArgs)
            dragController.CancelDragDrop()
        End Sub

        Private Sub OnToolboxDragItemDrop(ByVal sender As Object, ByVal e As ToolboxDragItemDropEventArgs)
            dragController.DoDragDrop(CType(e.Item.Tag, Type))
        End Sub

#End Region
        Protected Overridable Function CreateView() As XtraLayoutPanelDemoViewBase
            Return Nothing
        End Function

        Protected Overridable Function CreateDragController() As DragDropControllerBase
            Return Nothing
        End Function

        Protected Overridable Function CreateEditorProperties(ByVal control As Control) As EditorPropertiesObjectBase
            Return Nothing
        End Function

        Private Sub SubscriveViewEvents(ByVal view As XtraLayoutPanelDemoViewBase)
            AddHandler view.ControlSelectRequest, AddressOf OnViewControlSelectRequest
            AddHandler view.ControlDeleteRequest, AddressOf OnViewControlDeleteRequest
        End Sub

        Private Sub SelectDefaultControl()
            If Not View.LayoutPanel.ContainerIsEmpty() Then SelectControl(View.LayoutPanel.Controls(0))
        End Sub

        Private Sub SelectControl(ByVal control As Control)
            selectedControl = control
            propertyGridControl.SelectedObject = CreateEditorProperties(control)
        End Sub

        Private Function CalculateViewLocation() As Point
            Return rootPanel.Bounds.GetCenterRect(coreView.Size).Location.WithOffset(0, -contentPanel.Bounds.Y)
        End Function

        Public ReadOnly Property View As XtraLayoutPanelDemoViewBase
            Get
                Return coreView
            End Get
        End Property
    End Class

    Public MustInherit Class DragDropControllerBase

        Private ReadOnly view As XtraLayoutPanelDemoViewBase

        Private ReadOnly adornerPainter As LayoutPanelAdornerPainterBase

        Private isDragActive As Boolean

        Private mPosition As Point

        Public Sub New(ByVal view As XtraLayoutPanelDemoViewBase)
            Guard.ArgumentNotNull(view, "view")
            Me.view = view
            isDragActive = False
            mPosition = Point.Empty
            AddHandler Me.view.LayoutPanel.Paint, AddressOf OnViewPaint
            adornerPainter = CreateAdornerPainter()
        End Sub

        Public Sub StartDragDrop()
            isDragActive = True
            StartDragDropCore()
        End Sub

        Public Sub OnMouseOver(ByVal point As Point)
            mPosition = LayoutPanel.PointToClient(point)
            OnMouseOverCore()
            LayoutPanel.Invalidate()
        End Sub

        Public Sub CancelDragDrop()
            isDragActive = False
        End Sub

        Public Sub DoDragDrop(ByVal controlType As Type)
            isDragActive = False
            DoDragDropCore(controlType)
            LayoutPanel.Invalidate()
        End Sub

        Public Function AllowDragDrop(ByVal point As Point) As Boolean
            If Not view.Bounds.Contains(view.Parent.PointToClient(point)) Then Return False
            Return AllowDragDropCore(point)
        End Function

        Protected MustOverride Sub StartDragDropCore()

        Protected MustOverride Sub OnMouseOverCore()

        Protected MustOverride Sub DoDragDropCore(ByVal controlType As Type)

        Protected MustOverride Function CalculateAdornerObject() As LayoutPanelAdornerObject

        Protected MustOverride Function CreateAdornerPainter() As LayoutPanelAdornerPainterBase

        Protected Overridable Function AllowDragDropCore(ByVal point As Point) As Boolean
            Return True
        End Function

        Private Sub OnViewPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
            If Not isDragActive Then Return
            Using cache As GraphicsCache = New GraphicsCache(e)
                adornerPainter.Paint(New LayoutPanelAdornerPaintInfo(LayoutPanel, cache, CalculateAdornerObject()))
            End Using
        End Sub

        Protected ReadOnly Property MousePosition As Point
            Get
                Return mPosition
            End Get
        End Property

        Public ReadOnly Property LayoutPanel As XtraLayoutPanelBase
            Get
                Return view.LayoutPanel
            End Get
        End Property
    End Class

    Public NotInheritable Class LayoutPanelAdornerPaintInfo

        Private ReadOnly _layoutPanel As XtraLayoutPanelBase

        Private ReadOnly _cache As GraphicsCache

        Private ReadOnly _adorner As LayoutPanelAdornerObject

        Public Sub New(ByVal layoutPanel As XtraLayoutPanelBase, ByVal cache As GraphicsCache, ByVal adorner As LayoutPanelAdornerObject)
            _layoutPanel = layoutPanel
            _cache = cache
            _adorner = adorner
        End Sub

        Public ReadOnly Property Cache As GraphicsCache
            Get
                Return _cache
            End Get
        End Property

        Public ReadOnly Property Adorner As LayoutPanelAdornerObject
            Get
                Return _adorner
            End Get
        End Property

        Public ReadOnly Property LayoutPanel As XtraLayoutPanelBase
            Get
                Return _layoutPanel
            End Get
        End Property
    End Class

    Public MustInherit Class LayoutPanelAdornerObject

        Private ReadOnly _visible As Boolean

        Public Sub New(ByVal visible As Boolean)
            _visible = visible
        End Sub

        Public ReadOnly Property Visible As Boolean
            Get
                Return _visible
            End Get
        End Property
    End Class

    Public MustInherit Class LayoutPanelAdornerPainterBase

        Public Sub New()
        End Sub

        Public Sub Paint(ByVal e As LayoutPanelAdornerPaintInfo)
            If Not e.Adorner.Visible Then Return
            OnPaint(e)
        End Sub

        Protected MustOverride Sub OnPaint(ByVal e As LayoutPanelAdornerPaintInfo)
    End Class

    Public NotInheritable Class NullLayoutPanelAdornerObject
        Inherits LayoutPanelAdornerObject

        Private Sub New(ByVal visible As Boolean)
            MyBase.New(visible)
        End Sub

        Public Shared Instance As NullLayoutPanelAdornerObject = New NullLayoutPanelAdornerObject(False)
    End Class

    Public MustInherit Class EditorPropertiesObjectBase

        Private ReadOnly _control As Control

        Public Sub New(ByVal control As Control)
            Guard.ArgumentNotNull(control, "control")
            _control = control
        End Sub

        <Category(CategoryName.Layout), TypeConverter(GetType(SimpleSizeConverter))>
        Public Property Size As Size
            Get
                Return _control.Size
            End Get

            Set(ByVal value As Size)
                value.Width = CheckValueRange(value.Width)
                value.Height = CheckValueRange(value.Height)
                _control.Size = value
            End Set
        End Property

        <Category(CategoryName.Layout)>
        Public Property Dock As DockStyle
            Get
                Return _control.Dock
            End Get

            Set(ByVal value As DockStyle)
                _control.Dock = value
            End Set
        End Property

        <Category(CategoryName.Layout), TypeConverter(GetType(SimplePaddingConverter))>
        Public Property Margin As Padding
            Get
                Return _control.Margin
            End Get

            Set(ByVal value As Padding)
                value.Left = CheckValueRange(value.Left, lBound:=0)
                value.Top = CheckValueRange(value.Top, lBound:=0)
                value.Right = CheckValueRange(value.Right, lBound:=0)
                value.Bottom = CheckValueRange(value.Bottom, lBound:=0)
                _control.Margin = value
            End Set
        End Property

        <Category(CategoryName.Appearance)>
        Public Property Text As String
            Get
                Return _control.Text
            End Get

            Set(ByVal value As String)
                _control.Text = value
            End Set
        End Property

        <Category("Design")>
        Public ReadOnly Property Name As String
            Get
                Return _control.Name
            End Get
        End Property

        Protected Function CheckValueRange(ByVal value As Integer, ByVal Optional lBound As Integer = 1, ByVal Optional hBound As Integer = 500) As Integer
            If value < lBound Then Return lBound
            If value > hBound Then Return hBound
            Return value
        End Function

        Protected ReadOnly Property Control As Control
            Get
                Return _control
            End Get
        End Property
    End Class
End Namespace

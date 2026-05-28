Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Layout
Imports DevExpress.Utils.Extensions
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraLayout.Demos.Controls
Imports DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class StackLayout
        Inherits XtraLayoutPanelTutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Function CreateView() As XtraLayoutPanelDemoViewBase
            Return New LoginView()
        End Function

        Protected Overrides Function CreateDragController() As DragDropControllerBase
            Return New StackLayoutDragDropController(View)
        End Function

        Protected Overrides Function CreateEditorProperties(ByVal control As Control) As EditorPropertiesObjectBase
            Return New StackEditorPropertiesObject(View.StackPanel, control)
        End Function

        Public Overloads ReadOnly Property View As LoginView
            Get
                Return CType(MyBase.View, LoginView)
            End Get
        End Property
    End Class

    Public Class StackEditorPropertiesObject
        Inherits EditorPropertiesObjectBase

        Private ReadOnly stackPanel As StackPanel

        Public Sub New(ByVal stackPanel As StackPanel, ByVal control As Control)
            MyBase.New(control)
            Guard.ArgumentNotNull(stackPanel, "stackPanel")
            Me.stackPanel = stackPanel
        End Sub

        <Category(CategoryName.Layout)>
        Public Property UseSkinIndents As Boolean
            Get
                Return stackPanel.UseSkinIndents
            End Get

            Set(ByVal value As Boolean)
                stackPanel.UseSkinIndents = value
            End Set
        End Property
    End Class

    Public NotInheritable Class StackPanelAdornerObject
        Inherits LayoutPanelAdornerObject

        Private ReadOnly _start As Point

        Private ReadOnly _end As Point

        Public Sub New(ByVal start As Point, ByVal [end] As Point)
            MyBase.New(True)
            _start = start
            _end = [end]
        End Sub

        Public ReadOnly Property Start As Point
            Get
                Return _start
            End Get
        End Property

        Public ReadOnly Property [End] As Point
            Get
                Return _end
            End Get
        End Property
    End Class

    Public NotInheritable Class StackPanelAdornerPainter
        Inherits LayoutPanelAdornerPainterBase

        Const IBarSize As Integer = 4

        Public Sub New()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As LayoutPanelAdornerPaintInfo)
            Dim adorner As StackPanelAdornerObject = CType(e.Adorner, StackPanelAdornerObject)
            DrawHorzIBar(e.Cache, adorner.Start, adorner.End, e.LayoutPanel.BackColor)
        End Sub

        Private Sub DrawHorzIBar(ByVal cache As GraphicsCache, ByVal start As Point, ByVal [end] As Point, ByVal backColor As Color)
            Dim barPen As Pen = If(backColor <> Color.Empty AndAlso backColor.GetBrightness() < 0.5, SystemPens.ControlLight, SystemPens.ControlText)
            cache.DrawLine(barPen, start, [end])
            cache.DrawLine(barPen, start.WithOffset(0, -IBarSize), start.WithOffset(0, IBarSize))
            cache.DrawLine(barPen, [end].WithOffset(0, -IBarSize), [end].WithOffset(0, IBarSize))
        End Sub
    End Class

    Public NotInheritable Class StackLayoutDragDropController
        Inherits DragDropControllerBase

        Private targetItem As StackPanelLayoutItem

        Private layout As StackPanelLayout

        Public Sub New(ByVal view As LoginView)
            MyBase.New(view)
            targetItem = Nothing
            layout = Nothing
        End Sub

        Protected Overrides Sub StartDragDropCore()
            layout = LayoutPanel.CalculateLayout()
        End Sub

        Protected Overrides Sub OnMouseOverCore()
            targetItem = layout.Return(Function(x) x.GetItemByPoint(MousePosition))
        End Sub

        Protected Overrides Sub DoDragDropCore(ByVal controlType As Type)
            If targetItem Is Nothing Then Return
            Dim control As Control = LayoutPanel.AddControl(CustomControlFactory.CreateControl(controlType))
            LayoutPanel.Controls.SetChildIndex(control, targetItem.GetDragDropTargetIndex(MousePosition))
        End Sub

        Protected Overrides Function CalculateAdornerObject() As LayoutPanelAdornerObject
            If targetItem Is Nothing Then Return NullLayoutPanelAdornerObject.Instance
            If targetItem.MarginBounds.TopHalfRect().Contains(MousePosition) Then
                Return New StackPanelAdornerObject(targetItem.MarginBounds.LeftTop(), targetItem.MarginBounds.RightTop())
            End If

            Return New StackPanelAdornerObject(targetItem.MarginBounds.LeftBottom(), targetItem.MarginBounds.RightBottom())
        End Function

        Protected Overrides Function CreateAdornerPainter() As LayoutPanelAdornerPainterBase
            Return New StackPanelAdornerPainter()
        End Function

        Public Overloads ReadOnly Property LayoutPanel As StackPanel
            Get
                Return CType(MyBase.LayoutPanel, StackPanel)
            End Get
        End Property
    End Class
End Namespace

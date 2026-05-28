Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Layout
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraLayout.Demos.Controls
Imports DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class TableLayout
        Inherits XtraLayoutPanelTutorialControl

        Public Sub New()
            InitializeComponent()
            ceShowGrid.Checked = View.ShowGrid
        End Sub

#Region "Handlers"
        Private Sub OnShowGridCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            View.ShowGrid = checkEdit.Checked
        End Sub

#End Region
        Protected Overrides Function CreateView() As XtraLayoutPanelDemoViewBase
            Return New DetailView()
        End Function

        Protected Overrides Function CreateDragController() As DragDropControllerBase
            Return New TableLayoutDragDropController(View)
        End Function

        Protected Overrides Function CreateEditorProperties(ByVal control As Control) As EditorPropertiesObjectBase
            Return New TableEditorPropertiesObject(View.TableLayoutPanel, control)
        End Function

        Public Overloads ReadOnly Property View As DetailView
            Get
                Return CType(MyBase.View, DetailView)
            End Get
        End Property
    End Class

    Public Class TableEditorPropertiesObject
        Inherits EditorPropertiesObjectBase

        Private ReadOnly tablePanel As TablePanel

        Public Sub New(ByVal tablePanel As TablePanel, ByVal control As Control)
            MyBase.New(control)
            Guard.ArgumentNotNull(tablePanel, "tablePanel")
            Me.tablePanel = tablePanel
        End Sub

        <Category(CategoryName.Layout)>
        Public Property Column As Integer
            Get
                Return tablePanel.GetColumn(Control)
            End Get

            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                tablePanel.SetColumn(Control, value)
            End Set
        End Property

        <Category(CategoryName.Layout)>
        Public Property Row As Integer
            Get
                Return tablePanel.GetRow(Control)
            End Get

            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                tablePanel.SetRow(Control, value)
            End Set
        End Property

        <Category(CategoryName.Layout)>
        Public Property ColumnSpan As Integer
            Get
                Return tablePanel.GetColumnSpan(Control)
            End Get

            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                tablePanel.SetColumnSpan(Control, value)
            End Set
        End Property

        <Category(CategoryName.Layout)>
        Public Property RowSpan As Integer
            Get
                Return tablePanel.GetRowSpan(Control)
            End Get

            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                tablePanel.SetRowSpan(Control, value)
            End Set
        End Property

        <Category(CategoryName.Layout)>
        Public Property UseSkinIndents As Boolean
            Get
                Return tablePanel.UseSkinIndents
            End Get

            Set(ByVal value As Boolean)
                tablePanel.UseSkinIndents = value
            End Set
        End Property
    End Class

    Public NotInheritable Class TablePanelAdornerPainter
        Inherits LayoutPanelAdornerPainterBase

        Public Sub New()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As LayoutPanelAdornerPaintInfo)
            Dim adorner As TablePanelAdornerObject = CType(e.Adorner, TablePanelAdornerObject)
            Call DXControlPaint.DrawDashedBorder(e.Cache.Graphics, adorner.Bounds, e.LayoutPanel.GetBackColor(), 2F)
        End Sub
    End Class

    Public NotInheritable Class TablePanelAdornerObject
        Inherits LayoutPanelAdornerObject

        Private ReadOnly _bounds As Rectangle

        Public Sub New(ByVal bounds As Rectangle)
            MyBase.New(True)
            _bounds = bounds
        End Sub

        Public ReadOnly Property Bounds As Rectangle
            Get
                Return _bounds
            End Get
        End Property
    End Class

    Public NotInheritable Class TableLayoutDragDropController
        Inherits DragDropControllerBase

        Private targetCell As TablePanelCell

        Private layout As TablePanelLayout

        Public Sub New(ByVal view As DetailView)
            MyBase.New(view)
            targetCell = Nothing
            layout = Nothing
        End Sub

        Protected Overrides Sub StartDragDropCore()
            layout = LayoutPanel.CalculateLayout()
        End Sub

        Protected Overrides Sub OnMouseOverCore()
            targetCell = layout.Return(Function(x) x.GetCell(MousePosition))
        End Sub

        Protected Overrides Sub DoDragDropCore(ByVal controlType As Type)
            If targetCell Is Nothing OrElse targetCell.IsOccupied Then Return
            Dim control As Control = LayoutPanel.AddControl(CustomControlFactory.CreateControl(controlType))
            LayoutPanel.SetCell(control, targetCell.Row, targetCell.Column)
        End Sub

        Protected Overrides Function AllowDragDropCore(ByVal point As Point) As Boolean
            If targetCell Is Nothing OrElse targetCell.IsOccupied Then Return False
            Return True
        End Function

        Protected Overrides Function CreateAdornerPainter() As LayoutPanelAdornerPainterBase
            Return New TablePanelAdornerPainter()
        End Function

        Protected Overrides Function CalculateAdornerObject() As LayoutPanelAdornerObject
            If targetCell Is Nothing Then Return NullLayoutPanelAdornerObject.Instance
            Return New TablePanelAdornerObject(targetCell.Bounds)
        End Function

        Public Overloads ReadOnly Property LayoutPanel As TablePanel
            Get
                Return CType(MyBase.LayoutPanel, TablePanel)
            End Get
        End Property
    End Class
End Namespace

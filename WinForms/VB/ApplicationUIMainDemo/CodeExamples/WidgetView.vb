Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Widget
Imports DevExpress.XtraEditors

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("WidgetView via code", "WidgetView.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("WidgetView", "StackGroup", "UserControl", "DocumentContent", "Document", "Orientation", "LengthUnitType", "DocumentManager", "XtraUserControl", "RowDefinition", "ColumnDefinition", "Color", "Pen", "SolidBrush", "StringFormat", "StringAlignment", "StringTrimming", "StringFormatFlags", "ControlStyles", "PaintEventArgs", "Panel")>
    Public Module WidgetLayout

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim documentManager As DevExpress.XtraBars.Docking2010.DocumentManager = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Dim documentManagerHost As DevExpress.XtraEditors.XtraUserControl = New DevExpress.XtraEditors.XtraUserControl()
            documentManagerHost.Parent = sampleHost
            documentManagerHost.Dock = System.Windows.Forms.DockStyle.Fill
            Return New Object() {documentManager, documentManagerHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim documentManager = DevExpress.XtraBars.Docking2010.DocumentManager.FromControl(sampleHost)
            If documentManager IsNot Nothing Then documentManager = Nothing
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create WidgetView")>
        Public Sub CreateWidgetView(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup())
            view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"})
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Using maximized Control", New System.Type() {GetType(Examples.WidgetLayout.DocumentContent)})>
        Public Sub UsingMaximizedControl(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup())
            Dim document = TryCast(view.AddDocument(New Examples.WidgetLayout.DocumentContent() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            document.MaximizedControl = New Examples.WidgetLayout.DocumentContent() With {.Text = "Maximized control"}
            view.Controller.Maximize(document)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create Vertical StackLayout"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Stack Layout")>
        Public Sub CreateVerticalStackGroup(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup())
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim group1 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup()
            view.StackGroups.Add(group1)
            view.Controller.Dock(document2, group1)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create Horizontal StackLayout"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Stack Layout")>
        Public Sub CreateHorizontalStackGroup(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup())
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            view.Orientation = System.Windows.Forms.Orientation.Horizontal
            Dim group As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup()
            view.StackGroups.Add(group)
            view.Controller.Dock(document2, group)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Dragging StackGroup"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Stack Layout")>
        Public Sub DraggingStackGroup(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            view.AllowStartupAnimation = DevExpress.Utils.DefaultBoolean.[False]
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup() With {.Caption = "StackGroup1"})
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim group As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup() With {.Caption = "StackGroup2"}
            view.StackGroups.Add(group)
            view.Controller.Dock(document2, group)
            view.BeginUpdateAnimation()
            view.StackGroups.Remove(group)
            view.StackGroups.Insert(0, group)
            view.EndUpdateAnimation()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize Document in StackLayout"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Stack Layout")>
        Public Sub ResizeDocumentInStackLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup())
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            document1.Height = 300
            Dim group As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup()
            view.StackGroups.Add(group)
            view.Controller.Dock(document2, group)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize StackGroup"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Stack Layout")>
        Public Sub ResizeStackGroup(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup())
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim group As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup()
            group.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            group.Length.UnitValue = 200
            view.StackGroups.Add(group)
            view.Controller.Dock(document2, group)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create TableLayout", New System.Type() {GetType(Examples.WidgetLayout.DefaultWidgetViewCreator)}), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Table Layout")>
        Public Sub CreateTableLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WidgetLayout.DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout
            Dim document = TryCast(view.Documents(1), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout
            view.Rows.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition())
            view.Rows.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition())
            view.Columns.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition())
            view.Columns.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition())
            document.RowIndex = 1
            document.ColumnIndex = 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize Document", New System.Type() {GetType(Examples.WidgetLayout.DefaultWidgetViewCreator)}), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Table Layout")>
        Public Sub ResizeDocumentInTableLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WidgetLayout.DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout
            Dim document = TryCast(view.Documents(1), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout
            view.Rows.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition())
            view.Rows.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition())
            view.Columns.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition())
            view.Columns.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition())
            document.RowIndex = 1
            document.ColumnIndex = 0
            document.ColumnSpan = 2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize TableLayout"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Table Layout")>
        Public Sub ResizeTableLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            document2.RowIndex = 0
            document2.ColumnIndex = 1
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout
            view.Rows.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition())
            view.Rows.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition())
            view.Columns.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition())
            view.Columns.Add(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition())
            Dim column = view.Columns(1)
            column.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            column.Length.UnitValue = 150
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create FlowLayout"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Flow Layout")>
        Public Sub CreateFlowLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change FlowDirection", New System.Type() {GetType(Examples.WidgetLayout.DefaultWidgetViewCreator)}), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Flow Layout")>
        Public Sub ChangeFlowDirection(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WidgetLayout.DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout
            view.FlowLayoutProperties.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize Document", New System.Type() {GetType(Examples.WidgetLayout.DefaultWidgetViewCreator)}), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Flow Layout")>
        Public Sub ResizeDocumentInFlowLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WidgetLayout.DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout
            Dim document = TryCast(view.Documents(0), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            document.Width = 180
            document.Height = 180
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create FreeLayout"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Free Layout")>
        Public Sub CreateFreeLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document3 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document3"}), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            view.Orientation = System.Windows.Forms.Orientation.Horizontal
            document3.DockTo(document2, System.Windows.Forms.Orientation.Vertical)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create Document with fixed Length", New System.Type() {GetType(Examples.WidgetLayout.DefaultWidgetViewCreator)}), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Free Layout")>
        Public Sub CreateDocumentWithFixedLength(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim documentsCount As Integer = 3
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = Examples.WidgetLayout.DefaultWidgetViewCreator.Create(documentManager, ownerControl, documentsCount)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            view.Orientation = System.Windows.Forms.Orientation.Horizontal
            Dim document2 As DevExpress.XtraBars.Docking2010.Views.Widget.Document = TryCast(view.Documents(1), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            view.BeginUpdate()
            document2.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document2.FreeLayoutWidth.UnitValue = 150
            view.EndUpdate()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize Document", New System.Type() {GetType(Examples.WidgetLayout.DefaultWidgetViewCreator)}), DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Free Layout")>
        Public Sub ResizeDocumentInFreeLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim documentsCount As Integer = 3
            Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = Examples.WidgetLayout.DefaultWidgetViewCreator.Create(documentManager, ownerControl, documentsCount)
            view.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            view.Orientation = System.Windows.Forms.Orientation.Horizontal
            Dim document1 As DevExpress.XtraBars.Docking2010.Views.Widget.Document = TryCast(view.Documents(0), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim document2 As DevExpress.XtraBars.Docking2010.Views.Widget.Document = TryCast(view.Documents(1), DevExpress.XtraBars.Docking2010.Views.Widget.Document)
            Dim delta As Double = 0.2R
            document1.FreeLayoutWidth.UnitValue += delta
            document2.FreeLayoutWidth.UnitValue -= delta
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public NotInheritable Class DefaultWidgetViewCreator

            Public Shared Function Create(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl, ByVal Optional documentCount As Integer = 2) As WidgetView
                Dim view As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView()
                documentManager.View = view
                documentManager.ViewCollection.Add(view)
                documentManager.ContainerControl = ownerControl
                For i As Integer = 0 To documentCount - 1
                    view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document" & (i + 1)})
                Next

                Return view
            End Function
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class DocumentContent
            Inherits System.Windows.Forms.Panel

            Private Shared currentColor As Integer

            Private Shared forecolors As System.Drawing.Color() = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Green}

            Private sb As System.Drawing.SolidBrush

            Private pen As System.Drawing.Pen

            Private sf As System.Drawing.StringFormat

            Private Shared _font As System.Drawing.Font = New System.Drawing.Font("Segoe UI", 24F)

            Public Sub New()
                Me.sf = New System.Drawing.StringFormat() With {.Alignment = System.Drawing.StringAlignment.Center, .LineAlignment = System.Drawing.StringAlignment.Center, .Trimming = System.Drawing.StringTrimming.EllipsisCharacter, .FormatFlags = System.Drawing.StringFormatFlags.NoWrap}
                Me.DoubleBuffered = True
                Me.ForeColor = Examples.WidgetLayout.DocumentContent.forecolors((System.Math.Min(System.Threading.Interlocked.Increment(Examples.WidgetLayout.DocumentContent.currentColor), Examples.WidgetLayout.DocumentContent.currentColor - 1)) Mod Examples.WidgetLayout.DocumentContent.forecolors.Length)
                Me.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint Or System.Windows.Forms.ControlStyles.UserPaint, True)
                Me.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw Or System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, True)
            End Sub

            Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
                If Me.sb Is Nothing Then Me.sb = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(100, Me.ForeColor))
                If Me.pen Is Nothing Then Me.pen = New System.Drawing.Pen(System.Drawing.Color.FromArgb(200, 221, 223, 223))
                e.Graphics.FillRectangle(Me.sb, Me.ClientRectangle)
                e.Graphics.DrawString(Me.Text, Examples.WidgetLayout.DocumentContent._font, Me.sb, Me.ClientRectangle, Me.sf)
            End Sub
        End Class
    End Module
End Namespace

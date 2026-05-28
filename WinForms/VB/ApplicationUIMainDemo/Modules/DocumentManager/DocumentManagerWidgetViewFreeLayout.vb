Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DocumentManagerWidgetViewFreeLayout
        Inherits TutorialControlBase

        Private widgetView1 As XtraBars.Docking2010.Views.Widget.WidgetView

        Private documentManager1 As XtraBars.Docking2010.DocumentManager

        Private document1 As XtraBars.Docking2010.Views.Widget.Document

        Private document3 As XtraBars.Docking2010.Views.Widget.Document

        Private document2 As XtraBars.Docking2010.Views.Widget.Document

        Private document4 As XtraBars.Docking2010.Views.Widget.Document

        Private document5 As XtraBars.Docking2010.Views.Widget.Document

        Private document6 As XtraBars.Docking2010.Views.Widget.Document

        Private document7 As XtraBars.Docking2010.Views.Widget.Document

        Private document8 As XtraBars.Docking2010.Views.Widget.Document

        Private document9 As XtraBars.Docking2010.Views.Widget.Document

        Private components As System.ComponentModel.IContainer

        Public Sub New()
            InitializeComponent()
            AddHandler documentManager1.View.QueryControl, AddressOf OnViewQueryControl
        End Sub

        Private Sub OnViewQueryControl(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.QueryControlEventArgs)
            Dim typeName As String = e.Document.ControlTypeName
            If Equals(typeName, "DevExpress.ApplicationUI.Demos.ucCardWidget") Then
                Dim smallWidget = New ucCardWidget()
                smallWidget.Price = TutorialConstants.Random.Next(100, 1000)
                smallWidget.PPrice = TutorialConstants.Random.NextDouble() - TutorialConstants.Random.NextDouble()
                smallWidget.Delta = TutorialConstants.Random.Next(-50, 100) + TutorialConstants.Random.NextDouble()
                e.Control = smallWidget
                Return
            End If

            If Not String.IsNullOrEmpty(typeName) Then
                Dim controlType = Data.Internal.SafeTypeResolver.GetKnownType(GetType(Program).Assembly, typeName)
                e.Control = TryCast(Activator.CreateInstance(controlType), Control)
            Else
                e.Control = New Control()
            End If
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim widgetDockingContainer1 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer2 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer3 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer4 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer5 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer6 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer7 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer8 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer9 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer10 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer11 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer12 As XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            document9 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document2 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document1 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document3 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document5 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document4 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document6 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document7 = New XtraBars.Docking2010.Views.Widget.Document(components)
            document8 = New XtraBars.Docking2010.Views.Widget.Document(components)
            documentManager1 = New XtraBars.Docking2010.DocumentManager(components)
            widgetView1 = New XtraBars.Docking2010.Views.Widget.WidgetView(components)
            CType(document9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(widgetView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' document9
            ' 
            document9.Caption = "Clock"
            document9.ControlName = "Clock"
            document9.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock"
            document9.FreeLayoutHeight.UnitValue = 0.45R
            document9.FreeLayoutWidth.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document9.FreeLayoutWidth.UnitValue = 220R
            ' 
            ' document2
            ' 
            document2.Caption = "Calendar"
            document2.ControlName = "Calendar"
            document2.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar"
            document2.FreeLayoutHeight.UnitValue = 1.55R
            document2.FreeLayoutWidth.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document2.FreeLayoutWidth.UnitValue = 220R
            ' 
            ' document1
            ' 
            document1.Caption = "Products"
            document1.ControlName = "ProductsGridEx"
            document1.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsBorderlessGrid"
            document1.Properties.ShowBorders = Utils.DefaultBoolean.False
            ' 
            ' document3
            ' 
            document3.Caption = "Locations"
            document3.ControlName = "ChoroplethMapItem"
            document3.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem"
            document3.FreeLayoutHeight.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document3.FreeLayoutHeight.UnitValue = 230R
            ' 
            ' document5
            ' 
            document5.Caption = "Profit YTD"
            document5.ControlName = "CardWidget2"
            document5.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            document5.FreeLayoutWidth.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document5.FreeLayoutWidth.UnitValue = 220R
            document5.Properties.AllowMaximize = Utils.DefaultBoolean.False
            ' 
            ' document4
            ' 
            document4.Caption = "Exprense YTD"
            document4.ControlName = "CardWidget1"
            document4.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            document4.FreeLayoutWidth.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document4.FreeLayoutWidth.UnitValue = 220R
            document4.Properties.AllowMaximize = Utils.DefaultBoolean.False
            ' 
            ' document6
            ' 
            document6.Caption = "New Customers"
            document6.ControlName = "CardWidget3"
            document6.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            document6.FreeLayoutWidth.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document6.FreeLayoutWidth.UnitValue = 220R
            document6.Properties.AllowMaximize = Utils.DefaultBoolean.False
            ' 
            ' document7
            ' 
            document7.Caption = "Market Share"
            document7.ControlName = "CardWidget4"
            document7.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            document7.FreeLayoutWidth.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document7.FreeLayoutWidth.UnitValue = 220R
            document7.Properties.AllowMaximize = Utils.DefaultBoolean.False
            ' 
            ' document8
            ' 
            document8.Caption = "Avg Order Size"
            document8.ControlName = "CardWidget5"
            document8.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            document8.FreeLayoutWidth.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            document8.FreeLayoutWidth.UnitValue = 220R
            document8.Properties.AllowMaximize = Utils.DefaultBoolean.False
            ' 
            ' documentManager1
            ' 
            documentManager1.ContainerControl = Me
            documentManager1.ShowThumbnailsInTaskBar = Utils.DefaultBoolean.False
            documentManager1.View = widgetView1
            documentManager1.ViewCollection.AddRange(New XtraBars.Docking2010.Views.BaseView() {widgetView1})
            ' 
            ' widgetView1
            ' 
            widgetView1.Documents.AddRange(New XtraBars.Docking2010.Views.BaseDocument() {document1, document2, document3, document4, document5, document6, document7, document8, document9})
            widgetView1.FreeLayoutProperties.FreeLayoutItems.AddRange(New XtraBars.Docking2010.Views.Widget.Document() {document1, document2, document3, document4, document5, document6, document7, document8, document9})
            widgetView1.FreeLayoutProperties.ItemDragStyle = XtraBars.Docking2010.Views.Widget.ItemDragStyle.DockingHints
            widgetView1.LayoutMode = XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            widgetView1.Orientation = Orientation.Horizontal
            widgetDockingContainer2.Element = document9
            widgetDockingContainer3.Element = document2
            widgetDockingContainer1.Nodes.AddRange(New XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer2, widgetDockingContainer3})
            widgetDockingContainer1.Orientation = Orientation.Vertical
            widgetDockingContainer1.Size.Width.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            widgetDockingContainer1.Size.Width.UnitValue = 260R
            widgetDockingContainer5.Element = document1
            widgetDockingContainer6.Element = document3
            widgetDockingContainer4.Nodes.AddRange(New XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer5, widgetDockingContainer6})
            widgetDockingContainer4.Orientation = Orientation.Vertical
            widgetDockingContainer8.Element = document5
            widgetDockingContainer9.Element = document4
            widgetDockingContainer10.Element = document6
            widgetDockingContainer11.Element = document7
            widgetDockingContainer12.Element = document8
            widgetDockingContainer7.Nodes.AddRange(New XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer8, widgetDockingContainer9, widgetDockingContainer10, widgetDockingContainer11, widgetDockingContainer12})
            widgetDockingContainer7.Orientation = Orientation.Vertical
            widgetDockingContainer7.Size.Width.UnitType = XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            widgetDockingContainer7.Size.Width.UnitValue = 180R
            widgetView1.RootContainer.Nodes.AddRange(New XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer1, widgetDockingContainer4, widgetDockingContainer7})
            ' 
            ' DocumentManagerWidgetViewFreeLayout
            ' 
            Name = "DocumentManagerWidgetViewFreeLayout"
            Size = New System.Drawing.Size(778, 409)
            CType(document9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(widgetView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub
    End Class
End Namespace
